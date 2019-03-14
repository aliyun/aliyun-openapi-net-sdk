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
        public static DescribeExecutionPlanResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeExecutionPlanResponse describeExecutionPlanResponse = new DescribeExecutionPlanResponse();

			describeExecutionPlanResponse.HttpResponse = context.HttpResponse;
			describeExecutionPlanResponse.RequestId = context.StringValue("DescribeExecutionPlan.RequestId");
			describeExecutionPlanResponse.Id = context.StringValue("DescribeExecutionPlan.Id");
			describeExecutionPlanResponse.Name = context.StringValue("DescribeExecutionPlan.Name");
			describeExecutionPlanResponse.Status = context.StringValue("DescribeExecutionPlan.Status");
			describeExecutionPlanResponse.Strategy = context.StringValue("DescribeExecutionPlan.Strategy");
			describeExecutionPlanResponse.TimeInterval = context.IntegerValue("DescribeExecutionPlan.TimeInterval");
			describeExecutionPlanResponse.StartTime = context.LongValue("DescribeExecutionPlan.StartTime");
			describeExecutionPlanResponse.TimeUnit = context.StringValue("DescribeExecutionPlan.TimeUnit");
			describeExecutionPlanResponse.DayOfWeek = context.StringValue("DescribeExecutionPlan.DayOfWeek");
			describeExecutionPlanResponse.DayOfMonth = context.StringValue("DescribeExecutionPlan.DayOfMonth");
			describeExecutionPlanResponse.CreateClusterOnDemand = context.BooleanValue("DescribeExecutionPlan.CreateClusterOnDemand");
			describeExecutionPlanResponse.ClusterId = context.StringValue("DescribeExecutionPlan.ClusterId");
			describeExecutionPlanResponse.ClusterName = context.StringValue("DescribeExecutionPlan.ClusterName");
			describeExecutionPlanResponse.WorkflowApp = context.StringValue("DescribeExecutionPlan.WorkflowApp");
			describeExecutionPlanResponse.ExecutionPlanVersion = context.LongValue("DescribeExecutionPlan.ExecutionPlanVersion");

			DescribeExecutionPlanResponse.DescribeExecutionPlan_ClusterInfo clusterInfo = new DescribeExecutionPlanResponse.DescribeExecutionPlan_ClusterInfo();
			clusterInfo.Name = context.StringValue("DescribeExecutionPlan.ClusterInfo.Name");
			clusterInfo.ZoneId = context.StringValue("DescribeExecutionPlan.ClusterInfo.ZoneId");
			clusterInfo.LogEnable = context.BooleanValue("DescribeExecutionPlan.ClusterInfo.LogEnable");
			clusterInfo.LogPath = context.StringValue("DescribeExecutionPlan.ClusterInfo.LogPath");
			clusterInfo.SecurityGroupId = context.StringValue("DescribeExecutionPlan.ClusterInfo.SecurityGroupId");
			clusterInfo.EmrVer = context.StringValue("DescribeExecutionPlan.ClusterInfo.EmrVer");
			clusterInfo.ClusterType = context.StringValue("DescribeExecutionPlan.ClusterInfo.ClusterType");
			clusterInfo.HighAvailabilityEnable = context.BooleanValue("DescribeExecutionPlan.ClusterInfo.HighAvailabilityEnable");
			clusterInfo.VpcId = context.StringValue("DescribeExecutionPlan.ClusterInfo.VpcId");
			clusterInfo.VSwitchId = context.StringValue("DescribeExecutionPlan.ClusterInfo.VSwitchId");
			clusterInfo.NetType = context.StringValue("DescribeExecutionPlan.ClusterInfo.NetType");
			clusterInfo.IoOptimized = context.BooleanValue("DescribeExecutionPlan.ClusterInfo.IoOptimized");
			clusterInfo.InstanceGeneration = context.StringValue("DescribeExecutionPlan.ClusterInfo.InstanceGeneration");
			clusterInfo.Configurations = context.StringValue("DescribeExecutionPlan.ClusterInfo.Configurations");
			clusterInfo.EasEnable = context.BooleanValue("DescribeExecutionPlan.ClusterInfo.EasEnable");
			clusterInfo.UseCustomHiveMetaDB = context.BooleanValue("DescribeExecutionPlan.ClusterInfo.UseCustomHiveMetaDB");
			clusterInfo.InitCustomHiveMetaDB = context.BooleanValue("DescribeExecutionPlan.ClusterInfo.InitCustomHiveMetaDB");
			clusterInfo.UserDefinedEmrEcsRole = context.StringValue("DescribeExecutionPlan.ClusterInfo.UserDefinedEmrEcsRole");
			clusterInfo.UseLocalMetaDb = context.BooleanValue("DescribeExecutionPlan.ClusterInfo.UseLocalMetaDb");

			DescribeExecutionPlanResponse.DescribeExecutionPlan_ClusterInfo.DescribeExecutionPlan_SoftwareInfo softwareInfo = new DescribeExecutionPlanResponse.DescribeExecutionPlan_ClusterInfo.DescribeExecutionPlan_SoftwareInfo();
			softwareInfo.EmrVer = context.StringValue("DescribeExecutionPlan.ClusterInfo.SoftwareInfo.EmrVer");
			softwareInfo.ClusterType = context.StringValue("DescribeExecutionPlan.ClusterInfo.SoftwareInfo.ClusterType");

			List<DescribeExecutionPlanResponse.DescribeExecutionPlan_ClusterInfo.DescribeExecutionPlan_SoftwareInfo.DescribeExecutionPlan_Software> softwareInfo_softwares = new List<DescribeExecutionPlanResponse.DescribeExecutionPlan_ClusterInfo.DescribeExecutionPlan_SoftwareInfo.DescribeExecutionPlan_Software>();
			for (int i = 0; i < context.Length("DescribeExecutionPlan.ClusterInfo.SoftwareInfo.Softwares.Length"); i++) {
				DescribeExecutionPlanResponse.DescribeExecutionPlan_ClusterInfo.DescribeExecutionPlan_SoftwareInfo.DescribeExecutionPlan_Software software = new DescribeExecutionPlanResponse.DescribeExecutionPlan_ClusterInfo.DescribeExecutionPlan_SoftwareInfo.DescribeExecutionPlan_Software();
				software.DisplayName = context.StringValue("DescribeExecutionPlan.ClusterInfo.SoftwareInfo.Softwares["+ i +"].DisplayName");
				software.Name = context.StringValue("DescribeExecutionPlan.ClusterInfo.SoftwareInfo.Softwares["+ i +"].Name");
				software.OnlyDisplay = context.BooleanValue("DescribeExecutionPlan.ClusterInfo.SoftwareInfo.Softwares["+ i +"].OnlyDisplay");
				software.StartTpe = context.IntegerValue("DescribeExecutionPlan.ClusterInfo.SoftwareInfo.Softwares["+ i +"].StartTpe");
				software.Version = context.StringValue("DescribeExecutionPlan.ClusterInfo.SoftwareInfo.Softwares["+ i +"].Version");
				software.Optional = context.BooleanValue("DescribeExecutionPlan.ClusterInfo.SoftwareInfo.Softwares["+ i +"].Optional");

				softwareInfo_softwares.Add(software);
			}
			softwareInfo.Softwares = softwareInfo_softwares;
			clusterInfo.SoftwareInfo = softwareInfo;

			List<DescribeExecutionPlanResponse.DescribeExecutionPlan_ClusterInfo.DescribeExecutionPlan_EcsOrderInfo> clusterInfo_ecsOrders = new List<DescribeExecutionPlanResponse.DescribeExecutionPlan_ClusterInfo.DescribeExecutionPlan_EcsOrderInfo>();
			for (int i = 0; i < context.Length("DescribeExecutionPlan.ClusterInfo.EcsOrders.Length"); i++) {
				DescribeExecutionPlanResponse.DescribeExecutionPlan_ClusterInfo.DescribeExecutionPlan_EcsOrderInfo ecsOrderInfo = new DescribeExecutionPlanResponse.DescribeExecutionPlan_ClusterInfo.DescribeExecutionPlan_EcsOrderInfo();
				ecsOrderInfo.Index = context.IntegerValue("DescribeExecutionPlan.ClusterInfo.EcsOrders["+ i +"].Index");
				ecsOrderInfo.NodeCount = context.IntegerValue("DescribeExecutionPlan.ClusterInfo.EcsOrders["+ i +"].NodeCount");
				ecsOrderInfo.InstanceType = context.StringValue("DescribeExecutionPlan.ClusterInfo.EcsOrders["+ i +"].InstanceType");
				ecsOrderInfo.DiskType = context.StringValue("DescribeExecutionPlan.ClusterInfo.EcsOrders["+ i +"].DiskType");
				ecsOrderInfo.DiskCapacity = context.IntegerValue("DescribeExecutionPlan.ClusterInfo.EcsOrders["+ i +"].DiskCapacity");
				ecsOrderInfo.NodeType = context.StringValue("DescribeExecutionPlan.ClusterInfo.EcsOrders["+ i +"].NodeType");
				ecsOrderInfo.DiskCount = context.IntegerValue("DescribeExecutionPlan.ClusterInfo.EcsOrders["+ i +"].DiskCount");

				clusterInfo_ecsOrders.Add(ecsOrderInfo);
			}
			clusterInfo.EcsOrders = clusterInfo_ecsOrders;

			List<DescribeExecutionPlanResponse.DescribeExecutionPlan_ClusterInfo.DescribeExecutionPlan_BootstrapAction> clusterInfo_bootstrapActionList = new List<DescribeExecutionPlanResponse.DescribeExecutionPlan_ClusterInfo.DescribeExecutionPlan_BootstrapAction>();
			for (int i = 0; i < context.Length("DescribeExecutionPlan.ClusterInfo.BootstrapActionList.Length"); i++) {
				DescribeExecutionPlanResponse.DescribeExecutionPlan_ClusterInfo.DescribeExecutionPlan_BootstrapAction bootstrapAction = new DescribeExecutionPlanResponse.DescribeExecutionPlan_ClusterInfo.DescribeExecutionPlan_BootstrapAction();
				bootstrapAction.Name = context.StringValue("DescribeExecutionPlan.ClusterInfo.BootstrapActionList["+ i +"].Name");
				bootstrapAction.Path = context.StringValue("DescribeExecutionPlan.ClusterInfo.BootstrapActionList["+ i +"].Path");
				bootstrapAction.Arg = context.StringValue("DescribeExecutionPlan.ClusterInfo.BootstrapActionList["+ i +"].Arg");

				clusterInfo_bootstrapActionList.Add(bootstrapAction);
			}
			clusterInfo.BootstrapActionList = clusterInfo_bootstrapActionList;

			List<DescribeExecutionPlanResponse.DescribeExecutionPlan_ClusterInfo.DescribeExecutionPlan_Config> clusterInfo_configList = new List<DescribeExecutionPlanResponse.DescribeExecutionPlan_ClusterInfo.DescribeExecutionPlan_Config>();
			for (int i = 0; i < context.Length("DescribeExecutionPlan.ClusterInfo.ConfigList.Length"); i++) {
				DescribeExecutionPlanResponse.DescribeExecutionPlan_ClusterInfo.DescribeExecutionPlan_Config config = new DescribeExecutionPlanResponse.DescribeExecutionPlan_ClusterInfo.DescribeExecutionPlan_Config();
				config.ServiceName = context.StringValue("DescribeExecutionPlan.ClusterInfo.ConfigList["+ i +"].ServiceName");
				config.FileName = context.StringValue("DescribeExecutionPlan.ClusterInfo.ConfigList["+ i +"].FileName");
				config.ConfigKey = context.StringValue("DescribeExecutionPlan.ClusterInfo.ConfigList["+ i +"].ConfigKey");
				config.ConfigValue = context.StringValue("DescribeExecutionPlan.ClusterInfo.ConfigList["+ i +"].ConfigValue");
				config.Encrypt = context.StringValue("DescribeExecutionPlan.ClusterInfo.ConfigList["+ i +"].Encrypt");

				clusterInfo_configList.Add(config);
			}
			clusterInfo.ConfigList = clusterInfo_configList;
			describeExecutionPlanResponse.ClusterInfo = clusterInfo;

			List<DescribeExecutionPlanResponse.DescribeExecutionPlan_JobInfo> describeExecutionPlanResponse_jobInfoList = new List<DescribeExecutionPlanResponse.DescribeExecutionPlan_JobInfo>();
			for (int i = 0; i < context.Length("DescribeExecutionPlan.JobInfoList.Length"); i++) {
				DescribeExecutionPlanResponse.DescribeExecutionPlan_JobInfo jobInfo = new DescribeExecutionPlanResponse.DescribeExecutionPlan_JobInfo();
				jobInfo.Id = context.StringValue("DescribeExecutionPlan.JobInfoList["+ i +"].Id");
				jobInfo.Name = context.StringValue("DescribeExecutionPlan.JobInfoList["+ i +"].Name");
				jobInfo.Type = context.StringValue("DescribeExecutionPlan.JobInfoList["+ i +"].Type");
				jobInfo.RunParameter = context.StringValue("DescribeExecutionPlan.JobInfoList["+ i +"].RunParameter");
				jobInfo.FailAct = context.StringValue("DescribeExecutionPlan.JobInfoList["+ i +"].FailAct");

				describeExecutionPlanResponse_jobInfoList.Add(jobInfo);
			}
			describeExecutionPlanResponse.JobInfoList = describeExecutionPlanResponse_jobInfoList;
        
			return describeExecutionPlanResponse;
        }
    }
}
