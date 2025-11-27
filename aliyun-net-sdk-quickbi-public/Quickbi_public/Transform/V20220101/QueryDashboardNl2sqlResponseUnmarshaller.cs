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
using Aliyun.Acs.quickbi_public.Model.V20220101;

namespace Aliyun.Acs.quickbi_public.Transform.V20220101
{
    public class QueryDashboardNl2sqlResponseUnmarshaller
    {
        public static QueryDashboardNl2sqlResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryDashboardNl2sqlResponse queryDashboardNl2sqlResponse = new QueryDashboardNl2sqlResponse();

			queryDashboardNl2sqlResponse.HttpResponse = _ctx.HttpResponse;
			queryDashboardNl2sqlResponse.RequestId = _ctx.StringValue("QueryDashboardNl2sql.RequestId");
			queryDashboardNl2sqlResponse.Success = _ctx.BooleanValue("QueryDashboardNl2sql.Success");

			List<QueryDashboardNl2sqlResponse.QueryDashboardNl2sql_Data> queryDashboardNl2sqlResponse_result = new List<QueryDashboardNl2sqlResponse.QueryDashboardNl2sql_Data>();
			for (int i = 0; i < _ctx.Length("QueryDashboardNl2sql.Result.Length"); i++) {
				QueryDashboardNl2sqlResponse.QueryDashboardNl2sql_Data data = new QueryDashboardNl2sqlResponse.QueryDashboardNl2sql_Data();
				data.DashboardName = _ctx.StringValue("QueryDashboardNl2sql.Result["+ i +"].DashboardName");
				data.DashboardNl2sqlId = _ctx.StringValue("QueryDashboardNl2sql.Result["+ i +"].DashboardNl2sqlId");
				data.OwnerId = _ctx.StringValue("QueryDashboardNl2sql.Result["+ i +"].OwnerId");

				List<string> data_authorities = new List<string>();
				for (int j = 0; j < _ctx.Length("QueryDashboardNl2sql.Result["+ i +"].Authorities.Length"); j++) {
					data_authorities.Add(_ctx.StringValue("QueryDashboardNl2sql.Result["+ i +"].Authorities["+ j +"]"));
				}
				data.Authorities = data_authorities;

				queryDashboardNl2sqlResponse_result.Add(data);
			}
			queryDashboardNl2sqlResponse.Result = queryDashboardNl2sqlResponse_result;
        
			return queryDashboardNl2sqlResponse;
        }
    }
}
