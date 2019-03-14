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
    public class DescribeClusterBasicInfoResponseUnmarshaller
    {
        public static DescribeClusterBasicInfoResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeClusterBasicInfoResponse describeClusterBasicInfoResponse = new DescribeClusterBasicInfoResponse();

			describeClusterBasicInfoResponse.HttpResponse = context.HttpResponse;
			describeClusterBasicInfoResponse.RequestId = context.StringValue("DescribeClusterBasicInfo.RequestId");

			DescribeClusterBasicInfoResponse.DescribeClusterBasicInfo_ClusterInfo clusterInfo = new DescribeClusterBasicInfoResponse.DescribeClusterBasicInfo_ClusterInfo();
			clusterInfo.Id = context.StringValue("DescribeClusterBasicInfo.ClusterInfo.Id");
			clusterInfo.BizId = context.StringValue("DescribeClusterBasicInfo.ClusterInfo.BizId");
			clusterInfo.RegionId = context.StringValue("DescribeClusterBasicInfo.ClusterInfo.RegionId");
			clusterInfo.ZoneId = context.StringValue("DescribeClusterBasicInfo.ClusterInfo.ZoneId");
			clusterInfo.Name = context.StringValue("DescribeClusterBasicInfo.ClusterInfo.Name");
			clusterInfo.CreateType = context.StringValue("DescribeClusterBasicInfo.ClusterInfo.CreateType");
			clusterInfo.StartTime = context.LongValue("DescribeClusterBasicInfo.ClusterInfo.StartTime");
			clusterInfo.StopTime = context.LongValue("DescribeClusterBasicInfo.ClusterInfo.StopTime");
			clusterInfo.LogEnable = context.BooleanValue("DescribeClusterBasicInfo.ClusterInfo.LogEnable");
			clusterInfo.LogPath = context.StringValue("DescribeClusterBasicInfo.ClusterInfo.LogPath");
			clusterInfo.Status = context.StringValue("DescribeClusterBasicInfo.ClusterInfo.Status");
			clusterInfo.HighAvailabilityEnable = context.BooleanValue("DescribeClusterBasicInfo.ClusterInfo.HighAvailabilityEnable");
			clusterInfo.ChargeType = context.StringValue("DescribeClusterBasicInfo.ClusterInfo.ChargeType");
			clusterInfo.ExpiredTime = context.LongValue("DescribeClusterBasicInfo.ClusterInfo.ExpiredTime");
			clusterInfo.Period = context.IntegerValue("DescribeClusterBasicInfo.ClusterInfo.Period");
			clusterInfo.RunningTime = context.IntegerValue("DescribeClusterBasicInfo.ClusterInfo.RunningTime");
			clusterInfo.MasterNodeTotal = context.IntegerValue("DescribeClusterBasicInfo.ClusterInfo.MasterNodeTotal");
			clusterInfo.MasterNodeInService = context.IntegerValue("DescribeClusterBasicInfo.ClusterInfo.MasterNodeInService");
			clusterInfo.CoreNodeTotal = context.IntegerValue("DescribeClusterBasicInfo.ClusterInfo.CoreNodeTotal");
			clusterInfo.CoreNodeInService = context.IntegerValue("DescribeClusterBasicInfo.ClusterInfo.CoreNodeInService");
			clusterInfo.TaskNodeTotal = context.IntegerValue("DescribeClusterBasicInfo.ClusterInfo.TaskNodeTotal");
			clusterInfo.TaskNodeInService = context.IntegerValue("DescribeClusterBasicInfo.ClusterInfo.TaskNodeInService");
			clusterInfo.ShowSoftwareInterface = context.BooleanValue("DescribeClusterBasicInfo.ClusterInfo.ShowSoftwareInterface");
			clusterInfo.VpcId = context.StringValue("DescribeClusterBasicInfo.ClusterInfo.VpcId");
			clusterInfo.VSwitchId = context.StringValue("DescribeClusterBasicInfo.ClusterInfo.VSwitchId");
			clusterInfo.NetType = context.StringValue("DescribeClusterBasicInfo.ClusterInfo.NetType");
			clusterInfo.UserDefinedEmrEcsRole = context.StringValue("DescribeClusterBasicInfo.ClusterInfo.UserDefinedEmrEcsRole");
			clusterInfo.IoOptimized = context.BooleanValue("DescribeClusterBasicInfo.ClusterInfo.IoOptimized");
			clusterInfo.InstanceGeneration = context.StringValue("DescribeClusterBasicInfo.ClusterInfo.InstanceGeneration");
			clusterInfo.BootstrapFailed = context.BooleanValue("DescribeClusterBasicInfo.ClusterInfo.BootstrapFailed");
			clusterInfo.Configurations = context.StringValue("DescribeClusterBasicInfo.ClusterInfo.Configurations");
			clusterInfo.ImageId = context.StringValue("DescribeClusterBasicInfo.ClusterInfo.ImageId");
			clusterInfo.SecurityGroupId = context.StringValue("DescribeClusterBasicInfo.ClusterInfo.SecurityGroupId");
			clusterInfo.SecurityGroupName = context.StringValue("DescribeClusterBasicInfo.ClusterInfo.SecurityGroupName");
			clusterInfo.EasEnable = context.BooleanValue("DescribeClusterBasicInfo.ClusterInfo.EasEnable");
			clusterInfo.ClusterType = context.StringValue("DescribeClusterBasicInfo.ClusterInfo.ClusterType");

			DescribeClusterBasicInfoResponse.DescribeClusterBasicInfo_ClusterInfo.DescribeClusterBasicInfo_SoftwareInfo softwareInfo = new DescribeClusterBasicInfoResponse.DescribeClusterBasicInfo_ClusterInfo.DescribeClusterBasicInfo_SoftwareInfo();
			softwareInfo.EmrVer = context.StringValue("DescribeClusterBasicInfo.ClusterInfo.SoftwareInfo.EmrVer");
			softwareInfo.ClusterType = context.StringValue("DescribeClusterBasicInfo.ClusterInfo.SoftwareInfo.ClusterType");

			List<DescribeClusterBasicInfoResponse.DescribeClusterBasicInfo_ClusterInfo.DescribeClusterBasicInfo_SoftwareInfo.DescribeClusterBasicInfo_Software> softwareInfo_softwares = new List<DescribeClusterBasicInfoResponse.DescribeClusterBasicInfo_ClusterInfo.DescribeClusterBasicInfo_SoftwareInfo.DescribeClusterBasicInfo_Software>();
			for (int i = 0; i < context.Length("DescribeClusterBasicInfo.ClusterInfo.SoftwareInfo.Softwares.Length"); i++) {
				DescribeClusterBasicInfoResponse.DescribeClusterBasicInfo_ClusterInfo.DescribeClusterBasicInfo_SoftwareInfo.DescribeClusterBasicInfo_Software software = new DescribeClusterBasicInfoResponse.DescribeClusterBasicInfo_ClusterInfo.DescribeClusterBasicInfo_SoftwareInfo.DescribeClusterBasicInfo_Software();
				software.DisplayName = context.StringValue("DescribeClusterBasicInfo.ClusterInfo.SoftwareInfo.Softwares["+ i +"].DisplayName");
				software.Name = context.StringValue("DescribeClusterBasicInfo.ClusterInfo.SoftwareInfo.Softwares["+ i +"].Name");
				software.OnlyDisplay = context.BooleanValue("DescribeClusterBasicInfo.ClusterInfo.SoftwareInfo.Softwares["+ i +"].OnlyDisplay");
				software.StartTpe = context.IntegerValue("DescribeClusterBasicInfo.ClusterInfo.SoftwareInfo.Softwares["+ i +"].StartTpe");
				software.Version = context.StringValue("DescribeClusterBasicInfo.ClusterInfo.SoftwareInfo.Softwares["+ i +"].Version");

				softwareInfo_softwares.Add(software);
			}
			softwareInfo.Softwares = softwareInfo_softwares;
			clusterInfo.SoftwareInfo = softwareInfo;

			DescribeClusterBasicInfoResponse.DescribeClusterBasicInfo_ClusterInfo.DescribeClusterBasicInfo_FailReason failReason = new DescribeClusterBasicInfoResponse.DescribeClusterBasicInfo_ClusterInfo.DescribeClusterBasicInfo_FailReason();
			failReason.ErrorCode = context.StringValue("DescribeClusterBasicInfo.ClusterInfo.FailReason.ErrorCode");
			failReason.ErrorMsg = context.StringValue("DescribeClusterBasicInfo.ClusterInfo.FailReason.ErrorMsg");
			failReason.RequestId = context.StringValue("DescribeClusterBasicInfo.ClusterInfo.FailReason.RequestId");
			clusterInfo.FailReason = failReason;

			List<DescribeClusterBasicInfoResponse.DescribeClusterBasicInfo_ClusterInfo.DescribeClusterBasicInfo_BootstrapAction> clusterInfo_bootstrapActionList = new List<DescribeClusterBasicInfoResponse.DescribeClusterBasicInfo_ClusterInfo.DescribeClusterBasicInfo_BootstrapAction>();
			for (int i = 0; i < context.Length("DescribeClusterBasicInfo.ClusterInfo.BootstrapActionList.Length"); i++) {
				DescribeClusterBasicInfoResponse.DescribeClusterBasicInfo_ClusterInfo.DescribeClusterBasicInfo_BootstrapAction bootstrapAction = new DescribeClusterBasicInfoResponse.DescribeClusterBasicInfo_ClusterInfo.DescribeClusterBasicInfo_BootstrapAction();
				bootstrapAction.Name = context.StringValue("DescribeClusterBasicInfo.ClusterInfo.BootstrapActionList["+ i +"].Name");
				bootstrapAction.Path = context.StringValue("DescribeClusterBasicInfo.ClusterInfo.BootstrapActionList["+ i +"].Path");
				bootstrapAction.Arg = context.StringValue("DescribeClusterBasicInfo.ClusterInfo.BootstrapActionList["+ i +"].Arg");

				clusterInfo_bootstrapActionList.Add(bootstrapAction);
			}
			clusterInfo.BootstrapActionList = clusterInfo_bootstrapActionList;
			describeClusterBasicInfoResponse.ClusterInfo = clusterInfo;
        
			return describeClusterBasicInfoResponse;
        }
    }
}
