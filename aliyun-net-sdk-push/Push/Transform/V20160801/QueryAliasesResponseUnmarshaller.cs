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
using Aliyun.Acs.Push.Model.V20160801;

namespace Aliyun.Acs.Push.Transform.V20160801
{
    public class QueryAliasesResponseUnmarshaller
    {
        public static QueryAliasesResponse Unmarshall(UnmarshallerContext context)
        {
			QueryAliasesResponse queryAliasesResponse = new QueryAliasesResponse();

			queryAliasesResponse.HttpResponse = context.HttpResponse;
			queryAliasesResponse.RequestId = context.StringValue("QueryAliases.RequestId");

			List<QueryAliasesResponse.QueryAliases_AliasInfo> queryAliasesResponse_aliasInfos = new List<QueryAliasesResponse.QueryAliases_AliasInfo>();
			for (int i = 0; i < context.Length("QueryAliases.AliasInfos.Length"); i++) {
				QueryAliasesResponse.QueryAliases_AliasInfo aliasInfo = new QueryAliasesResponse.QueryAliases_AliasInfo();
				aliasInfo.AliasName = context.StringValue("QueryAliases.AliasInfos["+ i +"].AliasName");

				queryAliasesResponse_aliasInfos.Add(aliasInfo);
			}
			queryAliasesResponse.AliasInfos = queryAliasesResponse_aliasInfos;
        
			return queryAliasesResponse;
        }
    }
}
