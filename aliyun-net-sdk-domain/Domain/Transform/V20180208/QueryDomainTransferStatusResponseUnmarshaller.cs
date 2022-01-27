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
using Aliyun.Acs.Domain.Model.V20180208;

namespace Aliyun.Acs.Domain.Transform.V20180208
{
    public class QueryDomainTransferStatusResponseUnmarshaller
    {
        public static QueryDomainTransferStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryDomainTransferStatusResponse queryDomainTransferStatusResponse = new QueryDomainTransferStatusResponse();

			queryDomainTransferStatusResponse.HttpResponse = _ctx.HttpResponse;
			queryDomainTransferStatusResponse.RequestId = _ctx.StringValue("QueryDomainTransferStatus.RequestId");

			List<QueryDomainTransferStatusResponse.QueryDomainTransferStatus_DomainTransferStatusItem> queryDomainTransferStatusResponse_domainTransferStatus = new List<QueryDomainTransferStatusResponse.QueryDomainTransferStatus_DomainTransferStatusItem>();
			for (int i = 0; i < _ctx.Length("QueryDomainTransferStatus.DomainTransferStatus.Length"); i++) {
				QueryDomainTransferStatusResponse.QueryDomainTransferStatus_DomainTransferStatusItem domainTransferStatusItem = new QueryDomainTransferStatusResponse.QueryDomainTransferStatus_DomainTransferStatusItem();
				domainTransferStatusItem.DomainStatusDescription = _ctx.StringValue("QueryDomainTransferStatus.DomainTransferStatus["+ i +"].DomainStatusDescription");
				domainTransferStatusItem.DomainName = _ctx.StringValue("QueryDomainTransferStatus.DomainTransferStatus["+ i +"].DomainName");

				queryDomainTransferStatusResponse_domainTransferStatus.Add(domainTransferStatusItem);
			}
			queryDomainTransferStatusResponse.DomainTransferStatus = queryDomainTransferStatusResponse_domainTransferStatus;
        
			return queryDomainTransferStatusResponse;
        }
    }
}
