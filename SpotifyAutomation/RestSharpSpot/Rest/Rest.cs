using RestSharp;
using RestSharpSpot.Api.Extensions;
using System;
using System.Collections.Generic;

namespace RestSharpSpot.API
{
    public class Rest
    {
        private readonly string _baseUrl;
        private readonly string _key;

        public Rest(string baseUrl, string key)
        {
            _baseUrl = baseUrl;
            _key = key;
            InitiateRestClient();
        }

        public RestRequest RestRequest { get; set; }

        public RestClient RestClient { get; set; }

        private void InitiateRestClient()
        {
            RestClient = new RestClient(_baseUrl);
        }

        public void CreateRestRequest(string resource, Method method = Method.GET)
        {
            RestRequest = new RestRequest(resource, method, DataFormat.Json);
            SetRequestToken();
            //SetContentTypeToJson();
        }

        public void SetContentTypeToJson()
        {
            RestRequest.RequestFormat = DataFormat.Json;
            RestRequest.OnBeforeDeserialization = resp => resp.ContentType = "application/json";
        }

        private void SetRequestToken()
        {
            RestRequest.AddHeader("Authorization", $"Bearer {_key}");
        }

        private IRestResponse<T> ExecuteAndGetResponseDetails<T>() where T : new()
        {
            IRestResponse<T> response = RestClient.Execute<T>(RestRequest);
            if (!response.IsSuccessful)
            {
                throw new Exception(response.ErrorMessage + response.Content);
            }
            return response;
        }

        public T Execute<T>() where T : new()
        {
            IRestResponse<T> response = RestClient.Execute<T>(RestRequest);
            if (!response.IsSuccessful)
            {
                throw new Exception(response.ErrorMessage + response.Content);
            }
            return response.Data;
        }

        public T SendRequestAndGetData<T>(string resource) where T : new()
        {
            CreateRestRequest(resource);
            return Execute<T>();
        }

        public T SendRequestAndGetData<T>(string resource, Dictionary<string, string> queryParameters) where T : new()
        {
            CreateRestRequest(resource);
            RestRequest.AddQueryParameters(queryParameters);
            return Execute<T>();
        }

        public T SendRequestAndGetData<T>(string resource, KeyValuePair<string, string> urlSegmentParameter) where T : new()
        {
            CreateRestRequest(resource);
            RestRequest.AddUrlSegment(urlSegmentParameter.Key, urlSegmentParameter.Value);
            return Execute<T>();
        }

        public T SendRequestAndGetData<T>(string resource, KeyValuePair<string, string> queryParameter, KeyValuePair<string, string> urlSegmentParameter) where T : new()
        {
            CreateRestRequest(resource);
            RestRequest.AddUrlSegment(urlSegmentParameter.Key, urlSegmentParameter.Value);
            RestRequest.AddQueryParameter(queryParameter.Key, queryParameter.Value);
            return Execute<T>();
        }

        public T SendRequestAndGetData<T>(string resource, Dictionary<string, string> queryParameters, KeyValuePair<string, string> urlSegmentParameter, Method method = Method.GET) where T : new()
        {
            CreateRestRequest(resource);
            RestRequest.AddUrlSegment(urlSegmentParameter.Key, urlSegmentParameter.Value);
            RestRequest.AddQueryParameters(queryParameters);
            return Execute<T>();
        }

        public IRestResponse<T> SendRequestAndGetResponse<T>(string resource, Method method = Method.PUT) where T : new()
        {
            CreateRestRequest(resource, method);
            return ExecuteAndGetResponseDetails<T>();
        }

        public IRestResponse<T> SendRequestAndGetResponse<T>(string resource, Dictionary<string, string> queryParameters, Method method = Method.PUT) where T : new()
        {
            CreateRestRequest(resource, method);
            RestRequest.AddQueryParameters(queryParameters);
            return ExecuteAndGetResponseDetails<T>();
        }

        public IRestResponse<T> SendRequestAndGetResponse<T>(string resource, KeyValuePair<string, string> queryParameter, Method method = Method.PUT) where T : new()
        {
            CreateRestRequest(resource, method);
            RestRequest.AddQueryParameter(queryParameter.Key, queryParameter.Value);
            return ExecuteAndGetResponseDetails<T>();
        }

        public IRestResponse<T> SendRequestAndGetResponse<T>(string resource, Dictionary<string, string> queryParameters, KeyValuePair<string, string> urlSegmentParameter, Method method = Method.PUT) where T : new()
        {
            CreateRestRequest(resource, method);
            RestRequest.AddUrlSegment(urlSegmentParameter.Key, urlSegmentParameter.Value);
            RestRequest.AddQueryParameters(queryParameters);
            return ExecuteAndGetResponseDetails<T>();
        }
    }
}