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
using Aliyun.Acs.Airec.Transform;
using Aliyun.Acs.Airec.Transform.V20201126;

namespace Aliyun.Acs.Airec.Model.V20201126
{
    public class ListDashboardMetricsFlowsRequest : RoaAcsRequest<ListDashboardMetricsFlowsResponse>
    {
        public ListDashboardMetricsFlowsRequest()
            : base("Airec", "2020-11-26", "ListDashboardMetricsFlows", "airec", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Airec.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Airec.Endpoint.endpointRegionalType, null);
            }
			UriPattern = "/v2/openapi/instances/[instanceId]/dashboard/metrics/flows";
			Method = MethodType.GET;
        }

		private string metricType;

		private string instanceId;

		private long? endTime;

		private long? startTime;

		public string MetricType
		{
			get
			{
				return metricType;
			}
			set	
			{
				metricType = value;
				DictionaryUtil.Add(QueryParameters, "metricType", value);
			}
		}

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
				DictionaryUtil.Add(PathParameters, "instanceId", value);
			}
		}

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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListDashboardMetricsFlowsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListDashboardMetricsFlowsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
