using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SXB.ICommonCLR
{
    public class XHttpClient
    {
        /// <summary>
        /// 根据参数集合拼凑json提交字符串
        /// </summary>
        /// <param name="datas"></param>
        /// <returns></returns>
        private static string CreateDataJson(IDictionary<string, object> datas = null)
        {
            if (datas == null)
                return string.Empty;

            var namevalues = datas.Select(d =>
                string.Format(@"""{0}"":{1}"
                , d.Key
                , d.Value==null
                    ? "null" 
                    :d.Value.GetType().IsByRef
                        ? ObjectToJson(d.Value)
                        : string.Format(@"""{0}""", (d.Value ?? "").ToString()))
                ).ToArray();

            return string.Format("{{{0}}}", string.Join(",", namevalues));
        }

        #region 对象序列化json-ObjectToJson
        /// <summary>
        /// ObjectToJson 对象序列化 返回json
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string ObjectToJson(object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
        #endregion

        /// <summary>
        /// GET
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="url"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static async Task<T> Get<T>(string url,IDictionary<string,object> data = null)
        {
            HttpClient httpclient = new HttpClient();
            HttpResponseMessage response = await httpclient.GetAsync(url);
            string responseBody = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(responseBody);
        }

        /// <summary>
        /// POST 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="url"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static async Task<T> Post<T>(string url,IDictionary<string,object> data=null)
        {
            using (HttpClient httpclient = new HttpClient())
            {
                HttpResponseMessage response = await httpclient.PostAsync(url, new StringContent(CreateDataJson(data)));
                string responseBody = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T>(responseBody);
            }
        }
    }
}
