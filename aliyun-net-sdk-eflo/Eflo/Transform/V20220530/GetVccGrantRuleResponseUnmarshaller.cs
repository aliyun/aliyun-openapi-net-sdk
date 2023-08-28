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
using Aliyun.Acs.eflo.Model.V20220530;

namespace Aliyun.Acs.eflo.Transform.V20220530
{
    public class GetVccGrantRuleResponseUnmarshaller
    {
        public static GetVccGrantRuleResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetVccGrantRuleResponse getVccGrantRuleResponse = new GetVccGrantRuleResponse();

			getVccGrantRuleResponse.HttpResponse = _ctx.HttpResponse;
			getVccGrantRuleResponse.Code = _ctx.IntegerValue("GetVccGrantRule.Code");
			getVccGrantRuleResponse.Message = _ctx.StringValue("GetVccGrantRule.Message");
			getVccGrantRuleResponse.RequestId = _ctx.StringValue("GetVccGrantRule.RequestId");

			GetVccGrantRuleResponse.GetVccGrantRule_Content content = new GetVccGrantRuleResponse.GetVccGrantRule_Content();
			content.RegionId = _ctx.StringValue("GetVccGrantRule.Content.RegionId");
			content.TenantId = _ctx.StringValue("GetVccGrantRule.Content.TenantId");
			content.InstanceId = _ctx.StringValue("GetVccGrantRule.Content.InstanceId");
			content.InstanceName = _ctx.StringValue("GetVccGrantRule.Content.InstanceName");
			content.Product = _ctx.StringValue("GetVccGrantRule.Content.Product");
			content.ErId = _ctx.StringValue("GetVccGrantRule.Content.ErId");
			content.GrantTenantId = _ctx.StringValue("GetVccGrantRule.Content.GrantTenantId");
			content.Used = _ctx.BooleanValue("GetVccGrantRule.Content.Used");
			content.CreateTime = _ctx.StringValue("GetVccGrantRule.Content.CreateTime");
			content.GrantRuleId = _ctx.StringValue("GetVccGrantRule.Content.GrantRuleId");
			getVccGrantRuleResponse.Content = content;
        
			return getVccGrantRuleResponse;
        }
    }
}
