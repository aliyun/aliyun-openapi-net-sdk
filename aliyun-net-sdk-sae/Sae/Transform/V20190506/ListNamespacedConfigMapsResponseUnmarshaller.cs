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
        public static ListNamespacedConfigMapsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListNamespacedConfigMapsResponse listNamespacedConfigMapsResponse = new ListNamespacedConfigMapsResponse();

			listNamespacedConfigMapsResponse.HttpResponse = _ctx.HttpResponse;
			listNamespacedConfigMapsResponse.RequestId = _ctx.StringValue("ListNamespacedConfigMaps.RequestId");
			listNamespacedConfigMapsResponse.Code = _ctx.StringValue("ListNamespacedConfigMaps.Code");
			listNamespacedConfigMapsResponse.Message = _ctx.StringValue("ListNamespacedConfigMaps.Message");
			listNamespacedConfigMapsResponse.ErrorCode = _ctx.StringValue("ListNamespacedConfigMaps.ErrorCode");
			listNamespacedConfigMapsResponse.TraceId = _ctx.StringValue("ListNamespacedConfigMaps.TraceId");
			listNamespacedConfigMapsResponse.Success = _ctx.BooleanValue("ListNamespacedConfigMaps.Success");

			ListNamespacedConfigMapsResponse.ListNamespacedConfigMaps_Data data = new ListNamespacedConfigMapsResponse.ListNamespacedConfigMaps_Data();

			List<ListNamespacedConfigMapsResponse.ListNamespacedConfigMaps_Data.ListNamespacedConfigMaps_ConfigMap> data_configMaps = new List<ListNamespacedConfigMapsResponse.ListNamespacedConfigMaps_Data.ListNamespacedConfigMaps_ConfigMap>();
			for (int i = 0; i < _ctx.Length("ListNamespacedConfigMaps.Data.ConfigMaps.Length"); i++) {
				ListNamespacedConfigMapsResponse.ListNamespacedConfigMaps_Data.ListNamespacedConfigMaps_ConfigMap configMap = new ListNamespacedConfigMapsResponse.ListNamespacedConfigMaps_Data.ListNamespacedConfigMaps_ConfigMap();
				configMap.ConfigMapId = _ctx.LongValue("ListNamespacedConfigMaps.Data.ConfigMaps["+ i +"].ConfigMapId");
				configMap.Name = _ctx.StringValue("ListNamespacedConfigMaps.Data.ConfigMaps["+ i +"].Name");
				configMap.NamespaceId = _ctx.StringValue("ListNamespacedConfigMaps.Data.ConfigMaps["+ i +"].NamespaceId");
				configMap.Description = _ctx.StringValue("ListNamespacedConfigMaps.Data.ConfigMaps["+ i +"].Description");
				configMap.Data = _ctx.StringValue("ListNamespacedConfigMaps.Data.ConfigMaps["+ i +"].Data");
				configMap.CreateTime = _ctx.LongValue("ListNamespacedConfigMaps.Data.ConfigMaps["+ i +"].CreateTime");
				configMap.UpdateTime = _ctx.LongValue("ListNamespacedConfigMaps.Data.ConfigMaps["+ i +"].UpdateTime");

				List<ListNamespacedConfigMapsResponse.ListNamespacedConfigMaps_Data.ListNamespacedConfigMaps_ConfigMap.ListNamespacedConfigMaps_RelateApp> configMap_relateApps = new List<ListNamespacedConfigMapsResponse.ListNamespacedConfigMaps_Data.ListNamespacedConfigMaps_ConfigMap.ListNamespacedConfigMaps_RelateApp>();
				for (int j = 0; j < _ctx.Length("ListNamespacedConfigMaps.Data.ConfigMaps["+ i +"].RelateApps.Length"); j++) {
					ListNamespacedConfigMapsResponse.ListNamespacedConfigMaps_Data.ListNamespacedConfigMaps_ConfigMap.ListNamespacedConfigMaps_RelateApp relateApp = new ListNamespacedConfigMapsResponse.ListNamespacedConfigMaps_Data.ListNamespacedConfigMaps_ConfigMap.ListNamespacedConfigMaps_RelateApp();
					relateApp.AppId = _ctx.StringValue("ListNamespacedConfigMaps.Data.ConfigMaps["+ i +"].RelateApps["+ j +"].AppId");
					relateApp.AppName = _ctx.StringValue("ListNamespacedConfigMaps.Data.ConfigMaps["+ i +"].RelateApps["+ j +"].AppName");

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
