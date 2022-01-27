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
    public class DescribeWebCCRulesResponseUnmarshaller
    {
        public static DescribeWebCCRulesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeWebCCRulesResponse describeWebCCRulesResponse = new DescribeWebCCRulesResponse();

			describeWebCCRulesResponse.HttpResponse = _ctx.HttpResponse;
			describeWebCCRulesResponse.RequestId = _ctx.StringValue("DescribeWebCCRules.RequestId");
			describeWebCCRulesResponse.TotalCount = _ctx.LongValue("DescribeWebCCRules.TotalCount");

			List<DescribeWebCCRulesResponse.DescribeWebCCRules_WebCCRule> describeWebCCRulesResponse_webCCRules = new List<DescribeWebCCRulesResponse.DescribeWebCCRules_WebCCRule>();
			for (int i = 0; i < _ctx.Length("DescribeWebCCRules.WebCCRules.Length"); i++) {
				DescribeWebCCRulesResponse.DescribeWebCCRules_WebCCRule webCCRule = new DescribeWebCCRulesResponse.DescribeWebCCRules_WebCCRule();
				webCCRule.Name = _ctx.StringValue("DescribeWebCCRules.WebCCRules["+ i +"].Name");
				webCCRule.Act = _ctx.StringValue("DescribeWebCCRules.WebCCRules["+ i +"].Act");
				webCCRule.Count = _ctx.IntegerValue("DescribeWebCCRules.WebCCRules["+ i +"].Count");
				webCCRule.Interval = _ctx.IntegerValue("DescribeWebCCRules.WebCCRules["+ i +"].Interval");
				webCCRule.Mode = _ctx.StringValue("DescribeWebCCRules.WebCCRules["+ i +"].Mode");
				webCCRule.Ttl = _ctx.IntegerValue("DescribeWebCCRules.WebCCRules["+ i +"].Ttl");
				webCCRule.Uri = _ctx.StringValue("DescribeWebCCRules.WebCCRules["+ i +"].Uri");

				describeWebCCRulesResponse_webCCRules.Add(webCCRule);
			}
			describeWebCCRulesResponse.WebCCRules = describeWebCCRulesResponse_webCCRules;
        
			return describeWebCCRulesResponse;
        }
    }
}
