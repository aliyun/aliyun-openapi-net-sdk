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
using Aliyun.Acs.idrsservice.Model.V20200630;

namespace Aliyun.Acs.idrsservice.Transform.V20200630
{
    public class ListRulesResponseUnmarshaller
    {
        public static ListRulesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListRulesResponse listRulesResponse = new ListRulesResponse();

			listRulesResponse.HttpResponse = _ctx.HttpResponse;
			listRulesResponse.Code = _ctx.StringValue("ListRules.Code");
			listRulesResponse.Message = _ctx.StringValue("ListRules.Message");
			listRulesResponse.RequestId = _ctx.StringValue("ListRules.RequestId");

			ListRulesResponse.ListRules_Data data = new ListRulesResponse.ListRules_Data();
			data.TotalElements = _ctx.LongValue("ListRules.Data.TotalElements");
			data.TotalPages = _ctx.IntegerValue("ListRules.Data.TotalPages");

			List<ListRulesResponse.ListRules_Data.ListRules_ItemsItem> data_items = new List<ListRulesResponse.ListRules_Data.ListRules_ItemsItem>();
			for (int i = 0; i < _ctx.Length("ListRules.Data.Items.Length"); i++) {
				ListRulesResponse.ListRules_Data.ListRules_ItemsItem itemsItem = new ListRulesResponse.ListRules_Data.ListRules_ItemsItem();
				itemsItem.Content = _ctx.StringValue("ListRules.Data.Items["+ i +"].Content");
				itemsItem.CreatedAt = _ctx.StringValue("ListRules.Data.Items["+ i +"].CreatedAt");
				itemsItem.Id = _ctx.StringValue("ListRules.Data.Items["+ i +"].Id");
				itemsItem.Name = _ctx.StringValue("ListRules.Data.Items["+ i +"].Name");

				data_items.Add(itemsItem);
			}
			data.Items = data_items;
			listRulesResponse.Data = data;
        
			return listRulesResponse;
        }
    }
}
