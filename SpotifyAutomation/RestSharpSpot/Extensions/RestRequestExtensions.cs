using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpSpot.Api.Extensions
{
    public static class RestRequestExtensions
    {
        public static void AddQueryParameters(this RestRequest request, Dictionary<string, string> queryParameters)
        {
            foreach (var item in queryParameters)
            {
                if (!String.IsNullOrEmpty(item.Value))
                {
                    request.AddQueryParameter(item.Key, item.Value);
                }
            }
        }

        public static void AddParameters(this RestRequest request, Dictionary<string, string> queryParameters)
        {
            var dictionaryAsString = DictionaryIntoString(queryParameters);
            request.AddParameter("text/json", dictionaryAsString, ParameterType.RequestBody);
        }

        public static string DictionaryIntoString(Dictionary<string, string> dictionary)
        {
            StringBuilder sb = new StringBuilder("{");
            foreach (var item in dictionary)
            {
                if (!String.IsNullOrEmpty(item.Value))
                {
                    sb
                        .Append("\"")
                        .Append(item.Key)
                        .Append("\": ")
                        .Append(item.Value.ToLower())
                        .Append(",");
                }
            }
            sb.Remove(sb.Length - 1, 1);
            sb.Append("}");
            Console.WriteLine(sb.ToString());
            return sb.ToString();
        }
    }
}