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
    public class DescribeLaunchTemplateVersionsResponseUnmarshaller
    {
        public static DescribeLaunchTemplateVersionsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeLaunchTemplateVersionsResponse describeLaunchTemplateVersionsResponse = new DescribeLaunchTemplateVersionsResponse();

			describeLaunchTemplateVersionsResponse.HttpResponse = context.HttpResponse;
			describeLaunchTemplateVersionsResponse.RequestId = context.StringValue("DescribeLaunchTemplateVersions.RequestId");
			describeLaunchTemplateVersionsResponse.TotalCount = context.IntegerValue("DescribeLaunchTemplateVersions.TotalCount");
			describeLaunchTemplateVersionsResponse.PageNumber = context.IntegerValue("DescribeLaunchTemplateVersions.PageNumber");
			describeLaunchTemplateVersionsResponse.PageSize = context.IntegerValue("DescribeLaunchTemplateVersions.PageSize");

			List<DescribeLaunchTemplateVersionsResponse.DescribeLaunchTemplateVersions_LaunchTemplateVersionSet> describeLaunchTemplateVersionsResponse_launchTemplateVersionSets = new List<DescribeLaunchTemplateVersionsResponse.DescribeLaunchTemplateVersions_LaunchTemplateVersionSet>();
			for (int i = 0; i < context.Length("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets.Length"); i++) {
				DescribeLaunchTemplateVersionsResponse.DescribeLaunchTemplateVersions_LaunchTemplateVersionSet launchTemplateVersionSet = new DescribeLaunchTemplateVersionsResponse.DescribeLaunchTemplateVersions_LaunchTemplateVersionSet();
				launchTemplateVersionSet.CreateTime = context.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].CreateTime");
				launchTemplateVersionSet.ModifiedTime = context.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].ModifiedTime");
				launchTemplateVersionSet.LaunchTemplateId = context.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateId");
				launchTemplateVersionSet.LaunchTemplateName = context.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateName");
				launchTemplateVersionSet.DefaultVersion = context.BooleanValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].DefaultVersion");
				launchTemplateVersionSet.VersionNumber = context.LongValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].VersionNumber");
				launchTemplateVersionSet.VersionDescription = context.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].VersionDescription");
				launchTemplateVersionSet.CreatedBy = context.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].CreatedBy");

				DescribeLaunchTemplateVersionsResponse.DescribeLaunchTemplateVersions_LaunchTemplateVersionSet.DescribeLaunchTemplateVersions_LaunchTemplateData launchTemplateData = new DescribeLaunchTemplateVersionsResponse.DescribeLaunchTemplateVersions_LaunchTemplateVersionSet.DescribeLaunchTemplateVersions_LaunchTemplateData();
				launchTemplateData.ImageId = context.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.ImageId");
				launchTemplateData.ImageOwnerAlias = context.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.ImageOwnerAlias");
				launchTemplateData.PasswordInherit = context.BooleanValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.PasswordInherit");
				launchTemplateData.InstanceType = context.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.InstanceType");
				launchTemplateData.SecurityGroupId = context.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.SecurityGroupId");
				launchTemplateData.VpcId = context.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.VpcId");
				launchTemplateData.VSwitchId = context.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.VSwitchId");
				launchTemplateData.InstanceName = context.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.InstanceName");
				launchTemplateData.Description = context.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.Description");
				launchTemplateData.InternetMaxBandwidthIn = context.IntegerValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.InternetMaxBandwidthIn");
				launchTemplateData.InternetMaxBandwidthOut = context.IntegerValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.InternetMaxBandwidthOut");
				launchTemplateData.HostName = context.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.HostName");
				launchTemplateData.ZoneId = context.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.ZoneId");
				launchTemplateData.SystemDiskSize = context.IntegerValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.SystemDisk.Size");
				launchTemplateData.SystemDiskCategory = context.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.SystemDisk.Category");
				launchTemplateData.SystemDiskDiskName = context.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.SystemDisk.DiskName");
				launchTemplateData.SystemDiskDescription = context.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.SystemDisk.Description");
				launchTemplateData.SystemDiskIops = context.IntegerValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.SystemDisk.Iops");
				launchTemplateData.IoOptimized = context.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.IoOptimized");
				launchTemplateData.InstanceChargeType = context.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.InstanceChargeType");
				launchTemplateData.Period = context.IntegerValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.Period");
				launchTemplateData.InternetChargeType = context.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.InternetChargeType");
				launchTemplateData.EnableVmOsConfig = context.BooleanValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.EnableVmOsConfig");
				launchTemplateData.NetworkType = context.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.NetworkType");
				launchTemplateData.UserData = context.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.UserData");
				launchTemplateData.KeyPairName = context.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.KeyPairName");
				launchTemplateData.RamRoleName = context.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.RamRoleName");
				launchTemplateData.AutoReleaseTime = context.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.AutoReleaseTime");
				launchTemplateData.SpotStrategy = context.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.SpotStrategy");
				launchTemplateData.SpotPriceLimit = context.FloatValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.SpotPriceLimit");
				launchTemplateData.SpotDuration = context.IntegerValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.SpotDuration");
				launchTemplateData.ResourceGroupId = context.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.ResourceGroupId");
				launchTemplateData.SecurityEnhancementStrategy = context.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.SecurityEnhancementStrategy");

				List<DescribeLaunchTemplateVersionsResponse.DescribeLaunchTemplateVersions_LaunchTemplateVersionSet.DescribeLaunchTemplateVersions_LaunchTemplateData.DescribeLaunchTemplateVersions_DataDisk> launchTemplateData_dataDisks = new List<DescribeLaunchTemplateVersionsResponse.DescribeLaunchTemplateVersions_LaunchTemplateVersionSet.DescribeLaunchTemplateVersions_LaunchTemplateData.DescribeLaunchTemplateVersions_DataDisk>();
				for (int j = 0; j < context.Length("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.DataDisks.Length"); j++) {
					DescribeLaunchTemplateVersionsResponse.DescribeLaunchTemplateVersions_LaunchTemplateVersionSet.DescribeLaunchTemplateVersions_LaunchTemplateData.DescribeLaunchTemplateVersions_DataDisk dataDisk = new DescribeLaunchTemplateVersionsResponse.DescribeLaunchTemplateVersions_LaunchTemplateVersionSet.DescribeLaunchTemplateVersions_LaunchTemplateData.DescribeLaunchTemplateVersions_DataDisk();
					dataDisk.Size = context.IntegerValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.DataDisks["+ j +"].Size");
					dataDisk.SnapshotId = context.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.DataDisks["+ j +"].SnapshotId");
					dataDisk.Category = context.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.DataDisks["+ j +"].Category");
					dataDisk.Encrypted = context.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.DataDisks["+ j +"].Encrypted");
					dataDisk.DiskName = context.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.DataDisks["+ j +"].DiskName");
					dataDisk.Description = context.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.DataDisks["+ j +"].Description");
					dataDisk.DeleteWithInstance = context.BooleanValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.DataDisks["+ j +"].DeleteWithInstance");
					dataDisk.Device = context.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.DataDisks["+ j +"].Device");

					launchTemplateData_dataDisks.Add(dataDisk);
				}
				launchTemplateData.DataDisks = launchTemplateData_dataDisks;

				List<DescribeLaunchTemplateVersionsResponse.DescribeLaunchTemplateVersions_LaunchTemplateVersionSet.DescribeLaunchTemplateVersions_LaunchTemplateData.DescribeLaunchTemplateVersions_NetworkInterface> launchTemplateData_networkInterfaces = new List<DescribeLaunchTemplateVersionsResponse.DescribeLaunchTemplateVersions_LaunchTemplateVersionSet.DescribeLaunchTemplateVersions_LaunchTemplateData.DescribeLaunchTemplateVersions_NetworkInterface>();
				for (int j = 0; j < context.Length("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.NetworkInterfaces.Length"); j++) {
					DescribeLaunchTemplateVersionsResponse.DescribeLaunchTemplateVersions_LaunchTemplateVersionSet.DescribeLaunchTemplateVersions_LaunchTemplateData.DescribeLaunchTemplateVersions_NetworkInterface networkInterface = new DescribeLaunchTemplateVersionsResponse.DescribeLaunchTemplateVersions_LaunchTemplateVersionSet.DescribeLaunchTemplateVersions_LaunchTemplateData.DescribeLaunchTemplateVersions_NetworkInterface();
					networkInterface.PrimaryIpAddress = context.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.NetworkInterfaces["+ j +"].PrimaryIpAddress");
					networkInterface.VSwitchId = context.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.NetworkInterfaces["+ j +"].VSwitchId");
					networkInterface.SecurityGroupId = context.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.NetworkInterfaces["+ j +"].SecurityGroupId");
					networkInterface.NetworkInterfaceName = context.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.NetworkInterfaces["+ j +"].NetworkInterfaceName");
					networkInterface.Description = context.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.NetworkInterfaces["+ j +"].Description");

					launchTemplateData_networkInterfaces.Add(networkInterface);
				}
				launchTemplateData.NetworkInterfaces = launchTemplateData_networkInterfaces;

				List<DescribeLaunchTemplateVersionsResponse.DescribeLaunchTemplateVersions_LaunchTemplateVersionSet.DescribeLaunchTemplateVersions_LaunchTemplateData.DescribeLaunchTemplateVersions_InstanceTag> launchTemplateData_tags = new List<DescribeLaunchTemplateVersionsResponse.DescribeLaunchTemplateVersions_LaunchTemplateVersionSet.DescribeLaunchTemplateVersions_LaunchTemplateData.DescribeLaunchTemplateVersions_InstanceTag>();
				for (int j = 0; j < context.Length("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.Tags.Length"); j++) {
					DescribeLaunchTemplateVersionsResponse.DescribeLaunchTemplateVersions_LaunchTemplateVersionSet.DescribeLaunchTemplateVersions_LaunchTemplateData.DescribeLaunchTemplateVersions_InstanceTag instanceTag = new DescribeLaunchTemplateVersionsResponse.DescribeLaunchTemplateVersions_LaunchTemplateVersionSet.DescribeLaunchTemplateVersions_LaunchTemplateData.DescribeLaunchTemplateVersions_InstanceTag();
					instanceTag.Key = context.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.Tags["+ j +"].Key");
					instanceTag._Value = context.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.Tags["+ j +"].Value");

					launchTemplateData_tags.Add(instanceTag);
				}
				launchTemplateData.Tags = launchTemplateData_tags;
				launchTemplateVersionSet.LaunchTemplateData = launchTemplateData;

				describeLaunchTemplateVersionsResponse_launchTemplateVersionSets.Add(launchTemplateVersionSet);
			}
			describeLaunchTemplateVersionsResponse.LaunchTemplateVersionSets = describeLaunchTemplateVersionsResponse_launchTemplateVersionSets;
        
			return describeLaunchTemplateVersionsResponse;
        }
    }
}
