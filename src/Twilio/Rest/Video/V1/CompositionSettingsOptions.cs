/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Video.V1
{

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    ///
    /// FetchCompositionSettingsOptions
    /// </summary>
    public class FetchCompositionSettingsOptions : IOptions<CompositionSettingsResource>
    {
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
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    ///
    /// CreateCompositionSettingsOptions
    /// </summary>
    public class CreateCompositionSettingsOptions : IOptions<CompositionSettingsResource>
    {
        /// <summary>
        /// Friendly name of the configuration to be shown in the console
        /// </summary>
        public string FriendlyName { get; }
        /// <summary>
        /// SID of the Stored Credential resource CRxx
        /// </summary>
        public string AwsCredentialsSid { get; set; }
        /// <summary>
        /// SID of the Public Key resource CRxx
        /// </summary>
        public string EncryptionKeySid { get; set; }
        /// <summary>
        /// Identity of the external location where the compositions should be stored. We only support DNS-compliant URLs like http://<my-bucket>.s3-<aws-region>.amazonaws.com/compositions, where compositions is the path where you want compositions to be stored.
        /// </summary>
        public Uri AwsS3Url { get; set; }
        /// <summary>
        /// true|false When set to true, all Compositions will be written to the AwsS3Url specified above. When set to false, all Compositions will be stored in Twilio's cloud.
        /// </summary>
        public bool? AwsStorageEnabled { get; set; }
        /// <summary>
        /// true|false When set to true, all Compositions will be stored encrypted.
        /// </summary>
        public bool? EncryptionEnabled { get; set; }

        /// <summary>
        /// Construct a new CreateCompositionSettingsOptions
        /// </summary>
        /// <param name="friendlyName"> Friendly name of the configuration to be shown in the console </param>
        public CreateCompositionSettingsOptions(string friendlyName)
        {
            FriendlyName = friendlyName;
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

            if (AwsCredentialsSid != null)
            {
                p.Add(new KeyValuePair<string, string>("AwsCredentialsSid", AwsCredentialsSid.ToString()));
            }

            if (EncryptionKeySid != null)
            {
                p.Add(new KeyValuePair<string, string>("EncryptionKeySid", EncryptionKeySid.ToString()));
            }

            if (AwsS3Url != null)
            {
                p.Add(new KeyValuePair<string, string>("AwsS3Url", Serializers.Url(AwsS3Url)));
            }

            if (AwsStorageEnabled != null)
            {
                p.Add(new KeyValuePair<string, string>("AwsStorageEnabled", AwsStorageEnabled.Value.ToString().ToLower()));
            }

            if (EncryptionEnabled != null)
            {
                p.Add(new KeyValuePair<string, string>("EncryptionEnabled", EncryptionEnabled.Value.ToString().ToLower()));
            }

            return p;
        }
    }

}