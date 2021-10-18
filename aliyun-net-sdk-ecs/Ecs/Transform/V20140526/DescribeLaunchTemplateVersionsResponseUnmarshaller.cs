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
        public static DescribeLaunchTemplateVersionsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLaunchTemplateVersionsResponse describeLaunchTemplateVersionsResponse = new DescribeLaunchTemplateVersionsResponse();

			describeLaunchTemplateVersionsResponse.HttpResponse = _ctx.HttpResponse;
			describeLaunchTemplateVersionsResponse.PageSize = _ctx.IntegerValue("DescribeLaunchTemplateVersions.PageSize");
			describeLaunchTemplateVersionsResponse.RequestId = _ctx.StringValue("DescribeLaunchTemplateVersions.RequestId");
			describeLaunchTemplateVersionsResponse.PageNumber = _ctx.IntegerValue("DescribeLaunchTemplateVersions.PageNumber");
			describeLaunchTemplateVersionsResponse.TotalCount = _ctx.IntegerValue("DescribeLaunchTemplateVersions.TotalCount");

			List<DescribeLaunchTemplateVersionsResponse.DescribeLaunchTemplateVersions_LaunchTemplateVersionSet> describeLaunchTemplateVersionsResponse_launchTemplateVersionSets = new List<DescribeLaunchTemplateVersionsResponse.DescribeLaunchTemplateVersions_LaunchTemplateVersionSet>();
			for (int i = 0; i < _ctx.Length("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets.Length"); i++) {
				DescribeLaunchTemplateVersionsResponse.DescribeLaunchTemplateVersions_LaunchTemplateVersionSet launchTemplateVersionSet = new DescribeLaunchTemplateVersionsResponse.DescribeLaunchTemplateVersions_LaunchTemplateVersionSet();
				launchTemplateVersionSet.LaunchTemplateName = _ctx.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateName");
				launchTemplateVersionSet.DefaultVersion = _ctx.BooleanValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].DefaultVersion");
				launchTemplateVersionSet.VersionNumber = _ctx.LongValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].VersionNumber");
				launchTemplateVersionSet.ModifiedTime = _ctx.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].ModifiedTime");
				launchTemplateVersionSet.LaunchTemplateId = _ctx.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateId");
				launchTemplateVersionSet.CreateTime = _ctx.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].CreateTime");
				launchTemplateVersionSet.CreatedBy = _ctx.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].CreatedBy");
				launchTemplateVersionSet.VersionDescription = _ctx.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].VersionDescription");

				DescribeLaunchTemplateVersionsResponse.DescribeLaunchTemplateVersions_LaunchTemplateVersionSet.DescribeLaunchTemplateVersions_LaunchTemplateData launchTemplateData = new DescribeLaunchTemplateVersionsResponse.DescribeLaunchTemplateVersions_LaunchTemplateVersionSet.DescribeLaunchTemplateVersions_LaunchTemplateData();
				launchTemplateData.DeploymentSetId = _ctx.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.DeploymentSetId");
				launchTemplateData.VpcId = _ctx.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.VpcId");
				launchTemplateData.SystemDiskPerformanceLevel = _ctx.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.SystemDisk.PerformanceLevel");
				launchTemplateData.KeyPairName = _ctx.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.KeyPairName");
				launchTemplateData.SecurityGroupId = _ctx.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.SecurityGroupId");
				launchTemplateData.NetworkType = _ctx.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.NetworkType");
				launchTemplateData.SpotStrategy = _ctx.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.SpotStrategy");
				launchTemplateData.EnableVmOsConfig = _ctx.BooleanValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.EnableVmOsConfig");
				launchTemplateData.Description = _ctx.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.Description");
				launchTemplateData.SpotDuration = _ctx.IntegerValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.SpotDuration");
				launchTemplateData.InstanceName = _ctx.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.InstanceName");
				launchTemplateData.SecurityEnhancementStrategy = _ctx.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.SecurityEnhancementStrategy");
				launchTemplateData.UserData = _ctx.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.UserData");
				launchTemplateData.SystemDiskDiskName = _ctx.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.SystemDisk.DiskName");
				launchTemplateData.SystemDiskSize = _ctx.IntegerValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.SystemDisk.Size");
				launchTemplateData.SpotPriceLimit = _ctx.FloatValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.SpotPriceLimit");
				launchTemplateData.PasswordInherit = _ctx.BooleanValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.PasswordInherit");
				launchTemplateData.PrivateIpAddress = _ctx.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.PrivateIpAddress");
				launchTemplateData.ImageId = _ctx.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.ImageId");
				launchTemplateData.SystemDiskDeleteWithInstance = _ctx.BooleanValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.SystemDisk.DeleteWithInstance");
				launchTemplateData.SystemDiskCategory = _ctx.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.SystemDisk.Category");
				launchTemplateData.AutoReleaseTime = _ctx.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.AutoReleaseTime");
				launchTemplateData.SystemDiskDescription = _ctx.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.SystemDisk.Description");
				launchTemplateData.ImageOwnerAlias = _ctx.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.ImageOwnerAlias");
				launchTemplateData.HostName = _ctx.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.HostName");
				launchTemplateData.SystemDiskIops = _ctx.IntegerValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.SystemDisk.Iops");
				launchTemplateData.InternetMaxBandwidthOut = _ctx.IntegerValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.InternetMaxBandwidthOut");
				launchTemplateData.InternetMaxBandwidthIn = _ctx.IntegerValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.InternetMaxBandwidthIn");
				launchTemplateData.InstanceType = _ctx.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.InstanceType");
				launchTemplateData.Period = _ctx.IntegerValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.Period");
				launchTemplateData.InstanceChargeType = _ctx.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.InstanceChargeType");
				launchTemplateData.IoOptimized = _ctx.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.IoOptimized");
				launchTemplateData.RamRoleName = _ctx.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.RamRoleName");
				launchTemplateData.VSwitchId = _ctx.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.VSwitchId");
				launchTemplateData.ResourceGroupId = _ctx.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.ResourceGroupId");
				launchTemplateData.InternetChargeType = _ctx.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.InternetChargeType");
				launchTemplateData.ZoneId = _ctx.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.ZoneId");

				List<string> launchTemplateData_securityGroupIds = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.SecurityGroupIds.Length"); j++) {
					launchTemplateData_securityGroupIds.Add(_ctx.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.SecurityGroupIds["+ j +"]"));
				}
				launchTemplateData.SecurityGroupIds = launchTemplateData_securityGroupIds;

				List<DescribeLaunchTemplateVersionsResponse.DescribeLaunchTemplateVersions_LaunchTemplateVersionSet.DescribeLaunchTemplateVersions_LaunchTemplateData.DescribeLaunchTemplateVersions_DataDisk> launchTemplateData_dataDisks = new List<DescribeLaunchTemplateVersionsResponse.DescribeLaunchTemplateVersions_LaunchTemplateVersionSet.DescribeLaunchTemplateVersions_LaunchTemplateData.DescribeLaunchTemplateVersions_DataDisk>();
				for (int j = 0; j < _ctx.Length("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.DataDisks.Length"); j++) {
					DescribeLaunchTemplateVersionsResponse.DescribeLaunchTemplateVersions_LaunchTemplateVersionSet.DescribeLaunchTemplateVersions_LaunchTemplateData.DescribeLaunchTemplateVersions_DataDisk dataDisk = new DescribeLaunchTemplateVersionsResponse.DescribeLaunchTemplateVersions_LaunchTemplateVersionSet.DescribeLaunchTemplateVersions_LaunchTemplateData.DescribeLaunchTemplateVersions_DataDisk();
					dataDisk.PerformanceLevel = _ctx.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.DataDisks["+ j +"].PerformanceLevel");
					dataDisk.Description = _ctx.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.DataDisks["+ j +"].Description");
					dataDisk.SnapshotId = _ctx.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.DataDisks["+ j +"].SnapshotId");
					dataDisk.Device = _ctx.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.DataDisks["+ j +"].Device");
					dataDisk.Size = _ctx.IntegerValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.DataDisks["+ j +"].Size");
					dataDisk.DiskName = _ctx.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.DataDisks["+ j +"].DiskName");
					dataDisk.Category = _ctx.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.DataDisks["+ j +"].Category");
					dataDisk.DeleteWithInstance = _ctx.BooleanValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.DataDisks["+ j +"].DeleteWithInstance");
					dataDisk.Encrypted = _ctx.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.DataDisks["+ j +"].Encrypted");

					launchTemplateData_dataDisks.Add(dataDisk);
				}
				launchTemplateData.DataDisks = launchTemplateData_dataDisks;

				List<DescribeLaunchTemplateVersionsResponse.DescribeLaunchTemplateVersions_LaunchTemplateVersionSet.DescribeLaunchTemplateVersions_LaunchTemplateData.DescribeLaunchTemplateVersions_NetworkInterface> launchTemplateData_networkInterfaces = new List<DescribeLaunchTemplateVersionsResponse.DescribeLaunchTemplateVersions_LaunchTemplateVersionSet.DescribeLaunchTemplateVersions_LaunchTemplateData.DescribeLaunchTemplateVersions_NetworkInterface>();
				for (int j = 0; j < _ctx.Length("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.NetworkInterfaces.Length"); j++) {
					DescribeLaunchTemplateVersionsResponse.DescribeLaunchTemplateVersions_LaunchTemplateVersionSet.DescribeLaunchTemplateVersions_LaunchTemplateData.DescribeLaunchTemplateVersions_NetworkInterface networkInterface = new DescribeLaunchTemplateVersionsResponse.DescribeLaunchTemplateVersions_LaunchTemplateVersionSet.DescribeLaunchTemplateVersions_LaunchTemplateData.DescribeLaunchTemplateVersions_NetworkInterface();
					networkInterface.NetworkInterfaceName = _ctx.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.NetworkInterfaces["+ j +"].NetworkInterfaceName");
					networkInterface.VSwitchId = _ctx.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.NetworkInterfaces["+ j +"].VSwitchId");
					networkInterface.Description = _ctx.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.NetworkInterfaces["+ j +"].Description");
					networkInterface.PrimaryIpAddress = _ctx.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.NetworkInterfaces["+ j +"].PrimaryIpAddress");
					networkInterface.SecurityGroupId = _ctx.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.NetworkInterfaces["+ j +"].SecurityGroupId");

					List<string> networkInterface_securityGroupIds1 = new List<string>();
					for (int k = 0; k < _ctx.Length("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.NetworkInterfaces["+ j +"].SecurityGroupIds.Length"); k++) {
						networkInterface_securityGroupIds1.Add(_ctx.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.NetworkInterfaces["+ j +"].SecurityGroupIds["+ k +"]"));
					}
					networkInterface.SecurityGroupIds1 = networkInterface_securityGroupIds1;

					launchTemplateData_networkInterfaces.Add(networkInterface);
				}
				launchTemplateData.NetworkInterfaces = launchTemplateData_networkInterfaces;

				List<DescribeLaunchTemplateVersionsResponse.DescribeLaunchTemplateVersions_LaunchTemplateVersionSet.DescribeLaunchTemplateVersions_LaunchTemplateData.DescribeLaunchTemplateVersions_InstanceTag> launchTemplateData_tags = new List<DescribeLaunchTemplateVersionsResponse.DescribeLaunchTemplateVersions_LaunchTemplateVersionSet.DescribeLaunchTemplateVersions_LaunchTemplateData.DescribeLaunchTemplateVersions_InstanceTag>();
				for (int j = 0; j < _ctx.Length("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.Tags.Length"); j++) {
					DescribeLaunchTemplateVersionsResponse.DescribeLaunchTemplateVersions_LaunchTemplateVersionSet.DescribeLaunchTemplateVersions_LaunchTemplateData.DescribeLaunchTemplateVersions_InstanceTag instanceTag = new DescribeLaunchTemplateVersionsResponse.DescribeLaunchTemplateVersions_LaunchTemplateVersionSet.DescribeLaunchTemplateVersions_LaunchTemplateData.DescribeLaunchTemplateVersions_InstanceTag();
					instanceTag.Key = _ctx.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.Tags["+ j +"].Key");
					instanceTag._Value = _ctx.StringValue("DescribeLaunchTemplateVersions.LaunchTemplateVersionSets["+ i +"].LaunchTemplateData.Tags["+ j +"].Value");

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
