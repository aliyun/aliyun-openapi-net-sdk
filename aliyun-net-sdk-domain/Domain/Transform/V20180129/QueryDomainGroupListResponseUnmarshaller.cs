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
using Aliyun.Acs.Domain.Model.V20180129;

namespace Aliyun.Acs.Domain.Transform.V20180129
{
    public class QueryDomainGroupListResponseUnmarshaller
    {
        public static QueryDomainGroupListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryDomainGroupListResponse queryDomainGroupListResponse = new QueryDomainGroupListResponse();

			queryDomainGroupListResponse.HttpResponse = _ctx.HttpResponse;
			queryDomainGroupListResponse.RequestId = _ctx.StringValue("QueryDomainGroupList.RequestId");

			List<QueryDomainGroupListResponse.QueryDomainGroupList_DomainGroup> queryDomainGroupListResponse_data = new List<QueryDomainGroupListResponse.QueryDomainGroupList_DomainGroup>();
			for (int i = 0; i < _ctx.Length("QueryDomainGroupList.Data.Length"); i++) {
				QueryDomainGroupListResponse.QueryDomainGroupList_DomainGroup domainGroup = new QueryDomainGroupListResponse.QueryDomainGroupList_DomainGroup();
				domainGroup.DomainGroupId = _ctx.StringValue("QueryDomainGroupList.Data["+ i +"].DomainGroupId");
				domainGroup.DomainGroupName = _ctx.StringValue("QueryDomainGroupList.Data["+ i +"].DomainGroupName");
				domainGroup.TotalNumber = _ctx.IntegerValue("QueryDomainGroupList.Data["+ i +"].TotalNumber");
				domainGroup.CreationDate = _ctx.StringValue("QueryDomainGroupList.Data["+ i +"].CreationDate");
				domainGroup.ModificationDate = _ctx.StringValue("QueryDomainGroupList.Data["+ i +"].ModificationDate");
				domainGroup.DomainGroupStatus = _ctx.StringValue("QueryDomainGroupList.Data["+ i +"].DomainGroupStatus");
				domainGroup.BeingDeleted = _ctx.BooleanValue("QueryDomainGroupList.Data["+ i +"].BeingDeleted");

				queryDomainGroupListResponse_data.Add(domainGroup);
			}
			queryDomainGroupListResponse.Data = queryDomainGroupListResponse_data;
        
			return queryDomainGroupListResponse;
        }
    }
}
