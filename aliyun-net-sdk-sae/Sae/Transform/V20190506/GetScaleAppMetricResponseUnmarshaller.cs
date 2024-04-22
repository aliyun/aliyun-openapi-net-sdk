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
    public class GetScaleAppMetricResponseUnmarshaller
    {
        public static GetScaleAppMetricResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetScaleAppMetricResponse getScaleAppMetricResponse = new GetScaleAppMetricResponse();

			getScaleAppMetricResponse.HttpResponse = _ctx.HttpResponse;
			getScaleAppMetricResponse.Message = _ctx.StringValue("GetScaleAppMetric.Message");
			getScaleAppMetricResponse.RequestId = _ctx.StringValue("GetScaleAppMetric.RequestId");
			getScaleAppMetricResponse.Code = _ctx.StringValue("GetScaleAppMetric.Code");
			getScaleAppMetricResponse.Success = _ctx.BooleanValue("GetScaleAppMetric.Success");

			List<GetScaleAppMetricResponse.GetScaleAppMetric_ScaleAppMetricDto> getScaleAppMetricResponse_data = new List<GetScaleAppMetricResponse.GetScaleAppMetric_ScaleAppMetricDto>();
			for (int i = 0; i < _ctx.Length("GetScaleAppMetric.Data.Length"); i++) {
				GetScaleAppMetricResponse.GetScaleAppMetric_ScaleAppMetricDto scaleAppMetricDto = new GetScaleAppMetricResponse.GetScaleAppMetric_ScaleAppMetricDto();
				scaleAppMetricDto.AppId = _ctx.StringValue("GetScaleAppMetric.Data["+ i +"].AppId");
				scaleAppMetricDto.Name = _ctx.StringValue("GetScaleAppMetric.Data["+ i +"].Name");
				scaleAppMetricDto.RegionId = _ctx.StringValue("GetScaleAppMetric.Data["+ i +"].RegionId");
				scaleAppMetricDto.Runnings = _ctx.LongValue("GetScaleAppMetric.Data["+ i +"].Runnings");
				scaleAppMetricDto.MaxReplicas = _ctx.LongValue("GetScaleAppMetric.Data["+ i +"].MaxReplicas");

				getScaleAppMetricResponse_data.Add(scaleAppMetricDto);
			}
			getScaleAppMetricResponse.Data = getScaleAppMetricResponse_data;
        
			return getScaleAppMetricResponse;
        }
    }
}
