﻿using System.Net;
using System.Threading.Tasks;
using StackifyLib.Internal.Auth.Claims;
using StackifyLib.Models;

namespace StackifyLib.Internal.StackifyApi
{
    internal interface IStackifyApiService
    {
        /// <summary>
        /// Uploads data to Stackify's API
        /// </summary>
        /// <param name="claims">What app should this data be uploaded on behalf of</param>
        /// <param name="uri">The request route URI</param>
        /// <param name="data">Data to upload</param>        
        /// <param name="compress">Compress the data?</param>
        /// <returns>
        /// HttpStatusCode of API response. A value of zero (0) indicates the service refused to send the request.
        /// </returns>
        Task<HttpStatusCode> UploadAsync(AppClaims claims, string uri, Identifiable data, bool compress = false);
    }
}
