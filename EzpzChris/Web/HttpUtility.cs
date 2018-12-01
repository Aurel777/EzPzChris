namespace EzpzChris.Web
{
    #region Using Statements

    using System;
    using System.Collections.Specialized;
    using System.IO;
    using System.Net;
    using System.Net.Http;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    using Extensions;
    using Uri;

    #endregion

    class HttpUtility
    {
        public static async Task<string> GetSourcePageAfterLoginTaskAsync(string loginUrl, string nextUrl, NameValueCollection values)
        {
            var uri = UriHelper.GetUriFromUrl(loginUrl);

            if (string.IsNullOrWhiteSpace(uri.AbsoluteUri) || values?.Count == 0)
                throw new ArgumentNullException();


            using (var client = new WebClientWithCookies())
            {
                await client.UploadValuesTaskAsync(uri, HttpMethod.Get.GetDescription(), values).ConfigureAwait(true);
                return await client.DownloadStringTaskAsync(nextUrl).ConfigureAwait(true);
            }
        }

        public async Task<string> LoginTaskAsync(string domainName, string loginUrl, string domainUrl, string postData)
        {
            var data = new ASCIIEncoding().GetBytes(postData);
            var cookies = new CookieContainer();
            Stream responseStream = null;
            try
            {
                var request = (HttpWebRequest) WebRequest.Create(domainUrl);
                request.ServerCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;
                var response = (HttpWebResponse) request.GetResponse();
                cookies.Add(response.Cookies);
                var sessionCookie = response.Headers["Set-Cookie"];
                responseStream = response.GetResponseStream();
                var responseCookie = sessionCookie.Substring(0, sessionCookie.IndexOf(';'));
                var cookieValues = responseCookie.Split('=');
                cookies.Add(new Cookie(cookieValues[0], cookieValues[1], "/", domainName));
                request = (HttpWebRequest) WebRequest.Create(loginUrl);
                request.Accept = "text / html,application / xhtml + xml,application / xml; q = 0.9,*/*;q=0.8";
                request.AllowAutoRedirect = true;
                request.CookieContainer = cookies;
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = data.Length;
                request.Credentials = CredentialCache.DefaultCredentials; // needed ?
                request.KeepAlive = true;
                request.Method = "POST";
                request.Proxy = new WebProxy();
                request.ReadWriteTimeout = 10000;
                request.Referer = domainUrl;
                request.Timeout = 10000;
                request.UserAgent ="Agent: Mozilla / 5.0(Windows NT 10.0; Win64; x64; rv: 62.0) Gecko / 20100101 Firefox / 62.0";

                request.Headers["Accept-Language"] = "en-US,en;q=0.5";
                request.Headers["Accept-Encoding"] = "gzip, deflate, br";
                request.Headers["DNT"] = "1";
                request.Headers["Upgrade-Insecure-Requests"] = "1";

                await request.GetRequestStream().WriteAsync(data, 0, data.Length).ConfigureAwait(false);
                request.GetRequestStream().Close();
                response = (HttpWebResponse) await request.GetResponseAsync().ConfigureAwait(false);
                return await GetResponseStreamAsStringTaskAsync(response).ConfigureAwait(false);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, @"Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
            finally
            {
                responseStream?.Dispose();
            }
        }

        public async Task<HttpResponseMessage> DoRequestTaskAsync(string url, HttpMethod method, HttpContent content = null)
        {
            var uri = UriHelper.GetUriFromUrl(url);

            if (string.IsNullOrWhiteSpace(uri.AbsoluteUri))
                throw new ArgumentNullException();

            var response = new Task<HttpResponseMessage>(null);

            using (var client = new HttpClient())
            {
                try
                {
                    switch (method)
                    {
                        case HttpMethod.Connect:
                            break;
                        case HttpMethod.Delete:
                            await client.DeleteAsync(uri).ConfigureAwait(false);
                            break;
                        case HttpMethod.Get:
                            response = client.GetAsync(uri, HttpCompletionOption.ResponseContentRead);
                            await response.ConfigureAwait(false);
                            break;
                        case HttpMethod.Post:
                            response = client.PostAsync(uri, content);
                            await response.ConfigureAwait(false);
                            break;
                        case HttpMethod.Put:
                            response = client.PutAsync(uri, content);
                            await response.ConfigureAwait(false);
                            break;
                        case HttpMethod.Head:
                            break;
                        case HttpMethod.Trace:
                            break;
                        default:
                            throw new ArgumentOutOfRangeException(nameof(method), method, null);
                    }
                }
                finally
                {
                    client.Dispose();
                }
            }

            return response.Result;
        }

        public async Task<HttpResponseMessage> PostRequestTaskAsync(string url, string postData)
        {
            if (string.IsNullOrWhiteSpace(url.Trim()) || string.IsNullOrWhiteSpace(postData))
                return null;

            using (var client = new HttpClient())
            {
                HttpResponseMessage responseMessage = null;

                try
                {
                    var content = new StringContent(postData, Encoding.UTF8);
                    responseMessage = await client.PostAsync(url, content).ConfigureAwait(false);
                }
                catch (Exception exception)
                {
                    if (responseMessage == null)
                        responseMessage = new HttpResponseMessage();

                    responseMessage.StatusCode = HttpStatusCode.InternalServerError;
                    responseMessage.ReasonPhrase = $"RestHttpClient.SendRequest failed: {exception}";
                }
                finally
                {
                    responseMessage?.Dispose();
                }

                return responseMessage;
            }
        }

        static async Task<string> GetResponseStreamAsStringTaskAsync(WebResponse response)
        {
            using (var responseStream = response.GetResponseStream())
            {
                if (responseStream == null)
                    return string.Empty;

                using (var responseReader = new StreamReader(responseStream, Encoding.UTF8, true))
                {
                    var readerTask = responseReader.ReadToEndAsync();
                    await readerTask.ConfigureAwait(false);
                    return readerTask.Result;
                }
            }
        }
    }
}
