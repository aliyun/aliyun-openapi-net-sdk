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
    public class ListSecretsResponseUnmarshaller
    {
        public static ListSecretsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListSecretsResponse listSecretsResponse = new ListSecretsResponse();

			listSecretsResponse.HttpResponse = _ctx.HttpResponse;
			listSecretsResponse.RequestId = _ctx.StringValue("ListSecrets.RequestId");
			listSecretsResponse.Message = _ctx.StringValue("ListSecrets.Message");
			listSecretsResponse.TraceId = _ctx.StringValue("ListSecrets.TraceId");
			listSecretsResponse.ErrorCode = _ctx.StringValue("ListSecrets.ErrorCode");
			listSecretsResponse.Code = _ctx.StringValue("ListSecrets.Code");
			listSecretsResponse.Success = _ctx.BooleanValue("ListSecrets.Success");

			ListSecretsResponse.ListSecrets_Data data = new ListSecretsResponse.ListSecrets_Data();

			List<ListSecretsResponse.ListSecrets_Data.ListSecrets_Secret> data_secrets = new List<ListSecretsResponse.ListSecrets_Data.ListSecrets_Secret>();
			for (int i = 0; i < _ctx.Length("ListSecrets.Data.Secrets.Length"); i++) {
				ListSecretsResponse.ListSecrets_Data.ListSecrets_Secret secret = new ListSecretsResponse.ListSecrets_Data.ListSecrets_Secret();
				secret.NamespaceId = _ctx.StringValue("ListSecrets.Data.Secrets["+ i +"].NamespaceId");
				secret.SecretId = _ctx.LongValue("ListSecrets.Data.Secrets["+ i +"].SecretId");
				secret.SecretName = _ctx.StringValue("ListSecrets.Data.Secrets["+ i +"].SecretName");
				secret.SecretType = _ctx.StringValue("ListSecrets.Data.Secrets["+ i +"].SecretType");
				secret.SecretData = _ctx.StringValue("ListSecrets.Data.Secrets["+ i +"].SecretData");
				secret.CreateTime = _ctx.LongValue("ListSecrets.Data.Secrets["+ i +"].CreateTime");
				secret.UpdateTime = _ctx.LongValue("ListSecrets.Data.Secrets["+ i +"].UpdateTime");

				List<ListSecretsResponse.ListSecrets_Data.ListSecrets_Secret.ListSecrets_RelateApp> secret_relateApps = new List<ListSecretsResponse.ListSecrets_Data.ListSecrets_Secret.ListSecrets_RelateApp>();
				for (int j = 0; j < _ctx.Length("ListSecrets.Data.Secrets["+ i +"].RelateApps.Length"); j++) {
					ListSecretsResponse.ListSecrets_Data.ListSecrets_Secret.ListSecrets_RelateApp relateApp = new ListSecretsResponse.ListSecrets_Data.ListSecrets_Secret.ListSecrets_RelateApp();
					relateApp.AppName = _ctx.StringValue("ListSecrets.Data.Secrets["+ i +"].RelateApps["+ j +"].AppName");
					relateApp.AppId = _ctx.StringValue("ListSecrets.Data.Secrets["+ i +"].RelateApps["+ j +"].AppId");

					secret_relateApps.Add(relateApp);
				}
				secret.RelateApps = secret_relateApps;

				data_secrets.Add(secret);
			}
			data.Secrets = data_secrets;
			listSecretsResponse.Data = data;
        
			return listSecretsResponse;
        }
    }
}
