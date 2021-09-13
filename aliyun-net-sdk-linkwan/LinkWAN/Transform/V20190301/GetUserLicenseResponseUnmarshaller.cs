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
using Aliyun.Acs.LinkWAN.Model.V20190301;

namespace Aliyun.Acs.LinkWAN.Transform.V20190301
{
    public class GetUserLicenseResponseUnmarshaller
    {
        public static GetUserLicenseResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetUserLicenseResponse getUserLicenseResponse = new GetUserLicenseResponse();

			getUserLicenseResponse.HttpResponse = _ctx.HttpResponse;
			getUserLicenseResponse.Success = _ctx.BooleanValue("GetUserLicense.Success");
			getUserLicenseResponse.RequestId = _ctx.StringValue("GetUserLicense.RequestId");

			GetUserLicenseResponse.GetUserLicense_Data data = new GetUserLicenseResponse.GetUserLicense_Data();
			data.Oui = _ctx.StringValue("GetUserLicense.Data.Oui");
			data.GatewayTupleLimit = _ctx.LongValue("GetUserLicense.Data.GatewayTupleLimit");
			data.GatewayTupleCount = _ctx.LongValue("GetUserLicense.Data.GatewayTupleCount");
			data.NodeTupleLimit = _ctx.LongValue("GetUserLicense.Data.NodeTupleLimit");
			data.NodeTupleCount = _ctx.LongValue("GetUserLicense.Data.NodeTupleCount");
			data.GatewayLimit = _ctx.LongValue("GetUserLicense.Data.GatewayLimit");
			data.GatewayCount = _ctx.LongValue("GetUserLicense.Data.GatewayCount");
			data.LocalJoinPermissionLimit = _ctx.LongValue("GetUserLicense.Data.LocalJoinPermissionLimit");
			data.LocalJoinPermissionCount = _ctx.LongValue("GetUserLicense.Data.LocalJoinPermissionCount");
			data.NodeLimit = _ctx.LongValue("GetUserLicense.Data.NodeLimit");
			data.NodeCount = _ctx.LongValue("GetUserLicense.Data.NodeCount");
			data.RoamingJoinPermissionLimit = _ctx.LongValue("GetUserLicense.Data.RoamingJoinPermissionLimit");
			data.RoamingJoinPermissionCount = _ctx.LongValue("GetUserLicense.Data.RoamingJoinPermissionCount");
			data.GatewayTupleFreeLimit = _ctx.LongValue("GetUserLicense.Data.GatewayTupleFreeLimit");
			data.NodeTupleFreeLimit = _ctx.LongValue("GetUserLicense.Data.NodeTupleFreeLimit");
			data.GatewayFreeLimit = _ctx.LongValue("GetUserLicense.Data.GatewayFreeLimit");
			data.LocalJoinPermissionFreeLimit = _ctx.LongValue("GetUserLicense.Data.LocalJoinPermissionFreeLimit");
			data.RoamingJoinPermissionFreeLimit = _ctx.LongValue("GetUserLicense.Data.RoamingJoinPermissionFreeLimit");
			data.NodeFreeLimit = _ctx.LongValue("GetUserLicense.Data.NodeFreeLimit");
			data.RelayLimit = _ctx.LongValue("GetUserLicense.Data.RelayLimit");
			data.RelayCount = _ctx.LongValue("GetUserLicense.Data.RelayCount");
			data.GatewayPrePayCount = _ctx.LongValue("GetUserLicense.Data.GatewayPrePayCount");
			data.NodeTupleRelayLimit = _ctx.LongValue("GetUserLicense.Data.NodeTupleRelayLimit");
			data.NodeTupleRelayCount = _ctx.LongValue("GetUserLicense.Data.NodeTupleRelayCount");
			data.NodeTupleStandardLimit = _ctx.LongValue("GetUserLicense.Data.NodeTupleStandardLimit");
			data.NodeTupleStandardCount = _ctx.LongValue("GetUserLicense.Data.NodeTupleStandardCount");
			data.GatewayTupleHybridLimit = _ctx.LongValue("GetUserLicense.Data.GatewayTupleHybridLimit");
			data.GatewayTupleHybridCount = _ctx.LongValue("GetUserLicense.Data.GatewayTupleHybridCount");
			data.GatewayTupleSingleChannelLimit = _ctx.LongValue("GetUserLicense.Data.GatewayTupleSingleChannelLimit");
			data.GatewayTupleSingleChannelCount = _ctx.LongValue("GetUserLicense.Data.GatewayTupleSingleChannelCount");
			data.GatewayTupleStandardLimit = _ctx.LongValue("GetUserLicense.Data.GatewayTupleStandardLimit");
			data.GatewayTupleStandardCount = _ctx.LongValue("GetUserLicense.Data.GatewayTupleStandardCount");
			data.GatewayDingTalkCount = _ctx.LongValue("GetUserLicense.Data.GatewayDingTalkCount");
			data.GatewayDingTalkLimit = _ctx.LongValue("GetUserLicense.Data.GatewayDingTalkLimit");
			data.GatewayProfessionalCount = _ctx.LongValue("GetUserLicense.Data.GatewayProfessionalCount");
			data.GatewayProfessionalLimit = _ctx.LongValue("GetUserLicense.Data.GatewayProfessionalLimit");
			getUserLicenseResponse.Data = data;
        
			return getUserLicenseResponse;
        }
    }
}
