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
using Aliyun.Acs.imm.Model.V20170906;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.imm.Transform.V20170906
{
    public class GroupFacesResponseUnmarshaller
    {
        public static GroupFacesResponse Unmarshall(UnmarshallerContext context)
        {
			GroupFacesResponse groupFacesResponse = new GroupFacesResponse();

			groupFacesResponse.HttpResponse = context.HttpResponse;
			groupFacesResponse.RequestId = context.StringValue("GroupFaces.RequestId");
			groupFacesResponse.SetId = context.StringValue("GroupFaces.SetId");
			groupFacesResponse.HasMore = context.IntegerValue("GroupFaces.HasMore");

			List<GroupFacesResponse.GroupFaces_GroupsItem> groupFacesResponse_groups = new List<GroupFacesResponse.GroupFaces_GroupsItem>();
			for (int i = 0; i < context.Length("GroupFaces.Groups.Length"); i++) {
				GroupFacesResponse.GroupFaces_GroupsItem groupsItem = new GroupFacesResponse.GroupFaces_GroupsItem();
				groupsItem.FaceId = context.StringValue("GroupFaces.Groups["+ i +"].FaceId");
				groupsItem.GroupId = context.StringValue("GroupFaces.Groups["+ i +"].GroupId");
				groupsItem.UnGroupReason = context.StringValue("GroupFaces.Groups["+ i +"].UnGroupReason");

				groupFacesResponse_groups.Add(groupsItem);
			}
			groupFacesResponse.Groups = groupFacesResponse_groups;
        
			return groupFacesResponse;
        }
    }
}