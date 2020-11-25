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
			describeInstanceAttributeResponse.RequestId = _ctx.StringValue("DescribeInstanceAttribute.RequestId");
			describeInstanceAttributeResponse.InstanceId = _ctx.StringValue("DescribeInstanceAttribute.InstanceId");
			describeInstanceAttributeResponse.InstanceName = _ctx.StringValue("DescribeInstanceAttribute.InstanceName");
			describeInstanceAttributeResponse.ImageId = _ctx.StringValue("DescribeInstanceAttribute.ImageId");
			describeInstanceAttributeResponse.RegionId = _ctx.StringValue("DescribeInstanceAttribute.RegionId");
			describeInstanceAttributeResponse.ZoneId = _ctx.StringValue("DescribeInstanceAttribute.ZoneId");
			describeInstanceAttributeResponse.ClusterId = _ctx.StringValue("DescribeInstanceAttribute.ClusterId");
			describeInstanceAttributeResponse.InstanceType = _ctx.StringValue("DescribeInstanceAttribute.InstanceType");
			describeInstanceAttributeResponse.Cpu = _ctx.IntegerValue("DescribeInstanceAttribute.Cpu");
			describeInstanceAttributeResponse.Memory = _ctx.IntegerValue("DescribeInstanceAttribute.Memory");
			describeInstanceAttributeResponse.HostName = _ctx.StringValue("DescribeInstanceAttribute.HostName");
			describeInstanceAttributeResponse.Status = _ctx.StringValue("DescribeInstanceAttribute.Status");
			describeInstanceAttributeResponse.InternetChargeType = _ctx.StringValue("DescribeInstanceAttribute.InternetChargeType");
			describeInstanceAttributeResponse.InternetMaxBandwidthIn = _ctx.IntegerValue("DescribeInstanceAttribute.InternetMaxBandwidthIn");
			describeInstanceAttributeResponse.InternetMaxBandwidthOut = _ctx.IntegerValue("DescribeInstanceAttribute.InternetMaxBandwidthOut");
			describeInstanceAttributeResponse.VlanId = _ctx.StringValue("DescribeInstanceAttribute.VlanId");
			describeInstanceAttributeResponse.SerialNumber = _ctx.StringValue("DescribeInstanceAttribute.SerialNumber");
			describeInstanceAttributeResponse.CreationTime = _ctx.StringValue("DescribeInstanceAttribute.CreationTime");
			describeInstanceAttributeResponse.Description = _ctx.StringValue("DescribeInstanceAttribute.Description");
			describeInstanceAttributeResponse.InstanceNetworkType = _ctx.StringValue("DescribeInstanceAttribute.InstanceNetworkType");
			describeInstanceAttributeResponse.IoOptimized = _ctx.StringValue("DescribeInstanceAttribute.IoOptimized");
			describeInstanceAttributeResponse.InstanceChargeType = _ctx.StringValue("DescribeInstanceAttribute.InstanceChargeType");
			describeInstanceAttributeResponse.ExpiredTime = _ctx.StringValue("DescribeInstanceAttribute.ExpiredTime");
			describeInstanceAttributeResponse.StoppedMode = _ctx.StringValue("DescribeInstanceAttribute.StoppedMode");
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
			vpcAttributes.VSwitchId = _ctx.StringValue("DescribeInstanceAttribute.VpcAttributes.VSwitchId");
			vpcAttributes.NatIpAddress = _ctx.StringValue("DescribeInstanceAttribute.VpcAttributes.NatIpAddress");

			List<string> vpcAttributes_privateIpAddress = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeInstanceAttribute.VpcAttributes.PrivateIpAddress.Length"); i++) {
				vpcAttributes_privateIpAddress.Add(_ctx.StringValue("DescribeInstanceAttribute.VpcAttributes.PrivateIpAddress["+ i +"]"));
			}
			vpcAttributes.PrivateIpAddress = vpcAttributes_privateIpAddress;
			describeInstanceAttributeResponse.VpcAttributes = vpcAttributes;

			DescribeInstanceAttributeResponse.DescribeInstanceAttribute_EipAddress eipAddress = new DescribeInstanceAttributeResponse.DescribeInstanceAttribute_EipAddress();
			eipAddress.AllocationId = _ctx.StringValue("DescribeInstanceAttribute.EipAddress.AllocationId");
			eipAddress.IpAddress = _ctx.StringValue("DescribeInstanceAttribute.EipAddress.IpAddress");
			eipAddress.Bandwidth = _ctx.IntegerValue("DescribeInstanceAttribute.EipAddress.Bandwidth");
			eipAddress.InternetChargeType = _ctx.StringValue("DescribeInstanceAttribute.EipAddress.InternetChargeType");
			describeInstanceAttributeResponse.EipAddress = eipAddress;

			DescribeInstanceAttributeResponse.DescribeInstanceAttribute_DedicatedHostAttribute dedicatedHostAttribute = new DescribeInstanceAttributeResponse.DescribeInstanceAttribute_DedicatedHostAttribute();
			dedicatedHostAttribute.DedicatedHostId = _ctx.StringValue("DescribeInstanceAttribute.DedicatedHostAttribute.DedicatedHostId");
			dedicatedHostAttribute.DedicatedHostName = _ctx.StringValue("DescribeInstanceAttribute.DedicatedHostAttribute.DedicatedHostName");
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
