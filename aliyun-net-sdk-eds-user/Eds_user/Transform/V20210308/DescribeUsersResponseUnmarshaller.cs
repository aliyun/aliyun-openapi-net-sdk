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
using Aliyun.Acs.eds_user.Model.V20210308;

namespace Aliyun.Acs.eds_user.Transform.V20210308
{
    public class DescribeUsersResponseUnmarshaller
    {
        public static DescribeUsersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeUsersResponse describeUsersResponse = new DescribeUsersResponse();

			describeUsersResponse.HttpResponse = _ctx.HttpResponse;
			describeUsersResponse.RequestId = _ctx.StringValue("DescribeUsers.RequestId");
			describeUsersResponse.NextToken = _ctx.StringValue("DescribeUsers.NextToken");

			List<DescribeUsersResponse.DescribeUsers_Data> describeUsersResponse_users = new List<DescribeUsersResponse.DescribeUsers_Data>();
			for (int i = 0; i < _ctx.Length("DescribeUsers.Users.Length"); i++) {
				DescribeUsersResponse.DescribeUsers_Data data = new DescribeUsersResponse.DescribeUsers_Data();
				data.Id = _ctx.LongValue("DescribeUsers.Users["+ i +"].Id");
				data.EndUserId = _ctx.StringValue("DescribeUsers.Users["+ i +"].EndUserId");
				data.Email = _ctx.StringValue("DescribeUsers.Users["+ i +"].Email");
				data.Phone = _ctx.StringValue("DescribeUsers.Users["+ i +"].Phone");
				data.Status = _ctx.LongValue("DescribeUsers.Users["+ i +"].Status");
				data.OwnerType = _ctx.StringValue("DescribeUsers.Users["+ i +"].OwnerType");
				data.Remark = _ctx.StringValue("DescribeUsers.Users["+ i +"].Remark");
				data.OrgId = _ctx.StringValue("DescribeUsers.Users["+ i +"].OrgId");
				data.WyId = _ctx.StringValue("DescribeUsers.Users["+ i +"].WyId");
				data.IsTenantManager = _ctx.BooleanValue("DescribeUsers.Users["+ i +"].IsTenantManager");
				data.Avatar = _ctx.StringValue("DescribeUsers.Users["+ i +"].Avatar");
				data.Address = _ctx.StringValue("DescribeUsers.Users["+ i +"].Address");
				data.NickName = _ctx.StringValue("DescribeUsers.Users["+ i +"].NickName");
				data.RealNickName = _ctx.StringValue("DescribeUsers.Users["+ i +"].RealNickName");
				data.JobNumber = _ctx.StringValue("DescribeUsers.Users["+ i +"].JobNumber");
				data.ExternalName = _ctx.StringValue("DescribeUsers.Users["+ i +"].ExternalName");

				DescribeUsersResponse.DescribeUsers_Data.DescribeUsers_Extras extras = new DescribeUsersResponse.DescribeUsers_Data.DescribeUsers_Extras();
				extras.AssignedResourceCount = _ctx.StringValue("DescribeUsers.Users["+ i +"].Extras.AssignedResourceCount");
				data.Extras = extras;

				List<DescribeUsersResponse.DescribeUsers_Data.DescribeUsers_Group> data_groups = new List<DescribeUsersResponse.DescribeUsers_Data.DescribeUsers_Group>();
				for (int j = 0; j < _ctx.Length("DescribeUsers.Users["+ i +"].Groups.Length"); j++) {
					DescribeUsersResponse.DescribeUsers_Data.DescribeUsers_Group group = new DescribeUsersResponse.DescribeUsers_Data.DescribeUsers_Group();
					group.GroupId = _ctx.StringValue("DescribeUsers.Users["+ i +"].Groups["+ j +"].GroupId");
					group.GroupName = _ctx.StringValue("DescribeUsers.Users["+ i +"].Groups["+ j +"].GroupName");

					data_groups.Add(group);
				}
				data.Groups = data_groups;

				List<DescribeUsersResponse.DescribeUsers_Data.DescribeUsers_Org> data_orgs = new List<DescribeUsersResponse.DescribeUsers_Data.DescribeUsers_Org>();
				for (int j = 0; j < _ctx.Length("DescribeUsers.Users["+ i +"].Orgs.Length"); j++) {
					DescribeUsersResponse.DescribeUsers_Data.DescribeUsers_Org org = new DescribeUsersResponse.DescribeUsers_Data.DescribeUsers_Org();
					org.OrgId = _ctx.StringValue("DescribeUsers.Users["+ i +"].Orgs["+ j +"].OrgId");
					org.OrgName = _ctx.StringValue("DescribeUsers.Users["+ i +"].Orgs["+ j +"].OrgName");

					data_orgs.Add(org);
				}
				data.Orgs = data_orgs;

				List<DescribeUsersResponse.DescribeUsers_Data.DescribeUsers_Property> data_properties = new List<DescribeUsersResponse.DescribeUsers_Data.DescribeUsers_Property>();
				for (int j = 0; j < _ctx.Length("DescribeUsers.Users["+ i +"].Properties.Length"); j++) {
					DescribeUsersResponse.DescribeUsers_Data.DescribeUsers_Property property = new DescribeUsersResponse.DescribeUsers_Data.DescribeUsers_Property();
					property.Key = _ctx.StringValue("DescribeUsers.Users["+ i +"].Properties["+ j +"].Key");
					property._Value = _ctx.StringValue("DescribeUsers.Users["+ i +"].Properties["+ j +"].Value");

					data_properties.Add(property);
				}
				data.Properties = data_properties;

				describeUsersResponse_users.Add(data);
			}
			describeUsersResponse.Users = describeUsersResponse_users;
        
			return describeUsersResponse;
        }
    }
}
