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
using Aliyun.Acs.antiddos_public.Model.V20170518;

namespace Aliyun.Acs.antiddos_public.Transform.V20170518
{
    public class DescribeInstanceIpAddressResponseUnmarshaller
    {
        public static DescribeInstanceIpAddressResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeInstanceIpAddressResponse describeInstanceIpAddressResponse = new DescribeInstanceIpAddressResponse();

			describeInstanceIpAddressResponse.HttpResponse = _ctx.HttpResponse;
			describeInstanceIpAddressResponse.Total = _ctx.IntegerValue("DescribeInstanceIpAddress.Total");
			describeInstanceIpAddressResponse.RequestId = _ctx.StringValue("DescribeInstanceIpAddress.RequestId");

			List<DescribeInstanceIpAddressResponse.DescribeInstanceIpAddress_Instance> describeInstanceIpAddressResponse_instanceList = new List<DescribeInstanceIpAddressResponse.DescribeInstanceIpAddress_Instance>();
			for (int i = 0; i < _ctx.Length("DescribeInstanceIpAddress.InstanceList.Length"); i++) {
				DescribeInstanceIpAddressResponse.DescribeInstanceIpAddress_Instance instance = new DescribeInstanceIpAddressResponse.DescribeInstanceIpAddress_Instance();
				instance.InstanceId = _ctx.StringValue("DescribeInstanceIpAddress.InstanceList["+ i +"].InstanceId");
				instance.InstanceType = _ctx.StringValue("DescribeInstanceIpAddress.InstanceList["+ i +"].InstanceType");
				instance.InstanceName = _ctx.StringValue("DescribeInstanceIpAddress.InstanceList["+ i +"].InstanceName");
				instance.InstanceStatus = _ctx.StringValue("DescribeInstanceIpAddress.InstanceList["+ i +"].InstanceStatus");

				List<DescribeInstanceIpAddressResponse.DescribeInstanceIpAddress_Instance.DescribeInstanceIpAddress_IpAddressConfigItem> instance_ipAddressConfig = new List<DescribeInstanceIpAddressResponse.DescribeInstanceIpAddress_Instance.DescribeInstanceIpAddress_IpAddressConfigItem>();
				for (int j = 0; j < _ctx.Length("DescribeInstanceIpAddress.InstanceList["+ i +"].IpAddressConfig.Length"); j++) {
					DescribeInstanceIpAddressResponse.DescribeInstanceIpAddress_Instance.DescribeInstanceIpAddress_IpAddressConfigItem ipAddressConfigItem = new DescribeInstanceIpAddressResponse.DescribeInstanceIpAddress_Instance.DescribeInstanceIpAddress_IpAddressConfigItem();
					ipAddressConfigItem.InstanceIp = _ctx.StringValue("DescribeInstanceIpAddress.InstanceList["+ i +"].IpAddressConfig["+ j +"].InstanceIp");
					ipAddressConfigItem.IsBgppack = _ctx.BooleanValue("DescribeInstanceIpAddress.InstanceList["+ i +"].IpAddressConfig["+ j +"].IsBgppack");
					ipAddressConfigItem.IpVersion = _ctx.StringValue("DescribeInstanceIpAddress.InstanceList["+ i +"].IpAddressConfig["+ j +"].IpVersion");
					ipAddressConfigItem.IpStatus = _ctx.StringValue("DescribeInstanceIpAddress.InstanceList["+ i +"].IpAddressConfig["+ j +"].IpStatus");
					ipAddressConfigItem.RegionId = _ctx.StringValue("DescribeInstanceIpAddress.InstanceList["+ i +"].IpAddressConfig["+ j +"].RegionId");
					ipAddressConfigItem.ElasticThreshold = _ctx.IntegerValue("DescribeInstanceIpAddress.InstanceList["+ i +"].IpAddressConfig["+ j +"].ElasticThreshold");
					ipAddressConfigItem.BlackholeThreshold = _ctx.IntegerValue("DescribeInstanceIpAddress.InstanceList["+ i +"].IpAddressConfig["+ j +"].BlackholeThreshold");
					ipAddressConfigItem.DefenseBpsThreshold = _ctx.IntegerValue("DescribeInstanceIpAddress.InstanceList["+ i +"].IpAddressConfig["+ j +"].DefenseBpsThreshold");
					ipAddressConfigItem.DefensePpsThreshold = _ctx.IntegerValue("DescribeInstanceIpAddress.InstanceList["+ i +"].IpAddressConfig["+ j +"].DefensePpsThreshold");

					instance_ipAddressConfig.Add(ipAddressConfigItem);
				}
				instance.IpAddressConfig = instance_ipAddressConfig;

				describeInstanceIpAddressResponse_instanceList.Add(instance);
			}
			describeInstanceIpAddressResponse.InstanceList = describeInstanceIpAddressResponse_instanceList;
        
			return describeInstanceIpAddressResponse;
        }
    }
}
