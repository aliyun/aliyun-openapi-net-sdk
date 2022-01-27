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
using Aliyun.Acs.EHPC.Model.V20180412;

namespace Aliyun.Acs.EHPC.Transform.V20180412
{
    public class DescribeClusterResponseUnmarshaller
    {
        public static DescribeClusterResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeClusterResponse describeClusterResponse = new DescribeClusterResponse();

			describeClusterResponse.HttpResponse = _ctx.HttpResponse;
			describeClusterResponse.RequestId = _ctx.StringValue("DescribeCluster.RequestId");

			DescribeClusterResponse.DescribeCluster_ClusterInfo clusterInfo = new DescribeClusterResponse.DescribeCluster_ClusterInfo();
			clusterInfo.Id = _ctx.StringValue("DescribeCluster.ClusterInfo.Id");
			clusterInfo.RegionId = _ctx.StringValue("DescribeCluster.ClusterInfo.RegionId");
			clusterInfo.Name = _ctx.StringValue("DescribeCluster.ClusterInfo.Name");
			clusterInfo.Description = _ctx.StringValue("DescribeCluster.ClusterInfo.Description");
			clusterInfo.Status = _ctx.StringValue("DescribeCluster.ClusterInfo.Status");
			clusterInfo.OsTag = _ctx.StringValue("DescribeCluster.ClusterInfo.OsTag");
			clusterInfo.AccountType = _ctx.StringValue("DescribeCluster.ClusterInfo.AccountType");
			clusterInfo.SchedulerType = _ctx.StringValue("DescribeCluster.ClusterInfo.SchedulerType");
			clusterInfo.CreateTime = _ctx.StringValue("DescribeCluster.ClusterInfo.CreateTime");
			clusterInfo.SecurityGroupId = _ctx.StringValue("DescribeCluster.ClusterInfo.SecurityGroupId");
			clusterInfo.VpcId = _ctx.StringValue("DescribeCluster.ClusterInfo.VpcId");
			clusterInfo.VSwitchId = _ctx.StringValue("DescribeCluster.ClusterInfo.VSwitchId");
			clusterInfo.VolumeType = _ctx.StringValue("DescribeCluster.ClusterInfo.VolumeType");
			clusterInfo.VolumeId = _ctx.StringValue("DescribeCluster.ClusterInfo.VolumeId");
			clusterInfo.VolumeProtocol = _ctx.StringValue("DescribeCluster.ClusterInfo.VolumeProtocol");
			clusterInfo.VolumeMountpoint = _ctx.StringValue("DescribeCluster.ClusterInfo.VolumeMountpoint");
			clusterInfo.RemoteDirectory = _ctx.StringValue("DescribeCluster.ClusterInfo.RemoteDirectory");
			clusterInfo.DeployMode = _ctx.StringValue("DescribeCluster.ClusterInfo.DeployMode");
			clusterInfo.HaEnable = _ctx.BooleanValue("DescribeCluster.ClusterInfo.HaEnable");
			clusterInfo.EcsChargeType = _ctx.StringValue("DescribeCluster.ClusterInfo.EcsChargeType");
			clusterInfo.KeyPairName = _ctx.StringValue("DescribeCluster.ClusterInfo.KeyPairName");
			clusterInfo.SccClusterId = _ctx.StringValue("DescribeCluster.ClusterInfo.SccClusterId");
			clusterInfo.ClientVersion = _ctx.StringValue("DescribeCluster.ClusterInfo.ClientVersion");
			clusterInfo.ImageOwnerAlias = _ctx.StringValue("DescribeCluster.ClusterInfo.ImageOwnerAlias");
			clusterInfo.ImageId = _ctx.StringValue("DescribeCluster.ClusterInfo.ImageId");
			clusterInfo.Location = _ctx.StringValue("DescribeCluster.ClusterInfo.Location");
			clusterInfo.BaseOsTag = _ctx.StringValue("DescribeCluster.ClusterInfo.BaseOsTag");
			clusterInfo.ImageName = _ctx.StringValue("DescribeCluster.ClusterInfo.ImageName");

			DescribeClusterResponse.DescribeCluster_ClusterInfo.DescribeCluster_EcsInfo ecsInfo = new DescribeClusterResponse.DescribeCluster_ClusterInfo.DescribeCluster_EcsInfo();

