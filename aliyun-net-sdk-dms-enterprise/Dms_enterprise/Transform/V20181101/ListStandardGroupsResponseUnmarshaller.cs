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
using Aliyun.Acs.dms_enterprise.Model.V20181101;

namespace Aliyun.Acs.dms_enterprise.Transform.V20181101
{
    public class ListStandardGroupsResponseUnmarshaller
    {
        public static ListStandardGroupsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListStandardGroupsResponse listStandardGroupsResponse = new ListStandardGroupsResponse();

			listStandardGroupsResponse.HttpResponse = _ctx.HttpResponse;
			listStandardGroupsResponse.RequestId = _ctx.StringValue("ListStandardGroups.RequestId");
			listStandardGroupsResponse.Success = _ctx.BooleanValue("ListStandardGroups.Success");
			listStandardGroupsResponse.ErrorMessage = _ctx.StringValue("ListStandardGroups.ErrorMessage");
			listStandardGroupsResponse.ErrorCode = _ctx.StringValue("ListStandardGroups.ErrorCode");

			List<ListStandardGroupsResponse.ListStandardGroups_StandardGroupListItem> listStandardGroupsResponse_standardGroupList = new List<ListStandardGroupsResponse.ListStandardGroups_StandardGroupListItem>();
			for (int i = 0; i < _ctx.Length("ListStandardGroups.StandardGroupList.Length"); i++) {
				ListStandardGroupsResponse.ListStandardGroups_StandardGroupListItem standardGroupListItem = new ListStandardGroupsResponse.ListStandardGroups_StandardGroupListItem();
				standardGroupListItem.GroupName = _ctx.StringValue("ListStandardGroups.StandardGroupList["+ i +"].GroupName");
				standardGroupListItem.Description = _ctx.StringValue("ListStandardGroups.StandardGroupList["+ i +"].Description");
				standardGroupListItem.DbType = _ctx.StringValue("ListStandardGroups.StandardGroupList["+ i +"].DbType");
				standardGroupListItem.LastMenderId = _ctx.LongValue("ListStandardGroups.StandardGroupList["+ i +"].LastMenderId");
				standardGroupListItem.GroupMode = _ctx.StringValue("ListStandardGroups.StandardGroupList["+ i +"].GroupMode");

				listStandardGroupsResponse_standardGroupList.Add(standardGroupListItem);
			}
			listStandardGroupsResponse.StandardGroupList = listStandardGroupsResponse_standardGroupList;
        
			return listStandardGroupsResponse;
        }
    }
}
