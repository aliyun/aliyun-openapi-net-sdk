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
using Aliyun.Acs.Sddp.Model.V20190103;

namespace Aliyun.Acs.Sddp.Transform.V20190103
{
    public class DescribeEventDetailResponseUnmarshaller
    {
        public static DescribeEventDetailResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeEventDetailResponse describeEventDetailResponse = new DescribeEventDetailResponse();

			describeEventDetailResponse.HttpResponse = context.HttpResponse;
			describeEventDetailResponse.RequestId = context.StringValue("DescribeEventDetail.RequestId");

			DescribeEventDetailResponse.DescribeEventDetail__Event _event = new DescribeEventDetailResponse.DescribeEventDetail__Event();
			_event.Id = context.LongValue("DescribeEventDetail.Event.Id");
			_event.UserId = context.LongValue("DescribeEventDetail.Event.UserId");
			_event.LoginName = context.StringValue("DescribeEventDetail.Event.LoginName");
			_event.DisplayName = context.StringValue("DescribeEventDetail.Event.DisplayName");
			_event.ProductCode = context.StringValue("DescribeEventDetail.Event.ProductCode");
			_event.TypeCode = context.StringValue("DescribeEventDetail.Event.TypeCode");
			_event.TypeName = context.StringValue("DescribeEventDetail.Event.TypeName");
			_event.SubTypeCode = context.StringValue("DescribeEventDetail.Event.SubTypeCode");
			_event.SubTypeName = context.StringValue("DescribeEventDetail.Event.SubTypeName");
			_event.AlertTime = context.LongValue("DescribeEventDetail.Event.AlertTime");
			_event.DataInstance = context.StringValue("DescribeEventDetail.Event.DataInstance");
			_event.EventTime = context.LongValue("DescribeEventDetail.Event.EventTime");
			_event.Status = context.IntegerValue("DescribeEventDetail.Event.Status");
			_event.StatusName = context.StringValue("DescribeEventDetail.Event.StatusName");
			_event.DealUserId = context.LongValue("DescribeEventDetail.Event.DealUserId");
			_event.DealLoginName = context.StringValue("DescribeEventDetail.Event.DealLoginName");
			_event.DealDisplayName = context.StringValue("DescribeEventDetail.Event.DealDisplayName");
			_event.DealTime = context.LongValue("DescribeEventDetail.Event.DealTime");
			_event.DepartName = context.StringValue("DescribeEventDetail.Event.DepartName");
			_event.Backed = context.BooleanValue("DescribeEventDetail.Event.Backed");
			_event.DealReason = context.StringValue("DescribeEventDetail.Event.DealReason");

			DescribeEventDetailResponse.DescribeEventDetail__Event.DescribeEventDetail_Detail detail = new DescribeEventDetailResponse.DescribeEventDetail__Event.DescribeEventDetail_Detail();

			List<DescribeEventDetailResponse.DescribeEventDetail__Event.DescribeEventDetail_Detail.DescribeEventDetail_ContentItem> detail_content = new List<DescribeEventDetailResponse.DescribeEventDetail__Event.DescribeEventDetail_Detail.DescribeEventDetail_ContentItem>();
			for (int i = 0; i < context.Length("DescribeEventDetail.Event.Detail.Content.Length"); i++) {
				DescribeEventDetailResponse.DescribeEventDetail__Event.DescribeEventDetail_Detail.DescribeEventDetail_ContentItem contentItem = new DescribeEventDetailResponse.DescribeEventDetail__Event.DescribeEventDetail_Detail.DescribeEventDetail_ContentItem();
				contentItem.Label = context.StringValue("DescribeEventDetail.Event.Detail.Content["+ i +"].Label");
				contentItem._Value = context.StringValue("DescribeEventDetail.Event.Detail.Content["+ i +"].Value");

				detail_content.Add(contentItem);
			}
			detail.Content = detail_content;

			List<DescribeEventDetailResponse.DescribeEventDetail__Event.DescribeEventDetail_Detail.DescribeEventDetail_ChartItem> detail_chart = new List<DescribeEventDetailResponse.DescribeEventDetail__Event.DescribeEventDetail_Detail.DescribeEventDetail_ChartItem>();
			for (int i = 0; i < context.Length("DescribeEventDetail.Event.Detail.Chart.Length"); i++) {
				DescribeEventDetailResponse.DescribeEventDetail__Event.DescribeEventDetail_Detail.DescribeEventDetail_ChartItem chartItem = new DescribeEventDetailResponse.DescribeEventDetail__Event.DescribeEventDetail_Detail.DescribeEventDetail_ChartItem();
				chartItem.Label = context.StringValue("DescribeEventDetail.Event.Detail.Chart["+ i +"].Label");
				chartItem.XLabel = context.StringValue("DescribeEventDetail.Event.Detail.Chart["+ i +"].XLabel");
				chartItem.YLabel = context.StringValue("DescribeEventDetail.Event.Detail.Chart["+ i +"].YLabel");
				chartItem.Type = context.StringValue("DescribeEventDetail.Event.Detail.Chart["+ i +"].Type");

				DescribeEventDetailResponse.DescribeEventDetail__Event.DescribeEventDetail_Detail.DescribeEventDetail_ChartItem.DescribeEventDetail_Data data = new DescribeEventDetailResponse.DescribeEventDetail__Event.DescribeEventDetail_Detail.DescribeEventDetail_ChartItem.DescribeEventDetail_Data();
				data.X = context.StringValue("DescribeEventDetail.Event.Detail.Chart["+ i +"].Data.X");
				data.Y = context.StringValue("DescribeEventDetail.Event.Detail.Chart["+ i +"].Data.Y");
				chartItem.Data = data;

				detail_chart.Add(chartItem);
			}
			detail.Chart = detail_chart;

			List<DescribeEventDetailResponse.DescribeEventDetail__Event.DescribeEventDetail_Detail.DescribeEventDetail_ResourceInfoItem> detail_resourceInfo = new List<DescribeEventDetailResponse.DescribeEventDetail__Event.DescribeEventDetail_Detail.DescribeEventDetail_ResourceInfoItem>();
			for (int i = 0; i < context.Length("DescribeEventDetail.Event.Detail.ResourceInfo.Length"); i++) {
				DescribeEventDetailResponse.DescribeEventDetail__Event.DescribeEventDetail_Detail.DescribeEventDetail_ResourceInfoItem resourceInfoItem = new DescribeEventDetailResponse.DescribeEventDetail__Event.DescribeEventDetail_Detail.DescribeEventDetail_ResourceInfoItem();
				resourceInfoItem.Label = context.StringValue("DescribeEventDetail.Event.Detail.ResourceInfo["+ i +"].Label");
				resourceInfoItem._Value = context.StringValue("DescribeEventDetail.Event.Detail.ResourceInfo["+ i +"].Value");

				detail_resourceInfo.Add(resourceInfoItem);
			}
			detail.ResourceInfo = detail_resourceInfo;
			_event.Detail = detail;
			describeEventDetailResponse._Event = _event;
        
			return describeEventDetailResponse;
        }
    }
}
