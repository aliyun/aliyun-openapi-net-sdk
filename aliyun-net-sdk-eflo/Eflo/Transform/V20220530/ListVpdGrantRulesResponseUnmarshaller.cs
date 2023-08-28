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
    public class ListVpdGrantRulesResponseUnmarshaller
    {
        public static ListVpdGrantRulesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListVpdGrantRulesResponse listVpdGrantRulesResponse = new ListVpdGrantRulesResponse();

			listVpdGrantRulesResponse.HttpResponse = _ctx.HttpResponse;
			listVpdGrantRulesResponse.Code = _ctx.IntegerValue("ListVpdGrantRules.Code");
			listVpdGrantRulesResponse.Message = _ctx.StringValue("ListVpdGrantRules.Message");
			listVpdGrantRulesResponse.RequestId = _ctx.StringValue("ListVpdGrantRules.RequestId");

			ListVpdGrantRulesResponse.ListVpdGrantRules_Content content = new ListVpdGrantRulesResponse.ListVpdGrantRules_Content();
			content.Total = _ctx.LongValue("ListVpdGrantRules.Content.Total");

			List<ListVpdGrantRulesResponse.ListVpdGrantRules_Content.ListVpdGrantRules_DataItem> content_data = new List<ListVpdGrantRulesResponse.ListVpdGrantRules_Content.ListVpdGrantRules_DataItem>();
			for (int i = 0; i < _ctx.Length("ListVpdGrantRules.Content.Data.Length"); i++) {
				ListVpdGrantRulesResponse.ListVpdGrantRules_Content.ListVpdGrantRules_DataItem dataItem = new ListVpdGrantRulesResponse.ListVpdGrantRules_Content.ListVpdGrantRules_DataItem();
				dataItem.RegionId = _ctx.StringValue("ListVpdGrantRules.Content.Data["+ i +"].RegionId");
				dataItem.TenantId = _ctx.StringValue("ListVpdGrantRules.Content.Data["+ i +"].TenantId");
				dataItem.InstanceId = _ctx.StringValue("ListVpdGrantRules.Content.Data["+ i +"].InstanceId");
				dataItem.InstanceName = _ctx.StringValue("ListVpdGrantRules.Content.Data["+ i +"].InstanceName");
				dataItem.Product = _ctx.StringValue("ListVpdGrantRules.Content.Data["+ i +"].Product");
				dataItem.ErId = _ctx.StringValue("ListVpdGrantRules.Content.Data["+ i +"].ErId");
				dataItem.GrantTenantId = _ctx.StringValue("ListVpdGrantRules.Content.Data["+ i +"].GrantTenantId");
				dataItem.Used = _ctx.BooleanValue("ListVpdGrantRules.Content.Data["+ i +"].Used");
				dataItem.CreateTime = _ctx.StringValue("ListVpdGrantRules.Content.Data["+ i +"].CreateTime");
				dataItem.GrantRuleId = _ctx.StringValue("ListVpdGrantRules.Content.Data["+ i +"].GrantRuleId");

				content_data.Add(dataItem);
			}
			content.Data = content_data;
			listVpdGrantRulesResponse.Content = content;
        
			return listVpdGrantRulesResponse;
        }
    }
}
