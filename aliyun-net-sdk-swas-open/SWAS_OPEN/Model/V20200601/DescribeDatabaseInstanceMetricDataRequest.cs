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
using Aliyun.Acs.SWAS_OPEN.Transform;
using Aliyun.Acs.SWAS_OPEN.Transform.V20200601;

namespace Aliyun.Acs.SWAS_OPEN.Model.V20200601
{
    public class DescribeDatabaseInstanceMetricDataRequest : RpcAcsRequest<DescribeDatabaseInstanceMetricDataResponse>
    {
        public DescribeDatabaseInstanceMetricDataRequest()
            : base("SWAS-OPEN", "2020-06-01", "DescribeDatabaseInstanceMetricData", "SWAS-OPEN", "openAPI")
        {
			Method = MethodType.POST;
        }

		private string databaseInstanceId;

		private string endTime;

		private string startTime;

		private string metricName;

		[JsonProperty(PropertyName = "DatabaseInstanceId")]
		public string DatabaseInstanceId
		{
			get
			{
				return databaseInstanceId;
			}
			set	
			{
				databaseInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "DatabaseInstanceId", value);
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

		[JsonProperty(PropertyName = "MetricName")]
		public string MetricName
		{
			get
			{
				return metricName;
			}
			set	
			{
				metricName = value;
				DictionaryUtil.Add(QueryParameters, "MetricName", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeDatabaseInstanceMetricDataResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeDatabaseInstanceMetricDataResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
