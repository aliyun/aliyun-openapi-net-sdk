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
    public class QueryEnduserStatusResponseUnmarshaller
    {
        public static QueryEnduserStatusResponse Unmarshall(UnmarshallerContext context)
        {
			QueryEnduserStatusResponse queryEnduserStatusResponse = new QueryEnduserStatusResponse();

			queryEnduserStatusResponse.HttpResponse = context.HttpResponse;
			queryEnduserStatusResponse.RequestId = context.StringValue("QueryEnduserStatus.RequestId");
			queryEnduserStatusResponse.Code = context.StringValue("QueryEnduserStatus.Code");
			queryEnduserStatusResponse.Message = context.StringValue("QueryEnduserStatus.Message");
			queryEnduserStatusResponse.Success = context.BooleanValue("QueryEnduserStatus.Success");
			queryEnduserStatusResponse.Count = context.IntegerValue("QueryEnduserStatus.Count");

			List<QueryEnduserStatusResponse.QueryEnduserStatus_Data> queryEnduserStatusResponse_datas = new List<QueryEnduserStatusResponse.QueryEnduserStatus_Data>();
			for (int i = 0; i < context.Length("QueryEnduserStatus.Datas.Length"); i++) {
				QueryEnduserStatusResponse.QueryEnduserStatus_Data data = new QueryEnduserStatusResponse.QueryEnduserStatus_Data();
				data.Uid = context.LongValue("QueryEnduserStatus.Datas["+ i +"].Uid");
				data.PrimaryAccount = context.StringValue("QueryEnduserStatus.Datas["+ i +"].PrimaryAccount");
				data.BusinessType = context.StringValue("QueryEnduserStatus.Datas["+ i +"].BusinessType");
				data.Status = context.StringValue("QueryEnduserStatus.Datas["+ i +"].Status");

				queryEnduserStatusResponse_datas.Add(data);
			}
			queryEnduserStatusResponse.Datas = queryEnduserStatusResponse_datas;
        
			return queryEnduserStatusResponse;
        }
    }
}
