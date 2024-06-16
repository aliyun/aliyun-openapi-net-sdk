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
using Aliyun.Acs.oos.Model.V20190601;

namespace Aliyun.Acs.oos.Transform.V20190601
{
    public class ListOpsItemsResponseUnmarshaller
    {
        public static ListOpsItemsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListOpsItemsResponse listOpsItemsResponse = new ListOpsItemsResponse();

			listOpsItemsResponse.HttpResponse = _ctx.HttpResponse;
			listOpsItemsResponse.NextToken = _ctx.StringValue("ListOpsItems.NextToken");
			listOpsItemsResponse.RequestId = _ctx.StringValue("ListOpsItems.RequestId");
			listOpsItemsResponse.MaxResults = _ctx.IntegerValue("ListOpsItems.MaxResults");
			listOpsItemsResponse.TotalCount = _ctx.IntegerValue("ListOpsItems.TotalCount");

			List<ListOpsItemsResponse.ListOpsItems_OpsItem> listOpsItemsResponse_opsItems = new List<ListOpsItemsResponse.ListOpsItems_OpsItem>();
			for (int i = 0; i < _ctx.Length("ListOpsItems.OpsItems.Length"); i++) {
				ListOpsItemsResponse.ListOpsItems_OpsItem opsItem = new ListOpsItemsResponse.ListOpsItems_OpsItem();
				opsItem.OpsItemId = _ctx.StringValue("ListOpsItems.OpsItems["+ i +"].OpsItemId");
				opsItem.CreateDate = _ctx.StringValue("ListOpsItems.OpsItems["+ i +"].CreateDate");
				opsItem.UpdateDate = _ctx.StringValue("ListOpsItems.OpsItems["+ i +"].UpdateDate");
				opsItem.Title = _ctx.StringValue("ListOpsItems.OpsItems["+ i +"].Title");
				opsItem.Status = _ctx.StringValue("ListOpsItems.OpsItems["+ i +"].Status");
				opsItem.Severity = _ctx.StringValue("ListOpsItems.OpsItems["+ i +"].Severity");
				opsItem.Category = _ctx.StringValue("ListOpsItems.OpsItems["+ i +"].Category");
				opsItem.Source = _ctx.StringValue("ListOpsItems.OpsItems["+ i +"].Source");
				opsItem.Priority = _ctx.IntegerValue("ListOpsItems.OpsItems["+ i +"].Priority");
				opsItem.Tags = _ctx.StringValue("ListOpsItems.OpsItems["+ i +"].Tags");

				List<string> opsItem_resources = new List<string>();
				for (int j = 0; j < _ctx.Length("ListOpsItems.OpsItems["+ i +"].Resources.Length"); j++) {
					opsItem_resources.Add(_ctx.StringValue("ListOpsItems.OpsItems["+ i +"].Resources["+ j +"]"));
				}
				opsItem.Resources = opsItem_resources;

				listOpsItemsResponse_opsItems.Add(opsItem);
			}
			listOpsItemsResponse.OpsItems = listOpsItemsResponse_opsItems;
        
			return listOpsItemsResponse;
        }
    }
}
