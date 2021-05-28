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
    public class DescribeGatewayLDAPInfoResponseUnmarshaller
    {
        public static DescribeGatewayLDAPInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeGatewayLDAPInfoResponse describeGatewayLDAPInfoResponse = new DescribeGatewayLDAPInfoResponse();

			describeGatewayLDAPInfoResponse.HttpResponse = _ctx.HttpResponse;
			describeGatewayLDAPInfoResponse.RequestId = _ctx.StringValue("DescribeGatewayLDAPInfo.RequestId");
			describeGatewayLDAPInfoResponse.Success = _ctx.BooleanValue("DescribeGatewayLDAPInfo.Success");
			describeGatewayLDAPInfoResponse.Code = _ctx.StringValue("DescribeGatewayLDAPInfo.Code");
			describeGatewayLDAPInfoResponse.Message = _ctx.StringValue("DescribeGatewayLDAPInfo.Message");
			describeGatewayLDAPInfoResponse.BaseDN = _ctx.StringValue("DescribeGatewayLDAPInfo.BaseDN");
			describeGatewayLDAPInfoResponse.RootDN = _ctx.StringValue("DescribeGatewayLDAPInfo.RootDN");
			describeGatewayLDAPInfoResponse.ServerIp = _ctx.StringValue("DescribeGatewayLDAPInfo.ServerIp");
			describeGatewayLDAPInfoResponse.IsTls = _ctx.BooleanValue("DescribeGatewayLDAPInfo.IsTls");
			describeGatewayLDAPInfoResponse.IsEnabled = _ctx.BooleanValue("DescribeGatewayLDAPInfo.IsEnabled");
        
			return describeGatewayLDAPInfoResponse;
        }
    }
}
