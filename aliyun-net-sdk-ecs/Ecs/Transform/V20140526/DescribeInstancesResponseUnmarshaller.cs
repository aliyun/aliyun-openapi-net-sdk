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

			List<DescribeInstancesResponse.DescribeInstances_Instance> describeInstancesResponse_instances = new List<DescribeInstancesResponse.DescribeInstances_Instance>();
			for (int i = 0; i < context.Length("DescribeInstances.Instances.Length"); i++) {
				DescribeInstancesResponse.DescribeInstances_Instance instance = new DescribeInstancesResponse.DescribeInstances_Instance();
				instance.InstanceId = context.StringValue("DescribeInstances.Instances["+ i +"].InstanceId");
				instance.InstanceName = context.StringValue("DescribeInstances.Instances["+ i +"].InstanceName");
				instance.Description = context.StringValue("DescribeInstances.Instances["+ i +"].Description");
				instance.ImageId = context.StringValue("DescribeInstances.Instances["+ i +"].ImageId");
				instance.OSName = context.StringValue("DescribeInstances.Instances["+ i +"].OSName");
				instance.OSNameEn = context.StringValue("DescribeInstances.Instances["+ i +"].OSNameEn");
				instance.OSType = context.StringValue("DescribeInstances.Instances["+ i +"].OSType");
				instance.RegionId = context.StringValue("DescribeInstances.Instances["+ i +"].RegionId");
				instance.ZoneId = context.StringValue("DescribeInstances.Instances["+ i +"].ZoneId");
				instance.ClusterId = context.StringValue("DescribeInstances.Instances["+ i +"].ClusterId");
				instance.InstanceType = context.StringValue("DescribeInstances.Instances["+ i +"].InstanceType");
				instance.Cpu = context.IntegerValue("DescribeInstances.Instances["+ i +"].Cpu");
				instance.Memory = context.IntegerValue("DescribeInstances.Instances["+ i +"].Memory");
				instance.HostName = context.StringValue("DescribeInstances.Instances["+ i +"].HostName");
				instance.DeploymentSetId = context.StringValue("DescribeInstances.Instances["+ i +"].DeploymentSetId");
				instance.DeploymentSetGroupNo = context.IntegerValue("DescribeInstances.Instances["+ i +"].DeploymentSetGroupNo");
				instance.Status = context.StringValue("DescribeInstances.Instances["+ i +"].Status");
				instance.SerialNumber = context.StringValue("DescribeInstances.Instances["+ i +"].SerialNumber");
				instance.InternetChargeType = context.StringValue("DescribeInstances.Instances["+ i +"].InternetChargeType");
				instance.InternetMaxBandwidthIn = context.IntegerValue("DescribeInstances.Instances["+ i +"].InternetMaxBandwidthIn");
				instance.InternetMaxBandwidthOut = context.IntegerValue("DescribeInstances.Instances["+ i +"].InternetMaxBandwidthOut");
				instance.VlanId = context.StringValue("DescribeInstances.Instances["+ i +"].VlanId");
				instance.CreationTime = context.StringValue("DescribeInstances.Instances["+ i +"].CreationTime");
				instance.StartTime = context.StringValue("DescribeInstances.Instances["+ i +"].StartTime");
				instance.InstanceNetworkType = context.StringValue("DescribeInstances.Instances["+ i +"].InstanceNetworkType");
				instance.InstanceChargeType = context.StringValue("DescribeInstances.Instances["+ i +"].InstanceChargeType");
				instance.SaleCycle = context.StringValue("DescribeInstances.Instances["+ i +"].SaleCycle");
				instance.ExpiredTime = context.StringValue("DescribeInstances.Instances["+ i +"].ExpiredTime");
				instance.AutoReleaseTime = context.StringValue("DescribeInstances.Instances["+ i +"].AutoReleaseTime");
				instance.IoOptimized = context.BooleanValue("DescribeInstances.Instances["+ i +"].IoOptimized");
				instance.DeviceAvailable = context.BooleanValue("DescribeInstances.Instances["+ i +"].DeviceAvailable");
				instance.InstanceTypeFamily = context.StringValue("DescribeInstances.Instances["+ i +"].InstanceTypeFamily");
				instance.LocalStorageCapacity = context.LongValue("DescribeInstances.Instances["+ i +"].LocalStorageCapacity");
				instance.LocalStorageAmount = context.IntegerValue("DescribeInstances.Instances["+ i +"].LocalStorageAmount");
				instance.GPUAmount = context.IntegerValue("DescribeInstances.Instances["+ i +"].GPUAmount");
				instance.GPUSpec = context.StringValue("DescribeInstances.Instances["+ i +"].GPUSpec");
				instance.SpotStrategy = context.StringValue("DescribeInstances.Instances["+ i +"].SpotStrategy");
				instance.SpotPriceLimit = context.FloatValue("DescribeInstances.Instances["+ i +"].SpotPriceLimit");
				instance.SpotDuration = context.IntegerValue("DescribeInstances.Instances["+ i +"].SpotDuration");
				instance.ResourceGroupId = context.StringValue("DescribeInstances.Instances["+ i +"].ResourceGroupId");
				instance.KeyPairName = context.StringValue("DescribeInstances.Instances["+ i +"].KeyPairName");
				instance.Recyclable = context.BooleanValue("DescribeInstances.Instances["+ i +"].Recyclable");
				instance.HpcClusterId = context.StringValue("DescribeInstances.Instances["+ i +"].HpcClusterId");
				instance.StoppedMode = context.StringValue("DescribeInstances.Instances["+ i +"].StoppedMode");
				instance.CreditSpecification = context.StringValue("DescribeInstances.Instances["+ i +"].CreditSpecification");
				instance.DeletionProtection = context.BooleanValue("DescribeInstances.Instances["+ i +"].DeletionProtection");

				List<string> instance_securityGroupIds = new List<string>();
				for (int j = 0; j < context.Length("DescribeInstances.Instances["+ i +"].SecurityGroupIds.Length"); j++) {
					instance_securityGroupIds.Add(context.StringValue("DescribeInstances.Instances["+ i +"].SecurityGroupIds["+ j +"]"));
				}
				instance.SecurityGroupIds = instance_securityGroupIds;

				List<string> instance_publicIpAddress = new List<string>();
				for (int j = 0; j < context.Length("DescribeInstances.Instances["+ i +"].PublicIpAddress.Length"); j++) {
					instance_publicIpAddress.Add(context.StringValue("DescribeInstances.Instances["+ i +"].PublicIpAddress["+ j +"]"));
				}
				instance.PublicIpAddress = instance_publicIpAddress;

				List<string> instance_innerIpAddress = new List<string>();
				for (int j = 0; j < context.Length("DescribeInstances.Instances["+ i +"].InnerIpAddress.Length"); j++) {
					instance_innerIpAddress.Add(context.StringValue("DescribeInstances.Instances["+ i +"].InnerIpAddress["+ j +"]"));
				}
				instance.InnerIpAddress = instance_innerIpAddress;

				List<string> instance_rdmaIpAddress = new List<string>();
				for (int j = 0; j < context.Length("DescribeInstances.Instances["+ i +"].RdmaIpAddress.Length"); j++) {
					instance_rdmaIpAddress.Add(context.StringValue("DescribeInstances.Instances["+ i +"].RdmaIpAddress["+ j +"]"));
				}
				instance.RdmaIpAddress = instance_rdmaIpAddress;

				DescribeInstancesResponse.DescribeInstances_Instance.DescribeInstances_VpcAttributes vpcAttributes = new DescribeInstancesResponse.DescribeInstances_Instance.DescribeInstances_VpcAttributes();
				vpcAttributes.VpcId = context.StringValue("DescribeInstances.Instances["+ i +"].VpcAttributes.VpcId");
				vpcAttributes.VSwitchId = context.StringValue("DescribeInstances.Instances["+ i +"].VpcAttributes.VSwitchId");
				vpcAttributes.NatIpAddress = context.StringValue("DescribeInstances.Instances["+ i +"].VpcAttributes.NatIpAddress");

				List<string> vpcAttributes_privateIpAddress = new List<string>();
				for (int j = 0; j < context.Length("DescribeInstances.Instances["+ i +"].VpcAttributes.PrivateIpAddress.Length"); j++) {
					vpcAttributes_privateIpAddress.Add(context.StringValue("DescribeInstances.Instances["+ i +"].VpcAttributes.PrivateIpAddress["+ j +"]"));
				}
				vpcAttributes.PrivateIpAddress = vpcAttributes_privateIpAddress;
				instance.VpcAttributes = vpcAttributes;

				DescribeInstancesResponse.DescribeInstances_Instance.DescribeInstances_EipAddress eipAddress = new DescribeInstancesResponse.DescribeInstances_Instance.DescribeInstances_EipAddress();
				eipAddress.AllocationId = context.StringValue("DescribeInstances.Instances["+ i +"].EipAddress.AllocationId");
				eipAddress.IpAddress = context.StringValue("DescribeInstances.Instances["+ i +"].EipAddress.IpAddress");
				eipAddress.Bandwidth = context.IntegerValue("DescribeInstances.Instances["+ i +"].EipAddress.Bandwidth");
				eipAddress.InternetChargeType = context.StringValue("DescribeInstances.Instances["+ i +"].EipAddress.InternetChargeType");
				eipAddress.IsSupportUnassociate = context.BooleanValue("DescribeInstances.Instances["+ i +"].EipAddress.IsSupportUnassociate");
				instance.EipAddress = eipAddress;

				DescribeInstancesResponse.DescribeInstances_Instance.DescribeInstances_DedicatedHostAttribute dedicatedHostAttribute = new DescribeInstancesResponse.DescribeInstances_Instance.DescribeInstances_DedicatedHostAttribute();
				dedicatedHostAttribute.DedicatedHostId = context.StringValue("DescribeInstances.Instances["+ i +"].DedicatedHostAttribute.DedicatedHostId");
				dedicatedHostAttribute.DedicatedHostName = context.StringValue("DescribeInstances.Instances["+ i +"].DedicatedHostAttribute.DedicatedHostName");
				dedicatedHostAttribute.DedicatedHostClusterId = context.StringValue("DescribeInstances.Instances["+ i +"].DedicatedHostAttribute.DedicatedHostClusterId");
				instance.DedicatedHostAttribute = dedicatedHostAttribute;

				DescribeInstancesResponse.DescribeInstances_Instance.DescribeInstances_EcsCapacityReservationAttr ecsCapacityReservationAttr = new DescribeInstancesResponse.DescribeInstances_Instance.DescribeInstances_EcsCapacityReservationAttr();
				ecsCapacityReservationAttr.CapacityReservationId = context.StringValue("DescribeInstances.Instances["+ i +"].EcsCapacityReservationAttr.CapacityReservationId");
				ecsCapacityReservationAttr.CapacityReservationPreference = context.StringValue("DescribeInstances.Instances["+ i +"].EcsCapacityReservationAttr.CapacityReservationPreference");
				instance.EcsCapacityReservationAttr = ecsCapacityReservationAttr;

				DescribeInstancesResponse.DescribeInstances_Instance.DescribeInstances_DedicatedInstanceAttribute dedicatedInstanceAttribute = new DescribeInstancesResponse.DescribeInstances_Instance.DescribeInstances_DedicatedInstanceAttribute();
				dedicatedInstanceAttribute.Tenancy = context.StringValue("DescribeInstances.Instances["+ i +"].DedicatedInstanceAttribute.Tenancy");
				dedicatedInstanceAttribute.Affinity = context.StringValue("DescribeInstances.Instances["+ i +"].DedicatedInstanceAttribute.Affinity");
				instance.DedicatedInstanceAttribute = dedicatedInstanceAttribute;

				DescribeInstancesResponse.DescribeInstances_Instance.DescribeInstances_CpuOptions cpuOptions = new DescribeInstancesResponse.DescribeInstances_Instance.DescribeInstances_CpuOptions();
				cpuOptions.CoreCount = context.IntegerValue("DescribeInstances.Instances["+ i +"].CpuOptions.CoreCount");
				cpuOptions.ThreadsPerCore = context.IntegerValue("DescribeInstances.Instances["+ i +"].CpuOptions.ThreadsPerCore");
				cpuOptions.Numa = context.StringValue("DescribeInstances.Instances["+ i +"].CpuOptions.Numa");
				instance.CpuOptions = cpuOptions;

				DescribeInstancesResponse.DescribeInstances_Instance.DescribeInstances_MetadataOptions metadataOptions = new DescribeInstancesResponse.DescribeInstances_Instance.DescribeInstances_MetadataOptions();
				metadataOptions.HttpEndpoint = context.StringValue("DescribeInstances.Instances["+ i +"].MetadataOptions.HttpEndpoint");
				metadataOptions.HttpTokens = context.StringValue("DescribeInstances.Instances["+ i +"].MetadataOptions.HttpTokens");
				metadataOptions.HttpPutResponseHopLimit = context.IntegerValue("DescribeInstances.Instances["+ i +"].MetadataOptions.HttpPutResponseHopLimit");
				instance.MetadataOptions = metadataOptions;

				List<DescribeInstancesResponse.DescribeInstances_Instance.DescribeInstances_NetworkInterface> instance_networkInterfaces = new List<DescribeInstancesResponse.DescribeInstances_Instance.DescribeInstances_NetworkInterface>();
				for (int j = 0; j < context.Length("DescribeInstances.Instances["+ i +"].NetworkInterfaces.Length"); j++) {
					DescribeInstancesResponse.DescribeInstances_Instance.DescribeInstances_NetworkInterface networkInterface = new DescribeInstancesResponse.DescribeInstances_Instance.DescribeInstances_NetworkInterface();
					networkInterface.NetworkInterfaceId = context.StringValue("DescribeInstances.Instances["+ i +"].NetworkInterfaces["+ j +"].NetworkInterfaceId");
					networkInterface.MacAddress = context.StringValue("DescribeInstances.Instances["+ i +"].NetworkInterfaces["+ j +"].MacAddress");
					networkInterface.PrimaryIpAddress = context.StringValue("DescribeInstances.Instances["+ i +"].NetworkInterfaces["+ j +"].PrimaryIpAddress");

					instance_networkInterfaces.Add(networkInterface);
				}
				instance.NetworkInterfaces = instance_networkInterfaces;

				List<DescribeInstancesResponse.DescribeInstances_Instance.DescribeInstances_LockReason> instance_operationLocks = new List<DescribeInstancesResponse.DescribeInstances_Instance.DescribeInstances_LockReason>();
				for (int j = 0; j < context.Length("DescribeInstances.Instances["+ i +"].OperationLocks.Length"); j++) {
					DescribeInstancesResponse.DescribeInstances_Instance.DescribeInstances_LockReason lockReason = new DescribeInstancesResponse.DescribeInstances_Instance.DescribeInstances_LockReason();
					lockReason.LockReason = context.StringValue("DescribeInstances.Instances["+ i +"].OperationLocks["+ j +"].LockReason");
					lockReason.LockMsg = context.StringValue("DescribeInstances.Instances["+ i +"].OperationLocks["+ j +"].LockMsg");

					instance_operationLocks.Add(lockReason);
				}
				instance.OperationLocks = instance_operationLocks;

				List<DescribeInstancesResponse.DescribeInstances_Instance.DescribeInstances_Tag> instance_tags = new List<DescribeInstancesResponse.DescribeInstances_Instance.DescribeInstances_Tag>();
				for (int j = 0; j < context.Length("DescribeInstances.Instances["+ i +"].Tags.Length"); j++) {
					DescribeInstancesResponse.DescribeInstances_Instance.DescribeInstances_Tag tag = new DescribeInstancesResponse.DescribeInstances_Instance.DescribeInstances_Tag();
					tag.TagKey = context.StringValue("DescribeInstances.Instances["+ i +"].Tags["+ j +"].TagKey");
					tag.TagValue = context.StringValue("DescribeInstances.Instances["+ i +"].Tags["+ j +"].TagValue");

					instance_tags.Add(tag);
				}
				instance.Tags = instance_tags;

				describeInstancesResponse_instances.Add(instance);
			}
			describeInstancesResponse.Instances = describeInstancesResponse_instances;
        
			return describeInstancesResponse;
        }
    }
}
