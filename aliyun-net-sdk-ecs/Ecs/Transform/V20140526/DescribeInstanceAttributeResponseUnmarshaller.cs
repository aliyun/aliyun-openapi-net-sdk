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
using Aliyun.Acs.Ecs.Model.V20140526;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeInstanceAttributeResponseUnmarshaller
    {
        public static DescribeInstanceAttributeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeInstanceAttributeResponse describeInstanceAttributeResponse = new DescribeInstanceAttributeResponse();

			describeInstanceAttributeResponse.HttpResponse = _ctx.HttpResponse;
			describeInstanceAttributeResponse.Status = _ctx.StringValue("DescribeInstanceAttribute.Status");
			describeInstanceAttributeResponse.SerialNumber = _ctx.StringValue("DescribeInstanceAttribute.SerialNumber");
			describeInstanceAttributeResponse.CreationTime = _ctx.StringValue("DescribeInstanceAttribute.CreationTime");
			describeInstanceAttributeResponse.RequestId = _ctx.StringValue("DescribeInstanceAttribute.RequestId");
			describeInstanceAttributeResponse.Description = _ctx.StringValue("DescribeInstanceAttribute.Description");
			describeInstanceAttributeResponse.InstanceName = _ctx.StringValue("DescribeInstanceAttribute.InstanceName");
			describeInstanceAttributeResponse.InstanceNetworkType = _ctx.StringValue("DescribeInstanceAttribute.InstanceNetworkType");
			describeInstanceAttributeResponse.Memory = _ctx.IntegerValue("DescribeInstanceAttribute.Memory");
			describeInstanceAttributeResponse.ImageId = _ctx.StringValue("DescribeInstanceAttribute.ImageId");
			describeInstanceAttributeResponse.ClusterId = _ctx.StringValue("DescribeInstanceAttribute.ClusterId");
			describeInstanceAttributeResponse.VlanId = _ctx.StringValue("DescribeInstanceAttribute.VlanId");
			describeInstanceAttributeResponse.StoppedMode = _ctx.StringValue("DescribeInstanceAttribute.StoppedMode");
			describeInstanceAttributeResponse.HostName = _ctx.StringValue("DescribeInstanceAttribute.HostName");
			describeInstanceAttributeResponse.InstanceId = _ctx.StringValue("DescribeInstanceAttribute.InstanceId");
			describeInstanceAttributeResponse.InstanceType = _ctx.StringValue("DescribeInstanceAttribute.InstanceType");
			describeInstanceAttributeResponse.InternetMaxBandwidthIn = _ctx.IntegerValue("DescribeInstanceAttribute.InternetMaxBandwidthIn");
			describeInstanceAttributeResponse.InternetMaxBandwidthOut = _ctx.IntegerValue("DescribeInstanceAttribute.InternetMaxBandwidthOut");
			describeInstanceAttributeResponse.RegionId = _ctx.StringValue("DescribeInstanceAttribute.RegionId");
			describeInstanceAttributeResponse.InstanceChargeType = _ctx.StringValue("DescribeInstanceAttribute.InstanceChargeType");
			describeInstanceAttributeResponse.IoOptimized = _ctx.StringValue("DescribeInstanceAttribute.IoOptimized");
			describeInstanceAttributeResponse.Cpu = _ctx.IntegerValue("DescribeInstanceAttribute.Cpu");
			describeInstanceAttributeResponse.ExpiredTime = _ctx.StringValue("DescribeInstanceAttribute.ExpiredTime");
			describeInstanceAttributeResponse.ZoneId = _ctx.StringValue("DescribeInstanceAttribute.ZoneId");
			describeInstanceAttributeResponse.InternetChargeType = _ctx.StringValue("DescribeInstanceAttribute.InternetChargeType");
			describeInstanceAttributeResponse.CreditSpecification = _ctx.StringValue("DescribeInstanceAttribute.CreditSpecification");

			List<string> describeInstanceAttributeResponse_securityGroupIds = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeInstanceAttribute.SecurityGroupIds.Length"); i++) {
				describeInstanceAttributeResponse_securityGroupIds.Add(_ctx.StringValue("DescribeInstanceAttribute.SecurityGroupIds["+ i +"]"));
			}
			describeInstanceAttributeResponse.SecurityGroupIds = describeInstanceAttributeResponse_securityGroupIds;

			List<string> describeInstanceAttributeResponse_publicIpAddress = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeInstanceAttribute.PublicIpAddress.Length"); i++) {
				describeInstanceAttributeResponse_publicIpAddress.Add(_ctx.StringValue("DescribeInstanceAttribute.PublicIpAddress["+ i +"]"));
			}
			describeInstanceAttributeResponse.PublicIpAddress = describeInstanceAttributeResponse_publicIpAddress;

			List<string> describeInstanceAttributeResponse_innerIpAddress = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeInstanceAttribute.InnerIpAddress.Length"); i++) {
				describeInstanceAttributeResponse_innerIpAddress.Add(_ctx.StringValue("DescribeInstanceAttribute.InnerIpAddress["+ i +"]"));
			}
			describeInstanceAttributeResponse.InnerIpAddress = describeInstanceAttributeResponse_innerIpAddress;

			DescribeInstanceAttributeResponse.DescribeInstanceAttribute_VpcAttributes vpcAttributes = new DescribeInstanceAttributeResponse.DescribeInstanceAttribute_VpcAttributes();
			vpcAttributes.VpcId = _ctx.StringValue("DescribeInstanceAttribute.VpcAttributes.VpcId");
			vpcAttributes.NatIpAddress = _ctx.StringValue("DescribeInstanceAttribute.VpcAttributes.NatIpAddress");
			vpcAttributes.VSwitchId = _ctx.StringValue("DescribeInstanceAttribute.VpcAttributes.VSwitchId");

			List<string> vpcAttributes_privateIpAddress = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeInstanceAttribute.VpcAttributes.PrivateIpAddress.Length"); i++) {
				vpcAttributes_privateIpAddress.Add(_ctx.StringValue("DescribeInstanceAttribute.VpcAttributes.PrivateIpAddress["+ i +"]"));
			}
			vpcAttributes.PrivateIpAddress = vpcAttributes_privateIpAddress;
			describeInstanceAttributeResponse.VpcAttributes = vpcAttributes;

			DescribeInstanceAttributeResponse.DescribeInstanceAttribute_EipAddress eipAddress = new DescribeInstanceAttributeResponse.DescribeInstanceAttribute_EipAddress();
			eipAddress.InternetChargeType = _ctx.StringValue("DescribeInstanceAttribute.EipAddress.InternetChargeType");
			eipAddress.IpAddress = _ctx.StringValue("DescribeInstanceAttribute.EipAddress.IpAddress");
			eipAddress.Bandwidth = _ctx.IntegerValue("DescribeInstanceAttribute.EipAddress.Bandwidth");
			eipAddress.AllocationId = _ctx.StringValue("DescribeInstanceAttribute.EipAddress.AllocationId");
			describeInstanceAttributeResponse.EipAddress = eipAddress;

			DescribeInstanceAttributeResponse.DescribeInstanceAttribute_DedicatedHostAttribute dedicatedHostAttribute = new DescribeInstanceAttributeResponse.DescribeInstanceAttribute_DedicatedHostAttribute();
			dedicatedHostAttribute.DedicatedHostName = _ctx.StringValue("DescribeInstanceAttribute.DedicatedHostAttribute.DedicatedHostName");
			dedicatedHostAttribute.DedicatedHostId = _ctx.StringValue("DescribeInstanceAttribute.DedicatedHostAttribute.DedicatedHostId");
			describeInstanceAttributeResponse.DedicatedHostAttribute = dedicatedHostAttribute;

			List<DescribeInstanceAttributeResponse.DescribeInstanceAttribute_LockReason> describeInstanceAttributeResponse_operationLocks = new List<DescribeInstanceAttributeResponse.DescribeInstanceAttribute_LockReason>();
			for (int i = 0; i < _ctx.Length("DescribeInstanceAttribute.OperationLocks.Length"); i++) {
				DescribeInstanceAttributeResponse.DescribeInstanceAttribute_LockReason lockReason = new DescribeInstanceAttributeResponse.DescribeInstanceAttribute_LockReason();
				lockReason.LockReason = _ctx.StringValue("DescribeInstanceAttribute.OperationLocks["+ i +"].LockReason");

				describeInstanceAttributeResponse_operationLocks.Add(lockReason);
			}
			describeInstanceAttributeResponse.OperationLocks = describeInstanceAttributeResponse_operationLocks;
        
			return describeInstanceAttributeResponse;
        }
    }
}
