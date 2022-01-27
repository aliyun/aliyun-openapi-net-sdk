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
using Aliyun.Acs.gpdb.Model.V20160503;

namespace Aliyun.Acs.gpdb.Transform.V20160503
{
    public class DescribeSQLLogCountResponseUnmarshaller
    {
        public static DescribeSQLLogCountResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSQLLogCountResponse describeSQLLogCountResponse = new DescribeSQLLogCountResponse();

			describeSQLLogCountResponse.HttpResponse = _ctx.HttpResponse;
			describeSQLLogCountResponse.EndTime = _ctx.StringValue("DescribeSQLLogCount.EndTime");
			describeSQLLogCountResponse.RequestId = _ctx.StringValue("DescribeSQLLogCount.RequestId");
			describeSQLLogCountResponse.StartTime = _ctx.StringValue("DescribeSQLLogCount.StartTime");
			describeSQLLogCountResponse.DBClusterId = _ctx.StringValue("DescribeSQLLogCount.DBClusterId");

			List<DescribeSQLLogCountResponse.DescribeSQLLogCount_Item> describeSQLLogCountResponse_items = new List<DescribeSQLLogCountResponse.DescribeSQLLogCount_Item>();
			for (int i = 0; i < _ctx.Length("DescribeSQLLogCount.Items.Length"); i++) {
				DescribeSQLLogCountResponse.DescribeSQLLogCount_Item item = new DescribeSQLLogCountResponse.DescribeSQLLogCount_Item();
				item.Name = _ctx.StringValue("DescribeSQLLogCount.Items["+ i +"].Name");

				List<DescribeSQLLogCountResponse.DescribeSQLLogCount_Item.DescribeSQLLogCount_SeriesItem> item_series = new List<DescribeSQLLogCountResponse.DescribeSQLLogCount_Item.DescribeSQLLogCount_SeriesItem>();
				for (int j = 0; j < _ctx.Length("DescribeSQLLogCount.Items["+ i +"].Series.Length"); j++) {
					DescribeSQLLogCountResponse.DescribeSQLLogCount_Item.DescribeSQLLogCount_SeriesItem seriesItem = new DescribeSQLLogCountResponse.DescribeSQLLogCount_Item.DescribeSQLLogCount_SeriesItem();

					List<DescribeSQLLogCountResponse.DescribeSQLLogCount_Item.DescribeSQLLogCount_SeriesItem.DescribeSQLLogCount_ValueItem> seriesItem_values = new List<DescribeSQLLogCountResponse.DescribeSQLLogCount_Item.DescribeSQLLogCount_SeriesItem.DescribeSQLLogCount_ValueItem>();
					for (int k = 0; k < _ctx.Length("DescribeSQLLogCount.Items["+ i +"].Series["+ j +"].Values.Length"); k++) {
						DescribeSQLLogCountResponse.DescribeSQLLogCount_Item.DescribeSQLLogCount_SeriesItem.DescribeSQLLogCount_ValueItem valueItem = new DescribeSQLLogCountResponse.DescribeSQLLogCount_Item.DescribeSQLLogCount_SeriesItem.DescribeSQLLogCount_ValueItem();

						List<string> valueItem_point = new List<string>();
						for (int l = 0; l < _ctx.Length("DescribeSQLLogCount.Items["+ i +"].Series["+ j +"].Values["+ k +"].Point.Length"); l++) {
							valueItem_point.Add(_ctx.StringValue("DescribeSQLLogCount.Items["+ i +"].Series["+ j +"].Values["+ k +"].Point["+ l +"]"));
						}
						valueItem.Point = valueItem_point;

						seriesItem_values.Add(valueItem);
					}
					seriesItem.Values = seriesItem_values;

					item_series.Add(seriesItem);
				}
				item.Series = item_series;

				describeSQLLogCountResponse_items.Add(item);
			}
			describeSQLLogCountResponse.Items = describeSQLLogCountResponse_items;
        
			return describeSQLLogCountResponse;
        }
    }
}
