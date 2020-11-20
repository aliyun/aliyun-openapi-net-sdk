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
    public class CreateGatewayResponseUnmarshaller
    {
        public static CreateGatewayResponse Unmarshall(UnmarshallerContext context)
        {
			CreateGatewayResponse createGatewayResponse = new CreateGatewayResponse();

			createGatewayResponse.HttpResponse = context.HttpResponse;
			createGatewayResponse.RequestId = context.StringValue("CreateGateway.RequestId");
			createGatewayResponse.Success = context.BooleanValue("CreateGateway.Success");
			createGatewayResponse.Code = context.StringValue("CreateGateway.Code");
			createGatewayResponse.Message = context.StringValue("CreateGateway.Message");
			createGatewayResponse.GatewayId = context.StringValue("CreateGateway.GatewayId");
			createGatewayResponse.BuyURL = context.StringValue("CreateGateway.BuyURL");
        
			return createGatewayResponse;
        }
    }
}
