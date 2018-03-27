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
    public class ReplaceCredentialResponseUnmarshaller
    {
        public static ReplaceCredentialResponse Unmarshall(UnmarshallerContext context)
        {
			ReplaceCredentialResponse replaceCredentialResponse = new ReplaceCredentialResponse();

			replaceCredentialResponse.HttpResponse = context.HttpResponse;
			replaceCredentialResponse.Code = context.IntegerValue("ReplaceCredential.Code");
			replaceCredentialResponse.Message = context.StringValue("ReplaceCredential.Message");
			replaceCredentialResponse.RequestId = context.StringValue("ReplaceCredential.RequestId");

			ReplaceCredentialResponse.ReplaceCredential_Data data = new ReplaceCredentialResponse.ReplaceCredential_Data();

			ReplaceCredentialResponse.ReplaceCredential_Data.ReplaceCredential_Credentials credentials = new ReplaceCredentialResponse.ReplaceCredential_Data.ReplaceCredential_Credentials();
			credentials.GmtCreate = context.LongValue("ReplaceCredential.Data.Credentials.GmtCreate");
			credentials.Id = context.LongValue("ReplaceCredential.Data.Credentials.Id");
			credentials.Name = context.StringValue("ReplaceCredential.Data.Credentials.Name");
			credentials.UserId = context.StringValue("ReplaceCredential.Data.Credentials.UserId");

			ReplaceCredentialResponse.ReplaceCredential_Data.ReplaceCredential_Credentials.ReplaceCredential_CurrentCredential currentCredential = new ReplaceCredentialResponse.ReplaceCredential_Data.ReplaceCredential_Credentials.ReplaceCredential_CurrentCredential();
			currentCredential.AccessKey = context.StringValue("ReplaceCredential.Data.Credentials.CurrentCredential.AccessKey");
			currentCredential.SecretKey = context.StringValue("ReplaceCredential.Data.Credentials.CurrentCredential.SecretKey");
			credentials.CurrentCredential = currentCredential;

			ReplaceCredentialResponse.ReplaceCredential_Data.ReplaceCredential_Credentials.ReplaceCredential_NewCredential newCredential = new ReplaceCredentialResponse.ReplaceCredential_Data.ReplaceCredential_Credentials.ReplaceCredential_NewCredential();
			newCredential.AccessKey = context.StringValue("ReplaceCredential.Data.Credentials.NewCredential.AccessKey");
			newCredential.SecretKey = context.StringValue("ReplaceCredential.Data.Credentials.NewCredential.SecretKey");
			credentials.NewCredential = newCredential;
			data.Credentials = credentials;
			replaceCredentialResponse.Data = data;
        
			return replaceCredentialResponse;
        }
    }
}