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
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class ListSecurityGroupResponseUnmarshaller
    {
        public static ListSecurityGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListSecurityGroupResponse listSecurityGroupResponse = new ListSecurityGroupResponse();

			listSecurityGroupResponse.HttpResponse = _ctx.HttpResponse;
			listSecurityGroupResponse.RequestId = _ctx.StringValue("ListSecurityGroup.RequestId");

			List<ListSecurityGroupResponse.ListSecurityGroup_SecurityGroup> listSecurityGroupResponse_securityGroupList = new List<ListSecurityGroupResponse.ListSecurityGroup_SecurityGroup>();
			for (int i = 0; i < _ctx.Length("ListSecurityGroup.SecurityGroupList.Length"); i++) {
				ListSecurityGroupResponse.ListSecurityGroup_SecurityGroup securityGroup = new ListSecurityGroupResponse.ListSecurityGroup_SecurityGroup();
				securityGroup.SecurityGroupId = _ctx.StringValue("ListSecurityGroup.SecurityGroupList["+ i +"].SecurityGroupId");
				securityGroup.Description = _ctx.StringValue("ListSecurityGroup.SecurityGroupList["+ i +"].Description");
				securityGroup.SecurityGroupName = _ctx.StringValue("ListSecurityGroup.SecurityGroupList["+ i +"].SecurityGroupName");
				securityGroup.VpcId = _ctx.StringValue("ListSecurityGroup.SecurityGroupList["+ i +"].VpcId");
				securityGroup.CreationTime = _ctx.StringValue("ListSecurityGroup.SecurityGroupList["+ i +"].CreationTime");
				securityGroup.SecurityGroupType = _ctx.StringValue("ListSecurityGroup.SecurityGroupList["+ i +"].SecurityGroupType");
				securityGroup.AvailableInstanceAmount = _ctx.IntegerValue("ListSecurityGroup.SecurityGroupList["+ i +"].AvailableInstanceAmount");
				securityGroup.EcsCount = _ctx.IntegerValue("ListSecurityGroup.SecurityGroupList["+ i +"].EcsCount");

				listSecurityGroupResponse_securityGroupList.Add(securityGroup);
			}
			listSecurityGroupResponse.SecurityGroupList = listSecurityGroupResponse_securityGroupList;
        
			return listSecurityGroupResponse;
        }
    }
}
