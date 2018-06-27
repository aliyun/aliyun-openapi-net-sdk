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
using Aliyun.Acs.CCC.Model.V20170705;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.CCC.Transform.V20170705
{
    public class EncryptResponseUnmarshaller
    {
        public static EncryptResponse Unmarshall(UnmarshallerContext context)
        {
			EncryptResponse encryptResponse = new EncryptResponse();

			encryptResponse.HttpResponse = context.HttpResponse;
			encryptResponse.RequestId = context.StringValue("Encrypt.RequestId");
			encryptResponse.Success = context.BooleanValue("Encrypt.Success");
			encryptResponse.Code = context.StringValue("Encrypt.Code");
			encryptResponse.Message = context.StringValue("Encrypt.Message");
			encryptResponse.HttpStatusCode = context.IntegerValue("Encrypt.HttpStatusCode");
			encryptResponse.PublicKey = context.StringValue("Encrypt.PublicKey");

			List<EncryptResponse.Encrypt_CypherContent> encryptResponse_cypherContents = new List<EncryptResponse.Encrypt_CypherContent>();
			for (int i = 0; i < context.Length("Encrypt.CypherContents.Length"); i++) {
				EncryptResponse.Encrypt_CypherContent cypherContent = new EncryptResponse.Encrypt_CypherContent();
				cypherContent.PlainText = context.StringValue("Encrypt.CypherContents["+ i +"].PlainText");
				cypherContent.CypherText = context.StringValue("Encrypt.CypherContents["+ i +"].CypherText");

				encryptResponse_cypherContents.Add(cypherContent);
			}
			encryptResponse.CypherContents = encryptResponse_cypherContents;
        
			return encryptResponse;
        }
    }
}