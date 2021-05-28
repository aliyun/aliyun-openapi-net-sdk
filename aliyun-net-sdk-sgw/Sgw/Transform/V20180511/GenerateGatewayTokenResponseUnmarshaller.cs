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
    public class GenerateGatewayTokenResponseUnmarshaller
    {
        public static GenerateGatewayTokenResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GenerateGatewayTokenResponse generateGatewayTokenResponse = new GenerateGatewayTokenResponse();

			generateGatewayTokenResponse.HttpResponse = _ctx.HttpResponse;
			generateGatewayTokenResponse.RequestId = _ctx.StringValue("GenerateGatewayToken.RequestId");
			generateGatewayTokenResponse.Success = _ctx.BooleanValue("GenerateGatewayToken.Success");
			generateGatewayTokenResponse.Code = _ctx.StringValue("GenerateGatewayToken.Code");
			generateGatewayTokenResponse.Message = _ctx.StringValue("GenerateGatewayToken.Message");
			generateGatewayTokenResponse.Token = _ctx.StringValue("GenerateGatewayToken.Token");
        
			return generateGatewayTokenResponse;
        }
    }
}
