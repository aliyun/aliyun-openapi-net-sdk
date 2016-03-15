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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Rds.Model.V20140815;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeSQLReportsResponseUnmarshaller
    {
        public static DescribeSQLReportsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSQLReportsResponse describeSQLReportsResponse = new DescribeSQLReportsResponse();

			describeSQLReportsResponse.HttpResponse = context.HttpResponse;
			describeSQLReportsResponse.RequestId = context.StringValue("DescribeSQLReports.RequestId");
			describeSQLReportsResponse.TotalRecordCount = context.IntegerValue("DescribeSQLReports.TotalRecordCount");
			describeSQLReportsResponse.PageNumber = context.IntegerValue("DescribeSQLReports.PageNumber");
			describeSQLReportsResponse.PageRecordCount = context.IntegerValue("DescribeSQLReports.PageRecordCount");

			List<DescribeSQLReportsResponse.Item> items = new List<DescribeSQLReportsResponse.Item>();
			for (int i = 0; i < context.Length("DescribeSQLReports.Items.Length"); i++) {
				DescribeSQLReportsResponse.Item item = new DescribeSQLReportsResponse.Item();
				item.ReportTime = context.StringValue("DescribeSQLReports.Items["+ i +"].ReportTime");

				List<DescribeSQLReportsResponse.Item.LatencyTopNItem> latencyTopNItems = new List<DescribeSQLReportsResponse.Item.LatencyTopNItem>();
				for (int j = 0; j < context.Length("DescribeSQLReports.Items["+ i +"].LatencyTopNItems.Length"); j++) {
					DescribeSQLReportsResponse.Item.LatencyTopNItem latencyTopNItem = new DescribeSQLReportsResponse.Item.LatencyTopNItem();
					latencyTopNItem.SQLText = context.StringValue("DescribeSQLReports.Items["+ i +"].LatencyTopNItems["+ j +"].SQLText");
					latencyTopNItem.AvgLatency = context.LongValue("DescribeSQLReports.Items["+ i +"].LatencyTopNItems["+ j +"].AvgLatency");
					latencyTopNItem.SQLExecuteTimes = context.LongValue("DescribeSQLReports.Items["+ i +"].LatencyTopNItems["+ j +"].SQLExecuteTimes");

					latencyTopNItems.Add(latencyTopNItem);
				}
				item.LatencyTopNItems = latencyTopNItems;

				List<DescribeSQLReportsResponse.Item.QPSTopNItem> qPSTopNItems = new List<DescribeSQLReportsResponse.Item.QPSTopNItem>();
				for (int j = 0; j < context.Length("DescribeSQLReports.Items["+ i +"].QPSTopNItems.Length"); j++) {
					DescribeSQLReportsResponse.Item.QPSTopNItem qPSTopNItem = new DescribeSQLReportsResponse.Item.QPSTopNItem();
					qPSTopNItem.SQLText = context.StringValue("DescribeSQLReports.Items["+ i +"].QPSTopNItems["+ j +"].SQLText");
					qPSTopNItem.SQLExecuteTimes = context.LongValue("DescribeSQLReports.Items["+ i +"].QPSTopNItems["+ j +"].SQLExecuteTimes");

					qPSTopNItems.Add(qPSTopNItem);
				}
				item.QPSTopNItems = qPSTopNItems;

				items.Add(item);
			}
			describeSQLReportsResponse.Items = items;
        
			return describeSQLReportsResponse;
        }
    }
}