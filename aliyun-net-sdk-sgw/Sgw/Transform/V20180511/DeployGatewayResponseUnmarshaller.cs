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
    public class DeployGatewayResponseUnmarshaller
    {
        public static DeployGatewayResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DeployGatewayResponse deployGatewayResponse = new DeployGatewayResponse();

			deployGatewayResponse.HttpResponse = _ctx.HttpResponse;
			deployGatewayResponse.RequestId = _ctx.StringValue("DeployGateway.RequestId");
			deployGatewayResponse.Success = _ctx.BooleanValue("DeployGateway.Success");
			deployGatewayResponse.Code = _ctx.StringValue("DeployGateway.Code");
			deployGatewayResponse.Message = _ctx.StringValue("DeployGateway.Message");
			deployGatewayResponse.TaskId = _ctx.StringValue("DeployGateway.TaskId");
        
			return deployGatewayResponse;
        }
    }
}
