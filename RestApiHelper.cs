using System;
using System.Collections.Generic;
using System.Text;
using RestSharp;
using System.IO;


namespace TypiCodeProject
{
    public class RestApiHelper
    {
        public static RestClient client;
        public static RestRequest restRequest;
        public static string baseURL = "https://jsonplaceholder.typicode.com/";

        public static RestClient SetPostEndpoint(string endpoint)
        {
            var url = Path.Combine(baseURL, endpoint);
            return client = new RestClient(url);
        }

        public static RestRequest GetRequest()
        {
            restRequest = new RestRequest(Method.GET);
            restRequest.AddHeader("Accept", "application/json");
            return restRequest;
        }

        public RestApiHelper SetResourse(string resource)
        {
            restRequest.Resource = resource;
            return this;
        }

        public RestApiHelper SetMethod(Method method)
        {
            restRequest.Method = method;
            return this;
        }
        public RestApiHelper AddHeaders(IDictionary<string, string> headers)
        {
            foreach (var header in headers)
            {
                restRequest.AddParameter(header.Key, header.Value, ParameterType.HttpHeader);
            }
            return this;
        }

        public RestApiHelper AddJsonContent(object data)
        {
            restRequest.RequestFormat = DataFormat.Json;
            restRequest.AddHeader("Content-Type", "application/json");
            restRequest.AddJsonBody(data);
            return this;
        }

        

    }
}
