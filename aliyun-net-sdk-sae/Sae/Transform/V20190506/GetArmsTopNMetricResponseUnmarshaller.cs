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
    public class GetArmsTopNMetricResponseUnmarshaller
    {
        public static GetArmsTopNMetricResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetArmsTopNMetricResponse getArmsTopNMetricResponse = new GetArmsTopNMetricResponse();

			getArmsTopNMetricResponse.HttpResponse = _ctx.HttpResponse;
			getArmsTopNMetricResponse.Message = _ctx.StringValue("GetArmsTopNMetric.Message");
			getArmsTopNMetricResponse.RequestId = _ctx.StringValue("GetArmsTopNMetric.RequestId");
			getArmsTopNMetricResponse.Code = _ctx.StringValue("GetArmsTopNMetric.Code");
			getArmsTopNMetricResponse.Success = _ctx.BooleanValue("GetArmsTopNMetric.Success");

			List<GetArmsTopNMetricResponse.GetArmsTopNMetric_ArmsMetricDto> getArmsTopNMetricResponse_data = new List<GetArmsTopNMetricResponse.GetArmsTopNMetric_ArmsMetricDto>();
			for (int i = 0; i < _ctx.Length("GetArmsTopNMetric.Data.Length"); i++) {
				GetArmsTopNMetricResponse.GetArmsTopNMetric_ArmsMetricDto armsMetricDto = new GetArmsTopNMetricResponse.GetArmsTopNMetric_ArmsMetricDto();
				armsMetricDto.AppId = _ctx.StringValue("GetArmsTopNMetric.Data["+ i +"].AppId");
				armsMetricDto.Name = _ctx.StringValue("GetArmsTopNMetric.Data["+ i +"].Name");
				armsMetricDto.RegionId = _ctx.StringValue("GetArmsTopNMetric.Data["+ i +"].RegionId");
				armsMetricDto.Count = _ctx.LongValue("GetArmsTopNMetric.Data["+ i +"].Count");
				armsMetricDto.Error = _ctx.LongValue("GetArmsTopNMetric.Data["+ i +"].Error");
				armsMetricDto.Rt = _ctx.LongValue("GetArmsTopNMetric.Data["+ i +"].Rt");

				getArmsTopNMetricResponse_data.Add(armsMetricDto);
			}
			getArmsTopNMetricResponse.Data = getArmsTopNMetricResponse_data;
        
			return getArmsTopNMetricResponse;
        }
    }
}
