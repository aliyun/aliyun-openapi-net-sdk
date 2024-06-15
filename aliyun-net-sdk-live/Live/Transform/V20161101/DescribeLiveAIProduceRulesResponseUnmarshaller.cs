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
    public class DescribeLiveAIProduceRulesResponseUnmarshaller
    {
        public static DescribeLiveAIProduceRulesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveAIProduceRulesResponse describeLiveAIProduceRulesResponse = new DescribeLiveAIProduceRulesResponse();

			describeLiveAIProduceRulesResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveAIProduceRulesResponse.RequestId = _ctx.StringValue("DescribeLiveAIProduceRules.RequestId");

			List<DescribeLiveAIProduceRulesResponse.DescribeLiveAIProduceRules_RuleInfo> describeLiveAIProduceRulesResponse_ruleInfoList = new List<DescribeLiveAIProduceRulesResponse.DescribeLiveAIProduceRules_RuleInfo>();
			for (int i = 0; i < _ctx.Length("DescribeLiveAIProduceRules.RuleInfoList.Length"); i++) {
				DescribeLiveAIProduceRulesResponse.DescribeLiveAIProduceRules_RuleInfo ruleInfo = new DescribeLiveAIProduceRulesResponse.DescribeLiveAIProduceRules_RuleInfo();
				ruleInfo.Domain = _ctx.StringValue("DescribeLiveAIProduceRules.RuleInfoList["+ i +"].Domain");
				ruleInfo.App = _ctx.StringValue("DescribeLiveAIProduceRules.RuleInfoList["+ i +"].App");
				ruleInfo.SubtitleName = _ctx.StringValue("DescribeLiveAIProduceRules.RuleInfoList["+ i +"].SubtitleName");
				ruleInfo.IsLazy = _ctx.BooleanValue("DescribeLiveAIProduceRules.RuleInfoList["+ i +"].IsLazy");
				ruleInfo.IsOrigin = _ctx.BooleanValue("DescribeLiveAIProduceRules.RuleInfoList["+ i +"].IsOrigin");
				ruleInfo.RulesId = _ctx.StringValue("DescribeLiveAIProduceRules.RuleInfoList["+ i +"].RulesId");
				ruleInfo.LiveTemplate = _ctx.StringValue("DescribeLiveAIProduceRules.RuleInfoList["+ i +"].LiveTemplate");
				ruleInfo.GmtModifyTime = _ctx.StringValue("DescribeLiveAIProduceRules.RuleInfoList["+ i +"].GmtModifyTime");
				ruleInfo.SuffixName = _ctx.StringValue("DescribeLiveAIProduceRules.RuleInfoList["+ i +"].SuffixName");
				ruleInfo.Description = _ctx.StringValue("DescribeLiveAIProduceRules.RuleInfoList["+ i +"].Description");

				describeLiveAIProduceRulesResponse_ruleInfoList.Add(ruleInfo);
			}
			describeLiveAIProduceRulesResponse.RuleInfoList = describeLiveAIProduceRulesResponse_ruleInfoList;
        
			return describeLiveAIProduceRulesResponse;
        }
    }
}
