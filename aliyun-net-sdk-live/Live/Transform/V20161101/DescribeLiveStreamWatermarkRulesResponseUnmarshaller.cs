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
using Aliyun.Acs.live.Model.V20161101;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class DescribeLiveStreamWatermarkRulesResponseUnmarshaller
    {
        public static DescribeLiveStreamWatermarkRulesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveStreamWatermarkRulesResponse describeLiveStreamWatermarkRulesResponse = new DescribeLiveStreamWatermarkRulesResponse();

			describeLiveStreamWatermarkRulesResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveStreamWatermarkRulesResponse.RequestId = _ctx.StringValue("DescribeLiveStreamWatermarkRules.RequestId");

			List<DescribeLiveStreamWatermarkRulesResponse.DescribeLiveStreamWatermarkRules_RuleInfo> describeLiveStreamWatermarkRulesResponse_ruleInfoList = new List<DescribeLiveStreamWatermarkRulesResponse.DescribeLiveStreamWatermarkRules_RuleInfo>();
			for (int i = 0; i < _ctx.Length("DescribeLiveStreamWatermarkRules.RuleInfoList.Length"); i++) {
				DescribeLiveStreamWatermarkRulesResponse.DescribeLiveStreamWatermarkRules_RuleInfo ruleInfo = new DescribeLiveStreamWatermarkRulesResponse.DescribeLiveStreamWatermarkRules_RuleInfo();
				ruleInfo.RuleId = _ctx.StringValue("DescribeLiveStreamWatermarkRules.RuleInfoList["+ i +"].RuleId");
				ruleInfo.Name = _ctx.StringValue("DescribeLiveStreamWatermarkRules.RuleInfoList["+ i +"].Name");
				ruleInfo.Domain = _ctx.StringValue("DescribeLiveStreamWatermarkRules.RuleInfoList["+ i +"].Domain");
				ruleInfo.App = _ctx.StringValue("DescribeLiveStreamWatermarkRules.RuleInfoList["+ i +"].App");
				ruleInfo.Stream = _ctx.StringValue("DescribeLiveStreamWatermarkRules.RuleInfoList["+ i +"].Stream");
				ruleInfo.TemplateId = _ctx.StringValue("DescribeLiveStreamWatermarkRules.RuleInfoList["+ i +"].TemplateId");
				ruleInfo.Description = _ctx.StringValue("DescribeLiveStreamWatermarkRules.RuleInfoList["+ i +"].Description");

				describeLiveStreamWatermarkRulesResponse_ruleInfoList.Add(ruleInfo);
			}
			describeLiveStreamWatermarkRulesResponse.RuleInfoList = describeLiveStreamWatermarkRulesResponse_ruleInfoList;
        
			return describeLiveStreamWatermarkRulesResponse;
        }
    }
}
