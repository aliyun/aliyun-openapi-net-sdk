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
    public class ListClusterTemplatesResponseUnmarshaller
    {
        public static ListClusterTemplatesResponse Unmarshall(UnmarshallerContext context)
        {
			ListClusterTemplatesResponse listClusterTemplatesResponse = new ListClusterTemplatesResponse();

			listClusterTemplatesResponse.HttpResponse = context.HttpResponse;
			listClusterTemplatesResponse.RequestId = context.StringValue("ListClusterTemplates.RequestId");
			listClusterTemplatesResponse.TotalCount = context.IntegerValue("ListClusterTemplates.TotalCount");
			listClusterTemplatesResponse.PageNumber = context.IntegerValue("ListClusterTemplates.PageNumber");
			listClusterTemplatesResponse.PageSize = context.IntegerValue("ListClusterTemplates.PageSize");

			List<ListClusterTemplatesResponse.ListClusterTemplates_TemplateInfo> listClusterTemplatesResponse_templateInfoList = new List<ListClusterTemplatesResponse.ListClusterTemplates_TemplateInfo>();
			for (int i = 0; i < context.Length("ListClusterTemplates.TemplateInfoList.Length"); i++) {
				ListClusterTemplatesResponse.ListClusterTemplates_TemplateInfo templateInfo = new ListClusterTemplatesResponse.ListClusterTemplates_TemplateInfo();
				templateInfo.Id = context.StringValue("ListClusterTemplates.TemplateInfoList["+ i +"].Id");
				templateInfo.TemplateName = context.StringValue("ListClusterTemplates.TemplateInfoList["+ i +"].TemplateName");
				templateInfo.LogEnable = context.BooleanValue("ListClusterTemplates.TemplateInfoList["+ i +"].LogEnable");
				templateInfo.LogPath = context.StringValue("ListClusterTemplates.TemplateInfoList["+ i +"].LogPath");
				templateInfo.UserId = context.StringValue("ListClusterTemplates.TemplateInfoList["+ i +"].UserId");
				templateInfo.UserDefinedEmrEcsRole = context.StringValue("ListClusterTemplates.TemplateInfoList["+ i +"].UserDefinedEmrEcsRole");
				templateInfo.MasterNodeTotal = context.IntegerValue("ListClusterTemplates.TemplateInfoList["+ i +"].MasterNodeTotal");
				templateInfo.VpcId = context.StringValue("ListClusterTemplates.TemplateInfoList["+ i +"].VpcId");
				templateInfo.VSwitchId = context.StringValue("ListClusterTemplates.TemplateInfoList["+ i +"].VSwitchId");
				templateInfo.NetType = context.StringValue("ListClusterTemplates.TemplateInfoList["+ i +"].NetType");
				templateInfo.IoOptimized = context.BooleanValue("ListClusterTemplates.TemplateInfoList["+ i +"].IoOptimized");
				templateInfo.InstanceGeneration = context.StringValue("ListClusterTemplates.TemplateInfoList["+ i +"].InstanceGeneration");
				templateInfo.HighAvailabilityEnable = context.BooleanValue("ListClusterTemplates.TemplateInfoList["+ i +"].HighAvailabilityEnable");
				templateInfo.EasEnable = context.BooleanValue("ListClusterTemplates.TemplateInfoList["+ i +"].EasEnable");
				templateInfo.GmtCreate = context.LongValue("ListClusterTemplates.TemplateInfoList["+ i +"].GmtCreate");
				templateInfo.GmtModified = context.LongValue("ListClusterTemplates.TemplateInfoList["+ i +"].GmtModified");
				templateInfo.ZoneId = context.StringValue("ListClusterTemplates.TemplateInfoList["+ i +"].ZoneId");
				templateInfo.ClusterType = context.StringValue("ListClusterTemplates.TemplateInfoList["+ i +"].ClusterType");
				templateInfo.SecurityGroupId = context.StringValue("ListClusterTemplates.TemplateInfoList["+ i +"].SecurityGroupId");
				templateInfo.SecurityGroupName = context.StringValue("ListClusterTemplates.TemplateInfoList["+ i +"].SecurityGroupName");
				templateInfo.Configurations = context.StringValue("ListClusterTemplates.TemplateInfoList["+ i +"].Configurations");
				templateInfo.AllowNotebook = context.BooleanValue("ListClusterTemplates.TemplateInfoList["+ i +"].AllowNotebook");
				templateInfo.CreateSource = context.StringValue("ListClusterTemplates.TemplateInfoList["+ i +"].CreateSource");
				templateInfo.UseLocalMetaDb = context.BooleanValue("ListClusterTemplates.TemplateInfoList["+ i +"].UseLocalMetaDb");
				templateInfo.SshEnable = context.BooleanValue("ListClusterTemplates.TemplateInfoList["+ i +"].SshEnable");
				templateInfo.IsOpenPublicIp = context.BooleanValue("ListClusterTemplates.TemplateInfoList["+ i +"].IsOpenPublicIp");
				templateInfo.DepositType = context.StringValue("ListClusterTemplates.TemplateInfoList["+ i +"].DepositType");
				templateInfo.MachineType = context.StringValue("ListClusterTemplates.TemplateInfoList["+ i +"].MachineType");
				templateInfo.UseCustomHiveMetaDb = context.BooleanValue("ListClusterTemplates.TemplateInfoList["+ i +"].UseCustomHiveMetaDb");
				templateInfo.InitCustomHiveMetaDb = context.BooleanValue("ListClusterTemplates.TemplateInfoList["+ i +"].InitCustomHiveMetaDb");

				List<string> templateInfo_softwareInfoList = new List<string>();
				for (int j = 0; j < context.Length("ListClusterTemplates.TemplateInfoList["+ i +"].SoftwareInfoList.Length"); j++) {
					templateInfo_softwareInfoList.Add(context.StringValue("ListClusterTemplates.TemplateInfoList["+ i +"].SoftwareInfoList["+ j +"]"));
				}
				templateInfo.SoftwareInfoList = templateInfo_softwareInfoList;

				List<ListClusterTemplatesResponse.ListClusterTemplates_TemplateInfo.ListClusterTemplates_BootstrapAction> templateInfo_bootstrapActionList = new List<ListClusterTemplatesResponse.ListClusterTemplates_TemplateInfo.ListClusterTemplates_BootstrapAction>();
				for (int j = 0; j < context.Length("ListClusterTemplates.TemplateInfoList["+ i +"].BootstrapActionList.Length"); j++) {
					ListClusterTemplatesResponse.ListClusterTemplates_TemplateInfo.ListClusterTemplates_BootstrapAction bootstrapAction = new ListClusterTemplatesResponse.ListClusterTemplates_TemplateInfo.ListClusterTemplates_BootstrapAction();
					bootstrapAction.Name = context.StringValue("ListClusterTemplates.TemplateInfoList["+ i +"].BootstrapActionList["+ j +"].Name");
					bootstrapAction.Path = context.StringValue("ListClusterTemplates.TemplateInfoList["+ i +"].BootstrapActionList["+ j +"].Path");
					bootstrapAction.Arg = context.StringValue("ListClusterTemplates.TemplateInfoList["+ i +"].BootstrapActionList["+ j +"].Arg");

					templateInfo_bootstrapActionList.Add(bootstrapAction);
				}
				templateInfo.BootstrapActionList = templateInfo_bootstrapActionList;

				List<ListClusterTemplatesResponse.ListClusterTemplates_TemplateInfo.ListClusterTemplates_HostGroup> templateInfo_hostGroupList = new List<ListClusterTemplatesResponse.ListClusterTemplates_TemplateInfo.ListClusterTemplates_HostGroup>();
				for (int j = 0; j < context.Length("ListClusterTemplates.TemplateInfoList["+ i +"].HostGroupList.Length"); j++) {
					ListClusterTemplatesResponse.ListClusterTemplates_TemplateInfo.ListClusterTemplates_HostGroup hostGroup = new ListClusterTemplatesResponse.ListClusterTemplates_TemplateInfo.ListClusterTemplates_HostGroup();
					hostGroup.HostGroupId = context.StringValue("ListClusterTemplates.TemplateInfoList["+ i +"].HostGroupList["+ j +"].HostGroupId");
					hostGroup.HostGroupName = context.StringValue("ListClusterTemplates.TemplateInfoList["+ i +"].HostGroupList["+ j +"].HostGroupName");
					hostGroup.HostGroupType = context.StringValue("ListClusterTemplates.TemplateInfoList["+ i +"].HostGroupList["+ j +"].HostGroupType");
					hostGroup.ChargeType = context.StringValue("ListClusterTemplates.TemplateInfoList["+ i +"].HostGroupList["+ j +"].ChargeType");
					hostGroup.Period = context.StringValue("ListClusterTemplates.TemplateInfoList["+ i +"].HostGroupList["+ j +"].Period");
					hostGroup.NodeCount = context.IntegerValue("ListClusterTemplates.TemplateInfoList["+ i +"].HostGroupList["+ j +"].NodeCount");
					hostGroup.InstanceType = context.StringValue("ListClusterTemplates.TemplateInfoList["+ i +"].HostGroupList["+ j +"].InstanceType");
					hostGroup.DiskType = context.StringValue("ListClusterTemplates.TemplateInfoList["+ i +"].HostGroupList["+ j +"].DiskType");
					hostGroup.DiskCapacity = context.IntegerValue("ListClusterTemplates.TemplateInfoList["+ i +"].HostGroupList["+ j +"].DiskCapacity");
					hostGroup.DiskCount = context.IntegerValue("ListClusterTemplates.TemplateInfoList["+ i +"].HostGroupList["+ j +"].DiskCount");
					hostGroup.SysDiskType = context.StringValue("ListClusterTemplates.TemplateInfoList["+ i +"].HostGroupList["+ j +"].SysDiskType");
					hostGroup.SysDiskCapacity = context.IntegerValue("ListClusterTemplates.TemplateInfoList["+ i +"].HostGroupList["+ j +"].SysDiskCapacity");
					hostGroup.MultiInstanceTypes = context.StringValue("ListClusterTemplates.TemplateInfoList["+ i +"].HostGroupList["+ j +"].MultiInstanceTypes");

					templateInfo_hostGroupList.Add(hostGroup);
				}
				templateInfo.HostGroupList = templateInfo_hostGroupList;

				List<ListClusterTemplatesResponse.ListClusterTemplates_TemplateInfo.ListClusterTemplates_Config> templateInfo_configList = new List<ListClusterTemplatesResponse.ListClusterTemplates_TemplateInfo.ListClusterTemplates_Config>();
				for (int j = 0; j < context.Length("ListClusterTemplates.TemplateInfoList["+ i +"].ConfigList.Length"); j++) {
					ListClusterTemplatesResponse.ListClusterTemplates_TemplateInfo.ListClusterTemplates_Config config = new ListClusterTemplatesResponse.ListClusterTemplates_TemplateInfo.ListClusterTemplates_Config();
					config.ServiceName = context.StringValue("ListClusterTemplates.TemplateInfoList["+ i +"].ConfigList["+ j +"].ServiceName");
					config.FileName = context.StringValue("ListClusterTemplates.TemplateInfoList["+ i +"].ConfigList["+ j +"].FileName");
					config.ConfigKey = context.StringValue("ListClusterTemplates.TemplateInfoList["+ i +"].ConfigList["+ j +"].ConfigKey");
					config.ConfigValue = context.StringValue("ListClusterTemplates.TemplateInfoList["+ i +"].ConfigList["+ j +"].ConfigValue");
					config.Encrypt = context.StringValue("ListClusterTemplates.TemplateInfoList["+ i +"].ConfigList["+ j +"].Encrypt");
					config.Replace = context.StringValue("ListClusterTemplates.TemplateInfoList["+ i +"].ConfigList["+ j +"].Replace");

					templateInfo_configList.Add(config);
				}
				templateInfo.ConfigList = templateInfo_configList;

				listClusterTemplatesResponse_templateInfoList.Add(templateInfo);
			}
			listClusterTemplatesResponse.TemplateInfoList = listClusterTemplatesResponse_templateInfoList;
        
			return listClusterTemplatesResponse;
        }
    }
}
