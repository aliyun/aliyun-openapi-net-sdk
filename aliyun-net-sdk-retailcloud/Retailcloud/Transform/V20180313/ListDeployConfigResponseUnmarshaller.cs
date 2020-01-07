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
        public static ListDeployConfigResponse Unmarshall(UnmarshallerContext context)
        {
			ListDeployConfigResponse listDeployConfigResponse = new ListDeployConfigResponse();

			listDeployConfigResponse.HttpResponse = context.HttpResponse;
			listDeployConfigResponse.Code = context.IntegerValue("ListDeployConfig.Code");
			listDeployConfigResponse.ErrorMsg = context.StringValue("ListDeployConfig.ErrorMsg");
			listDeployConfigResponse.PageNumber = context.IntegerValue("ListDeployConfig.PageNumber");
			listDeployConfigResponse.PageSize = context.IntegerValue("ListDeployConfig.PageSize");
			listDeployConfigResponse.RequestId = context.StringValue("ListDeployConfig.RequestId");
			listDeployConfigResponse.TotalCount = context.LongValue("ListDeployConfig.TotalCount");

			List<ListDeployConfigResponse.ListDeployConfig_DeployConfigInstance> listDeployConfigResponse_data = new List<ListDeployConfigResponse.ListDeployConfig_DeployConfigInstance>();
			for (int i = 0; i < context.Length("ListDeployConfig.Data.Length"); i++) {
				ListDeployConfigResponse.ListDeployConfig_DeployConfigInstance deployConfigInstance = new ListDeployConfigResponse.ListDeployConfig_DeployConfigInstance();
				deployConfigInstance.Id = context.LongValue("ListDeployConfig.Data["+ i +"].Id");
				deployConfigInstance.Name = context.StringValue("ListDeployConfig.Data["+ i +"].Name");
				deployConfigInstance.AppId = context.LongValue("ListDeployConfig.Data["+ i +"].AppId");
				deployConfigInstance.EnvType = context.StringValue("ListDeployConfig.Data["+ i +"].EnvType");

				ListDeployConfigResponse.ListDeployConfig_DeployConfigInstance.ListDeployConfig_ContainerCodePath containerCodePath = new ListDeployConfigResponse.ListDeployConfig_DeployConfigInstance.ListDeployConfig_ContainerCodePath();
				containerCodePath.CodePath = context.StringValue("ListDeployConfig.Data["+ i +"].ContainerCodePath.CodePath");
				deployConfigInstance.ContainerCodePath = containerCodePath;

				ListDeployConfigResponse.ListDeployConfig_DeployConfigInstance.ListDeployConfig_ContainerYamlConf containerYamlConf = new ListDeployConfigResponse.ListDeployConfig_DeployConfigInstance.ListDeployConfig_ContainerYamlConf();
				containerYamlConf.Deployment = context.StringValue("ListDeployConfig.Data["+ i +"].ContainerYamlConf.Deployment");
				containerYamlConf.ConfigMap = context.StringValue("ListDeployConfig.Data["+ i +"].ContainerYamlConf.ConfigMap");
				containerYamlConf.StatefulSet = context.StringValue("ListDeployConfig.Data["+ i +"].ContainerYamlConf.StatefulSet");
				deployConfigInstance.ContainerYamlConf = containerYamlConf;

				listDeployConfigResponse_data.Add(deployConfigInstance);
			}
			listDeployConfigResponse.Data = listDeployConfigResponse_data;
        
			return listDeployConfigResponse;
        }
    }
}
