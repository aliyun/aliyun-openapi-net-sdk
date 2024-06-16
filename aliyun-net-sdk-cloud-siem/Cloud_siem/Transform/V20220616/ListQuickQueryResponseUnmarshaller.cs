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
using Aliyun.Acs.cloud_siem.Model.V20220616;

namespace Aliyun.Acs.cloud_siem.Transform.V20220616
{
    public class ListQuickQueryResponseUnmarshaller
    {
        public static ListQuickQueryResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListQuickQueryResponse listQuickQueryResponse = new ListQuickQueryResponse();

			listQuickQueryResponse.HttpResponse = _ctx.HttpResponse;
			listQuickQueryResponse.RequestId = _ctx.StringValue("ListQuickQuery.RequestId");

			ListQuickQueryResponse.ListQuickQuery_Data data = new ListQuickQueryResponse.ListQuickQuery_Data();
			data.Total = _ctx.IntegerValue("ListQuickQuery.Data.Total");
			data.Count = _ctx.IntegerValue("ListQuickQuery.Data.Count");

			List<ListQuickQueryResponse.ListQuickQuery_Data.ListQuickQuery_QuickQueryListItem> data_quickQueryList = new List<ListQuickQueryResponse.ListQuickQuery_Data.ListQuickQuery_QuickQueryListItem>();
			for (int i = 0; i < _ctx.Length("ListQuickQuery.Data.QuickQueryList.Length"); i++) {
				ListQuickQueryResponse.ListQuickQuery_Data.ListQuickQuery_QuickQueryListItem quickQueryListItem = new ListQuickQueryResponse.ListQuickQuery_Data.ListQuickQuery_QuickQueryListItem();
				quickQueryListItem.Query = _ctx.StringValue("ListQuickQuery.Data.QuickQueryList["+ i +"].Query");
				quickQueryListItem.SearchName = _ctx.StringValue("ListQuickQuery.Data.QuickQueryList["+ i +"].SearchName");
				quickQueryListItem.DisplayName = _ctx.StringValue("ListQuickQuery.Data.QuickQueryList["+ i +"].DisplayName");

				data_quickQueryList.Add(quickQueryListItem);
			}
			data.QuickQueryList = data_quickQueryList;
			listQuickQueryResponse.Data = data;
        
			return listQuickQueryResponse;
        }
    }
}
