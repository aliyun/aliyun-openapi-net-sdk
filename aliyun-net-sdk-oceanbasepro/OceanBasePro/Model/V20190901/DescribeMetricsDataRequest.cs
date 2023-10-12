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
using Aliyun.Acs.OceanBasePro.Transform;
using Aliyun.Acs.OceanBasePro.Transform.V20190901;

namespace Aliyun.Acs.OceanBasePro.Model.V20190901
{
    public class DescribeMetricsDataRequest : RpcAcsRequest<DescribeMetricsDataResponse>
    {
        public DescribeMetricsDataRequest()
            : base("OceanBasePro", "2019-09-01", "DescribeMetricsData", "oceanbase", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.OceanBasePro.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.OceanBasePro.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string groupByLabels;

		private string startTime;

		private string limit;

		private string sortOrder;

		private string sortMetricKey;

		private string endTime;

		private string labels;

		private string instanceId;

		private string metrics;

		[JsonProperty(PropertyName = "GroupByLabels")]
		public string GroupByLabels
		{
			get
			{
				return groupByLabels;
			}
			set	
			{
				groupByLabels = value;
				DictionaryUtil.Add(QueryParameters, "GroupByLabels", value);
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

		[JsonProperty(PropertyName = "Limit")]
		public string Limit
		{
			get
			{
				return limit;
			}
			set	
			{
				limit = value;
				DictionaryUtil.Add(QueryParameters, "Limit", value);
			}
		}

		[JsonProperty(PropertyName = "SortOrder")]
		public string SortOrder
		{
			get
			{
				return sortOrder;
			}
			set	
			{
				sortOrder = value;
				DictionaryUtil.Add(QueryParameters, "SortOrder", value);
			}
		}

		[JsonProperty(PropertyName = "SortMetricKey")]
		public string SortMetricKey
		{
			get
			{
				return sortMetricKey;
			}
			set	
			{
				sortMetricKey = value;
				DictionaryUtil.Add(QueryParameters, "SortMetricKey", value);
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

		[JsonProperty(PropertyName = "Labels")]
		public string Labels
		{
			get
			{
				return labels;
			}
			set	
			{
				labels = value;
				DictionaryUtil.Add(QueryParameters, "Labels", value);
			}
		}

		[JsonProperty(PropertyName = "InstanceId")]
		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId", value);
			}
		}

		[JsonProperty(PropertyName = "Metrics")]
		public string Metrics
		{
			get
			{
				return metrics;
			}
			set	
			{
				metrics = value;
				DictionaryUtil.Add(QueryParameters, "Metrics", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeMetricsDataResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeMetricsDataResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
