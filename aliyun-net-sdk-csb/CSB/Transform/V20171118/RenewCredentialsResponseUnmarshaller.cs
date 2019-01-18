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
    public class RenewCredentialsResponseUnmarshaller
    {
        public static RenewCredentialsResponse Unmarshall(UnmarshallerContext context)
        {
			RenewCredentialsResponse renewCredentialsResponse = new RenewCredentialsResponse();

			renewCredentialsResponse.HttpResponse = context.HttpResponse;
			renewCredentialsResponse.Code = context.IntegerValue("RenewCredentials.Code");
			renewCredentialsResponse.Message = context.StringValue("RenewCredentials.Message");
			renewCredentialsResponse.RequestId = context.StringValue("RenewCredentials.RequestId");

			RenewCredentialsResponse.RenewCredentials_Data data = new RenewCredentialsResponse.RenewCredentials_Data();

			RenewCredentialsResponse.RenewCredentials_Data.RenewCredentials_Credentials credentials = new RenewCredentialsResponse.RenewCredentials_Data.RenewCredentials_Credentials();
			credentials.GmtCreate = context.LongValue("RenewCredentials.Data.Credentials.GmtCreate");
			credentials.Id = context.LongValue("RenewCredentials.Data.Credentials.Id");
			credentials.Name = context.StringValue("RenewCredentials.Data.Credentials.Name");
			credentials.UserId = context.StringValue("RenewCredentials.Data.Credentials.UserId");

			RenewCredentialsResponse.RenewCredentials_Data.RenewCredentials_Credentials.RenewCredentials_CurrentCredential currentCredential = new RenewCredentialsResponse.RenewCredentials_Data.RenewCredentials_Credentials.RenewCredentials_CurrentCredential();
			currentCredential.AccessKey = context.StringValue("RenewCredentials.Data.Credentials.CurrentCredential.AccessKey");
			currentCredential.SecretKey = context.StringValue("RenewCredentials.Data.Credentials.CurrentCredential.SecretKey");
			credentials.CurrentCredential = currentCredential;

			RenewCredentialsResponse.RenewCredentials_Data.RenewCredentials_Credentials.RenewCredentials_NewCredential newCredential = new RenewCredentialsResponse.RenewCredentials_Data.RenewCredentials_Credentials.RenewCredentials_NewCredential();
			newCredential.AccessKey = context.StringValue("RenewCredentials.Data.Credentials.NewCredential.AccessKey");
			newCredential.SecretKey = context.StringValue("RenewCredentials.Data.Credentials.NewCredential.SecretKey");
			credentials.NewCredential = newCredential;
			data.Credentials = credentials;
			renewCredentialsResponse.Data = data;
        
			return renewCredentialsResponse;
        }
    }
}