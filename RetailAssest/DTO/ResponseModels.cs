using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace CMS_NC_BusinessUnit.DTO
{
    public class CustomResponse
    {
        /// <summary>
        /// Response Message - Eg: Record inserted successfully / Record updated successfully / No record found
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        private DateTime TimeStamp = DateTime.Now;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int Code { get; set; }
    }

    public class CustomResponse<T> : CustomResponse
    {
        /// <summary>
        /// Data returned by the api
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public T Data { get; set; }
    }
    public class ErrorResponse
    {
        public string Message { get; set; }
    }

    
   
  
}
