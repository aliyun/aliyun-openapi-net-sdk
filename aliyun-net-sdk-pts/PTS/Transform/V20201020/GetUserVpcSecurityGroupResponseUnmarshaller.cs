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
using Aliyun.Acs.PTS.Model.V20201020;

namespace Aliyun.Acs.PTS.Transform.V20201020
{
    public class GetUserVpcSecurityGroupResponseUnmarshaller
    {
        public static GetUserVpcSecurityGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetUserVpcSecurityGroupResponse getUserVpcSecurityGroupResponse = new GetUserVpcSecurityGroupResponse();

			getUserVpcSecurityGroupResponse.HttpResponse = _ctx.HttpResponse;
			getUserVpcSecurityGroupResponse.SecurityGroupCount = _ctx.IntegerValue("GetUserVpcSecurityGroup.SecurityGroupCount");
			getUserVpcSecurityGroupResponse.RequestId = _ctx.StringValue("GetUserVpcSecurityGroup.RequestId");
			getUserVpcSecurityGroupResponse.Message = _ctx.StringValue("GetUserVpcSecurityGroup.Message");
			getUserVpcSecurityGroupResponse.PageSize = _ctx.IntegerValue("GetUserVpcSecurityGroup.PageSize");
			getUserVpcSecurityGroupResponse.PageNumber = _ctx.IntegerValue("GetUserVpcSecurityGroup.PageNumber");
			getUserVpcSecurityGroupResponse.HttpStatusCode = _ctx.IntegerValue("GetUserVpcSecurityGroup.HttpStatusCode");
			getUserVpcSecurityGroupResponse.Code = _ctx.StringValue("GetUserVpcSecurityGroup.Code");
			getUserVpcSecurityGroupResponse.Success = _ctx.BooleanValue("GetUserVpcSecurityGroup.Success");

			List<GetUserVpcSecurityGroupResponse.GetUserVpcSecurityGroup_SecurityGroup> getUserVpcSecurityGroupResponse_securityGroupList = new List<GetUserVpcSecurityGroupResponse.GetUserVpcSecurityGroup_SecurityGroup>();
			for (int i = 0; i < _ctx.Length("GetUserVpcSecurityGroup.SecurityGroupList.Length"); i++) {
				GetUserVpcSecurityGroupResponse.GetUserVpcSecurityGroup_SecurityGroup securityGroup = new GetUserVpcSecurityGroupResponse.GetUserVpcSecurityGroup_SecurityGroup();
				securityGroup.VpcId = _ctx.StringValue("GetUserVpcSecurityGroup.SecurityGroupList["+ i +"].VpcId");
				securityGroup.Description = _ctx.StringValue("GetUserVpcSecurityGroup.SecurityGroupList["+ i +"].Description");
				securityGroup.SecurityGroupId = _ctx.StringValue("GetUserVpcSecurityGroup.SecurityGroupList["+ i +"].SecurityGroupId");
				securityGroup.SecurityGroupName = _ctx.StringValue("GetUserVpcSecurityGroup.SecurityGroupList["+ i +"].SecurityGroupName");

				getUserVpcSecurityGroupResponse_securityGroupList.Add(securityGroup);
			}
			getUserVpcSecurityGroupResponse.SecurityGroupList = getUserVpcSecurityGroupResponse_securityGroupList;
        
			return getUserVpcSecurityGroupResponse;
        }
    }
}
