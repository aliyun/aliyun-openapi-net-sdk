/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;
using Newtonsoft.Json;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.live.Transform;
using Aliyun.Acs.live.Transform.V20161101;

namespace Aliyun.Acs.live.Model.V20161101
{
    public class CreateRtcAsrTaskRequest : RpcAcsRequest<CreateRtcAsrTaskResponse>
    {
        public CreateRtcAsrTaskRequest()
            : base("live", "2016-11-01", "CreateRtcAsrTask", "live", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.live.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.live.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string authKey;

		private string language;

		private string mode;

		private bool? translateEnabled;

		private string tag;

		private string streamURL;

		private string targetLanguages;

		private bool? autoTerminateEnabled;

		private long? ownerId;

		private string rtcUserId;

		private long? reportInterval;

		private long? autoTerminateDelay;

		private string sDKAppID;

		private string callbackURL;

		private string channelID;

		[JsonProperty(PropertyName = "AuthKey")]
		public string AuthKey
		{
			get
			{
				return authKey;
			}
			set	
			{
				authKey = value;
				DictionaryUtil.Add(QueryParameters, "AuthKey", value);
			}
		}

		[JsonProperty(PropertyName = "Language")]
		public string Language
		{
			get
			{
				return language;
			}
			set	
			{
				language = value;
				DictionaryUtil.Add(QueryParameters, "Language", value);
			}
		}

		[JsonProperty(PropertyName = "Mode")]
		public string Mode
		{
			get
			{
				return mode;
			}
			set	
			{
				mode = value;
				DictionaryUtil.Add(QueryParameters, "Mode", value);
			}
		}

		[JsonProperty(PropertyName = "TranslateEnabled")]
		public bool? TranslateEnabled
		{
			get
			{
				return translateEnabled;
			}
			set	
			{
				translateEnabled = value;
				DictionaryUtil.Add(QueryParameters, "TranslateEnabled", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "Tag")]
		public string Tag
		{
			get
			{
				return tag;
			}
			set	
			{
				tag = value;
				DictionaryUtil.Add(QueryParameters, "Tag", value);
			}
		}

		[JsonProperty(PropertyName = "StreamURL")]
		public string StreamURL
		{
			get
			{
				return streamURL;
			}
			set	
			{
				streamURL = value;
				DictionaryUtil.Add(QueryParameters, "StreamURL", value);
			}
		}

		[JsonProperty(PropertyName = "TargetLanguages")]
		public string TargetLanguages
		{
			get
			{
				return targetLanguages;
			}
			set	
			{
				targetLanguages = value;
				DictionaryUtil.Add(QueryParameters, "TargetLanguages", value);
			}
		}

		[JsonProperty(PropertyName = "AutoTerminateEnabled")]
		public bool? AutoTerminateEnabled
		{
			get
			{
				return autoTerminateEnabled;
			}
			set	
			{
				autoTerminateEnabled = value;
				DictionaryUtil.Add(QueryParameters, "AutoTerminateEnabled", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "OwnerId")]
		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "RtcUserId")]
		public string RtcUserId
		{
			get
			{
				return rtcUserId;
			}
			set	
			{
				rtcUserId = value;
				DictionaryUtil.Add(QueryParameters, "RtcUserId", value);
			}
		}

		[JsonProperty(PropertyName = "ReportInterval")]
		public long? ReportInterval
		{
			get
			{
				return reportInterval;
			}
			set	
			{
				reportInterval = value;
				DictionaryUtil.Add(QueryParameters, "ReportInterval", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "AutoTerminateDelay")]
		public long? AutoTerminateDelay
		{
			get
			{
				return autoTerminateDelay;
			}
			set	
			{
				autoTerminateDelay = value;
				DictionaryUtil.Add(QueryParameters, "AutoTerminateDelay", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "SDKAppID")]
		public string SDKAppID
		{
			get
			{
				return sDKAppID;
			}
			set	
			{
				sDKAppID = value;
				DictionaryUtil.Add(QueryParameters, "SDKAppID", value);
			}
		}

		[JsonProperty(PropertyName = "CallbackURL")]
		public string CallbackURL
		{
			get
			{
				return callbackURL;
			}
			set	
			{
				callbackURL = value;
				DictionaryUtil.Add(QueryParameters, "CallbackURL", value);
			}
		}

		[JsonProperty(PropertyName = "ChannelID")]
		public string ChannelID
		{
			get
			{
				return channelID;
			}
			set	
			{
				channelID = value;
				DictionaryUtil.Add(QueryParameters, "ChannelID", value);
			}
		}

        public override CreateRtcAsrTaskResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateRtcAsrTaskResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
