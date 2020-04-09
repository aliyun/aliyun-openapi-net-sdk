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
using Aliyun.Acs.waf_openapi.Model.V20190910;

namespace Aliyun.Acs.waf_openapi.Transform.V20190910
{
    public class DescribeRealProtectSummaryResponseUnmarshaller
    {
        public static DescribeRealProtectSummaryResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeRealProtectSummaryResponse describeRealProtectSummaryResponse = new DescribeRealProtectSummaryResponse();

			describeRealProtectSummaryResponse.HttpResponse = context.HttpResponse;
			describeRealProtectSummaryResponse.RequestId = context.StringValue("DescribeRealProtectSummary.RequestId");

			List<DescribeRealProtectSummaryResponse.DescribeRealProtectSummary_Item> describeRealProtectSummaryResponse_realProtectSummarys = new List<DescribeRealProtectSummaryResponse.DescribeRealProtectSummary_Item>();
			for (int i = 0; i < context.Length("DescribeRealProtectSummary.RealProtectSummarys.Length"); i++) {
				DescribeRealProtectSummaryResponse.DescribeRealProtectSummary_Item item = new DescribeRealProtectSummaryResponse.DescribeRealProtectSummary_Item();
				item.AlgorithmPv = context.LongValue("DescribeRealProtectSummary.RealProtectSummarys["+ i +"].AlgorithmPv");
				item.JsinjectPv = context.LongValue("DescribeRealProtectSummary.RealProtectSummarys["+ i +"].JsinjectPv");
				item.IntelligencePv = context.LongValue("DescribeRealProtectSummary.RealProtectSummarys["+ i +"].IntelligencePv");
				item.SdkPv = context.LongValue("DescribeRealProtectSummary.RealProtectSummarys["+ i +"].SdkPv");
				item.Index = context.LongValue("DescribeRealProtectSummary.RealProtectSummarys["+ i +"].Index");
				item.Qps = context.LongValue("DescribeRealProtectSummary.RealProtectSummarys["+ i +"].Qps");

				describeRealProtectSummaryResponse_realProtectSummarys.Add(item);
			}
			describeRealProtectSummaryResponse.RealProtectSummarys = describeRealProtectSummaryResponse_realProtectSummarys;
        
			return describeRealProtectSummaryResponse;
        }
    }
}
