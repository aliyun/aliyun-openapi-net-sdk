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
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class DescribeExecutionPlanResponseUnmarshaller
    {
        public static DescribeExecutionPlanResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeExecutionPlanResponse describeExecutionPlanResponse = new DescribeExecutionPlanResponse();

			describeExecutionPlanResponse.HttpResponse = _ctx.HttpResponse;
			describeExecutionPlanResponse.RequestId = _ctx.StringValue("DescribeExecutionPlan.RequestId");
			describeExecutionPlanResponse.Id = _ctx.StringValue("DescribeExecutionPlan.Id");
			describeExecutionPlanResponse.Name = _ctx.StringValue("DescribeExecutionPlan.Name");
			describeExecutionPlanResponse.Status = _ctx.StringValue("DescribeExecutionPlan.Status");
			describeExecutionPlanResponse.Strategy = _ctx.StringValue("DescribeExecutionPlan.Strategy");
			describeExecutionPlanResponse.TimeInterval = _ctx.IntegerValue("DescribeExecutionPlan.TimeInterval");
			describeExecutionPlanResponse.StartTime = _ctx.LongValue("DescribeExecutionPlan.StartTime");
			describeExecutionPlanResponse.TimeUnit = _ctx.StringValue("DescribeExecutionPlan.TimeUnit");
			describeExecutionPlanResponse.DayOfWeek = _ctx.StringValue("DescribeExecutionPlan.DayOfWeek");
			describeExecutionPlanResponse.DayOfMonth = _ctx.StringValue("DescribeExecutionPlan.DayOfMonth");
			describeExecutionPlanResponse.CreateClusterOnDemand = _ctx.BooleanValue("DescribeExecutionPlan.CreateClusterOnDemand");
			describeExecutionPlanResponse.ClusterId = _ctx.StringValue("DescribeExecutionPlan.ClusterId");
			describeExecutionPlanResponse.ClusterName = _ctx.StringValue("DescribeExecutionPlan.ClusterName");
			describeExecutionPlanResponse.WorkflowApp = _ctx.StringValue("DescribeExecutionPlan.WorkflowApp");
			describeExecutionPlanResponse.ExecutionPlanVersion = _ctx.LongValue("DescribeExecutionPlan.ExecutionPlanVersion");

			DescribeExecutionPlanResponse.DescribeExecutionPlan_ClusterInfo clusterInfo = new DescribeExecutionPlanResponse.DescribeExecutionPlan_ClusterInfo();
			clusterInfo.Name = _ctx.StringValue("DescribeExecutionPlan.ClusterInfo.Name");
			clusterInfo.ZoneId = _ctx.StringValue("DescribeExecutionPlan.ClusterInfo.ZoneId");
			clusterInfo.LogEnable = _ctx.BooleanValue("DescribeExecutionPlan.ClusterInfo.LogEnable");
			clusterInfo.LogPath = _ctx.StringValue("DescribeExecutionPlan.ClusterInfo.LogPath");
			clusterInfo.SecurityGroupId = _ctx.StringValue("DescribeExecutionPlan.ClusterInfo.SecurityGroupId");
			clusterInfo.EmrVer = _ctx.StringValue("DescribeExecutionPlan.ClusterInfo.EmrVer");
			clusterInfo.ClusterType = _ctx.StringValue("DescribeExecutionPlan.ClusterInfo.ClusterType");
			clusterInfo.HighAvailabilityEnable = _ctx.BooleanValue("DescribeExecutionPlan.ClusterInfo.HighAvailabilityEnable");
			clusterInfo.VpcId = _ctx.StringValue("DescribeExecutionPlan.ClusterInfo.VpcId");
			clusterInfo.VSwitchId = _ctx.StringValue("DescribeExecutionPlan.ClusterInfo.VSwitchId");
			clusterInfo.NetType = _ctx.StringValue("DescribeExecutionPlan.ClusterInfo.NetType");
			clusterInfo.IoOptimized = _ctx.BooleanValue("DescribeExecutionPlan.ClusterInfo.IoOptimized");
			clusterInfo.InstanceGeneration = _ctx.StringValue("DescribeExecutionPlan.ClusterInfo.InstanceGeneration");
			clusterInfo.Configurations = _ctx.StringValue("DescribeExecutionPlan.ClusterInfo.Configurations");
			clusterInfo.EasEnable = _ctx.BooleanValue("DescribeExecutionPlan.ClusterInfo.EasEnable");
			clusterInfo.UseCustomHiveMetaDB = _ctx.BooleanValue("DescribeExecutionPlan.ClusterInfo.UseCustomHiveMetaDB");
			clusterInfo.InitCustomHiveMetaDB = _ctx.BooleanValue("DescribeExecutionPlan.ClusterInfo.InitCustomHiveMetaDB");
			clusterInfo.UserDefinedEmrEcsRole = _ctx.StringValue("DescribeExecutionPlan.ClusterInfo.UserDefinedEmrEcsRole");
			clusterInfo.UseLocalMetaDb = _ctx.BooleanValue("DescribeExecutionPlan.ClusterInfo.UseLocalMetaDb");

			DescribeExecutionPlanResponse.DescribeExecutionPlan_ClusterInfo.DescribeExecutionPlan_SoftwareInfo softwareInfo = new DescribeExecutionPlanResponse.DescribeExecutionPlan_ClusterInfo.DescribeExecutionPlan_SoftwareInfo();
			softwareInfo.EmrVer = _ctx.StringValue("DescribeExecutionPlan.ClusterInfo.SoftwareInfo.EmrVer");
			softwareInfo.ClusterType = _ctx.StringValue("DescribeExecutionPlan.ClusterInfo.SoftwareInfo.ClusterType");

			List<DescribeExecutionPlanResponse.DescribeExecutionPlan_ClusterInfo.DescribeExecutionPlan_SoftwareInfo.DescribeExecutionPlan_Software> softwareInfo_softwares = new List<DescribeExecutionPlanResponse.DescribeExecutionPlan_ClusterInfo.DescribeExecutionPlan_SoftwareInfo.DescribeExecutionPlan_Software>();
			for (int i = 0; i < _ctx.Length("DescribeExecutionPlan.ClusterInfo.SoftwareInfo.Softwares.Length"); i++) {
				DescribeExecutionPlanResponse.DescribeExecutionPlan_ClusterInfo.DescribeExecutionPlan_SoftwareInfo.DescribeExecutionPlan_Software software = new DescribeExecutionPlanResponse.DescribeExecutionPlan_ClusterInfo.DescribeExecutionPlan_SoftwareInfo.DescribeExecutionPlan_Software();
				software.DisplayName = _ctx.StringValue("DescribeExecutionPlan.ClusterInfo.SoftwareInfo.Softwares["+ i +"].DisplayName");
				software.Name = _ctx.StringValue("DescribeExecutionPlan.ClusterInfo.SoftwareInfo.Softwares["+ i +"].Name");
				software.OnlyDisplay = _ctx.BooleanValue("DescribeExecutionPlan.ClusterInfo.SoftwareInfo.Softwares["+ i +"].OnlyDisplay");
				software.StartTpe = _ctx.IntegerValue("DescribeExecutionPlan.ClusterInfo.SoftwareInfo.Softwares["+ i +"].StartTpe");
				software.Version = _ctx.StringValue("DescribeExecutionPlan.ClusterInfo.SoftwareInfo.Softwares["+ i +"].Version");
				software.Optional = _ctx.BooleanValue("DescribeExecutionPlan.ClusterInfo.SoftwareInfo.Softwares["+ i +"].Optional");

				softwareInfo_softwares.Add(software);
			}
			softwareInfo.Softwares = softwareInfo_softwares;
			clusterInfo.SoftwareInfo = softwareInfo;

			List<DescribeExecutionPlanResponse.DescribeExecutionPlan_ClusterInfo.DescribeExecutionPlan_EcsOrderInfo> clusterInfo_ecsOrders = new List<DescribeExecutionPlanResponse.DescribeExecutionPlan_ClusterInfo.DescribeExecutionPlan_EcsOrderInfo>();
			for (int i = 0; i < _ctx.Length("DescribeExecutionPlan.ClusterInfo.EcsOrders.Length"); i++) {
				DescribeExecutionPlanResponse.DescribeExecutionPlan_ClusterInfo.DescribeExecutionPlan_EcsOrderInfo ecsOrderInfo = new DescribeExecutionPlanResponse.DescribeExecutionPlan_ClusterInfo.DescribeExecutionPlan_EcsOrderInfo();
				ecsOrderInfo.Index = _ctx.IntegerValue("DescribeExecutionPlan.ClusterInfo.EcsOrders["+ i +"].Index");
				ecsOrderInfo.NodeCount = _ctx.IntegerValue("DescribeExecutionPlan.ClusterInfo.EcsOrders["+ i +"].NodeCount");
				ecsOrderInfo.InstanceType = _ctx.StringValue("DescribeExecutionPlan.ClusterInfo.EcsOrders["+ i +"].InstanceType");
				ecsOrderInfo.DiskType = _ctx.StringValue("DescribeExecutionPlan.ClusterInfo.EcsOrders["+ i +"].DiskType");
				ecsOrderInfo.DiskCapacity = _ctx.IntegerValue("DescribeExecutionPlan.ClusterInfo.EcsOrders["+ i +"].DiskCapacity");
				ecsOrderInfo.NodeType = _ctx.StringValue("DescribeExecutionPlan.ClusterInfo.EcsOrders["+ i +"].NodeType");
				ecsOrderInfo.DiskCount = _ctx.IntegerValue("DescribeExecutionPlan.ClusterInfo.EcsOrders["+ i +"].DiskCount");

				clusterInfo_ecsOrders.Add(ecsOrderInfo);
			}
			clusterInfo.EcsOrders = clusterInfo_ecsOrders;

			List<DescribeExecutionPlanResponse.DescribeExecutionPlan_ClusterInfo.DescribeExecutionPlan_BootstrapAction> clusterInfo_bootstrapActionList = new List<DescribeExecutionPlanResponse.DescribeExecutionPlan_ClusterInfo.DescribeExecutionPlan_BootstrapAction>();
			for (int i = 0; i < _ctx.Length("DescribeExecutionPlan.ClusterInfo.BootstrapActionList.Length"); i++) {
				DescribeExecutionPlanResponse.DescribeExecutionPlan_ClusterInfo.DescribeExecutionPlan_BootstrapAction bootstrapAction = new DescribeExecutionPlanResponse.DescribeExecutionPlan_ClusterInfo.DescribeExecutionPlan_BootstrapAction();
				bootstrapAction.Name = _ctx.StringValue("DescribeExecutionPlan.ClusterInfo.BootstrapActionList["+ i +"].Name");
				bootstrapAction.Path = _ctx.StringValue("DescribeExecutionPlan.ClusterInfo.BootstrapActionList["+ i +"].Path");
				bootstrapAction.Arg = _ctx.StringValue("DescribeExecutionPlan.ClusterInfo.BootstrapActionList["+ i +"].Arg");

				clusterInfo_bootstrapActionList.Add(bootstrapAction);
			}
			clusterInfo.BootstrapActionList = clusterInfo_bootstrapActionList;

			List<DescribeExecutionPlanResponse.DescribeExecutionPlan_ClusterInfo.DescribeExecutionPlan_Config> clusterInfo_configList = new List<DescribeExecutionPlanResponse.DescribeExecutionPlan_ClusterInfo.DescribeExecutionPlan_Config>();
			for (int i = 0; i < _ctx.Length("DescribeExecutionPlan.ClusterInfo.ConfigList.Length"); i++) {
				DescribeExecutionPlanResponse.DescribeExecutionPlan_ClusterInfo.DescribeExecutionPlan_Config config = new DescribeExecutionPlanResponse.DescribeExecutionPlan_ClusterInfo.DescribeExecutionPlan_Config();
				config.ServiceName = _ctx.StringValue("DescribeExecutionPlan.ClusterInfo.ConfigList["+ i +"].ServiceName");
				config.FileName = _ctx.StringValue("DescribeExecutionPlan.ClusterInfo.ConfigList["+ i +"].FileName");
				config.ConfigKey = _ctx.StringValue("DescribeExecutionPlan.ClusterInfo.ConfigList["+ i +"].ConfigKey");
				config.ConfigValue = _ctx.StringValue("DescribeExecutionPlan.ClusterInfo.ConfigList["+ i +"].ConfigValue");
				config.Encrypt = _ctx.StringValue("DescribeExecutionPlan.ClusterInfo.ConfigList["+ i +"].Encrypt");

				clusterInfo_configList.Add(config);
			}
			clusterInfo.ConfigList = clusterInfo_configList;
			describeExecutionPlanResponse.ClusterInfo = clusterInfo;

			List<DescribeExecutionPlanResponse.DescribeExecutionPlan_JobInfo> describeExecutionPlanResponse_jobInfoList = new List<DescribeExecutionPlanResponse.DescribeExecutionPlan_JobInfo>();
			for (int i = 0; i < _ctx.Length("DescribeExecutionPlan.JobInfoList.Length"); i++) {
				DescribeExecutionPlanResponse.DescribeExecutionPlan_JobInfo jobInfo = new DescribeExecutionPlanResponse.DescribeExecutionPlan_JobInfo();
				jobInfo.Id = _ctx.StringValue("DescribeExecutionPlan.JobInfoList["+ i +"].Id");
				jobInfo.Name = _ctx.StringValue("DescribeExecutionPlan.JobInfoList["+ i +"].Name");
				jobInfo.Type = _ctx.StringValue("DescribeExecutionPlan.JobInfoList["+ i +"].Type");
				jobInfo.RunParameter = _ctx.StringValue("DescribeExecutionPlan.JobInfoList["+ i +"].RunParameter");
				jobInfo.FailAct = _ctx.StringValue("DescribeExecutionPlan.JobInfoList["+ i +"].FailAct");

				describeExecutionPlanResponse_jobInfoList.Add(jobInfo);
			}
			describeExecutionPlanResponse.JobInfoList = describeExecutionPlanResponse_jobInfoList;
        
			return describeExecutionPlanResponse;
        }
    }
}
