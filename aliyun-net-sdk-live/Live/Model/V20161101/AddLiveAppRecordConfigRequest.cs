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
    public class AddLiveAppRecordConfigRequest : RpcAcsRequest<AddLiveAppRecordConfigResponse>
    {
        public AddLiveAppRecordConfigRequest()
            : base("live", "2016-11-01", "AddLiveAppRecordConfig", "live", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.live.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.live.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string ossEndpoint;

		private int? delayTime;

		private List<string> transcodeTemplatess = new List<string>(){ };

		private string startTime;

		private string appName;

		private string securityToken;

		private List<string> transcodeRecordFormats = new List<string>(){ };

		private int? onDemand;

		private string streamName;

		private string ossBucket;

		private string domainName;

		private string endTime;

		private long? ownerId;

		private List<string> recordFormats = new List<string>(){ };

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
				DictionaryUtil.Add(QueryParameters, "OssEndpoint", value);
			}
		}

		[JsonProperty(PropertyName = "DelayTime")]
		public int? DelayTime
		{
			get
			{
				return delayTime;
			}
			set	
			{
				delayTime = value;
				DictionaryUtil.Add(QueryParameters, "DelayTime", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "TranscodeTemplates")]
		public List<string> TranscodeTemplatess
		{
			get
			{
				return transcodeTemplatess;
			}

			set
			{
				transcodeTemplatess = value;
			}
		}

		[JsonProperty(PropertyName = "StartTime")]
		public string StartTime
		{
			get
			{
				return startTime;
			}
			set	
			{
				startTime = value;
				DictionaryUtil.Add(QueryParameters, "StartTime", value);
			}
		}

		[JsonProperty(PropertyName = "AppName")]
		public string AppName
		{
			get
			{
				return appName;
			}
			set	
			{
				appName = value;
				DictionaryUtil.Add(QueryParameters, "AppName", value);
			}
		}

		[JsonProperty(PropertyName = "SecurityToken")]
		public string SecurityToken
		{
			get
			{
				return securityToken;
			}
			set	
			{
				securityToken = value;
				DictionaryUtil.Add(QueryParameters, "SecurityToken", value);
			}
		}

		[JsonProperty(PropertyName = "TranscodeRecordFormat")]
		public List<string> TranscodeRecordFormats
		{
			get
			{
				return transcodeRecordFormats;
			}

			set
			{
				transcodeRecordFormats = value;
				if(transcodeRecordFormats != null)
				{
					for (int depth1 = 0; depth1 < transcodeRecordFormats.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"TranscodeRecordFormat." + (depth1 + 1), transcodeRecordFormats[depth1]);
						DictionaryUtil.Add(QueryParameters,"TranscodeRecordFormat." + (depth1 + 1), transcodeRecordFormats[depth1]);
						DictionaryUtil.Add(QueryParameters,"TranscodeRecordFormat." + (depth1 + 1), transcodeRecordFormats[depth1]);
						DictionaryUtil.Add(QueryParameters,"TranscodeRecordFormat." + (depth1 + 1), transcodeRecordFormats[depth1]);
						DictionaryUtil.Add(QueryParameters,"TranscodeRecordFormat." + (depth1 + 1), transcodeRecordFormats[depth1]);
					}
				}
			}
		}

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
				DictionaryUtil.Add(QueryParameters, "OnDemand", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "StreamName")]
		public string StreamName
		{
			get
			{
				return streamName;
			}
			set	
			{
				streamName = value;
				DictionaryUtil.Add(QueryParameters, "StreamName", value);
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
				DictionaryUtil.Add(QueryParameters, "OssBucket", value);
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
				DictionaryUtil.Add(QueryParameters, "DomainName", value);
			}
		}

		[JsonProperty(PropertyName = "EndTime")]
		public string EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
				DictionaryUtil.Add(QueryParameters, "EndTime", value);
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

		[JsonProperty(PropertyName = "RecordFormat")]
		public List<string> RecordFormats
		{
			get
			{
				return recordFormats;
			}

			set
			{
				recordFormats = value;
				if(recordFormats != null)
				{
					for (int depth1 = 0; depth1 < recordFormats.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"RecordFormat." + (depth1 + 1), recordFormats[depth1]);
						DictionaryUtil.Add(QueryParameters,"RecordFormat." + (depth1 + 1), recordFormats[depth1]);
						DictionaryUtil.Add(QueryParameters,"RecordFormat." + (depth1 + 1), recordFormats[depth1]);
						DictionaryUtil.Add(QueryParameters,"RecordFormat." + (depth1 + 1), recordFormats[depth1]);
						DictionaryUtil.Add(QueryParameters,"RecordFormat." + (depth1 + 1), recordFormats[depth1]);
					}
				}
			}
		}

		public class TranscodeRecordFormat
		{

			private string sliceOssObjectPrefix;

			private int? sliceDuration;

			private string ossObjectPrefix;

			private string format;

			private int? cycleDuration;

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

			[JsonProperty(PropertyName = "SliceDuration")]
			public int? SliceDuration
			{
				get
				{
					return sliceDuration;
				}
				set	
				{
					sliceDuration = value;
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
		}

		public class RecordFormat
		{

			private string sliceOssObjectPrefix;

			private int? sliceDuration;

			private string ossObjectPrefix;

			private string format;

			private int? cycleDuration;

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

			[JsonProperty(PropertyName = "SliceDuration")]
			public int? SliceDuration
			{
				get
				{
					return sliceDuration;
				}
				set	
				{
					sliceDuration = value;
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
		}

        public override AddLiveAppRecordConfigResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AddLiveAppRecordConfigResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
