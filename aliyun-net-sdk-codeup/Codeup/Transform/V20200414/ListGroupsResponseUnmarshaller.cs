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
using Aliyun.Acs.codeup.Model.V20200414;

namespace Aliyun.Acs.codeup.Transform.V20200414
{
    public class ListGroupsResponseUnmarshaller
    {
        public static ListGroupsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListGroupsResponse listGroupsResponse = new ListGroupsResponse();

			listGroupsResponse.HttpResponse = _ctx.HttpResponse;
			listGroupsResponse.RequestId = _ctx.StringValue("ListGroups.RequestId");
			listGroupsResponse.ErrorCode = _ctx.StringValue("ListGroups.ErrorCode");
			listGroupsResponse.Success = _ctx.BooleanValue("ListGroups.Success");
			listGroupsResponse.ErrorMessage = _ctx.StringValue("ListGroups.ErrorMessage");
			listGroupsResponse.Total = _ctx.LongValue("ListGroups.Total");

			List<ListGroupsResponse.ListGroups_ResultItem> listGroupsResponse_result = new List<ListGroupsResponse.ListGroups_ResultItem>();
			for (int i = 0; i < _ctx.Length("ListGroups.Result.Length"); i++) {
				ListGroupsResponse.ListGroups_ResultItem resultItem = new ListGroupsResponse.ListGroups_ResultItem();
				resultItem.Id = _ctx.LongValue("ListGroups.Result["+ i +"].Id");
				resultItem.CreatedAt = _ctx.StringValue("ListGroups.Result["+ i +"].CreatedAt");
				resultItem.UpdatedAt = _ctx.StringValue("ListGroups.Result["+ i +"].UpdatedAt");
				resultItem.AccessLevel = _ctx.IntegerValue("ListGroups.Result["+ i +"].AccessLevel");
				resultItem.Description = _ctx.StringValue("ListGroups.Result["+ i +"].Description");
				resultItem.Name = _ctx.StringValue("ListGroups.Result["+ i +"].Name");
				resultItem.NameWithNamespace = _ctx.StringValue("ListGroups.Result["+ i +"].NameWithNamespace");
				resultItem.OwnerId = _ctx.LongValue("ListGroups.Result["+ i +"].OwnerId");
				resultItem.ParentId = _ctx.LongValue("ListGroups.Result["+ i +"].ParentId");
				resultItem.Path = _ctx.StringValue("ListGroups.Result["+ i +"].Path");
				resultItem.PathWithNamespace = _ctx.StringValue("ListGroups.Result["+ i +"].PathWithNamespace");
				resultItem.Type = _ctx.StringValue("ListGroups.Result["+ i +"].Type");
				resultItem.VisibilityLevel = _ctx.StringValue("ListGroups.Result["+ i +"].VisibilityLevel");
				resultItem.WebUrl = _ctx.StringValue("ListGroups.Result["+ i +"].WebUrl");

				listGroupsResponse_result.Add(resultItem);
			}
			listGroupsResponse.Result = listGroupsResponse_result;
        
			return listGroupsResponse;
        }
    }
}
