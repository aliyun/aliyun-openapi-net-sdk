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
using Aliyun.Acs.CCC.Model.V20170705;

namespace Aliyun.Acs.CCC.Transform.V20170705
{
    public class ListBasicStatisticsReportSubItemsResponseUnmarshaller
    {
        public static ListBasicStatisticsReportSubItemsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListBasicStatisticsReportSubItemsResponse listBasicStatisticsReportSubItemsResponse = new ListBasicStatisticsReportSubItemsResponse();

			listBasicStatisticsReportSubItemsResponse.HttpResponse = _ctx.HttpResponse;
			listBasicStatisticsReportSubItemsResponse.RequestId = _ctx.StringValue("ListBasicStatisticsReportSubItems.RequestId");
			listBasicStatisticsReportSubItemsResponse.Success = _ctx.BooleanValue("ListBasicStatisticsReportSubItems.Success");
			listBasicStatisticsReportSubItemsResponse.Code = _ctx.StringValue("ListBasicStatisticsReportSubItems.Code");
			listBasicStatisticsReportSubItemsResponse.Message = _ctx.StringValue("ListBasicStatisticsReportSubItems.Message");
			listBasicStatisticsReportSubItemsResponse.HttpStatusCode = _ctx.IntegerValue("ListBasicStatisticsReportSubItems.HttpStatusCode");

			ListBasicStatisticsReportSubItemsResponse.ListBasicStatisticsReportSubItems_SubItems subItems = new ListBasicStatisticsReportSubItemsResponse.ListBasicStatisticsReportSubItems_SubItems();
			subItems.TotalCount = _ctx.IntegerValue("ListBasicStatisticsReportSubItems.SubItems.TotalCount");
			subItems.PageNumber = _ctx.IntegerValue("ListBasicStatisticsReportSubItems.SubItems.PageNumber");
			subItems.PageSize = _ctx.IntegerValue("ListBasicStatisticsReportSubItems.SubItems.PageSize");

			List<ListBasicStatisticsReportSubItemsResponse.ListBasicStatisticsReportSubItems_SubItems.ListBasicStatisticsReportSubItems_BasicStatisticsReportSubItem> subItems_list = new List<ListBasicStatisticsReportSubItemsResponse.ListBasicStatisticsReportSubItems_SubItems.ListBasicStatisticsReportSubItems_BasicStatisticsReportSubItem>();
			for (int i = 0; i < _ctx.Length("ListBasicStatisticsReportSubItems.SubItems.List.Length"); i++) {
				ListBasicStatisticsReportSubItemsResponse.ListBasicStatisticsReportSubItems_SubItems.ListBasicStatisticsReportSubItems_BasicStatisticsReportSubItem basicStatisticsReportSubItem = new ListBasicStatisticsReportSubItemsResponse.ListBasicStatisticsReportSubItems_SubItems.ListBasicStatisticsReportSubItems_BasicStatisticsReportSubItem();
				basicStatisticsReportSubItem.BasicStatisticsReportSubItemName = _ctx.StringValue("ListBasicStatisticsReportSubItems.SubItems.List["+ i +"].BasicStatisticsReportSubItemName");
				basicStatisticsReportSubItem._Value = _ctx.StringValue("ListBasicStatisticsReportSubItems.SubItems.List["+ i +"].Value");
				basicStatisticsReportSubItem.Count = _ctx.IntegerValue("ListBasicStatisticsReportSubItems.SubItems.List["+ i +"].Count");
				basicStatisticsReportSubItem.Percentage = _ctx.IntegerValue("ListBasicStatisticsReportSubItems.SubItems.List["+ i +"].Percentage");

				List<ListBasicStatisticsReportSubItemsResponse.ListBasicStatisticsReportSubItems_SubItems.ListBasicStatisticsReportSubItems_BasicStatisticsReportSubItem.ListBasicStatisticsReportSubItems_KeyValuePair> basicStatisticsReportSubItem_row = new List<ListBasicStatisticsReportSubItemsResponse.ListBasicStatisticsReportSubItems_SubItems.ListBasicStatisticsReportSubItems_BasicStatisticsReportSubItem.ListBasicStatisticsReportSubItems_KeyValuePair>();
				for (int j = 0; j < _ctx.Length("ListBasicStatisticsReportSubItems.SubItems.List["+ i +"].Row.Length"); j++) {
					ListBasicStatisticsReportSubItemsResponse.ListBasicStatisticsReportSubItems_SubItems.ListBasicStatisticsReportSubItems_BasicStatisticsReportSubItem.ListBasicStatisticsReportSubItems_KeyValuePair keyValuePair = new ListBasicStatisticsReportSubItemsResponse.ListBasicStatisticsReportSubItems_SubItems.ListBasicStatisticsReportSubItems_BasicStatisticsReportSubItem.ListBasicStatisticsReportSubItems_KeyValuePair();
					keyValuePair.Key = _ctx.StringValue("ListBasicStatisticsReportSubItems.SubItems.List["+ i +"].Row["+ j +"].Key");
					keyValuePair._Value = _ctx.StringValue("ListBasicStatisticsReportSubItems.SubItems.List["+ i +"].Row["+ j +"].Value");

					basicStatisticsReportSubItem_row.Add(keyValuePair);
				}
				basicStatisticsReportSubItem.Row = basicStatisticsReportSubItem_row;

				subItems_list.Add(basicStatisticsReportSubItem);
			}
			subItems.List = subItems_list;
			listBasicStatisticsReportSubItemsResponse.SubItems = subItems;
        
			return listBasicStatisticsReportSubItemsResponse;
        }
    }
}
