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
    public class DescribeLiveCdnDiagnoseInfoRequest : RpcAcsRequest<DescribeLiveCdnDiagnoseInfoResponse>
    {
        public DescribeLiveCdnDiagnoseInfoRequest()
            : base("live", "2016-11-01", "DescribeLiveCdnDiagnoseInfo", "live", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.live.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.live.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string intervalType;

		private string streamSuffix;

		private long? startTime;

		private string requestType;

		private string securityToken;

		private string streamName;

		private string app;

		private int? phase;

		private long? endTime;

		private string domain;

		[JsonProperty(PropertyName = "intervalType")]
		public string IntervalType
		{
			get
			{
				return intervalType;
			}
			set	
			{
				intervalType = value;
				DictionaryUtil.Add(QueryParameters, "intervalType", value);
			}
		}

		[JsonProperty(PropertyName = "streamSuffix")]
		public string StreamSuffix
		{
			get
			{
				return streamSuffix;
			}
			set	
			{
				streamSuffix = value;
				DictionaryUtil.Add(QueryParameters, "streamSuffix", value);
			}
		}

		[JsonProperty(PropertyName = "startTime")]
		public long? StartTime
		{
			get
			{
				return startTime;
			}
			set	
			{
				startTime = value;
				DictionaryUtil.Add(QueryParameters, "startTime", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "requestType")]
		public string RequestType
		{
			get
			{
				return requestType;
			}
			set	
			{
				requestType = value;
				DictionaryUtil.Add(QueryParameters, "requestType", value);
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

		[JsonProperty(PropertyName = "streamName")]
		public string StreamName
		{
			get
			{
				return streamName;
			}
			set	
			{
				streamName = value;
				DictionaryUtil.Add(QueryParameters, "streamName", value);
			}
		}

		[JsonProperty(PropertyName = "app")]
		public string App
		{
			get
			{
				return app;
			}
			set	
			{
				app = value;
				DictionaryUtil.Add(QueryParameters, "app", value);
			}
		}

		[JsonProperty(PropertyName = "phase")]
		public int? Phase
		{
			get
			{
				return phase;
			}
			set	
			{
				phase = value;
				DictionaryUtil.Add(QueryParameters, "phase", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "endTime")]
		public long? EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
				DictionaryUtil.Add(QueryParameters, "endTime", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "domain")]
		public string Domain
		{
			get
			{
				return domain;
			}
			set	
			{
				domain = value;
				DictionaryUtil.Add(QueryParameters, "domain", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeLiveCdnDiagnoseInfoResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeLiveCdnDiagnoseInfoResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
