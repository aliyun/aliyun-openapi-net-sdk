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
    public class DescribeDomainCCAttackInfoResponseUnmarshaller
    {
        public static DescribeDomainCCAttackInfoResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDomainCCAttackInfoResponse describeDomainCCAttackInfoResponse = new DescribeDomainCCAttackInfoResponse();

			describeDomainCCAttackInfoResponse.HttpResponse = context.HttpResponse;
			describeDomainCCAttackInfoResponse.RequestId = context.StringValue("DescribeDomainCCAttackInfo.RequestId");
			describeDomainCCAttackInfoResponse.DomainName = context.StringValue("DescribeDomainCCAttackInfo.DomainName");
			describeDomainCCAttackInfoResponse.StartTime = context.StringValue("DescribeDomainCCAttackInfo.StartTime");
			describeDomainCCAttackInfoResponse.EndTime = context.StringValue("DescribeDomainCCAttackInfo.EndTime");

			List<DescribeDomainCCAttackInfoResponse.DescribeDomainCCAttackInfo_AttackIpDatas> describeDomainCCAttackInfoResponse_attackIpDataList = new List<DescribeDomainCCAttackInfoResponse.DescribeDomainCCAttackInfo_AttackIpDatas>();
			for (int i = 0; i < context.Length("DescribeDomainCCAttackInfo.AttackIpDataList.Length"); i++) {
				DescribeDomainCCAttackInfoResponse.DescribeDomainCCAttackInfo_AttackIpDatas attackIpDatas = new DescribeDomainCCAttackInfoResponse.DescribeDomainCCAttackInfo_AttackIpDatas();
				attackIpDatas.Ip = context.StringValue("DescribeDomainCCAttackInfo.AttackIpDataList["+ i +"].Ip");
				attackIpDatas.AttackCount = context.StringValue("DescribeDomainCCAttackInfo.AttackIpDataList["+ i +"].AttackCount");
				attackIpDatas.Result = context.StringValue("DescribeDomainCCAttackInfo.AttackIpDataList["+ i +"].Result");

				describeDomainCCAttackInfoResponse_attackIpDataList.Add(attackIpDatas);
			}
			describeDomainCCAttackInfoResponse.AttackIpDataList = describeDomainCCAttackInfoResponse_attackIpDataList;

			List<DescribeDomainCCAttackInfoResponse.DescribeDomainCCAttackInfo_AttackedUrlDatas> describeDomainCCAttackInfoResponse_attackedUrlDataList = new List<DescribeDomainCCAttackInfoResponse.DescribeDomainCCAttackInfo_AttackedUrlDatas>();
			for (int i = 0; i < context.Length("DescribeDomainCCAttackInfo.AttackedUrlDataList.Length"); i++) {
				DescribeDomainCCAttackInfoResponse.DescribeDomainCCAttackInfo_AttackedUrlDatas attackedUrlDatas = new DescribeDomainCCAttackInfoResponse.DescribeDomainCCAttackInfo_AttackedUrlDatas();
				attackedUrlDatas.Url = context.StringValue("DescribeDomainCCAttackInfo.AttackedUrlDataList["+ i +"].Url");
				attackedUrlDatas.AttackCount = context.StringValue("DescribeDomainCCAttackInfo.AttackedUrlDataList["+ i +"].AttackCount");
				attackedUrlDatas.Result = context.StringValue("DescribeDomainCCAttackInfo.AttackedUrlDataList["+ i +"].Result");

				describeDomainCCAttackInfoResponse_attackedUrlDataList.Add(attackedUrlDatas);
			}
			describeDomainCCAttackInfoResponse.AttackedUrlDataList = describeDomainCCAttackInfoResponse_attackedUrlDataList;
        
			return describeDomainCCAttackInfoResponse;
        }
    }
}