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
using Aliyun.Acs.CSB.Model.V20171118;

namespace Aliyun.Acs.CSB.Transform.V20171118
{
    public class ImportCredentialsResponseUnmarshaller
    {
        public static ImportCredentialsResponse Unmarshall(UnmarshallerContext context)
        {
			ImportCredentialsResponse importCredentialsResponse = new ImportCredentialsResponse();

			importCredentialsResponse.HttpResponse = context.HttpResponse;
			importCredentialsResponse.Code = context.IntegerValue("ImportCredentials.Code");
			importCredentialsResponse.Message = context.StringValue("ImportCredentials.Message");
			importCredentialsResponse.RequestId = context.StringValue("ImportCredentials.RequestId");

			ImportCredentialsResponse.ImportCredentials_Data data = new ImportCredentialsResponse.ImportCredentials_Data();

			ImportCredentialsResponse.ImportCredentials_Data.ImportCredentials_Credentials credentials = new ImportCredentialsResponse.ImportCredentials_Data.ImportCredentials_Credentials();
			credentials.Id = context.LongValue("ImportCredentials.Data.Credentials.Id");

			ImportCredentialsResponse.ImportCredentials_Data.ImportCredentials_Credentials.ImportCredentials_CurrentCredential currentCredential = new ImportCredentialsResponse.ImportCredentials_Data.ImportCredentials_Credentials.ImportCredentials_CurrentCredential();
			currentCredential.SecretKey = context.StringValue("ImportCredentials.Data.Credentials.CurrentCredential.SecretKey");
			currentCredential.AccessKey = context.StringValue("ImportCredentials.Data.Credentials.CurrentCredential.AccessKey");
			credentials.CurrentCredential = currentCredential;
			data.Credentials = credentials;
			importCredentialsResponse.Data = data;
        
			return importCredentialsResponse;
        }
    }
}
