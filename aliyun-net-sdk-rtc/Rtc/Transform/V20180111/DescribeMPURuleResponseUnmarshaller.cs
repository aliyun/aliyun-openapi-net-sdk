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
using Aliyun.Acs.rtc.Model.V20180111;

namespace Aliyun.Acs.rtc.Transform.V20180111
{
    public class DescribeMPURuleResponseUnmarshaller
    {
        public static DescribeMPURuleResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeMPURuleResponse describeMPURuleResponse = new DescribeMPURuleResponse();

			describeMPURuleResponse.HttpResponse = context.HttpResponse;
			describeMPURuleResponse.RequestId = context.StringValue("DescribeMPURule.RequestId");

			List<DescribeMPURuleResponse.DescribeMPURule_Rule> describeMPURuleResponse_rules = new List<DescribeMPURuleResponse.DescribeMPURule_Rule>();
			for (int i = 0; i < context.Length("DescribeMPURule.Rules.Length"); i++) {
				DescribeMPURuleResponse.DescribeMPURule_Rule rule = new DescribeMPURuleResponse.DescribeMPURule_Rule();
				rule.RuleId = context.LongValue("DescribeMPURule.Rules["+ i +"].RuleId");
				rule.ChannelPrefix = context.StringValue("DescribeMPURule.Rules["+ i +"].ChannelPrefix");
				rule.MediaEncode = context.IntegerValue("DescribeMPURule.Rules["+ i +"].MediaEncode");
				rule.BackgroudColor = context.IntegerValue("DescribeMPURule.Rules["+ i +"].BackgroudColor");
				rule.CropMode = context.IntegerValue("DescribeMPURule.Rules["+ i +"].CropMode");
				rule.TaskProfile = context.StringValue("DescribeMPURule.Rules["+ i +"].TaskProfile");
				rule.PlayDomain = context.StringValue("DescribeMPURule.Rules["+ i +"].PlayDomain");
				rule.CallBack = context.StringValue("DescribeMPURule.Rules["+ i +"].CallBack");
				rule.IsEnable = context.IntegerValue("DescribeMPURule.Rules["+ i +"].IsEnable");

				List<string> rule_layoutIds = new List<string>();
				for (int j = 0; j < context.Length("DescribeMPURule.Rules["+ i +"].LayoutIds.Length"); j++) {
					rule_layoutIds.Add(context.StringValue("DescribeMPURule.Rules["+ i +"].LayoutIds["+ j +"]"));
				}
				rule.LayoutIds = rule_layoutIds;

				describeMPURuleResponse_rules.Add(rule);
			}
			describeMPURuleResponse.Rules = describeMPURuleResponse_rules;
        
			return describeMPURuleResponse;
        }
    }
}
