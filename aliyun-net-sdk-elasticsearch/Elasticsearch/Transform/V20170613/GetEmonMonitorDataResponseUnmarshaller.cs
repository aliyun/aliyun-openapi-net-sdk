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
using Aliyun.Acs.elasticsearch.Model.V20170613;

namespace Aliyun.Acs.elasticsearch.Transform.V20170613
{
    public class GetEmonMonitorDataResponseUnmarshaller
    {
        public static GetEmonMonitorDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetEmonMonitorDataResponse getEmonMonitorDataResponse = new GetEmonMonitorDataResponse();

			getEmonMonitorDataResponse.HttpResponse = _ctx.HttpResponse;
			getEmonMonitorDataResponse.RequestId = _ctx.StringValue("GetEmonMonitorData.RequestId");
			getEmonMonitorDataResponse.Code = _ctx.StringValue("GetEmonMonitorData.Code");
			getEmonMonitorDataResponse.Message = _ctx.StringValue("GetEmonMonitorData.Message");
			getEmonMonitorDataResponse.Success = _ctx.BooleanValue("GetEmonMonitorData.Success");

			List<GetEmonMonitorDataResponse.GetEmonMonitorData_ResultItem> getEmonMonitorDataResponse_result = new List<GetEmonMonitorDataResponse.GetEmonMonitorData_ResultItem>();
			for (int i = 0; i < _ctx.Length("GetEmonMonitorData.Result.Length"); i++) {
				GetEmonMonitorDataResponse.GetEmonMonitorData_ResultItem resultItem = new GetEmonMonitorDataResponse.GetEmonMonitorData_ResultItem();
				resultItem.Dps = _ctx.StringValue("GetEmonMonitorData.Result["+ i +"].dps");
				resultItem.Integrity = _ctx.FloatValue("GetEmonMonitorData.Result["+ i +"].integrity");
				resultItem.MessageWatermark = _ctx.LongValue("GetEmonMonitorData.Result["+ i +"].messageWatermark");
				resultItem.Metric = _ctx.StringValue("GetEmonMonitorData.Result["+ i +"].metric");
				resultItem.Summary = _ctx.FloatValue("GetEmonMonitorData.Result["+ i +"].summary");
				resultItem.Tags = _ctx.StringValue("GetEmonMonitorData.Result["+ i +"].tags");

				getEmonMonitorDataResponse_result.Add(resultItem);
			}
			getEmonMonitorDataResponse.Result = getEmonMonitorDataResponse_result;
        
			return getEmonMonitorDataResponse;
        }
    }
}
