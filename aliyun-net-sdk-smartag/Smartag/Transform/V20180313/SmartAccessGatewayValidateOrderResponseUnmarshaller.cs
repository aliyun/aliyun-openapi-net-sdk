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
    public class SmartAccessGatewayValidateOrderResponseUnmarshaller
    {
        public static SmartAccessGatewayValidateOrderResponse Unmarshall(UnmarshallerContext context)
        {
			SmartAccessGatewayValidateOrderResponse smartAccessGatewayValidateOrderResponse = new SmartAccessGatewayValidateOrderResponse();

			smartAccessGatewayValidateOrderResponse.HttpResponse = context.HttpResponse;
			smartAccessGatewayValidateOrderResponse.RequestId = context.StringValue("SmartAccessGatewayValidateOrder.RequestId");
			smartAccessGatewayValidateOrderResponse.Data = context.StringValue("SmartAccessGatewayValidateOrder.Data");
			smartAccessGatewayValidateOrderResponse.Code = context.StringValue("SmartAccessGatewayValidateOrder.Code");
			smartAccessGatewayValidateOrderResponse.Success = context.BooleanValue("SmartAccessGatewayValidateOrder.Success");
			smartAccessGatewayValidateOrderResponse.Message = context.StringValue("SmartAccessGatewayValidateOrder.Message");
        
			return smartAccessGatewayValidateOrderResponse;
        }
    }
}
