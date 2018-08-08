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
    public class QueryAllGroupsResponseUnmarshaller
    {
        public static QueryAllGroupsResponse Unmarshall(UnmarshallerContext context)
        {
			QueryAllGroupsResponse queryAllGroupsResponse = new QueryAllGroupsResponse();

			queryAllGroupsResponse.HttpResponse = context.HttpResponse;
			queryAllGroupsResponse.Code = context.IntegerValue("QueryAllGroups.Code");
			queryAllGroupsResponse.RequestId = context.StringValue("QueryAllGroups.RequestId");
			queryAllGroupsResponse.Message = context.StringValue("QueryAllGroups.Message");
			queryAllGroupsResponse.PageCount = context.IntegerValue("QueryAllGroups.PageCount");
			queryAllGroupsResponse.PageSize = context.IntegerValue("QueryAllGroups.PageSize");
			queryAllGroupsResponse.Page = context.IntegerValue("QueryAllGroups.Page");
			queryAllGroupsResponse.Total = context.IntegerValue("QueryAllGroups.Total");
			queryAllGroupsResponse.Success = context.BooleanValue("QueryAllGroups.Success");

			QueryAllGroupsResponse.QueryAllGroups_Data data = new QueryAllGroupsResponse.QueryAllGroups_Data();

			List<string> data_groups = new List<string>();
			for (int i = 0; i < context.Length("QueryAllGroups.Data.Groups.Length"); i++) {
				data_groups.Add(context.StringValue("QueryAllGroups.Data.Groups["+ i +"]"));
			}
			data.Groups = data_groups;
			queryAllGroupsResponse.Data = data;
        
			return queryAllGroupsResponse;
        }
    }
}