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
using Aliyun.Acs.Edas.Model.V20170801;

namespace Aliyun.Acs.Edas.Transform.V20170801
{
    public class GetK8sApplicationResponseUnmarshaller
    {
        public static GetK8sApplicationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetK8sApplicationResponse getK8sApplicationResponse = new GetK8sApplicationResponse();

			getK8sApplicationResponse.HttpResponse = _ctx.HttpResponse;
			getK8sApplicationResponse.Code = _ctx.IntegerValue("GetK8sApplication.Code");
			getK8sApplicationResponse.Message = _ctx.StringValue("GetK8sApplication.Message");
			getK8sApplicationResponse.RequestId = _ctx.StringValue("GetK8sApplication.RequestId");

			GetK8sApplicationResponse.GetK8sApplication_Applcation applcation = new GetK8sApplicationResponse.GetK8sApplication_Applcation();
			applcation.AppId = _ctx.StringValue("GetK8sApplication.Applcation.AppId");

			GetK8sApplicationResponse.GetK8sApplication_Applcation.GetK8sApplication_ImageInfo imageInfo = new GetK8sApplicationResponse.GetK8sApplication_Applcation.GetK8sApplication_ImageInfo();
			imageInfo.ImageUrl = _ctx.StringValue("GetK8sApplication.Applcation.ImageInfo.ImageUrl");
			imageInfo.RepoName = _ctx.StringValue("GetK8sApplication.Applcation.ImageInfo.RepoName");
			imageInfo.RegionId = _ctx.StringValue("GetK8sApplication.Applcation.ImageInfo.RegionId");
			imageInfo.RepoId = _ctx.StringValue("GetK8sApplication.Applcation.ImageInfo.RepoId");
			imageInfo.RepoNamespace = _ctx.StringValue("GetK8sApplication.Applcation.ImageInfo.RepoNamespace");
			imageInfo.RepoOriginType = _ctx.StringValue("GetK8sApplication.Applcation.ImageInfo.RepoOriginType");
			imageInfo.Tag = _ctx.StringValue("GetK8sApplication.Applcation.ImageInfo.Tag");
			applcation.ImageInfo = imageInfo;

			GetK8sApplicationResponse.GetK8sApplication_Applcation.GetK8sApplication_App app = new GetK8sApplicationResponse.GetK8sApplication_Applcation.GetK8sApplication_App();
			app.ApplicationType = _ctx.StringValue("GetK8sApplication.Applcation.App.ApplicationType");
			app.Cmd = _ctx.StringValue("GetK8sApplication.Applcation.App.Cmd");
			app.DeployType = _ctx.StringValue("GetK8sApplication.Applcation.App.DeployType");
			app.EdasContainerVersion = _ctx.StringValue("GetK8sApplication.Applcation.App.EdasContainerVersion");
			app.BuildpackId = _ctx.IntegerValue("GetK8sApplication.Applcation.App.BuildpackId");
			app.TomcatVersion = _ctx.StringValue("GetK8sApplication.Applcation.App.TomcatVersion");
			app.InstancesBeforeScaling = _ctx.IntegerValue("GetK8sApplication.Applcation.App.InstancesBeforeScaling");
			app.AppId = _ctx.StringValue("GetK8sApplication.Applcation.App.AppId");
			app.ApplicationName = _ctx.StringValue("GetK8sApplication.Applcation.App.ApplicationName");
			app.ClusterId = _ctx.StringValue("GetK8sApplication.Applcation.App.ClusterId");
			app.Instances = _ctx.IntegerValue("GetK8sApplication.Applcation.App.Instances");
			app.CsClusterId = _ctx.StringValue("GetK8sApplication.Applcation.App.CsClusterId");
			app.LimitCpuM = _ctx.IntegerValue("GetK8sApplication.Applcation.App.LimitCpuM");
			app.RequestCpuM = _ctx.IntegerValue("GetK8sApplication.Applcation.App.RequestCpuM");
			app.LimitMem = _ctx.IntegerValue("GetK8sApplication.Applcation.App.LimitMem");
			app.RequestMem = _ctx.IntegerValue("GetK8sApplication.Applcation.App.RequestMem");
			app.K8sNamespace = _ctx.StringValue("GetK8sApplication.Applcation.App.K8sNamespace");
			app.RegionId = _ctx.StringValue("GetK8sApplication.Applcation.App.RegionId");

			List<string> app_cmdArgs = new List<string>();
			for (int i = 0; i < _ctx.Length("GetK8sApplication.Applcation.App.CmdArgs.Length"); i++) {
				app_cmdArgs.Add(_ctx.StringValue("GetK8sApplication.Applcation.App.CmdArgs["+ i +"]"));
			}
			app.CmdArgs = app_cmdArgs;

			List<GetK8sApplicationResponse.GetK8sApplication_Applcation.GetK8sApplication_App.GetK8sApplication_Env> app_envList = new List<GetK8sApplicationResponse.GetK8sApplication_Applcation.GetK8sApplication_App.GetK8sApplication_Env>();
			for (int i = 0; i < _ctx.Length("GetK8sApplication.Applcation.App.EnvList.Length"); i++) {
				GetK8sApplicationResponse.GetK8sApplication_Applcation.GetK8sApplication_App.GetK8sApplication_Env env = new GetK8sApplicationResponse.GetK8sApplication_Applcation.GetK8sApplication_App.GetK8sApplication_Env();
				env.Name = _ctx.StringValue("GetK8sApplication.Applcation.App.EnvList["+ i +"].Name");
				env._Value = _ctx.StringValue("GetK8sApplication.Applcation.App.EnvList["+ i +"].Value");

				app_envList.Add(env);
			}
			app.EnvList = app_envList;
			applcation.App = app;

