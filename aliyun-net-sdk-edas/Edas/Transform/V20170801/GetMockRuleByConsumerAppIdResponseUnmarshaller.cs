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
using Aliyun.Acs.Edas.Model.V20170801;

namespace Aliyun.Acs.Edas.Transform.V20170801
{
    public class GetMockRuleByConsumerAppIdResponseUnmarshaller
    {
        public static GetMockRuleByConsumerAppIdResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetMockRuleByConsumerAppIdResponse getMockRuleByConsumerAppIdResponse = new GetMockRuleByConsumerAppIdResponse();

			getMockRuleByConsumerAppIdResponse.HttpResponse = _ctx.HttpResponse;
			getMockRuleByConsumerAppIdResponse.Code = _ctx.StringValue("GetMockRuleByConsumerAppId.Code");
			getMockRuleByConsumerAppIdResponse.HttpCode = _ctx.StringValue("GetMockRuleByConsumerAppId.HttpCode");
			getMockRuleByConsumerAppIdResponse.Message = _ctx.StringValue("GetMockRuleByConsumerAppId.Message");
			getMockRuleByConsumerAppIdResponse.RequestId = _ctx.StringValue("GetMockRuleByConsumerAppId.RequestId");
			getMockRuleByConsumerAppIdResponse.Success = _ctx.BooleanValue("GetMockRuleByConsumerAppId.Success");

			List<GetMockRuleByConsumerAppIdResponse.GetMockRuleByConsumerAppId_RuleItemList> getMockRuleByConsumerAppIdResponse_data = new List<GetMockRuleByConsumerAppIdResponse.GetMockRuleByConsumerAppId_RuleItemList>();
			for (int i = 0; i < _ctx.Length("GetMockRuleByConsumerAppId.Data.Length"); i++) {
				GetMockRuleByConsumerAppIdResponse.GetMockRuleByConsumerAppId_RuleItemList ruleItemList = new GetMockRuleByConsumerAppIdResponse.GetMockRuleByConsumerAppId_RuleItemList();
				ruleItemList.AccountId = _ctx.StringValue("GetMockRuleByConsumerAppId.Data["+ i +"].AccountId");
				ruleItemList.Name = _ctx.StringValue("GetMockRuleByConsumerAppId.Data["+ i +"].Name");
				ruleItemList.ConsumerAppId = _ctx.StringValue("GetMockRuleByConsumerAppId.Data["+ i +"].ConsumerAppId");
				ruleItemList.ConsumerAppName = _ctx.StringValue("GetMockRuleByConsumerAppId.Data["+ i +"].ConsumerAppName");
				ruleItemList.Enable = _ctx.BooleanValue("GetMockRuleByConsumerAppId.Data["+ i +"].Enable");
				ruleItemList.ExtraJson = _ctx.StringValue("GetMockRuleByConsumerAppId.Data["+ i +"].ExtraJson");
				ruleItemList.Id = _ctx.LongValue("GetMockRuleByConsumerAppId.Data["+ i +"].Id");
				ruleItemList.NamespaceId = _ctx.StringValue("GetMockRuleByConsumerAppId.Data["+ i +"].NamespaceId");
				ruleItemList.ProviderAppId = _ctx.StringValue("GetMockRuleByConsumerAppId.Data["+ i +"].ProviderAppId");
				ruleItemList.ProviderAppName = _ctx.StringValue("GetMockRuleByConsumerAppId.Data["+ i +"].ProviderAppName");
				ruleItemList.Region = _ctx.StringValue("GetMockRuleByConsumerAppId.Data["+ i +"].Region");
				ruleItemList.ScMockItemJson = _ctx.StringValue("GetMockRuleByConsumerAppId.Data["+ i +"].ScMockItemJson");
				ruleItemList.Source = _ctx.StringValue("GetMockRuleByConsumerAppId.Data["+ i +"].Source");

				getMockRuleByConsumerAppIdResponse_data.Add(ruleItemList);
			}
			getMockRuleByConsumerAppIdResponse.Data = getMockRuleByConsumerAppIdResponse_data;
        
			return getMockRuleByConsumerAppIdResponse;
        }
    }
}
