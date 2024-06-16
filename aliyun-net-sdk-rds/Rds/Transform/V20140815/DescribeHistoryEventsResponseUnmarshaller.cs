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
    public class DescribeHistoryEventsResponseUnmarshaller
    {
        public static DescribeHistoryEventsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeHistoryEventsResponse describeHistoryEventsResponse = new DescribeHistoryEventsResponse();

			describeHistoryEventsResponse.HttpResponse = _ctx.HttpResponse;
			describeHistoryEventsResponse.PageNumber = _ctx.IntegerValue("DescribeHistoryEvents.PageNumber");
			describeHistoryEventsResponse.RequestId = _ctx.StringValue("DescribeHistoryEvents.RequestId");
			describeHistoryEventsResponse.PageSize = _ctx.IntegerValue("DescribeHistoryEvents.PageSize");
			describeHistoryEventsResponse.TotalCount = _ctx.IntegerValue("DescribeHistoryEvents.TotalCount");

			List<DescribeHistoryEventsResponse.DescribeHistoryEvents_ItemsItem> describeHistoryEventsResponse_items = new List<DescribeHistoryEventsResponse.DescribeHistoryEvents_ItemsItem>();
			for (int i = 0; i < _ctx.Length("DescribeHistoryEvents.Items.Length"); i++) {
				DescribeHistoryEventsResponse.DescribeHistoryEvents_ItemsItem itemsItem = new DescribeHistoryEventsResponse.DescribeHistoryEvents_ItemsItem();
				itemsItem.Id = _ctx.StringValue("DescribeHistoryEvents.Items["+ i +"].Id");
				itemsItem.Region = _ctx.StringValue("DescribeHistoryEvents.Items["+ i +"].Region");
				itemsItem.Source = _ctx.StringValue("DescribeHistoryEvents.Items["+ i +"].Source");
				itemsItem.Specversion = _ctx.StringValue("DescribeHistoryEvents.Items["+ i +"].Specversion");
				itemsItem.Subject = _ctx.StringValue("DescribeHistoryEvents.Items["+ i +"].Subject");
				itemsItem.Time = _ctx.StringValue("DescribeHistoryEvents.Items["+ i +"].Time");
				itemsItem.Type = _ctx.StringValue("DescribeHistoryEvents.Items["+ i +"].Type");

				DescribeHistoryEventsResponse.DescribeHistoryEvents_ItemsItem.DescribeHistoryEvents_Data data = new DescribeHistoryEventsResponse.DescribeHistoryEvents_ItemsItem.DescribeHistoryEvents_Data();
				data.EventType = _ctx.StringValue("DescribeHistoryEvents.Items["+ i +"].Data.EventType");
				data.EventId = _ctx.StringValue("DescribeHistoryEvents.Items["+ i +"].Data.EventId");
				data.CmsProduct = _ctx.StringValue("DescribeHistoryEvents.Items["+ i +"].Data.CmsProduct");
				data.DbType = _ctx.StringValue("DescribeHistoryEvents.Items["+ i +"].Data.DbType");
				data.DetailImpact = _ctx.StringValue("DescribeHistoryEvents.Items["+ i +"].Data.DetailImpact");
				data.DetailReason = _ctx.StringValue("DescribeHistoryEvents.Items["+ i +"].Data.DetailReason");
				data.EndTime = _ctx.StringValue("DescribeHistoryEvents.Items["+ i +"].Data.EndTime");
				data.EventCategory = _ctx.StringValue("DescribeHistoryEvents.Items["+ i +"].Data.EventCategory");
				data.EventCode = _ctx.StringValue("DescribeHistoryEvents.Items["+ i +"].Data.EventCode");
				data.EventDetail = _ctx.StringValue("DescribeHistoryEvents.Items["+ i +"].Data.EventDetail");
				data.EventImpact = _ctx.StringValue("DescribeHistoryEvents.Items["+ i +"].Data.EventImpact");
				data.EventLevel = _ctx.StringValue("DescribeHistoryEvents.Items["+ i +"].Data.EventLevel");
				data.EventReason = _ctx.StringValue("DescribeHistoryEvents.Items["+ i +"].Data.EventReason");
				data.EventStatus = _ctx.StringValue("DescribeHistoryEvents.Items["+ i +"].Data.EventStatus");
				data.GmtCreated = _ctx.StringValue("DescribeHistoryEvents.Items["+ i +"].Data.GmtCreated");
				data.GmtModified = _ctx.StringValue("DescribeHistoryEvents.Items["+ i +"].Data.GmtModified");
				data.HandleStatus = _ctx.StringValue("DescribeHistoryEvents.Items["+ i +"].Data.HandleStatus");
				data.HasLifeCycle = _ctx.IntegerValue("DescribeHistoryEvents.Items["+ i +"].Data.HasLifeCycle");
				data.InstanceId = _ctx.StringValue("DescribeHistoryEvents.Items["+ i +"].Data.InstanceId");
				data.InstanceName = _ctx.StringValue("DescribeHistoryEvents.Items["+ i +"].Data.InstanceName");
				data.IsClosed = _ctx.IntegerValue("DescribeHistoryEvents.Items["+ i +"].Data.IsClosed");
				data.Product = _ctx.StringValue("DescribeHistoryEvents.Items["+ i +"].Data.Product");
				data.RegionId = _ctx.StringValue("DescribeHistoryEvents.Items["+ i +"].Data.RegionId");
				data.ResourceType = _ctx.StringValue("DescribeHistoryEvents.Items["+ i +"].Data.ResourceType");
				data.SourceType = _ctx.StringValue("DescribeHistoryEvents.Items["+ i +"].Data.SourceType");
				data.StartTime = _ctx.StringValue("DescribeHistoryEvents.Items["+ i +"].Data.StartTime");
				data.Uid = _ctx.StringValue("DescribeHistoryEvents.Items["+ i +"].Data.Uid");
				itemsItem.Data = data;

				describeHistoryEventsResponse_items.Add(itemsItem);
			}
			describeHistoryEventsResponse.Items = describeHistoryEventsResponse_items;
        
			return describeHistoryEventsResponse;
        }
    }
}
