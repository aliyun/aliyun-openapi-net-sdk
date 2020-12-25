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
        public static DescribeClusterTemplateResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeClusterTemplateResponse describeClusterTemplateResponse = new DescribeClusterTemplateResponse();

			describeClusterTemplateResponse.HttpResponse = _ctx.HttpResponse;
			describeClusterTemplateResponse.RequestId = _ctx.StringValue("DescribeClusterTemplate.RequestId");

			DescribeClusterTemplateResponse.DescribeClusterTemplate_TemplateInfo templateInfo = new DescribeClusterTemplateResponse.DescribeClusterTemplate_TemplateInfo();
			templateInfo.Id = _ctx.StringValue("DescribeClusterTemplate.TemplateInfo.Id");
			templateInfo.TemplateName = _ctx.StringValue("DescribeClusterTemplate.TemplateInfo.TemplateName");
			templateInfo.EmrVer = _ctx.StringValue("DescribeClusterTemplate.TemplateInfo.EmrVer");
			templateInfo.LogEnable = _ctx.BooleanValue("DescribeClusterTemplate.TemplateInfo.LogEnable");
			templateInfo.LogPath = _ctx.StringValue("DescribeClusterTemplate.TemplateInfo.LogPath");
			templateInfo.UserId = _ctx.StringValue("DescribeClusterTemplate.TemplateInfo.UserId");
			templateInfo.UserDefinedEmrEcsRole = _ctx.StringValue("DescribeClusterTemplate.TemplateInfo.UserDefinedEmrEcsRole");
			templateInfo.MasterNodeTotal = _ctx.IntegerValue("DescribeClusterTemplate.TemplateInfo.MasterNodeTotal");
			templateInfo.VpcId = _ctx.StringValue("DescribeClusterTemplate.TemplateInfo.VpcId");
			templateInfo.VSwitchId = _ctx.StringValue("DescribeClusterTemplate.TemplateInfo.VSwitchId");
			templateInfo.NetType = _ctx.StringValue("DescribeClusterTemplate.TemplateInfo.NetType");
			templateInfo.IoOptimized = _ctx.BooleanValue("DescribeClusterTemplate.TemplateInfo.IoOptimized");
			templateInfo.InstanceGeneration = _ctx.StringValue("DescribeClusterTemplate.TemplateInfo.InstanceGeneration");
			templateInfo.HighAvailabilityEnable = _ctx.BooleanValue("DescribeClusterTemplate.TemplateInfo.HighAvailabilityEnable");
			templateInfo.EasEnable = _ctx.BooleanValue("DescribeClusterTemplate.TemplateInfo.EasEnable");
			templateInfo.GmtCreate = _ctx.LongValue("DescribeClusterTemplate.TemplateInfo.GmtCreate");
			templateInfo.GmtModified = _ctx.LongValue("DescribeClusterTemplate.TemplateInfo.GmtModified");
			templateInfo.ZoneId = _ctx.StringValue("DescribeClusterTemplate.TemplateInfo.ZoneId");
			templateInfo.ClusterType = _ctx.StringValue("DescribeClusterTemplate.TemplateInfo.ClusterType");
			templateInfo.SecurityGroupId = _ctx.StringValue("DescribeClusterTemplate.TemplateInfo.SecurityGroupId");
			templateInfo.SecurityGroupName = _ctx.StringValue("DescribeClusterTemplate.TemplateInfo.SecurityGroupName");
			templateInfo.Configurations = _ctx.StringValue("DescribeClusterTemplate.TemplateInfo.Configurations");
			templateInfo.AllowNotebook = _ctx.BooleanValue("DescribeClusterTemplate.TemplateInfo.AllowNotebook");
			templateInfo.CreateSource = _ctx.StringValue("DescribeClusterTemplate.TemplateInfo.CreateSource");
			templateInfo.UseLocalMetaDb = _ctx.BooleanValue("DescribeClusterTemplate.TemplateInfo.UseLocalMetaDb");
			templateInfo.SshEnable = _ctx.BooleanValue("DescribeClusterTemplate.TemplateInfo.SshEnable");
			templateInfo.IsOpenPublicIp = _ctx.BooleanValue("DescribeClusterTemplate.TemplateInfo.IsOpenPublicIp");
			templateInfo.DepositType = _ctx.StringValue("DescribeClusterTemplate.TemplateInfo.DepositType");
			templateInfo.MachineType = _ctx.StringValue("DescribeClusterTemplate.TemplateInfo.MachineType");
			templateInfo.UseCustomHiveMetaDb = _ctx.BooleanValue("DescribeClusterTemplate.TemplateInfo.UseCustomHiveMetaDb");
			templateInfo.InitCustomHiveMetaDb = _ctx.BooleanValue("DescribeClusterTemplate.TemplateInfo.InitCustomHiveMetaDb");
			templateInfo.KeyPairName = _ctx.StringValue("DescribeClusterTemplate.TemplateInfo.KeyPairName");
			templateInfo.MasterPwd = _ctx.StringValue("DescribeClusterTemplate.TemplateInfo.MasterPwd");
			templateInfo.MetaStoreType = _ctx.StringValue("DescribeClusterTemplate.TemplateInfo.MetaStoreType");
			templateInfo.MetaStoreConf = _ctx.StringValue("DescribeClusterTemplate.TemplateInfo.MetaStoreConf");

			List<string> templateInfo_softwareInfoList = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeClusterTemplate.TemplateInfo.SoftwareInfoList.Length"); i++) {
				templateInfo_softwareInfoList.Add(_ctx.StringValue("DescribeClusterTemplate.TemplateInfo.SoftwareInfoList["+ i +"]"));
			}
			templateInfo.SoftwareInfoList = templateInfo_softwareInfoList;

			List<DescribeClusterTemplateResponse.DescribeClusterTemplate_TemplateInfo.DescribeClusterTemplate_BootstrapAction> templateInfo_bootstrapActionList = new List<DescribeClusterTemplateResponse.DescribeClusterTemplate_TemplateInfo.DescribeClusterTemplate_BootstrapAction>();
			for (int i = 0; i < _ctx.Length("DescribeClusterTemplate.TemplateInfo.BootstrapActionList.Length"); i++) {
				DescribeClusterTemplateResponse.DescribeClusterTemplate_TemplateInfo.DescribeClusterTemplate_BootstrapAction bootstrapAction = new DescribeClusterTemplateResponse.DescribeClusterTemplate_TemplateInfo.DescribeClusterTemplate_BootstrapAction();
				bootstrapAction.Name = _ctx.StringValue("DescribeClusterTemplate.TemplateInfo.BootstrapActionList["+ i +"].Name");
				bootstrapAction.Path = _ctx.StringValue("DescribeClusterTemplate.TemplateInfo.BootstrapActionList["+ i +"].Path");
				bootstrapAction.Arg = _ctx.StringValue("DescribeClusterTemplate.TemplateInfo.BootstrapActionList["+ i +"].Arg");

				templateInfo_bootstrapActionList.Add(bootstrapAction);
			}
			templateInfo.BootstrapActionList = templateInfo_bootstrapActionList;

			List<DescribeClusterTemplateResponse.DescribeClusterTemplate_TemplateInfo.DescribeClusterTemplate_HostGroup> templateInfo_hostGroupList = new List<DescribeClusterTemplateResponse.DescribeClusterTemplate_TemplateInfo.DescribeClusterTemplate_HostGroup>();
			for (int i = 0; i < _ctx.Length("DescribeClusterTemplate.TemplateInfo.HostGroupList.Length"); i++) {
				DescribeClusterTemplateResponse.DescribeClusterTemplate_TemplateInfo.DescribeClusterTemplate_HostGroup hostGroup = new DescribeClusterTemplateResponse.DescribeClusterTemplate_TemplateInfo.DescribeClusterTemplate_HostGroup();
				hostGroup.HostGroupId = _ctx.StringValue("DescribeClusterTemplate.TemplateInfo.HostGroupList["+ i +"].HostGroupId");
				hostGroup.HostGroupName = _ctx.StringValue("DescribeClusterTemplate.TemplateInfo.HostGroupList["+ i +"].HostGroupName");
				hostGroup.HostGroupType = _ctx.StringValue("DescribeClusterTemplate.TemplateInfo.HostGroupList["+ i +"].HostGroupType");
				hostGroup.ChargeType = _ctx.StringValue("DescribeClusterTemplate.TemplateInfo.HostGroupList["+ i +"].ChargeType");
				hostGroup.Period = _ctx.StringValue("DescribeClusterTemplate.TemplateInfo.HostGroupList["+ i +"].Period");
				hostGroup.NodeCount = _ctx.IntegerValue("DescribeClusterTemplate.TemplateInfo.HostGroupList["+ i +"].NodeCount");
				hostGroup.InstanceType = _ctx.StringValue("DescribeClusterTemplate.TemplateInfo.HostGroupList["+ i +"].InstanceType");
				hostGroup.DiskType = _ctx.StringValue("DescribeClusterTemplate.TemplateInfo.HostGroupList["+ i +"].DiskType");
				hostGroup.DiskCapacity = _ctx.IntegerValue("DescribeClusterTemplate.TemplateInfo.HostGroupList["+ i +"].DiskCapacity");
				hostGroup.DiskCount = _ctx.IntegerValue("DescribeClusterTemplate.TemplateInfo.HostGroupList["+ i +"].DiskCount");
				hostGroup.SysDiskType = _ctx.StringValue("DescribeClusterTemplate.TemplateInfo.HostGroupList["+ i +"].SysDiskType");
				hostGroup.SysDiskCapacity = _ctx.IntegerValue("DescribeClusterTemplate.TemplateInfo.HostGroupList["+ i +"].SysDiskCapacity");
				hostGroup.MultiInstanceTypes = _ctx.StringValue("DescribeClusterTemplate.TemplateInfo.HostGroupList["+ i +"].MultiInstanceTypes");

				templateInfo_hostGroupList.Add(hostGroup);
			}
			templateInfo.HostGroupList = templateInfo_hostGroupList;

			List<DescribeClusterTemplateResponse.DescribeClusterTemplate_TemplateInfo.DescribeClusterTemplate_Config> templateInfo_configList = new List<DescribeClusterTemplateResponse.DescribeClusterTemplate_TemplateInfo.DescribeClusterTemplate_Config>();
			for (int i = 0; i < _ctx.Length("DescribeClusterTemplate.TemplateInfo.ConfigList.Length"); i++) {
				DescribeClusterTemplateResponse.DescribeClusterTemplate_TemplateInfo.DescribeClusterTemplate_Config config = new DescribeClusterTemplateResponse.DescribeClusterTemplate_TemplateInfo.DescribeClusterTemplate_Config();
				config.ServiceName = _ctx.StringValue("DescribeClusterTemplate.TemplateInfo.ConfigList["+ i +"].ServiceName");
				config.FileName = _ctx.StringValue("DescribeClusterTemplate.TemplateInfo.ConfigList["+ i +"].FileName");
				config.ConfigKey = _ctx.StringValue("DescribeClusterTemplate.TemplateInfo.ConfigList["+ i +"].ConfigKey");
				config.ConfigValue = _ctx.StringValue("DescribeClusterTemplate.TemplateInfo.ConfigList["+ i +"].ConfigValue");
				config.Encrypt = _ctx.StringValue("DescribeClusterTemplate.TemplateInfo.ConfigList["+ i +"].Encrypt");
				config.Replace = _ctx.StringValue("DescribeClusterTemplate.TemplateInfo.ConfigList["+ i +"].Replace");

				templateInfo_configList.Add(config);
			}
			templateInfo.ConfigList = templateInfo_configList;

			List<DescribeClusterTemplateResponse.DescribeClusterTemplate_TemplateInfo.DescribeClusterTemplate_Tag> templateInfo_tags = new List<DescribeClusterTemplateResponse.DescribeClusterTemplate_TemplateInfo.DescribeClusterTemplate_Tag>();
			for (int i = 0; i < _ctx.Length("DescribeClusterTemplate.TemplateInfo.Tags.Length"); i++) {
				DescribeClusterTemplateResponse.DescribeClusterTemplate_TemplateInfo.DescribeClusterTemplate_Tag tag = new DescribeClusterTemplateResponse.DescribeClusterTemplate_TemplateInfo.DescribeClusterTemplate_Tag();
				tag.TagKey = _ctx.StringValue("DescribeClusterTemplate.TemplateInfo.Tags["+ i +"].TagKey");
				tag.TagValue = _ctx.StringValue("DescribeClusterTemplate.TemplateInfo.Tags["+ i +"].TagValue");

				templateInfo_tags.Add(tag);
			}
			templateInfo.Tags = templateInfo_tags;
			describeClusterTemplateResponse.TemplateInfo = templateInfo;
        
			return describeClusterTemplateResponse;
        }
    }
}