			GetK8sApplicationResponse.GetK8sApplication_Applcation.GetK8sApplication_Conf conf = new GetK8sApplicationResponse.GetK8sApplication_Applcation.GetK8sApplication_Conf();
			conf.JarStartArgs = _ctx.StringValue("GetK8sApplication.Applcation.Conf.JarStartArgs");
			conf.JarStartOptions = _ctx.StringValue("GetK8sApplication.Applcation.Conf.JarStartOptions");
			conf.K8sCmd = _ctx.StringValue("GetK8sApplication.Applcation.Conf.K8sCmd");
			conf.K8sCmdArgs = _ctx.StringValue("GetK8sApplication.Applcation.Conf.K8sCmdArgs");
			conf.K8sLocalvolumeInfo = _ctx.StringValue("GetK8sApplication.Applcation.Conf.K8sLocalvolumeInfo");
			conf.K8sNasInfo = _ctx.StringValue("GetK8sApplication.Applcation.Conf.K8sNasInfo");
			conf.K8sVolumeInfo = _ctx.StringValue("GetK8sApplication.Applcation.Conf.K8sVolumeInfo");
			conf.Liveness = _ctx.StringValue("GetK8sApplication.Applcation.Conf.Liveness");
			conf.PostStart = _ctx.StringValue("GetK8sApplication.Applcation.Conf.PostStart");
			conf.PreStop = _ctx.StringValue("GetK8sApplication.Applcation.Conf.PreStop");
			conf.Readiness = _ctx.StringValue("GetK8sApplication.Applcation.Conf.Readiness");
			conf.RuntimeClassName = _ctx.StringValue("GetK8sApplication.Applcation.Conf.RuntimeClassName");
			conf.DeployAcrossZones = _ctx.StringValue("GetK8sApplication.Applcation.Conf.DeployAcrossZones");
			conf.AhasEnabled = _ctx.BooleanValue("GetK8sApplication.Applcation.Conf.AhasEnabled");
			conf.DeployAcrossNodes = _ctx.StringValue("GetK8sApplication.Applcation.Conf.DeployAcrossNodes");
			applcation.Conf = conf;

			GetK8sApplicationResponse.GetK8sApplication_Applcation.GetK8sApplication_LatestVersion latestVersion = new GetK8sApplicationResponse.GetK8sApplication_Applcation.GetK8sApplication_LatestVersion();
			latestVersion.PackageVersion = _ctx.StringValue("GetK8sApplication.Applcation.LatestVersion.PackageVersion");
			latestVersion.Url = _ctx.StringValue("GetK8sApplication.Applcation.LatestVersion.Url");
			latestVersion.WarUrl = _ctx.StringValue("GetK8sApplication.Applcation.LatestVersion.WarUrl");
			applcation.LatestVersion = latestVersion;

			List<GetK8sApplicationResponse.GetK8sApplication_Applcation.GetK8sApplication_DeployGroup> applcation_deployGroups = new List<GetK8sApplicationResponse.GetK8sApplication_Applcation.GetK8sApplication_DeployGroup>();
			for (int i = 0; i < _ctx.Length("GetK8sApplication.Applcation.DeployGroups.Length"); i++) {
				GetK8sApplicationResponse.GetK8sApplication_Applcation.GetK8sApplication_DeployGroup deployGroup = new GetK8sApplicationResponse.GetK8sApplication_Applcation.GetK8sApplication_DeployGroup();

				List<GetK8sApplicationResponse.GetK8sApplication_Applcation.GetK8sApplication_DeployGroup.GetK8sApplication_ComponentsItem> deployGroup_components = new List<GetK8sApplicationResponse.GetK8sApplication_Applcation.GetK8sApplication_DeployGroup.GetK8sApplication_ComponentsItem>();
				for (int j = 0; j < _ctx.Length("GetK8sApplication.Applcation.DeployGroups["+ i +"].Components.Length"); j++) {
					GetK8sApplicationResponse.GetK8sApplication_Applcation.GetK8sApplication_DeployGroup.GetK8sApplication_ComponentsItem componentsItem = new GetK8sApplicationResponse.GetK8sApplication_Applcation.GetK8sApplication_DeployGroup.GetK8sApplication_ComponentsItem();
					componentsItem.ComponentId = _ctx.StringValue("GetK8sApplication.Applcation.DeployGroups["+ i +"].Components["+ j +"].ComponentId");
					componentsItem.ComponentKey = _ctx.StringValue("GetK8sApplication.Applcation.DeployGroups["+ i +"].Components["+ j +"].ComponentKey");
					componentsItem.Type = _ctx.StringValue("GetK8sApplication.Applcation.DeployGroups["+ i +"].Components["+ j +"].Type");

					deployGroup_components.Add(componentsItem);
				}
				deployGroup.Components = deployGroup_components;

				applcation_deployGroups.Add(deployGroup);
			}
			applcation.DeployGroups = applcation_deployGroups;
			getK8sApplicationResponse.Applcation = applcation;
        
			return getK8sApplicationResponse;
        }
    }
}
