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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.EHPC.Model.V20170714;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.EHPC.Transform.V20170714
{
    public class DescribeClusterResponseUnmarshaller
    {
        public static DescribeClusterResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeClusterResponse describeClusterResponse = new DescribeClusterResponse();

			describeClusterResponse.HttpResponse = context.HttpResponse;
			describeClusterResponse.RequestId = context.StringValue("DescribeCluster.RequestId");

			DescribeClusterResponse.DescribeCluster_ClusterInfo clusterInfo = new DescribeClusterResponse.DescribeCluster_ClusterInfo();
			clusterInfo.Id = context.StringValue("DescribeCluster.ClusterInfo.Id");
			clusterInfo.RegionId = context.StringValue("DescribeCluster.ClusterInfo.RegionId");
			clusterInfo.Name = context.StringValue("DescribeCluster.ClusterInfo.Name");
			clusterInfo.Description = context.StringValue("DescribeCluster.ClusterInfo.Description");
			clusterInfo.Status = context.StringValue("DescribeCluster.ClusterInfo.Status");
			clusterInfo.OsTag = context.StringValue("DescribeCluster.ClusterInfo.OsTag");
			clusterInfo.AccountType = context.StringValue("DescribeCluster.ClusterInfo.AccountType");
			clusterInfo.SchedulerType = context.StringValue("DescribeCluster.ClusterInfo.SchedulerType");
			clusterInfo.CreateTime = context.StringValue("DescribeCluster.ClusterInfo.CreateTime");
			clusterInfo.SecurityGroupId = context.StringValue("DescribeCluster.ClusterInfo.SecurityGroupId");
			clusterInfo.VSwitchId = context.StringValue("DescribeCluster.ClusterInfo.VSwitchId");
			clusterInfo.VolumeType = context.StringValue("DescribeCluster.ClusterInfo.VolumeType");
			clusterInfo.VolumeId = context.StringValue("DescribeCluster.ClusterInfo.VolumeId");
			clusterInfo.VolumeProtocol = context.StringValue("DescribeCluster.ClusterInfo.VolumeProtocol");
			clusterInfo.VolumeMountpoint = context.StringValue("DescribeCluster.ClusterInfo.VolumeMountpoint");
			clusterInfo.RemoteDirectory = context.StringValue("DescribeCluster.ClusterInfo.RemoteDirectory");
			clusterInfo.HaEnable = context.BooleanValue("DescribeCluster.ClusterInfo.HaEnable");
			clusterInfo.EcsChargeType = context.StringValue("DescribeCluster.ClusterInfo.EcsChargeType");
			clusterInfo.KeyPairName = context.StringValue("DescribeCluster.ClusterInfo.KeyPairName");
			clusterInfo.SccClusterId = context.StringValue("DescribeCluster.ClusterInfo.SccClusterId");
			clusterInfo.ClientVersion = context.StringValue("DescribeCluster.ClusterInfo.ClientVersion");
			clusterInfo.ImageOwnerAlias = context.StringValue("DescribeCluster.ClusterInfo.ImageOwnerAlias");
			clusterInfo.ImageId = context.StringValue("DescribeCluster.ClusterInfo.ImageId");

			DescribeClusterResponse.DescribeCluster_ClusterInfo.DescribeCluster_EcsInfo ecsInfo = new DescribeClusterResponse.DescribeCluster_ClusterInfo.DescribeCluster_EcsInfo();

			DescribeClusterResponse.DescribeCluster_ClusterInfo.DescribeCluster_EcsInfo.DescribeCluster_Manager manager = new DescribeClusterResponse.DescribeCluster_ClusterInfo.DescribeCluster_EcsInfo.DescribeCluster_Manager();
			manager.Count = context.IntegerValue("DescribeCluster.ClusterInfo.EcsInfo.Manager.Count");
			manager.InstanceType = context.StringValue("DescribeCluster.ClusterInfo.EcsInfo.Manager.InstanceType");
			ecsInfo.Manager = manager;

			DescribeClusterResponse.DescribeCluster_ClusterInfo.DescribeCluster_EcsInfo.DescribeCluster_Compute compute = new DescribeClusterResponse.DescribeCluster_ClusterInfo.DescribeCluster_EcsInfo.DescribeCluster_Compute();
			compute.Count = context.IntegerValue("DescribeCluster.ClusterInfo.EcsInfo.Compute.Count");
			compute.InstanceType = context.StringValue("DescribeCluster.ClusterInfo.EcsInfo.Compute.InstanceType");
			ecsInfo.Compute = compute;

			DescribeClusterResponse.DescribeCluster_ClusterInfo.DescribeCluster_EcsInfo.DescribeCluster_Login login = new DescribeClusterResponse.DescribeCluster_ClusterInfo.DescribeCluster_EcsInfo.DescribeCluster_Login();
			login.Count = context.IntegerValue("DescribeCluster.ClusterInfo.EcsInfo.Login.Count");
			login.InstanceType = context.StringValue("DescribeCluster.ClusterInfo.EcsInfo.Login.InstanceType");
			ecsInfo.Login = login;
			clusterInfo.EcsInfo = ecsInfo;

			List<DescribeClusterResponse.DescribeCluster_ClusterInfo.DescribeCluster_ApplicationInfoItem> clusterInfo_applicationInfo = new List<DescribeClusterResponse.DescribeCluster_ClusterInfo.DescribeCluster_ApplicationInfoItem>();
			for (int i = 0; i < context.Length("DescribeCluster.ClusterInfo.ApplicationInfo.Length"); i++) {
				DescribeClusterResponse.DescribeCluster_ClusterInfo.DescribeCluster_ApplicationInfoItem applicationInfoItem = new DescribeClusterResponse.DescribeCluster_ClusterInfo.DescribeCluster_ApplicationInfoItem();
				applicationInfoItem.Tag = context.StringValue("DescribeCluster.ClusterInfo.ApplicationInfo["+ i +"].Tag");
				applicationInfoItem.Name = context.StringValue("DescribeCluster.ClusterInfo.ApplicationInfo["+ i +"].Name");
				applicationInfoItem.Version = context.StringValue("DescribeCluster.ClusterInfo.ApplicationInfo["+ i +"].Version");

				clusterInfo_applicationInfo.Add(applicationInfoItem);
			}
			clusterInfo.ApplicationInfo = clusterInfo_applicationInfo;
			describeClusterResponse.ClusterInfo = clusterInfo;
        
			return describeClusterResponse;
        }
    }
}