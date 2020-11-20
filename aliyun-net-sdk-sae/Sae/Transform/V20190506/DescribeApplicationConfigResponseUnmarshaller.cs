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
        public static DescribeApplicationConfigResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeApplicationConfigResponse describeApplicationConfigResponse = new DescribeApplicationConfigResponse();

			describeApplicationConfigResponse.HttpResponse = context.HttpResponse;
			describeApplicationConfigResponse.Code = context.StringValue("DescribeApplicationConfig.Code");
			describeApplicationConfigResponse.Message = context.StringValue("DescribeApplicationConfig.Message");
			describeApplicationConfigResponse.TraceId = context.StringValue("DescribeApplicationConfig.TraceId");
			describeApplicationConfigResponse.RequestId = context.StringValue("DescribeApplicationConfig.RequestId");
			describeApplicationConfigResponse.Success = context.BooleanValue("DescribeApplicationConfig.Success");
			describeApplicationConfigResponse.ErrorCode = context.StringValue("DescribeApplicationConfig.ErrorCode");

			DescribeApplicationConfigResponse.DescribeApplicationConfig_Data data = new DescribeApplicationConfigResponse.DescribeApplicationConfig_Data();
			data.AppId = context.StringValue("DescribeApplicationConfig.Data.AppId");
			data.AppName = context.StringValue("DescribeApplicationConfig.Data.AppName");
			data.NamespaceId = context.StringValue("DescribeApplicationConfig.Data.NamespaceId");
			data.AppDescription = context.StringValue("DescribeApplicationConfig.Data.AppDescription");
			data.VpcId = context.StringValue("DescribeApplicationConfig.Data.VpcId");
			data.VSwitchId = context.StringValue("DescribeApplicationConfig.Data.VSwitchId");
			data.PackageType = context.StringValue("DescribeApplicationConfig.Data.PackageType");
			data.PackageVersion = context.StringValue("DescribeApplicationConfig.Data.PackageVersion");
			data.PackageUrl = context.StringValue("DescribeApplicationConfig.Data.PackageUrl");
			data.ImageUrl = context.StringValue("DescribeApplicationConfig.Data.ImageUrl");
			data.Jdk = context.StringValue("DescribeApplicationConfig.Data.Jdk");
			data.WebContainer = context.StringValue("DescribeApplicationConfig.Data.WebContainer");
			data.Cpu = context.IntegerValue("DescribeApplicationConfig.Data.Cpu");
			data.Memory = context.IntegerValue("DescribeApplicationConfig.Data.Memory");
			data.Replicas = context.IntegerValue("DescribeApplicationConfig.Data.Replicas");
			data.Command = context.StringValue("DescribeApplicationConfig.Data.Command");
			data.CommandArgs = context.StringValue("DescribeApplicationConfig.Data.CommandArgs");
			data.Envs = context.StringValue("DescribeApplicationConfig.Data.Envs");
			data.CustomHostAlias = context.StringValue("DescribeApplicationConfig.Data.CustomHostAlias");
			data.JarStartOptions = context.StringValue("DescribeApplicationConfig.Data.JarStartOptions");
			data.JarStartArgs = context.StringValue("DescribeApplicationConfig.Data.JarStartArgs");
			data.Liveness = context.StringValue("DescribeApplicationConfig.Data.Liveness");
			data.Readiness = context.StringValue("DescribeApplicationConfig.Data.Readiness");
			data.MinReadyInstances = context.IntegerValue("DescribeApplicationConfig.Data.MinReadyInstances");
			data.BatchWaitTime = context.IntegerValue("DescribeApplicationConfig.Data.BatchWaitTime");
			data.EdasContainerVersion = context.StringValue("DescribeApplicationConfig.Data.EdasContainerVersion");
			data.RegionId = context.StringValue("DescribeApplicationConfig.Data.RegionId");
			data.SlsConfigs = context.StringValue("DescribeApplicationConfig.Data.SlsConfigs");
			data.Timezone = context.StringValue("DescribeApplicationConfig.Data.Timezone");
			data.NasId = context.StringValue("DescribeApplicationConfig.Data.NasId");
			data.MountHost = context.StringValue("DescribeApplicationConfig.Data.MountHost");
			data.PreStop = context.StringValue("DescribeApplicationConfig.Data.PreStop");
			data.PostStart = context.StringValue("DescribeApplicationConfig.Data.PostStart");
			data.WarStartOptions = context.StringValue("DescribeApplicationConfig.Data.WarStartOptions");
			data.SecurityGroupId = context.StringValue("DescribeApplicationConfig.Data.SecurityGroupId");
			data.TerminationGracePeriodSeconds = context.IntegerValue("DescribeApplicationConfig.Data.TerminationGracePeriodSeconds");
			data.EnableAhas = context.StringValue("DescribeApplicationConfig.Data.EnableAhas");
			data.PhpArmsConfigLocation = context.StringValue("DescribeApplicationConfig.Data.PhpArmsConfigLocation");
			data.PhpConfigLocation = context.StringValue("DescribeApplicationConfig.Data.PhpConfigLocation");
			data.PhpConfig = context.StringValue("DescribeApplicationConfig.Data.PhpConfig");
			data.TomcatConfig = context.StringValue("DescribeApplicationConfig.Data.TomcatConfig");

			List<DescribeApplicationConfigResponse.DescribeApplicationConfig_Data.DescribeApplicationConfig_MountDescItem> data_mountDesc = new List<DescribeApplicationConfigResponse.DescribeApplicationConfig_Data.DescribeApplicationConfig_MountDescItem>();
			for (int i = 0; i < context.Length("DescribeApplicationConfig.Data.MountDesc.Length"); i++) {
				DescribeApplicationConfigResponse.DescribeApplicationConfig_Data.DescribeApplicationConfig_MountDescItem mountDescItem = new DescribeApplicationConfigResponse.DescribeApplicationConfig_Data.DescribeApplicationConfig_MountDescItem();
				mountDescItem.NasPath = context.StringValue("DescribeApplicationConfig.Data.MountDesc["+ i +"].NasPath");
				mountDescItem.MountPath = context.StringValue("DescribeApplicationConfig.Data.MountDesc["+ i +"].MountPath");

				data_mountDesc.Add(mountDescItem);
			}
			data.MountDesc = data_mountDesc;

			List<DescribeApplicationConfigResponse.DescribeApplicationConfig_Data.DescribeApplicationConfig_Tag> data_tags = new List<DescribeApplicationConfigResponse.DescribeApplicationConfig_Data.DescribeApplicationConfig_Tag>();
			for (int i = 0; i < context.Length("DescribeApplicationConfig.Data.Tags.Length"); i++) {
				DescribeApplicationConfigResponse.DescribeApplicationConfig_Data.DescribeApplicationConfig_Tag tag = new DescribeApplicationConfigResponse.DescribeApplicationConfig_Data.DescribeApplicationConfig_Tag();
				tag.Key = context.StringValue("DescribeApplicationConfig.Data.Tags["+ i +"].Key");
				tag._Value = context.StringValue("DescribeApplicationConfig.Data.Tags["+ i +"].Value");

				data_tags.Add(tag);
			}
			data.Tags = data_tags;

			List<DescribeApplicationConfigResponse.DescribeApplicationConfig_Data.DescribeApplicationConfig_ConfigMapMountDescItem> data_configMapMountDesc = new List<DescribeApplicationConfigResponse.DescribeApplicationConfig_Data.DescribeApplicationConfig_ConfigMapMountDescItem>();
			for (int i = 0; i < context.Length("DescribeApplicationConfig.Data.ConfigMapMountDesc.Length"); i++) {
				DescribeApplicationConfigResponse.DescribeApplicationConfig_Data.DescribeApplicationConfig_ConfigMapMountDescItem configMapMountDescItem = new DescribeApplicationConfigResponse.DescribeApplicationConfig_Data.DescribeApplicationConfig_ConfigMapMountDescItem();
				configMapMountDescItem.ConfigMapId = context.LongValue("DescribeApplicationConfig.Data.ConfigMapMountDesc["+ i +"].ConfigMapId");
				configMapMountDescItem.ConfigMapName = context.StringValue("DescribeApplicationConfig.Data.ConfigMapMountDesc["+ i +"].ConfigMapName");
				configMapMountDescItem.Key = context.StringValue("DescribeApplicationConfig.Data.ConfigMapMountDesc["+ i +"].Key");
				configMapMountDescItem.MountPath = context.StringValue("DescribeApplicationConfig.Data.ConfigMapMountDesc["+ i +"].MountPath");

				data_configMapMountDesc.Add(configMapMountDescItem);
			}
			data.ConfigMapMountDesc = data_configMapMountDesc;
			describeApplicationConfigResponse.Data = data;
        
			return describeApplicationConfigResponse;
        }
    }
}
