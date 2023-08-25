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
    public class DescribeProjectStepMetricRequest : RpcAcsRequest<DescribeProjectStepMetricResponse>
    {
        public DescribeProjectStepMetricRequest()
            : base("OceanBasePro", "2019-09-01", "DescribeProjectStepMetric", "oceanbase", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.OceanBasePro.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.OceanBasePro.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string metricType;

		private string stepName;

		private string aggregator;

		private int? maxPointNum;

		private long? endTimestamp;

		private long? beginTimestamp;

		private string projectId;

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
				DictionaryUtil.Add(BodyParameters, "MetricType", value);
			}
		}

		[JsonProperty(PropertyName = "StepName")]
		public string StepName
		{
			get
			{
				return stepName;
			}
			set	
			{
				stepName = value;
				DictionaryUtil.Add(BodyParameters, "StepName", value);
			}
		}

		[JsonProperty(PropertyName = "Aggregator")]
		public string Aggregator
		{
			get
			{
				return aggregator;
			}
			set	
			{
				aggregator = value;
				DictionaryUtil.Add(BodyParameters, "Aggregator", value);
			}
		}

		[JsonProperty(PropertyName = "MaxPointNum")]
		public int? MaxPointNum
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

		[JsonProperty(PropertyName = "EndTimestamp")]
		public long? EndTimestamp
		{
			get
			{
				return endTimestamp;
			}
			set	
			{
				endTimestamp = value;
				DictionaryUtil.Add(BodyParameters, "EndTimestamp", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "BeginTimestamp")]
		public long? BeginTimestamp
		{
			get
			{
				return beginTimestamp;
			}
			set	
			{
				beginTimestamp = value;
				DictionaryUtil.Add(BodyParameters, "BeginTimestamp", value.ToString());
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

        public override DescribeProjectStepMetricResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeProjectStepMetricResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
