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
using Aliyun.Acs.Kms.Model.V20160120;

namespace Aliyun.Acs.Kms.Transform.V20160120
{
    public class ListSecretsResponseUnmarshaller
    {
        public static ListSecretsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListSecretsResponse listSecretsResponse = new ListSecretsResponse();

			listSecretsResponse.HttpResponse = _ctx.HttpResponse;
			listSecretsResponse.PageNumber = _ctx.IntegerValue("ListSecrets.PageNumber");
			listSecretsResponse.PageSize = _ctx.IntegerValue("ListSecrets.PageSize");
			listSecretsResponse.RequestId = _ctx.StringValue("ListSecrets.RequestId");
			listSecretsResponse.TotalCount = _ctx.IntegerValue("ListSecrets.TotalCount");

			List<ListSecretsResponse.ListSecrets_Secret> listSecretsResponse_secretList = new List<ListSecretsResponse.ListSecrets_Secret>();
			for (int i = 0; i < _ctx.Length("ListSecrets.SecretList.Length"); i++) {
				ListSecretsResponse.ListSecrets_Secret secret = new ListSecretsResponse.ListSecrets_Secret();
				secret.CreateTime = _ctx.StringValue("ListSecrets.SecretList["+ i +"].CreateTime");
				secret.PlannedDeleteTime = _ctx.StringValue("ListSecrets.SecretList["+ i +"].PlannedDeleteTime");
				secret.SecretName = _ctx.StringValue("ListSecrets.SecretList["+ i +"].SecretName");
				secret.UpdateTime = _ctx.StringValue("ListSecrets.SecretList["+ i +"].UpdateTime");
				secret.SecretType = _ctx.StringValue("ListSecrets.SecretList["+ i +"].SecretType");

				List<ListSecretsResponse.ListSecrets_Secret.ListSecrets_Tag> secret_tags = new List<ListSecretsResponse.ListSecrets_Secret.ListSecrets_Tag>();
				for (int j = 0; j < _ctx.Length("ListSecrets.SecretList["+ i +"].Tags.Length"); j++) {
					ListSecretsResponse.ListSecrets_Secret.ListSecrets_Tag tag = new ListSecretsResponse.ListSecrets_Secret.ListSecrets_Tag();
					tag.TagKey = _ctx.StringValue("ListSecrets.SecretList["+ i +"].Tags["+ j +"].TagKey");
					tag.TagValue = _ctx.StringValue("ListSecrets.SecretList["+ i +"].Tags["+ j +"].TagValue");

					secret_tags.Add(tag);
				}
				secret.Tags = secret_tags;

				listSecretsResponse_secretList.Add(secret);
			}
			listSecretsResponse.SecretList = listSecretsResponse_secretList;
        
			return listSecretsResponse;
        }
    }
}
