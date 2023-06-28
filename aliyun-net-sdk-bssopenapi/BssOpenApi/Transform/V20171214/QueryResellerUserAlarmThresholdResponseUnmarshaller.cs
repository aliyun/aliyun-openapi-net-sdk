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
using Aliyun.Acs.BssOpenApi.Model.V20171214;

namespace Aliyun.Acs.BssOpenApi.Transform.V20171214
{
    public class QueryResellerUserAlarmThresholdResponseUnmarshaller
    {
        public static QueryResellerUserAlarmThresholdResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryResellerUserAlarmThresholdResponse queryResellerUserAlarmThresholdResponse = new QueryResellerUserAlarmThresholdResponse();

			queryResellerUserAlarmThresholdResponse.HttpResponse = _ctx.HttpResponse;
			queryResellerUserAlarmThresholdResponse.Count = _ctx.IntegerValue("QueryResellerUserAlarmThreshold.Count");
			queryResellerUserAlarmThresholdResponse.Success = _ctx.BooleanValue("QueryResellerUserAlarmThreshold.Success");
			queryResellerUserAlarmThresholdResponse.Code = _ctx.StringValue("QueryResellerUserAlarmThreshold.Code");
			queryResellerUserAlarmThresholdResponse.Message = _ctx.StringValue("QueryResellerUserAlarmThreshold.Message");
			queryResellerUserAlarmThresholdResponse.RequestId = _ctx.StringValue("QueryResellerUserAlarmThreshold.RequestId");

			List<QueryResellerUserAlarmThresholdResponse.QueryResellerUserAlarmThreshold_DataItem> queryResellerUserAlarmThresholdResponse_data = new List<QueryResellerUserAlarmThresholdResponse.QueryResellerUserAlarmThreshold_DataItem>();
			for (int i = 0; i < _ctx.Length("QueryResellerUserAlarmThreshold.Data.Length"); i++) {
				QueryResellerUserAlarmThresholdResponse.QueryResellerUserAlarmThreshold_DataItem dataItem = new QueryResellerUserAlarmThresholdResponse.QueryResellerUserAlarmThreshold_DataItem();
				dataItem.ThresholdType = _ctx.IntegerValue("QueryResellerUserAlarmThreshold.Data["+ i +"].ThresholdType");
				dataItem.ThresholdAmount = _ctx.StringValue("QueryResellerUserAlarmThreshold.Data["+ i +"].ThresholdAmount");
				dataItem.Numerator = _ctx.IntegerValue("QueryResellerUserAlarmThreshold.Data["+ i +"].Numerator");
				dataItem.Denominator = _ctx.IntegerValue("QueryResellerUserAlarmThreshold.Data["+ i +"].Denominator");

				queryResellerUserAlarmThresholdResponse_data.Add(dataItem);
			}
			queryResellerUserAlarmThresholdResponse.Data = queryResellerUserAlarmThresholdResponse_data;
        
			return queryResellerUserAlarmThresholdResponse;
        }
    }
}
