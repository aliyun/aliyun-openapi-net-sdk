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
    public class UpgradeGatewayResponseUnmarshaller
    {
        public static UpgradeGatewayResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpgradeGatewayResponse upgradeGatewayResponse = new UpgradeGatewayResponse();

			upgradeGatewayResponse.HttpResponse = _ctx.HttpResponse;
			upgradeGatewayResponse.TaskId = _ctx.StringValue("UpgradeGateway.TaskId");
			upgradeGatewayResponse.Message = _ctx.StringValue("UpgradeGateway.Message");
			upgradeGatewayResponse.RequestId = _ctx.StringValue("UpgradeGateway.RequestId");
			upgradeGatewayResponse.Code = _ctx.StringValue("UpgradeGateway.Code");
			upgradeGatewayResponse.Success = _ctx.BooleanValue("UpgradeGateway.Success");
        
			return upgradeGatewayResponse;
        }
    }
}
