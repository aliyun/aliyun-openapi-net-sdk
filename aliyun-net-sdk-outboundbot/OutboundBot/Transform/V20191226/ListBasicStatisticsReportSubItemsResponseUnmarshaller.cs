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
using Aliyun.Acs.OutboundBot.Model.V20191226;

namespace Aliyun.Acs.OutboundBot.Transform.V20191226
{
    public class ListBasicStatisticsReportSubItemsResponseUnmarshaller
    {
        public static ListBasicStatisticsReportSubItemsResponse Unmarshall(UnmarshallerContext context)
        {
			ListBasicStatisticsReportSubItemsResponse listBasicStatisticsReportSubItemsResponse = new ListBasicStatisticsReportSubItemsResponse();

			listBasicStatisticsReportSubItemsResponse.HttpResponse = context.HttpResponse;
			listBasicStatisticsReportSubItemsResponse.RequestId = context.StringValue("ListBasicStatisticsReportSubItems.RequestId");
			listBasicStatisticsReportSubItemsResponse.Success = context.BooleanValue("ListBasicStatisticsReportSubItems.Success");
			listBasicStatisticsReportSubItemsResponse.Code = context.StringValue("ListBasicStatisticsReportSubItems.Code");
			listBasicStatisticsReportSubItemsResponse.Message = context.StringValue("ListBasicStatisticsReportSubItems.Message");
			listBasicStatisticsReportSubItemsResponse.HttpStatusCode = context.IntegerValue("ListBasicStatisticsReportSubItems.HttpStatusCode");

			ListBasicStatisticsReportSubItemsResponse.ListBasicStatisticsReportSubItems_BasicStatisticsReportSubItems basicStatisticsReportSubItems = new ListBasicStatisticsReportSubItemsResponse.ListBasicStatisticsReportSubItems_BasicStatisticsReportSubItems();
			basicStatisticsReportSubItems.TotalCount = context.IntegerValue("ListBasicStatisticsReportSubItems.BasicStatisticsReportSubItems.TotalCount");
			basicStatisticsReportSubItems.PageNumber = context.IntegerValue("ListBasicStatisticsReportSubItems.BasicStatisticsReportSubItems.PageNumber");
			basicStatisticsReportSubItems.PageSize = context.IntegerValue("ListBasicStatisticsReportSubItems.BasicStatisticsReportSubItems.PageSize");

			List<ListBasicStatisticsReportSubItemsResponse.ListBasicStatisticsReportSubItems_BasicStatisticsReportSubItems.ListBasicStatisticsReportSubItems_BasicStatisticsReportSubItem> basicStatisticsReportSubItems_list = new List<ListBasicStatisticsReportSubItemsResponse.ListBasicStatisticsReportSubItems_BasicStatisticsReportSubItems.ListBasicStatisticsReportSubItems_BasicStatisticsReportSubItem>();
			for (int i = 0; i < context.Length("ListBasicStatisticsReportSubItems.BasicStatisticsReportSubItems.List.Length"); i++) {
				ListBasicStatisticsReportSubItemsResponse.ListBasicStatisticsReportSubItems_BasicStatisticsReportSubItems.ListBasicStatisticsReportSubItems_BasicStatisticsReportSubItem basicStatisticsReportSubItem = new ListBasicStatisticsReportSubItemsResponse.ListBasicStatisticsReportSubItems_BasicStatisticsReportSubItems.ListBasicStatisticsReportSubItems_BasicStatisticsReportSubItem();
				basicStatisticsReportSubItem.BasicStatisticsReportSubItemName = context.StringValue("ListBasicStatisticsReportSubItems.BasicStatisticsReportSubItems.List["+ i +"].BasicStatisticsReportSubItemName");
				basicStatisticsReportSubItem._Value = context.StringValue("ListBasicStatisticsReportSubItems.BasicStatisticsReportSubItems.List["+ i +"].Value");
				basicStatisticsReportSubItem.Count = context.IntegerValue("ListBasicStatisticsReportSubItems.BasicStatisticsReportSubItems.List["+ i +"].Count");
				basicStatisticsReportSubItem.Percentage = context.IntegerValue("ListBasicStatisticsReportSubItems.BasicStatisticsReportSubItems.List["+ i +"].Percentage");

				List<ListBasicStatisticsReportSubItemsResponse.ListBasicStatisticsReportSubItems_BasicStatisticsReportSubItems.ListBasicStatisticsReportSubItems_BasicStatisticsReportSubItem.ListBasicStatisticsReportSubItems_KeyValuePair> basicStatisticsReportSubItem_row = new List<ListBasicStatisticsReportSubItemsResponse.ListBasicStatisticsReportSubItems_BasicStatisticsReportSubItems.ListBasicStatisticsReportSubItems_BasicStatisticsReportSubItem.ListBasicStatisticsReportSubItems_KeyValuePair>();
				for (int j = 0; j < context.Length("ListBasicStatisticsReportSubItems.BasicStatisticsReportSubItems.List["+ i +"].Row.Length"); j++) {
					ListBasicStatisticsReportSubItemsResponse.ListBasicStatisticsReportSubItems_BasicStatisticsReportSubItems.ListBasicStatisticsReportSubItems_BasicStatisticsReportSubItem.ListBasicStatisticsReportSubItems_KeyValuePair keyValuePair = new ListBasicStatisticsReportSubItemsResponse.ListBasicStatisticsReportSubItems_BasicStatisticsReportSubItems.ListBasicStatisticsReportSubItems_BasicStatisticsReportSubItem.ListBasicStatisticsReportSubItems_KeyValuePair();
					keyValuePair.Key = context.StringValue("ListBasicStatisticsReportSubItems.BasicStatisticsReportSubItems.List["+ i +"].Row["+ j +"].Key");
					keyValuePair._Value = context.StringValue("ListBasicStatisticsReportSubItems.BasicStatisticsReportSubItems.List["+ i +"].Row["+ j +"].Value");

					basicStatisticsReportSubItem_row.Add(keyValuePair);
				}
				basicStatisticsReportSubItem.Row = basicStatisticsReportSubItem_row;

				basicStatisticsReportSubItems_list.Add(basicStatisticsReportSubItem);
			}
			basicStatisticsReportSubItems.List = basicStatisticsReportSubItems_list;
			listBasicStatisticsReportSubItemsResponse.BasicStatisticsReportSubItems = basicStatisticsReportSubItems;
        
			return listBasicStatisticsReportSubItemsResponse;
        }
    }
}
