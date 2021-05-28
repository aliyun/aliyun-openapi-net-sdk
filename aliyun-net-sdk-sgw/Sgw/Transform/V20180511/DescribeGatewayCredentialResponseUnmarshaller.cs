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
    public class DescribeGatewayCredentialResponseUnmarshaller
    {
        public static DescribeGatewayCredentialResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeGatewayCredentialResponse describeGatewayCredentialResponse = new DescribeGatewayCredentialResponse();

			describeGatewayCredentialResponse.HttpResponse = _ctx.HttpResponse;
			describeGatewayCredentialResponse.RequestId = _ctx.StringValue("DescribeGatewayCredential.RequestId");
			describeGatewayCredentialResponse.Success = _ctx.BooleanValue("DescribeGatewayCredential.Success");
			describeGatewayCredentialResponse.Code = _ctx.StringValue("DescribeGatewayCredential.Code");
			describeGatewayCredentialResponse.Message = _ctx.StringValue("DescribeGatewayCredential.Message");
			describeGatewayCredentialResponse.EcsIp = _ctx.StringValue("DescribeGatewayCredential.EcsIp");
			describeGatewayCredentialResponse.EcsPassword = _ctx.StringValue("DescribeGatewayCredential.EcsPassword");
			describeGatewayCredentialResponse.ConsoleUsername = _ctx.StringValue("DescribeGatewayCredential.ConsoleUsername");
			describeGatewayCredentialResponse.ConsolePassword = _ctx.StringValue("DescribeGatewayCredential.ConsolePassword");
			describeGatewayCredentialResponse.VpcId = _ctx.StringValue("DescribeGatewayCredential.VpcId");
			describeGatewayCredentialResponse.VSwitchId = _ctx.StringValue("DescribeGatewayCredential.VSwitchId");
        
			return describeGatewayCredentialResponse;
        }
    }
}
