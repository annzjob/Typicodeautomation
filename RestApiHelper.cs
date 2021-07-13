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

        public static RestClient SetUrl(string endpoint)
        {
            var url = Path.Combine(baseURL, endpoint);
            return client = new RestClient(url);
        }
        public static RestClient SetUrlIdontexist(string endpoint)
        {
            var url = Path.Combine(baseURL, endpoint);
            return client = new RestClient(url+ "/idontexist/");

        }

        public static RestRequest GetRequest()
        {
            restRequest = new RestRequest(Method.GET);
            restRequest.AddHeader("Accept", "application/json");
            return restRequest;
        }
        public static RestRequest GetRequest(string Id)
        {
            var resource = Id;          
            restRequest = new RestRequest(resource,Method.GET);
            restRequest.AddHeader("Accept", "application/json");
            return restRequest;
        }
        public static RestRequest DeleteRequest(string Id)
        {
            var resource = Id;
            restRequest = new RestRequest(resource, Method.DELETE);
            restRequest.AddHeader("Accept", "application/json");
            return restRequest;
        }
        public static RestRequest ReplacePostRequest(string Id)
        {
            var resource = Id;
            restRequest = new RestRequest(resource, Method.PUT);
            restRequest.AddHeader("Accept", "application/json");
            return restRequest;
        }
        public static RestRequest PostDoesNotExist()
        {
            var resource = "/posts/idontexist/";
            restRequest = new RestRequest(resource,Method.GET);
            restRequest.AddHeader("Accept", "application/json");
            return restRequest;
        }

        public static IRestResponse GetResponse()
        {
            return client.Execute(restRequest);
            
        }

        public static RestRequest CreatePostRequest()
        {
            var PostInfo = new PostData();
            PostInfo.userId = 101;
            PostInfo.Title = "Foo";
            PostInfo.Body = "bar";
            var resource = "/posts/";
            restRequest = new RestRequest(resource, Method.POST);
            restRequest.RequestFormat = DataFormat.Json;
            restRequest.AddHeader("Content-Type", "application/json");
            restRequest.AddJsonBody(PostInfo);
            return restRequest;
        }




    }
}
