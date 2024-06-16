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
using Aliyun.Acs.polardb.Model.V20170801;

namespace Aliyun.Acs.polardb.Transform.V20170801
{
    public class DescribeDBClusterAttributeResponseUnmarshaller
    {
        public static DescribeDBClusterAttributeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDBClusterAttributeResponse describeDBClusterAttributeResponse = new DescribeDBClusterAttributeResponse();

			describeDBClusterAttributeResponse.HttpResponse = _ctx.HttpResponse;
			describeDBClusterAttributeResponse.DeletionLock = _ctx.IntegerValue("DescribeDBClusterAttribute.DeletionLock");
			describeDBClusterAttributeResponse.Category = _ctx.StringValue("DescribeDBClusterAttribute.Category");
			describeDBClusterAttributeResponse.ResourceGroupId = _ctx.StringValue("DescribeDBClusterAttribute.ResourceGroupId");
			describeDBClusterAttributeResponse.DataLevel1BackupChainSize = _ctx.LongValue("DescribeDBClusterAttribute.DataLevel1BackupChainSize");
			describeDBClusterAttributeResponse.DBClusterId = _ctx.StringValue("DescribeDBClusterAttribute.DBClusterId");
			describeDBClusterAttributeResponse.DBType = _ctx.StringValue("DescribeDBClusterAttribute.DBType");
			describeDBClusterAttributeResponse.DBClusterNetworkType = _ctx.StringValue("DescribeDBClusterAttribute.DBClusterNetworkType");
			describeDBClusterAttributeResponse.IsLatestVersion = _ctx.BooleanValue("DescribeDBClusterAttribute.IsLatestVersion");
			describeDBClusterAttributeResponse.HasCompleteStandbyRes = _ctx.BooleanValue("DescribeDBClusterAttribute.HasCompleteStandbyRes");
			describeDBClusterAttributeResponse.HotStandbyClusterStatus = _ctx.StringValue("DescribeDBClusterAttribute.HotStandbyClusterStatus");
			describeDBClusterAttributeResponse.HotStandbyCluster = _ctx.StringValue("DescribeDBClusterAttribute.HotStandbyCluster");
			describeDBClusterAttributeResponse.DataSyncMode = _ctx.StringValue("DescribeDBClusterAttribute.DataSyncMode");
			describeDBClusterAttributeResponse.StandbyHAMode = _ctx.StringValue("DescribeDBClusterAttribute.StandbyHAMode");
			describeDBClusterAttributeResponse.CompressStorageMode = _ctx.StringValue("DescribeDBClusterAttribute.CompressStorageMode");
			describeDBClusterAttributeResponse.StorageMax = _ctx.LongValue("DescribeDBClusterAttribute.StorageMax");
			describeDBClusterAttributeResponse.DBVersion = _ctx.StringValue("DescribeDBClusterAttribute.DBVersion");
			describeDBClusterAttributeResponse.ZoneIds = _ctx.StringValue("DescribeDBClusterAttribute.ZoneIds");
			describeDBClusterAttributeResponse.MaintainTime = _ctx.StringValue("DescribeDBClusterAttribute.MaintainTime");
			describeDBClusterAttributeResponse.Engine = _ctx.StringValue("DescribeDBClusterAttribute.Engine");
			describeDBClusterAttributeResponse.RequestId = _ctx.StringValue("DescribeDBClusterAttribute.RequestId");
			describeDBClusterAttributeResponse.VPCId = _ctx.StringValue("DescribeDBClusterAttribute.VPCId");
			describeDBClusterAttributeResponse.DBClusterStatus = _ctx.StringValue("DescribeDBClusterAttribute.DBClusterStatus");
			describeDBClusterAttributeResponse.VSwitchId = _ctx.StringValue("DescribeDBClusterAttribute.VSwitchId");
			describeDBClusterAttributeResponse.DBClusterDescription = _ctx.StringValue("DescribeDBClusterAttribute.DBClusterDescription");
			describeDBClusterAttributeResponse.Expired = _ctx.StringValue("DescribeDBClusterAttribute.Expired");
			describeDBClusterAttributeResponse.PayType = _ctx.StringValue("DescribeDBClusterAttribute.PayType");
			describeDBClusterAttributeResponse.StoragePayType = _ctx.StringValue("DescribeDBClusterAttribute.StoragePayType");
			describeDBClusterAttributeResponse.LockMode = _ctx.StringValue("DescribeDBClusterAttribute.LockMode");
			describeDBClusterAttributeResponse.StorageUsed = _ctx.LongValue("DescribeDBClusterAttribute.StorageUsed");
			describeDBClusterAttributeResponse.CompressStorageUsed = _ctx.LongValue("DescribeDBClusterAttribute.CompressStorageUsed");
			describeDBClusterAttributeResponse.StorageSpace = _ctx.LongValue("DescribeDBClusterAttribute.StorageSpace");
			describeDBClusterAttributeResponse.DBVersionStatus = _ctx.StringValue("DescribeDBClusterAttribute.DBVersionStatus");
			describeDBClusterAttributeResponse.CreationTime = _ctx.StringValue("DescribeDBClusterAttribute.CreationTime");
			describeDBClusterAttributeResponse.SQLSize = _ctx.LongValue("DescribeDBClusterAttribute.SQLSize");
			describeDBClusterAttributeResponse.InodeTotal = _ctx.LongValue("DescribeDBClusterAttribute.InodeTotal");
			describeDBClusterAttributeResponse.InodeUsed = _ctx.LongValue("DescribeDBClusterAttribute.InodeUsed");
			describeDBClusterAttributeResponse.BlktagTotal = _ctx.LongValue("DescribeDBClusterAttribute.BlktagTotal");
			describeDBClusterAttributeResponse.BlktagUsed = _ctx.LongValue("DescribeDBClusterAttribute.BlktagUsed");
			describeDBClusterAttributeResponse.RegionId = _ctx.StringValue("DescribeDBClusterAttribute.RegionId");
			describeDBClusterAttributeResponse.ExpireTime = _ctx.StringValue("DescribeDBClusterAttribute.ExpireTime");
			describeDBClusterAttributeResponse.SubCategory = _ctx.StringValue("DescribeDBClusterAttribute.SubCategory");
			describeDBClusterAttributeResponse.DeployUnit = _ctx.StringValue("DescribeDBClusterAttribute.DeployUnit");
			describeDBClusterAttributeResponse.IsProxyLatestVersion = _ctx.BooleanValue("DescribeDBClusterAttribute.IsProxyLatestVersion");
			describeDBClusterAttributeResponse.StorageType = _ctx.StringValue("DescribeDBClusterAttribute.StorageType");
			describeDBClusterAttributeResponse.ServerlessType = _ctx.StringValue("DescribeDBClusterAttribute.ServerlessType");
			describeDBClusterAttributeResponse.StrictConsistency = _ctx.StringValue("DescribeDBClusterAttribute.StrictConsistency");
			describeDBClusterAttributeResponse.ProxyCpuCores = _ctx.StringValue("DescribeDBClusterAttribute.ProxyCpuCores");
			describeDBClusterAttributeResponse.ProxyStandardCpuCores = _ctx.StringValue("DescribeDBClusterAttribute.ProxyStandardCpuCores");
			describeDBClusterAttributeResponse.ProxyType = _ctx.StringValue("DescribeDBClusterAttribute.ProxyType");
			describeDBClusterAttributeResponse.ProxyStatus = _ctx.StringValue("DescribeDBClusterAttribute.ProxyStatus");
			describeDBClusterAttributeResponse.FeatureHTAPSupported = _ctx.StringValue("DescribeDBClusterAttribute.FeatureHTAPSupported");
			describeDBClusterAttributeResponse.ProxyServerlessType = _ctx.StringValue("DescribeDBClusterAttribute.ProxyServerlessType");
			describeDBClusterAttributeResponse.Architecture = _ctx.StringValue("DescribeDBClusterAttribute.Architecture");
			describeDBClusterAttributeResponse.AiType = _ctx.StringValue("DescribeDBClusterAttribute.AiType");
			describeDBClusterAttributeResponse.ProvisionedIops = _ctx.StringValue("DescribeDBClusterAttribute.ProvisionedIops");
			describeDBClusterAttributeResponse.HotStandbyHealthy = _ctx.BooleanValue("DescribeDBClusterAttribute.HotStandbyHealthy");
			describeDBClusterAttributeResponse.HotStandbyWhiteListSwitch = _ctx.BooleanValue("DescribeDBClusterAttribute.HotStandbyWhiteListSwitch");
			describeDBClusterAttributeResponse.StorageTypeWhiteListSwitch = _ctx.BooleanValue("DescribeDBClusterAttribute.StorageTypeWhiteListSwitch");
			describeDBClusterAttributeResponse.AiFreeMode = _ctx.StringValue("DescribeDBClusterAttribute.AiFreeMode");
			describeDBClusterAttributeResponse.AiCreatingTime = _ctx.StringValue("DescribeDBClusterAttribute.AiCreatingTime");
			describeDBClusterAttributeResponse.SupportInstantSwitchWithImci = _ctx.StringValue("DescribeDBClusterAttribute.SupportInstantSwitchWithImci");

