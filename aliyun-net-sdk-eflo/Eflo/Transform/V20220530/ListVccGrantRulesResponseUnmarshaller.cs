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
    public class ListVccGrantRulesResponseUnmarshaller
    {
        public static ListVccGrantRulesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListVccGrantRulesResponse listVccGrantRulesResponse = new ListVccGrantRulesResponse();

			listVccGrantRulesResponse.HttpResponse = _ctx.HttpResponse;
			listVccGrantRulesResponse.Code = _ctx.IntegerValue("ListVccGrantRules.Code");
			listVccGrantRulesResponse.Message = _ctx.StringValue("ListVccGrantRules.Message");
			listVccGrantRulesResponse.RequestId = _ctx.StringValue("ListVccGrantRules.RequestId");

			ListVccGrantRulesResponse.ListVccGrantRules_Content content = new ListVccGrantRulesResponse.ListVccGrantRules_Content();
			content.Total = _ctx.LongValue("ListVccGrantRules.Content.Total");

			List<ListVccGrantRulesResponse.ListVccGrantRules_Content.ListVccGrantRules_DataItem> content_data = new List<ListVccGrantRulesResponse.ListVccGrantRules_Content.ListVccGrantRules_DataItem>();
			for (int i = 0; i < _ctx.Length("ListVccGrantRules.Content.Data.Length"); i++) {
				ListVccGrantRulesResponse.ListVccGrantRules_Content.ListVccGrantRules_DataItem dataItem = new ListVccGrantRulesResponse.ListVccGrantRules_Content.ListVccGrantRules_DataItem();
				dataItem.RegionId = _ctx.StringValue("ListVccGrantRules.Content.Data["+ i +"].RegionId");
				dataItem.TenantId = _ctx.StringValue("ListVccGrantRules.Content.Data["+ i +"].TenantId");
				dataItem.InstanceId = _ctx.StringValue("ListVccGrantRules.Content.Data["+ i +"].InstanceId");
				dataItem.InstanceName = _ctx.StringValue("ListVccGrantRules.Content.Data["+ i +"].InstanceName");
				dataItem.Product = _ctx.StringValue("ListVccGrantRules.Content.Data["+ i +"].Product");
				dataItem.ErId = _ctx.StringValue("ListVccGrantRules.Content.Data["+ i +"].ErId");
				dataItem.GrantTenantId = _ctx.StringValue("ListVccGrantRules.Content.Data["+ i +"].GrantTenantId");
				dataItem.Used = _ctx.BooleanValue("ListVccGrantRules.Content.Data["+ i +"].Used");
				dataItem.CreateTime = _ctx.StringValue("ListVccGrantRules.Content.Data["+ i +"].CreateTime");
				dataItem.GrantRuleId = _ctx.StringValue("ListVccGrantRules.Content.Data["+ i +"].GrantRuleId");
				dataItem.ResourceGroupId = _ctx.StringValue("ListVccGrantRules.Content.Data["+ i +"].ResourceGroupId");

				content_data.Add(dataItem);
			}
			content.Data = content_data;
			listVccGrantRulesResponse.Content = content;
        
			return listVccGrantRulesResponse;
        }
    }
}
