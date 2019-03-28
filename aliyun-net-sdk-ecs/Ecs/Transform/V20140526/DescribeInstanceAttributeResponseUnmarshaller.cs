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
        public static DescribeInstanceAttributeResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeInstanceAttributeResponse describeInstanceAttributeResponse = new DescribeInstanceAttributeResponse();

			describeInstanceAttributeResponse.HttpResponse = context.HttpResponse;
			describeInstanceAttributeResponse.RequestId = context.StringValue("DescribeInstanceAttribute.RequestId");
			describeInstanceAttributeResponse.InstanceId = context.StringValue("DescribeInstanceAttribute.InstanceId");
			describeInstanceAttributeResponse.InstanceName = context.StringValue("DescribeInstanceAttribute.InstanceName");
			describeInstanceAttributeResponse.ImageId = context.StringValue("DescribeInstanceAttribute.ImageId");
			describeInstanceAttributeResponse.RegionId = context.StringValue("DescribeInstanceAttribute.RegionId");
			describeInstanceAttributeResponse.ZoneId = context.StringValue("DescribeInstanceAttribute.ZoneId");
			describeInstanceAttributeResponse.ClusterId = context.StringValue("DescribeInstanceAttribute.ClusterId");
			describeInstanceAttributeResponse.InstanceType = context.StringValue("DescribeInstanceAttribute.InstanceType");
			describeInstanceAttributeResponse.Cpu = context.IntegerValue("DescribeInstanceAttribute.Cpu");
			describeInstanceAttributeResponse.Memory = context.IntegerValue("DescribeInstanceAttribute.Memory");
			describeInstanceAttributeResponse.HostName = context.StringValue("DescribeInstanceAttribute.HostName");
			describeInstanceAttributeResponse.Status = context.StringValue("DescribeInstanceAttribute.Status");
			describeInstanceAttributeResponse.InternetChargeType = context.StringValue("DescribeInstanceAttribute.InternetChargeType");
			describeInstanceAttributeResponse.InternetMaxBandwidthIn = context.IntegerValue("DescribeInstanceAttribute.InternetMaxBandwidthIn");
			describeInstanceAttributeResponse.InternetMaxBandwidthOut = context.IntegerValue("DescribeInstanceAttribute.InternetMaxBandwidthOut");
			describeInstanceAttributeResponse.VlanId = context.StringValue("DescribeInstanceAttribute.VlanId");
			describeInstanceAttributeResponse.SerialNumber = context.StringValue("DescribeInstanceAttribute.SerialNumber");
			describeInstanceAttributeResponse.CreationTime = context.StringValue("DescribeInstanceAttribute.CreationTime");
			describeInstanceAttributeResponse.Description = context.StringValue("DescribeInstanceAttribute.Description");
			describeInstanceAttributeResponse.InstanceNetworkType = context.StringValue("DescribeInstanceAttribute.InstanceNetworkType");
			describeInstanceAttributeResponse.IoOptimized = context.StringValue("DescribeInstanceAttribute.IoOptimized");
			describeInstanceAttributeResponse.InstanceChargeType = context.StringValue("DescribeInstanceAttribute.InstanceChargeType");
			describeInstanceAttributeResponse.ExpiredTime = context.StringValue("DescribeInstanceAttribute.ExpiredTime");
			describeInstanceAttributeResponse.StoppedMode = context.StringValue("DescribeInstanceAttribute.StoppedMode");
			describeInstanceAttributeResponse.CreditSpecification = context.StringValue("DescribeInstanceAttribute.CreditSpecification");

			List<string> describeInstanceAttributeResponse_securityGroupIds = new List<string>();
			for (int i = 0; i < context.Length("DescribeInstanceAttribute.SecurityGroupIds.Length"); i++) {
				describeInstanceAttributeResponse_securityGroupIds.Add(context.StringValue("DescribeInstanceAttribute.SecurityGroupIds["+ i +"]"));
			}
			describeInstanceAttributeResponse.SecurityGroupIds = describeInstanceAttributeResponse_securityGroupIds;

			List<string> describeInstanceAttributeResponse_publicIpAddress = new List<string>();
			for (int i = 0; i < context.Length("DescribeInstanceAttribute.PublicIpAddress.Length"); i++) {
				describeInstanceAttributeResponse_publicIpAddress.Add(context.StringValue("DescribeInstanceAttribute.PublicIpAddress["+ i +"]"));
			}
			describeInstanceAttributeResponse.PublicIpAddress = describeInstanceAttributeResponse_publicIpAddress;

			List<string> describeInstanceAttributeResponse_innerIpAddress = new List<string>();
			for (int i = 0; i < context.Length("DescribeInstanceAttribute.InnerIpAddress.Length"); i++) {
				describeInstanceAttributeResponse_innerIpAddress.Add(context.StringValue("DescribeInstanceAttribute.InnerIpAddress["+ i +"]"));
			}
			describeInstanceAttributeResponse.InnerIpAddress = describeInstanceAttributeResponse_innerIpAddress;

			DescribeInstanceAttributeResponse.DescribeInstanceAttribute_VpcAttributes vpcAttributes = new DescribeInstanceAttributeResponse.DescribeInstanceAttribute_VpcAttributes();
			vpcAttributes.VpcId = context.StringValue("DescribeInstanceAttribute.VpcAttributes.VpcId");
			vpcAttributes.VSwitchId = context.StringValue("DescribeInstanceAttribute.VpcAttributes.VSwitchId");
			vpcAttributes.NatIpAddress = context.StringValue("DescribeInstanceAttribute.VpcAttributes.NatIpAddress");

			List<string> vpcAttributes_privateIpAddress = new List<string>();
			for (int i = 0; i < context.Length("DescribeInstanceAttribute.VpcAttributes.PrivateIpAddress.Length"); i++) {
				vpcAttributes_privateIpAddress.Add(context.StringValue("DescribeInstanceAttribute.VpcAttributes.PrivateIpAddress["+ i +"]"));
			}
			vpcAttributes.PrivateIpAddress = vpcAttributes_privateIpAddress;
			describeInstanceAttributeResponse.VpcAttributes = vpcAttributes;

			DescribeInstanceAttributeResponse.DescribeInstanceAttribute_EipAddress eipAddress = new DescribeInstanceAttributeResponse.DescribeInstanceAttribute_EipAddress();
			eipAddress.AllocationId = context.StringValue("DescribeInstanceAttribute.EipAddress.AllocationId");
			eipAddress.IpAddress = context.StringValue("DescribeInstanceAttribute.EipAddress.IpAddress");
			eipAddress.Bandwidth = context.IntegerValue("DescribeInstanceAttribute.EipAddress.Bandwidth");
			eipAddress.InternetChargeType = context.StringValue("DescribeInstanceAttribute.EipAddress.InternetChargeType");
			describeInstanceAttributeResponse.EipAddress = eipAddress;

			DescribeInstanceAttributeResponse.DescribeInstanceAttribute_DedicatedHostAttribute dedicatedHostAttribute = new DescribeInstanceAttributeResponse.DescribeInstanceAttribute_DedicatedHostAttribute();
			dedicatedHostAttribute.DedicatedHostId = context.StringValue("DescribeInstanceAttribute.DedicatedHostAttribute.DedicatedHostId");
			dedicatedHostAttribute.DedicatedHostName = context.StringValue("DescribeInstanceAttribute.DedicatedHostAttribute.DedicatedHostName");
			describeInstanceAttributeResponse.DedicatedHostAttribute = dedicatedHostAttribute;

			List<DescribeInstanceAttributeResponse.DescribeInstanceAttribute_LockReason> describeInstanceAttributeResponse_operationLocks = new List<DescribeInstanceAttributeResponse.DescribeInstanceAttribute_LockReason>();
			for (int i = 0; i < context.Length("DescribeInstanceAttribute.OperationLocks.Length"); i++) {
				DescribeInstanceAttributeResponse.DescribeInstanceAttribute_LockReason lockReason = new DescribeInstanceAttributeResponse.DescribeInstanceAttribute_LockReason();
				lockReason.LockReason = context.StringValue("DescribeInstanceAttribute.OperationLocks["+ i +"].LockReason");

				describeInstanceAttributeResponse_operationLocks.Add(lockReason);
			}
			describeInstanceAttributeResponse.OperationLocks = describeInstanceAttributeResponse_operationLocks;
        
			return describeInstanceAttributeResponse;
        }
    }
}
