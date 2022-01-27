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
    public class GetMockRuleByProviderAppIdResponseUnmarshaller
    {
        public static GetMockRuleByProviderAppIdResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetMockRuleByProviderAppIdResponse getMockRuleByProviderAppIdResponse = new GetMockRuleByProviderAppIdResponse();

			getMockRuleByProviderAppIdResponse.HttpResponse = _ctx.HttpResponse;
			getMockRuleByProviderAppIdResponse.Code = _ctx.StringValue("GetMockRuleByProviderAppId.Code");
			getMockRuleByProviderAppIdResponse.HttpCode = _ctx.StringValue("GetMockRuleByProviderAppId.HttpCode");
			getMockRuleByProviderAppIdResponse.Message = _ctx.StringValue("GetMockRuleByProviderAppId.Message");
			getMockRuleByProviderAppIdResponse.RequestId = _ctx.StringValue("GetMockRuleByProviderAppId.RequestId");
			getMockRuleByProviderAppIdResponse.Success = _ctx.BooleanValue("GetMockRuleByProviderAppId.Success");

			List<GetMockRuleByProviderAppIdResponse.GetMockRuleByProviderAppId_RuleItemList> getMockRuleByProviderAppIdResponse_data = new List<GetMockRuleByProviderAppIdResponse.GetMockRuleByProviderAppId_RuleItemList>();
			for (int i = 0; i < _ctx.Length("GetMockRuleByProviderAppId.Data.Length"); i++) {
				GetMockRuleByProviderAppIdResponse.GetMockRuleByProviderAppId_RuleItemList ruleItemList = new GetMockRuleByProviderAppIdResponse.GetMockRuleByProviderAppId_RuleItemList();
				ruleItemList.AccountId = _ctx.StringValue("GetMockRuleByProviderAppId.Data["+ i +"].AccountId");
				ruleItemList.Name = _ctx.StringValue("GetMockRuleByProviderAppId.Data["+ i +"].Name");
				ruleItemList.ConsumerAppId = _ctx.StringValue("GetMockRuleByProviderAppId.Data["+ i +"].ConsumerAppId");
				ruleItemList.ConsumerAppName = _ctx.StringValue("GetMockRuleByProviderAppId.Data["+ i +"].ConsumerAppName");
				ruleItemList.Enable = _ctx.BooleanValue("GetMockRuleByProviderAppId.Data["+ i +"].Enable");
				ruleItemList.ExtraJson = _ctx.StringValue("GetMockRuleByProviderAppId.Data["+ i +"].ExtraJson");
				ruleItemList.Id = _ctx.LongValue("GetMockRuleByProviderAppId.Data["+ i +"].Id");
				ruleItemList.NamespaceId = _ctx.StringValue("GetMockRuleByProviderAppId.Data["+ i +"].NamespaceId");
				ruleItemList.ProviderAppId = _ctx.StringValue("GetMockRuleByProviderAppId.Data["+ i +"].ProviderAppId");
				ruleItemList.ProviderAppName = _ctx.StringValue("GetMockRuleByProviderAppId.Data["+ i +"].ProviderAppName");
				ruleItemList.Region = _ctx.StringValue("GetMockRuleByProviderAppId.Data["+ i +"].Region");
				ruleItemList.ScMockItemJson = _ctx.StringValue("GetMockRuleByProviderAppId.Data["+ i +"].ScMockItemJson");
				ruleItemList.Source = _ctx.StringValue("GetMockRuleByProviderAppId.Data["+ i +"].Source");

				getMockRuleByProviderAppIdResponse_data.Add(ruleItemList);
			}
			getMockRuleByProviderAppIdResponse.Data = getMockRuleByProviderAppIdResponse_data;
        
			return getMockRuleByProviderAppIdResponse;
        }
    }
}
