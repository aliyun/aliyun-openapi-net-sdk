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
    public class QueryShareListResponseUnmarshaller
    {
        public static QueryShareListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryShareListResponse queryShareListResponse = new QueryShareListResponse();

			queryShareListResponse.HttpResponse = _ctx.HttpResponse;
			queryShareListResponse.Success = _ctx.BooleanValue("QueryShareList.Success");
			queryShareListResponse.RequestId = _ctx.StringValue("QueryShareList.RequestId");

			List<QueryShareListResponse.QueryShareList_Data> queryShareListResponse_result = new List<QueryShareListResponse.QueryShareList_Data>();
			for (int i = 0; i < _ctx.Length("QueryShareList.Result.Length"); i++) {
				QueryShareListResponse.QueryShareList_Data data = new QueryShareListResponse.QueryShareList_Data();
				data.ShareId = _ctx.StringValue("QueryShareList.Result["+ i +"].ShareId");
				data.ShareToId = _ctx.StringValue("QueryShareList.Result["+ i +"].ShareToId");
				data.AuthPoint = _ctx.IntegerValue("QueryShareList.Result["+ i +"].AuthPoint");
				data.ExpireDate = _ctx.LongValue("QueryShareList.Result["+ i +"].ExpireDate");
				data.ShareToType = _ctx.IntegerValue("QueryShareList.Result["+ i +"].ShareToType");
				data.ReportId = _ctx.StringValue("QueryShareList.Result["+ i +"].ReportId");
				data.ShareToName = _ctx.StringValue("QueryShareList.Result["+ i +"].ShareToName");
				data.ShareType = _ctx.StringValue("QueryShareList.Result["+ i +"].ShareType");

				queryShareListResponse_result.Add(data);
			}
			queryShareListResponse.Result = queryShareListResponse_result;
        
			return queryShareListResponse;
        }
    }
}
