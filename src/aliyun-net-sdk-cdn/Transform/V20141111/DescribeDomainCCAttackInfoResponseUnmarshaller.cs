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
using System.Collections.Generic;

namespace Aliyun.Acs.Cdn.Transform.V20141111
{
    public class DescribeDomainCcAttackInfoResponseUnmarshaller
    {
        public static DescribeDomainCcAttackInfoResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeDomainCcAttackInfoResponse describeDomainCcAttackInfoResponse = new DescribeDomainCcAttackInfoResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeDomainCCAttackInfo.RequestId"),
                DomainName = context.StringValue("DescribeDomainCCAttackInfo.DomainName"),
                StartTime = context.StringValue("DescribeDomainCCAttackInfo.StartTime"),
                EndTime = context.StringValue("DescribeDomainCCAttackInfo.EndTime")
            };
            List<DescribeDomainCcAttackInfoResponse.AttackIpDatas> attackIpDataList = new List<DescribeDomainCcAttackInfoResponse.AttackIpDatas>();
			for (int i = 0; i < context.Length("DescribeDomainCCAttackInfo.AttackIpDataList.Length"); i++) {
                DescribeDomainCcAttackInfoResponse.AttackIpDatas attackIpDatas = new DescribeDomainCcAttackInfoResponse.AttackIpDatas()
                {
                    Ip = context.StringValue($"DescribeDomainCCAttackInfo.AttackIpDataList[{i}].Ip"),
                    AttackCount = context.StringValue($"DescribeDomainCCAttackInfo.AttackIpDataList[{i}].AttackCount"),
                    Result = context.StringValue($"DescribeDomainCCAttackInfo.AttackIpDataList[{i}].Result")
                };
                attackIpDataList.Add(attackIpDatas);
			}
			describeDomainCcAttackInfoResponse.AttackIpDataList = attackIpDataList;

			List<DescribeDomainCcAttackInfoResponse.AttackedUrlDatas> attackedUrlDataList = new List<DescribeDomainCcAttackInfoResponse.AttackedUrlDatas>();
			for (int i = 0; i < context.Length("DescribeDomainCCAttackInfo.AttackedUrlDataList.Length"); i++) {
                DescribeDomainCcAttackInfoResponse.AttackedUrlDatas attackedUrlDatas = new DescribeDomainCcAttackInfoResponse.AttackedUrlDatas()
                {
                    Url = context.StringValue($"DescribeDomainCCAttackInfo.AttackedUrlDataList[{i}].Url"),
                    AttackCount = context.StringValue($"DescribeDomainCCAttackInfo.AttackedUrlDataList[{i}].AttackCount"),
                    Result = context.StringValue($"DescribeDomainCCAttackInfo.AttackedUrlDataList[{i}].Result")
                };
                attackedUrlDataList.Add(attackedUrlDatas);
			}
			describeDomainCcAttackInfoResponse.AttackedUrlDataList = attackedUrlDataList;
        
			return describeDomainCcAttackInfoResponse;
        }
    }
}