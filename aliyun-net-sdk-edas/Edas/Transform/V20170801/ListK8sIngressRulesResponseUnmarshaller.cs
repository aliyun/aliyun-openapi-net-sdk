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
    public class ListK8sIngressRulesResponseUnmarshaller
    {
        public static ListK8sIngressRulesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListK8sIngressRulesResponse listK8sIngressRulesResponse = new ListK8sIngressRulesResponse();

			listK8sIngressRulesResponse.HttpResponse = _ctx.HttpResponse;
			listK8sIngressRulesResponse.Code = _ctx.IntegerValue("ListK8sIngressRules.Code");
			listK8sIngressRulesResponse.Message = _ctx.StringValue("ListK8sIngressRules.Message");
			listK8sIngressRulesResponse.RequestId = _ctx.StringValue("ListK8sIngressRules.RequestId");

			List<ListK8sIngressRulesResponse.ListK8sIngressRules_DataItem> listK8sIngressRulesResponse_data = new List<ListK8sIngressRulesResponse.ListK8sIngressRules_DataItem>();
			for (int i = 0; i < _ctx.Length("ListK8sIngressRules.Data.Length"); i++) {
				ListK8sIngressRulesResponse.ListK8sIngressRules_DataItem dataItem = new ListK8sIngressRulesResponse.ListK8sIngressRules_DataItem();
				dataItem.ClusterName = _ctx.StringValue("ListK8sIngressRules.Data["+ i +"].ClusterName");
				dataItem.ClusterId = _ctx.StringValue("ListK8sIngressRules.Data["+ i +"].ClusterId");
				dataItem.RegionId = _ctx.StringValue("ListK8sIngressRules.Data["+ i +"].RegionId");

				List<ListK8sIngressRulesResponse.ListK8sIngressRules_DataItem.ListK8sIngressRules_IngressConfsItem> dataItem_ingressConfs = new List<ListK8sIngressRulesResponse.ListK8sIngressRules_DataItem.ListK8sIngressRules_IngressConfsItem>();
				for (int j = 0; j < _ctx.Length("ListK8sIngressRules.Data["+ i +"].IngressConfs.Length"); j++) {
					ListK8sIngressRulesResponse.ListK8sIngressRules_DataItem.ListK8sIngressRules_IngressConfsItem ingressConfsItem = new ListK8sIngressRulesResponse.ListK8sIngressRules_DataItem.ListK8sIngressRules_IngressConfsItem();
					ingressConfsItem.CreationTime = _ctx.StringValue("ListK8sIngressRules.Data["+ i +"].IngressConfs["+ j +"].CreationTime");
					ingressConfsItem.SslRedirect = _ctx.BooleanValue("ListK8sIngressRules.Data["+ i +"].IngressConfs["+ j +"].SslRedirect");
					ingressConfsItem.Endpoint = _ctx.StringValue("ListK8sIngressRules.Data["+ i +"].IngressConfs["+ j +"].Endpoint");
					ingressConfsItem._Namespace = _ctx.StringValue("ListK8sIngressRules.Data["+ i +"].IngressConfs["+ j +"].Namespace");
					ingressConfsItem.Name = _ctx.StringValue("ListK8sIngressRules.Data["+ i +"].IngressConfs["+ j +"].Name");
					ingressConfsItem.DashboardUrl = _ctx.StringValue("ListK8sIngressRules.Data["+ i +"].IngressConfs["+ j +"].DashboardUrl");

					List<ListK8sIngressRulesResponse.ListK8sIngressRules_DataItem.ListK8sIngressRules_IngressConfsItem.ListK8sIngressRules_RulesItem> ingressConfsItem_rules = new List<ListK8sIngressRulesResponse.ListK8sIngressRules_DataItem.ListK8sIngressRules_IngressConfsItem.ListK8sIngressRules_RulesItem>();
					for (int k = 0; k < _ctx.Length("ListK8sIngressRules.Data["+ i +"].IngressConfs["+ j +"].Rules.Length"); k++) {
						ListK8sIngressRulesResponse.ListK8sIngressRules_DataItem.ListK8sIngressRules_IngressConfsItem.ListK8sIngressRules_RulesItem rulesItem = new ListK8sIngressRulesResponse.ListK8sIngressRules_DataItem.ListK8sIngressRules_IngressConfsItem.ListK8sIngressRules_RulesItem();
						rulesItem.SecretName = _ctx.StringValue("ListK8sIngressRules.Data["+ i +"].IngressConfs["+ j +"].Rules["+ k +"].SecretName");
						rulesItem.Host = _ctx.StringValue("ListK8sIngressRules.Data["+ i +"].IngressConfs["+ j +"].Rules["+ k +"].Host");

						List<ListK8sIngressRulesResponse.ListK8sIngressRules_DataItem.ListK8sIngressRules_IngressConfsItem.ListK8sIngressRules_RulesItem.ListK8sIngressRules_PathsItem> rulesItem_paths = new List<ListK8sIngressRulesResponse.ListK8sIngressRules_DataItem.ListK8sIngressRules_IngressConfsItem.ListK8sIngressRules_RulesItem.ListK8sIngressRules_PathsItem>();
						for (int l = 0; l < _ctx.Length("ListK8sIngressRules.Data["+ i +"].IngressConfs["+ j +"].Rules["+ k +"].Paths.Length"); l++) {
							ListK8sIngressRulesResponse.ListK8sIngressRules_DataItem.ListK8sIngressRules_IngressConfsItem.ListK8sIngressRules_RulesItem.ListK8sIngressRules_PathsItem pathsItem = new ListK8sIngressRulesResponse.ListK8sIngressRules_DataItem.ListK8sIngressRules_IngressConfsItem.ListK8sIngressRules_RulesItem.ListK8sIngressRules_PathsItem();
							pathsItem.Status = _ctx.StringValue("ListK8sIngressRules.Data["+ i +"].IngressConfs["+ j +"].Rules["+ k +"].Paths["+ l +"].Status");
							pathsItem.Path = _ctx.StringValue("ListK8sIngressRules.Data["+ i +"].IngressConfs["+ j +"].Rules["+ k +"].Paths["+ l +"].Path");
							pathsItem.AppName = _ctx.StringValue("ListK8sIngressRules.Data["+ i +"].IngressConfs["+ j +"].Rules["+ k +"].Paths["+ l +"].AppName");
							pathsItem.AppId = _ctx.StringValue("ListK8sIngressRules.Data["+ i +"].IngressConfs["+ j +"].Rules["+ k +"].Paths["+ l +"].AppId");

							ListK8sIngressRulesResponse.ListK8sIngressRules_DataItem.ListK8sIngressRules_IngressConfsItem.ListK8sIngressRules_RulesItem.ListK8sIngressRules_PathsItem.ListK8sIngressRules_Backend backend = new ListK8sIngressRulesResponse.ListK8sIngressRules_DataItem.ListK8sIngressRules_IngressConfsItem.ListK8sIngressRules_RulesItem.ListK8sIngressRules_PathsItem.ListK8sIngressRules_Backend();
							backend.ServiceName = _ctx.StringValue("ListK8sIngressRules.Data["+ i +"].IngressConfs["+ j +"].Rules["+ k +"].Paths["+ l +"].Backend.ServiceName");
							backend.ServicePort = _ctx.StringValue("ListK8sIngressRules.Data["+ i +"].IngressConfs["+ j +"].Rules["+ k +"].Paths["+ l +"].Backend.ServicePort");
							pathsItem.Backend = backend;

							rulesItem_paths.Add(pathsItem);
						}
						rulesItem.Paths = rulesItem_paths;

						ingressConfsItem_rules.Add(rulesItem);
					}
					ingressConfsItem.Rules = ingressConfsItem_rules;

					dataItem_ingressConfs.Add(ingressConfsItem);
				}
				dataItem.IngressConfs = dataItem_ingressConfs;

				listK8sIngressRulesResponse_data.Add(dataItem);
			}
			listK8sIngressRulesResponse.Data = listK8sIngressRulesResponse_data;
        
			return listK8sIngressRulesResponse;
        }
    }
}
