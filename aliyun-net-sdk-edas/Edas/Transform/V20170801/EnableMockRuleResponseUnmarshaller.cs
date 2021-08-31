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
    public class EnableMockRuleResponseUnmarshaller
    {
        public static EnableMockRuleResponse Unmarshall(UnmarshallerContext _ctx)
        {
			EnableMockRuleResponse enableMockRuleResponse = new EnableMockRuleResponse();

			enableMockRuleResponse.HttpResponse = _ctx.HttpResponse;
			enableMockRuleResponse.Code = _ctx.IntegerValue("EnableMockRule.Code");
			enableMockRuleResponse.Message = _ctx.StringValue("EnableMockRule.Message");
			enableMockRuleResponse.RequestId = _ctx.StringValue("EnableMockRule.RequestId");
			enableMockRuleResponse.Success = _ctx.BooleanValue("EnableMockRule.Success");

			EnableMockRuleResponse.EnableMockRule_Data data = new EnableMockRuleResponse.EnableMockRule_Data();
			data.AccountId = _ctx.StringValue("EnableMockRule.Data.AccountId");
			data.Name = _ctx.StringValue("EnableMockRule.Data.Name");
			data.ConsumerAppId = _ctx.StringValue("EnableMockRule.Data.ConsumerAppId");
			data.ConsumerAppName = _ctx.StringValue("EnableMockRule.Data.ConsumerAppName");
			data.Enable = _ctx.BooleanValue("EnableMockRule.Data.Enable");
			data.ExtraJson = _ctx.StringValue("EnableMockRule.Data.ExtraJson");
			data.Id = _ctx.LongValue("EnableMockRule.Data.Id");
			data.NamespaceId = _ctx.StringValue("EnableMockRule.Data.NamespaceId");
			data.ProviderAppId = _ctx.StringValue("EnableMockRule.Data.ProviderAppId");
			data.ProviderAppName = _ctx.StringValue("EnableMockRule.Data.ProviderAppName");
			data.Region = _ctx.StringValue("EnableMockRule.Data.Region");
			data.ScMockItemJson = _ctx.StringValue("EnableMockRule.Data.ScMockItemJson");
			data.Source = _ctx.StringValue("EnableMockRule.Data.Source");
			enableMockRuleResponse.Data = data;
        
			return enableMockRuleResponse;
        }
    }
}
