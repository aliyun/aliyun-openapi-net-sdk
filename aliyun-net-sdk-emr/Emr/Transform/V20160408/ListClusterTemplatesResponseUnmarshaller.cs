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
        public static ListClusterTemplatesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListClusterTemplatesResponse listClusterTemplatesResponse = new ListClusterTemplatesResponse();

			listClusterTemplatesResponse.HttpResponse = _ctx.HttpResponse;
			listClusterTemplatesResponse.RequestId = _ctx.StringValue("ListClusterTemplates.RequestId");
			listClusterTemplatesResponse.TotalCount = _ctx.IntegerValue("ListClusterTemplates.TotalCount");
			listClusterTemplatesResponse.PageNumber = _ctx.IntegerValue("ListClusterTemplates.PageNumber");
			listClusterTemplatesResponse.PageSize = _ctx.IntegerValue("ListClusterTemplates.PageSize");

			List<ListClusterTemplatesResponse.ListClusterTemplates_TemplateInfo> listClusterTemplatesResponse_templateInfoList = new List<ListClusterTemplatesResponse.ListClusterTemplates_TemplateInfo>();
			for (int i = 0; i < _ctx.Length("ListClusterTemplates.TemplateInfoList.Length"); i++) {
				ListClusterTemplatesResponse.ListClusterTemplates_TemplateInfo templateInfo = new ListClusterTemplatesResponse.ListClusterTemplates_TemplateInfo();
				templateInfo.Id = _ctx.StringValue("ListClusterTemplates.TemplateInfoList["+ i +"].Id");
				templateInfo.TemplateName = _ctx.StringValue("ListClusterTemplates.TemplateInfoList["+ i +"].TemplateName");
				templateInfo.LogEnable = _ctx.BooleanValue("ListClusterTemplates.TemplateInfoList["+ i +"].LogEnable");
				templateInfo.LogPath = _ctx.StringValue("ListClusterTemplates.TemplateInfoList["+ i +"].LogPath");
				templateInfo.UserId = _ctx.StringValue("ListClusterTemplates.TemplateInfoList["+ i +"].UserId");
				templateInfo.UserDefinedEmrEcsRole = _ctx.StringValue("ListClusterTemplates.TemplateInfoList["+ i +"].UserDefinedEmrEcsRole");
				templateInfo.MasterNodeTotal = _ctx.IntegerValue("ListClusterTemplates.TemplateInfoList["+ i +"].MasterNodeTotal");
				templateInfo.VpcId = _ctx.StringValue("ListClusterTemplates.TemplateInfoList["+ i +"].VpcId");
				templateInfo.VSwitchId = _ctx.StringValue("ListClusterTemplates.TemplateInfoList["+ i +"].VSwitchId");
				templateInfo.NetType = _ctx.StringValue("ListClusterTemplates.TemplateInfoList["+ i +"].NetType");
				templateInfo.IoOptimized = _ctx.BooleanValue("ListClusterTemplates.TemplateInfoList["+ i +"].IoOptimized");
				templateInfo.InstanceGeneration = _ctx.StringValue("ListClusterTemplates.TemplateInfoList["+ i +"].InstanceGeneration");
				templateInfo.HighAvailabilityEnable = _ctx.BooleanValue("ListClusterTemplates.TemplateInfoList["+ i +"].HighAvailabilityEnable");
				templateInfo.EasEnable = _ctx.BooleanValue("ListClusterTemplates.TemplateInfoList["+ i +"].EasEnable");
				templateInfo.GmtCreate = _ctx.LongValue("ListClusterTemplates.TemplateInfoList["+ i +"].GmtCreate");
				templateInfo.GmtModified = _ctx.LongValue("ListClusterTemplates.TemplateInfoList["+ i +"].GmtModified");
				templateInfo.ZoneId = _ctx.StringValue("ListClusterTemplates.TemplateInfoList["+ i +"].ZoneId");
				templateInfo.ClusterType = _ctx.StringValue("ListClusterTemplates.TemplateInfoList["+ i +"].ClusterType");
				templateInfo.SecurityGroupId = _ctx.StringValue("ListClusterTemplates.TemplateInfoList["+ i +"].SecurityGroupId");
				templateInfo.SecurityGroupName = _ctx.StringValue("ListClusterTemplates.TemplateInfoList["+ i +"].SecurityGroupName");
				templateInfo.Configurations = _ctx.StringValue("ListClusterTemplates.TemplateInfoList["+ i +"].Configurations");
				templateInfo.AllowNotebook = _ctx.BooleanValue("ListClusterTemplates.TemplateInfoList["+ i +"].AllowNotebook");
				templateInfo.CreateSource = _ctx.StringValue("ListClusterTemplates.TemplateInfoList["+ i +"].CreateSource");
				templateInfo.UseLocalMetaDb = _ctx.BooleanValue("ListClusterTemplates.TemplateInfoList["+ i +"].UseLocalMetaDb");
				templateInfo.SshEnable = _ctx.BooleanValue("ListClusterTemplates.TemplateInfoList["+ i +"].SshEnable");
				templateInfo.IsOpenPublicIp = _ctx.BooleanValue("ListClusterTemplates.TemplateInfoList["+ i +"].IsOpenPublicIp");
				templateInfo.DepositType = _ctx.StringValue("ListClusterTemplates.TemplateInfoList["+ i +"].DepositType");
				templateInfo.MachineType = _ctx.StringValue("ListClusterTemplates.TemplateInfoList["+ i +"].MachineType");
				templateInfo.UseCustomHiveMetaDb = _ctx.BooleanValue("ListClusterTemplates.TemplateInfoList["+ i +"].UseCustomHiveMetaDb");
				templateInfo.InitCustomHiveMetaDb = _ctx.BooleanValue("ListClusterTemplates.TemplateInfoList["+ i +"].InitCustomHiveMetaDb");
				templateInfo.KeyPairName = _ctx.StringValue("ListClusterTemplates.TemplateInfoList["+ i +"].KeyPairName");
				templateInfo.MetaStoreType = _ctx.StringValue("ListClusterTemplates.TemplateInfoList["+ i +"].MetaStoreType");
				templateInfo.MetaStoreConf = _ctx.StringValue("ListClusterTemplates.TemplateInfoList["+ i +"].MetaStoreConf");

				List<string> templateInfo_softwareInfoList = new List<string>();
				for (int j = 0; j < _ctx.Length("ListClusterTemplates.TemplateInfoList["+ i +"].SoftwareInfoList.Length"); j++) {
					templateInfo_softwareInfoList.Add(_ctx.StringValue("ListClusterTemplates.TemplateInfoList["+ i +"].SoftwareInfoList["+ j +"]"));
				}
				templateInfo.SoftwareInfoList = templateInfo_softwareInfoList;

				List<ListClusterTemplatesResponse.ListClusterTemplates_TemplateInfo.ListClusterTemplates_BootstrapAction> templateInfo_bootstrapActionList = new List<ListClusterTemplatesResponse.ListClusterTemplates_TemplateInfo.ListClusterTemplates_BootstrapAction>();
				for (int j = 0; j < _ctx.Length("ListClusterTemplates.TemplateInfoList["+ i +"].BootstrapActionList.Length"); j++) {
					ListClusterTemplatesResponse.ListClusterTemplates_TemplateInfo.ListClusterTemplates_BootstrapAction bootstrapAction = new ListClusterTemplatesResponse.ListClusterTemplates_TemplateInfo.ListClusterTemplates_BootstrapAction();
					bootstrapAction.Name = _ctx.StringValue("ListClusterTemplates.TemplateInfoList["+ i +"].BootstrapActionList["+ j +"].Name");
					bootstrapAction.Path = _ctx.StringValue("ListClusterTemplates.TemplateInfoList["+ i +"].BootstrapActionList["+ j +"].Path");
					bootstrapAction.Arg = _ctx.StringValue("ListClusterTemplates.TemplateInfoList["+ i +"].BootstrapActionList["+ j +"].Arg");

					templateInfo_bootstrapActionList.Add(bootstrapAction);
				}
				templateInfo.BootstrapActionList = templateInfo_bootstrapActionList;

				List<ListClusterTemplatesResponse.ListClusterTemplates_TemplateInfo.ListClusterTemplates_HostGroup> templateInfo_hostGroupList = new List<ListClusterTemplatesResponse.ListClusterTemplates_TemplateInfo.ListClusterTemplates_HostGroup>();
				for (int j = 0; j < _ctx.Length("ListClusterTemplates.TemplateInfoList["+ i +"].HostGroupList.Length"); j++) {
					ListClusterTemplatesResponse.ListClusterTemplates_TemplateInfo.ListClusterTemplates_HostGroup hostGroup = new ListClusterTemplatesResponse.ListClusterTemplates_TemplateInfo.ListClusterTemplates_HostGroup();
					hostGroup.HostGroupId = _ctx.StringValue("ListClusterTemplates.TemplateInfoList["+ i +"].HostGroupList["+ j +"].HostGroupId");
					hostGroup.HostGroupName = _ctx.StringValue("ListClusterTemplates.TemplateInfoList["+ i +"].HostGroupList["+ j +"].HostGroupName");
					hostGroup.HostGroupType = _ctx.StringValue("ListClusterTemplates.TemplateInfoList["+ i +"].HostGroupList["+ j +"].HostGroupType");
					hostGroup.ChargeType = _ctx.StringValue("ListClusterTemplates.TemplateInfoList["+ i +"].HostGroupList["+ j +"].ChargeType");
					hostGroup.Period = _ctx.StringValue("ListClusterTemplates.TemplateInfoList["+ i +"].HostGroupList["+ j +"].Period");
					hostGroup.NodeCount = _ctx.IntegerValue("ListClusterTemplates.TemplateInfoList["+ i +"].HostGroupList["+ j +"].NodeCount");
					hostGroup.InstanceType = _ctx.StringValue("ListClusterTemplates.TemplateInfoList["+ i +"].HostGroupList["+ j +"].InstanceType");
					hostGroup.DiskType = _ctx.StringValue("ListClusterTemplates.TemplateInfoList["+ i +"].HostGroupList["+ j +"].DiskType");
					hostGroup.DiskCapacity = _ctx.IntegerValue("ListClusterTemplates.TemplateInfoList["+ i +"].HostGroupList["+ j +"].DiskCapacity");
					hostGroup.DiskCount = _ctx.IntegerValue("ListClusterTemplates.TemplateInfoList["+ i +"].HostGroupList["+ j +"].DiskCount");
					hostGroup.SysDiskType = _ctx.StringValue("ListClusterTemplates.TemplateInfoList["+ i +"].HostGroupList["+ j +"].SysDiskType");
					hostGroup.SysDiskCapacity = _ctx.IntegerValue("ListClusterTemplates.TemplateInfoList["+ i +"].HostGroupList["+ j +"].SysDiskCapacity");
					hostGroup.MultiInstanceTypes = _ctx.StringValue("ListClusterTemplates.TemplateInfoList["+ i +"].HostGroupList["+ j +"].MultiInstanceTypes");

					templateInfo_hostGroupList.Add(hostGroup);
				}
				templateInfo.HostGroupList = templateInfo_hostGroupList;

				List<ListClusterTemplatesResponse.ListClusterTemplates_TemplateInfo.ListClusterTemplates_Config> templateInfo_configList = new List<ListClusterTemplatesResponse.ListClusterTemplates_TemplateInfo.ListClusterTemplates_Config>();
				for (int j = 0; j < _ctx.Length("ListClusterTemplates.TemplateInfoList["+ i +"].ConfigList.Length"); j++) {
					ListClusterTemplatesResponse.ListClusterTemplates_TemplateInfo.ListClusterTemplates_Config config = new ListClusterTemplatesResponse.ListClusterTemplates_TemplateInfo.ListClusterTemplates_Config();
					config.ServiceName = _ctx.StringValue("ListClusterTemplates.TemplateInfoList["+ i +"].ConfigList["+ j +"].ServiceName");
					config.FileName = _ctx.StringValue("ListClusterTemplates.TemplateInfoList["+ i +"].ConfigList["+ j +"].FileName");
					config.ConfigKey = _ctx.StringValue("ListClusterTemplates.TemplateInfoList["+ i +"].ConfigList["+ j +"].ConfigKey");
					config.ConfigValue = _ctx.StringValue("ListClusterTemplates.TemplateInfoList["+ i +"].ConfigList["+ j +"].ConfigValue");
					config.Encrypt = _ctx.StringValue("ListClusterTemplates.TemplateInfoList["+ i +"].ConfigList["+ j +"].Encrypt");
					config.Replace = _ctx.StringValue("ListClusterTemplates.TemplateInfoList["+ i +"].ConfigList["+ j +"].Replace");

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
