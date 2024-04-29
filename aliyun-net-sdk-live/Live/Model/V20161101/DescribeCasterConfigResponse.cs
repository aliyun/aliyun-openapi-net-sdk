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

namespace Aliyun.Acs.live.Model.V20161101
{
	public class DescribeCasterConfigResponse : AcsResponse
	{

		private string autoSwitchUrgentConfig;

		private string autoSwitchUrgentOn;

		private string callbackUrl;

		private string casterId;

		private string casterName;

		private int? channelEnable;

		private float? delay;

		private string domainName;

		private int? programEffect;

		private string programName;

		private string requestId;

		private string sideOutputUrl;

		private string sideOutputUrlList;

		private string urgentImageId;

		private string urgentImageUrl;

		private string urgentLiveStreamUrl;

		private string urgentMaterialId;

		private List<DescribeCasterConfig_SyncGroup> syncGroupsConfig;

		private DescribeCasterConfig_RecordConfig recordConfig;

		private DescribeCasterConfig_TranscodeConfig transcodeConfig;

		[JsonProperty(PropertyName = "AutoSwitchUrgentConfig")]
		public string AutoSwitchUrgentConfig
		{
			get
			{
				return autoSwitchUrgentConfig;
			}
			set	
			{
				autoSwitchUrgentConfig = value;
			}
		}

		[JsonProperty(PropertyName = "AutoSwitchUrgentOn")]
		public string AutoSwitchUrgentOn
		{
			get
			{
				return autoSwitchUrgentOn;
			}
			set	
			{
				autoSwitchUrgentOn = value;
			}
		}

		[JsonProperty(PropertyName = "CallbackUrl")]
		public string CallbackUrl
		{
			get
			{
				return callbackUrl;
			}
			set	
			{
				callbackUrl = value;
			}
		}

		[JsonProperty(PropertyName = "CasterId")]
		public string CasterId
		{
			get
			{
				return casterId;
			}
			set	
			{
				casterId = value;
			}
		}

		[JsonProperty(PropertyName = "CasterName")]
		public string CasterName
		{
			get
			{
				return casterName;
			}
			set	
			{
				casterName = value;
			}
		}

		[JsonProperty(PropertyName = "ChannelEnable")]
		public int? ChannelEnable
		{
			get
			{
				return channelEnable;
			}
			set	
			{
				channelEnable = value;
			}
		}

		[JsonProperty(PropertyName = "Delay")]
		public float? Delay
		{
			get
			{
				return delay;
			}
			set	
			{
				delay = value;
			}
		}

		[JsonProperty(PropertyName = "DomainName")]
		public string DomainName
		{
			get
			{
				return domainName;
			}
			set	
			{
				domainName = value;
			}
		}

		[JsonProperty(PropertyName = "ProgramEffect")]
		public int? ProgramEffect
		{
			get
			{
				return programEffect;
			}
			set	
			{
				programEffect = value;
			}
		}

		[JsonProperty(PropertyName = "ProgramName")]
		public string ProgramName
		{
			get
			{
				return programName;
			}
			set	
			{
				programName = value;
			}
		}

		[JsonProperty(PropertyName = "RequestId")]
		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		[JsonProperty(PropertyName = "SideOutputUrl")]
		public string SideOutputUrl
		{
			get
			{
				return sideOutputUrl;
			}
			set	
			{
				sideOutputUrl = value;
			}
		}

		[JsonProperty(PropertyName = "SideOutputUrlList")]
		public string SideOutputUrlList
		{
			get
			{
				return sideOutputUrlList;
			}
			set	
			{
				sideOutputUrlList = value;
			}
		}

		[JsonProperty(PropertyName = "UrgentImageId")]
		public string UrgentImageId
		{
			get
			{
				return urgentImageId;
			}
			set	
			{
				urgentImageId = value;
			}
		}

		[JsonProperty(PropertyName = "UrgentImageUrl")]
		public string UrgentImageUrl
		{
			get
			{
				return urgentImageUrl;
			}
			set	
			{
				urgentImageUrl = value;
			}
		}

		[JsonProperty(PropertyName = "UrgentLiveStreamUrl")]
		public string UrgentLiveStreamUrl
		{
			get
			{
				return urgentLiveStreamUrl;
			}
			set	
			{
				urgentLiveStreamUrl = value;
			}
		}