			DescribeClusterResponse.DescribeCluster_ClusterInfo.DescribeCluster_EcsInfo.DescribeCluster_Manager manager = new DescribeClusterResponse.DescribeCluster_ClusterInfo.DescribeCluster_EcsInfo.DescribeCluster_Manager();
			manager.Count = _ctx.IntegerValue("DescribeCluster.ClusterInfo.EcsInfo.Manager.Count");
			manager.InstanceType = _ctx.StringValue("DescribeCluster.ClusterInfo.EcsInfo.Manager.InstanceType");
			ecsInfo.Manager = manager;

			DescribeClusterResponse.DescribeCluster_ClusterInfo.DescribeCluster_EcsInfo.DescribeCluster_Compute compute = new DescribeClusterResponse.DescribeCluster_ClusterInfo.DescribeCluster_EcsInfo.DescribeCluster_Compute();
			compute.Count = _ctx.IntegerValue("DescribeCluster.ClusterInfo.EcsInfo.Compute.Count");
			compute.InstanceType = _ctx.StringValue("DescribeCluster.ClusterInfo.EcsInfo.Compute.InstanceType");
			ecsInfo.Compute = compute;

			DescribeClusterResponse.DescribeCluster_ClusterInfo.DescribeCluster_EcsInfo.DescribeCluster_Login login = new DescribeClusterResponse.DescribeCluster_ClusterInfo.DescribeCluster_EcsInfo.DescribeCluster_Login();
			login.Count = _ctx.IntegerValue("DescribeCluster.ClusterInfo.EcsInfo.Login.Count");
			login.InstanceType = _ctx.StringValue("DescribeCluster.ClusterInfo.EcsInfo.Login.InstanceType");
			ecsInfo.Login = login;
			clusterInfo.EcsInfo = ecsInfo;

			List<DescribeClusterResponse.DescribeCluster_ClusterInfo.DescribeCluster_ApplicationInfo> clusterInfo_applications = new List<DescribeClusterResponse.DescribeCluster_ClusterInfo.DescribeCluster_ApplicationInfo>();
			for (int i = 0; i < _ctx.Length("DescribeCluster.ClusterInfo.Applications.Length"); i++) {
				DescribeClusterResponse.DescribeCluster_ClusterInfo.DescribeCluster_ApplicationInfo applicationInfo = new DescribeClusterResponse.DescribeCluster_ClusterInfo.DescribeCluster_ApplicationInfo();
				applicationInfo.Tag = _ctx.StringValue("DescribeCluster.ClusterInfo.Applications["+ i +"].Tag");
				applicationInfo.Name = _ctx.StringValue("DescribeCluster.ClusterInfo.Applications["+ i +"].Name");
				applicationInfo.Version = _ctx.StringValue("DescribeCluster.ClusterInfo.Applications["+ i +"].Version");

				clusterInfo_applications.Add(applicationInfo);
			}
			clusterInfo.Applications = clusterInfo_applications;

			List<DescribeClusterResponse.DescribeCluster_ClusterInfo.DescribeCluster_PostInstallScriptInfo> clusterInfo_postInstallScripts = new List<DescribeClusterResponse.DescribeCluster_ClusterInfo.DescribeCluster_PostInstallScriptInfo>();
			for (int i = 0; i < _ctx.Length("DescribeCluster.ClusterInfo.PostInstallScripts.Length"); i++) {
				DescribeClusterResponse.DescribeCluster_ClusterInfo.DescribeCluster_PostInstallScriptInfo postInstallScriptInfo = new DescribeClusterResponse.DescribeCluster_ClusterInfo.DescribeCluster_PostInstallScriptInfo();
				postInstallScriptInfo.Url = _ctx.StringValue("DescribeCluster.ClusterInfo.PostInstallScripts["+ i +"].Url");
				postInstallScriptInfo.Args = _ctx.StringValue("DescribeCluster.ClusterInfo.PostInstallScripts["+ i +"].Args");

				clusterInfo_postInstallScripts.Add(postInstallScriptInfo);
			}
			clusterInfo.PostInstallScripts = clusterInfo_postInstallScripts;
			describeClusterResponse.ClusterInfo = clusterInfo;
        
			return describeClusterResponse;
        }
    }
}
