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
    public class CreateCredentialsResponseUnmarshaller
    {
        public static CreateCredentialsResponse Unmarshall(UnmarshallerContext context)
        {
			CreateCredentialsResponse createCredentialsResponse = new CreateCredentialsResponse();

			createCredentialsResponse.HttpResponse = context.HttpResponse;
			createCredentialsResponse.Code = context.IntegerValue("CreateCredentials.Code");
			createCredentialsResponse.Message = context.StringValue("CreateCredentials.Message");
			createCredentialsResponse.RequestId = context.StringValue("CreateCredentials.RequestId");

			CreateCredentialsResponse.CreateCredentials_Data data = new CreateCredentialsResponse.CreateCredentials_Data();

			CreateCredentialsResponse.CreateCredentials_Data.CreateCredentials_Credentials credentials = new CreateCredentialsResponse.CreateCredentials_Data.CreateCredentials_Credentials();
			credentials.Id = context.LongValue("CreateCredentials.Data.Credentials.Id");

			CreateCredentialsResponse.CreateCredentials_Data.CreateCredentials_Credentials.CreateCredentials_CurrentCredential currentCredential = new CreateCredentialsResponse.CreateCredentials_Data.CreateCredentials_Credentials.CreateCredentials_CurrentCredential();
			currentCredential.SecretKey = context.StringValue("CreateCredentials.Data.Credentials.CurrentCredential.SecretKey");
			currentCredential.AccessKey = context.StringValue("CreateCredentials.Data.Credentials.CurrentCredential.AccessKey");
			credentials.CurrentCredential = currentCredential;
			data.Credentials = credentials;
			createCredentialsResponse.Data = data;
        
			return createCredentialsResponse;
        }
    }
}