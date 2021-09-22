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
using Aliyun.Acs.Alidns.Model.V20150109;

namespace Aliyun.Acs.Alidns.Transform.V20150109
{
    public class DescribePdnsAccountSummaryResponseUnmarshaller
    {
        public static DescribePdnsAccountSummaryResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePdnsAccountSummaryResponse describePdnsAccountSummaryResponse = new DescribePdnsAccountSummaryResponse();

			describePdnsAccountSummaryResponse.HttpResponse = _ctx.HttpResponse;
			describePdnsAccountSummaryResponse.RequestId = _ctx.StringValue("DescribePdnsAccountSummary.RequestId");

			DescribePdnsAccountSummaryResponse.DescribePdnsAccountSummary_Data data = new DescribePdnsAccountSummaryResponse.DescribePdnsAccountSummary_Data();
			data.TotalCount = _ctx.LongValue("DescribePdnsAccountSummary.Data.TotalCount");
			data.ThreatCount = _ctx.LongValue("DescribePdnsAccountSummary.Data.ThreatCount");
			data.UserId = _ctx.LongValue("DescribePdnsAccountSummary.Data.UserId");
			data.HttpsCount = _ctx.LongValue("DescribePdnsAccountSummary.Data.HttpsCount");
			data.HttpCount = _ctx.LongValue("DescribePdnsAccountSummary.Data.HttpCount");
			data.SubDomainCount = _ctx.LongValue("DescribePdnsAccountSummary.Data.SubDomainCount");
			data.DomainCount = _ctx.LongValue("DescribePdnsAccountSummary.Data.DomainCount");
			describePdnsAccountSummaryResponse.Data = data;
        
			return describePdnsAccountSummaryResponse;
        }
    }
}
