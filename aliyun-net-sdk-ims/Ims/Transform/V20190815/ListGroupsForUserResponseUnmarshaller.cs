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
using Aliyun.Acs.Ims.Model.V20190815;

namespace Aliyun.Acs.Ims.Transform.V20190815
{
    public class ListGroupsForUserResponseUnmarshaller
    {
        public static ListGroupsForUserResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListGroupsForUserResponse listGroupsForUserResponse = new ListGroupsForUserResponse();

			listGroupsForUserResponse.HttpResponse = _ctx.HttpResponse;
			listGroupsForUserResponse.RequestId = _ctx.StringValue("ListGroupsForUser.RequestId");

			List<ListGroupsForUserResponse.ListGroupsForUser_Group> listGroupsForUserResponse_groups = new List<ListGroupsForUserResponse.ListGroupsForUser_Group>();
			for (int i = 0; i < _ctx.Length("ListGroupsForUser.Groups.Length"); i++) {
				ListGroupsForUserResponse.ListGroupsForUser_Group group = new ListGroupsForUserResponse.ListGroupsForUser_Group();
				group.DisplayName = _ctx.StringValue("ListGroupsForUser.Groups["+ i +"].DisplayName");
				group.GroupPrincipalName = _ctx.StringValue("ListGroupsForUser.Groups["+ i +"].GroupPrincipalName");
				group.GroupName = _ctx.StringValue("ListGroupsForUser.Groups["+ i +"].GroupName");
				group.GroupId = _ctx.StringValue("ListGroupsForUser.Groups["+ i +"].GroupId");
				group.Comments = _ctx.StringValue("ListGroupsForUser.Groups["+ i +"].Comments");
				group.JoinDate = _ctx.StringValue("ListGroupsForUser.Groups["+ i +"].JoinDate");

				listGroupsForUserResponse_groups.Add(group);
			}
			listGroupsForUserResponse.Groups = listGroupsForUserResponse_groups;
        
			return listGroupsForUserResponse;
        }
    }
}
