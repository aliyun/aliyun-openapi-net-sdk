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
using Aliyun.Acs.OceanBasePro.Model.V20190901;

namespace Aliyun.Acs.OceanBasePro.Transform.V20190901
{
    public class DeleteSecurityIpGroupResponseUnmarshaller
    {
        public static DeleteSecurityIpGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DeleteSecurityIpGroupResponse deleteSecurityIpGroupResponse = new DeleteSecurityIpGroupResponse();

			deleteSecurityIpGroupResponse.HttpResponse = _ctx.HttpResponse;
			deleteSecurityIpGroupResponse.RequestId = _ctx.StringValue("DeleteSecurityIpGroup.RequestId");

			DeleteSecurityIpGroupResponse.DeleteSecurityIpGroup_SecurityIpGroup securityIpGroup = new DeleteSecurityIpGroupResponse.DeleteSecurityIpGroup_SecurityIpGroup();
			securityIpGroup.InstanceId = _ctx.StringValue("DeleteSecurityIpGroup.SecurityIpGroup.InstanceId");
			securityIpGroup.SecurityIpGroupName = _ctx.StringValue("DeleteSecurityIpGroup.SecurityIpGroup.SecurityIpGroupName");
			deleteSecurityIpGroupResponse.SecurityIpGroup = securityIpGroup;
        
			return deleteSecurityIpGroupResponse;
        }
    }
}
