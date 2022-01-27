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
using Aliyun.Acs.quickbi_public.Model.V20200801;

namespace Aliyun.Acs.quickbi_public.Transform.V20200801
{
    public class QueryUserListResponseUnmarshaller
    {
        public static QueryUserListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryUserListResponse queryUserListResponse = new QueryUserListResponse();

			queryUserListResponse.HttpResponse = _ctx.HttpResponse;
			queryUserListResponse.RequestId = _ctx.StringValue("QueryUserList.RequestId");
			queryUserListResponse.Success = _ctx.BooleanValue("QueryUserList.Success");

			QueryUserListResponse.QueryUserList_Result result = new QueryUserListResponse.QueryUserList_Result();
			result.PageNum = _ctx.IntegerValue("QueryUserList.Result.PageNum");
			result.PageSize = _ctx.IntegerValue("QueryUserList.Result.PageSize");
			result.TotalNum = _ctx.IntegerValue("QueryUserList.Result.TotalNum");
			result.TotalPages = _ctx.IntegerValue("QueryUserList.Result.TotalPages");

			List<QueryUserListResponse.QueryUserList_Result.QueryUserList_DataItem> result_data = new List<QueryUserListResponse.QueryUserList_Result.QueryUserList_DataItem>();
			for (int i = 0; i < _ctx.Length("QueryUserList.Result.Data.Length"); i++) {
				QueryUserListResponse.QueryUserList_Result.QueryUserList_DataItem dataItem = new QueryUserListResponse.QueryUserList_Result.QueryUserList_DataItem();
				dataItem.AccountId = _ctx.StringValue("QueryUserList.Result.Data["+ i +"].AccountId");
				dataItem.AccountName = _ctx.StringValue("QueryUserList.Result.Data["+ i +"].AccountName");
				dataItem.AdminUser = _ctx.BooleanValue("QueryUserList.Result.Data["+ i +"].AdminUser");
				dataItem.AuthAdminUser = _ctx.BooleanValue("QueryUserList.Result.Data["+ i +"].AuthAdminUser");
				dataItem.Email = _ctx.StringValue("QueryUserList.Result.Data["+ i +"].Email");
				dataItem.NickName = _ctx.StringValue("QueryUserList.Result.Data["+ i +"].NickName");
				dataItem.Phone = _ctx.StringValue("QueryUserList.Result.Data["+ i +"].Phone");
				dataItem.UserId = _ctx.StringValue("QueryUserList.Result.Data["+ i +"].UserId");
				dataItem.UserType = _ctx.IntegerValue("QueryUserList.Result.Data["+ i +"].UserType");

				result_data.Add(dataItem);
			}
			result.Data = result_data;
			queryUserListResponse.Result = result;
        
			return queryUserListResponse;
        }
    }
}
