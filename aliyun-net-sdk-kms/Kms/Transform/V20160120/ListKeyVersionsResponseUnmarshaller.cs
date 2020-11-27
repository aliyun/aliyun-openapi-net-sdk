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
    public class ListKeyVersionsResponseUnmarshaller
    {
        public static ListKeyVersionsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListKeyVersionsResponse listKeyVersionsResponse = new ListKeyVersionsResponse();

			listKeyVersionsResponse.HttpResponse = _ctx.HttpResponse;
			listKeyVersionsResponse.RequestId = _ctx.StringValue("ListKeyVersions.RequestId");
			listKeyVersionsResponse.TotalCount = _ctx.IntegerValue("ListKeyVersions.TotalCount");
			listKeyVersionsResponse.PageNumber = _ctx.IntegerValue("ListKeyVersions.PageNumber");
			listKeyVersionsResponse.PageSize = _ctx.IntegerValue("ListKeyVersions.PageSize");

			List<ListKeyVersionsResponse.ListKeyVersions_KeyVersion> listKeyVersionsResponse_keyVersions = new List<ListKeyVersionsResponse.ListKeyVersions_KeyVersion>();
			for (int i = 0; i < _ctx.Length("ListKeyVersions.KeyVersions.Length"); i++) {
				ListKeyVersionsResponse.ListKeyVersions_KeyVersion keyVersion = new ListKeyVersionsResponse.ListKeyVersions_KeyVersion();
				keyVersion.KeyId = _ctx.StringValue("ListKeyVersions.KeyVersions["+ i +"].KeyId");
				keyVersion.KeyVersionId = _ctx.StringValue("ListKeyVersions.KeyVersions["+ i +"].KeyVersionId");
				keyVersion.CreationDate = _ctx.StringValue("ListKeyVersions.KeyVersions["+ i +"].CreationDate");

				listKeyVersionsResponse_keyVersions.Add(keyVersion);
			}
			listKeyVersionsResponse.KeyVersions = listKeyVersionsResponse_keyVersions;
        
			return listKeyVersionsResponse;
        }
    }
}
