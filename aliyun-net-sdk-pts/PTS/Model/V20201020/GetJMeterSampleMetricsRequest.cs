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
using Aliyun.Acs.PTS;
using Aliyun.Acs.PTS.Transform;
using Aliyun.Acs.PTS.Transform.V20201020;

namespace Aliyun.Acs.PTS.Model.V20201020
{
    public class GetJMeterSampleMetricsRequest : RpcAcsRequest<GetJMeterSampleMetricsResponse>
    {
        public GetJMeterSampleMetricsRequest()
            : base("PTS", "2020-10-20", "GetJMeterSampleMetrics")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.PTS.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.PTS.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string reportId;

		private int? samplerId;

		private long? endTime;

		private long? beginTime;

		public string ReportId
		{
			get
			{
				return reportId;
			}
			set	
			{
				reportId = value;
				DictionaryUtil.Add(QueryParameters, "ReportId", value);
			}
		}

		public int? SamplerId
		{
			get
			{
				return samplerId;
			}
			set	
			{
				samplerId = value;
				DictionaryUtil.Add(QueryParameters, "SamplerId", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "EndTime", value.ToString());
			}
		}

		public long? BeginTime
		{
			get
			{
				return beginTime;
			}
			set	
			{
				beginTime = value;
				DictionaryUtil.Add(QueryParameters, "BeginTime", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override GetJMeterSampleMetricsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetJMeterSampleMetricsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
