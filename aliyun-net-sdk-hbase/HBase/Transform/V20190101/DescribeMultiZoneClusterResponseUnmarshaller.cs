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
    public class DescribeMultiZoneClusterResponseUnmarshaller
    {
        public static DescribeMultiZoneClusterResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeMultiZoneClusterResponse describeMultiZoneClusterResponse = new DescribeMultiZoneClusterResponse();

			describeMultiZoneClusterResponse.HttpResponse = _ctx.HttpResponse;
			describeMultiZoneClusterResponse.AutoRenewal = _ctx.BooleanValue("DescribeMultiZoneCluster.AutoRenewal");
			describeMultiZoneClusterResponse.ClusterId = _ctx.StringValue("DescribeMultiZoneCluster.ClusterId");
			describeMultiZoneClusterResponse.ClusterName = _ctx.StringValue("DescribeMultiZoneCluster.ClusterName");
			describeMultiZoneClusterResponse.CreatedTime = _ctx.StringValue("DescribeMultiZoneCluster.CreatedTime");
			describeMultiZoneClusterResponse.CreatedTimeUTC = _ctx.StringValue("DescribeMultiZoneCluster.CreatedTimeUTC");
			describeMultiZoneClusterResponse.Duration = _ctx.IntegerValue("DescribeMultiZoneCluster.Duration");
			describeMultiZoneClusterResponse.Engine = _ctx.StringValue("DescribeMultiZoneCluster.Engine");
			describeMultiZoneClusterResponse.ExpireTime = _ctx.StringValue("DescribeMultiZoneCluster.ExpireTime");
			describeMultiZoneClusterResponse.ExpireTimeUTC = _ctx.StringValue("DescribeMultiZoneCluster.ExpireTimeUTC");
			describeMultiZoneClusterResponse.InstanceId = _ctx.StringValue("DescribeMultiZoneCluster.InstanceId");
			describeMultiZoneClusterResponse.InstanceName = _ctx.StringValue("DescribeMultiZoneCluster.InstanceName");
			describeMultiZoneClusterResponse.IsDeletionProtection = _ctx.BooleanValue("DescribeMultiZoneCluster.IsDeletionProtection");
			describeMultiZoneClusterResponse.MaintainEndTime = _ctx.StringValue("DescribeMultiZoneCluster.MaintainEndTime");
			describeMultiZoneClusterResponse.MaintainStartTime = _ctx.StringValue("DescribeMultiZoneCluster.MaintainStartTime");
			describeMultiZoneClusterResponse.MajorVersion = _ctx.StringValue("DescribeMultiZoneCluster.MajorVersion");
			describeMultiZoneClusterResponse.MasterDiskSize = _ctx.IntegerValue("DescribeMultiZoneCluster.MasterDiskSize");
			describeMultiZoneClusterResponse.MasterDiskType = _ctx.StringValue("DescribeMultiZoneCluster.MasterDiskType");
			describeMultiZoneClusterResponse.MasterInstanceType = _ctx.StringValue("DescribeMultiZoneCluster.MasterInstanceType");
			describeMultiZoneClusterResponse.MasterNodeCount = _ctx.IntegerValue("DescribeMultiZoneCluster.MasterNodeCount");
			describeMultiZoneClusterResponse.CoreDiskCount = _ctx.StringValue("DescribeMultiZoneCluster.CoreDiskCount");
			describeMultiZoneClusterResponse.CoreDiskSize = _ctx.IntegerValue("DescribeMultiZoneCluster.CoreDiskSize");
			describeMultiZoneClusterResponse.CoreDiskType = _ctx.StringValue("DescribeMultiZoneCluster.CoreDiskType");
			describeMultiZoneClusterResponse.CoreInstanceType = _ctx.StringValue("DescribeMultiZoneCluster.CoreInstanceType");
			describeMultiZoneClusterResponse.CoreNodeCount = _ctx.IntegerValue("DescribeMultiZoneCluster.CoreNodeCount");
			describeMultiZoneClusterResponse.LogDiskCount = _ctx.StringValue("DescribeMultiZoneCluster.LogDiskCount");
			describeMultiZoneClusterResponse.LogDiskSize = _ctx.IntegerValue("DescribeMultiZoneCluster.LogDiskSize");
			describeMultiZoneClusterResponse.LogDiskType = _ctx.StringValue("DescribeMultiZoneCluster.LogDiskType");
			describeMultiZoneClusterResponse.LogInstanceType = _ctx.StringValue("DescribeMultiZoneCluster.LogInstanceType");
			describeMultiZoneClusterResponse.LogNodeCount = _ctx.IntegerValue("DescribeMultiZoneCluster.LogNodeCount");
			describeMultiZoneClusterResponse.ModuleId = _ctx.IntegerValue("DescribeMultiZoneCluster.ModuleId");
			describeMultiZoneClusterResponse.ModuleStackVersion = _ctx.StringValue("DescribeMultiZoneCluster.ModuleStackVersion");
			describeMultiZoneClusterResponse.NetworkType = _ctx.StringValue("DescribeMultiZoneCluster.NetworkType");
			describeMultiZoneClusterResponse.ParentId = _ctx.StringValue("DescribeMultiZoneCluster.ParentId");
			describeMultiZoneClusterResponse.PayType = _ctx.StringValue("DescribeMultiZoneCluster.PayType");
			describeMultiZoneClusterResponse.RegionId = _ctx.StringValue("DescribeMultiZoneCluster.RegionId");
			describeMultiZoneClusterResponse.RequestId = _ctx.StringValue("DescribeMultiZoneCluster.RequestId");
			describeMultiZoneClusterResponse.Status = _ctx.StringValue("DescribeMultiZoneCluster.Status");
			describeMultiZoneClusterResponse.MultiZoneCombination = _ctx.StringValue("DescribeMultiZoneCluster.MultiZoneCombination");
			describeMultiZoneClusterResponse.PrimaryZoneId = _ctx.StringValue("DescribeMultiZoneCluster.PrimaryZoneId");
			describeMultiZoneClusterResponse.PrimaryVSwitchIds = _ctx.StringValue("DescribeMultiZoneCluster.PrimaryVSwitchIds");
			describeMultiZoneClusterResponse.StandbyZoneId = _ctx.StringValue("DescribeMultiZoneCluster.StandbyZoneId");
			describeMultiZoneClusterResponse.StandbyVSwitchIds = _ctx.StringValue("DescribeMultiZoneCluster.StandbyVSwitchIds");
			describeMultiZoneClusterResponse.ArbiterZoneId = _ctx.StringValue("DescribeMultiZoneCluster.ArbiterZoneId");
			describeMultiZoneClusterResponse.ArbiterVSwitchIds = _ctx.StringValue("DescribeMultiZoneCluster.ArbiterVSwitchIds");
			describeMultiZoneClusterResponse.VpcId = _ctx.StringValue("DescribeMultiZoneCluster.VpcId");
			describeMultiZoneClusterResponse.ResourceGroupId = _ctx.StringValue("DescribeMultiZoneCluster.ResourceGroupId");
			describeMultiZoneClusterResponse.EncryptionType = _ctx.BooleanValue("DescribeMultiZoneCluster.EncryptionType");
			describeMultiZoneClusterResponse.EncryptionKey = _ctx.StringValue("DescribeMultiZoneCluster.EncryptionKey");

			List<DescribeMultiZoneClusterResponse.DescribeMultiZoneCluster_MultiZoneInstanceModel> describeMultiZoneClusterResponse_multiZoneInstanceModels = new List<DescribeMultiZoneClusterResponse.DescribeMultiZoneCluster_MultiZoneInstanceModel>();
			for (int i = 0; i < _ctx.Length("DescribeMultiZoneCluster.MultiZoneInstanceModels.Length"); i++) {
				DescribeMultiZoneClusterResponse.DescribeMultiZoneCluster_MultiZoneInstanceModel multiZoneInstanceModel = new DescribeMultiZoneClusterResponse.DescribeMultiZoneCluster_MultiZoneInstanceModel();
				multiZoneInstanceModel.InsName = _ctx.StringValue("DescribeMultiZoneCluster.MultiZoneInstanceModels["+ i +"].InsName");
				multiZoneInstanceModel.IsLatestVersion = _ctx.BooleanValue("DescribeMultiZoneCluster.MultiZoneInstanceModels["+ i +"].IsLatestVersion");
				multiZoneInstanceModel.MinorVersion = _ctx.StringValue("DescribeMultiZoneCluster.MultiZoneInstanceModels["+ i +"].MinorVersion");
				multiZoneInstanceModel.Status = _ctx.StringValue("DescribeMultiZoneCluster.MultiZoneInstanceModels["+ i +"].Status");
				multiZoneInstanceModel.Role = _ctx.StringValue("DescribeMultiZoneCluster.MultiZoneInstanceModels["+ i +"].Role");

				describeMultiZoneClusterResponse_multiZoneInstanceModels.Add(multiZoneInstanceModel);
			}
			describeMultiZoneClusterResponse.MultiZoneInstanceModels = describeMultiZoneClusterResponse_multiZoneInstanceModels;

			List<DescribeMultiZoneClusterResponse.DescribeMultiZoneCluster_Tag> describeMultiZoneClusterResponse_tags = new List<DescribeMultiZoneClusterResponse.DescribeMultiZoneCluster_Tag>();
			for (int i = 0; i < _ctx.Length("DescribeMultiZoneCluster.Tags.Length"); i++) {
				DescribeMultiZoneClusterResponse.DescribeMultiZoneCluster_Tag tag = new DescribeMultiZoneClusterResponse.DescribeMultiZoneCluster_Tag();
				tag.Key = _ctx.StringValue("DescribeMultiZoneCluster.Tags["+ i +"].Key");
				tag._Value = _ctx.StringValue("DescribeMultiZoneCluster.Tags["+ i +"].Value");

				describeMultiZoneClusterResponse_tags.Add(tag);
			}
			describeMultiZoneClusterResponse.Tags = describeMultiZoneClusterResponse_tags;
        
			return describeMultiZoneClusterResponse;
        }
    }
}
