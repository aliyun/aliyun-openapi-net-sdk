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
    public class DescribeGatewayInfoResponseUnmarshaller
    {
        public static DescribeGatewayInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeGatewayInfoResponse describeGatewayInfoResponse = new DescribeGatewayInfoResponse();

			describeGatewayInfoResponse.HttpResponse = _ctx.HttpResponse;
			describeGatewayInfoResponse.RequestId = _ctx.StringValue("DescribeGatewayInfo.RequestId");
			describeGatewayInfoResponse.Success = _ctx.BooleanValue("DescribeGatewayInfo.Success");
			describeGatewayInfoResponse.Code = _ctx.StringValue("DescribeGatewayInfo.Code");
			describeGatewayInfoResponse.Message = _ctx.StringValue("DescribeGatewayInfo.Message");

			List<DescribeGatewayInfoResponse.DescribeGatewayInfo_GatewayInfo> describeGatewayInfoResponse_gatewayInfos = new List<DescribeGatewayInfoResponse.DescribeGatewayInfo_GatewayInfo>();
			for (int i = 0; i < _ctx.Length("DescribeGatewayInfo.GatewayInfos.Length"); i++) {
				DescribeGatewayInfoResponse.DescribeGatewayInfo_GatewayInfo gatewayInfo = new DescribeGatewayInfoResponse.DescribeGatewayInfo_GatewayInfo();
				gatewayInfo.Time = _ctx.LongValue("DescribeGatewayInfo.GatewayInfos["+ i +"].Time");
				gatewayInfo.Info = _ctx.StringValue("DescribeGatewayInfo.GatewayInfos["+ i +"].Info");

				describeGatewayInfoResponse_gatewayInfos.Add(gatewayInfo);
			}
			describeGatewayInfoResponse.GatewayInfos = describeGatewayInfoResponse_gatewayInfos;
        
			return describeGatewayInfoResponse;
        }
    }
}