		[JsonProperty(PropertyName = "UrgentMaterialId")]
		public string UrgentMaterialId
		{
			get
			{
				return urgentMaterialId;
			}
			set	
			{
				urgentMaterialId = value;
			}
		}

		[JsonProperty(PropertyName = "SyncGroupsConfig")]
		public List<DescribeCasterConfig_SyncGroup> SyncGroupsConfig
		{
			get
			{
				return syncGroupsConfig;
			}
			set	
			{
				syncGroupsConfig = value;
			}
		}

		[JsonProperty(PropertyName = "RecordConfig")]
		public DescribeCasterConfig_RecordConfig RecordConfig
		{
			get
			{
				return recordConfig;
			}
			set	
			{
				recordConfig = value;
			}
		}

		[JsonProperty(PropertyName = "TranscodeConfig")]
		public DescribeCasterConfig_TranscodeConfig TranscodeConfig
		{
			get
			{
				return transcodeConfig;
			}
			set	
			{
				transcodeConfig = value;
			}
		}

		public class DescribeCasterConfig_SyncGroup
		{

			private string hostResourceId;

			private int? mode;

			private List<string> resourceIds;

			[JsonProperty(PropertyName = "HostResourceId")]
			public string HostResourceId
			{
				get
				{
					return hostResourceId;
				}
				set	
				{
					hostResourceId = value;
				}
			}

			[JsonProperty(PropertyName = "Mode")]
			public int? Mode
			{
				get
				{
					return mode;
				}
				set	
				{
					mode = value;
				}
			}

			[JsonProperty(PropertyName = "ResourceIds")]
			public List<string> ResourceIds
			{
				get
				{
					return resourceIds;
				}
				set	
				{
					resourceIds = value;
				}
			}
		}

		public class DescribeCasterConfig_RecordConfig
		{

			private int? onDemand;

			private string ossBucket;

			private string ossEndpoint;

			private List<DescribeCasterConfig_RecordFormatItem> recordFormat;

			[JsonProperty(PropertyName = "OnDemand")]
			public int? OnDemand
			{
				get
				{
					return onDemand;
				}
				set	
				{
					onDemand = value;
				}
			}

			[JsonProperty(PropertyName = "OssBucket")]
			public string OssBucket
			{
				get
				{
					return ossBucket;
				}
				set	
				{
					ossBucket = value;
				}
			}

			[JsonProperty(PropertyName = "OssEndpoint")]
			public string OssEndpoint
			{
				get
				{
					return ossEndpoint;
				}
				set	
				{
					ossEndpoint = value;
				}
			}

			[JsonProperty(PropertyName = "RecordFormat")]
			public List<DescribeCasterConfig_RecordFormatItem> RecordFormat
			{
				get
				{
					return recordFormat;
				}
				set	
				{
					recordFormat = value;
				}
			}

			public class DescribeCasterConfig_RecordFormatItem
			{

				private int? cycleDuration;

				private string format;

				private string ossObjectPrefix;

				private string sliceOssObjectPrefix;

				[JsonProperty(PropertyName = "CycleDuration")]
				public int? CycleDuration
				{
					get
					{
						return cycleDuration;
					}
					set	
					{
						cycleDuration = value;
					}
				}

				[JsonProperty(PropertyName = "Format")]
				public string Format
				{
					get
					{
						return format;
					}
					set	
					{
						format = value;
					}
				}

				[JsonProperty(PropertyName = "OssObjectPrefix")]
				public string OssObjectPrefix
				{
					get
					{
						return ossObjectPrefix;
					}
					set	
					{
						ossObjectPrefix = value;
					}
				}

				[JsonProperty(PropertyName = "SliceOssObjectPrefix")]
				public string SliceOssObjectPrefix
				{
					get
					{
						return sliceOssObjectPrefix;
					}
					set	
					{
						sliceOssObjectPrefix = value;
					}
				}
			}
		}

		public class DescribeCasterConfig_TranscodeConfig
		{

			private string casterTemplate;

			private List<string> liveTemplateIds;

			[JsonProperty(PropertyName = "CasterTemplate")]
			public string CasterTemplate
			{
				get
				{
					return casterTemplate;
				}
				set	
				{
					casterTemplate = value;
				}
			}

			[JsonProperty(PropertyName = "LiveTemplateIds")]
			public List<string> LiveTemplateIds
			{
				get
				{
					return liveTemplateIds;
				}
				set	
				{
					liveTemplateIds = value;
				}
			}
		}
	}
}
