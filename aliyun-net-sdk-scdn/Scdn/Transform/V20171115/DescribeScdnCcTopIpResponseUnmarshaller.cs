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
using Aliyun.Acs.scdn.Model.V20171115;

namespace Aliyun.Acs.scdn.Transform.V20171115
{
    public class DescribeScdnCcTopIpResponseUnmarshaller
    {
        public static DescribeScdnCcTopIpResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeScdnCcTopIpResponse describeScdnCcTopIpResponse = new DescribeScdnCcTopIpResponse();

			describeScdnCcTopIpResponse.HttpResponse = _ctx.HttpResponse;
			describeScdnCcTopIpResponse.RequestId = _ctx.StringValue("DescribeScdnCcTopIp.RequestId");
			describeScdnCcTopIpResponse.Total = _ctx.StringValue("DescribeScdnCcTopIp.Total");
			describeScdnCcTopIpResponse.DomainName = _ctx.StringValue("DescribeScdnCcTopIp.DomainName");

			List<DescribeScdnCcTopIpResponse.DescribeScdnCcTopIp_AttackIpDatas> describeScdnCcTopIpResponse_attackIpDataList = new List<DescribeScdnCcTopIpResponse.DescribeScdnCcTopIp_AttackIpDatas>();
			for (int i = 0; i < _ctx.Length("DescribeScdnCcTopIp.AttackIpDataList.Length"); i++) {
				DescribeScdnCcTopIpResponse.DescribeScdnCcTopIp_AttackIpDatas attackIpDatas = new DescribeScdnCcTopIpResponse.DescribeScdnCcTopIp_AttackIpDatas();
				attackIpDatas.Ip = _ctx.StringValue("DescribeScdnCcTopIp.AttackIpDataList["+ i +"].Ip");
				attackIpDatas.AttackCount = _ctx.StringValue("DescribeScdnCcTopIp.AttackIpDataList["+ i +"].AttackCount");

				describeScdnCcTopIpResponse_attackIpDataList.Add(attackIpDatas);
			}
			describeScdnCcTopIpResponse.AttackIpDataList = describeScdnCcTopIpResponse_attackIpDataList;
        
			return describeScdnCcTopIpResponse;
        }
    }
}
