using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;

namespace Twilio.Rest.Api.V2010.Account.Recording 
{

    public class TranscriptionResource : Resource 
    {
        public sealed class StatusEnum : StringEnum 
        {
            private StatusEnum(string value) : base(value) {}
            public StatusEnum() {}
        
            public static readonly StatusEnum InProgress = new StatusEnum("in-progress");
            public static readonly StatusEnum Completed = new StatusEnum("completed");
            public static readonly StatusEnum Failed = new StatusEnum("failed");
        }
    
        private static Request BuildFetchRequest(FetchTranscriptionOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.AccountSid ?? client.AccountSid) + "/Recordings/" + options.RecordingSid + "/Transcriptions/" + options.Sid + ".json",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="options"> Fetch Transcription parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Transcription </returns> 
        public static TranscriptionResource Fetch(FetchTranscriptionOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
    
        #if NET40
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="options"> Fetch Transcription parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Transcription </returns> 
        public static async System.Threading.Tasks.Task<TranscriptionResource> FetchAsync(FetchTranscriptionOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
    
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="recordingSid"> The recording_sid </param>
        /// <param name="sid"> The sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Transcription </returns> 
        public static TranscriptionResource Fetch(string recordingSid, string sid, string accountSid = null, ITwilioRestClient client = null)
        {
            var options = new FetchTranscriptionOptions(recordingSid, sid){AccountSid = accountSid};
            return Fetch(options, client);
        }
    
        #if NET40
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="recordingSid"> The recording_sid </param>
        /// <param name="sid"> The sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Transcription </returns> 
        public static async System.Threading.Tasks.Task<TranscriptionResource> FetchAsync(string recordingSid, string sid, string accountSid = null, ITwilioRestClient client = null)
        {
            var options = new FetchTranscriptionOptions(recordingSid, sid){AccountSid = accountSid};
            return await FetchAsync(options, client);
        }
        #endif
    
        private static Request BuildDeleteRequest(DeleteTranscriptionOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.AccountSid ?? client.AccountSid) + "/Recordings/" + options.RecordingSid + "/Transcriptions/" + options.Sid + ".json",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// delete
        /// </summary>
        ///
        /// <param name="options"> Delete Transcription parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Transcription </returns> 
        public static bool Delete(DeleteTranscriptionOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
    
        #if NET40
        /// <summary>
        /// delete
        /// </summary>
        ///
        /// <param name="options"> Delete Transcription parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Transcription </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteTranscriptionOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif
    
        /// <summary>
        /// delete
        /// </summary>
        ///
        /// <param name="recordingSid"> The recording_sid </param>
        /// <param name="sid"> The sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Transcription </returns> 
        public static bool Delete(string recordingSid, string sid, string accountSid = null, ITwilioRestClient client = null)
        {
            var options = new DeleteTranscriptionOptions(recordingSid, sid){AccountSid = accountSid};
            return Delete(options, client);
        }
    
        #if NET40
        /// <summary>
        /// delete
        /// </summary>
        ///
        /// <param name="recordingSid"> The recording_sid </param>
        /// <param name="sid"> The sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Transcription </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string recordingSid, string sid, string accountSid = null, ITwilioRestClient client = null)
        {
            var options = new DeleteTranscriptionOptions(recordingSid, sid){AccountSid = accountSid};
            return await DeleteAsync(options, client);
        }
        #endif
    
        private static Request BuildReadRequest(ReadTranscriptionOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.AccountSid ?? client.AccountSid) + "/Recordings/" + options.RecordingSid + "/Transcriptions.json",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="options"> Read Transcription parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Transcription </returns> 
        public static ResourceSet<TranscriptionResource> Read(ReadTranscriptionOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            
            var page = Page<TranscriptionResource>.FromJson("transcriptions", response.Content);
            return new ResourceSet<TranscriptionResource>(page, options, client);
        }
    
        #if NET40
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="options"> Read Transcription parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Transcription </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<TranscriptionResource>> ReadAsync(ReadTranscriptionOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));
            
            var page = Page<TranscriptionResource>.FromJson("transcriptions", response.Content);
            return new ResourceSet<TranscriptionResource>(page, options, client);
        }
        #endif
    
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="recordingSid"> The recording_sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Transcription </returns> 
        public static ResourceSet<TranscriptionResource> Read(string recordingSid, string accountSid = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadTranscriptionOptions(recordingSid){AccountSid = accountSid, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }
    
        #if NET40
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="recordingSid"> The recording_sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Transcription </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<TranscriptionResource>> ReadAsync(string recordingSid, string accountSid = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadTranscriptionOptions(recordingSid){AccountSid = accountSid, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        ///
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns> 
        public static Page<TranscriptionResource> NextPage(Page<TranscriptionResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Api,
                    client.Region
                )
            );
            
            var response = client.Request(request);
            return Page<TranscriptionResource>.FromJson("transcriptions", response.Content);
        }
    
        /// <summary>
        /// Converts a JSON string into a TranscriptionResource object
        /// </summary>
        ///
        /// <param name="json"> Raw JSON string </param>
        /// <returns> TranscriptionResource object represented by the provided JSON </returns> 
        public static TranscriptionResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<TranscriptionResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }
    
        /// <summary>
        /// The account_sid
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The api_version
        /// </summary>
        [JsonProperty("api_version")]
        public string ApiVersion { get; private set; }
        /// <summary>
        /// The date_created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The date_updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// The duration
        /// </summary>
        [JsonProperty("duration")]
        public string Duration { get; private set; }
        /// <summary>
        /// The price
        /// </summary>
        [JsonProperty("price")]
        public decimal? Price { get; private set; }
        /// <summary>
        /// The price_unit
        /// </summary>
        [JsonProperty("price_unit")]
        public string PriceUnit { get; private set; }
        /// <summary>
        /// The recording_sid
        /// </summary>
        [JsonProperty("recording_sid")]
        public string RecordingSid { get; private set; }
        /// <summary>
        /// The sid
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The status
        /// </summary>
        [JsonProperty("status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public TranscriptionResource.StatusEnum Status { get; private set; }
        /// <summary>
        /// The transcription_text
        /// </summary>
        [JsonProperty("transcription_text")]
        public string TranscriptionText { get; private set; }
        /// <summary>
        /// The type
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; private set; }
        /// <summary>
        /// The uri
        /// </summary>
        [JsonProperty("uri")]
        public string Uri { get; private set; }
    
        private TranscriptionResource()
        {
        
        }
    }

}