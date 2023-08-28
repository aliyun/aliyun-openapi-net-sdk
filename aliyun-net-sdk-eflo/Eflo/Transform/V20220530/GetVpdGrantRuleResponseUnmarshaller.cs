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
    public class GetVpdGrantRuleResponseUnmarshaller
    {
        public static GetVpdGrantRuleResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetVpdGrantRuleResponse getVpdGrantRuleResponse = new GetVpdGrantRuleResponse();

			getVpdGrantRuleResponse.HttpResponse = _ctx.HttpResponse;
			getVpdGrantRuleResponse.Code = _ctx.IntegerValue("GetVpdGrantRule.Code");
			getVpdGrantRuleResponse.Message = _ctx.StringValue("GetVpdGrantRule.Message");
			getVpdGrantRuleResponse.RequestId = _ctx.StringValue("GetVpdGrantRule.RequestId");

			GetVpdGrantRuleResponse.GetVpdGrantRule_Content content = new GetVpdGrantRuleResponse.GetVpdGrantRule_Content();
			content.RegionId = _ctx.StringValue("GetVpdGrantRule.Content.RegionId");
			content.TenantId = _ctx.StringValue("GetVpdGrantRule.Content.TenantId");
			content.InstanceId = _ctx.StringValue("GetVpdGrantRule.Content.InstanceId");
			content.InstanceName = _ctx.StringValue("GetVpdGrantRule.Content.InstanceName");
			content.Product = _ctx.StringValue("GetVpdGrantRule.Content.Product");
			content.ErId = _ctx.StringValue("GetVpdGrantRule.Content.ErId");
			content.GrantTenantId = _ctx.StringValue("GetVpdGrantRule.Content.GrantTenantId");
			content.Used = _ctx.BooleanValue("GetVpdGrantRule.Content.Used");
			content.CreateTime = _ctx.StringValue("GetVpdGrantRule.Content.CreateTime");
			content.GrantRuleId = _ctx.StringValue("GetVpdGrantRule.Content.GrantRuleId");
			getVpdGrantRuleResponse.Content = content;
        
			return getVpdGrantRuleResponse;
        }
    }
}
