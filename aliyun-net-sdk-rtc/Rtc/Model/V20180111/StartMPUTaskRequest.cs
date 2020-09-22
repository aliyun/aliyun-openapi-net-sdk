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

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.rtc.Transform;
using Aliyun.Acs.rtc.Transform.V20180111;

namespace Aliyun.Acs.rtc.Model.V20180111
{
    public class StartMPUTaskRequest : RpcAcsRequest<StartMPUTaskResponse>
    {
        public StartMPUTaskRequest()
            : base("rtc", "2018-01-11", "StartMPUTask", "rtc", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private int? payloadType;

		private List<UserPanes> userPaness = new List<UserPanes>(){ };

		private int? rtpExtInfo;

		private int? backgroundColor;

		private int? cropMode;

		private int? reportVad;

		private string taskProfile;

		private List<long?> layoutIdss = new List<long?>(){ };

		private string taskId;

		private string streamURL;

		private long? vadInterval;

		private long? ownerId;

		private List<string> subSpecUserss = new List<string>(){ };

		private string appId;

		private long? timeStampRef;

		private int? mediaEncode;

		private string channelId;

		public int? PayloadType
		{
			get
			{
				return payloadType;
			}
			set	
			{
				payloadType = value;
				DictionaryUtil.Add(QueryParameters, "PayloadType", value.ToString());
			}
		}

		public List<UserPanes> UserPaness
		{
			get
			{
				return userPaness;
			}

			set
			{
				userPaness = value;
				for (int i = 0; i < userPaness.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"UserPanes." + (i + 1) + ".PaneId", userPaness[i].PaneId);
					DictionaryUtil.Add(QueryParameters,"UserPanes." + (i + 1) + ".UserId", userPaness[i].UserId);
					DictionaryUtil.Add(QueryParameters,"UserPanes." + (i + 1) + ".SourceType", userPaness[i].SourceType);
				}
			}
		}

		public int? RtpExtInfo
		{
			get
			{
				return rtpExtInfo;
			}
			set	
			{
				rtpExtInfo = value;
				DictionaryUtil.Add(QueryParameters, "RtpExtInfo", value.ToString());
			}
		}

		public int? BackgroundColor
		{
			get
			{
				return backgroundColor;
			}
			set	
			{
				backgroundColor = value;
				DictionaryUtil.Add(QueryParameters, "BackgroundColor", value.ToString());
			}
		}

		public int? CropMode
		{
			get
			{
				return cropMode;
			}
			set	
			{
				cropMode = value;
				DictionaryUtil.Add(QueryParameters, "CropMode", value.ToString());
			}
		}

		public int? ReportVad
		{
			get
			{
				return reportVad;
			}
			set	
			{
				reportVad = value;
				DictionaryUtil.Add(QueryParameters, "ReportVad", value.ToString());
			}
		}

		public string TaskProfile
		{
			get
			{
				return taskProfile;
			}
			set	
			{
				taskProfile = value;
				DictionaryUtil.Add(QueryParameters, "TaskProfile", value);
			}
		}

		public List<long?> LayoutIdss
		{
			get
			{
				return layoutIdss;
			}

			set
			{
				layoutIdss = value;
				for (int i = 0; i < layoutIdss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"LayoutIds." + (i + 1) , layoutIdss[i]);
				}
			}
		}

		public string TaskId
		{
			get
			{
				return taskId;
			}
			set	
			{
				taskId = value;
				DictionaryUtil.Add(QueryParameters, "TaskId", value);
			}
		}

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

		public long? VadInterval
		{
			get
			{
				return vadInterval;
			}
			set	
			{
				vadInterval = value;
				DictionaryUtil.Add(QueryParameters, "VadInterval", value.ToString());
			}
		}

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

		public List<string> SubSpecUserss
		{
			get
			{
				return subSpecUserss;
			}

			set
			{
				subSpecUserss = value;
				for (int i = 0; i < subSpecUserss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"SubSpecUsers." + (i + 1) , subSpecUserss[i]);
				}
			}
		}

		public string AppId
		{
			get
			{
				return appId;
			}
			set	
			{
				appId = value;
				DictionaryUtil.Add(QueryParameters, "AppId", value);
			}
		}

		public long? TimeStampRef
		{
			get
			{
				return timeStampRef;
			}
			set	
			{
				timeStampRef = value;
				DictionaryUtil.Add(QueryParameters, "TimeStampRef", value.ToString());
			}
		}

		public int? MediaEncode
		{
			get
			{
				return mediaEncode;
			}
			set	
			{
				mediaEncode = value;
				DictionaryUtil.Add(QueryParameters, "MediaEncode", value.ToString());
			}
		}

		public string ChannelId
		{
			get
			{
				return channelId;
			}
			set	
			{
				channelId = value;
				DictionaryUtil.Add(QueryParameters, "ChannelId", value);
			}
		}

		public class UserPanes
		{

			private int? paneId;

			private string userId;

			private string sourceType;

			public int? PaneId
			{
				get
				{
					return paneId;
				}
				set	
				{
					paneId = value;
				}
			}

			public string UserId
			{
				get
				{
					return userId;
				}
				set	
				{
					userId = value;
				}
			}

			public string SourceType
			{
				get
				{
					return sourceType;
				}
				set	
				{
					sourceType = value;
				}
			}
		}

        public override StartMPUTaskResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return StartMPUTaskResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
