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
    public class GetChangeOrderMetricResponseUnmarshaller
    {
        public static GetChangeOrderMetricResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetChangeOrderMetricResponse getChangeOrderMetricResponse = new GetChangeOrderMetricResponse();

			getChangeOrderMetricResponse.HttpResponse = _ctx.HttpResponse;
			getChangeOrderMetricResponse.Message = _ctx.StringValue("GetChangeOrderMetric.Message");
			getChangeOrderMetricResponse.RequestId = _ctx.StringValue("GetChangeOrderMetric.RequestId");
			getChangeOrderMetricResponse.Code = _ctx.StringValue("GetChangeOrderMetric.Code");
			getChangeOrderMetricResponse.Success = _ctx.BooleanValue("GetChangeOrderMetric.Success");

			List<GetChangeOrderMetricResponse.GetChangeOrderMetric_ChangeOrderMetricDto> getChangeOrderMetricResponse_data = new List<GetChangeOrderMetricResponse.GetChangeOrderMetric_ChangeOrderMetricDto>();
			for (int i = 0; i < _ctx.Length("GetChangeOrderMetric.Data.Length"); i++) {
				GetChangeOrderMetricResponse.GetChangeOrderMetric_ChangeOrderMetricDto changeOrderMetricDto = new GetChangeOrderMetricResponse.GetChangeOrderMetric_ChangeOrderMetricDto();
				changeOrderMetricDto.AppId = _ctx.StringValue("GetChangeOrderMetric.Data["+ i +"].AppId");
				changeOrderMetricDto.Name = _ctx.StringValue("GetChangeOrderMetric.Data["+ i +"].Name");
				changeOrderMetricDto.RegionId = _ctx.StringValue("GetChangeOrderMetric.Data["+ i +"].RegionId");
				changeOrderMetricDto.Total = _ctx.LongValue("GetChangeOrderMetric.Data["+ i +"].Total");
				changeOrderMetricDto.Error = _ctx.LongValue("GetChangeOrderMetric.Data["+ i +"].Error");
				changeOrderMetricDto.ErrorPercent = _ctx.FloatValue("GetChangeOrderMetric.Data["+ i +"].ErrorPercent");

				getChangeOrderMetricResponse_data.Add(changeOrderMetricDto);
			}
			getChangeOrderMetricResponse.Data = getChangeOrderMetricResponse_data;
        
			return getChangeOrderMetricResponse;
        }
    }
}
