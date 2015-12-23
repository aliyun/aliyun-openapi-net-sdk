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
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeInstancesResponseUnmarshaller
    {
        public static DescribeInstancesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeInstancesResponse describeInstancesResponse = new DescribeInstancesResponse();

			describeInstancesResponse.HttpResponse = context.HttpResponse;
			describeInstancesResponse.RequestId = context.StringValue("DescribeInstances.RequestId");
			describeInstancesResponse.TotalCount = context.IntegerValue("DescribeInstances.TotalCount");
			describeInstancesResponse.PageNumber = context.IntegerValue("DescribeInstances.PageNumber");
			describeInstancesResponse.PageSize = context.IntegerValue("DescribeInstances.PageSize");

			List<DescribeInstancesResponse.Instance> instances = new List<DescribeInstancesResponse.Instance>();
			for (int i = 0; i < context.Length("DescribeInstances.Instances.Length"); i++) {
				DescribeInstancesResponse.Instance instance = new DescribeInstancesResponse.Instance();
				instance.InstanceId = context.StringValue("DescribeInstances.Instances["+ i +"].InstanceId");
				instance.InstanceName = context.StringValue("DescribeInstances.Instances["+ i +"].InstanceName");
				instance.Description = context.StringValue("DescribeInstances.Instances["+ i +"].Description");
				instance.ImageId = context.StringValue("DescribeInstances.Instances["+ i +"].ImageId");
				instance.RegionId = context.StringValue("DescribeInstances.Instances["+ i +"].RegionId");
				instance.ZoneId = context.StringValue("DescribeInstances.Instances["+ i +"].ZoneId");
				instance.ClusterId = context.StringValue("DescribeInstances.Instances["+ i +"].ClusterId");
				instance.InstanceType = context.StringValue("DescribeInstances.Instances["+ i +"].InstanceType");
				instance.HostName = context.StringValue("DescribeInstances.Instances["+ i +"].HostName");
				instance.Status = (DescribeInstancesResponse.Instance.Status_)Enum.Parse(typeof(DescribeInstancesResponse.Instance.Status_),
					 context.StringValue("DescribeInstances.Instances["+ i +"].Status"));
				instance.SerialNumber = context.StringValue("DescribeInstances.Instances["+ i +"].SerialNumber");
				instance.InternetChargeType = context.StringValue("DescribeInstances.Instances["+ i +"].InternetChargeType");
				instance.InternetMaxBandwidthIn = context.IntegerValue("DescribeInstances.Instances["+ i +"].InternetMaxBandwidthIn");
				instance.InternetMaxBandwidthOut = context.IntegerValue("DescribeInstances.Instances["+ i +"].InternetMaxBandwidthOut");
				instance.VlanId = context.StringValue("DescribeInstances.Instances["+ i +"].VlanId");
				instance.CreationTime = context.StringValue("DescribeInstances.Instances["+ i +"].CreationTime");
				instance.InstanceNetworkType = context.StringValue("DescribeInstances.Instances["+ i +"].InstanceNetworkType");
				instance.InstanceChargeType = context.StringValue("DescribeInstances.Instances["+ i +"].InstanceChargeType");
				instance.ExpiredTime = context.StringValue("DescribeInstances.Instances["+ i +"].ExpiredTime");
				instance.IoOptimized = context.BooleanValue("DescribeInstances.Instances["+ i +"].IoOptimized");
				instance.DeviceAvailable = context.BooleanValue("DescribeInstances.Instances["+ i +"].DeviceAvailable");

				List<string> securityGroupIds = new List<string>();
				for (int j = 0; j < context.Length("DescribeInstances.Instances["+ i +"].SecurityGroupIds.Length"); j++) {
					securityGroupIds.Add(context.StringValue("DescribeInstances.Instances["+ i +"].SecurityGroupIds["+ j +"]"));
				}
				instance.SecurityGroupIds = securityGroupIds;

				List<string> publicIpAddress = new List<string>();
				for (int j = 0; j < context.Length("DescribeInstances.Instances["+ i +"].PublicIpAddress.Length"); j++) {
					publicIpAddress.Add(context.StringValue("DescribeInstances.Instances["+ i +"].PublicIpAddress["+ j +"]"));
				}
				instance.PublicIpAddress = publicIpAddress;

				List<string> innerIpAddress = new List<string>();
				for (int j = 0; j < context.Length("DescribeInstances.Instances["+ i +"].InnerIpAddress.Length"); j++) {
					innerIpAddress.Add(context.StringValue("DescribeInstances.Instances["+ i +"].InnerIpAddress["+ j +"]"));
				}
				instance.InnerIpAddress = innerIpAddress;

				DescribeInstancesResponse.Instance.VpcAttributes_ vpcAttributes = new DescribeInstancesResponse.Instance.VpcAttributes_();
				vpcAttributes.VpcId = context.StringValue("DescribeInstances.Instances["+ i +"].VpcAttributes.VpcId");
				vpcAttributes.VSwitchId = context.StringValue("DescribeInstances.Instances["+ i +"].VpcAttributes.VSwitchId");
				vpcAttributes.NatIpAddress = context.StringValue("DescribeInstances.Instances["+ i +"].VpcAttributes.NatIpAddress");

				List<string> privateIpAddress = new List<string>();
				for (int j = 0; j < context.Length("DescribeInstances.Instances["+ i +"].VpcAttributes.PrivateIpAddress.Length"); j++) {
					privateIpAddress.Add(context.StringValue("DescribeInstances.Instances["+ i +"].VpcAttributes.PrivateIpAddress["+ j +"]"));
				}
				vpcAttributes.PrivateIpAddress = privateIpAddress;
				instance.VpcAttributes = vpcAttributes;

				DescribeInstancesResponse.Instance.EipAddress_ eipAddress = new DescribeInstancesResponse.Instance.EipAddress_();
				eipAddress.AllocationId = context.StringValue("DescribeInstances.Instances["+ i +"].EipAddress.AllocationId");
				eipAddress.IpAddress = context.StringValue("DescribeInstances.Instances["+ i +"].EipAddress.IpAddress");
				eipAddress.Bandwidth = context.IntegerValue("DescribeInstances.Instances["+ i +"].EipAddress.Bandwidth");
				eipAddress.InternetChargeType = context.StringValue("DescribeInstances.Instances["+ i +"].EipAddress.InternetChargeType");
				instance.EipAddress = eipAddress;

				List<DescribeInstancesResponse.Instance.LockReason> operationLocks = new List<DescribeInstancesResponse.Instance.LockReason>();
				for (int j = 0; j < context.Length("DescribeInstances.Instances["+ i +"].OperationLocks.Length"); j++) {
					DescribeInstancesResponse.Instance.LockReason lockReason = new DescribeInstancesResponse.Instance.LockReason();
					lockReason.LockReason_ = context.StringValue("DescribeInstances.Instances["+ i +"].OperationLocks["+ j +"].LockReason");

					operationLocks.Add(lockReason);
				}
				instance.OperationLocks = operationLocks;

				List<DescribeInstancesResponse.Instance.Tag> tags = new List<DescribeInstancesResponse.Instance.Tag>();
				for (int j = 0; j < context.Length("DescribeInstances.Instances["+ i +"].Tags.Length"); j++) {
					DescribeInstancesResponse.Instance.Tag tag = new DescribeInstancesResponse.Instance.Tag();
					tag.TagKey = context.StringValue("DescribeInstances.Instances["+ i +"].Tags["+ j +"].TagKey");
					tag.TagValue = context.StringValue("DescribeInstances.Instances["+ i +"].Tags["+ j +"].TagValue");

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