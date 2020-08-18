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
        public static DescribeMultiZoneClusterResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeMultiZoneClusterResponse describeMultiZoneClusterResponse = new DescribeMultiZoneClusterResponse();

			describeMultiZoneClusterResponse.HttpResponse = context.HttpResponse;
			describeMultiZoneClusterResponse.AutoRenewal = context.BooleanValue("DescribeMultiZoneCluster.AutoRenewal");
			describeMultiZoneClusterResponse.ClusterId = context.StringValue("DescribeMultiZoneCluster.ClusterId");
			describeMultiZoneClusterResponse.ClusterName = context.StringValue("DescribeMultiZoneCluster.ClusterName");
			describeMultiZoneClusterResponse.CreatedTime = context.StringValue("DescribeMultiZoneCluster.CreatedTime");
			describeMultiZoneClusterResponse.CreatedTimeUTC = context.StringValue("DescribeMultiZoneCluster.CreatedTimeUTC");
			describeMultiZoneClusterResponse.Duration = context.IntegerValue("DescribeMultiZoneCluster.Duration");
			describeMultiZoneClusterResponse.Engine = context.StringValue("DescribeMultiZoneCluster.Engine");
			describeMultiZoneClusterResponse.ExpireTime = context.StringValue("DescribeMultiZoneCluster.ExpireTime");
			describeMultiZoneClusterResponse.ExpireTimeUTC = context.StringValue("DescribeMultiZoneCluster.ExpireTimeUTC");
			describeMultiZoneClusterResponse.InstanceId = context.StringValue("DescribeMultiZoneCluster.InstanceId");
			describeMultiZoneClusterResponse.InstanceName = context.StringValue("DescribeMultiZoneCluster.InstanceName");
			describeMultiZoneClusterResponse.IsDeletionProtection = context.BooleanValue("DescribeMultiZoneCluster.IsDeletionProtection");
			describeMultiZoneClusterResponse.MaintainEndTime = context.StringValue("DescribeMultiZoneCluster.MaintainEndTime");
			describeMultiZoneClusterResponse.MaintainStartTime = context.StringValue("DescribeMultiZoneCluster.MaintainStartTime");
			describeMultiZoneClusterResponse.MajorVersion = context.StringValue("DescribeMultiZoneCluster.MajorVersion");
			describeMultiZoneClusterResponse.MasterDiskSize = context.IntegerValue("DescribeMultiZoneCluster.MasterDiskSize");
			describeMultiZoneClusterResponse.MasterDiskType = context.StringValue("DescribeMultiZoneCluster.MasterDiskType");
			describeMultiZoneClusterResponse.MasterInstanceType = context.StringValue("DescribeMultiZoneCluster.MasterInstanceType");
			describeMultiZoneClusterResponse.MasterNodeCount = context.IntegerValue("DescribeMultiZoneCluster.MasterNodeCount");
			describeMultiZoneClusterResponse.CoreDiskCount = context.StringValue("DescribeMultiZoneCluster.CoreDiskCount");
			describeMultiZoneClusterResponse.CoreDiskSize = context.IntegerValue("DescribeMultiZoneCluster.CoreDiskSize");
			describeMultiZoneClusterResponse.CoreDiskType = context.StringValue("DescribeMultiZoneCluster.CoreDiskType");
			describeMultiZoneClusterResponse.CoreInstanceType = context.StringValue("DescribeMultiZoneCluster.CoreInstanceType");
			describeMultiZoneClusterResponse.CoreNodeCount = context.IntegerValue("DescribeMultiZoneCluster.CoreNodeCount");
			describeMultiZoneClusterResponse.LogDiskCount = context.StringValue("DescribeMultiZoneCluster.LogDiskCount");
			describeMultiZoneClusterResponse.LogDiskSize = context.IntegerValue("DescribeMultiZoneCluster.LogDiskSize");
			describeMultiZoneClusterResponse.LogDiskType = context.StringValue("DescribeMultiZoneCluster.LogDiskType");
			describeMultiZoneClusterResponse.LogInstanceType = context.StringValue("DescribeMultiZoneCluster.LogInstanceType");
			describeMultiZoneClusterResponse.LogNodeCount = context.IntegerValue("DescribeMultiZoneCluster.LogNodeCount");
			describeMultiZoneClusterResponse.ModuleId = context.IntegerValue("DescribeMultiZoneCluster.ModuleId");
			describeMultiZoneClusterResponse.ModuleStackVersion = context.StringValue("DescribeMultiZoneCluster.ModuleStackVersion");
			describeMultiZoneClusterResponse.NetworkType = context.StringValue("DescribeMultiZoneCluster.NetworkType");
			describeMultiZoneClusterResponse.ParentId = context.StringValue("DescribeMultiZoneCluster.ParentId");
			describeMultiZoneClusterResponse.PayType = context.StringValue("DescribeMultiZoneCluster.PayType");
			describeMultiZoneClusterResponse.RegionId = context.StringValue("DescribeMultiZoneCluster.RegionId");
			describeMultiZoneClusterResponse.RequestId = context.StringValue("DescribeMultiZoneCluster.RequestId");
			describeMultiZoneClusterResponse.Status = context.StringValue("DescribeMultiZoneCluster.Status");
			describeMultiZoneClusterResponse.MultiZoneCombination = context.StringValue("DescribeMultiZoneCluster.MultiZoneCombination");
			describeMultiZoneClusterResponse.PrimaryZoneId = context.StringValue("DescribeMultiZoneCluster.PrimaryZoneId");
			describeMultiZoneClusterResponse.PrimaryVSwitchIds = context.StringValue("DescribeMultiZoneCluster.PrimaryVSwitchIds");
			describeMultiZoneClusterResponse.StandbyZoneId = context.StringValue("DescribeMultiZoneCluster.StandbyZoneId");
			describeMultiZoneClusterResponse.StandbyVSwitchIds = context.StringValue("DescribeMultiZoneCluster.StandbyVSwitchIds");
			describeMultiZoneClusterResponse.ArbiterZoneId = context.StringValue("DescribeMultiZoneCluster.ArbiterZoneId");
			describeMultiZoneClusterResponse.ArbiterVSwitchIds = context.StringValue("DescribeMultiZoneCluster.ArbiterVSwitchIds");
			describeMultiZoneClusterResponse.VpcId = context.StringValue("DescribeMultiZoneCluster.VpcId");

			List<DescribeMultiZoneClusterResponse.DescribeMultiZoneCluster_MultiZoneInstanceModel> describeMultiZoneClusterResponse_multiZoneInstanceModels = new List<DescribeMultiZoneClusterResponse.DescribeMultiZoneCluster_MultiZoneInstanceModel>();
			for (int i = 0; i < context.Length("DescribeMultiZoneCluster.MultiZoneInstanceModels.Length"); i++) {
				DescribeMultiZoneClusterResponse.DescribeMultiZoneCluster_MultiZoneInstanceModel multiZoneInstanceModel = new DescribeMultiZoneClusterResponse.DescribeMultiZoneCluster_MultiZoneInstanceModel();
				multiZoneInstanceModel.InsName = context.StringValue("DescribeMultiZoneCluster.MultiZoneInstanceModels["+ i +"].InsName");
				multiZoneInstanceModel.IsLatestVersion = context.BooleanValue("DescribeMultiZoneCluster.MultiZoneInstanceModels["+ i +"].IsLatestVersion");
				multiZoneInstanceModel.MinorVersion = context.StringValue("DescribeMultiZoneCluster.MultiZoneInstanceModels["+ i +"].MinorVersion");
				multiZoneInstanceModel.Status = context.StringValue("DescribeMultiZoneCluster.MultiZoneInstanceModels["+ i +"].Status");
				multiZoneInstanceModel.Role = context.StringValue("DescribeMultiZoneCluster.MultiZoneInstanceModels["+ i +"].Role");

				describeMultiZoneClusterResponse_multiZoneInstanceModels.Add(multiZoneInstanceModel);
			}
			describeMultiZoneClusterResponse.MultiZoneInstanceModels = describeMultiZoneClusterResponse_multiZoneInstanceModels;

			List<DescribeMultiZoneClusterResponse.DescribeMultiZoneCluster_Tag> describeMultiZoneClusterResponse_tags = new List<DescribeMultiZoneClusterResponse.DescribeMultiZoneCluster_Tag>();
			for (int i = 0; i < context.Length("DescribeMultiZoneCluster.Tags.Length"); i++) {
				DescribeMultiZoneClusterResponse.DescribeMultiZoneCluster_Tag tag = new DescribeMultiZoneClusterResponse.DescribeMultiZoneCluster_Tag();
				tag.Key = context.StringValue("DescribeMultiZoneCluster.Tags["+ i +"].Key");
				tag._Value = context.StringValue("DescribeMultiZoneCluster.Tags["+ i +"].Value");

				describeMultiZoneClusterResponse_tags.Add(tag);
			}
			describeMultiZoneClusterResponse.Tags = describeMultiZoneClusterResponse_tags;
        
			return describeMultiZoneClusterResponse;
        }
    }
}
