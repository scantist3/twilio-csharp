/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Taskrouter.V1.Workspace.TaskQueue
{

    /// <summary>
    /// FetchTaskQueueCumulativeStatisticsOptions
    /// </summary>
    public class FetchTaskQueueCumulativeStatisticsOptions : IOptions<TaskQueueCumulativeStatisticsResource>
    {
        /// <summary>
        /// The workspace_sid
        /// </summary>
        public string PathWorkspaceSid { get; }
        /// <summary>
        /// The task_queue_sid
        /// </summary>
        public string PathTaskQueueSid { get; }
        /// <summary>
        /// Filter cumulative statistics by an end date.
        /// </summary>
        public DateTime? EndDate { get; set; }
        /// <summary>
        /// Filter cumulative statistics by up to 'x' minutes in the past.
        /// </summary>
        public int? Minutes { get; set; }
        /// <summary>
        /// Filter cumulative statistics by a start date.
        /// </summary>
        public DateTime? StartDate { get; set; }
        /// <summary>
        /// Filter real-time and cumulative statistics by TaskChannel.
        /// </summary>
        public string TaskChannel { get; set; }
        /// <summary>
        /// A comma separated values for viewing splits of tasks canceled and accepted above the given threshold in seconds.
        /// </summary>
        public string SplitByWaitTime { get; set; }

        /// <summary>
        /// Construct a new FetchTaskQueueCumulativeStatisticsOptions
        /// </summary>
        /// <param name="pathWorkspaceSid"> The workspace_sid </param>
        /// <param name="pathTaskQueueSid"> The task_queue_sid </param>
        public FetchTaskQueueCumulativeStatisticsOptions(string pathWorkspaceSid, string pathTaskQueueSid)
        {
            PathWorkspaceSid = pathWorkspaceSid;
            PathTaskQueueSid = pathTaskQueueSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (EndDate != null)
            {
                p.Add(new KeyValuePair<string, string>("EndDate", Serializers.DateTimeIso8601(EndDate)));
            }

            if (Minutes != null)
            {
                p.Add(new KeyValuePair<string, string>("Minutes", Minutes.ToString()));
            }

            if (StartDate != null)
            {
                p.Add(new KeyValuePair<string, string>("StartDate", Serializers.DateTimeIso8601(StartDate)));
            }

            if (TaskChannel != null)
            {
                p.Add(new KeyValuePair<string, string>("TaskChannel", TaskChannel));
            }

            if (SplitByWaitTime != null)
            {
                p.Add(new KeyValuePair<string, string>("SplitByWaitTime", SplitByWaitTime));
            }

            return p;
        }
    }

}