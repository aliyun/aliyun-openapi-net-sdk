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
using Aliyun.Acs.Domain.Model.V20180129;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Domain.Transform.V20180129
{
    public class QueryDomainGroupListResponseUnmarshaller
    {
        public static QueryDomainGroupListResponse Unmarshall(UnmarshallerContext context)
        {
			QueryDomainGroupListResponse queryDomainGroupListResponse = new QueryDomainGroupListResponse();

			queryDomainGroupListResponse.HttpResponse = context.HttpResponse;
			queryDomainGroupListResponse.RequestId = context.StringValue("QueryDomainGroupList.RequestId");

			List<QueryDomainGroupListResponse.QueryDomainGroupList_Domain> queryDomainGroupListResponse_data = new List<QueryDomainGroupListResponse.QueryDomainGroupList_Domain>();
			for (int i = 0; i < context.Length("QueryDomainGroupList.Data.Length"); i++) {
				QueryDomainGroupListResponse.QueryDomainGroupList_Domain domain = new QueryDomainGroupListResponse.QueryDomainGroupList_Domain();
				domain.DomainGroupId = context.StringValue("QueryDomainGroupList.Data["+ i +"].DomainGroupId");
				domain.DomainGroupName = context.StringValue("QueryDomainGroupList.Data["+ i +"].DomainGroupName");
				domain.TotalNumber = context.IntegerValue("QueryDomainGroupList.Data["+ i +"].TotalNumber");
				domain.CreationDate = context.StringValue("QueryDomainGroupList.Data["+ i +"].CreationDate");
				domain.ModificationDate = context.StringValue("QueryDomainGroupList.Data["+ i +"].ModificationDate");

				queryDomainGroupListResponse_data.Add(domain);
			}
			queryDomainGroupListResponse.Data = queryDomainGroupListResponse_data;
        
			return queryDomainGroupListResponse;
        }
    }
}