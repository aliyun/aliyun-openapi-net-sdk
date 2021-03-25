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
using Aliyun.Acs.sae.Model.V20190506;

namespace Aliyun.Acs.sae.Transform.V20190506
{
    public class DescribeApplicationConfigResponseUnmarshaller
    {
        public static DescribeApplicationConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeApplicationConfigResponse describeApplicationConfigResponse = new DescribeApplicationConfigResponse();

			describeApplicationConfigResponse.HttpResponse = _ctx.HttpResponse;
			describeApplicationConfigResponse.Message = _ctx.StringValue("DescribeApplicationConfig.Message");
			describeApplicationConfigResponse.RequestId = _ctx.StringValue("DescribeApplicationConfig.RequestId");
			describeApplicationConfigResponse.TraceId = _ctx.StringValue("DescribeApplicationConfig.TraceId");
			describeApplicationConfigResponse.ErrorCode = _ctx.StringValue("DescribeApplicationConfig.ErrorCode");
			describeApplicationConfigResponse.Code = _ctx.StringValue("DescribeApplicationConfig.Code");
			describeApplicationConfigResponse.Success = _ctx.BooleanValue("DescribeApplicationConfig.Success");

			DescribeApplicationConfigResponse.DescribeApplicationConfig_Data data = new DescribeApplicationConfigResponse.DescribeApplicationConfig_Data();
			data.Timezone = _ctx.StringValue("DescribeApplicationConfig.Data.Timezone");
			data.AppDescription = _ctx.StringValue("DescribeApplicationConfig.Data.AppDescription");
			data.PhpConfig = _ctx.StringValue("DescribeApplicationConfig.Data.PhpConfig");
			data.NasId = _ctx.StringValue("DescribeApplicationConfig.Data.NasId");
			data.WarStartOptions = _ctx.StringValue("DescribeApplicationConfig.Data.WarStartOptions");
			data.Liveness = _ctx.StringValue("DescribeApplicationConfig.Data.Liveness");
			data.Memory = _ctx.IntegerValue("DescribeApplicationConfig.Data.Memory");
			data.WebContainer = _ctx.StringValue("DescribeApplicationConfig.Data.WebContainer");
			data.SlsConfigs = _ctx.StringValue("DescribeApplicationConfig.Data.SlsConfigs");
			data.Cpu = _ctx.IntegerValue("DescribeApplicationConfig.Data.Cpu");
			data.PackageVersion = _ctx.StringValue("DescribeApplicationConfig.Data.PackageVersion");
			data.AppName = _ctx.StringValue("DescribeApplicationConfig.Data.AppName");
			data.Jdk = _ctx.StringValue("DescribeApplicationConfig.Data.Jdk");
			data.JarStartArgs = _ctx.StringValue("DescribeApplicationConfig.Data.JarStartArgs");
			data.MinReadyInstances = _ctx.IntegerValue("DescribeApplicationConfig.Data.MinReadyInstances");
			data.PreStop = _ctx.StringValue("DescribeApplicationConfig.Data.PreStop");
			data.Readiness = _ctx.StringValue("DescribeApplicationConfig.Data.Readiness");
			data.PhpArmsConfigLocation = _ctx.StringValue("DescribeApplicationConfig.Data.PhpArmsConfigLocation");
			data.PackageType = _ctx.StringValue("DescribeApplicationConfig.Data.PackageType");
			data.CommandArgs = _ctx.StringValue("DescribeApplicationConfig.Data.CommandArgs");
			data.AcrAssumeRoleArn = _ctx.StringValue("DescribeApplicationConfig.Data.AcrAssumeRoleArn");
			data.TerminationGracePeriodSeconds = _ctx.IntegerValue("DescribeApplicationConfig.Data.TerminationGracePeriodSeconds");
			data.Envs = _ctx.StringValue("DescribeApplicationConfig.Data.Envs");
			data.VSwitchId = _ctx.StringValue("DescribeApplicationConfig.Data.VSwitchId");
			data.SecurityGroupId = _ctx.StringValue("DescribeApplicationConfig.Data.SecurityGroupId");
			data.PostStart = _ctx.StringValue("DescribeApplicationConfig.Data.PostStart");
			data.ImageUrl = _ctx.StringValue("DescribeApplicationConfig.Data.ImageUrl");
			data.MountHost = _ctx.StringValue("DescribeApplicationConfig.Data.MountHost");
			data.JarStartOptions = _ctx.StringValue("DescribeApplicationConfig.Data.JarStartOptions");
			data.Replicas = _ctx.IntegerValue("DescribeApplicationConfig.Data.Replicas");
			data.CustomHostAlias = _ctx.StringValue("DescribeApplicationConfig.Data.CustomHostAlias");
			data.AppId = _ctx.StringValue("DescribeApplicationConfig.Data.AppId");
			data.VpcId = _ctx.StringValue("DescribeApplicationConfig.Data.VpcId");
			data.EdasContainerVersion = _ctx.StringValue("DescribeApplicationConfig.Data.EdasContainerVersion");
			data.Command = _ctx.StringValue("DescribeApplicationConfig.Data.Command");
			data.PhpConfigLocation = _ctx.StringValue("DescribeApplicationConfig.Data.PhpConfigLocation");
			data.PackageUrl = _ctx.StringValue("DescribeApplicationConfig.Data.PackageUrl");
			data.BatchWaitTime = _ctx.IntegerValue("DescribeApplicationConfig.Data.BatchWaitTime");
			data.RegionId = _ctx.StringValue("DescribeApplicationConfig.Data.RegionId");
			data.NamespaceId = _ctx.StringValue("DescribeApplicationConfig.Data.NamespaceId");
			data.EnableAhas = _ctx.StringValue("DescribeApplicationConfig.Data.EnableAhas");
			data.TomcatConfig = _ctx.StringValue("DescribeApplicationConfig.Data.TomcatConfig");

