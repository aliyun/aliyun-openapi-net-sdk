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
    public class ListK8sConfigMapsResponseUnmarshaller
    {
        public static ListK8sConfigMapsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListK8sConfigMapsResponse listK8sConfigMapsResponse = new ListK8sConfigMapsResponse();

			listK8sConfigMapsResponse.HttpResponse = _ctx.HttpResponse;
			listK8sConfigMapsResponse.RequestId = _ctx.StringValue("ListK8sConfigMaps.RequestId");
			listK8sConfigMapsResponse.Code = _ctx.IntegerValue("ListK8sConfigMaps.Code");
			listK8sConfigMapsResponse.Message = _ctx.StringValue("ListK8sConfigMaps.Message");

			List<ListK8sConfigMapsResponse.ListK8sConfigMaps_ResultItem> listK8sConfigMapsResponse_result = new List<ListK8sConfigMapsResponse.ListK8sConfigMaps_ResultItem>();
			for (int i = 0; i < _ctx.Length("ListK8sConfigMaps.Result.Length"); i++) {
				ListK8sConfigMapsResponse.ListK8sConfigMaps_ResultItem resultItem = new ListK8sConfigMapsResponse.ListK8sConfigMaps_ResultItem();
				resultItem.Total = _ctx.IntegerValue("ListK8sConfigMaps.Result["+ i +"].Total");

				List<ListK8sConfigMapsResponse.ListK8sConfigMaps_ResultItem.ListK8sConfigMaps_ConfigMapsItem> resultItem_configMaps = new List<ListK8sConfigMapsResponse.ListK8sConfigMaps_ResultItem.ListK8sConfigMaps_ConfigMapsItem>();
				for (int j = 0; j < _ctx.Length("ListK8sConfigMaps.Result["+ i +"].ConfigMaps.Length"); j++) {
					ListK8sConfigMapsResponse.ListK8sConfigMaps_ResultItem.ListK8sConfigMaps_ConfigMapsItem configMapsItem = new ListK8sConfigMapsResponse.ListK8sConfigMaps_ResultItem.ListK8sConfigMaps_ConfigMapsItem();
					configMapsItem.Name = _ctx.StringValue("ListK8sConfigMaps.Result["+ i +"].ConfigMaps["+ j +"].Name");
					configMapsItem._Namespace = _ctx.StringValue("ListK8sConfigMaps.Result["+ i +"].ConfigMaps["+ j +"].Namespace");
					configMapsItem.ClusterId = _ctx.StringValue("ListK8sConfigMaps.Result["+ i +"].ConfigMaps["+ j +"].ClusterId");
					configMapsItem.ClusterName = _ctx.StringValue("ListK8sConfigMaps.Result["+ i +"].ConfigMaps["+ j +"].ClusterName");
					configMapsItem.CreationTime = _ctx.StringValue("ListK8sConfigMaps.Result["+ i +"].ConfigMaps["+ j +"].CreationTime");

					List<ListK8sConfigMapsResponse.ListK8sConfigMaps_ResultItem.ListK8sConfigMaps_ConfigMapsItem.ListK8sConfigMaps_DataItem> configMapsItem_data = new List<ListK8sConfigMapsResponse.ListK8sConfigMaps_ResultItem.ListK8sConfigMaps_ConfigMapsItem.ListK8sConfigMaps_DataItem>();
					for (int k = 0; k < _ctx.Length("ListK8sConfigMaps.Result["+ i +"].ConfigMaps["+ j +"].Data.Length"); k++) {
						ListK8sConfigMapsResponse.ListK8sConfigMaps_ResultItem.ListK8sConfigMaps_ConfigMapsItem.ListK8sConfigMaps_DataItem dataItem = new ListK8sConfigMapsResponse.ListK8sConfigMaps_ResultItem.ListK8sConfigMaps_ConfigMapsItem.ListK8sConfigMaps_DataItem();
						dataItem.Key = _ctx.StringValue("ListK8sConfigMaps.Result["+ i +"].ConfigMaps["+ j +"].Data["+ k +"].Key");
						dataItem._Value = _ctx.StringValue("ListK8sConfigMaps.Result["+ i +"].ConfigMaps["+ j +"].Data["+ k +"].Value");

						configMapsItem_data.Add(dataItem);
					}
					configMapsItem.Data = configMapsItem_data;

					List<ListK8sConfigMapsResponse.ListK8sConfigMaps_ResultItem.ListK8sConfigMaps_ConfigMapsItem.ListK8sConfigMaps_RelatedAppsItem> configMapsItem_relatedApps = new List<ListK8sConfigMapsResponse.ListK8sConfigMaps_ResultItem.ListK8sConfigMaps_ConfigMapsItem.ListK8sConfigMaps_RelatedAppsItem>();
					for (int k = 0; k < _ctx.Length("ListK8sConfigMaps.Result["+ i +"].ConfigMaps["+ j +"].RelatedApps.Length"); k++) {
						ListK8sConfigMapsResponse.ListK8sConfigMaps_ResultItem.ListK8sConfigMaps_ConfigMapsItem.ListK8sConfigMaps_RelatedAppsItem relatedAppsItem = new ListK8sConfigMapsResponse.ListK8sConfigMaps_ResultItem.ListK8sConfigMaps_ConfigMapsItem.ListK8sConfigMaps_RelatedAppsItem();
						relatedAppsItem.AppName = _ctx.StringValue("ListK8sConfigMaps.Result["+ i +"].ConfigMaps["+ j +"].RelatedApps["+ k +"].AppName");
						relatedAppsItem.AppId = _ctx.StringValue("ListK8sConfigMaps.Result["+ i +"].ConfigMaps["+ j +"].RelatedApps["+ k +"].AppId");

						configMapsItem_relatedApps.Add(relatedAppsItem);
					}
					configMapsItem.RelatedApps = configMapsItem_relatedApps;

					resultItem_configMaps.Add(configMapsItem);
				}
				resultItem.ConfigMaps = resultItem_configMaps;

				listK8sConfigMapsResponse_result.Add(resultItem);
			}
			listK8sConfigMapsResponse.Result = listK8sConfigMapsResponse_result;
        
			return listK8sConfigMapsResponse;
        }
    }
}
