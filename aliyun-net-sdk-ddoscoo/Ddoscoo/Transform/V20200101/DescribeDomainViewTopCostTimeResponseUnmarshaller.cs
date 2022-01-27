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
    public class DescribeDomainViewTopCostTimeResponseUnmarshaller
    {
        public static DescribeDomainViewTopCostTimeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDomainViewTopCostTimeResponse describeDomainViewTopCostTimeResponse = new DescribeDomainViewTopCostTimeResponse();

			describeDomainViewTopCostTimeResponse.HttpResponse = _ctx.HttpResponse;
			describeDomainViewTopCostTimeResponse.RequestId = _ctx.StringValue("DescribeDomainViewTopCostTime.RequestId");

			List<DescribeDomainViewTopCostTimeResponse.DescribeDomainViewTopCostTime_Url> describeDomainViewTopCostTimeResponse_urlList = new List<DescribeDomainViewTopCostTimeResponse.DescribeDomainViewTopCostTime_Url>();
			for (int i = 0; i < _ctx.Length("DescribeDomainViewTopCostTime.UrlList.Length"); i++) {
				DescribeDomainViewTopCostTimeResponse.DescribeDomainViewTopCostTime_Url url = new DescribeDomainViewTopCostTimeResponse.DescribeDomainViewTopCostTime_Url();
				url.CostTime = _ctx.FloatValue("DescribeDomainViewTopCostTime.UrlList["+ i +"].CostTime");
				url.Domain = _ctx.StringValue("DescribeDomainViewTopCostTime.UrlList["+ i +"].Domain");
				url.Url = _ctx.StringValue("DescribeDomainViewTopCostTime.UrlList["+ i +"].Url");

				describeDomainViewTopCostTimeResponse_urlList.Add(url);
			}
			describeDomainViewTopCostTimeResponse.UrlList = describeDomainViewTopCostTimeResponse_urlList;
        
			return describeDomainViewTopCostTimeResponse;
        }
    }
}
