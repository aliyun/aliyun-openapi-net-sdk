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
    public class DescribeEipGatewayInfoResponseUnmarshaller
    {
        public static DescribeEipGatewayInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeEipGatewayInfoResponse describeEipGatewayInfoResponse = new DescribeEipGatewayInfoResponse();

			describeEipGatewayInfoResponse.HttpResponse = _ctx.HttpResponse;
			describeEipGatewayInfoResponse.RequestId = _ctx.StringValue("DescribeEipGatewayInfo.RequestId");
			describeEipGatewayInfoResponse.Code = _ctx.StringValue("DescribeEipGatewayInfo.Code");
			describeEipGatewayInfoResponse.Message = _ctx.StringValue("DescribeEipGatewayInfo.Message");

			List<DescribeEipGatewayInfoResponse.DescribeEipGatewayInfo_EipInfo> describeEipGatewayInfoResponse_eipInfos = new List<DescribeEipGatewayInfoResponse.DescribeEipGatewayInfo_EipInfo>();
			for (int i = 0; i < _ctx.Length("DescribeEipGatewayInfo.EipInfos.Length"); i++) {
				DescribeEipGatewayInfoResponse.DescribeEipGatewayInfo_EipInfo eipInfo = new DescribeEipGatewayInfoResponse.DescribeEipGatewayInfo_EipInfo();
				eipInfo.Ip = _ctx.StringValue("DescribeEipGatewayInfo.EipInfos["+ i +"].Ip");
				eipInfo.IpGw = _ctx.StringValue("DescribeEipGatewayInfo.EipInfos["+ i +"].IpGw");
				eipInfo.IpMask = _ctx.StringValue("DescribeEipGatewayInfo.EipInfos["+ i +"].IpMask");

				describeEipGatewayInfoResponse_eipInfos.Add(eipInfo);
			}
			describeEipGatewayInfoResponse.EipInfos = describeEipGatewayInfoResponse_eipInfos;
        
			return describeEipGatewayInfoResponse;
        }
    }
}
