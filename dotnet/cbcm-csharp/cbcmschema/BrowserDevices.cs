﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using cbcmSchema.Browserdevices;
//
//    var browserDevices = BrowserDevices.FromJson(jsonString);

namespace cbcmSchema.Browserdevices
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class BrowserDevices
    {
        [JsonProperty("kind", NullValueHandling = NullValueHandling.Ignore)]
        public string Kind { get; set; }

        [JsonProperty("browsers", NullValueHandling = NullValueHandling.Ignore)]
        public List<BrowserDevicesBrowser> Browsers { get; set; }

        [JsonProperty("nextPageToken", NullValueHandling = NullValueHandling.Ignore)]
        public string NextPageToken { get; set; }
    }

    public partial class BrowserDevicesBrowser : IEquatable<BrowserDevicesBrowser>
    {
        [JsonProperty("deviceId", NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceId { get; set; }

        [JsonProperty("lastPolicyFetchTime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? LastPolicyFetchTime { get; set; }

        [JsonProperty("osPlatform", NullValueHandling = NullValueHandling.Ignore)]
        public string OsPlatform { get; set; }

        [JsonProperty("osArchitecture", NullValueHandling = NullValueHandling.Ignore)]
        public string OsArchitecture { get; set; }

        [JsonProperty("osVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string OsVersion { get; set; }

        [JsonProperty("machineName", NullValueHandling = NullValueHandling.Ignore)]
        public string MachineName { get; set; }

        [JsonProperty("lastRegistrationTime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? LastRegistrationTime { get; set; }

        [JsonProperty("extensionCount", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? ExtensionCount { get; set; }

        [JsonProperty("policyCount", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? PolicyCount { get; set; }

        [JsonProperty("lastDeviceUser", NullValueHandling = NullValueHandling.Ignore)]
        public string LastDeviceUser { get; set; }

        [JsonProperty("lastActivityTime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? LastActivityTime { get; set; }

        [JsonProperty("osPlatformVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string OsPlatformVersion { get; set; }

        [JsonProperty("browserVersions", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> BrowserVersions { get; set; }

        [JsonProperty("lastStatusReportTime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? LastStatusReportTime { get; set; }

        [JsonProperty("lastDeviceUsers", NullValueHandling = NullValueHandling.Ignore)]
        public List<LastDeviceUser> LastDeviceUsers { get; set; }

        [JsonProperty("machinePolicies", NullValueHandling = NullValueHandling.Ignore)]
        public List<Policy> MachinePolicies { get; set; }

        [JsonProperty("machineExtensionPolicies", NullValueHandling = NullValueHandling.Ignore)]
        public List<ExtensionPolicy> MachineExtensionPolicies { get; set; }

        [JsonProperty("browsers", NullValueHandling = NullValueHandling.Ignore)]
        public List<BrowserBrowser> Browsers { get; set; }

        [JsonProperty("serialNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string SerialNumber { get; set; }

        [JsonProperty("virtualDeviceId", NullValueHandling = NullValueHandling.Ignore)]
        public string VirtualDeviceId { get; set; }

        [JsonProperty("orgUnitPath", NullValueHandling = NullValueHandling.Ignore)]
        public string OrgUnitPath { get; set; }

        [JsonProperty("deviceIdentifiersHistory", NullValueHandling = NullValueHandling.Ignore)]
        public DeviceIdentifiersHistory DeviceIdentifiersHistory { get; set; }

        [JsonProperty("annotatedLocation", NullValueHandling = NullValueHandling.Ignore)]
        public string AnnotatedLocation { get; set; }

        [JsonProperty("annotatedUser", NullValueHandling = NullValueHandling.Ignore)]
        public string AnnotatedUser { get; set; }

        [JsonProperty("annotatedAssetId", NullValueHandling = NullValueHandling.Ignore)]
        public string AnnotatedAssetId { get; set; }

        [JsonProperty("annotatedNotes", NullValueHandling = NullValueHandling.Ignore)]
        public string AnnotatedNotes { get; set; }

        public List<Extension> AllExtensions
        {
            get
            {
                List<Extension> extensions = new List<Extension>();

                if (this.Browsers is null)
                    return extensions;

                foreach (BrowserBrowser browser in this.Browsers)
                {
                    if (browser is null)
                        continue;

                    extensions.AddRange(browser.AllExtensions);
                }

                return extensions;

            }
        }

        public override string ToString()
        {
            return this.DeviceId;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            BrowserDevicesBrowser lhs = obj as BrowserDevicesBrowser;

            if (lhs == null) return false;

            if (String.IsNullOrEmpty(lhs.DeviceId)) return false;

            return String.Compare(lhs.DeviceId, this.DeviceId, true) == 0;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public bool Equals(BrowserDevicesBrowser other)
        {
            if (other == null) return false;
            return this.DeviceId.Equals(other.DeviceId);
        }
    }

    public partial class BrowserBrowser
    {
        [JsonProperty("browserVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string BrowserVersion { get; set; }

        [JsonProperty("channel", NullValueHandling = NullValueHandling.Ignore)]
        public string Channel { get; set; }

        [JsonProperty("lastStatusReportTime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? LastStatusReportTime { get; set; }

        [JsonProperty("executablePath", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecutablePath { get; set; }

        [JsonProperty("plugins", NullValueHandling = NullValueHandling.Ignore)]
        public List<Plugin> Plugins { get; set; }

        [JsonProperty("profiles", NullValueHandling = NullValueHandling.Ignore)]
        public List<Profile> Profiles { get; set; }

        public List<Extension> AllExtensions
        {
            get
            {
                List<Extension> extensions = new List<Extension>();

                if (this.Profiles is null)
                    return extensions;

                foreach (Profile profile in this.Profiles)
                {
                    if (profile.Extensions is null)
                        continue;

                    extensions.AddRange(profile.Extensions);
                }

                return extensions;
            }
        }

        [JsonProperty("pendingInstallVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string PendingInstallVersion { get; set; }
    }

    public partial class Plugin
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("filename", NullValueHandling = NullValueHandling.Ignore)]
        public string Filename { get; set; }
    }

    public partial class Profile
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("lastStatusReportTime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? LastStatusReportTime { get; set; }

        [JsonProperty("lastPolicyFetchTime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? LastPolicyFetchTime { get; set; }

        [JsonProperty("extensions", NullValueHandling = NullValueHandling.Ignore)]
        public List<Extension> Extensions { get; set; }

        [JsonProperty("chromeSignedInUserEmail", NullValueHandling = NullValueHandling.Ignore)]
        public string ChromeSignedInUserEmail { get; set; }

        [JsonProperty("userPolicies", NullValueHandling = NullValueHandling.Ignore)]
        public List<Policy> UserPolicies { get; set; }

        [JsonProperty("extensionPolicies", NullValueHandling = NullValueHandling.Ignore)]
        public List<ExtensionPolicy> ExtensionPolicies { get; set; }
    }

    public partial class Extension
    {
        [JsonProperty("extensionId", NullValueHandling = NullValueHandling.Ignore)]
        public string ExtensionId { get; set; }

        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        [JsonProperty("permissions", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Permissions { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("appType", NullValueHandling = NullValueHandling.Ignore)]
        public string AppType { get; set; }

        [JsonProperty("homepageUrl", NullValueHandling = NullValueHandling.Ignore)]
        public Uri HomepageUrl { get; set; }

        [JsonProperty("installType", NullValueHandling = NullValueHandling.Ignore)]
        public string InstallType { get; set; }

        [JsonProperty("manifestVersion", NullValueHandling = NullValueHandling.Ignore)]
        public long? ManifestVersion { get; set; }

        [JsonProperty("disabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Disabled { get; set; }
    }

    public partial class ExtensionPolicy
    {
        [JsonProperty("extensionId", NullValueHandling = NullValueHandling.Ignore)]
        public string ExtensionId { get; set; }

        [JsonProperty("extensionName", NullValueHandling = NullValueHandling.Ignore)]
        public string ExtensionName { get; set; }

        [JsonProperty("policies", NullValueHandling = NullValueHandling.Ignore)]
        public List<Policy> Policies { get; set; }
    }

    public partial class Policy
    {
        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public string Source { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }

        [JsonProperty("error", NullValueHandling = NullValueHandling.Ignore)]
        public string Error { get; set; }

        public override string ToString()
        {
            return String.Format("source:{0};name:{1};value:{2}", 
                this.Source,
                this.Name,
                this.Value);
        }
    }
    public partial class DeviceIdentifiersHistory
    {
        [JsonProperty("records", NullValueHandling = NullValueHandling.Ignore)]
        public List<Record> Records { get; set; }
    }

    public partial class Record
    {
        [JsonProperty("identifiers", NullValueHandling = NullValueHandling.Ignore)]
        public Identifiers Identifiers { get; set; }

        [JsonProperty("firstRecordTime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? FirstRecordTime { get; set; }

        [JsonProperty("lastActivityTime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? LastActivityTime { get; set; }
    }

    public partial class Identifiers
    {
        [JsonProperty("machineName", NullValueHandling = NullValueHandling.Ignore)]
        public string MachineName { get; set; }

        [JsonProperty("serialNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string SerialNumber { get; set; }
    }

    public partial class LastDeviceUser
    {
        [JsonProperty("userName", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        [JsonProperty("lastStatusReportTime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? LastStatusReportTime { get; set; }
    }

    public partial class BrowserDevices
    {
        public static BrowserDevices FromJson(string json) => JsonConvert.DeserializeObject<BrowserDevices>(json, cbcmSchema.Browserdevices.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this BrowserDevices self) => JsonConvert.SerializeObject(self, cbcmSchema.Browserdevices.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }
}
