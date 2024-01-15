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
using Aliyun.Acs.hitsdb.Model.V20200615;

namespace Aliyun.Acs.hitsdb.Transform.V20200615
{
    public class GetInstanceSecurityGroupsResponseUnmarshaller
    {
        public static GetInstanceSecurityGroupsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetInstanceSecurityGroupsResponse getInstanceSecurityGroupsResponse = new GetInstanceSecurityGroupsResponse();

			getInstanceSecurityGroupsResponse.HttpResponse = _ctx.HttpResponse;
			getInstanceSecurityGroupsResponse.InstanceId = _ctx.StringValue("GetInstanceSecurityGroups.InstanceId");
			getInstanceSecurityGroupsResponse.RequestId = _ctx.StringValue("GetInstanceSecurityGroups.RequestId");

			List<string> getInstanceSecurityGroupsResponse_securityGroups = new List<string>();
			for (int i = 0; i < _ctx.Length("GetInstanceSecurityGroups.SecurityGroups.Length"); i++) {
				getInstanceSecurityGroupsResponse_securityGroups.Add(_ctx.StringValue("GetInstanceSecurityGroups.SecurityGroups["+ i +"]"));
			}
			getInstanceSecurityGroupsResponse.SecurityGroups = getInstanceSecurityGroupsResponse_securityGroups;
        
			return getInstanceSecurityGroupsResponse;
        }
    }
}
