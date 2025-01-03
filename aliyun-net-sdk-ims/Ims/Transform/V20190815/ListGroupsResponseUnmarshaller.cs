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
    public class ListGroupsResponseUnmarshaller
    {
        public static ListGroupsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListGroupsResponse listGroupsResponse = new ListGroupsResponse();

			listGroupsResponse.HttpResponse = _ctx.HttpResponse;
			listGroupsResponse.RequestId = _ctx.StringValue("ListGroups.RequestId");
			listGroupsResponse.IsTruncated = _ctx.BooleanValue("ListGroups.IsTruncated");
			listGroupsResponse.Marker = _ctx.StringValue("ListGroups.Marker");

			List<ListGroupsResponse.ListGroups_Group> listGroupsResponse_groups = new List<ListGroupsResponse.ListGroups_Group>();
			for (int i = 0; i < _ctx.Length("ListGroups.Groups.Length"); i++) {
				ListGroupsResponse.ListGroups_Group group = new ListGroupsResponse.ListGroups_Group();
				group.DisplayName = _ctx.StringValue("ListGroups.Groups["+ i +"].DisplayName");
				group.GroupPrincipalName = _ctx.StringValue("ListGroups.Groups["+ i +"].GroupPrincipalName");
				group.GroupId = _ctx.StringValue("ListGroups.Groups["+ i +"].GroupId");
				group.UpdateDate = _ctx.StringValue("ListGroups.Groups["+ i +"].UpdateDate");
				group.GroupName = _ctx.StringValue("ListGroups.Groups["+ i +"].GroupName");
				group.Comments = _ctx.StringValue("ListGroups.Groups["+ i +"].Comments");
				group.CreateDate = _ctx.StringValue("ListGroups.Groups["+ i +"].CreateDate");

				listGroupsResponse_groups.Add(group);
			}
			listGroupsResponse.Groups = listGroupsResponse_groups;
        
			return listGroupsResponse;
        }
    }
}
