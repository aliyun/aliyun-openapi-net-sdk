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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.LinkFace.Model.V20180720;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.LinkFace.Transform.V20180720
{
    public class QueryGroupUsersResponseUnmarshaller
    {
        public static QueryGroupUsersResponse Unmarshall(UnmarshallerContext context)
        {
			QueryGroupUsersResponse queryGroupUsersResponse = new QueryGroupUsersResponse();

			queryGroupUsersResponse.HttpResponse = context.HttpResponse;
			queryGroupUsersResponse.Code = context.IntegerValue("QueryGroupUsers.Code");
			queryGroupUsersResponse.RequestId = context.StringValue("QueryGroupUsers.RequestId");
			queryGroupUsersResponse.Message = context.StringValue("QueryGroupUsers.Message");
			queryGroupUsersResponse.PageCount = context.IntegerValue("QueryGroupUsers.PageCount");
			queryGroupUsersResponse.PageSize = context.IntegerValue("QueryGroupUsers.PageSize");
			queryGroupUsersResponse.Page = context.IntegerValue("QueryGroupUsers.Page");
			queryGroupUsersResponse.Total = context.IntegerValue("QueryGroupUsers.Total");
			queryGroupUsersResponse.Success = context.BooleanValue("QueryGroupUsers.Success");

			List<QueryGroupUsersResponse.QueryGroupUsers_DataItem> queryGroupUsersResponse_data = new List<QueryGroupUsersResponse.QueryGroupUsers_DataItem>();
			for (int i = 0; i < context.Length("QueryGroupUsers.Data.Length"); i++) {
				QueryGroupUsersResponse.QueryGroupUsers_DataItem dataItem = new QueryGroupUsersResponse.QueryGroupUsers_DataItem();
				dataItem.UserId = context.StringValue("QueryGroupUsers.Data["+ i +"].UserId");

				queryGroupUsersResponse_data.Add(dataItem);
			}
			queryGroupUsersResponse.Data = queryGroupUsersResponse_data;
        
			return queryGroupUsersResponse;
        }
    }
}