			List<DescribeApplicationConfigResponse.DescribeApplicationConfig_Data.DescribeApplicationConfig_MountDescItem> data_mountDesc = new List<DescribeApplicationConfigResponse.DescribeApplicationConfig_Data.DescribeApplicationConfig_MountDescItem>();
			for (int i = 0; i < _ctx.Length("DescribeApplicationConfig.Data.MountDesc.Length"); i++) {
				DescribeApplicationConfigResponse.DescribeApplicationConfig_Data.DescribeApplicationConfig_MountDescItem mountDescItem = new DescribeApplicationConfigResponse.DescribeApplicationConfig_Data.DescribeApplicationConfig_MountDescItem();
				mountDescItem.MountPath = _ctx.StringValue("DescribeApplicationConfig.Data.MountDesc["+ i +"].MountPath");
				mountDescItem.NasPath = _ctx.StringValue("DescribeApplicationConfig.Data.MountDesc["+ i +"].NasPath");

				data_mountDesc.Add(mountDescItem);
			}
			data.MountDesc = data_mountDesc;

			List<DescribeApplicationConfigResponse.DescribeApplicationConfig_Data.DescribeApplicationConfig_Tag> data_tags = new List<DescribeApplicationConfigResponse.DescribeApplicationConfig_Data.DescribeApplicationConfig_Tag>();
			for (int i = 0; i < _ctx.Length("DescribeApplicationConfig.Data.Tags.Length"); i++) {
				DescribeApplicationConfigResponse.DescribeApplicationConfig_Data.DescribeApplicationConfig_Tag tag = new DescribeApplicationConfigResponse.DescribeApplicationConfig_Data.DescribeApplicationConfig_Tag();
				tag._Value = _ctx.StringValue("DescribeApplicationConfig.Data.Tags["+ i +"].Value");
				tag.Key = _ctx.StringValue("DescribeApplicationConfig.Data.Tags["+ i +"].Key");

				data_tags.Add(tag);
			}
			data.Tags = data_tags;

			List<DescribeApplicationConfigResponse.DescribeApplicationConfig_Data.DescribeApplicationConfig_ConfigMapMountDescItem> data_configMapMountDesc = new List<DescribeApplicationConfigResponse.DescribeApplicationConfig_Data.DescribeApplicationConfig_ConfigMapMountDescItem>();
			for (int i = 0; i < _ctx.Length("DescribeApplicationConfig.Data.ConfigMapMountDesc.Length"); i++) {
				DescribeApplicationConfigResponse.DescribeApplicationConfig_Data.DescribeApplicationConfig_ConfigMapMountDescItem configMapMountDescItem = new DescribeApplicationConfigResponse.DescribeApplicationConfig_Data.DescribeApplicationConfig_ConfigMapMountDescItem();
				configMapMountDescItem.MountPath = _ctx.StringValue("DescribeApplicationConfig.Data.ConfigMapMountDesc["+ i +"].MountPath");
				configMapMountDescItem.ConfigMapId = _ctx.LongValue("DescribeApplicationConfig.Data.ConfigMapMountDesc["+ i +"].ConfigMapId");
				configMapMountDescItem.ConfigMapName = _ctx.StringValue("DescribeApplicationConfig.Data.ConfigMapMountDesc["+ i +"].ConfigMapName");
				configMapMountDescItem.Key = _ctx.StringValue("DescribeApplicationConfig.Data.ConfigMapMountDesc["+ i +"].Key");

				data_configMapMountDesc.Add(configMapMountDescItem);
			}
			data.ConfigMapMountDesc = data_configMapMountDesc;
			describeApplicationConfigResponse.Data = data;
        
			return describeApplicationConfigResponse;
        }
    }
}
