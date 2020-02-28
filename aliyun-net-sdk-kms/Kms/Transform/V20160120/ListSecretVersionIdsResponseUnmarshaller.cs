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
    public class ListSecretVersionIdsResponseUnmarshaller
    {
        public static ListSecretVersionIdsResponse Unmarshall(UnmarshallerContext context)
        {
			ListSecretVersionIdsResponse listSecretVersionIdsResponse = new ListSecretVersionIdsResponse();

			listSecretVersionIdsResponse.HttpResponse = context.HttpResponse;
			listSecretVersionIdsResponse.PageNumber = context.IntegerValue("ListSecretVersionIds.PageNumber");
			listSecretVersionIdsResponse.PageSize = context.IntegerValue("ListSecretVersionIds.PageSize");
			listSecretVersionIdsResponse.RequestId = context.StringValue("ListSecretVersionIds.RequestId");
			listSecretVersionIdsResponse.SecretName = context.StringValue("ListSecretVersionIds.SecretName");
			listSecretVersionIdsResponse.TotalCount = context.IntegerValue("ListSecretVersionIds.TotalCount");

			List<ListSecretVersionIdsResponse.ListSecretVersionIds_VersionId> listSecretVersionIdsResponse_versionIds = new List<ListSecretVersionIdsResponse.ListSecretVersionIds_VersionId>();
			for (int i = 0; i < context.Length("ListSecretVersionIds.VersionIds.Length"); i++) {
				ListSecretVersionIdsResponse.ListSecretVersionIds_VersionId versionId = new ListSecretVersionIdsResponse.ListSecretVersionIds_VersionId();
				versionId.CreateTime = context.StringValue("ListSecretVersionIds.VersionIds["+ i +"].CreateTime");
				versionId.VersionId = context.StringValue("ListSecretVersionIds.VersionIds["+ i +"].VersionId");

				List<string> versionId_versionStages = new List<string>();
				for (int j = 0; j < context.Length("ListSecretVersionIds.VersionIds["+ i +"].VersionStages.Length"); j++) {
					versionId_versionStages.Add(context.StringValue("ListSecretVersionIds.VersionIds["+ i +"].VersionStages["+ j +"]"));
				}
				versionId.VersionStages = versionId_versionStages;

				listSecretVersionIdsResponse_versionIds.Add(versionId);
			}
			listSecretVersionIdsResponse.VersionIds = listSecretVersionIdsResponse_versionIds;
        
			return listSecretVersionIdsResponse;
        }
    }
}
