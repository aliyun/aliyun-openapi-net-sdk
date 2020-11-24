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
using Aliyun.Acs.ddoscoo.Model.V20200101;

namespace Aliyun.Acs.ddoscoo.Transform.V20200101
{
    public class DescribeDomainQPSListResponseUnmarshaller
    {
        public static DescribeDomainQPSListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDomainQPSListResponse describeDomainQPSListResponse = new DescribeDomainQPSListResponse();

			describeDomainQPSListResponse.HttpResponse = _ctx.HttpResponse;
			describeDomainQPSListResponse.RequestId = _ctx.StringValue("DescribeDomainQPSList.RequestId");

			List<DescribeDomainQPSListResponse.DescribeDomainQPSList_DomainQPS> describeDomainQPSListResponse_domainQPSList = new List<DescribeDomainQPSListResponse.DescribeDomainQPSList_DomainQPS>();
			for (int i = 0; i < _ctx.Length("DescribeDomainQPSList.DomainQPSList.Length"); i++) {
				DescribeDomainQPSListResponse.DescribeDomainQPSList_DomainQPS domainQPS = new DescribeDomainQPSListResponse.DescribeDomainQPSList_DomainQPS();
				domainQPS.MaxQps = _ctx.LongValue("DescribeDomainQPSList.DomainQPSList["+ i +"].MaxQps");
				domainQPS.MaxAttackQps = _ctx.LongValue("DescribeDomainQPSList.DomainQPSList["+ i +"].MaxAttackQps");
				domainQPS.MaxNormalQps = _ctx.LongValue("DescribeDomainQPSList.DomainQPSList["+ i +"].MaxNormalQps");
				domainQPS.AttackQps = _ctx.LongValue("DescribeDomainQPSList.DomainQPSList["+ i +"].AttackQps");
				domainQPS.TotalQps = _ctx.LongValue("DescribeDomainQPSList.DomainQPSList["+ i +"].TotalQps");
				domainQPS.CacheHits = _ctx.LongValue("DescribeDomainQPSList.DomainQPSList["+ i +"].CacheHits");
				domainQPS.TotalCount = _ctx.LongValue("DescribeDomainQPSList.DomainQPSList["+ i +"].TotalCount");
				domainQPS.Index = _ctx.LongValue("DescribeDomainQPSList.DomainQPSList["+ i +"].Index");
				domainQPS.Time = _ctx.LongValue("DescribeDomainQPSList.DomainQPSList["+ i +"].Time");

				describeDomainQPSListResponse_domainQPSList.Add(domainQPS);
			}
			describeDomainQPSListResponse.DomainQPSList = describeDomainQPSListResponse_domainQPSList;
        
			return describeDomainQPSListResponse;
        }
    }
}
