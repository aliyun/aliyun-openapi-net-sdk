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
using Aliyun.Acs.Iot.Model.V20180120;

namespace Aliyun.Acs.Iot.Transform.V20180120
{
    public class ListDataSourceItemResponseUnmarshaller
    {
        public static ListDataSourceItemResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDataSourceItemResponse listDataSourceItemResponse = new ListDataSourceItemResponse();

			listDataSourceItemResponse.HttpResponse = _ctx.HttpResponse;
			listDataSourceItemResponse.RequestId = _ctx.StringValue("ListDataSourceItem.RequestId");
			listDataSourceItemResponse.Success = _ctx.BooleanValue("ListDataSourceItem.Success");
			listDataSourceItemResponse.Code = _ctx.StringValue("ListDataSourceItem.Code");
			listDataSourceItemResponse.ErrorMessage = _ctx.StringValue("ListDataSourceItem.ErrorMessage");
			listDataSourceItemResponse.Page = _ctx.IntegerValue("ListDataSourceItem.Page");
			listDataSourceItemResponse.PageSize = _ctx.IntegerValue("ListDataSourceItem.PageSize");
			listDataSourceItemResponse.Total = _ctx.IntegerValue("ListDataSourceItem.Total");

			List<ListDataSourceItemResponse.ListDataSourceItem_DataSourceItem> listDataSourceItemResponse_dataSourceItems = new List<ListDataSourceItemResponse.ListDataSourceItem_DataSourceItem>();
			for (int i = 0; i < _ctx.Length("ListDataSourceItem.DataSourceItems.Length"); i++) {
				ListDataSourceItemResponse.ListDataSourceItem_DataSourceItem dataSourceItem = new ListDataSourceItemResponse.ListDataSourceItem_DataSourceItem();
				dataSourceItem.DataSourceItemId = _ctx.LongValue("ListDataSourceItem.DataSourceItems["+ i +"].DataSourceItemId");
				dataSourceItem.Topic = _ctx.StringValue("ListDataSourceItem.DataSourceItems["+ i +"].Topic");
				dataSourceItem.ScopeType = _ctx.StringValue("ListDataSourceItem.DataSourceItems["+ i +"].ScopeType");
				dataSourceItem.ProductKey = _ctx.StringValue("ListDataSourceItem.DataSourceItems["+ i +"].ProductKey");
				dataSourceItem.DeviceName = _ctx.StringValue("ListDataSourceItem.DataSourceItems["+ i +"].DeviceName");

				listDataSourceItemResponse_dataSourceItems.Add(dataSourceItem);
			}
			listDataSourceItemResponse.DataSourceItems = listDataSourceItemResponse_dataSourceItems;
        
			return listDataSourceItemResponse;
        }
    }
}
