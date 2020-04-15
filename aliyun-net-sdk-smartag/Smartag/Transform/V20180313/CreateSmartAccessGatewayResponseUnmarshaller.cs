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
using Aliyun.Acs.Smartag.Model.V20180313;

namespace Aliyun.Acs.Smartag.Transform.V20180313
{
    public class CreateSmartAccessGatewayResponseUnmarshaller
    {
        public static CreateSmartAccessGatewayResponse Unmarshall(UnmarshallerContext context)
        {
			CreateSmartAccessGatewayResponse createSmartAccessGatewayResponse = new CreateSmartAccessGatewayResponse();

			createSmartAccessGatewayResponse.HttpResponse = context.HttpResponse;
			createSmartAccessGatewayResponse.RequestId = context.StringValue("CreateSmartAccessGateway.RequestId");
			createSmartAccessGatewayResponse.SmartAGId = context.StringValue("CreateSmartAccessGateway.SmartAGId");
			createSmartAccessGatewayResponse.Name = context.StringValue("CreateSmartAccessGateway.Name");
			createSmartAccessGatewayResponse.OrderId = context.StringValue("CreateSmartAccessGateway.OrderId");
			createSmartAccessGatewayResponse.Description = context.StringValue("CreateSmartAccessGateway.Description");
        
			return createSmartAccessGatewayResponse;
        }
    }
}
