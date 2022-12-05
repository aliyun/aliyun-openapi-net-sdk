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
    public class DescribeJobResponseUnmarshaller
    {
        public static DescribeJobResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeJobResponse describeJobResponse = new DescribeJobResponse();

			describeJobResponse.HttpResponse = _ctx.HttpResponse;
			describeJobResponse.RequestId = _ctx.StringValue("DescribeJob.RequestId");
			describeJobResponse.Message = _ctx.StringValue("DescribeJob.Message");
			describeJobResponse.TraceId = _ctx.StringValue("DescribeJob.TraceId");
			describeJobResponse.ErrorCode = _ctx.StringValue("DescribeJob.ErrorCode");
			describeJobResponse.Code = _ctx.StringValue("DescribeJob.Code");
			describeJobResponse.Success = _ctx.BooleanValue("DescribeJob.Success");

			DescribeJobResponse.DescribeJob_Data data = new DescribeJobResponse.DescribeJob_Data();
			data.VpcId = _ctx.StringValue("DescribeJob.Data.VpcId");
			data.Readiness = _ctx.StringValue("DescribeJob.Data.Readiness");
			data.SecurityGroupId = _ctx.StringValue("DescribeJob.Data.SecurityGroupId");
			data.BatchWaitTime = _ctx.IntegerValue("DescribeJob.Data.BatchWaitTime");
			data.Jdk = _ctx.StringValue("DescribeJob.Data.Jdk");
			data.ImageUrl = _ctx.StringValue("DescribeJob.Data.ImageUrl");
			data.SlsConfigs = _ctx.StringValue("DescribeJob.Data.SlsConfigs");
			data.Liveness = _ctx.StringValue("DescribeJob.Data.Liveness");
			data.PackageUrl = _ctx.StringValue("DescribeJob.Data.PackageUrl");
			data.PackageType = _ctx.StringValue("DescribeJob.Data.PackageType");
			data.PackageRuntimeCustomBuild = _ctx.StringValue("DescribeJob.Data.PackageRuntimeCustomBuild");
			data.PreStop = _ctx.StringValue("DescribeJob.Data.PreStop");
			data.PackageVersion = _ctx.StringValue("DescribeJob.Data.PackageVersion");
			data.JarStartArgs = _ctx.StringValue("DescribeJob.Data.JarStartArgs");
			data.AppName = _ctx.StringValue("DescribeJob.Data.AppName");
			data.AppId = _ctx.StringValue("DescribeJob.Data.AppId");
			data.JarStartOptions = _ctx.StringValue("DescribeJob.Data.JarStartOptions");
			data.Replicas = _ctx.IntegerValue("DescribeJob.Data.Replicas");
			data.MinReadyInstances = _ctx.IntegerValue("DescribeJob.Data.MinReadyInstances");
			data.Memory = _ctx.IntegerValue("DescribeJob.Data.Memory");
			data.Php = _ctx.StringValue("DescribeJob.Data.Php");
			data.PhpConfig = _ctx.StringValue("DescribeJob.Data.PhpConfig");
			data.PhpConfigLocation = _ctx.StringValue("DescribeJob.Data.PhpConfigLocation");
			data.PhpExtensions = _ctx.StringValue("DescribeJob.Data.PhpExtensions");
			data.PhpPECLExtensions = _ctx.StringValue("DescribeJob.Data.PhpPECLExtensions");
			data.PostStart = _ctx.StringValue("DescribeJob.Data.PostStart");
			data.TerminationGracePeriodSeconds = _ctx.IntegerValue("DescribeJob.Data.TerminationGracePeriodSeconds");
			data.CommandArgs = _ctx.StringValue("DescribeJob.Data.CommandArgs");
			data.NamespaceId = _ctx.StringValue("DescribeJob.Data.NamespaceId");
			data.MountHost = _ctx.StringValue("DescribeJob.Data.MountHost");
			data.TomcatConfig = _ctx.StringValue("DescribeJob.Data.TomcatConfig");
			data.RegionId = _ctx.StringValue("DescribeJob.Data.RegionId");
			data.VSwitchId = _ctx.StringValue("DescribeJob.Data.VSwitchId");
			data.Cpu = _ctx.IntegerValue("DescribeJob.Data.Cpu");
			data.Envs = _ctx.StringValue("DescribeJob.Data.Envs");
			data.EnableAhas = _ctx.StringValue("DescribeJob.Data.EnableAhas");
			data.CustomHostAlias = _ctx.StringValue("DescribeJob.Data.CustomHostAlias");
			data.WebContainer = _ctx.StringValue("DescribeJob.Data.WebContainer");
			data.Command = _ctx.StringValue("DescribeJob.Data.Command");
			data.WarStartOptions = _ctx.StringValue("DescribeJob.Data.WarStartOptions");
			data.PhpArmsConfigLocation = _ctx.StringValue("DescribeJob.Data.PhpArmsConfigLocation");
			data.NasId = _ctx.StringValue("DescribeJob.Data.NasId");
			data.OssAkId = _ctx.StringValue("DescribeJob.Data.OssAkId");
			data.OssAkSecret = _ctx.StringValue("DescribeJob.Data.OssAkSecret");
			data.EdasContainerVersion = _ctx.StringValue("DescribeJob.Data.EdasContainerVersion");
			data.Timezone = _ctx.StringValue("DescribeJob.Data.Timezone");
			data.AppDescription = _ctx.StringValue("DescribeJob.Data.AppDescription");
			data.EnableGreyTagRoute = _ctx.BooleanValue("DescribeJob.Data.EnableGreyTagRoute");
			data.MseApplicationId = _ctx.StringValue("DescribeJob.Data.MseApplicationId");
			data.AcrInstanceId = _ctx.StringValue("DescribeJob.Data.AcrInstanceId");
			data.AcrAssumeRoleArn = _ctx.StringValue("DescribeJob.Data.AcrAssumeRoleArn");
			data.ImagePullSecrets = _ctx.StringValue("DescribeJob.Data.ImagePullSecrets");
			data.EnableImageAccl = _ctx.BooleanValue("DescribeJob.Data.EnableImageAccl");
			data.AssociateEip = _ctx.BooleanValue("DescribeJob.Data.AssociateEip");
			data.TriggerConfig = _ctx.StringValue("DescribeJob.Data.TriggerConfig");
			data.ConcurrencyPolicy = _ctx.StringValue("DescribeJob.Data.ConcurrencyPolicy");
			data.Suspend = _ctx.BooleanValue("DescribeJob.Data.Suspend");
			data.Timeout = _ctx.LongValue("DescribeJob.Data.Timeout");
			data.BackoffLimit = _ctx.LongValue("DescribeJob.Data.BackoffLimit");
			data.Slice = _ctx.BooleanValue("DescribeJob.Data.Slice");
			data.SliceEnvs = _ctx.StringValue("DescribeJob.Data.SliceEnvs");
			data.RefAppId = _ctx.StringValue("DescribeJob.Data.RefAppId");
			data.ProgrammingLanguage = _ctx.StringValue("DescribeJob.Data.ProgrammingLanguage");
			data.NasConfigs = _ctx.StringValue("DescribeJob.Data.NasConfigs");
			data.Python = _ctx.StringValue("DescribeJob.Data.Python");
			data.PythonModules = _ctx.StringValue("DescribeJob.Data.PythonModules");

			List<string> data_refedAppIds = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeJob.Data.RefedAppIds.Length"); i++) {
				data_refedAppIds.Add(_ctx.StringValue("DescribeJob.Data.RefedAppIds["+ i +"]"));
			}
			data.RefedAppIds = data_refedAppIds;

			List<string> data_publicWebHookUrls = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeJob.Data.PublicWebHookUrls.Length"); i++) {
				data_publicWebHookUrls.Add(_ctx.StringValue("DescribeJob.Data.PublicWebHookUrls["+ i +"]"));
			}
			data.PublicWebHookUrls = data_publicWebHookUrls;

			List<string> data_vpcWebHookUrls = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeJob.Data.VpcWebHookUrls.Length"); i++) {
				data_vpcWebHookUrls.Add(_ctx.StringValue("DescribeJob.Data.VpcWebHookUrls["+ i +"]"));
			}
			data.VpcWebHookUrls = data_vpcWebHookUrls;

			List<DescribeJobResponse.DescribeJob_Data.DescribeJob_ConfigMapMountDescItem> data_configMapMountDesc = new List<DescribeJobResponse.DescribeJob_Data.DescribeJob_ConfigMapMountDescItem>();
			for (int i = 0; i < _ctx.Length("DescribeJob.Data.ConfigMapMountDesc.Length"); i++) {
				DescribeJobResponse.DescribeJob_Data.DescribeJob_ConfigMapMountDescItem configMapMountDescItem = new DescribeJobResponse.DescribeJob_Data.DescribeJob_ConfigMapMountDescItem();
				configMapMountDescItem.Key = _ctx.StringValue("DescribeJob.Data.ConfigMapMountDesc["+ i +"].Key");
				configMapMountDescItem.ConfigMapName = _ctx.StringValue("DescribeJob.Data.ConfigMapMountDesc["+ i +"].ConfigMapName");
				configMapMountDescItem.MountPath = _ctx.StringValue("DescribeJob.Data.ConfigMapMountDesc["+ i +"].MountPath");
				configMapMountDescItem.ConfigMapId = _ctx.LongValue("DescribeJob.Data.ConfigMapMountDesc["+ i +"].ConfigMapId");

				data_configMapMountDesc.Add(configMapMountDescItem);
			}
			data.ConfigMapMountDesc = data_configMapMountDesc;

			List<DescribeJobResponse.DescribeJob_Data.DescribeJob_Tag> data_tags = new List<DescribeJobResponse.DescribeJob_Data.DescribeJob_Tag>();
			for (int i = 0; i < _ctx.Length("DescribeJob.Data.Tags.Length"); i++) {
				DescribeJobResponse.DescribeJob_Data.DescribeJob_Tag tag = new DescribeJobResponse.DescribeJob_Data.DescribeJob_Tag();
				tag.Key = _ctx.StringValue("DescribeJob.Data.Tags["+ i +"].Key");
				tag._Value = _ctx.StringValue("DescribeJob.Data.Tags["+ i +"].Value");

				data_tags.Add(tag);
			}
			data.Tags = data_tags;

			List<DescribeJobResponse.DescribeJob_Data.DescribeJob_MountDescItem> data_mountDesc = new List<DescribeJobResponse.DescribeJob_Data.DescribeJob_MountDescItem>();
			for (int i = 0; i < _ctx.Length("DescribeJob.Data.MountDesc.Length"); i++) {
				DescribeJobResponse.DescribeJob_Data.DescribeJob_MountDescItem mountDescItem = new DescribeJobResponse.DescribeJob_Data.DescribeJob_MountDescItem();
				mountDescItem.MountPath = _ctx.StringValue("DescribeJob.Data.MountDesc["+ i +"].MountPath");
				mountDescItem.NasPath = _ctx.StringValue("DescribeJob.Data.MountDesc["+ i +"].NasPath");

				data_mountDesc.Add(mountDescItem);
			}
			data.MountDesc = data_mountDesc;

			List<DescribeJobResponse.DescribeJob_Data.DescribeJob_OssMountDesc> data_ossMountDescs = new List<DescribeJobResponse.DescribeJob_Data.DescribeJob_OssMountDesc>();
			for (int i = 0; i < _ctx.Length("DescribeJob.Data.OssMountDescs.Length"); i++) {
				DescribeJobResponse.DescribeJob_Data.DescribeJob_OssMountDesc ossMountDesc = new DescribeJobResponse.DescribeJob_Data.DescribeJob_OssMountDesc();
				ossMountDesc.BucketName = _ctx.StringValue("DescribeJob.Data.OssMountDescs["+ i +"].bucketName");
				ossMountDesc.BucketPath = _ctx.StringValue("DescribeJob.Data.OssMountDescs["+ i +"].bucketPath");
				ossMountDesc.MountPath = _ctx.StringValue("DescribeJob.Data.OssMountDescs["+ i +"].mountPath");
				ossMountDesc._ReadOnly = _ctx.BooleanValue("DescribeJob.Data.OssMountDescs["+ i +"].readOnly");

				data_ossMountDescs.Add(ossMountDesc);
			}
			data.OssMountDescs = data_ossMountDescs;
			describeJobResponse.Data = data;
        
			return describeJobResponse;
        }
    }
}
