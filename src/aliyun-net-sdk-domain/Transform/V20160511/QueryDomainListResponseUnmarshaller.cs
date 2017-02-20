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
using Aliyun.Acs.Domain.Model.V20160511;
using System.Collections.Generic;

namespace Aliyun.Acs.Domain.Transform.V20160511
{
    public class QueryDomainListResponseUnmarshaller
    {
        public static QueryDomainListResponse Unmarshall(UnmarshallerContext context)
        {
            QueryDomainListResponse queryDomainListResponse = new QueryDomainListResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("QueryDomainList.RequestId"),
                TotalItemNum = context.IntegerValue("QueryDomainList.TotalItemNum"),
                CurrentPageNum = context.IntegerValue("QueryDomainList.CurrentPageNum"),
                TotalPageNum = context.IntegerValue("QueryDomainList.TotalPageNum"),
                PageSize = context.IntegerValue("QueryDomainList.PageSize"),
                PrePage = context.BooleanValue("QueryDomainList.PrePage"),
                NextPage = context.BooleanValue("QueryDomainList.NextPage")
            };
            List<QueryDomainListResponse.Domain> data = new List<QueryDomainListResponse.Domain>();
			for (int i = 0; i < context.Length("QueryDomainList.Data.Length"); i++) {
                QueryDomainListResponse.Domain domain = new QueryDomainListResponse.Domain()
                {
                    DomainName = context.StringValue($"QueryDomainList.Data[{i}].DomainName"),
                    SaleId = context.StringValue($"QueryDomainList.Data[{i}].SaleId"),
                    DeadDate = context.StringValue($"QueryDomainList.Data[{i}].DeadDate"),
                    RegDate = context.StringValue($"QueryDomainList.Data[{i}].RegDate"),
                    DomainAuditStatus = context.StringValue($"QueryDomainList.Data[{i}].DomainAuditStatus"),
                    DomainRegType = context.StringValue($"QueryDomainList.Data[{i}].DomainRegType"),
                    GroupId = context.StringValue($"QueryDomainList.Data[{i}].GroupId"),
                    DomainType = context.StringValue($"QueryDomainList.Data[{i}].DomainType")
                };
                data.Add(domain);
			}
			queryDomainListResponse.Data = data;
        
			return queryDomainListResponse;
        }
    }
}