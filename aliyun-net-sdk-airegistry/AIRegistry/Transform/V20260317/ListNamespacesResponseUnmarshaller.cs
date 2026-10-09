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
using Aliyun.Acs.AIRegistry.Model.V20260317;

namespace Aliyun.Acs.AIRegistry.Transform.V20260317
{
    public class ListNamespacesResponseUnmarshaller
    {
        public static ListNamespacesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListNamespacesResponse listNamespacesResponse = new ListNamespacesResponse();

			listNamespacesResponse.HttpResponse = _ctx.HttpResponse;
			listNamespacesResponse.RequestId = _ctx.StringValue("ListNamespaces.RequestId");

			ListNamespacesResponse.ListNamespaces_Data data = new ListNamespacesResponse.ListNamespaces_Data();
			data.TotalCount = _ctx.IntegerValue("ListNamespaces.Data.TotalCount");
			data.PageSize = _ctx.IntegerValue("ListNamespaces.Data.PageSize");
			data.PageNumber = _ctx.IntegerValue("ListNamespaces.Data.PageNumber");

			List<ListNamespacesResponse.ListNamespaces_Data.ListNamespaces_Item> data_items = new List<ListNamespacesResponse.ListNamespaces_Data.ListNamespaces_Item>();
			for (int i = 0; i < _ctx.Length("ListNamespaces.Data.Items.Length"); i++) {
				ListNamespacesResponse.ListNamespaces_Data.ListNamespaces_Item item = new ListNamespacesResponse.ListNamespaces_Data.ListNamespaces_Item();
				item.SourceIndex = _ctx.IntegerValue("ListNamespaces.Data.Items["+ i +"].SourceIndex");
				item.Description = _ctx.StringValue("ListNamespaces.Data.Items["+ i +"].Description");
				item.PromptCount = _ctx.IntegerValue("ListNamespaces.Data.Items["+ i +"].PromptCount");
				item.CreatedTime = _ctx.StringValue("ListNamespaces.Data.Items["+ i +"].CreatedTime");
				item.IpWhitelist = _ctx.StringValue("ListNamespaces.Data.Items["+ i +"].IpWhitelist");
				item.SkillCount = _ctx.IntegerValue("ListNamespaces.Data.Items["+ i +"].SkillCount");
				item.PublicAccessEnabled = _ctx.BooleanValue("ListNamespaces.Data.Items["+ i +"].PublicAccessEnabled");
				item.NamespaceId = _ctx.StringValue("ListNamespaces.Data.Items["+ i +"].NamespaceId");
				item.Tags = _ctx.StringValue("ListNamespaces.Data.Items["+ i +"].Tags");
				item.Source = _ctx.StringValue("ListNamespaces.Data.Items["+ i +"].Source");
				item.Name = _ctx.StringValue("ListNamespaces.Data.Items["+ i +"].Name");
				item.PublicDomain = _ctx.StringValue("ListNamespaces.Data.Items["+ i +"].PublicDomain");

				data_items.Add(item);
			}
			data.Items = data_items;
			listNamespacesResponse.Data = data;
        
			return listNamespacesResponse;
        }
    }
}
