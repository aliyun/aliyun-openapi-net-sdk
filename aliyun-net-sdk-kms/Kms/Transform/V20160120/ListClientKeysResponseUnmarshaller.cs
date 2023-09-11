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
    public class ListClientKeysResponseUnmarshaller
    {
        public static ListClientKeysResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListClientKeysResponse listClientKeysResponse = new ListClientKeysResponse();

			listClientKeysResponse.HttpResponse = _ctx.HttpResponse;
			listClientKeysResponse.RequestId = _ctx.StringValue("ListClientKeys.RequestId");

			List<ListClientKeysResponse.ListClientKeys_ClientKey> listClientKeysResponse_clientKeys = new List<ListClientKeysResponse.ListClientKeys_ClientKey>();
			for (int i = 0; i < _ctx.Length("ListClientKeys.ClientKeys.Length"); i++) {
				ListClientKeysResponse.ListClientKeys_ClientKey clientKey = new ListClientKeysResponse.ListClientKeys_ClientKey();
				clientKey.ClientKeyId = _ctx.StringValue("ListClientKeys.ClientKeys["+ i +"].ClientKeyId");
				clientKey.CreateTime = _ctx.StringValue("ListClientKeys.ClientKeys["+ i +"].CreateTime");
				clientKey.PublicKeyData = _ctx.StringValue("ListClientKeys.ClientKeys["+ i +"].PublicKeyData");
				clientKey.KeyAlgorithm = _ctx.StringValue("ListClientKeys.ClientKeys["+ i +"].KeyAlgorithm");
				clientKey.NotBefore = _ctx.StringValue("ListClientKeys.ClientKeys["+ i +"].NotBefore");
				clientKey.NotAfter = _ctx.StringValue("ListClientKeys.ClientKeys["+ i +"].NotAfter");
				clientKey.KeyOrigin = _ctx.StringValue("ListClientKeys.ClientKeys["+ i +"].KeyOrigin");
				clientKey.AapName = _ctx.StringValue("ListClientKeys.ClientKeys["+ i +"].AapName");

				listClientKeysResponse_clientKeys.Add(clientKey);
			}
			listClientKeysResponse.ClientKeys = listClientKeysResponse_clientKeys;
        
			return listClientKeysResponse;
        }
    }
}
