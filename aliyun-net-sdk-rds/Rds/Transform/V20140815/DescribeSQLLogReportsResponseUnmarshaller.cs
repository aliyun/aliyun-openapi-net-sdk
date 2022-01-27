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
    public class DescribeSQLLogReportsResponseUnmarshaller
    {
        public static DescribeSQLLogReportsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSQLLogReportsResponse describeSQLLogReportsResponse = new DescribeSQLLogReportsResponse();

			describeSQLLogReportsResponse.HttpResponse = _ctx.HttpResponse;
			describeSQLLogReportsResponse.RequestId = _ctx.StringValue("DescribeSQLLogReports.RequestId");
			describeSQLLogReportsResponse.TotalRecordCount = _ctx.IntegerValue("DescribeSQLLogReports.TotalRecordCount");
			describeSQLLogReportsResponse.PageNumber = _ctx.IntegerValue("DescribeSQLLogReports.PageNumber");
			describeSQLLogReportsResponse.PageRecordCount = _ctx.IntegerValue("DescribeSQLLogReports.PageRecordCount");

			List<DescribeSQLLogReportsResponse.DescribeSQLLogReports_Item> describeSQLLogReportsResponse_items = new List<DescribeSQLLogReportsResponse.DescribeSQLLogReports_Item>();
			for (int i = 0; i < _ctx.Length("DescribeSQLLogReports.Items.Length"); i++) {
				DescribeSQLLogReportsResponse.DescribeSQLLogReports_Item item = new DescribeSQLLogReportsResponse.DescribeSQLLogReports_Item();
				item.ReportTime = _ctx.StringValue("DescribeSQLLogReports.Items["+ i +"].ReportTime");

				List<DescribeSQLLogReportsResponse.DescribeSQLLogReports_Item.DescribeSQLLogReports_LatencyTopNItem> item_latencyTopNItems = new List<DescribeSQLLogReportsResponse.DescribeSQLLogReports_Item.DescribeSQLLogReports_LatencyTopNItem>();
				for (int j = 0; j < _ctx.Length("DescribeSQLLogReports.Items["+ i +"].LatencyTopNItems.Length"); j++) {
					DescribeSQLLogReportsResponse.DescribeSQLLogReports_Item.DescribeSQLLogReports_LatencyTopNItem latencyTopNItem = new DescribeSQLLogReportsResponse.DescribeSQLLogReports_Item.DescribeSQLLogReports_LatencyTopNItem();
					latencyTopNItem.SQLText = _ctx.StringValue("DescribeSQLLogReports.Items["+ i +"].LatencyTopNItems["+ j +"].SQLText");
					latencyTopNItem.AvgLatency = _ctx.LongValue("DescribeSQLLogReports.Items["+ i +"].LatencyTopNItems["+ j +"].AvgLatency");
					latencyTopNItem.SQLExecuteTimes = _ctx.LongValue("DescribeSQLLogReports.Items["+ i +"].LatencyTopNItems["+ j +"].SQLExecuteTimes");

					item_latencyTopNItems.Add(latencyTopNItem);
				}
				item.LatencyTopNItems = item_latencyTopNItems;

				List<DescribeSQLLogReportsResponse.DescribeSQLLogReports_Item.DescribeSQLLogReports_QPSTopNItem> item_qPSTopNItems = new List<DescribeSQLLogReportsResponse.DescribeSQLLogReports_Item.DescribeSQLLogReports_QPSTopNItem>();
				for (int j = 0; j < _ctx.Length("DescribeSQLLogReports.Items["+ i +"].QPSTopNItems.Length"); j++) {
					DescribeSQLLogReportsResponse.DescribeSQLLogReports_Item.DescribeSQLLogReports_QPSTopNItem qPSTopNItem = new DescribeSQLLogReportsResponse.DescribeSQLLogReports_Item.DescribeSQLLogReports_QPSTopNItem();
					qPSTopNItem.SQLText = _ctx.StringValue("DescribeSQLLogReports.Items["+ i +"].QPSTopNItems["+ j +"].SQLText");
					qPSTopNItem.SQLExecuteTimes = _ctx.LongValue("DescribeSQLLogReports.Items["+ i +"].QPSTopNItems["+ j +"].SQLExecuteTimes");

					item_qPSTopNItems.Add(qPSTopNItem);
				}
				item.QPSTopNItems = item_qPSTopNItems;

				describeSQLLogReportsResponse_items.Add(item);
			}
			describeSQLLogReportsResponse.Items = describeSQLLogReportsResponse_items;
        
			return describeSQLLogReportsResponse;
        }
    }
}
