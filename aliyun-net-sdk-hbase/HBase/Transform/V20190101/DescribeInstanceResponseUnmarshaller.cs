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
using Aliyun.Acs.HBase.Model.V20190101;

namespace Aliyun.Acs.HBase.Transform.V20190101
{
    public class DescribeInstanceResponseUnmarshaller
    {
        public static DescribeInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeInstanceResponse describeInstanceResponse = new DescribeInstanceResponse();

			describeInstanceResponse.HttpResponse = _ctx.HttpResponse;
			describeInstanceResponse.VpcId = _ctx.StringValue("DescribeInstance.VpcId");
			describeInstanceResponse.Status = _ctx.StringValue("DescribeInstance.Status");
			describeInstanceResponse.EncryptionType = _ctx.StringValue("DescribeInstance.EncryptionType");
			describeInstanceResponse.ModuleId = _ctx.IntegerValue("DescribeInstance.ModuleId");
			describeInstanceResponse.VswitchId = _ctx.StringValue("DescribeInstance.VswitchId");
			describeInstanceResponse.BackupStatus = _ctx.StringValue("DescribeInstance.BackupStatus");
			describeInstanceResponse.PayType = _ctx.StringValue("DescribeInstance.PayType");
			describeInstanceResponse.CoreDiskType = _ctx.StringValue("DescribeInstance.CoreDiskType");
			describeInstanceResponse.MasterNodeCount = _ctx.IntegerValue("DescribeInstance.MasterNodeCount");
			describeInstanceResponse.NetworkType = _ctx.StringValue("DescribeInstance.NetworkType");
			describeInstanceResponse.CreatedTimeUTC = _ctx.StringValue("DescribeInstance.CreatedTimeUTC");
			describeInstanceResponse.ColdStorageSize = _ctx.IntegerValue("DescribeInstance.ColdStorageSize");
			describeInstanceResponse.ParentId = _ctx.StringValue("DescribeInstance.ParentId");
			describeInstanceResponse.IsLatestVersion = _ctx.BooleanValue("DescribeInstance.IsLatestVersion");
			describeInstanceResponse.ExpireTimeUTC = _ctx.StringValue("DescribeInstance.ExpireTimeUTC");
			describeInstanceResponse.RequestId = _ctx.StringValue("DescribeInstance.RequestId");
			describeInstanceResponse.InstanceName = _ctx.StringValue("DescribeInstance.InstanceName");
			describeInstanceResponse.MasterInstanceType = _ctx.StringValue("DescribeInstance.MasterInstanceType");
			describeInstanceResponse.CoreInstanceType = _ctx.StringValue("DescribeInstance.CoreInstanceType");
			describeInstanceResponse.EncryptionKey = _ctx.StringValue("DescribeInstance.EncryptionKey");
			describeInstanceResponse.CreatedTime = _ctx.StringValue("DescribeInstance.CreatedTime");
			describeInstanceResponse.CoreDiskSize = _ctx.IntegerValue("DescribeInstance.CoreDiskSize");
			describeInstanceResponse.ClusterId = _ctx.StringValue("DescribeInstance.ClusterId");
			describeInstanceResponse.ExpireTime = _ctx.StringValue("DescribeInstance.ExpireTime");
			describeInstanceResponse.MaintainStartTime = _ctx.StringValue("DescribeInstance.MaintainStartTime");
			describeInstanceResponse.ConfirmMaintainTime = _ctx.StringValue("DescribeInstance.ConfirmMaintainTime");
			describeInstanceResponse.IsHa = _ctx.BooleanValue("DescribeInstance.IsHa");
			describeInstanceResponse.MaintainEndTime = _ctx.StringValue("DescribeInstance.MaintainEndTime");
			describeInstanceResponse.InstanceId = _ctx.StringValue("DescribeInstance.InstanceId");
			describeInstanceResponse.ColdStorageStatus = _ctx.StringValue("DescribeInstance.ColdStorageStatus");
			describeInstanceResponse.IsDeletionProtection = _ctx.BooleanValue("DescribeInstance.IsDeletionProtection");
			describeInstanceResponse.MinorVersion = _ctx.StringValue("DescribeInstance.MinorVersion");
			describeInstanceResponse.RegionId = _ctx.StringValue("DescribeInstance.RegionId");
			describeInstanceResponse.MasterDiskSize = _ctx.IntegerValue("DescribeInstance.MasterDiskSize");
			describeInstanceResponse.MasterDiskType = _ctx.StringValue("DescribeInstance.MasterDiskType");
			describeInstanceResponse.NeedUpgrade = _ctx.BooleanValue("DescribeInstance.NeedUpgrade");
			describeInstanceResponse.IsMultiModel = _ctx.BooleanValue("DescribeInstance.IsMultiModel");
			describeInstanceResponse.AutoRenewal = _ctx.BooleanValue("DescribeInstance.AutoRenewal");
			describeInstanceResponse.ClusterType = _ctx.StringValue("DescribeInstance.ClusterType");
			describeInstanceResponse.ResourceGroupId = _ctx.StringValue("DescribeInstance.ResourceGroupId");
			describeInstanceResponse.ClusterName = _ctx.StringValue("DescribeInstance.ClusterName");
			describeInstanceResponse.ZoneId = _ctx.StringValue("DescribeInstance.ZoneId");
			describeInstanceResponse.Duration = _ctx.IntegerValue("DescribeInstance.Duration");
			describeInstanceResponse.ModuleStackVersion = _ctx.StringValue("DescribeInstance.ModuleStackVersion");
			describeInstanceResponse.Engine = _ctx.StringValue("DescribeInstance.Engine");
			describeInstanceResponse.MajorVersion = _ctx.StringValue("DescribeInstance.MajorVersion");
			describeInstanceResponse.CoreDiskCount = _ctx.StringValue("DescribeInstance.CoreDiskCount");
			describeInstanceResponse.TaskProgress = _ctx.StringValue("DescribeInstance.TaskProgress");
			describeInstanceResponse.CoreNodeCount = _ctx.IntegerValue("DescribeInstance.CoreNodeCount");

			List<string> describeInstanceResponse_needUpgradeComps = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeInstance.NeedUpgradeComps.Length"); i++) {
				describeInstanceResponse_needUpgradeComps.Add(_ctx.StringValue("DescribeInstance.NeedUpgradeComps["+ i +"]"));
			}
			describeInstanceResponse.NeedUpgradeComps = describeInstanceResponse_needUpgradeComps;

			List<DescribeInstanceResponse.DescribeInstance_Tag> describeInstanceResponse_tags = new List<DescribeInstanceResponse.DescribeInstance_Tag>();
			for (int i = 0; i < _ctx.Length("DescribeInstance.Tags.Length"); i++) {
				DescribeInstanceResponse.DescribeInstance_Tag tag = new DescribeInstanceResponse.DescribeInstance_Tag();
				tag.Key = _ctx.StringValue("DescribeInstance.Tags["+ i +"].Key");
				tag._Value = _ctx.StringValue("DescribeInstance.Tags["+ i +"].Value");

				describeInstanceResponse_tags.Add(tag);
			}
			describeInstanceResponse.Tags = describeInstanceResponse_tags;
        
			return describeInstanceResponse;
        }
    }
}
