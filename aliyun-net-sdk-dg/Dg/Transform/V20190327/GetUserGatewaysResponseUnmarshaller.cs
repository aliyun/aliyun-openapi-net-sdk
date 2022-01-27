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
using Aliyun.Acs.dg.Model.V20190327;

namespace Aliyun.Acs.dg.Transform.V20190327
{
    public class GetUserGatewaysResponseUnmarshaller
    {
        public static GetUserGatewaysResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetUserGatewaysResponse getUserGatewaysResponse = new GetUserGatewaysResponse();

			getUserGatewaysResponse.HttpResponse = _ctx.HttpResponse;
			getUserGatewaysResponse.RequestId = _ctx.StringValue("GetUserGateways.RequestId");
			getUserGatewaysResponse.Success = _ctx.BooleanValue("GetUserGateways.Success");
			getUserGatewaysResponse.Code = _ctx.StringValue("GetUserGateways.Code");
			getUserGatewaysResponse.ErrorMsg = _ctx.StringValue("GetUserGateways.ErrorMsg");
			getUserGatewaysResponse.Data = _ctx.StringValue("GetUserGateways.Data");
			getUserGatewaysResponse.Count = _ctx.IntegerValue("GetUserGateways.Count");
        
			return getUserGatewaysResponse;
        }
    }
}
