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
        public static ModifyGatewayClassResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ModifyGatewayClassResponse modifyGatewayClassResponse = new ModifyGatewayClassResponse();

			modifyGatewayClassResponse.HttpResponse = _ctx.HttpResponse;
			modifyGatewayClassResponse.BuyURL = _ctx.StringValue("ModifyGatewayClass.BuyURL");
			modifyGatewayClassResponse.TaskId = _ctx.StringValue("ModifyGatewayClass.TaskId");
			modifyGatewayClassResponse.RequestId = _ctx.StringValue("ModifyGatewayClass.RequestId");
			modifyGatewayClassResponse.Message = _ctx.StringValue("ModifyGatewayClass.Message");
			modifyGatewayClassResponse.Code = _ctx.StringValue("ModifyGatewayClass.Code");
			modifyGatewayClassResponse.Success = _ctx.BooleanValue("ModifyGatewayClass.Success");
        
			return modifyGatewayClassResponse;
        }
    }
}
