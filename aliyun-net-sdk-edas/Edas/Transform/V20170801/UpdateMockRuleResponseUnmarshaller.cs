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
    public class UpdateMockRuleResponseUnmarshaller
    {
        public static UpdateMockRuleResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdateMockRuleResponse updateMockRuleResponse = new UpdateMockRuleResponse();

			updateMockRuleResponse.HttpResponse = _ctx.HttpResponse;
			updateMockRuleResponse.Code = _ctx.StringValue("UpdateMockRule.Code");
			updateMockRuleResponse.HttpCode = _ctx.StringValue("UpdateMockRule.HttpCode");
			updateMockRuleResponse.Message = _ctx.StringValue("UpdateMockRule.Message");
			updateMockRuleResponse.RequestId = _ctx.StringValue("UpdateMockRule.RequestId");
			updateMockRuleResponse.Success = _ctx.BooleanValue("UpdateMockRule.Success");

			UpdateMockRuleResponse.UpdateMockRule_Data data = new UpdateMockRuleResponse.UpdateMockRule_Data();
			data.AccountId = _ctx.StringValue("UpdateMockRule.Data.AccountId");
			data.Name = _ctx.StringValue("UpdateMockRule.Data.Name");
			data.ConsumerAppId = _ctx.StringValue("UpdateMockRule.Data.ConsumerAppId");
			data.ConsumerAppName = _ctx.StringValue("UpdateMockRule.Data.ConsumerAppName");
			data.Enable = _ctx.BooleanValue("UpdateMockRule.Data.Enable");
			data.ExtraJson = _ctx.StringValue("UpdateMockRule.Data.ExtraJson");
			data.Id = _ctx.LongValue("UpdateMockRule.Data.Id");
			data.NamespaceId = _ctx.StringValue("UpdateMockRule.Data.NamespaceId");
			data.ProviderAppId = _ctx.StringValue("UpdateMockRule.Data.ProviderAppId");
			data.ProviderAppName = _ctx.StringValue("UpdateMockRule.Data.ProviderAppName");
			data.Region = _ctx.StringValue("UpdateMockRule.Data.Region");
			data.ScMockItemJson = _ctx.StringValue("UpdateMockRule.Data.ScMockItemJson");
			data.Source = _ctx.StringValue("UpdateMockRule.Data.Source");
			data.DubboMockItemJson = _ctx.StringValue("UpdateMockRule.Data.DubboMockItemJson");
			updateMockRuleResponse.Data = data;
        
			return updateMockRuleResponse;
        }
    }
}
