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
    public class ListK8sSecretsResponseUnmarshaller
    {
        public static ListK8sSecretsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListK8sSecretsResponse listK8sSecretsResponse = new ListK8sSecretsResponse();

			listK8sSecretsResponse.HttpResponse = _ctx.HttpResponse;
			listK8sSecretsResponse.Code = _ctx.IntegerValue("ListK8sSecrets.Code");
			listK8sSecretsResponse.Message = _ctx.StringValue("ListK8sSecrets.Message");
			listK8sSecretsResponse.RequestId = _ctx.StringValue("ListK8sSecrets.RequestId");

			List<ListK8sSecretsResponse.ListK8sSecrets_ResultItem> listK8sSecretsResponse_result = new List<ListK8sSecretsResponse.ListK8sSecrets_ResultItem>();
			for (int i = 0; i < _ctx.Length("ListK8sSecrets.Result.Length"); i++) {
				ListK8sSecretsResponse.ListK8sSecrets_ResultItem resultItem = new ListK8sSecretsResponse.ListK8sSecrets_ResultItem();
				resultItem.Total = _ctx.IntegerValue("ListK8sSecrets.Result["+ i +"].Total");

				List<ListK8sSecretsResponse.ListK8sSecrets_ResultItem.ListK8sSecrets_SecretsItem> resultItem_secrets = new List<ListK8sSecretsResponse.ListK8sSecrets_ResultItem.ListK8sSecrets_SecretsItem>();
				for (int j = 0; j < _ctx.Length("ListK8sSecrets.Result["+ i +"].Secrets.Length"); j++) {
					ListK8sSecretsResponse.ListK8sSecrets_ResultItem.ListK8sSecrets_SecretsItem secretsItem = new ListK8sSecretsResponse.ListK8sSecrets_ResultItem.ListK8sSecrets_SecretsItem();
					secretsItem.Type = _ctx.StringValue("ListK8sSecrets.Result["+ i +"].Secrets["+ j +"].Type");
					secretsItem.CreationTime = _ctx.StringValue("ListK8sSecrets.Result["+ i +"].Secrets["+ j +"].CreationTime");
					secretsItem.ClusterName = _ctx.StringValue("ListK8sSecrets.Result["+ i +"].Secrets["+ j +"].ClusterName");
					secretsItem._Namespace = _ctx.StringValue("ListK8sSecrets.Result["+ i +"].Secrets["+ j +"].Namespace");
					secretsItem.Base64Encoded = _ctx.BooleanValue("ListK8sSecrets.Result["+ i +"].Secrets["+ j +"].Base64Encoded");
					secretsItem.CertRegionId = _ctx.StringValue("ListK8sSecrets.Result["+ i +"].Secrets["+ j +"].CertRegionId");
					secretsItem.CertId = _ctx.StringValue("ListK8sSecrets.Result["+ i +"].Secrets["+ j +"].CertId");
					secretsItem.Name = _ctx.StringValue("ListK8sSecrets.Result["+ i +"].Secrets["+ j +"].Name");
					secretsItem.ClusterId = _ctx.StringValue("ListK8sSecrets.Result["+ i +"].Secrets["+ j +"].ClusterId");

					ListK8sSecretsResponse.ListK8sSecrets_ResultItem.ListK8sSecrets_SecretsItem.ListK8sSecrets_CertDetail certDetail = new ListK8sSecretsResponse.ListK8sSecrets_ResultItem.ListK8sSecrets_SecretsItem.ListK8sSecrets_CertDetail();
					certDetail.EndTime = _ctx.StringValue("ListK8sSecrets.Result["+ i +"].Secrets["+ j +"].CertDetail.EndTime");
					certDetail.Status = _ctx.StringValue("ListK8sSecrets.Result["+ i +"].Secrets["+ j +"].CertDetail.Status");
					certDetail.StartTime = _ctx.StringValue("ListK8sSecrets.Result["+ i +"].Secrets["+ j +"].CertDetail.StartTime");
					certDetail.Issuer = _ctx.StringValue("ListK8sSecrets.Result["+ i +"].Secrets["+ j +"].CertDetail.Issuer");

					List<string> certDetail_domainNames = new List<string>();
					for (int k = 0; k < _ctx.Length("ListK8sSecrets.Result["+ i +"].Secrets["+ j +"].CertDetail.DomainNames.Length"); k++) {
						certDetail_domainNames.Add(_ctx.StringValue("ListK8sSecrets.Result["+ i +"].Secrets["+ j +"].CertDetail.DomainNames["+ k +"]"));
					}
					certDetail.DomainNames = certDetail_domainNames;
					secretsItem.CertDetail = certDetail;

					List<ListK8sSecretsResponse.ListK8sSecrets_ResultItem.ListK8sSecrets_SecretsItem.ListK8sSecrets_RelatedIngressRulesItem> secretsItem_relatedIngressRules = new List<ListK8sSecretsResponse.ListK8sSecrets_ResultItem.ListK8sSecrets_SecretsItem.ListK8sSecrets_RelatedIngressRulesItem>();
					for (int k = 0; k < _ctx.Length("ListK8sSecrets.Result["+ i +"].Secrets["+ j +"].RelatedIngressRules.Length"); k++) {
						ListK8sSecretsResponse.ListK8sSecrets_ResultItem.ListK8sSecrets_SecretsItem.ListK8sSecrets_RelatedIngressRulesItem relatedIngressRulesItem = new ListK8sSecretsResponse.ListK8sSecrets_ResultItem.ListK8sSecrets_SecretsItem.ListK8sSecrets_RelatedIngressRulesItem();
						relatedIngressRulesItem.Name = _ctx.StringValue("ListK8sSecrets.Result["+ i +"].Secrets["+ j +"].RelatedIngressRules["+ k +"].Name");
						relatedIngressRulesItem._Namespace = _ctx.StringValue("ListK8sSecrets.Result["+ i +"].Secrets["+ j +"].RelatedIngressRules["+ k +"].Namespace");

						List<ListK8sSecretsResponse.ListK8sSecrets_ResultItem.ListK8sSecrets_SecretsItem.ListK8sSecrets_RelatedIngressRulesItem.ListK8sSecrets_RelatedAppsItem> relatedIngressRulesItem_relatedApps1 = new List<ListK8sSecretsResponse.ListK8sSecrets_ResultItem.ListK8sSecrets_SecretsItem.ListK8sSecrets_RelatedIngressRulesItem.ListK8sSecrets_RelatedAppsItem>();
						for (int l = 0; l < _ctx.Length("ListK8sSecrets.Result["+ i +"].Secrets["+ j +"].RelatedIngressRules["+ k +"].RelatedApps.Length"); l++) {
							ListK8sSecretsResponse.ListK8sSecrets_ResultItem.ListK8sSecrets_SecretsItem.ListK8sSecrets_RelatedIngressRulesItem.ListK8sSecrets_RelatedAppsItem relatedAppsItem = new ListK8sSecretsResponse.ListK8sSecrets_ResultItem.ListK8sSecrets_SecretsItem.ListK8sSecrets_RelatedIngressRulesItem.ListK8sSecrets_RelatedAppsItem();
							relatedAppsItem.AppName = _ctx.StringValue("ListK8sSecrets.Result["+ i +"].Secrets["+ j +"].RelatedIngressRules["+ k +"].RelatedApps["+ l +"].AppName");
							relatedAppsItem.AppId = _ctx.StringValue("ListK8sSecrets.Result["+ i +"].Secrets["+ j +"].RelatedIngressRules["+ k +"].RelatedApps["+ l +"].AppId");

							relatedIngressRulesItem_relatedApps1.Add(relatedAppsItem);
						}
						relatedIngressRulesItem.RelatedApps1 = relatedIngressRulesItem_relatedApps1;

						secretsItem_relatedIngressRules.Add(relatedIngressRulesItem);
					}
					secretsItem.RelatedIngressRules = secretsItem_relatedIngressRules;

					List<ListK8sSecretsResponse.ListK8sSecrets_ResultItem.ListK8sSecrets_SecretsItem.ListK8sSecrets_DataItem> secretsItem_data = new List<ListK8sSecretsResponse.ListK8sSecrets_ResultItem.ListK8sSecrets_SecretsItem.ListK8sSecrets_DataItem>();
					for (int k = 0; k < _ctx.Length("ListK8sSecrets.Result["+ i +"].Secrets["+ j +"].Data.Length"); k++) {
						ListK8sSecretsResponse.ListK8sSecrets_ResultItem.ListK8sSecrets_SecretsItem.ListK8sSecrets_DataItem dataItem = new ListK8sSecretsResponse.ListK8sSecrets_ResultItem.ListK8sSecrets_SecretsItem.ListK8sSecrets_DataItem();
						dataItem.Key = _ctx.StringValue("ListK8sSecrets.Result["+ i +"].Secrets["+ j +"].Data["+ k +"].Key");
						dataItem._Value = _ctx.StringValue("ListK8sSecrets.Result["+ i +"].Secrets["+ j +"].Data["+ k +"].Value");

						secretsItem_data.Add(dataItem);
					}
					secretsItem.Data = secretsItem_data;

					List<ListK8sSecretsResponse.ListK8sSecrets_ResultItem.ListK8sSecrets_SecretsItem.ListK8sSecrets_RelatedAppsItem2> secretsItem_relatedApps = new List<ListK8sSecretsResponse.ListK8sSecrets_ResultItem.ListK8sSecrets_SecretsItem.ListK8sSecrets_RelatedAppsItem2>();
					for (int k = 0; k < _ctx.Length("ListK8sSecrets.Result["+ i +"].Secrets["+ j +"].RelatedApps.Length"); k++) {
						ListK8sSecretsResponse.ListK8sSecrets_ResultItem.ListK8sSecrets_SecretsItem.ListK8sSecrets_RelatedAppsItem2 relatedAppsItem2 = new ListK8sSecretsResponse.ListK8sSecrets_ResultItem.ListK8sSecrets_SecretsItem.ListK8sSecrets_RelatedAppsItem2();
						relatedAppsItem2.AppName = _ctx.StringValue("ListK8sSecrets.Result["+ i +"].Secrets["+ j +"].RelatedApps["+ k +"].AppName");
						relatedAppsItem2.AppId = _ctx.StringValue("ListK8sSecrets.Result["+ i +"].Secrets["+ j +"].RelatedApps["+ k +"].AppId");

						secretsItem_relatedApps.Add(relatedAppsItem2);
					}
					secretsItem.RelatedApps = secretsItem_relatedApps;

					resultItem_secrets.Add(secretsItem);
				}
				resultItem.Secrets = resultItem_secrets;

				listK8sSecretsResponse_result.Add(resultItem);
			}
			listK8sSecretsResponse.Result = listK8sSecretsResponse_result;
        
			return listK8sSecretsResponse;
        }
    }
}
