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
			describeApplicationConfigResponse.RequestId = _ctx.StringValue("DescribeApplicationConfig.RequestId");
			describeApplicationConfigResponse.Message = _ctx.StringValue("DescribeApplicationConfig.Message");
			describeApplicationConfigResponse.TraceId = _ctx.StringValue("DescribeApplicationConfig.TraceId");
			describeApplicationConfigResponse.ErrorCode = _ctx.StringValue("DescribeApplicationConfig.ErrorCode");
			describeApplicationConfigResponse.Code = _ctx.StringValue("DescribeApplicationConfig.Code");
			describeApplicationConfigResponse.Success = _ctx.BooleanValue("DescribeApplicationConfig.Success");

			DescribeApplicationConfigResponse.DescribeApplicationConfig_Data data = new DescribeApplicationConfigResponse.DescribeApplicationConfig_Data();
			data.VpcId = _ctx.StringValue("DescribeApplicationConfig.Data.VpcId");
			data.Readiness = _ctx.StringValue("DescribeApplicationConfig.Data.Readiness");
			data.SecurityGroupId = _ctx.StringValue("DescribeApplicationConfig.Data.SecurityGroupId");
			data.BatchWaitTime = _ctx.IntegerValue("DescribeApplicationConfig.Data.BatchWaitTime");
			data.Jdk = _ctx.StringValue("DescribeApplicationConfig.Data.Jdk");
			data.ImageUrl = _ctx.StringValue("DescribeApplicationConfig.Data.ImageUrl");
			data.SlsConfigs = _ctx.StringValue("DescribeApplicationConfig.Data.SlsConfigs");
			data.Liveness = _ctx.StringValue("DescribeApplicationConfig.Data.Liveness");
			data.PackageUrl = _ctx.StringValue("DescribeApplicationConfig.Data.PackageUrl");
			data.PackageType = _ctx.StringValue("DescribeApplicationConfig.Data.PackageType");
			data.PreStop = _ctx.StringValue("DescribeApplicationConfig.Data.PreStop");
			data.PackageVersion = _ctx.StringValue("DescribeApplicationConfig.Data.PackageVersion");
			data.JarStartArgs = _ctx.StringValue("DescribeApplicationConfig.Data.JarStartArgs");
			data.AppName = _ctx.StringValue("DescribeApplicationConfig.Data.AppName");
			data.AppId = _ctx.StringValue("DescribeApplicationConfig.Data.AppId");
			data.JarStartOptions = _ctx.StringValue("DescribeApplicationConfig.Data.JarStartOptions");
			data.Replicas = _ctx.IntegerValue("DescribeApplicationConfig.Data.Replicas");
			data.UpdateStrategy = _ctx.StringValue("DescribeApplicationConfig.Data.UpdateStrategy");
			data.MinReadyInstances = _ctx.IntegerValue("DescribeApplicationConfig.Data.MinReadyInstances");
			data.MinReadyInstanceRatio = _ctx.IntegerValue("DescribeApplicationConfig.Data.MinReadyInstanceRatio");
			data.Memory = _ctx.IntegerValue("DescribeApplicationConfig.Data.Memory");
			data.Php = _ctx.StringValue("DescribeApplicationConfig.Data.Php");
			data.PhpConfig = _ctx.StringValue("DescribeApplicationConfig.Data.PhpConfig");
			data.PhpConfigLocation = _ctx.StringValue("DescribeApplicationConfig.Data.PhpConfigLocation");
			data.PhpExtensions = _ctx.StringValue("DescribeApplicationConfig.Data.PhpExtensions");
			data.PhpPECLExtensions = _ctx.StringValue("DescribeApplicationConfig.Data.PhpPECLExtensions");
			data.PostStart = _ctx.StringValue("DescribeApplicationConfig.Data.PostStart");
			data.TerminationGracePeriodSeconds = _ctx.IntegerValue("DescribeApplicationConfig.Data.TerminationGracePeriodSeconds");
			data.CommandArgs = _ctx.StringValue("DescribeApplicationConfig.Data.CommandArgs");
			data.NamespaceId = _ctx.StringValue("DescribeApplicationConfig.Data.NamespaceId");
			data.MountHost = _ctx.StringValue("DescribeApplicationConfig.Data.MountHost");
			data.TomcatConfig = _ctx.StringValue("DescribeApplicationConfig.Data.TomcatConfig");
			data.RegionId = _ctx.StringValue("DescribeApplicationConfig.Data.RegionId");
			data.VSwitchId = _ctx.StringValue("DescribeApplicationConfig.Data.VSwitchId");
			data.Cpu = _ctx.IntegerValue("DescribeApplicationConfig.Data.Cpu");
			data.Envs = _ctx.StringValue("DescribeApplicationConfig.Data.Envs");
			data.EnableAhas = _ctx.StringValue("DescribeApplicationConfig.Data.EnableAhas");
			data.CustomHostAlias = _ctx.StringValue("DescribeApplicationConfig.Data.CustomHostAlias");
			data.WebContainer = _ctx.StringValue("DescribeApplicationConfig.Data.WebContainer");
			data.Command = _ctx.StringValue("DescribeApplicationConfig.Data.Command");
			data.WarStartOptions = _ctx.StringValue("DescribeApplicationConfig.Data.WarStartOptions");
			data.PhpArmsConfigLocation = _ctx.StringValue("DescribeApplicationConfig.Data.PhpArmsConfigLocation");
			data.NasId = _ctx.StringValue("DescribeApplicationConfig.Data.NasId");
			data.OssAkId = _ctx.StringValue("DescribeApplicationConfig.Data.OssAkId");
			data.OssAkSecret = _ctx.StringValue("DescribeApplicationConfig.Data.OssAkSecret");
			data.EdasContainerVersion = _ctx.StringValue("DescribeApplicationConfig.Data.EdasContainerVersion");
			data.Timezone = _ctx.StringValue("DescribeApplicationConfig.Data.Timezone");
			data.AppDescription = _ctx.StringValue("DescribeApplicationConfig.Data.AppDescription");
			data.EnableGreyTagRoute = _ctx.BooleanValue("DescribeApplicationConfig.Data.EnableGreyTagRoute");
			data.MseApplicationId = _ctx.StringValue("DescribeApplicationConfig.Data.MseApplicationId");
			data.AcrInstanceId = _ctx.StringValue("DescribeApplicationConfig.Data.AcrInstanceId");
			data.AcrAssumeRoleArn = _ctx.StringValue("DescribeApplicationConfig.Data.AcrAssumeRoleArn");
			data.AssociateEip = _ctx.BooleanValue("DescribeApplicationConfig.Data.AssociateEip");
			data.KafkaConfigs = _ctx.StringValue("DescribeApplicationConfig.Data.KafkaConfigs");

			List<DescribeApplicationConfigResponse.DescribeApplicationConfig_Data.DescribeApplicationConfig_ConfigMapMountDescItem> data_configMapMountDesc = new List<DescribeApplicationConfigResponse.DescribeApplicationConfig_Data.DescribeApplicationConfig_ConfigMapMountDescItem>();
			for (int i = 0; i < _ctx.Length("DescribeApplicationConfig.Data.ConfigMapMountDesc.Length"); i++) {
				DescribeApplicationConfigResponse.DescribeApplicationConfig_Data.DescribeApplicationConfig_ConfigMapMountDescItem configMapMountDescItem = new DescribeApplicationConfigResponse.DescribeApplicationConfig_Data.DescribeApplicationConfig_ConfigMapMountDescItem();
				configMapMountDescItem.Key = _ctx.StringValue("DescribeApplicationConfig.Data.ConfigMapMountDesc["+ i +"].Key");
				configMapMountDescItem.ConfigMapName = _ctx.StringValue("DescribeApplicationConfig.Data.ConfigMapMountDesc["+ i +"].ConfigMapName");
				configMapMountDescItem.MountPath = _ctx.StringValue("DescribeApplicationConfig.Data.ConfigMapMountDesc["+ i +"].MountPath");
				configMapMountDescItem.ConfigMapId = _ctx.LongValue("DescribeApplicationConfig.Data.ConfigMapMountDesc["+ i +"].ConfigMapId");

				data_configMapMountDesc.Add(configMapMountDescItem);
			}
			data.ConfigMapMountDesc = data_configMapMountDesc;

			List<DescribeApplicationConfigResponse.DescribeApplicationConfig_Data.DescribeApplicationConfig_Tag> data_tags = new List<DescribeApplicationConfigResponse.DescribeApplicationConfig_Data.DescribeApplicationConfig_Tag>();
			for (int i = 0; i < _ctx.Length("DescribeApplicationConfig.Data.Tags.Length"); i++) {
				DescribeApplicationConfigResponse.DescribeApplicationConfig_Data.DescribeApplicationConfig_Tag tag = new DescribeApplicationConfigResponse.DescribeApplicationConfig_Data.DescribeApplicationConfig_Tag();
				tag.Key = _ctx.StringValue("DescribeApplicationConfig.Data.Tags["+ i +"].Key");
				tag._Value = _ctx.StringValue("DescribeApplicationConfig.Data.Tags["+ i +"].Value");

				data_tags.Add(tag);
			}
			data.Tags = data_tags;

			List<DescribeApplicationConfigResponse.DescribeApplicationConfig_Data.DescribeApplicationConfig_MountDescItem> data_mountDesc = new List<DescribeApplicationConfigResponse.DescribeApplicationConfig_Data.DescribeApplicationConfig_MountDescItem>();
			for (int i = 0; i < _ctx.Length("DescribeApplicationConfig.Data.MountDesc.Length"); i++) {
				DescribeApplicationConfigResponse.DescribeApplicationConfig_Data.DescribeApplicationConfig_MountDescItem mountDescItem = new DescribeApplicationConfigResponse.DescribeApplicationConfig_Data.DescribeApplicationConfig_MountDescItem();
				mountDescItem.MountPath = _ctx.StringValue("DescribeApplicationConfig.Data.MountDesc["+ i +"].MountPath");
				mountDescItem.NasPath = _ctx.StringValue("DescribeApplicationConfig.Data.MountDesc["+ i +"].NasPath");

				data_mountDesc.Add(mountDescItem);
			}
			data.MountDesc = data_mountDesc;

			List<DescribeApplicationConfigResponse.DescribeApplicationConfig_Data.DescribeApplicationConfig_OssMountDesc> data_ossMountDescs = new List<DescribeApplicationConfigResponse.DescribeApplicationConfig_Data.DescribeApplicationConfig_OssMountDesc>();
			for (int i = 0; i < _ctx.Length("DescribeApplicationConfig.Data.OssMountDescs.Length"); i++) {
				DescribeApplicationConfigResponse.DescribeApplicationConfig_Data.DescribeApplicationConfig_OssMountDesc ossMountDesc = new DescribeApplicationConfigResponse.DescribeApplicationConfig_Data.DescribeApplicationConfig_OssMountDesc();
				ossMountDesc.BucketName = _ctx.StringValue("DescribeApplicationConfig.Data.OssMountDescs["+ i +"].bucketName");
				ossMountDesc.BucketPath = _ctx.StringValue("DescribeApplicationConfig.Data.OssMountDescs["+ i +"].bucketPath");
				ossMountDesc.MountPath = _ctx.StringValue("DescribeApplicationConfig.Data.OssMountDescs["+ i +"].mountPath");
				ossMountDesc._ReadOnly = _ctx.BooleanValue("DescribeApplicationConfig.Data.OssMountDescs["+ i +"].readOnly");

				data_ossMountDescs.Add(ossMountDesc);
			}
			data.OssMountDescs = data_ossMountDescs;
			describeApplicationConfigResponse.Data = data;
        
			return describeApplicationConfigResponse;
        }
    }
}
