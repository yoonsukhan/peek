﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace BillingWebJob.Models
{
    public static partial class CspUsageLineItemCollection
    {
        /// <summary>
        /// Deserialize the object
        /// </summary>
        public static IList<CspUsageLineItem> DeserializeJson(JToken inputObject)
        {
            IList<CspUsageLineItem> deserializedObject = new List<CspUsageLineItem>();
            foreach (JToken iListValue in ((JArray) inputObject))
            {
                CspUsageLineItem cspUsageLineItem = new CspUsageLineItem();
                cspUsageLineItem.DeserializeJson(iListValue);
                deserializedObject.Add(cspUsageLineItem);
            }
            return deserializedObject;
        }
    }
}