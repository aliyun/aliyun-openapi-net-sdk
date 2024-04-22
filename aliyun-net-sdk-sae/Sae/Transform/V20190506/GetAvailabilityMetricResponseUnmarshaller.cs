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
    public class GetAvailabilityMetricResponseUnmarshaller
    {
        public static GetAvailabilityMetricResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetAvailabilityMetricResponse getAvailabilityMetricResponse = new GetAvailabilityMetricResponse();

			getAvailabilityMetricResponse.HttpResponse = _ctx.HttpResponse;
			getAvailabilityMetricResponse.Message = _ctx.StringValue("GetAvailabilityMetric.Message");
			getAvailabilityMetricResponse.RequestId = _ctx.StringValue("GetAvailabilityMetric.RequestId");
			getAvailabilityMetricResponse.Code = _ctx.StringValue("GetAvailabilityMetric.Code");
			getAvailabilityMetricResponse.Success = _ctx.BooleanValue("GetAvailabilityMetric.Success");

			List<GetAvailabilityMetricResponse.GetAvailabilityMetric_AvailabilityMetricDto> getAvailabilityMetricResponse_data = new List<GetAvailabilityMetricResponse.GetAvailabilityMetric_AvailabilityMetricDto>();
			for (int i = 0; i < _ctx.Length("GetAvailabilityMetric.Data.Length"); i++) {
				GetAvailabilityMetricResponse.GetAvailabilityMetric_AvailabilityMetricDto availabilityMetricDto = new GetAvailabilityMetricResponse.GetAvailabilityMetric_AvailabilityMetricDto();
				availabilityMetricDto.AppId = _ctx.StringValue("GetAvailabilityMetric.Data["+ i +"].AppId");
				availabilityMetricDto.Name = _ctx.StringValue("GetAvailabilityMetric.Data["+ i +"].Name");
				availabilityMetricDto.RegionId = _ctx.StringValue("GetAvailabilityMetric.Data["+ i +"].RegionId");
				availabilityMetricDto.Runnings = _ctx.LongValue("GetAvailabilityMetric.Data["+ i +"].Runnings");
				availabilityMetricDto.Instances = _ctx.LongValue("GetAvailabilityMetric.Data["+ i +"].Instances");
				availabilityMetricDto.ErrorInstances = _ctx.LongValue("GetAvailabilityMetric.Data["+ i +"].ErrorInstances");
				availabilityMetricDto.EnableAutoscale = _ctx.LongValue("GetAvailabilityMetric.Data["+ i +"].EnableAutoscale");

				getAvailabilityMetricResponse_data.Add(availabilityMetricDto);
			}
			getAvailabilityMetricResponse.Data = getAvailabilityMetricResponse_data;
        
			return getAvailabilityMetricResponse;
        }
    }
}
