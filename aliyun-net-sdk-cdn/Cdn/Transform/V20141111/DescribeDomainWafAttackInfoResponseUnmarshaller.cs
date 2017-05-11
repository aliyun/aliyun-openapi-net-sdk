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
using Aliyun.Acs.Cdn.Model.V20141111;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Cdn.Transform.V20141111
{
    public class DescribeDomainWafAttackInfoResponseUnmarshaller
    {
        public static DescribeDomainWafAttackInfoResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDomainWafAttackInfoResponse describeDomainWafAttackInfoResponse = new DescribeDomainWafAttackInfoResponse();

			describeDomainWafAttackInfoResponse.HttpResponse = context.HttpResponse;
			describeDomainWafAttackInfoResponse.RequestId = context.StringValue("DescribeDomainWafAttackInfo.RequestId");
			describeDomainWafAttackInfoResponse.DomainName = context.StringValue("DescribeDomainWafAttackInfo.DomainName");
			describeDomainWafAttackInfoResponse.StartTime = context.StringValue("DescribeDomainWafAttackInfo.StartTime");
			describeDomainWafAttackInfoResponse.EndTime = context.StringValue("DescribeDomainWafAttackInfo.EndTime");
			describeDomainWafAttackInfoResponse.PageNumber = context.IntegerValue("DescribeDomainWafAttackInfo.PageNumber");
			describeDomainWafAttackInfoResponse.PageSize = context.IntegerValue("DescribeDomainWafAttackInfo.PageSize");

			List<DescribeDomainWafAttackInfoResponse.AttackDatas> attackDataList = new List<DescribeDomainWafAttackInfoResponse.AttackDatas>();
			for (int i = 0; i < context.Length("DescribeDomainWafAttackInfo.AttackDataList.Length"); i++) {
				DescribeDomainWafAttackInfoResponse.AttackDatas attackDatas = new DescribeDomainWafAttackInfoResponse.AttackDatas();
				attackDatas.Ip = context.StringValue("DescribeDomainWafAttackInfo.AttackDataList["+ i +"].Ip");
				attackDatas.Time = context.StringValue("DescribeDomainWafAttackInfo.AttackDataList["+ i +"].Time");
				attackDatas.Url = context.StringValue("DescribeDomainWafAttackInfo.AttackDataList["+ i +"].Url");
				attackDatas.Type = context.StringValue("DescribeDomainWafAttackInfo.AttackDataList["+ i +"].Type");
				attackDatas.Result = context.StringValue("DescribeDomainWafAttackInfo.AttackDataList["+ i +"].Result");

				attackDataList.Add(attackDatas);
			}
			describeDomainWafAttackInfoResponse.AttackDataList = attackDataList;
        
			return describeDomainWafAttackInfoResponse;
        }
    }
}