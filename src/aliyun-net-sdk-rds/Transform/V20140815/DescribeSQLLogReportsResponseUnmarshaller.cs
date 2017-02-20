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
using System.Collections.Generic;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeSQLLogReportsResponseUnmarshaller
    {
        public static DescribeSQLLogReportsResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeSQLLogReportsResponse describeSQLLogReportsResponse = new DescribeSQLLogReportsResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeSQLLogReports.RequestId"),
                TotalRecordCount = context.IntegerValue("DescribeSQLLogReports.TotalRecordCount"),
                PageNumber = context.IntegerValue("DescribeSQLLogReports.PageNumber"),
                PageRecordCount = context.IntegerValue("DescribeSQLLogReports.PageRecordCount")
            };
            List<DescribeSQLLogReportsResponse.Item> items = new List<DescribeSQLLogReportsResponse.Item>();
			for (int i = 0; i < context.Length("DescribeSQLLogReports.Items.Length"); i++) {
                DescribeSQLLogReportsResponse.Item item = new DescribeSQLLogReportsResponse.Item()
                {
                    ReportTime = context.StringValue($"DescribeSQLLogReports.Items[{i}].ReportTime")
                };
                List<DescribeSQLLogReportsResponse.Item.LatencyTopNItem> latencyTopNItems = new List<DescribeSQLLogReportsResponse.Item.LatencyTopNItem>();
				for (int j = 0; j < context.Length($"DescribeSQLLogReports.Items[{i}].LatencyTopNItems.Length"); j++) {
                    DescribeSQLLogReportsResponse.Item.LatencyTopNItem latencyTopNItem = new DescribeSQLLogReportsResponse.Item.LatencyTopNItem()
                    {
                        SQLText = context.StringValue($"DescribeSQLLogReports.Items[{i}].LatencyTopNItems[{j}].SQLText"),
                        AvgLatency = context.LongValue($"DescribeSQLLogReports.Items[{i}].LatencyTopNItems[{j}].AvgLatency"),
                        SQLExecuteTimes = context.LongValue($"DescribeSQLLogReports.Items[{i}].LatencyTopNItems[{j}].SQLExecuteTimes")
                    };
                    latencyTopNItems.Add(latencyTopNItem);
				}
				item.LatencyTopNItems = latencyTopNItems;

				List<DescribeSQLLogReportsResponse.Item.QpsTopNItem> qPsTopNItems = new List<DescribeSQLLogReportsResponse.Item.QpsTopNItem>();
				for (int j = 0; j < context.Length($"DescribeSQLLogReports.Items[{i}].QPSTopNItems.Length"); j++) {
                    DescribeSQLLogReportsResponse.Item.QpsTopNItem qPsTopNItem = new DescribeSQLLogReportsResponse.Item.QpsTopNItem()
                    {
                        SQLText = context.StringValue($"DescribeSQLLogReports.Items[{i}].QPSTopNItems[{j}].SQLText"),
                        SQLExecuteTimes = context.LongValue($"DescribeSQLLogReports.Items[{i}].QPSTopNItems[{j}].SQLExecuteTimes")
                    };
                    qPsTopNItems.Add(qPsTopNItem);
				}
				item.QpsTopNItems = qPsTopNItems;

				items.Add(item);
			}
			describeSQLLogReportsResponse.Items = items;
        
			return describeSQLLogReportsResponse;
        }
    }
}