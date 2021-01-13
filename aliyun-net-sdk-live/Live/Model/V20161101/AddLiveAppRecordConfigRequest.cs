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

		private string startTime;

		private string appName;

		private string securityToken;

		private int? onDemand;

		private string streamName;

		private string ossBucket;

		private string domainName;

		private string endTime;

		private long? ownerId;

		private List<RecordFormat> recordFormats = new List<RecordFormat>(){ };

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

		public List<RecordFormat> RecordFormats
		{
			get
			{
				return recordFormats;
			}

			set
			{
				recordFormats = value;
				for (int i = 0; i < recordFormats.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"RecordFormat." + (i + 1) + ".SliceOssObjectPrefix", recordFormats[i].SliceOssObjectPrefix);
					DictionaryUtil.Add(QueryParameters,"RecordFormat." + (i + 1) + ".Format", recordFormats[i].Format);
					DictionaryUtil.Add(QueryParameters,"RecordFormat." + (i + 1) + ".OssObjectPrefix", recordFormats[i].OssObjectPrefix);
					DictionaryUtil.Add(QueryParameters,"RecordFormat." + (i + 1) + ".CycleDuration", recordFormats[i].CycleDuration);
				}
			}
		}

		public class RecordFormat
		{

			private string sliceOssObjectPrefix;

			private string format;

			private string ossObjectPrefix;

			private int? cycleDuration;

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
