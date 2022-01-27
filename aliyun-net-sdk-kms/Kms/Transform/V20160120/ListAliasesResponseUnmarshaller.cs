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
    public class ListAliasesResponseUnmarshaller
    {
        public static ListAliasesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListAliasesResponse listAliasesResponse = new ListAliasesResponse();

			listAliasesResponse.HttpResponse = _ctx.HttpResponse;
			listAliasesResponse.TotalCount = _ctx.IntegerValue("ListAliases.TotalCount");
			listAliasesResponse.PageNumber = _ctx.IntegerValue("ListAliases.PageNumber");
			listAliasesResponse.PageSize = _ctx.IntegerValue("ListAliases.PageSize");
			listAliasesResponse.RequestId = _ctx.StringValue("ListAliases.RequestId");

			List<ListAliasesResponse.ListAliases_Alias> listAliasesResponse_aliases = new List<ListAliasesResponse.ListAliases_Alias>();
			for (int i = 0; i < _ctx.Length("ListAliases.Aliases.Length"); i++) {
				ListAliasesResponse.ListAliases_Alias alias = new ListAliasesResponse.ListAliases_Alias();
				alias.KeyId = _ctx.StringValue("ListAliases.Aliases["+ i +"].KeyId");
				alias.AliasName = _ctx.StringValue("ListAliases.Aliases["+ i +"].AliasName");
				alias.AliasArn = _ctx.StringValue("ListAliases.Aliases["+ i +"].AliasArn");

				listAliasesResponse_aliases.Add(alias);
			}
			listAliasesResponse.Aliases = listAliasesResponse_aliases;
        
			return listAliasesResponse;
        }
    }
}
