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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.sae.Model.V20190506;

namespace Aliyun.Acs.sae.Transform.V20190506
{
    public class GetWarningEventMetricResponseUnmarshaller
    {
        public static GetWarningEventMetricResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetWarningEventMetricResponse getWarningEventMetricResponse = new GetWarningEventMetricResponse();

			getWarningEventMetricResponse.HttpResponse = _ctx.HttpResponse;
			getWarningEventMetricResponse.Message = _ctx.StringValue("GetWarningEventMetric.Message");
			getWarningEventMetricResponse.RequestId = _ctx.StringValue("GetWarningEventMetric.RequestId");
			getWarningEventMetricResponse.Code = _ctx.StringValue("GetWarningEventMetric.Code");
			getWarningEventMetricResponse.Success = _ctx.BooleanValue("GetWarningEventMetric.Success");

			List<GetWarningEventMetricResponse.GetWarningEventMetric_EventMetricDto> getWarningEventMetricResponse_data = new List<GetWarningEventMetricResponse.GetWarningEventMetric_EventMetricDto>();
			for (int i = 0; i < _ctx.Length("GetWarningEventMetric.Data.Length"); i++) {
				GetWarningEventMetricResponse.GetWarningEventMetric_EventMetricDto eventMetricDto = new GetWarningEventMetricResponse.GetWarningEventMetric_EventMetricDto();
				eventMetricDto.AppId = _ctx.StringValue("GetWarningEventMetric.Data["+ i +"].AppId");
				eventMetricDto.Name = _ctx.StringValue("GetWarningEventMetric.Data["+ i +"].Name");
				eventMetricDto.RegionId = _ctx.StringValue("GetWarningEventMetric.Data["+ i +"].RegionId");
				eventMetricDto.WarningCount = _ctx.LongValue("GetWarningEventMetric.Data["+ i +"].WarningCount");

				getWarningEventMetricResponse_data.Add(eventMetricDto);
			}
			getWarningEventMetricResponse.Data = getWarningEventMetricResponse_data;
        
			return getWarningEventMetricResponse;
        }
    }
}
