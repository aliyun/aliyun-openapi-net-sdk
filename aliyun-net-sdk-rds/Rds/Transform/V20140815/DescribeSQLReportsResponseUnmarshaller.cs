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
    public class DescribeSQLReportsResponseUnmarshaller
    {
        public static DescribeSQLReportsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSQLReportsResponse describeSQLReportsResponse = new DescribeSQLReportsResponse();

			describeSQLReportsResponse.HttpResponse = _ctx.HttpResponse;
			describeSQLReportsResponse.RequestId = _ctx.StringValue("DescribeSQLReports.RequestId");
			describeSQLReportsResponse.TotalRecordCount = _ctx.IntegerValue("DescribeSQLReports.TotalRecordCount");
			describeSQLReportsResponse.PageNumber = _ctx.IntegerValue("DescribeSQLReports.PageNumber");
			describeSQLReportsResponse.PageRecordCount = _ctx.IntegerValue("DescribeSQLReports.PageRecordCount");

			List<DescribeSQLReportsResponse.DescribeSQLReports_Item> describeSQLReportsResponse_items = new List<DescribeSQLReportsResponse.DescribeSQLReports_Item>();
			for (int i = 0; i < _ctx.Length("DescribeSQLReports.Items.Length"); i++) {
				DescribeSQLReportsResponse.DescribeSQLReports_Item item = new DescribeSQLReportsResponse.DescribeSQLReports_Item();
				item.ReportTime = _ctx.StringValue("DescribeSQLReports.Items["+ i +"].ReportTime");

				List<DescribeSQLReportsResponse.DescribeSQLReports_Item.DescribeSQLReports_LatencyTopNItem> item_latencyTopNItems = new List<DescribeSQLReportsResponse.DescribeSQLReports_Item.DescribeSQLReports_LatencyTopNItem>();
				for (int j = 0; j < _ctx.Length("DescribeSQLReports.Items["+ i +"].LatencyTopNItems.Length"); j++) {
					DescribeSQLReportsResponse.DescribeSQLReports_Item.DescribeSQLReports_LatencyTopNItem latencyTopNItem = new DescribeSQLReportsResponse.DescribeSQLReports_Item.DescribeSQLReports_LatencyTopNItem();
					latencyTopNItem.SQLText = _ctx.StringValue("DescribeSQLReports.Items["+ i +"].LatencyTopNItems["+ j +"].SQLText");
					latencyTopNItem.AvgLatency = _ctx.LongValue("DescribeSQLReports.Items["+ i +"].LatencyTopNItems["+ j +"].AvgLatency");
					latencyTopNItem.SQLExecuteTimes = _ctx.LongValue("DescribeSQLReports.Items["+ i +"].LatencyTopNItems["+ j +"].SQLExecuteTimes");

					item_latencyTopNItems.Add(latencyTopNItem);
				}
				item.LatencyTopNItems = item_latencyTopNItems;

				List<DescribeSQLReportsResponse.DescribeSQLReports_Item.DescribeSQLReports_QPSTopNItem> item_qPSTopNItems = new List<DescribeSQLReportsResponse.DescribeSQLReports_Item.DescribeSQLReports_QPSTopNItem>();
				for (int j = 0; j < _ctx.Length("DescribeSQLReports.Items["+ i +"].QPSTopNItems.Length"); j++) {
					DescribeSQLReportsResponse.DescribeSQLReports_Item.DescribeSQLReports_QPSTopNItem qPSTopNItem = new DescribeSQLReportsResponse.DescribeSQLReports_Item.DescribeSQLReports_QPSTopNItem();
					qPSTopNItem.SQLText = _ctx.StringValue("DescribeSQLReports.Items["+ i +"].QPSTopNItems["+ j +"].SQLText");
					qPSTopNItem.SQLExecuteTimes = _ctx.LongValue("DescribeSQLReports.Items["+ i +"].QPSTopNItems["+ j +"].SQLExecuteTimes");

					item_qPSTopNItems.Add(qPSTopNItem);
				}
				item.QPSTopNItems = item_qPSTopNItems;

				describeSQLReportsResponse_items.Add(item);
			}
			describeSQLReportsResponse.Items = describeSQLReportsResponse_items;
        
			return describeSQLReportsResponse;
        }
    }
}
