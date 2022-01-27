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
    public class DescribeDomainTopAttackListResponseUnmarshaller
    {
        public static DescribeDomainTopAttackListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDomainTopAttackListResponse describeDomainTopAttackListResponse = new DescribeDomainTopAttackListResponse();

			describeDomainTopAttackListResponse.HttpResponse = _ctx.HttpResponse;
			describeDomainTopAttackListResponse.RequestId = _ctx.StringValue("DescribeDomainTopAttackList.RequestId");

			List<DescribeDomainTopAttackListResponse.DescribeDomainTopAttackList_Data> describeDomainTopAttackListResponse_attackList = new List<DescribeDomainTopAttackListResponse.DescribeDomainTopAttackList_Data>();
			for (int i = 0; i < _ctx.Length("DescribeDomainTopAttackList.AttackList.Length"); i++) {
				DescribeDomainTopAttackListResponse.DescribeDomainTopAttackList_Data data = new DescribeDomainTopAttackListResponse.DescribeDomainTopAttackList_Data();
				data.Count = _ctx.LongValue("DescribeDomainTopAttackList.AttackList["+ i +"].Count");
				data.Attack = _ctx.LongValue("DescribeDomainTopAttackList.AttackList["+ i +"].Attack");
				data.Domain = _ctx.StringValue("DescribeDomainTopAttackList.AttackList["+ i +"].Domain");

				describeDomainTopAttackListResponse_attackList.Add(data);
			}
			describeDomainTopAttackListResponse.AttackList = describeDomainTopAttackListResponse_attackList;
        
			return describeDomainTopAttackListResponse;
        }
    }
}
