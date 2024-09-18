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
    public class QueryUserTagValueListResponseUnmarshaller
    {
        public static QueryUserTagValueListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryUserTagValueListResponse queryUserTagValueListResponse = new QueryUserTagValueListResponse();

			queryUserTagValueListResponse.HttpResponse = _ctx.HttpResponse;
			queryUserTagValueListResponse.RequestId = _ctx.StringValue("QueryUserTagValueList.RequestId");
			queryUserTagValueListResponse.Success = _ctx.BooleanValue("QueryUserTagValueList.Success");

			List<QueryUserTagValueListResponse.QueryUserTagValueList_Data> queryUserTagValueListResponse_result = new List<QueryUserTagValueListResponse.QueryUserTagValueList_Data>();
			for (int i = 0; i < _ctx.Length("QueryUserTagValueList.Result.Length"); i++) {
				QueryUserTagValueListResponse.QueryUserTagValueList_Data data = new QueryUserTagValueListResponse.QueryUserTagValueList_Data();
				data.TagId = _ctx.StringValue("QueryUserTagValueList.Result["+ i +"].TagId");
				data.TagName = _ctx.StringValue("QueryUserTagValueList.Result["+ i +"].TagName");
				data.TagValue = _ctx.StringValue("QueryUserTagValueList.Result["+ i +"].TagValue");

				queryUserTagValueListResponse_result.Add(data);
			}
			queryUserTagValueListResponse.Result = queryUserTagValueListResponse_result;
        
			return queryUserTagValueListResponse;
        }
    }
}
