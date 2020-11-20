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
using Aliyun.Acs.Ess.Model.V20140828;

namespace Aliyun.Acs.Ess.Transform.V20140828
{
    public class DescribeScalingConfigurationsResponseUnmarshaller
    {
        public static DescribeScalingConfigurationsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeScalingConfigurationsResponse describeScalingConfigurationsResponse = new DescribeScalingConfigurationsResponse();

			describeScalingConfigurationsResponse.HttpResponse = context.HttpResponse;
			describeScalingConfigurationsResponse.TotalCount = context.IntegerValue("DescribeScalingConfigurations.TotalCount");
			describeScalingConfigurationsResponse.PageNumber = context.IntegerValue("DescribeScalingConfigurations.PageNumber");
			describeScalingConfigurationsResponse.PageSize = context.IntegerValue("DescribeScalingConfigurations.PageSize");
			describeScalingConfigurationsResponse.RequestId = context.StringValue("DescribeScalingConfigurations.RequestId");

			List<DescribeScalingConfigurationsResponse.DescribeScalingConfigurations_ScalingConfiguration> describeScalingConfigurationsResponse_scalingConfigurations = new List<DescribeScalingConfigurationsResponse.DescribeScalingConfigurations_ScalingConfiguration>();
			for (int i = 0; i < context.Length("DescribeScalingConfigurations.ScalingConfigurations.Length"); i++) {
				DescribeScalingConfigurationsResponse.DescribeScalingConfigurations_ScalingConfiguration scalingConfiguration = new DescribeScalingConfigurationsResponse.DescribeScalingConfigurations_ScalingConfiguration();
				scalingConfiguration.ScalingConfigurationId = context.StringValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].ScalingConfigurationId");
				scalingConfiguration.ScalingConfigurationName = context.StringValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].ScalingConfigurationName");
				scalingConfiguration.ScalingGroupId = context.StringValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].ScalingGroupId");
				scalingConfiguration.InstanceName = context.StringValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].InstanceName");
				scalingConfiguration.ImageId = context.StringValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].ImageId");
				scalingConfiguration.ImageName = context.StringValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].ImageName");
				scalingConfiguration.HostName = context.StringValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].HostName");
				scalingConfiguration.InstanceType = context.StringValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].InstanceType");
				scalingConfiguration.Cpu = context.IntegerValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].Cpu");
				scalingConfiguration.Memory = context.IntegerValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].Memory");
				scalingConfiguration.InstanceGeneration = context.StringValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].InstanceGeneration");
				scalingConfiguration.SecurityGroupId = context.StringValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].SecurityGroupId");
				scalingConfiguration.IoOptimized = context.StringValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].IoOptimized");
				scalingConfiguration.InternetChargeType = context.StringValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].InternetChargeType");
				scalingConfiguration.InternetMaxBandwidthIn = context.IntegerValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].InternetMaxBandwidthIn");
				scalingConfiguration.InternetMaxBandwidthOut = context.IntegerValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].InternetMaxBandwidthOut");
				scalingConfiguration.SystemDiskCategory = context.StringValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].SystemDiskCategory");
				scalingConfiguration.SystemDiskSize = context.IntegerValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].SystemDiskSize");
				scalingConfiguration.SystemDiskName = context.StringValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].SystemDiskName");
				scalingConfiguration.SystemDiskDescription = context.StringValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].SystemDiskDescription");
				scalingConfiguration.SystemDiskAutoSnapshotPolicyId = context.StringValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].SystemDiskAutoSnapshotPolicyId");
				scalingConfiguration.LifecycleState = context.StringValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].LifecycleState");
				scalingConfiguration.CreationTime = context.StringValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].CreationTime");
				scalingConfiguration.LoadBalancerWeight = context.IntegerValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].LoadBalancerWeight");
				scalingConfiguration.UserData = context.StringValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].UserData");
				scalingConfiguration.KeyPairName = context.StringValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].KeyPairName");
				scalingConfiguration.RamRoleName = context.StringValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].RamRoleName");
				scalingConfiguration.DeploymentSetId = context.StringValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].DeploymentSetId");
				scalingConfiguration.SecurityEnhancementStrategy = context.StringValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].SecurityEnhancementStrategy");
				scalingConfiguration.SpotStrategy = context.StringValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].SpotStrategy");
				scalingConfiguration.PasswordInherit = context.BooleanValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].PasswordInherit");
				scalingConfiguration.ResourceGroupId = context.StringValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].ResourceGroupId");
				scalingConfiguration.HpcClusterId = context.StringValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].HpcClusterId");
				scalingConfiguration.InstanceDescription = context.StringValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].InstanceDescription");
				scalingConfiguration.CreditSpecification = context.StringValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].CreditSpecification");
				scalingConfiguration.ImageFamily = context.StringValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].ImageFamily");
				scalingConfiguration.ZoneId = context.StringValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].ZoneId");
				scalingConfiguration.DedicatedHostId = context.StringValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].DedicatedHostId");
				scalingConfiguration.Affinity = context.StringValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].Affinity");
				scalingConfiguration.Tenancy = context.StringValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].Tenancy");
				scalingConfiguration.PrivatePoolOptionsMatchCriteria = context.StringValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].PrivatePoolOptions.MatchCriteria");
				scalingConfiguration.PrivatePoolOptionsId = context.StringValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].PrivatePoolOptions.Id");
				scalingConfiguration.Ipv6AddressCount = context.IntegerValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].Ipv6AddressCount");

				List<string> scalingConfiguration_instanceTypes = new List<string>();
				for (int j = 0; j < context.Length("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].InstanceTypes.Length"); j++) {
					scalingConfiguration_instanceTypes.Add(context.StringValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].InstanceTypes["+ j +"]"));
				}
				scalingConfiguration.InstanceTypes = scalingConfiguration_instanceTypes;

				List<string> scalingConfiguration_securityGroupIds = new List<string>();
				for (int j = 0; j < context.Length("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].SecurityGroupIds.Length"); j++) {
					scalingConfiguration_securityGroupIds.Add(context.StringValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].SecurityGroupIds["+ j +"]"));
				}
				scalingConfiguration.SecurityGroupIds = scalingConfiguration_securityGroupIds;

				DescribeScalingConfigurationsResponse.DescribeScalingConfigurations_ScalingConfiguration.DescribeScalingConfigurations_SchedulerOptions schedulerOptions = new DescribeScalingConfigurationsResponse.DescribeScalingConfigurations_ScalingConfiguration.DescribeScalingConfigurations_SchedulerOptions();
				schedulerOptions.ManagedPrivateSpaceId = context.StringValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].SchedulerOptions.ManagedPrivateSpaceId");
				scalingConfiguration.SchedulerOptions = schedulerOptions;

				List<DescribeScalingConfigurationsResponse.DescribeScalingConfigurations_ScalingConfiguration.DescribeScalingConfigurations_DataDisk> scalingConfiguration_dataDisks = new List<DescribeScalingConfigurationsResponse.DescribeScalingConfigurations_ScalingConfiguration.DescribeScalingConfigurations_DataDisk>();
				for (int j = 0; j < context.Length("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].DataDisks.Length"); j++) {
					DescribeScalingConfigurationsResponse.DescribeScalingConfigurations_ScalingConfiguration.DescribeScalingConfigurations_DataDisk dataDisk = new DescribeScalingConfigurationsResponse.DescribeScalingConfigurations_ScalingConfiguration.DescribeScalingConfigurations_DataDisk();
					dataDisk.Size = context.IntegerValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].DataDisks["+ j +"].Size");
					dataDisk.Category = context.StringValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].DataDisks["+ j +"].Category");
					dataDisk.SnapshotId = context.StringValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].DataDisks["+ j +"].SnapshotId");
					dataDisk.Device = context.StringValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].DataDisks["+ j +"].Device");
					dataDisk.DeleteWithInstance = context.BooleanValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].DataDisks["+ j +"].DeleteWithInstance");
					dataDisk.Encrypted = context.StringValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].DataDisks["+ j +"].Encrypted");
					dataDisk.KMSKeyId = context.StringValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].DataDisks["+ j +"].KMSKeyId");
					dataDisk.DiskName = context.StringValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].DataDisks["+ j +"].DiskName");
					dataDisk.Description = context.StringValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].DataDisks["+ j +"].Description");
					dataDisk.AutoSnapshotPolicyId = context.StringValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].DataDisks["+ j +"].AutoSnapshotPolicyId");

					scalingConfiguration_dataDisks.Add(dataDisk);
				}
				scalingConfiguration.DataDisks = scalingConfiguration_dataDisks;

				List<DescribeScalingConfigurationsResponse.DescribeScalingConfigurations_ScalingConfiguration.DescribeScalingConfigurations_Tag> scalingConfiguration_tags = new List<DescribeScalingConfigurationsResponse.DescribeScalingConfigurations_ScalingConfiguration.DescribeScalingConfigurations_Tag>();
				for (int j = 0; j < context.Length("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].Tags.Length"); j++) {
					DescribeScalingConfigurationsResponse.DescribeScalingConfigurations_ScalingConfiguration.DescribeScalingConfigurations_Tag tag = new DescribeScalingConfigurationsResponse.DescribeScalingConfigurations_ScalingConfiguration.DescribeScalingConfigurations_Tag();
					tag.Key = context.StringValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].Tags["+ j +"].Key");
					tag._Value = context.StringValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].Tags["+ j +"].Value");

					scalingConfiguration_tags.Add(tag);
				}
				scalingConfiguration.Tags = scalingConfiguration_tags;

				List<DescribeScalingConfigurationsResponse.DescribeScalingConfigurations_ScalingConfiguration.DescribeScalingConfigurations_SpotPriceModel> scalingConfiguration_spotPriceLimit = new List<DescribeScalingConfigurationsResponse.DescribeScalingConfigurations_ScalingConfiguration.DescribeScalingConfigurations_SpotPriceModel>();
				for (int j = 0; j < context.Length("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].SpotPriceLimit.Length"); j++) {
					DescribeScalingConfigurationsResponse.DescribeScalingConfigurations_ScalingConfiguration.DescribeScalingConfigurations_SpotPriceModel spotPriceModel = new DescribeScalingConfigurationsResponse.DescribeScalingConfigurations_ScalingConfiguration.DescribeScalingConfigurations_SpotPriceModel();
					spotPriceModel.InstanceType = context.StringValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].SpotPriceLimit["+ j +"].InstanceType");
					spotPriceModel.PriceLimit = context.FloatValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].SpotPriceLimit["+ j +"].PriceLimit");

					scalingConfiguration_spotPriceLimit.Add(spotPriceModel);
				}
				scalingConfiguration.SpotPriceLimit = scalingConfiguration_spotPriceLimit;

				describeScalingConfigurationsResponse_scalingConfigurations.Add(scalingConfiguration);
			}
			describeScalingConfigurationsResponse.ScalingConfigurations = describeScalingConfigurationsResponse_scalingConfigurations;
        
			return describeScalingConfigurationsResponse;
        }
    }
}
