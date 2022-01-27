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
    public class RemoveMockRuleResponseUnmarshaller
    {
        public static RemoveMockRuleResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RemoveMockRuleResponse removeMockRuleResponse = new RemoveMockRuleResponse();

			removeMockRuleResponse.HttpResponse = _ctx.HttpResponse;
			removeMockRuleResponse.Code = _ctx.StringValue("RemoveMockRule.Code");
			removeMockRuleResponse.HttpCode = _ctx.StringValue("RemoveMockRule.HttpCode");
			removeMockRuleResponse.Message = _ctx.StringValue("RemoveMockRule.Message");
			removeMockRuleResponse.RequestId = _ctx.StringValue("RemoveMockRule.RequestId");
			removeMockRuleResponse.Success = _ctx.BooleanValue("RemoveMockRule.Success");

			RemoveMockRuleResponse.RemoveMockRule_Data data = new RemoveMockRuleResponse.RemoveMockRule_Data();
			data.AccountId = _ctx.StringValue("RemoveMockRule.Data.AccountId");
			data.Name = _ctx.StringValue("RemoveMockRule.Data.Name");
			data.ConsumerAppId = _ctx.StringValue("RemoveMockRule.Data.ConsumerAppId");
			data.ConsumerAppName = _ctx.StringValue("RemoveMockRule.Data.ConsumerAppName");
			data.Enable = _ctx.BooleanValue("RemoveMockRule.Data.Enable");
			data.ExtraJson = _ctx.StringValue("RemoveMockRule.Data.ExtraJson");
			data.Id = _ctx.LongValue("RemoveMockRule.Data.Id");
			data.NamespaceId = _ctx.StringValue("RemoveMockRule.Data.NamespaceId");
			data.ProviderAppId = _ctx.StringValue("RemoveMockRule.Data.ProviderAppId");
			data.ProviderAppName = _ctx.StringValue("RemoveMockRule.Data.ProviderAppName");
			data.Region = _ctx.StringValue("RemoveMockRule.Data.Region");
			data.ScMockItemJson = _ctx.StringValue("RemoveMockRule.Data.ScMockItemJson");
			data.Source = _ctx.StringValue("RemoveMockRule.Data.Source");
			removeMockRuleResponse.Data = data;
        
			return removeMockRuleResponse;
        }
    }
}
