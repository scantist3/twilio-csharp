using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Taskrouter.V1.Workspace 
{

    public class EventResource : Resource 
    {
        private static Request BuildFetchRequest(FetchEventOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Taskrouter,
                "/v1/Workspaces/" + options.WorkspaceSid + "/Events/" + options.Sid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="options"> Fetch Event parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Event </returns> 
        public static EventResource Fetch(FetchEventOptions options, ITwilioRestClient client = null)
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
        /// <param name="options"> Fetch Event parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Event </returns> 
        public static async System.Threading.Tasks.Task<EventResource> FetchAsync(FetchEventOptions options, ITwilioRestClient client = null)
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
        /// <param name="workspaceSid"> The workspace_sid </param>
        /// <param name="sid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Event </returns> 
        public static EventResource Fetch(string workspaceSid, string sid, ITwilioRestClient client = null)
        {
            var options = new FetchEventOptions(workspaceSid, sid);
            return Fetch(options, client);
        }
    
        #if NET40
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="workspaceSid"> The workspace_sid </param>
        /// <param name="sid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Event </returns> 
        public static async System.Threading.Tasks.Task<EventResource> FetchAsync(string workspaceSid, string sid, ITwilioRestClient client = null)
        {
            var options = new FetchEventOptions(workspaceSid, sid);
            return await FetchAsync(options, client);
        }
        #endif
    
        private static Request BuildReadRequest(ReadEventOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Taskrouter,
                "/v1/Workspaces/" + options.WorkspaceSid + "/Events",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="options"> Read Event parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Event </returns> 
        public static ResourceSet<EventResource> Read(ReadEventOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            
            var page = Page<EventResource>.FromJson("events", response.Content);
            return new ResourceSet<EventResource>(page, options, client);
        }
    
        #if NET40
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="options"> Read Event parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Event </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<EventResource>> ReadAsync(ReadEventOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));
            
            var page = Page<EventResource>.FromJson("events", response.Content);
            return new ResourceSet<EventResource>(page, options, client);
        }
        #endif
    
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="workspaceSid"> The workspace_sid </param>
        /// <param name="endDate"> The end_date </param>
        /// <param name="eventType"> The event_type </param>
        /// <param name="minutes"> The minutes </param>
        /// <param name="reservationSid"> The reservation_sid </param>
        /// <param name="startDate"> The start_date </param>
        /// <param name="taskQueueSid"> The task_queue_sid </param>
        /// <param name="taskSid"> The task_sid </param>
        /// <param name="workerSid"> The worker_sid </param>
        /// <param name="workflowSid"> The workflow_sid </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Event </returns> 
        public static ResourceSet<EventResource> Read(string workspaceSid, DateTime? endDate = null, string eventType = null, int? minutes = null, string reservationSid = null, DateTime? startDate = null, string taskQueueSid = null, string taskSid = null, string workerSid = null, string workflowSid = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadEventOptions(workspaceSid){EndDate = endDate, EventType = eventType, Minutes = minutes, ReservationSid = reservationSid, StartDate = startDate, TaskQueueSid = taskQueueSid, TaskSid = taskSid, WorkerSid = workerSid, WorkflowSid = workflowSid, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }
    
        #if NET40
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="workspaceSid"> The workspace_sid </param>
        /// <param name="endDate"> The end_date </param>
        /// <param name="eventType"> The event_type </param>
        /// <param name="minutes"> The minutes </param>
        /// <param name="reservationSid"> The reservation_sid </param>
        /// <param name="startDate"> The start_date </param>
        /// <param name="taskQueueSid"> The task_queue_sid </param>
        /// <param name="taskSid"> The task_sid </param>
        /// <param name="workerSid"> The worker_sid </param>
        /// <param name="workflowSid"> The workflow_sid </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Event </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<EventResource>> ReadAsync(string workspaceSid, DateTime? endDate = null, string eventType = null, int? minutes = null, string reservationSid = null, DateTime? startDate = null, string taskQueueSid = null, string taskSid = null, string workerSid = null, string workflowSid = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadEventOptions(workspaceSid){EndDate = endDate, EventType = eventType, Minutes = minutes, ReservationSid = reservationSid, StartDate = startDate, TaskQueueSid = taskQueueSid, TaskSid = taskSid, WorkerSid = workerSid, WorkflowSid = workflowSid, PageSize = pageSize, Limit = limit};
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
        public static Page<EventResource> NextPage(Page<EventResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Taskrouter,
                    client.Region
                )
            );
            
            var response = client.Request(request);
            return Page<EventResource>.FromJson("events", response.Content);
        }
    
        /// <summary>
        /// Converts a JSON string into a EventResource object
        /// </summary>
        ///
        /// <param name="json"> Raw JSON string </param>
        /// <returns> EventResource object represented by the provided JSON </returns> 
        public static EventResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<EventResource>(json);
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
        /// The actor_sid
        /// </summary>
        [JsonProperty("actor_sid")]
        public string ActorSid { get; private set; }
        /// <summary>
        /// The actor_type
        /// </summary>
        [JsonProperty("actor_type")]
        public string ActorType { get; private set; }
        /// <summary>
        /// The actor_url
        /// </summary>
        [JsonProperty("actor_url")]
        public Uri ActorUrl { get; private set; }
        /// <summary>
        /// The description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; private set; }
        /// <summary>
        /// The event_data
        /// </summary>
        [JsonProperty("event_data")]
        public Dictionary<string, string> EventData { get; private set; }
        /// <summary>
        /// The event_date
        /// </summary>
        [JsonProperty("event_date")]
        public DateTime? EventDate { get; private set; }
        /// <summary>
        /// The event_type
        /// </summary>
        [JsonProperty("event_type")]
        public string EventType { get; private set; }
        /// <summary>
        /// The resource_sid
        /// </summary>
        [JsonProperty("resource_sid")]
        public string ResourceSid { get; private set; }
        /// <summary>
        /// The resource_type
        /// </summary>
        [JsonProperty("resource_type")]
        public string ResourceType { get; private set; }
        /// <summary>
        /// The resource_url
        /// </summary>
        [JsonProperty("resource_url")]
        public Uri ResourceUrl { get; private set; }
        /// <summary>
        /// The sid
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The source
        /// </summary>
        [JsonProperty("source")]
        public string Source { get; private set; }
        /// <summary>
        /// The source_ip_address
        /// </summary>
        [JsonProperty("source_ip_address")]
        public string SourceIpAddress { get; private set; }
        /// <summary>
        /// The url
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }
    
        private EventResource()
        {
        
        }
    }

}