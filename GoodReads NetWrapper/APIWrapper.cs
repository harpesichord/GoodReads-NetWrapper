using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestSharp;

namespace GoodReads_NetWrapper
{
    internal class APIWrapper
    {
        private const string HOST = "https://www.goodreads.com";

        /// <summary>
        /// Calls the API Endpoint.
        /// </summary>
        /// <param name="endpoint">The endpoint.</param>
        /// <param name="httpMethod">The HTTP method.</param>
        /// <param name="DeveloperKey">The developer key.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        internal static object CallAPI(string endpoint, string httpMethod, string DeveloperKey, Dictionary<string, object> parameters)
        {
            if (httpMethod == "GET")
                return GetCall(endpoint, DeveloperKey, parameters);

            throw new NotImplementedException();
        }

        /// <summary>
        /// Adds the developer key to the request.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="DeveloperKey">The developer key.</param>
        private static void AddDeveloperKey(ref RestRequest request, string DeveloperKey)
        {
            request.AddParameter("key", DeveloperKey);
        }

        /// <summary>
        /// Adds the parameters to the request.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="parameters">The parameters.</param>
        private static void AddParameters(ref RestRequest request, Dictionary<string, object> parameters)
        {
            foreach (string key in parameters.Keys)
            {
                request.AddParameter(key, parameters[key]);
            }
        }

        /// <summary>
        /// Gets the call.
        /// </summary>
        /// <param name="endpoint">The endpoint.</param>
        /// <param name="DeveloperKey">The developer key.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        private static object GetCall(string endpoint, string DeveloperKey, Dictionary<string, object> parameters)
        {
            RestClient client = new RestClient(HOST);
            RestRequest request = new RestRequest(endpoint, Method.GET);
            AddParameters(ref request, parameters);
            AddDeveloperKey(ref request, DeveloperKey);

            IRestResponse response = client.Execute(request);
            var content = response.Content;

            return content;
        }
    }
}