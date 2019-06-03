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
    public class QueryUserAlarmThresholdResponseUnmarshaller
    {
        public static QueryUserAlarmThresholdResponse Unmarshall(UnmarshallerContext context)
        {
			QueryUserAlarmThresholdResponse queryUserAlarmThresholdResponse = new QueryUserAlarmThresholdResponse();

			queryUserAlarmThresholdResponse.HttpResponse = context.HttpResponse;
			queryUserAlarmThresholdResponse.RequestId = context.StringValue("QueryUserAlarmThreshold.RequestId");
			queryUserAlarmThresholdResponse.Code = context.StringValue("QueryUserAlarmThreshold.Code");
			queryUserAlarmThresholdResponse.Message = context.StringValue("QueryUserAlarmThreshold.Message");
			queryUserAlarmThresholdResponse.Success = context.BooleanValue("QueryUserAlarmThreshold.Success");
			queryUserAlarmThresholdResponse.Count = context.IntegerValue("QueryUserAlarmThreshold.Count");

			List<QueryUserAlarmThresholdResponse.QueryUserAlarmThreshold_Data> queryUserAlarmThresholdResponse_datas = new List<QueryUserAlarmThresholdResponse.QueryUserAlarmThreshold_Data>();
			for (int i = 0; i < context.Length("QueryUserAlarmThreshold.Datas.Length"); i++) {
				QueryUserAlarmThresholdResponse.QueryUserAlarmThreshold_Data data = new QueryUserAlarmThresholdResponse.QueryUserAlarmThreshold_Data();
				data.ThresholdAmount = context.StringValue("QueryUserAlarmThreshold.Datas["+ i +"].ThresholdAmount");
				data.Numerator = context.IntegerValue("QueryUserAlarmThreshold.Datas["+ i +"].Numerator");
				data.Denominator = context.IntegerValue("QueryUserAlarmThreshold.Datas["+ i +"].Denominator");
				data.ThresholdType = context.IntegerValue("QueryUserAlarmThreshold.Datas["+ i +"].ThresholdType");

				queryUserAlarmThresholdResponse_datas.Add(data);
			}
			queryUserAlarmThresholdResponse.Datas = queryUserAlarmThresholdResponse_datas;
        
			return queryUserAlarmThresholdResponse;
        }
    }
}
