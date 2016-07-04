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
    public class DescribeDomainWafDataResponseUnmarshaller
    {
        public static DescribeDomainWafDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDomainWafDataResponse describeDomainWafDataResponse = new DescribeDomainWafDataResponse();

			describeDomainWafDataResponse.HttpResponse = context.HttpResponse;
			describeDomainWafDataResponse.RequestId = context.StringValue("DescribeDomainWafData.RequestId");
			describeDomainWafDataResponse.DomainName = context.StringValue("DescribeDomainWafData.DomainName");
			describeDomainWafDataResponse.DataInterval = context.StringValue("DescribeDomainWafData.DataInterval");
			describeDomainWafDataResponse.StartTime = context.StringValue("DescribeDomainWafData.StartTime");
			describeDomainWafDataResponse.EndTime = context.StringValue("DescribeDomainWafData.EndTime");

			List<DescribeDomainWafDataResponse.WafDatas> wafDataList = new List<DescribeDomainWafDataResponse.WafDatas>();
			for (int i = 0; i < context.Length("DescribeDomainWafData.WafDataList.Length"); i++) {
				DescribeDomainWafDataResponse.WafDatas wafDatas = new DescribeDomainWafDataResponse.WafDatas();
				wafDatas.TimeStamp = context.StringValue("DescribeDomainWafData.WafDataList["+ i +"].TimeStamp");

				List<string> value = new List<string>();
				for (int j = 0; j < context.Length("DescribeDomainWafData.WafDataList["+ i +"].Value.Length"); j++) {
					value.Add(context.StringValue("DescribeDomainWafData.WafDataList["+ i +"].Value["+ j +"]"));
				}
				wafDatas.Value = value;

				wafDataList.Add(wafDatas);
			}
			describeDomainWafDataResponse.WafDataList = wafDataList;
        
			return describeDomainWafDataResponse;
        }
    }
}