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
    public class CreateCustomerGatewayResponseUnmarshaller
    {
        public static CreateCustomerGatewayResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateCustomerGatewayResponse createCustomerGatewayResponse = new CreateCustomerGatewayResponse();

			createCustomerGatewayResponse.HttpResponse = _ctx.HttpResponse;
			createCustomerGatewayResponse.RequestId = _ctx.StringValue("CreateCustomerGateway.RequestId");
			createCustomerGatewayResponse.IpAddress = _ctx.StringValue("CreateCustomerGateway.IpAddress");
			createCustomerGatewayResponse.Description = _ctx.StringValue("CreateCustomerGateway.Description");
			createCustomerGatewayResponse.CustomerGatewayId = _ctx.StringValue("CreateCustomerGateway.CustomerGatewayId");
			createCustomerGatewayResponse.CreateTime = _ctx.LongValue("CreateCustomerGateway.CreateTime");
			createCustomerGatewayResponse.Name = _ctx.StringValue("CreateCustomerGateway.Name");
        
			return createCustomerGatewayResponse;
        }
    }
}
