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
using Aliyun.Acs.Ram.Model.V20150501;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Ram.Transform.V20150501
{
    public class ListPublicKeysResponseUnmarshaller
    {
        public static ListPublicKeysResponse Unmarshall(UnmarshallerContext context)
        {
			ListPublicKeysResponse listPublicKeysResponse = new ListPublicKeysResponse();

			listPublicKeysResponse.HttpResponse = context.HttpResponse;
			listPublicKeysResponse.RequestId = context.StringValue("ListPublicKeys.RequestId");

			List<ListPublicKeysResponse.ListPublicKeys_PublicKey> listPublicKeysResponse_publicKeys = new List<ListPublicKeysResponse.ListPublicKeys_PublicKey>();
			for (int i = 0; i < context.Length("ListPublicKeys.PublicKeys.Length"); i++) {
				ListPublicKeysResponse.ListPublicKeys_PublicKey publicKey = new ListPublicKeysResponse.ListPublicKeys_PublicKey();
				publicKey.PublicKeyId = context.StringValue("ListPublicKeys.PublicKeys["+ i +"].PublicKeyId");
				publicKey.Status = context.StringValue("ListPublicKeys.PublicKeys["+ i +"].Status");
				publicKey.CreateDate = context.StringValue("ListPublicKeys.PublicKeys["+ i +"].CreateDate");

				listPublicKeysResponse_publicKeys.Add(publicKey);
			}
			listPublicKeysResponse.PublicKeys = listPublicKeysResponse_publicKeys;
        
			return listPublicKeysResponse;
        }
    }
}