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
    public class QueryUserTagMetaListResponseUnmarshaller
    {
        public static QueryUserTagMetaListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryUserTagMetaListResponse queryUserTagMetaListResponse = new QueryUserTagMetaListResponse();

			queryUserTagMetaListResponse.HttpResponse = _ctx.HttpResponse;
			queryUserTagMetaListResponse.Success = _ctx.BooleanValue("QueryUserTagMetaList.Success");
			queryUserTagMetaListResponse.RequestId = _ctx.StringValue("QueryUserTagMetaList.RequestId");

			List<QueryUserTagMetaListResponse.QueryUserTagMetaList_ResultItem> queryUserTagMetaListResponse_result = new List<QueryUserTagMetaListResponse.QueryUserTagMetaList_ResultItem>();
			for (int i = 0; i < _ctx.Length("QueryUserTagMetaList.Result.Length"); i++) {
				QueryUserTagMetaListResponse.QueryUserTagMetaList_ResultItem resultItem = new QueryUserTagMetaListResponse.QueryUserTagMetaList_ResultItem();
				resultItem.TagDescription = _ctx.StringValue("QueryUserTagMetaList.Result["+ i +"].TagDescription");
				resultItem.TagId = _ctx.StringValue("QueryUserTagMetaList.Result["+ i +"].TagId");
				resultItem.TagName = _ctx.StringValue("QueryUserTagMetaList.Result["+ i +"].TagName");

				queryUserTagMetaListResponse_result.Add(resultItem);
			}
			queryUserTagMetaListResponse.Result = queryUserTagMetaListResponse_result;
        
			return queryUserTagMetaListResponse;
        }
    }
}
