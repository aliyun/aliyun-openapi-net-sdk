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
    public class DescribeScdnCcTopUrlResponseUnmarshaller
    {
        public static DescribeScdnCcTopUrlResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeScdnCcTopUrlResponse describeScdnCcTopUrlResponse = new DescribeScdnCcTopUrlResponse();

			describeScdnCcTopUrlResponse.HttpResponse = context.HttpResponse;
			describeScdnCcTopUrlResponse.RequestId = context.StringValue("DescribeScdnCcTopUrl.RequestId");
			describeScdnCcTopUrlResponse.Total = context.StringValue("DescribeScdnCcTopUrl.Total");
			describeScdnCcTopUrlResponse.DomainName = context.StringValue("DescribeScdnCcTopUrl.DomainName");

			List<DescribeScdnCcTopUrlResponse.DescribeScdnCcTopUrl_AttackUrlDatas> describeScdnCcTopUrlResponse_attackUrlDataList = new List<DescribeScdnCcTopUrlResponse.DescribeScdnCcTopUrl_AttackUrlDatas>();
			for (int i = 0; i < context.Length("DescribeScdnCcTopUrl.AttackUrlDataList.Length"); i++) {
				DescribeScdnCcTopUrlResponse.DescribeScdnCcTopUrl_AttackUrlDatas attackUrlDatas = new DescribeScdnCcTopUrlResponse.DescribeScdnCcTopUrl_AttackUrlDatas();
				attackUrlDatas.Url = context.StringValue("DescribeScdnCcTopUrl.AttackUrlDataList["+ i +"].Url");
				attackUrlDatas.AttackCount = context.StringValue("DescribeScdnCcTopUrl.AttackUrlDataList["+ i +"].AttackCount");

				describeScdnCcTopUrlResponse_attackUrlDataList.Add(attackUrlDatas);
			}
			describeScdnCcTopUrlResponse.AttackUrlDataList = describeScdnCcTopUrlResponse_attackUrlDataList;
        
			return describeScdnCcTopUrlResponse;
        }
    }
}
