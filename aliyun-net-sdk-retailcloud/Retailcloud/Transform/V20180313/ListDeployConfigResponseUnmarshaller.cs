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
using Aliyun.Acs.retailcloud.Model.V20180313;

namespace Aliyun.Acs.retailcloud.Transform.V20180313
{
    public class ListDeployConfigResponseUnmarshaller
    {
        public static ListDeployConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDeployConfigResponse listDeployConfigResponse = new ListDeployConfigResponse();

			listDeployConfigResponse.HttpResponse = _ctx.HttpResponse;
			listDeployConfigResponse.Code = _ctx.IntegerValue("ListDeployConfig.Code");
			listDeployConfigResponse.ErrorMsg = _ctx.StringValue("ListDeployConfig.ErrorMsg");
			listDeployConfigResponse.PageNumber = _ctx.IntegerValue("ListDeployConfig.PageNumber");
			listDeployConfigResponse.PageSize = _ctx.IntegerValue("ListDeployConfig.PageSize");
			listDeployConfigResponse.RequestId = _ctx.StringValue("ListDeployConfig.RequestId");
			listDeployConfigResponse.TotalCount = _ctx.LongValue("ListDeployConfig.TotalCount");

			List<ListDeployConfigResponse.ListDeployConfig_DeployConfigInstance> listDeployConfigResponse_data = new List<ListDeployConfigResponse.ListDeployConfig_DeployConfigInstance>();
			for (int i = 0; i < _ctx.Length("ListDeployConfig.Data.Length"); i++) {
				ListDeployConfigResponse.ListDeployConfig_DeployConfigInstance deployConfigInstance = new ListDeployConfigResponse.ListDeployConfig_DeployConfigInstance();
				deployConfigInstance.Id = _ctx.LongValue("ListDeployConfig.Data["+ i +"].Id");
				deployConfigInstance.Name = _ctx.StringValue("ListDeployConfig.Data["+ i +"].Name");
				deployConfigInstance.AppId = _ctx.LongValue("ListDeployConfig.Data["+ i +"].AppId");
				deployConfigInstance.EnvType = _ctx.StringValue("ListDeployConfig.Data["+ i +"].EnvType");

				ListDeployConfigResponse.ListDeployConfig_DeployConfigInstance.ListDeployConfig_ContainerCodePath containerCodePath = new ListDeployConfigResponse.ListDeployConfig_DeployConfigInstance.ListDeployConfig_ContainerCodePath();
				containerCodePath.CodePath = _ctx.StringValue("ListDeployConfig.Data["+ i +"].ContainerCodePath.CodePath");
				deployConfigInstance.ContainerCodePath = containerCodePath;

				ListDeployConfigResponse.ListDeployConfig_DeployConfigInstance.ListDeployConfig_ContainerYamlConf containerYamlConf = new ListDeployConfigResponse.ListDeployConfig_DeployConfigInstance.ListDeployConfig_ContainerYamlConf();
				containerYamlConf.Deployment = _ctx.StringValue("ListDeployConfig.Data["+ i +"].ContainerYamlConf.Deployment");
				containerYamlConf.ConfigMap = _ctx.StringValue("ListDeployConfig.Data["+ i +"].ContainerYamlConf.ConfigMap");
				containerYamlConf.StatefulSet = _ctx.StringValue("ListDeployConfig.Data["+ i +"].ContainerYamlConf.StatefulSet");
				containerYamlConf.CronJob = _ctx.StringValue("ListDeployConfig.Data["+ i +"].ContainerYamlConf.CronJob");

				List<string> containerYamlConf_configMapList = new List<string>();
				for (int j = 0; j < _ctx.Length("ListDeployConfig.Data["+ i +"].ContainerYamlConf.ConfigMapList.Length"); j++) {
					containerYamlConf_configMapList.Add(_ctx.StringValue("ListDeployConfig.Data["+ i +"].ContainerYamlConf.ConfigMapList["+ j +"]"));
				}
				containerYamlConf.ConfigMapList = containerYamlConf_configMapList;

				List<string> containerYamlConf_secretList = new List<string>();
				for (int j = 0; j < _ctx.Length("ListDeployConfig.Data["+ i +"].ContainerYamlConf.SecretList.Length"); j++) {
					containerYamlConf_secretList.Add(_ctx.StringValue("ListDeployConfig.Data["+ i +"].ContainerYamlConf.SecretList["+ j +"]"));
				}
				containerYamlConf.SecretList = containerYamlConf_secretList;
				deployConfigInstance.ContainerYamlConf = containerYamlConf;

				listDeployConfigResponse_data.Add(deployConfigInstance);
			}
			listDeployConfigResponse.Data = listDeployConfigResponse_data;
        
			return listDeployConfigResponse;
        }
    }
}
