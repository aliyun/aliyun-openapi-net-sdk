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
    public class DescribeClusterTemplateResponseUnmarshaller
    {
        public static DescribeClusterTemplateResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeClusterTemplateResponse describeClusterTemplateResponse = new DescribeClusterTemplateResponse();

			describeClusterTemplateResponse.HttpResponse = context.HttpResponse;
			describeClusterTemplateResponse.RequestId = context.StringValue("DescribeClusterTemplate.RequestId");

			DescribeClusterTemplateResponse.DescribeClusterTemplate_TemplateInfo templateInfo = new DescribeClusterTemplateResponse.DescribeClusterTemplate_TemplateInfo();
			templateInfo.Id = context.StringValue("DescribeClusterTemplate.TemplateInfo.Id");
			templateInfo.TemplateName = context.StringValue("DescribeClusterTemplate.TemplateInfo.TemplateName");
			templateInfo.EmrVer = context.StringValue("DescribeClusterTemplate.TemplateInfo.EmrVer");
			templateInfo.LogEnable = context.BooleanValue("DescribeClusterTemplate.TemplateInfo.LogEnable");
			templateInfo.LogPath = context.StringValue("DescribeClusterTemplate.TemplateInfo.LogPath");
			templateInfo.UserId = context.StringValue("DescribeClusterTemplate.TemplateInfo.UserId");
			templateInfo.UserDefinedEmrEcsRole = context.StringValue("DescribeClusterTemplate.TemplateInfo.UserDefinedEmrEcsRole");
			templateInfo.MasterNodeTotal = context.IntegerValue("DescribeClusterTemplate.TemplateInfo.MasterNodeTotal");
			templateInfo.VpcId = context.StringValue("DescribeClusterTemplate.TemplateInfo.VpcId");
			templateInfo.VSwitchId = context.StringValue("DescribeClusterTemplate.TemplateInfo.VSwitchId");
			templateInfo.NetType = context.StringValue("DescribeClusterTemplate.TemplateInfo.NetType");
			templateInfo.IoOptimized = context.BooleanValue("DescribeClusterTemplate.TemplateInfo.IoOptimized");
			templateInfo.InstanceGeneration = context.StringValue("DescribeClusterTemplate.TemplateInfo.InstanceGeneration");
			templateInfo.HighAvailabilityEnable = context.BooleanValue("DescribeClusterTemplate.TemplateInfo.HighAvailabilityEnable");
			templateInfo.EasEnable = context.BooleanValue("DescribeClusterTemplate.TemplateInfo.EasEnable");
			templateInfo.GmtCreate = context.LongValue("DescribeClusterTemplate.TemplateInfo.GmtCreate");
			templateInfo.GmtModified = context.LongValue("DescribeClusterTemplate.TemplateInfo.GmtModified");
			templateInfo.ZoneId = context.StringValue("DescribeClusterTemplate.TemplateInfo.ZoneId");
			templateInfo.ClusterType = context.StringValue("DescribeClusterTemplate.TemplateInfo.ClusterType");
			templateInfo.SecurityGroupId = context.StringValue("DescribeClusterTemplate.TemplateInfo.SecurityGroupId");
			templateInfo.SecurityGroupName = context.StringValue("DescribeClusterTemplate.TemplateInfo.SecurityGroupName");
			templateInfo.Configurations = context.StringValue("DescribeClusterTemplate.TemplateInfo.Configurations");
			templateInfo.AllowNotebook = context.BooleanValue("DescribeClusterTemplate.TemplateInfo.AllowNotebook");
			templateInfo.CreateSource = context.StringValue("DescribeClusterTemplate.TemplateInfo.CreateSource");
			templateInfo.UseLocalMetaDb = context.BooleanValue("DescribeClusterTemplate.TemplateInfo.UseLocalMetaDb");
			templateInfo.SshEnable = context.BooleanValue("DescribeClusterTemplate.TemplateInfo.SshEnable");
			templateInfo.IsOpenPublicIp = context.BooleanValue("DescribeClusterTemplate.TemplateInfo.IsOpenPublicIp");
			templateInfo.DepositType = context.StringValue("DescribeClusterTemplate.TemplateInfo.DepositType");
			templateInfo.MachineType = context.StringValue("DescribeClusterTemplate.TemplateInfo.MachineType");
			templateInfo.UseCustomHiveMetaDb = context.BooleanValue("DescribeClusterTemplate.TemplateInfo.UseCustomHiveMetaDb");
			templateInfo.InitCustomHiveMetaDb = context.BooleanValue("DescribeClusterTemplate.TemplateInfo.InitCustomHiveMetaDb");

			List<string> templateInfo_softwareInfoList = new List<string>();
			for (int i = 0; i < context.Length("DescribeClusterTemplate.TemplateInfo.SoftwareInfoList.Length"); i++) {
				templateInfo_softwareInfoList.Add(context.StringValue("DescribeClusterTemplate.TemplateInfo.SoftwareInfoList["+ i +"]"));
			}
			templateInfo.SoftwareInfoList = templateInfo_softwareInfoList;

			List<DescribeClusterTemplateResponse.DescribeClusterTemplate_TemplateInfo.DescribeClusterTemplate_BootstrapAction> templateInfo_bootstrapActionList = new List<DescribeClusterTemplateResponse.DescribeClusterTemplate_TemplateInfo.DescribeClusterTemplate_BootstrapAction>();
			for (int i = 0; i < context.Length("DescribeClusterTemplate.TemplateInfo.BootstrapActionList.Length"); i++) {
				DescribeClusterTemplateResponse.DescribeClusterTemplate_TemplateInfo.DescribeClusterTemplate_BootstrapAction bootstrapAction = new DescribeClusterTemplateResponse.DescribeClusterTemplate_TemplateInfo.DescribeClusterTemplate_BootstrapAction();
				bootstrapAction.Name = context.StringValue("DescribeClusterTemplate.TemplateInfo.BootstrapActionList["+ i +"].Name");
				bootstrapAction.Path = context.StringValue("DescribeClusterTemplate.TemplateInfo.BootstrapActionList["+ i +"].Path");
				bootstrapAction.Arg = context.StringValue("DescribeClusterTemplate.TemplateInfo.BootstrapActionList["+ i +"].Arg");

				templateInfo_bootstrapActionList.Add(bootstrapAction);
			}
			templateInfo.BootstrapActionList = templateInfo_bootstrapActionList;

			List<DescribeClusterTemplateResponse.DescribeClusterTemplate_TemplateInfo.DescribeClusterTemplate_HostGroup> templateInfo_hostGroupList = new List<DescribeClusterTemplateResponse.DescribeClusterTemplate_TemplateInfo.DescribeClusterTemplate_HostGroup>();
			for (int i = 0; i < context.Length("DescribeClusterTemplate.TemplateInfo.HostGroupList.Length"); i++) {
				DescribeClusterTemplateResponse.DescribeClusterTemplate_TemplateInfo.DescribeClusterTemplate_HostGroup hostGroup = new DescribeClusterTemplateResponse.DescribeClusterTemplate_TemplateInfo.DescribeClusterTemplate_HostGroup();
				hostGroup.HostGroupId = context.StringValue("DescribeClusterTemplate.TemplateInfo.HostGroupList["+ i +"].HostGroupId");
				hostGroup.HostGroupName = context.StringValue("DescribeClusterTemplate.TemplateInfo.HostGroupList["+ i +"].HostGroupName");
				hostGroup.HostGroupType = context.StringValue("DescribeClusterTemplate.TemplateInfo.HostGroupList["+ i +"].HostGroupType");
				hostGroup.ChargeType = context.StringValue("DescribeClusterTemplate.TemplateInfo.HostGroupList["+ i +"].ChargeType");
				hostGroup.Period = context.StringValue("DescribeClusterTemplate.TemplateInfo.HostGroupList["+ i +"].Period");
				hostGroup.NodeCount = context.IntegerValue("DescribeClusterTemplate.TemplateInfo.HostGroupList["+ i +"].NodeCount");
				hostGroup.InstanceType = context.StringValue("DescribeClusterTemplate.TemplateInfo.HostGroupList["+ i +"].InstanceType");
				hostGroup.DiskType = context.StringValue("DescribeClusterTemplate.TemplateInfo.HostGroupList["+ i +"].DiskType");
				hostGroup.DiskCapacity = context.IntegerValue("DescribeClusterTemplate.TemplateInfo.HostGroupList["+ i +"].DiskCapacity");
				hostGroup.DiskCount = context.IntegerValue("DescribeClusterTemplate.TemplateInfo.HostGroupList["+ i +"].DiskCount");
				hostGroup.SysDiskType = context.StringValue("DescribeClusterTemplate.TemplateInfo.HostGroupList["+ i +"].SysDiskType");
				hostGroup.SysDiskCapacity = context.IntegerValue("DescribeClusterTemplate.TemplateInfo.HostGroupList["+ i +"].SysDiskCapacity");
				hostGroup.MultiInstanceTypes = context.StringValue("DescribeClusterTemplate.TemplateInfo.HostGroupList["+ i +"].MultiInstanceTypes");

				templateInfo_hostGroupList.Add(hostGroup);
			}
			templateInfo.HostGroupList = templateInfo_hostGroupList;

			List<DescribeClusterTemplateResponse.DescribeClusterTemplate_TemplateInfo.DescribeClusterTemplate_Config> templateInfo_configList = new List<DescribeClusterTemplateResponse.DescribeClusterTemplate_TemplateInfo.DescribeClusterTemplate_Config>();
			for (int i = 0; i < context.Length("DescribeClusterTemplate.TemplateInfo.ConfigList.Length"); i++) {
				DescribeClusterTemplateResponse.DescribeClusterTemplate_TemplateInfo.DescribeClusterTemplate_Config config = new DescribeClusterTemplateResponse.DescribeClusterTemplate_TemplateInfo.DescribeClusterTemplate_Config();
				config.ServiceName = context.StringValue("DescribeClusterTemplate.TemplateInfo.ConfigList["+ i +"].ServiceName");
				config.FileName = context.StringValue("DescribeClusterTemplate.TemplateInfo.ConfigList["+ i +"].FileName");
				config.ConfigKey = context.StringValue("DescribeClusterTemplate.TemplateInfo.ConfigList["+ i +"].ConfigKey");
				config.ConfigValue = context.StringValue("DescribeClusterTemplate.TemplateInfo.ConfigList["+ i +"].ConfigValue");
				config.Encrypt = context.StringValue("DescribeClusterTemplate.TemplateInfo.ConfigList["+ i +"].Encrypt");
				config.Replace = context.StringValue("DescribeClusterTemplate.TemplateInfo.ConfigList["+ i +"].Replace");

				templateInfo_configList.Add(config);
			}
			templateInfo.ConfigList = templateInfo_configList;
			describeClusterTemplateResponse.TemplateInfo = templateInfo;
        
			return describeClusterTemplateResponse;
        }
    }
}
