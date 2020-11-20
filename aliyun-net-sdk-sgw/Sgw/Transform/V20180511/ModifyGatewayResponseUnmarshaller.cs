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
    public class ModifyGatewayResponseUnmarshaller
    {
        public static ModifyGatewayResponse Unmarshall(UnmarshallerContext context)
        {
			ModifyGatewayResponse modifyGatewayResponse = new ModifyGatewayResponse();

			modifyGatewayResponse.HttpResponse = context.HttpResponse;
			modifyGatewayResponse.RequestId = context.StringValue("ModifyGateway.RequestId");
			modifyGatewayResponse.Success = context.BooleanValue("ModifyGateway.Success");
			modifyGatewayResponse.Code = context.StringValue("ModifyGateway.Code");
			modifyGatewayResponse.Message = context.StringValue("ModifyGateway.Message");
			modifyGatewayResponse.GatewayId = context.StringValue("ModifyGateway.GatewayId");
        
			return modifyGatewayResponse;
        }
    }
}
