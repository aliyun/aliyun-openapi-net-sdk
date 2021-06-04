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
        public static DescribeInstancesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeInstancesResponse describeInstancesResponse = new DescribeInstancesResponse();

			describeInstancesResponse.HttpResponse = _ctx.HttpResponse;
			describeInstancesResponse.NextToken = _ctx.StringValue("DescribeInstances.NextToken");
			describeInstancesResponse.PageSize = _ctx.IntegerValue("DescribeInstances.PageSize");
			describeInstancesResponse.PageNumber = _ctx.IntegerValue("DescribeInstances.PageNumber");
			describeInstancesResponse.RequestId = _ctx.StringValue("DescribeInstances.RequestId");
			describeInstancesResponse.TotalCount = _ctx.IntegerValue("DescribeInstances.TotalCount");

			List<DescribeInstancesResponse.DescribeInstances_Instance> describeInstancesResponse_instances = new List<DescribeInstancesResponse.DescribeInstances_Instance>();
			for (int i = 0; i < _ctx.Length("DescribeInstances.Instances.Length"); i++) {
				DescribeInstancesResponse.DescribeInstances_Instance instance = new DescribeInstancesResponse.DescribeInstances_Instance();
				instance.CreationTime = _ctx.StringValue("DescribeInstances.Instances["+ i +"].CreationTime");
				instance.SerialNumber = _ctx.StringValue("DescribeInstances.Instances["+ i +"].SerialNumber");
				instance.Status = _ctx.StringValue("DescribeInstances.Instances["+ i +"].Status");
				instance.DeploymentSetId = _ctx.StringValue("DescribeInstances.Instances["+ i +"].DeploymentSetId");
				instance.KeyPairName = _ctx.StringValue("DescribeInstances.Instances["+ i +"].KeyPairName");
				instance.SaleCycle = _ctx.StringValue("DescribeInstances.Instances["+ i +"].SaleCycle");
				instance.SpotStrategy = _ctx.StringValue("DescribeInstances.Instances["+ i +"].SpotStrategy");
				instance.DeviceAvailable = _ctx.BooleanValue("DescribeInstances.Instances["+ i +"].DeviceAvailable");
				instance.LocalStorageCapacity = _ctx.LongValue("DescribeInstances.Instances["+ i +"].LocalStorageCapacity");
				instance.Description = _ctx.StringValue("DescribeInstances.Instances["+ i +"].Description");
				instance.SpotDuration = _ctx.IntegerValue("DescribeInstances.Instances["+ i +"].SpotDuration");
				instance.InstanceNetworkType = _ctx.StringValue("DescribeInstances.Instances["+ i +"].InstanceNetworkType");
				instance.InstanceName = _ctx.StringValue("DescribeInstances.Instances["+ i +"].InstanceName");
				instance.OSNameEn = _ctx.StringValue("DescribeInstances.Instances["+ i +"].OSNameEn");
				instance.HpcClusterId = _ctx.StringValue("DescribeInstances.Instances["+ i +"].HpcClusterId");
				instance.SpotPriceLimit = _ctx.FloatValue("DescribeInstances.Instances["+ i +"].SpotPriceLimit");
				instance.Memory = _ctx.IntegerValue("DescribeInstances.Instances["+ i +"].Memory");
				instance.OSName = _ctx.StringValue("DescribeInstances.Instances["+ i +"].OSName");
				instance.DeploymentSetGroupNo = _ctx.IntegerValue("DescribeInstances.Instances["+ i +"].DeploymentSetGroupNo");
				instance.ImageId = _ctx.StringValue("DescribeInstances.Instances["+ i +"].ImageId");
				instance.VlanId = _ctx.StringValue("DescribeInstances.Instances["+ i +"].VlanId");
				instance.ClusterId = _ctx.StringValue("DescribeInstances.Instances["+ i +"].ClusterId");
				instance.GPUSpec = _ctx.StringValue("DescribeInstances.Instances["+ i +"].GPUSpec");
				instance.AutoReleaseTime = _ctx.StringValue("DescribeInstances.Instances["+ i +"].AutoReleaseTime");
				instance.DeletionProtection = _ctx.BooleanValue("DescribeInstances.Instances["+ i +"].DeletionProtection");
				instance.StoppedMode = _ctx.StringValue("DescribeInstances.Instances["+ i +"].StoppedMode");
				instance.GPUAmount = _ctx.IntegerValue("DescribeInstances.Instances["+ i +"].GPUAmount");
				instance.HostName = _ctx.StringValue("DescribeInstances.Instances["+ i +"].HostName");
				instance.InstanceId = _ctx.StringValue("DescribeInstances.Instances["+ i +"].InstanceId");
				instance.InternetMaxBandwidthOut = _ctx.IntegerValue("DescribeInstances.Instances["+ i +"].InternetMaxBandwidthOut");
				instance.InternetMaxBandwidthIn = _ctx.IntegerValue("DescribeInstances.Instances["+ i +"].InternetMaxBandwidthIn");
				instance.InstanceType = _ctx.StringValue("DescribeInstances.Instances["+ i +"].InstanceType");
				instance.InstanceChargeType = _ctx.StringValue("DescribeInstances.Instances["+ i +"].InstanceChargeType");
				instance.RegionId = _ctx.StringValue("DescribeInstances.Instances["+ i +"].RegionId");
				instance.IoOptimized = _ctx.BooleanValue("DescribeInstances.Instances["+ i +"].IoOptimized");
				instance.StartTime = _ctx.StringValue("DescribeInstances.Instances["+ i +"].StartTime");
				instance.Cpu = _ctx.IntegerValue("DescribeInstances.Instances["+ i +"].Cpu");
				instance.LocalStorageAmount = _ctx.IntegerValue("DescribeInstances.Instances["+ i +"].LocalStorageAmount");
				instance.ExpiredTime = _ctx.StringValue("DescribeInstances.Instances["+ i +"].ExpiredTime");
				instance.ResourceGroupId = _ctx.StringValue("DescribeInstances.Instances["+ i +"].ResourceGroupId");
				instance.InternetChargeType = _ctx.StringValue("DescribeInstances.Instances["+ i +"].InternetChargeType");
				instance.ZoneId = _ctx.StringValue("DescribeInstances.Instances["+ i +"].ZoneId");
				instance.Recyclable = _ctx.BooleanValue("DescribeInstances.Instances["+ i +"].Recyclable");
				instance.ISP = _ctx.StringValue("DescribeInstances.Instances["+ i +"].ISP");
				instance.CreditSpecification = _ctx.StringValue("DescribeInstances.Instances["+ i +"].CreditSpecification");
				instance.InstanceTypeFamily = _ctx.StringValue("DescribeInstances.Instances["+ i +"].InstanceTypeFamily");
				instance.OSType = _ctx.StringValue("DescribeInstances.Instances["+ i +"].OSType");

				List<string> instance_rdmaIpAddress = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeInstances.Instances["+ i +"].RdmaIpAddress.Length"); j++) {
					instance_rdmaIpAddress.Add(_ctx.StringValue("DescribeInstances.Instances["+ i +"].RdmaIpAddress["+ j +"]"));
				}
				instance.RdmaIpAddress = instance_rdmaIpAddress;

				List<string> instance_securityGroupIds = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeInstances.Instances["+ i +"].SecurityGroupIds.Length"); j++) {
					instance_securityGroupIds.Add(_ctx.StringValue("DescribeInstances.Instances["+ i +"].SecurityGroupIds["+ j +"]"));
				}
				instance.SecurityGroupIds = instance_securityGroupIds;

				List<string> instance_publicIpAddress = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeInstances.Instances["+ i +"].PublicIpAddress.Length"); j++) {
					instance_publicIpAddress.Add(_ctx.StringValue("DescribeInstances.Instances["+ i +"].PublicIpAddress["+ j +"]"));
				}
				instance.PublicIpAddress = instance_publicIpAddress;

				List<string> instance_innerIpAddress = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeInstances.Instances["+ i +"].InnerIpAddress.Length"); j++) {
					instance_innerIpAddress.Add(_ctx.StringValue("DescribeInstances.Instances["+ i +"].InnerIpAddress["+ j +"]"));
				}
				instance.InnerIpAddress = instance_innerIpAddress;

				DescribeInstancesResponse.DescribeInstances_Instance.DescribeInstances_VpcAttributes vpcAttributes = new DescribeInstancesResponse.DescribeInstances_Instance.DescribeInstances_VpcAttributes();
				vpcAttributes.VpcId = _ctx.StringValue("DescribeInstances.Instances["+ i +"].VpcAttributes.VpcId");
				vpcAttributes.NatIpAddress = _ctx.StringValue("DescribeInstances.Instances["+ i +"].VpcAttributes.NatIpAddress");
				vpcAttributes.VSwitchId = _ctx.StringValue("DescribeInstances.Instances["+ i +"].VpcAttributes.VSwitchId");

				List<string> vpcAttributes_privateIpAddress = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeInstances.Instances["+ i +"].VpcAttributes.PrivateIpAddress.Length"); j++) {
					vpcAttributes_privateIpAddress.Add(_ctx.StringValue("DescribeInstances.Instances["+ i +"].VpcAttributes.PrivateIpAddress["+ j +"]"));
				}
				vpcAttributes.PrivateIpAddress = vpcAttributes_privateIpAddress;
				instance.VpcAttributes = vpcAttributes;

				DescribeInstancesResponse.DescribeInstances_Instance.DescribeInstances_EipAddress eipAddress = new DescribeInstancesResponse.DescribeInstances_Instance.DescribeInstances_EipAddress();
				eipAddress.IsSupportUnassociate = _ctx.BooleanValue("DescribeInstances.Instances["+ i +"].EipAddress.IsSupportUnassociate");
				eipAddress.InternetChargeType = _ctx.StringValue("DescribeInstances.Instances["+ i +"].EipAddress.InternetChargeType");
				eipAddress.IpAddress = _ctx.StringValue("DescribeInstances.Instances["+ i +"].EipAddress.IpAddress");
				eipAddress.Bandwidth = _ctx.IntegerValue("DescribeInstances.Instances["+ i +"].EipAddress.Bandwidth");
				eipAddress.AllocationId = _ctx.StringValue("DescribeInstances.Instances["+ i +"].EipAddress.AllocationId");
				instance.EipAddress = eipAddress;

				DescribeInstancesResponse.DescribeInstances_Instance.DescribeInstances_HibernationOptions hibernationOptions = new DescribeInstancesResponse.DescribeInstances_Instance.DescribeInstances_HibernationOptions();
				hibernationOptions.Configured = _ctx.BooleanValue("DescribeInstances.Instances["+ i +"].HibernationOptions.Configured");
				instance.HibernationOptions = hibernationOptions;

				DescribeInstancesResponse.DescribeInstances_Instance.DescribeInstances_DedicatedHostAttribute dedicatedHostAttribute = new DescribeInstancesResponse.DescribeInstances_Instance.DescribeInstances_DedicatedHostAttribute();
				dedicatedHostAttribute.DedicatedHostId = _ctx.StringValue("DescribeInstances.Instances["+ i +"].DedicatedHostAttribute.DedicatedHostId");
				dedicatedHostAttribute.DedicatedHostName = _ctx.StringValue("DescribeInstances.Instances["+ i +"].DedicatedHostAttribute.DedicatedHostName");
				dedicatedHostAttribute.DedicatedHostClusterId = _ctx.StringValue("DescribeInstances.Instances["+ i +"].DedicatedHostAttribute.DedicatedHostClusterId");
				instance.DedicatedHostAttribute = dedicatedHostAttribute;

				DescribeInstancesResponse.DescribeInstances_Instance.DescribeInstances_EcsCapacityReservationAttr ecsCapacityReservationAttr = new DescribeInstancesResponse.DescribeInstances_Instance.DescribeInstances_EcsCapacityReservationAttr();
				ecsCapacityReservationAttr.CapacityReservationPreference = _ctx.StringValue("DescribeInstances.Instances["+ i +"].EcsCapacityReservationAttr.CapacityReservationPreference");
				ecsCapacityReservationAttr.CapacityReservationId = _ctx.StringValue("DescribeInstances.Instances["+ i +"].EcsCapacityReservationAttr.CapacityReservationId");
				instance.EcsCapacityReservationAttr = ecsCapacityReservationAttr;

				DescribeInstancesResponse.DescribeInstances_Instance.DescribeInstances_DedicatedInstanceAttribute dedicatedInstanceAttribute = new DescribeInstancesResponse.DescribeInstances_Instance.DescribeInstances_DedicatedInstanceAttribute();
				dedicatedInstanceAttribute.Affinity = _ctx.StringValue("DescribeInstances.Instances["+ i +"].DedicatedInstanceAttribute.Affinity");
				dedicatedInstanceAttribute.Tenancy = _ctx.StringValue("DescribeInstances.Instances["+ i +"].DedicatedInstanceAttribute.Tenancy");
				instance.DedicatedInstanceAttribute = dedicatedInstanceAttribute;

				DescribeInstancesResponse.DescribeInstances_Instance.DescribeInstances_CpuOptions cpuOptions = new DescribeInstancesResponse.DescribeInstances_Instance.DescribeInstances_CpuOptions();
				cpuOptions.Numa = _ctx.StringValue("DescribeInstances.Instances["+ i +"].CpuOptions.Numa");
				cpuOptions.CoreCount = _ctx.IntegerValue("DescribeInstances.Instances["+ i +"].CpuOptions.CoreCount");
				cpuOptions.ThreadsPerCore = _ctx.IntegerValue("DescribeInstances.Instances["+ i +"].CpuOptions.ThreadsPerCore");
				instance.CpuOptions = cpuOptions;

				DescribeInstancesResponse.DescribeInstances_Instance.DescribeInstances_MetadataOptions metadataOptions = new DescribeInstancesResponse.DescribeInstances_Instance.DescribeInstances_MetadataOptions();
				metadataOptions.HttpEndpoint = _ctx.StringValue("DescribeInstances.Instances["+ i +"].MetadataOptions.HttpEndpoint");
				metadataOptions.HttpPutResponseHopLimit = _ctx.IntegerValue("DescribeInstances.Instances["+ i +"].MetadataOptions.HttpPutResponseHopLimit");
				metadataOptions.HttpTokens = _ctx.StringValue("DescribeInstances.Instances["+ i +"].MetadataOptions.HttpTokens");
				instance.MetadataOptions = metadataOptions;

				List<DescribeInstancesResponse.DescribeInstances_Instance.DescribeInstances_NetworkInterface> instance_networkInterfaces = new List<DescribeInstancesResponse.DescribeInstances_Instance.DescribeInstances_NetworkInterface>();
				for (int j = 0; j < _ctx.Length("DescribeInstances.Instances["+ i +"].NetworkInterfaces.Length"); j++) {
					DescribeInstancesResponse.DescribeInstances_Instance.DescribeInstances_NetworkInterface networkInterface = new DescribeInstancesResponse.DescribeInstances_Instance.DescribeInstances_NetworkInterface();
					networkInterface.Type = _ctx.StringValue("DescribeInstances.Instances["+ i +"].NetworkInterfaces["+ j +"].Type");
					networkInterface.MacAddress = _ctx.StringValue("DescribeInstances.Instances["+ i +"].NetworkInterfaces["+ j +"].MacAddress");
					networkInterface.PrimaryIpAddress = _ctx.StringValue("DescribeInstances.Instances["+ i +"].NetworkInterfaces["+ j +"].PrimaryIpAddress");
					networkInterface.NetworkInterfaceId = _ctx.StringValue("DescribeInstances.Instances["+ i +"].NetworkInterfaces["+ j +"].NetworkInterfaceId");

					List<DescribeInstancesResponse.DescribeInstances_Instance.DescribeInstances_NetworkInterface.DescribeInstances_PrivateIpSet> networkInterface_privateIpSets = new List<DescribeInstancesResponse.DescribeInstances_Instance.DescribeInstances_NetworkInterface.DescribeInstances_PrivateIpSet>();
					for (int k = 0; k < _ctx.Length("DescribeInstances.Instances["+ i +"].NetworkInterfaces["+ j +"].PrivateIpSets.Length"); k++) {
						DescribeInstancesResponse.DescribeInstances_Instance.DescribeInstances_NetworkInterface.DescribeInstances_PrivateIpSet privateIpSet = new DescribeInstancesResponse.DescribeInstances_Instance.DescribeInstances_NetworkInterface.DescribeInstances_PrivateIpSet();
						privateIpSet.PrivateIpAddress = _ctx.StringValue("DescribeInstances.Instances["+ i +"].NetworkInterfaces["+ j +"].PrivateIpSets["+ k +"].PrivateIpAddress");
						privateIpSet.Primary = _ctx.BooleanValue("DescribeInstances.Instances["+ i +"].NetworkInterfaces["+ j +"].PrivateIpSets["+ k +"].Primary");

						networkInterface_privateIpSets.Add(privateIpSet);
					}
					networkInterface.PrivateIpSets = networkInterface_privateIpSets;

					List<DescribeInstancesResponse.DescribeInstances_Instance.DescribeInstances_NetworkInterface.DescribeInstances_Ipv6Set> networkInterface_ipv6Sets = new List<DescribeInstancesResponse.DescribeInstances_Instance.DescribeInstances_NetworkInterface.DescribeInstances_Ipv6Set>();
					for (int k = 0; k < _ctx.Length("DescribeInstances.Instances["+ i +"].NetworkInterfaces["+ j +"].Ipv6Sets.Length"); k++) {
						DescribeInstancesResponse.DescribeInstances_Instance.DescribeInstances_NetworkInterface.DescribeInstances_Ipv6Set ipv6Set = new DescribeInstancesResponse.DescribeInstances_Instance.DescribeInstances_NetworkInterface.DescribeInstances_Ipv6Set();
						ipv6Set.Ipv6Address = _ctx.StringValue("DescribeInstances.Instances["+ i +"].NetworkInterfaces["+ j +"].Ipv6Sets["+ k +"].Ipv6Address");

						networkInterface_ipv6Sets.Add(ipv6Set);
					}
					networkInterface.Ipv6Sets = networkInterface_ipv6Sets;

					instance_networkInterfaces.Add(networkInterface);
				}
				instance.NetworkInterfaces = instance_networkInterfaces;

				List<DescribeInstancesResponse.DescribeInstances_Instance.DescribeInstances_LockReason> instance_operationLocks = new List<DescribeInstancesResponse.DescribeInstances_Instance.DescribeInstances_LockReason>();
				for (int j = 0; j < _ctx.Length("DescribeInstances.Instances["+ i +"].OperationLocks.Length"); j++) {
					DescribeInstancesResponse.DescribeInstances_Instance.DescribeInstances_LockReason lockReason = new DescribeInstancesResponse.DescribeInstances_Instance.DescribeInstances_LockReason();
					lockReason.LockMsg = _ctx.StringValue("DescribeInstances.Instances["+ i +"].OperationLocks["+ j +"].LockMsg");
					lockReason.LockReason = _ctx.StringValue("DescribeInstances.Instances["+ i +"].OperationLocks["+ j +"].LockReason");

					instance_operationLocks.Add(lockReason);
				}
				instance.OperationLocks = instance_operationLocks;

				List<DescribeInstancesResponse.DescribeInstances_Instance.DescribeInstances_Tag> instance_tags = new List<DescribeInstancesResponse.DescribeInstances_Instance.DescribeInstances_Tag>();
				for (int j = 0; j < _ctx.Length("DescribeInstances.Instances["+ i +"].Tags.Length"); j++) {
					DescribeInstancesResponse.DescribeInstances_Instance.DescribeInstances_Tag tag = new DescribeInstancesResponse.DescribeInstances_Instance.DescribeInstances_Tag();
					tag.TagValue = _ctx.StringValue("DescribeInstances.Instances["+ i +"].Tags["+ j +"].TagValue");
					tag.TagKey = _ctx.StringValue("DescribeInstances.Instances["+ i +"].Tags["+ j +"].TagKey");

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
