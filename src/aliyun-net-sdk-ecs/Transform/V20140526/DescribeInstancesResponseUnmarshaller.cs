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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Ecs.Model.V20140526;
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeInstancesResponseUnmarshaller
    {
        public static DescribeInstancesResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeInstancesResponse describeInstancesResponse = new DescribeInstancesResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeInstances.RequestId"),
                TotalCount = context.IntegerValue("DescribeInstances.TotalCount"),
                PageNumber = context.IntegerValue("DescribeInstances.PageNumber"),
                PageSize = context.IntegerValue("DescribeInstances.PageSize")
            };
            List<DescribeInstancesResponse.Instance> instances = new List<DescribeInstancesResponse.Instance>();
			for (int i = 0; i < context.Length("DescribeInstances.Instances.Length"); i++) {
                DescribeInstancesResponse.Instance instance = new DescribeInstancesResponse.Instance()
                {
                    InstanceId = context.StringValue($"DescribeInstances.Instances[{i}].InstanceId"),
                    InstanceName = context.StringValue($"DescribeInstances.Instances[{i}].InstanceName"),
                    Description = context.StringValue($"DescribeInstances.Instances[{i}].Description"),
                    ImageId = context.StringValue($"DescribeInstances.Instances[{i}].ImageId"),
                    RegionId = context.StringValue($"DescribeInstances.Instances[{i}].RegionId"),
                    ZoneId = context.StringValue($"DescribeInstances.Instances[{i}].ZoneId"),
                    ClusterId = context.StringValue($"DescribeInstances.Instances[{i}].ClusterId"),
                    InstanceType = context.StringValue($"DescribeInstances.Instances[{i}].InstanceType"),
                    Cpu = context.IntegerValue($"DescribeInstances.Instances[{i}].Cpu"),
                    Memory = context.IntegerValue($"DescribeInstances.Instances[{i}].Memory"),
                    HostName = context.StringValue($"DescribeInstances.Instances[{i}].HostName"),
                    Status = context.EnumValue<DescribeInstancesResponse.Instance.StatusEnum>($"DescribeInstances.Instances[{i}].Status"),
                    SerialNumber = context.StringValue($"DescribeInstances.Instances[{i}].SerialNumber"),
                    InternetChargeType = context.StringValue($"DescribeInstances.Instances[{i}].InternetChargeType"),
                    InternetMaxBandwidthIn = context.IntegerValue($"DescribeInstances.Instances[{i}].InternetMaxBandwidthIn"),
                    InternetMaxBandwidthOut = context.IntegerValue($"DescribeInstances.Instances[{i}].InternetMaxBandwidthOut"),
                    VlanId = context.StringValue($"DescribeInstances.Instances[{i}].VlanId"),
                    CreationTime = context.StringValue($"DescribeInstances.Instances[{i}].CreationTime"),
                    InstanceNetworkType = context.StringValue($"DescribeInstances.Instances[{i}].InstanceNetworkType"),
                    InstanceChargeType = context.StringValue($"DescribeInstances.Instances[{i}].InstanceChargeType"),
                    ExpiredTime = context.StringValue($"DescribeInstances.Instances[{i}].ExpiredTime"),
                    IoOptimized = context.BooleanValue($"DescribeInstances.Instances[{i}].IoOptimized"),
                    DeviceAvailable = context.BooleanValue($"DescribeInstances.Instances[{i}].DeviceAvailable"),
                    InstanceTypeFamily = context.StringValue($"DescribeInstances.Instances[{i}].InstanceTypeFamily")
                };
                List<string> securityGroupIds = new List<string>();
				for (int j = 0; j < context.Length($"DescribeInstances.Instances[{i}].SecurityGroupIds.Length"); j++) {
					securityGroupIds.Add(context.StringValue($"DescribeInstances.Instances[{i}].SecurityGroupIds[{j}]"));
				}
				instance.SecurityGroupIds = securityGroupIds;

				List<string> publicIpAddress = new List<string>();
				for (int j = 0; j < context.Length($"DescribeInstances.Instances[{i}].PublicIpAddress.Length"); j++) {
					publicIpAddress.Add(context.StringValue($"DescribeInstances.Instances[{i}].PublicIpAddress[{j}]"));
				}
				instance.PublicIpAddress = publicIpAddress;

				List<string> innerIpAddress = new List<string>();
				for (int j = 0; j < context.Length($"DescribeInstances.Instances[{i}].InnerIpAddress.Length"); j++) {
					innerIpAddress.Add(context.StringValue($"DescribeInstances.Instances[{i}].InnerIpAddress[{j}]"));
				}
				instance.InnerIpAddress = innerIpAddress;

                DescribeInstancesResponse.Instance.VpcAttributes_ vpcAttributes = new DescribeInstancesResponse.Instance.VpcAttributes_()
                {
                    VpcId = context.StringValue($"DescribeInstances.Instances[{i}].VpcAttributes.VpcId"),
                    VSwitchId = context.StringValue($"DescribeInstances.Instances[{i}].VpcAttributes.VSwitchId"),
                    NatIpAddress = context.StringValue($"DescribeInstances.Instances[{i}].VpcAttributes.NatIpAddress")
                };
                List<string> privateIpAddress = new List<string>();
				for (int j = 0; j < context.Length($"DescribeInstances.Instances[{i}].VpcAttributes.PrivateIpAddress.Length"); j++) {
					privateIpAddress.Add(context.StringValue($"DescribeInstances.Instances[{i}].VpcAttributes.PrivateIpAddress[{j}]"));
				}
				vpcAttributes.PrivateIpAddress = privateIpAddress;
				instance.VpcAttributes = vpcAttributes;

                DescribeInstancesResponse.Instance.EipAddress_ eipAddress = new DescribeInstancesResponse.Instance.EipAddress_()
                {
                    AllocationId = context.StringValue($"DescribeInstances.Instances[{i}].EipAddress.AllocationId"),
                    IpAddress = context.StringValue($"DescribeInstances.Instances[{i}].EipAddress.IpAddress"),
                    Bandwidth = context.IntegerValue($"DescribeInstances.Instances[{i}].EipAddress.Bandwidth"),
                    InternetChargeType = context.StringValue($"DescribeInstances.Instances[{i}].EipAddress.InternetChargeType")
                };
                instance.EipAddress = eipAddress;

				List<DescribeInstancesResponse.Instance.LockReason> operationLocks = new List<DescribeInstancesResponse.Instance.LockReason>();
				for (int j = 0; j < context.Length($"DescribeInstances.Instances[{i}].OperationLocks.Length"); j++) {
                    DescribeInstancesResponse.Instance.LockReason lockReason = new DescribeInstancesResponse.Instance.LockReason()
                    {
                        LockReason_ = context.StringValue($"DescribeInstances.Instances[{i}].OperationLocks[{j}].LockReason")
                    };
                    operationLocks.Add(lockReason);
				}
				instance.OperationLocks = operationLocks;

				List<DescribeInstancesResponse.Instance.Tag> tags = new List<DescribeInstancesResponse.Instance.Tag>();
				for (int j = 0; j < context.Length($"DescribeInstances.Instances[{i}].Tags.Length"); j++) {
                    DescribeInstancesResponse.Instance.Tag tag = new DescribeInstancesResponse.Instance.Tag()
                    {
                        TagKey = context.StringValue($"DescribeInstances.Instances[{i}].Tags[{j}].TagKey"),
                        TagValue = context.StringValue($"DescribeInstances.Instances[{i}].Tags[{j}].TagValue")
                    };
                    tags.Add(tag);
				}
				instance.Tags = tags;

				instances.Add(instance);
			}
			describeInstancesResponse.Instances = instances;
        
			return describeInstancesResponse;
        }
    }
}