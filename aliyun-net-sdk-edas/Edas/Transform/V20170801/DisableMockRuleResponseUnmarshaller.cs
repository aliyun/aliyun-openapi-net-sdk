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
    public class DisableMockRuleResponseUnmarshaller
    {
        public static DisableMockRuleResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DisableMockRuleResponse disableMockRuleResponse = new DisableMockRuleResponse();

			disableMockRuleResponse.HttpResponse = _ctx.HttpResponse;
			disableMockRuleResponse.Code = _ctx.IntegerValue("DisableMockRule.Code");
			disableMockRuleResponse.Message = _ctx.StringValue("DisableMockRule.Message");
			disableMockRuleResponse.RequestId = _ctx.StringValue("DisableMockRule.RequestId");
			disableMockRuleResponse.Success = _ctx.BooleanValue("DisableMockRule.Success");

			DisableMockRuleResponse.DisableMockRule_Data data = new DisableMockRuleResponse.DisableMockRule_Data();
			data.AccountId = _ctx.StringValue("DisableMockRule.Data.AccountId");
			data.Name = _ctx.StringValue("DisableMockRule.Data.Name");
			data.ConsumerAppId = _ctx.StringValue("DisableMockRule.Data.ConsumerAppId");
			data.ConsumerAppName = _ctx.StringValue("DisableMockRule.Data.ConsumerAppName");
			data.Enable = _ctx.BooleanValue("DisableMockRule.Data.Enable");
			data.ExtraJson = _ctx.StringValue("DisableMockRule.Data.ExtraJson");
			data.Id = _ctx.LongValue("DisableMockRule.Data.Id");
			data.NamespaceId = _ctx.StringValue("DisableMockRule.Data.NamespaceId");
			data.ProviderAppId = _ctx.StringValue("DisableMockRule.Data.ProviderAppId");
			data.ProviderAppName = _ctx.StringValue("DisableMockRule.Data.ProviderAppName");
			data.Region = _ctx.StringValue("DisableMockRule.Data.Region");
			data.ScMockItemJson = _ctx.StringValue("DisableMockRule.Data.ScMockItemJson");
			data.Source = _ctx.StringValue("DisableMockRule.Data.Source");
			disableMockRuleResponse.Data = data;
        
			return disableMockRuleResponse;
        }
    }
}