			DescribeDBClusterAttributeResponse.DescribeDBClusterAttribute_RelatedAPInstance relatedAPInstance = new DescribeDBClusterAttributeResponse.DescribeDBClusterAttribute_RelatedAPInstance();
			relatedAPInstance.Name = _ctx.StringValue("DescribeDBClusterAttribute.RelatedAPInstance.Name");
			relatedAPInstance.ClassCode = _ctx.StringValue("DescribeDBClusterAttribute.RelatedAPInstance.ClassCode");
			relatedAPInstance.OssStorageUsed = _ctx.StringValue("DescribeDBClusterAttribute.RelatedAPInstance.OssStorageUsed");
			relatedAPInstance.TotalAPNodes = _ctx.StringValue("DescribeDBClusterAttribute.RelatedAPInstance.TotalAPNodes");
			relatedAPInstance.StorageUsedMB = _ctx.FloatValue("DescribeDBClusterAttribute.RelatedAPInstance.StorageUsedMB");
			relatedAPInstance.APNodeStatus = _ctx.StringValue("DescribeDBClusterAttribute.RelatedAPInstance.APNodeStatus");
			describeDBClusterAttributeResponse.RelatedAPInstance = relatedAPInstance;

			List<DescribeDBClusterAttributeResponse.DescribeDBClusterAttribute_DBNode> describeDBClusterAttributeResponse_dBNodes = new List<DescribeDBClusterAttributeResponse.DescribeDBClusterAttribute_DBNode>();
			for (int i = 0; i < _ctx.Length("DescribeDBClusterAttribute.DBNodes.Length"); i++) {
				DescribeDBClusterAttributeResponse.DescribeDBClusterAttribute_DBNode dBNode = new DescribeDBClusterAttributeResponse.DescribeDBClusterAttribute_DBNode();
				dBNode.CreationTime = _ctx.StringValue("DescribeDBClusterAttribute.DBNodes["+ i +"].CreationTime");
				dBNode.FailoverPriority = _ctx.IntegerValue("DescribeDBClusterAttribute.DBNodes["+ i +"].FailoverPriority");
				dBNode.MaxIOPS = _ctx.IntegerValue("DescribeDBClusterAttribute.DBNodes["+ i +"].MaxIOPS");
				dBNode.DBNodeClass = _ctx.StringValue("DescribeDBClusterAttribute.DBNodes["+ i +"].DBNodeClass");
				dBNode.CpuCores = _ctx.StringValue("DescribeDBClusterAttribute.DBNodes["+ i +"].CpuCores");
				dBNode.MemorySize = _ctx.StringValue("DescribeDBClusterAttribute.DBNodes["+ i +"].MemorySize");
				dBNode.DBNodeRole = _ctx.StringValue("DescribeDBClusterAttribute.DBNodes["+ i +"].DBNodeRole");
				dBNode.ZoneId = _ctx.StringValue("DescribeDBClusterAttribute.DBNodes["+ i +"].ZoneId");
				dBNode.MaxConnections = _ctx.IntegerValue("DescribeDBClusterAttribute.DBNodes["+ i +"].MaxConnections");
				dBNode.DBNodeStatus = _ctx.StringValue("DescribeDBClusterAttribute.DBNodes["+ i +"].DBNodeStatus");
				dBNode.DBNodeId = _ctx.StringValue("DescribeDBClusterAttribute.DBNodes["+ i +"].DBNodeId");
				dBNode.ImciSwitch = _ctx.StringValue("DescribeDBClusterAttribute.DBNodes["+ i +"].ImciSwitch");
				dBNode.HotReplicaMode = _ctx.StringValue("DescribeDBClusterAttribute.DBNodes["+ i +"].HotReplicaMode");
				dBNode.AddedCpuCores = _ctx.StringValue("DescribeDBClusterAttribute.DBNodes["+ i +"].AddedCpuCores");
				dBNode.MasterId = _ctx.StringValue("DescribeDBClusterAttribute.DBNodes["+ i +"].MasterId");
				dBNode.SccMode = _ctx.StringValue("DescribeDBClusterAttribute.DBNodes["+ i +"].SccMode");
				dBNode.ServerWeight = _ctx.StringValue("DescribeDBClusterAttribute.DBNodes["+ i +"].ServerWeight");
				dBNode.ServerlessType = _ctx.StringValue("DescribeDBClusterAttribute.DBNodes["+ i +"].ServerlessType");
				dBNode.SubCluster = _ctx.StringValue("DescribeDBClusterAttribute.DBNodes["+ i +"].SubCluster");
				dBNode.Tair = _ctx.StringValue("DescribeDBClusterAttribute.DBNodes["+ i +"].Tair");
				dBNode.RemoteMemorySize = _ctx.StringValue("DescribeDBClusterAttribute.DBNodes["+ i +"].RemoteMemorySize");

				describeDBClusterAttributeResponse_dBNodes.Add(dBNode);
			}
			describeDBClusterAttributeResponse.DBNodes = describeDBClusterAttributeResponse_dBNodes;

			List<DescribeDBClusterAttributeResponse.DescribeDBClusterAttribute_Tag> describeDBClusterAttributeResponse_tags = new List<DescribeDBClusterAttributeResponse.DescribeDBClusterAttribute_Tag>();
			for (int i = 0; i < _ctx.Length("DescribeDBClusterAttribute.Tags.Length"); i++) {
				DescribeDBClusterAttributeResponse.DescribeDBClusterAttribute_Tag tag = new DescribeDBClusterAttributeResponse.DescribeDBClusterAttribute_Tag();
				tag.Key = _ctx.StringValue("DescribeDBClusterAttribute.Tags["+ i +"].Key");
				tag._Value = _ctx.StringValue("DescribeDBClusterAttribute.Tags["+ i +"].Value");

				describeDBClusterAttributeResponse_tags.Add(tag);
			}
			describeDBClusterAttributeResponse.Tags = describeDBClusterAttributeResponse_tags;
        
			return describeDBClusterAttributeResponse;
        }
    }
}
