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
    public class AddMockRuleResponseUnmarshaller
    {
        public static AddMockRuleResponse Unmarshall(UnmarshallerContext _ctx)
        {
			AddMockRuleResponse addMockRuleResponse = new AddMockRuleResponse();

			addMockRuleResponse.HttpResponse = _ctx.HttpResponse;
			addMockRuleResponse.Code = _ctx.IntegerValue("AddMockRule.Code");
			addMockRuleResponse.Message = _ctx.StringValue("AddMockRule.Message");
			addMockRuleResponse.RequestId = _ctx.StringValue("AddMockRule.RequestId");
			addMockRuleResponse.Success = _ctx.BooleanValue("AddMockRule.Success");

			AddMockRuleResponse.AddMockRule_Data data = new AddMockRuleResponse.AddMockRule_Data();
			data.AccountId = _ctx.StringValue("AddMockRule.Data.AccountId");
			data.Name = _ctx.StringValue("AddMockRule.Data.Name");
			data.ConsumerAppId = _ctx.StringValue("AddMockRule.Data.ConsumerAppId");
			data.ConsumerAppName = _ctx.StringValue("AddMockRule.Data.ConsumerAppName");
			data.Enable = _ctx.BooleanValue("AddMockRule.Data.Enable");
			data.ExtraJson = _ctx.StringValue("AddMockRule.Data.ExtraJson");
			data.Id = _ctx.LongValue("AddMockRule.Data.Id");
			data.NamespaceId = _ctx.StringValue("AddMockRule.Data.NamespaceId");
			data.ProviderAppId = _ctx.StringValue("AddMockRule.Data.ProviderAppId");
			data.ProviderAppName = _ctx.StringValue("AddMockRule.Data.ProviderAppName");
			data.Region = _ctx.StringValue("AddMockRule.Data.Region");
			data.ScMockItemJson = _ctx.StringValue("AddMockRule.Data.ScMockItemJson");
			data.Source = _ctx.StringValue("AddMockRule.Data.Source");
			addMockRuleResponse.Data = data;
        
			return addMockRuleResponse;
        }
    }
}
