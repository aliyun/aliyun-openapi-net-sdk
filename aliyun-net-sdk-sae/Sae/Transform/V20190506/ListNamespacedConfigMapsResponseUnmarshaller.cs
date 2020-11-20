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
    public class ListNamespacedConfigMapsResponseUnmarshaller
    {
        public static ListNamespacedConfigMapsResponse Unmarshall(UnmarshallerContext context)
        {
			ListNamespacedConfigMapsResponse listNamespacedConfigMapsResponse = new ListNamespacedConfigMapsResponse();

			listNamespacedConfigMapsResponse.HttpResponse = context.HttpResponse;
			listNamespacedConfigMapsResponse.RequestId = context.StringValue("ListNamespacedConfigMaps.RequestId");
			listNamespacedConfigMapsResponse.Code = context.StringValue("ListNamespacedConfigMaps.Code");
			listNamespacedConfigMapsResponse.Message = context.StringValue("ListNamespacedConfigMaps.Message");
			listNamespacedConfigMapsResponse.ErrorCode = context.StringValue("ListNamespacedConfigMaps.ErrorCode");
			listNamespacedConfigMapsResponse.TraceId = context.StringValue("ListNamespacedConfigMaps.TraceId");
			listNamespacedConfigMapsResponse.Success = context.BooleanValue("ListNamespacedConfigMaps.Success");

			ListNamespacedConfigMapsResponse.ListNamespacedConfigMaps_Data data = new ListNamespacedConfigMapsResponse.ListNamespacedConfigMaps_Data();

			List<ListNamespacedConfigMapsResponse.ListNamespacedConfigMaps_Data.ListNamespacedConfigMaps_ConfigMap> data_configMaps = new List<ListNamespacedConfigMapsResponse.ListNamespacedConfigMaps_Data.ListNamespacedConfigMaps_ConfigMap>();
			for (int i = 0; i < context.Length("ListNamespacedConfigMaps.Data.ConfigMaps.Length"); i++) {
				ListNamespacedConfigMapsResponse.ListNamespacedConfigMaps_Data.ListNamespacedConfigMaps_ConfigMap configMap = new ListNamespacedConfigMapsResponse.ListNamespacedConfigMaps_Data.ListNamespacedConfigMaps_ConfigMap();
				configMap.ConfigMapId = context.LongValue("ListNamespacedConfigMaps.Data.ConfigMaps["+ i +"].ConfigMapId");
				configMap.Name = context.StringValue("ListNamespacedConfigMaps.Data.ConfigMaps["+ i +"].Name");
				configMap.NamespaceId = context.StringValue("ListNamespacedConfigMaps.Data.ConfigMaps["+ i +"].NamespaceId");
				configMap.Description = context.StringValue("ListNamespacedConfigMaps.Data.ConfigMaps["+ i +"].Description");
				configMap.Data = context.StringValue("ListNamespacedConfigMaps.Data.ConfigMaps["+ i +"].Data");
				configMap.CreateTime = context.LongValue("ListNamespacedConfigMaps.Data.ConfigMaps["+ i +"].CreateTime");
				configMap.UpdateTime = context.LongValue("ListNamespacedConfigMaps.Data.ConfigMaps["+ i +"].UpdateTime");

				List<ListNamespacedConfigMapsResponse.ListNamespacedConfigMaps_Data.ListNamespacedConfigMaps_ConfigMap.ListNamespacedConfigMaps_RelateApp> configMap_relateApps = new List<ListNamespacedConfigMapsResponse.ListNamespacedConfigMaps_Data.ListNamespacedConfigMaps_ConfigMap.ListNamespacedConfigMaps_RelateApp>();
				for (int j = 0; j < context.Length("ListNamespacedConfigMaps.Data.ConfigMaps["+ i +"].RelateApps.Length"); j++) {
					ListNamespacedConfigMapsResponse.ListNamespacedConfigMaps_Data.ListNamespacedConfigMaps_ConfigMap.ListNamespacedConfigMaps_RelateApp relateApp = new ListNamespacedConfigMapsResponse.ListNamespacedConfigMaps_Data.ListNamespacedConfigMaps_ConfigMap.ListNamespacedConfigMaps_RelateApp();
					relateApp.AppId = context.StringValue("ListNamespacedConfigMaps.Data.ConfigMaps["+ i +"].RelateApps["+ j +"].AppId");
					relateApp.AppName = context.StringValue("ListNamespacedConfigMaps.Data.ConfigMaps["+ i +"].RelateApps["+ j +"].AppName");

					configMap_relateApps.Add(relateApp);
				}
				configMap.RelateApps = configMap_relateApps;

				data_configMaps.Add(configMap);
			}
			data.ConfigMaps = data_configMaps;
			listNamespacedConfigMapsResponse.Data = data;
        
			return listNamespacedConfigMapsResponse;
        }
    }
}
