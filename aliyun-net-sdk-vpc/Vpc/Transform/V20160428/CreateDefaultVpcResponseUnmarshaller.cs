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
using Aliyun.Acs.Vpc.Model.V20160428;

namespace Aliyun.Acs.Vpc.Transform.V20160428
{
    public class CreateDefaultVpcResponseUnmarshaller
    {
        public static CreateDefaultVpcResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateDefaultVpcResponse createDefaultVpcResponse = new CreateDefaultVpcResponse();

			createDefaultVpcResponse.HttpResponse = _ctx.HttpResponse;
			createDefaultVpcResponse.VpcId = _ctx.StringValue("CreateDefaultVpc.VpcId");
			createDefaultVpcResponse.VRouterId = _ctx.StringValue("CreateDefaultVpc.VRouterId");
			createDefaultVpcResponse.RequestId = _ctx.StringValue("CreateDefaultVpc.RequestId");
			createDefaultVpcResponse.RouteTableId = _ctx.StringValue("CreateDefaultVpc.RouteTableId");

			List<CreateDefaultVpcResponse.CreateDefaultVpc_DefaultVSwitch> createDefaultVpcResponse_defaultVSwitchs = new List<CreateDefaultVpcResponse.CreateDefaultVpc_DefaultVSwitch>();
			for (int i = 0; i < _ctx.Length("CreateDefaultVpc.DefaultVSwitchs.Length"); i++) {
				CreateDefaultVpcResponse.CreateDefaultVpc_DefaultVSwitch defaultVSwitch = new CreateDefaultVpcResponse.CreateDefaultVpc_DefaultVSwitch();
				defaultVSwitch.ZoneId = _ctx.StringValue("CreateDefaultVpc.DefaultVSwitchs["+ i +"].ZoneId");
				defaultVSwitch.VSwitchId = _ctx.StringValue("CreateDefaultVpc.DefaultVSwitchs["+ i +"].VSwitchId");

				createDefaultVpcResponse_defaultVSwitchs.Add(defaultVSwitch);
			}
			createDefaultVpcResponse.DefaultVSwitchs = createDefaultVpcResponse_defaultVSwitchs;
        
			return createDefaultVpcResponse;
        }
    }
}
