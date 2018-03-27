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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.CSB.Model.V20171118;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.CSB.Transform.V20171118
{
    public class FindCredentialsListResponseUnmarshaller
    {
        public static FindCredentialsListResponse Unmarshall(UnmarshallerContext context)
        {
			FindCredentialsListResponse findCredentialsListResponse = new FindCredentialsListResponse();

			findCredentialsListResponse.HttpResponse = context.HttpResponse;
			findCredentialsListResponse.Code = context.IntegerValue("FindCredentialsList.Code");
			findCredentialsListResponse.Message = context.StringValue("FindCredentialsList.Message");
			findCredentialsListResponse.RequestId = context.StringValue("FindCredentialsList.RequestId");

			FindCredentialsListResponse.FindCredentialsList_Data data = new FindCredentialsListResponse.FindCredentialsList_Data();
			data.CurrentPage = context.IntegerValue("FindCredentialsList.Data.CurrentPage");
			data.PageNumber = context.IntegerValue("FindCredentialsList.Data.PageNumber");

			List<FindCredentialsListResponse.FindCredentialsList_Data.FindCredentialsList_Credential> data_credentialList = new List<FindCredentialsListResponse.FindCredentialsList_Data.FindCredentialsList_Credential>();
			for (int i = 0; i < context.Length("FindCredentialsList.Data.CredentialList.Length"); i++) {
				FindCredentialsListResponse.FindCredentialsList_Data.FindCredentialsList_Credential credential = new FindCredentialsListResponse.FindCredentialsList_Data.FindCredentialsList_Credential();
				credential.GmtCreate = context.LongValue("FindCredentialsList.Data.CredentialList["+ i +"].GmtCreate");
				credential.Id = context.LongValue("FindCredentialsList.Data.CredentialList["+ i +"].Id");
				credential.Name = context.StringValue("FindCredentialsList.Data.CredentialList["+ i +"].Name");
				credential.OwnerAttr = context.StringValue("FindCredentialsList.Data.CredentialList["+ i +"].OwnerAttr");
				credential.UserId = context.StringValue("FindCredentialsList.Data.CredentialList["+ i +"].UserId");

				FindCredentialsListResponse.FindCredentialsList_Data.FindCredentialsList_Credential.FindCredentialsList_CurrentCredential currentCredential = new FindCredentialsListResponse.FindCredentialsList_Data.FindCredentialsList_Credential.FindCredentialsList_CurrentCredential();
				currentCredential.AccessKey = context.StringValue("FindCredentialsList.Data.CredentialList["+ i +"].CurrentCredential.AccessKey");
				currentCredential.SecretKey = context.StringValue("FindCredentialsList.Data.CredentialList["+ i +"].CurrentCredential.SecretKey");
				credential.CurrentCredential = currentCredential;

				FindCredentialsListResponse.FindCredentialsList_Data.FindCredentialsList_Credential.FindCredentialsList_NewCredential newCredential = new FindCredentialsListResponse.FindCredentialsList_Data.FindCredentialsList_Credential.FindCredentialsList_NewCredential();
				newCredential.AccessKey = context.StringValue("FindCredentialsList.Data.CredentialList["+ i +"].NewCredential.AccessKey");
				newCredential.SecretKey = context.StringValue("FindCredentialsList.Data.CredentialList["+ i +"].NewCredential.SecretKey");
				credential.NewCredential = newCredential;

				data_credentialList.Add(credential);
			}
			data.CredentialList = data_credentialList;
			findCredentialsListResponse.Data = data;
        
			return findCredentialsListResponse;
        }
    }
}