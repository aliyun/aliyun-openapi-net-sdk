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
using Aliyun.Acs.Rds.Model.V20140815;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeSQLLogReportListResponseUnmarshaller
    {
        public static DescribeSQLLogReportListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSQLLogReportListResponse describeSQLLogReportListResponse = new DescribeSQLLogReportListResponse();

			describeSQLLogReportListResponse.HttpResponse = _ctx.HttpResponse;
			describeSQLLogReportListResponse.RequestId = _ctx.StringValue("DescribeSQLLogReportList.RequestId");
			describeSQLLogReportListResponse.TotalRecordCount = _ctx.IntegerValue("DescribeSQLLogReportList.TotalRecordCount");
			describeSQLLogReportListResponse.PageNumber = _ctx.IntegerValue("DescribeSQLLogReportList.PageNumber");
			describeSQLLogReportListResponse.PageRecordCount = _ctx.IntegerValue("DescribeSQLLogReportList.PageRecordCount");

			List<DescribeSQLLogReportListResponse.DescribeSQLLogReportList_Item> describeSQLLogReportListResponse_items = new List<DescribeSQLLogReportListResponse.DescribeSQLLogReportList_Item>();
			for (int i = 0; i < _ctx.Length("DescribeSQLLogReportList.Items.Length"); i++) {
				DescribeSQLLogReportListResponse.DescribeSQLLogReportList_Item item = new DescribeSQLLogReportListResponse.DescribeSQLLogReportList_Item();
				item.ReportTime = _ctx.StringValue("DescribeSQLLogReportList.Items["+ i +"].ReportTime");

				List<DescribeSQLLogReportListResponse.DescribeSQLLogReportList_Item.DescribeSQLLogReportList_LatencyTopNItem> item_latencyTopNItems = new List<DescribeSQLLogReportListResponse.DescribeSQLLogReportList_Item.DescribeSQLLogReportList_LatencyTopNItem>();
				for (int j = 0; j < _ctx.Length("DescribeSQLLogReportList.Items["+ i +"].LatencyTopNItems.Length"); j++) {
					DescribeSQLLogReportListResponse.DescribeSQLLogReportList_Item.DescribeSQLLogReportList_LatencyTopNItem latencyTopNItem = new DescribeSQLLogReportListResponse.DescribeSQLLogReportList_Item.DescribeSQLLogReportList_LatencyTopNItem();
					latencyTopNItem.SQLText = _ctx.StringValue("DescribeSQLLogReportList.Items["+ i +"].LatencyTopNItems["+ j +"].SQLText");
					latencyTopNItem.AvgLatency = _ctx.LongValue("DescribeSQLLogReportList.Items["+ i +"].LatencyTopNItems["+ j +"].AvgLatency");
					latencyTopNItem.SQLExecuteTimes = _ctx.LongValue("DescribeSQLLogReportList.Items["+ i +"].LatencyTopNItems["+ j +"].SQLExecuteTimes");

					item_latencyTopNItems.Add(latencyTopNItem);
				}
				item.LatencyTopNItems = item_latencyTopNItems;

				List<DescribeSQLLogReportListResponse.DescribeSQLLogReportList_Item.DescribeSQLLogReportList_QPSTopNItem> item_qPSTopNItems = new List<DescribeSQLLogReportListResponse.DescribeSQLLogReportList_Item.DescribeSQLLogReportList_QPSTopNItem>();
				for (int j = 0; j < _ctx.Length("DescribeSQLLogReportList.Items["+ i +"].QPSTopNItems.Length"); j++) {
					DescribeSQLLogReportListResponse.DescribeSQLLogReportList_Item.DescribeSQLLogReportList_QPSTopNItem qPSTopNItem = new DescribeSQLLogReportListResponse.DescribeSQLLogReportList_Item.DescribeSQLLogReportList_QPSTopNItem();
					qPSTopNItem.SQLText = _ctx.StringValue("DescribeSQLLogReportList.Items["+ i +"].QPSTopNItems["+ j +"].SQLText");
					qPSTopNItem.SQLExecuteTimes = _ctx.LongValue("DescribeSQLLogReportList.Items["+ i +"].QPSTopNItems["+ j +"].SQLExecuteTimes");

					item_qPSTopNItems.Add(qPSTopNItem);
				}
				item.QPSTopNItems = item_qPSTopNItems;

				describeSQLLogReportListResponse_items.Add(item);
			}
			describeSQLLogReportListResponse.Items = describeSQLLogReportListResponse_items;
        
			return describeSQLLogReportListResponse;
        }
    }
}
