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
using Aliyun.Acs.imm.Model.V20170906;

namespace Aliyun.Acs.imm.Transform.V20170906
{
    public class ListFaceSearchGroupsResponseUnmarshaller
    {
        public static ListFaceSearchGroupsResponse Unmarshall(UnmarshallerContext context)
        {
			ListFaceSearchGroupsResponse listFaceSearchGroupsResponse = new ListFaceSearchGroupsResponse();

			listFaceSearchGroupsResponse.HttpResponse = context.HttpResponse;
			listFaceSearchGroupsResponse.RequestId = context.StringValue("ListFaceSearchGroups.RequestId");
			listFaceSearchGroupsResponse.NextMarker = context.StringValue("ListFaceSearchGroups.NextMarker");

			List<ListFaceSearchGroupsResponse.ListFaceSearchGroups_GroupsItem> listFaceSearchGroupsResponse_groups = new List<ListFaceSearchGroupsResponse.ListFaceSearchGroups_GroupsItem>();
			for (int i = 0; i < context.Length("ListFaceSearchGroups.Groups.Length"); i++) {
				ListFaceSearchGroupsResponse.ListFaceSearchGroups_GroupsItem groupsItem = new ListFaceSearchGroupsResponse.ListFaceSearchGroups_GroupsItem();
				groupsItem.GroupName = context.StringValue("ListFaceSearchGroups.Groups["+ i +"].GroupName");
				groupsItem.Count = context.StringValue("ListFaceSearchGroups.Groups["+ i +"].Count");
				groupsItem.Status = context.StringValue("ListFaceSearchGroups.Groups["+ i +"].Status");
				groupsItem.CreateTime = context.StringValue("ListFaceSearchGroups.Groups["+ i +"].CreateTime");
				groupsItem.ModifyTime = context.StringValue("ListFaceSearchGroups.Groups["+ i +"].ModifyTime");
				groupsItem.GroupId = context.StringValue("ListFaceSearchGroups.Groups["+ i +"].GroupId");

				listFaceSearchGroupsResponse_groups.Add(groupsItem);
			}
			listFaceSearchGroupsResponse.Groups = listFaceSearchGroupsResponse_groups;
        
			return listFaceSearchGroupsResponse;
        }
    }
}
