/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Api.V2010.Account
{

    /// <summary>
    /// FetchKeyOptions
    /// </summary>
    public class FetchKeyOptions : IOptions<KeyResource>
    {
        /// <summary>
        /// The SID of the Account that created the resource to fetch
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchKeyOptions
        /// </summary>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        public FetchKeyOptions(string pathSid)
        {
            PathSid = pathSid;
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

    /// <summary>
    /// UpdateKeyOptions
    /// </summary>
    public class UpdateKeyOptions : IOptions<KeyResource>
    {
        /// <summary>
        /// The SID of the Account that created the resources to update
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// A string to describe the resource
        /// </summary>
        public string FriendlyName { get; set; }

        /// <summary>
        /// Construct a new UpdateKeyOptions
        /// </summary>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        public UpdateKeyOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            return p;
        }
    }

    /// <summary>
    /// DeleteKeyOptions
    /// </summary>
    public class DeleteKeyOptions : IOptions<KeyResource>
    {
        /// <summary>
        /// The SID of the Account that created the resources to delete
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteKeyOptions
        /// </summary>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        public DeleteKeyOptions(string pathSid)
        {
            PathSid = pathSid;
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

    /// <summary>
    /// ReadKeyOptions
    /// </summary>
    public class ReadKeyOptions : ReadOptions<KeyResource>
    {
        /// <summary>
        /// The SID of the Account that created the resources to read
        /// </summary>
        public string PathAccountSid { get; set; }

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