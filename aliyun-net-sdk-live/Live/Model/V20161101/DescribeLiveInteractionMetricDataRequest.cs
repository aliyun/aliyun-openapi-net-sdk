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
    public class DescribeLiveInteractionMetricDataRequest : RpcAcsRequest<DescribeLiveInteractionMetricDataResponse>
    {
        public DescribeLiveInteractionMetricDataRequest()
            : base("live", "2016-11-01", "DescribeLiveInteractionMetricData", "live", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.live.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.live.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string metricType;

		private long? endTs;

		private string os;

		private long? beginTs;

		private string appId;

		private string terminalType;

		[JsonProperty(PropertyName = "MetricType")]
		public string MetricType
		{
			get
			{
				return metricType;
			}
			set	
			{
				metricType = value;
				DictionaryUtil.Add(QueryParameters, "MetricType", value);
			}
		}

		[JsonProperty(PropertyName = "EndTs")]
		public long? EndTs
		{
			get
			{
				return endTs;
			}
			set	
			{
				endTs = value;
				DictionaryUtil.Add(QueryParameters, "EndTs", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "Os")]
		public string Os
		{
			get
			{
				return os;
			}
			set	
			{
				os = value;
				DictionaryUtil.Add(QueryParameters, "Os", value);
			}
		}

		[JsonProperty(PropertyName = "BeginTs")]
		public long? BeginTs
		{
			get
			{
				return beginTs;
			}
			set	
			{
				beginTs = value;
				DictionaryUtil.Add(QueryParameters, "BeginTs", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "AppId")]
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

		[JsonProperty(PropertyName = "TerminalType")]
		public string TerminalType
		{
			get
			{
				return terminalType;
			}
			set	
			{
				terminalType = value;
				DictionaryUtil.Add(QueryParameters, "TerminalType", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeLiveInteractionMetricDataResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeLiveInteractionMetricDataResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
