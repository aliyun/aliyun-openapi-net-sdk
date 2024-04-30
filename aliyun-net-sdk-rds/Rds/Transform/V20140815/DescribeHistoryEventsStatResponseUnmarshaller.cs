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
    public class DescribeHistoryEventsStatResponseUnmarshaller
    {
        public static DescribeHistoryEventsStatResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeHistoryEventsStatResponse describeHistoryEventsStatResponse = new DescribeHistoryEventsStatResponse();

			describeHistoryEventsStatResponse.HttpResponse = _ctx.HttpResponse;
			describeHistoryEventsStatResponse.RequestId = _ctx.StringValue("DescribeHistoryEventsStat.RequestId");

			List<DescribeHistoryEventsStatResponse.DescribeHistoryEventsStat_ItemsItem> describeHistoryEventsStatResponse_items = new List<DescribeHistoryEventsStatResponse.DescribeHistoryEventsStat_ItemsItem>();
			for (int i = 0; i < _ctx.Length("DescribeHistoryEventsStat.Items.Length"); i++) {
				DescribeHistoryEventsStatResponse.DescribeHistoryEventsStat_ItemsItem itemsItem = new DescribeHistoryEventsStatResponse.DescribeHistoryEventsStat_ItemsItem();
				itemsItem.EventCategory = _ctx.StringValue("DescribeHistoryEventsStat.Items["+ i +"].EventCategory");
				itemsItem.TotalCount = _ctx.IntegerValue("DescribeHistoryEventsStat.Items["+ i +"].TotalCount");

				describeHistoryEventsStatResponse_items.Add(itemsItem);
			}
			describeHistoryEventsStatResponse.Items = describeHistoryEventsStatResponse_items;
        
			return describeHistoryEventsStatResponse;
        }
    }
}
