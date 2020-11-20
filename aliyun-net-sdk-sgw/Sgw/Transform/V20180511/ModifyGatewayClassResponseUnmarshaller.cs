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
    public class ModifyGatewayClassResponseUnmarshaller
    {
        public static ModifyGatewayClassResponse Unmarshall(UnmarshallerContext context)
        {
			ModifyGatewayClassResponse modifyGatewayClassResponse = new ModifyGatewayClassResponse();

			modifyGatewayClassResponse.HttpResponse = context.HttpResponse;
			modifyGatewayClassResponse.RequestId = context.StringValue("ModifyGatewayClass.RequestId");
			modifyGatewayClassResponse.Success = context.BooleanValue("ModifyGatewayClass.Success");
			modifyGatewayClassResponse.Code = context.StringValue("ModifyGatewayClass.Code");
			modifyGatewayClassResponse.Message = context.StringValue("ModifyGatewayClass.Message");
			modifyGatewayClassResponse.TaskId = context.StringValue("ModifyGatewayClass.TaskId");
			modifyGatewayClassResponse.BuyURL = context.StringValue("ModifyGatewayClass.BuyURL");
        
			return modifyGatewayClassResponse;
        }
    }
}
