using System;
using System.Collections.Generic;
using Twilio.Base;

namespace Twilio.Rest.Preview.Marketplace 
{

    public class FetchAvailableAddOnOptions : IOptions<AvailableAddOnResource> 
    {
        /// <summary>
        /// The unique Available Add-on Sid
        /// </summary>
        public string Sid { get; }
    
        /// <summary>
        /// Construct a new FetchAvailableAddOnOptions
        /// </summary>
        ///
        /// <param name="sid"> The unique Available Add-on Sid </param>
        public FetchAvailableAddOnOptions(string sid)
        {
            Sid = sid;
        }
    
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    public class ReadAvailableAddOnOptions : ReadOptions<AvailableAddOnResource> 
    {
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            
            return p;
        }
    }

}