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
using Aliyun.Acs.PTS.Model.V20201020;

namespace Aliyun.Acs.PTS.Transform.V20201020
{
    public class GetJMeterSamplingLogsResponseUnmarshaller
    {
        public static GetJMeterSamplingLogsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetJMeterSamplingLogsResponse getJMeterSamplingLogsResponse = new GetJMeterSamplingLogsResponse();

			getJMeterSamplingLogsResponse.HttpResponse = _ctx.HttpResponse;
			getJMeterSamplingLogsResponse.TotalCount = _ctx.LongValue("GetJMeterSamplingLogs.TotalCount");
			getJMeterSamplingLogsResponse.RequestId = _ctx.StringValue("GetJMeterSamplingLogs.RequestId");
			getJMeterSamplingLogsResponse.Message = _ctx.StringValue("GetJMeterSamplingLogs.Message");
			getJMeterSamplingLogsResponse.PageSize = _ctx.IntegerValue("GetJMeterSamplingLogs.PageSize");
			getJMeterSamplingLogsResponse.PageNumber = _ctx.IntegerValue("GetJMeterSamplingLogs.PageNumber");
			getJMeterSamplingLogsResponse.HttpStatusCode = _ctx.IntegerValue("GetJMeterSamplingLogs.HttpStatusCode");
			getJMeterSamplingLogsResponse.Code = _ctx.StringValue("GetJMeterSamplingLogs.Code");
			getJMeterSamplingLogsResponse.Success = _ctx.BooleanValue("GetJMeterSamplingLogs.Success");

			List<string> getJMeterSamplingLogsResponse_sampleResults = new List<string>();
			for (int i = 0; i < _ctx.Length("GetJMeterSamplingLogs.SampleResults.Length"); i++) {
				getJMeterSamplingLogsResponse_sampleResults.Add(_ctx.StringValue("GetJMeterSamplingLogs.SampleResults["+ i +"]"));
			}
			getJMeterSamplingLogsResponse.SampleResults = getJMeterSamplingLogsResponse_sampleResults;
        
			return getJMeterSamplingLogsResponse;
        }
    }
}
