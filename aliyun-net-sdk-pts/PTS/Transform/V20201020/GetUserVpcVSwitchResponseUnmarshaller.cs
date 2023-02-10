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
    public class GetUserVpcVSwitchResponseUnmarshaller
    {
        public static GetUserVpcVSwitchResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetUserVpcVSwitchResponse getUserVpcVSwitchResponse = new GetUserVpcVSwitchResponse();

			getUserVpcVSwitchResponse.HttpResponse = _ctx.HttpResponse;
			getUserVpcVSwitchResponse.VSwitchCount = _ctx.IntegerValue("GetUserVpcVSwitch.VSwitchCount");
			getUserVpcVSwitchResponse.RequestId = _ctx.StringValue("GetUserVpcVSwitch.RequestId");
			getUserVpcVSwitchResponse.Message = _ctx.StringValue("GetUserVpcVSwitch.Message");
			getUserVpcVSwitchResponse.PageSize = _ctx.IntegerValue("GetUserVpcVSwitch.PageSize");
			getUserVpcVSwitchResponse.PageNumber = _ctx.IntegerValue("GetUserVpcVSwitch.PageNumber");
			getUserVpcVSwitchResponse.HttpStatusCode = _ctx.IntegerValue("GetUserVpcVSwitch.HttpStatusCode");
			getUserVpcVSwitchResponse.Code = _ctx.StringValue("GetUserVpcVSwitch.Code");
			getUserVpcVSwitchResponse.Success = _ctx.BooleanValue("GetUserVpcVSwitch.Success");

			List<GetUserVpcVSwitchResponse.GetUserVpcVSwitch_VSwitch> getUserVpcVSwitchResponse_vSwitchList = new List<GetUserVpcVSwitchResponse.GetUserVpcVSwitch_VSwitch>();
			for (int i = 0; i < _ctx.Length("GetUserVpcVSwitch.VSwitchList.Length"); i++) {
				GetUserVpcVSwitchResponse.GetUserVpcVSwitch_VSwitch vSwitch = new GetUserVpcVSwitchResponse.GetUserVpcVSwitch_VSwitch();
				vSwitch.VpcId = _ctx.StringValue("GetUserVpcVSwitch.VSwitchList["+ i +"].VpcId");
				vSwitch.MaxAgentCount = _ctx.IntegerValue("GetUserVpcVSwitch.VSwitchList["+ i +"].MaxAgentCount");
				vSwitch.AvailableIpAddressCount = _ctx.LongValue("GetUserVpcVSwitch.VSwitchList["+ i +"].AvailableIpAddressCount");
				vSwitch.VSwitchId = _ctx.StringValue("GetUserVpcVSwitch.VSwitchList["+ i +"].VSwitchId");
				vSwitch.VSwitchName = _ctx.StringValue("GetUserVpcVSwitch.VSwitchList["+ i +"].VSwitchName");

				getUserVpcVSwitchResponse_vSwitchList.Add(vSwitch);
			}
			getUserVpcVSwitchResponse.VSwitchList = getUserVpcVSwitchResponse_vSwitchList;
        
			return getUserVpcVSwitchResponse;
        }
    }
}
