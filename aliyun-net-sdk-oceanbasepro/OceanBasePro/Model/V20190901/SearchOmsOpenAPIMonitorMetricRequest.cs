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
    public class SearchOmsOpenAPIMonitorMetricRequest : RpcAcsRequest<SearchOmsOpenAPIMonitorMetricResponse>
    {
        public SearchOmsOpenAPIMonitorMetricRequest()
            : base("OceanBasePro", "2019-09-01", "SearchOmsOpenAPIMonitorMetric", "oceanbase", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.OceanBasePro.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.OceanBasePro.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? endTime;

		private long? beginTime;

		private long? maxPointNum;

		private int? pageNumber;

		private string metric;

		private int? pageSize;

		private string workerGradeId;

		private string projectId;

		[JsonProperty(PropertyName = "EndTime")]
		public long? EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
				DictionaryUtil.Add(BodyParameters, "EndTime", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "BeginTime")]
		public long? BeginTime
		{
			get
			{
				return beginTime;
			}
			set	
			{
				beginTime = value;
				DictionaryUtil.Add(BodyParameters, "BeginTime", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "MaxPointNum")]
		public long? MaxPointNum
		{
			get
			{
				return maxPointNum;
			}
			set	
			{
				maxPointNum = value;
				DictionaryUtil.Add(BodyParameters, "MaxPointNum", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "PageNumber")]
		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
				DictionaryUtil.Add(BodyParameters, "PageNumber", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "Metric")]
		public string Metric
		{
			get
			{
				return metric;
			}
			set	
			{
				metric = value;
				DictionaryUtil.Add(BodyParameters, "Metric", value);
			}
		}

		[JsonProperty(PropertyName = "PageSize")]
		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(BodyParameters, "PageSize", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "WorkerGradeId")]
		public string WorkerGradeId
		{
			get
			{
				return workerGradeId;
			}
			set	
			{
				workerGradeId = value;
				DictionaryUtil.Add(BodyParameters, "WorkerGradeId", value);
			}
		}

		[JsonProperty(PropertyName = "ProjectId")]
		public string ProjectId
		{
			get
			{
				return projectId;
			}
			set	
			{
				projectId = value;
				DictionaryUtil.Add(BodyParameters, "ProjectId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SearchOmsOpenAPIMonitorMetricResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SearchOmsOpenAPIMonitorMetricResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
