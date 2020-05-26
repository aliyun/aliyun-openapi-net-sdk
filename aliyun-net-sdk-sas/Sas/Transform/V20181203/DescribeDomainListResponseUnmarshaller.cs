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
using Aliyun.Acs.Sas.Model.V20181203;

namespace Aliyun.Acs.Sas.Transform.V20181203
{
    public class DescribeDomainListResponseUnmarshaller
    {
        public static DescribeDomainListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDomainListResponse describeDomainListResponse = new DescribeDomainListResponse();

			describeDomainListResponse.HttpResponse = context.HttpResponse;
			describeDomainListResponse.RequestId = context.StringValue("DescribeDomainList.RequestId");

			DescribeDomainListResponse.DescribeDomainList_PageInfo pageInfo = new DescribeDomainListResponse.DescribeDomainList_PageInfo();
			pageInfo.Count = context.IntegerValue("DescribeDomainList.PageInfo.Count");
			pageInfo.PageSize = context.IntegerValue("DescribeDomainList.PageInfo.PageSize");
			pageInfo.TotalCount = context.IntegerValue("DescribeDomainList.PageInfo.TotalCount");
			pageInfo.CurrentPage = context.IntegerValue("DescribeDomainList.PageInfo.CurrentPage");
			describeDomainListResponse.PageInfo = pageInfo;

			List<DescribeDomainListResponse.DescribeDomainList_DomainResponse> describeDomainListResponse_domainListResponseList = new List<DescribeDomainListResponse.DescribeDomainList_DomainResponse>();
			for (int i = 0; i < context.Length("DescribeDomainList.DomainListResponseList.Length"); i++) {
				DescribeDomainListResponse.DescribeDomainList_DomainResponse domainResponse = new DescribeDomainListResponse.DescribeDomainList_DomainResponse();
				domainResponse.Domain = context.StringValue("DescribeDomainList.DomainListResponseList["+ i +"].Domain");
				domainResponse.IpList = context.StringValue("DescribeDomainList.DomainListResponseList["+ i +"].IpList");

				describeDomainListResponse_domainListResponseList.Add(domainResponse);
			}
			describeDomainListResponse.DomainListResponseList = describeDomainListResponse_domainListResponseList;
        
			return describeDomainListResponse;
        }
    }
}
