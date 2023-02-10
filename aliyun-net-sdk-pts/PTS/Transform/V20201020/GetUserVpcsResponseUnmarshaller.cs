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
    public class GetUserVpcsResponseUnmarshaller
    {
        public static GetUserVpcsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetUserVpcsResponse getUserVpcsResponse = new GetUserVpcsResponse();

			getUserVpcsResponse.HttpResponse = _ctx.HttpResponse;
			getUserVpcsResponse.TotalCount = _ctx.LongValue("GetUserVpcs.TotalCount");
			getUserVpcsResponse.RequestId = _ctx.StringValue("GetUserVpcs.RequestId");
			getUserVpcsResponse.Message = _ctx.StringValue("GetUserVpcs.Message");
			getUserVpcsResponse.PageSize = _ctx.IntegerValue("GetUserVpcs.PageSize");
			getUserVpcsResponse.PageNumber = _ctx.IntegerValue("GetUserVpcs.PageNumber");
			getUserVpcsResponse.HttpStatusCode = _ctx.IntegerValue("GetUserVpcs.HttpStatusCode");
			getUserVpcsResponse.Code = _ctx.StringValue("GetUserVpcs.Code");
			getUserVpcsResponse.Success = _ctx.BooleanValue("GetUserVpcs.Success");

			List<GetUserVpcsResponse.GetUserVpcs_Vpc> getUserVpcsResponse_vpcs = new List<GetUserVpcsResponse.GetUserVpcs_Vpc>();
			for (int i = 0; i < _ctx.Length("GetUserVpcs.Vpcs.Length"); i++) {
				GetUserVpcsResponse.GetUserVpcs_Vpc vpc = new GetUserVpcsResponse.GetUserVpcs_Vpc();
				vpc.VpcId = _ctx.StringValue("GetUserVpcs.Vpcs["+ i +"].VpcId");
				vpc.RegionId = _ctx.StringValue("GetUserVpcs.Vpcs["+ i +"].RegionId");
				vpc.VpcName = _ctx.StringValue("GetUserVpcs.Vpcs["+ i +"].VpcName");
				vpc.CidrBlock = _ctx.StringValue("GetUserVpcs.Vpcs["+ i +"].CidrBlock");
				vpc.Description = _ctx.StringValue("GetUserVpcs.Vpcs["+ i +"].Description");
				vpc.ResourceGroupId = _ctx.StringValue("GetUserVpcs.Vpcs["+ i +"].ResourceGroupId");

				List<string> vpc_vSwitchIds = new List<string>();
				for (int j = 0; j < _ctx.Length("GetUserVpcs.Vpcs["+ i +"].VSwitchIds.Length"); j++) {
					vpc_vSwitchIds.Add(_ctx.StringValue("GetUserVpcs.Vpcs["+ i +"].VSwitchIds["+ j +"]"));
				}
				vpc.VSwitchIds = vpc_vSwitchIds;

				List<string> vpc_routerTableIds = new List<string>();
				for (int j = 0; j < _ctx.Length("GetUserVpcs.Vpcs["+ i +"].RouterTableIds.Length"); j++) {
					vpc_routerTableIds.Add(_ctx.StringValue("GetUserVpcs.Vpcs["+ i +"].RouterTableIds["+ j +"]"));
				}
				vpc.RouterTableIds = vpc_routerTableIds;

				getUserVpcsResponse_vpcs.Add(vpc);
			}
			getUserVpcsResponse.Vpcs = getUserVpcsResponse_vpcs;
        
			return getUserVpcsResponse;
        }
    }
}
