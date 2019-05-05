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
    public class QueryUserOmsDataResponseUnmarshaller
    {
        public static QueryUserOmsDataResponse Unmarshall(UnmarshallerContext context)
        {
			QueryUserOmsDataResponse queryUserOmsDataResponse = new QueryUserOmsDataResponse();

			queryUserOmsDataResponse.HttpResponse = context.HttpResponse;
			queryUserOmsDataResponse.RequestId = context.StringValue("QueryUserOmsData.RequestId");
			queryUserOmsDataResponse.Success = context.BooleanValue("QueryUserOmsData.Success");
			queryUserOmsDataResponse.Code = context.StringValue("QueryUserOmsData.Code");
			queryUserOmsDataResponse.Message = context.StringValue("QueryUserOmsData.Message");

			QueryUserOmsDataResponse.QueryUserOmsData_Data data = new QueryUserOmsDataResponse.QueryUserOmsData_Data();
			data.Marker = context.StringValue("QueryUserOmsData.Data.Marker");
			data.HostId = context.StringValue("QueryUserOmsData.Data.HostId");

			List<string> data_omsData = new List<string>();
			for (int i = 0; i < context.Length("QueryUserOmsData.Data.OmsData.Length"); i++) {
				data_omsData.Add(context.StringValue("QueryUserOmsData.Data.OmsData["+ i +"]"));
			}
			data.OmsData = data_omsData;
			queryUserOmsDataResponse.Data = data;
        
			return queryUserOmsDataResponse;
        }
    }
}
