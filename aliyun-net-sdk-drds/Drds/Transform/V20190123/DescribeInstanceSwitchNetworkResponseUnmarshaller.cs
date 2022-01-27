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
using Aliyun.Acs.Drds.Model.V20190123;

namespace Aliyun.Acs.Drds.Transform.V20190123
{
    public class DescribeInstanceSwitchNetworkResponseUnmarshaller
    {
        public static DescribeInstanceSwitchNetworkResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeInstanceSwitchNetworkResponse describeInstanceSwitchNetworkResponse = new DescribeInstanceSwitchNetworkResponse();

			describeInstanceSwitchNetworkResponse.HttpResponse = _ctx.HttpResponse;
			describeInstanceSwitchNetworkResponse.RequestId = _ctx.StringValue("DescribeInstanceSwitchNetwork.RequestId");
			describeInstanceSwitchNetworkResponse.Success = _ctx.BooleanValue("DescribeInstanceSwitchNetwork.Success");

			List<DescribeInstanceSwitchNetworkResponse.DescribeInstanceSwitchNetwork_VpcInfo> describeInstanceSwitchNetworkResponse_vpcInfos = new List<DescribeInstanceSwitchNetworkResponse.DescribeInstanceSwitchNetwork_VpcInfo>();
			for (int i = 0; i < _ctx.Length("DescribeInstanceSwitchNetwork.VpcInfos.Length"); i++) {
				DescribeInstanceSwitchNetworkResponse.DescribeInstanceSwitchNetwork_VpcInfo vpcInfo = new DescribeInstanceSwitchNetworkResponse.DescribeInstanceSwitchNetwork_VpcInfo();
				vpcInfo.VpcId = _ctx.StringValue("DescribeInstanceSwitchNetwork.VpcInfos["+ i +"].VpcId");
				vpcInfo.RegionId = _ctx.StringValue("DescribeInstanceSwitchNetwork.VpcInfos["+ i +"].RegionId");
				vpcInfo.VpcName = _ctx.StringValue("DescribeInstanceSwitchNetwork.VpcInfos["+ i +"].VpcName");

				List<DescribeInstanceSwitchNetworkResponse.DescribeInstanceSwitchNetwork_VpcInfo.DescribeInstanceSwitchNetwork_VswitchInfo> vpcInfo_vswitchInfos = new List<DescribeInstanceSwitchNetworkResponse.DescribeInstanceSwitchNetwork_VpcInfo.DescribeInstanceSwitchNetwork_VswitchInfo>();
				for (int j = 0; j < _ctx.Length("DescribeInstanceSwitchNetwork.VpcInfos["+ i +"].VswitchInfos.Length"); j++) {
					DescribeInstanceSwitchNetworkResponse.DescribeInstanceSwitchNetwork_VpcInfo.DescribeInstanceSwitchNetwork_VswitchInfo vswitchInfo = new DescribeInstanceSwitchNetworkResponse.DescribeInstanceSwitchNetwork_VpcInfo.DescribeInstanceSwitchNetwork_VswitchInfo();
					vswitchInfo.VswitchId = _ctx.StringValue("DescribeInstanceSwitchNetwork.VpcInfos["+ i +"].VswitchInfos["+ j +"].VswitchId");
					vswitchInfo.VpcId = _ctx.StringValue("DescribeInstanceSwitchNetwork.VpcInfos["+ i +"].VswitchInfos["+ j +"].VpcId");
					vswitchInfo.VswitchName = _ctx.StringValue("DescribeInstanceSwitchNetwork.VpcInfos["+ i +"].VswitchInfos["+ j +"].VswitchName");
					vswitchInfo.AzoneId = _ctx.StringValue("DescribeInstanceSwitchNetwork.VpcInfos["+ i +"].VswitchInfos["+ j +"].AzoneId");
					vswitchInfo.DrdsSupported = _ctx.BooleanValue("DescribeInstanceSwitchNetwork.VpcInfos["+ i +"].VswitchInfos["+ j +"].DrdsSupported");

					vpcInfo_vswitchInfos.Add(vswitchInfo);
				}
				vpcInfo.VswitchInfos = vpcInfo_vswitchInfos;

				describeInstanceSwitchNetworkResponse_vpcInfos.Add(vpcInfo);
			}
			describeInstanceSwitchNetworkResponse.VpcInfos = describeInstanceSwitchNetworkResponse_vpcInfos;
        
			return describeInstanceSwitchNetworkResponse;
        }
    }
}
