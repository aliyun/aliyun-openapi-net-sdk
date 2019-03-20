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
using Aliyun.Acs.Cms.Model.V20180308;

namespace Aliyun.Acs.Cms.Transform.V20180308
{
    public class ListGroupDynamicRuleResponseUnmarshaller
    {
        public static ListGroupDynamicRuleResponse Unmarshall(UnmarshallerContext context)
        {
			ListGroupDynamicRuleResponse listGroupDynamicRuleResponse = new ListGroupDynamicRuleResponse();

			listGroupDynamicRuleResponse.HttpResponse = context.HttpResponse;
			listGroupDynamicRuleResponse.RequestId = context.StringValue("ListGroupDynamicRule.RequestId");
			listGroupDynamicRuleResponse.Success = context.BooleanValue("ListGroupDynamicRule.Success");
			listGroupDynamicRuleResponse.ErrorCode = context.IntegerValue("ListGroupDynamicRule.ErrorCode");
			listGroupDynamicRuleResponse.ErrorMessage = context.StringValue("ListGroupDynamicRule.ErrorMessage");
			listGroupDynamicRuleResponse.PageNumber = context.IntegerValue("ListGroupDynamicRule.PageNumber");
			listGroupDynamicRuleResponse.PageSize = context.IntegerValue("ListGroupDynamicRule.PageSize");
			listGroupDynamicRuleResponse.Total = context.IntegerValue("ListGroupDynamicRule.Total");

			List<ListGroupDynamicRuleResponse.ListGroupDynamicRule_ResourceItem> listGroupDynamicRuleResponse_resource = new List<ListGroupDynamicRuleResponse.ListGroupDynamicRule_ResourceItem>();
			for (int i = 0; i < context.Length("ListGroupDynamicRule.Resource.Length"); i++) {
				ListGroupDynamicRuleResponse.ListGroupDynamicRule_ResourceItem resourceItem = new ListGroupDynamicRuleResponse.ListGroupDynamicRule_ResourceItem();
				resourceItem.GroupId = context.LongValue("ListGroupDynamicRule.Resource["+ i +"].GroupId");
				resourceItem.Category = context.StringValue("ListGroupDynamicRule.Resource["+ i +"].Category");
				resourceItem.FilterRelation = context.StringValue("ListGroupDynamicRule.Resource["+ i +"].FilterRelation");

				List<ListGroupDynamicRuleResponse.ListGroupDynamicRule_ResourceItem.ListGroupDynamicRule_Filter> resourceItem_filters = new List<ListGroupDynamicRuleResponse.ListGroupDynamicRule_ResourceItem.ListGroupDynamicRule_Filter>();
				for (int j = 0; j < context.Length("ListGroupDynamicRule.Resource["+ i +"].Filters.Length"); j++) {
					ListGroupDynamicRuleResponse.ListGroupDynamicRule_ResourceItem.ListGroupDynamicRule_Filter filter = new ListGroupDynamicRuleResponse.ListGroupDynamicRule_ResourceItem.ListGroupDynamicRule_Filter();
					filter.Function = context.StringValue("ListGroupDynamicRule.Resource["+ i +"].Filters["+ j +"].Function");
					filter.Name = context.StringValue("ListGroupDynamicRule.Resource["+ i +"].Filters["+ j +"].Name");
					filter._Value = context.StringValue("ListGroupDynamicRule.Resource["+ i +"].Filters["+ j +"].Value");

					resourceItem_filters.Add(filter);
				}
				resourceItem.Filters = resourceItem_filters;

				listGroupDynamicRuleResponse_resource.Add(resourceItem);
			}
			listGroupDynamicRuleResponse.Resource = listGroupDynamicRuleResponse_resource;
        
			return listGroupDynamicRuleResponse;
        }
    }
}
