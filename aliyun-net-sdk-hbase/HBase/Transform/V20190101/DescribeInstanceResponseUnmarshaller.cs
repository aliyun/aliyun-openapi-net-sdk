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
        public static DescribeInstanceResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeInstanceResponse describeInstanceResponse = new DescribeInstanceResponse();

			describeInstanceResponse.HttpResponse = context.HttpResponse;
			describeInstanceResponse.RequestId = context.StringValue("DescribeInstance.RequestId");
			describeInstanceResponse.InstanceId = context.StringValue("DescribeInstance.InstanceId");
			describeInstanceResponse.InstanceName = context.StringValue("DescribeInstance.InstanceName");
			describeInstanceResponse.Status = context.StringValue("DescribeInstance.Status");
			describeInstanceResponse.PayType = context.StringValue("DescribeInstance.PayType");
			describeInstanceResponse.CreatedTime = context.StringValue("DescribeInstance.CreatedTime");
			describeInstanceResponse.ExpireTime = context.StringValue("DescribeInstance.ExpireTime");
			describeInstanceResponse.MajorVersion = context.StringValue("DescribeInstance.MajorVersion");
			describeInstanceResponse.MinorVersion = context.StringValue("DescribeInstance.MinorVersion");
			describeInstanceResponse.Engine = context.StringValue("DescribeInstance.Engine");
			describeInstanceResponse.IsHa = context.BooleanValue("DescribeInstance.IsHa");
			describeInstanceResponse.NetworkType = context.StringValue("DescribeInstance.NetworkType");
			describeInstanceResponse.VpcId = context.StringValue("DescribeInstance.VpcId");
			describeInstanceResponse.VswitchId = context.StringValue("DescribeInstance.VswitchId");
			describeInstanceResponse.MasterInstanceType = context.StringValue("DescribeInstance.MasterInstanceType");
			describeInstanceResponse.MasterNodeCount = context.IntegerValue("DescribeInstance.MasterNodeCount");
			describeInstanceResponse.MasterDiskType = context.StringValue("DescribeInstance.MasterDiskType");
			describeInstanceResponse.MasterDiskSize = context.IntegerValue("DescribeInstance.MasterDiskSize");
			describeInstanceResponse.CoreInstanceType = context.StringValue("DescribeInstance.CoreInstanceType");
			describeInstanceResponse.CoreNodeCount = context.IntegerValue("DescribeInstance.CoreNodeCount");
			describeInstanceResponse.CoreDiskType = context.StringValue("DescribeInstance.CoreDiskType");
			describeInstanceResponse.CoreDiskSize = context.IntegerValue("DescribeInstance.CoreDiskSize");
			describeInstanceResponse.RegionId = context.StringValue("DescribeInstance.RegionId");
			describeInstanceResponse.ZoneId = context.StringValue("DescribeInstance.ZoneId");
			describeInstanceResponse.ColdStorageStatus = context.StringValue("DescribeInstance.ColdStorageStatus");
			describeInstanceResponse.BackupStatus = context.StringValue("DescribeInstance.BackupStatus");
			describeInstanceResponse.CoreDiskCount = context.StringValue("DescribeInstance.CoreDiskCount");
			describeInstanceResponse.MaintainStartTime = context.StringValue("DescribeInstance.MaintainStartTime");
			describeInstanceResponse.MaintainEndTime = context.StringValue("DescribeInstance.MaintainEndTime");
			describeInstanceResponse.CreatedTimeUTC = context.StringValue("DescribeInstance.CreatedTimeUTC");
			describeInstanceResponse.ExpireTimeUTC = context.StringValue("DescribeInstance.ExpireTimeUTC");
			describeInstanceResponse.IsLatestVersion = context.BooleanValue("DescribeInstance.IsLatestVersion");
			describeInstanceResponse.IsMultiModel = context.BooleanValue("DescribeInstance.IsMultiModel");
			describeInstanceResponse.ClusterType = context.StringValue("DescribeInstance.ClusterType");
			describeInstanceResponse.ClusterId = context.StringValue("DescribeInstance.ClusterId");
			describeInstanceResponse.ClusterName = context.StringValue("DescribeInstance.ClusterName");
			describeInstanceResponse.IsDeletionProtection = context.BooleanValue("DescribeInstance.IsDeletionProtection");
			describeInstanceResponse.ParentId = context.StringValue("DescribeInstance.ParentId");
			describeInstanceResponse.ModuleId = context.IntegerValue("DescribeInstance.ModuleId");
			describeInstanceResponse.ModuleStackVersion = context.StringValue("DescribeInstance.ModuleStackVersion");

			List<DescribeInstanceResponse.DescribeInstance_Tag> describeInstanceResponse_tags = new List<DescribeInstanceResponse.DescribeInstance_Tag>();
			for (int i = 0; i < context.Length("DescribeInstance.Tags.Length"); i++) {
				DescribeInstanceResponse.DescribeInstance_Tag tag = new DescribeInstanceResponse.DescribeInstance_Tag();
				tag.Key = context.StringValue("DescribeInstance.Tags["+ i +"].Key");
				tag._Value = context.StringValue("DescribeInstance.Tags["+ i +"].Value");

				describeInstanceResponse_tags.Add(tag);
			}
			describeInstanceResponse.Tags = describeInstanceResponse_tags;
        
			return describeInstanceResponse;
        }
    }
}
