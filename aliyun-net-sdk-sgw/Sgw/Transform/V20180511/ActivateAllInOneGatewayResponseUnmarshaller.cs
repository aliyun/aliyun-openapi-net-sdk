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
using Aliyun.Acs.sgw.Model.V20180511;

namespace Aliyun.Acs.sgw.Transform.V20180511
{
    public class ActivateAllInOneGatewayResponseUnmarshaller
    {
        public static ActivateAllInOneGatewayResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ActivateAllInOneGatewayResponse activateAllInOneGatewayResponse = new ActivateAllInOneGatewayResponse();

			activateAllInOneGatewayResponse.HttpResponse = _ctx.HttpResponse;
			activateAllInOneGatewayResponse.RequestId = _ctx.StringValue("ActivateAllInOneGateway.RequestId");
			activateAllInOneGatewayResponse.Success = _ctx.BooleanValue("ActivateAllInOneGateway.Success");
			activateAllInOneGatewayResponse.Code = _ctx.StringValue("ActivateAllInOneGateway.Code");
			activateAllInOneGatewayResponse.Message = _ctx.StringValue("ActivateAllInOneGateway.Message");
			activateAllInOneGatewayResponse.GatewayId = _ctx.StringValue("ActivateAllInOneGateway.GatewayId");
			activateAllInOneGatewayResponse.RegionId = _ctx.StringValue("ActivateAllInOneGateway.RegionId");
			activateAllInOneGatewayResponse.LicenseContent = _ctx.StringValue("ActivateAllInOneGateway.LicenseContent");
        
			return activateAllInOneGatewayResponse;
        }
    }
}
