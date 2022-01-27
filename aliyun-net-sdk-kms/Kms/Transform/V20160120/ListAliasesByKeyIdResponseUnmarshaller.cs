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
    public class ListAliasesByKeyIdResponseUnmarshaller
    {
        public static ListAliasesByKeyIdResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListAliasesByKeyIdResponse listAliasesByKeyIdResponse = new ListAliasesByKeyIdResponse();

			listAliasesByKeyIdResponse.HttpResponse = _ctx.HttpResponse;
			listAliasesByKeyIdResponse.TotalCount = _ctx.IntegerValue("ListAliasesByKeyId.TotalCount");
			listAliasesByKeyIdResponse.PageNumber = _ctx.IntegerValue("ListAliasesByKeyId.PageNumber");
			listAliasesByKeyIdResponse.PageSize = _ctx.IntegerValue("ListAliasesByKeyId.PageSize");
			listAliasesByKeyIdResponse.RequestId = _ctx.StringValue("ListAliasesByKeyId.RequestId");

			List<ListAliasesByKeyIdResponse.ListAliasesByKeyId_Alias> listAliasesByKeyIdResponse_aliases = new List<ListAliasesByKeyIdResponse.ListAliasesByKeyId_Alias>();
			for (int i = 0; i < _ctx.Length("ListAliasesByKeyId.Aliases.Length"); i++) {
				ListAliasesByKeyIdResponse.ListAliasesByKeyId_Alias alias = new ListAliasesByKeyIdResponse.ListAliasesByKeyId_Alias();
				alias.KeyId = _ctx.StringValue("ListAliasesByKeyId.Aliases["+ i +"].KeyId");
				alias.AliasName = _ctx.StringValue("ListAliasesByKeyId.Aliases["+ i +"].AliasName");
				alias.AliasArn = _ctx.StringValue("ListAliasesByKeyId.Aliases["+ i +"].AliasArn");

				listAliasesByKeyIdResponse_aliases.Add(alias);
			}
			listAliasesByKeyIdResponse.Aliases = listAliasesByKeyIdResponse_aliases;
        
			return listAliasesByKeyIdResponse;
        }
    }
}
