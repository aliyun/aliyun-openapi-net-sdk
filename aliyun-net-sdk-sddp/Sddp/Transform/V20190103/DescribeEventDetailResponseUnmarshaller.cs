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
        public static DescribeEventDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeEventDetailResponse describeEventDetailResponse = new DescribeEventDetailResponse();

			describeEventDetailResponse.HttpResponse = _ctx.HttpResponse;
			describeEventDetailResponse.RequestId = _ctx.StringValue("DescribeEventDetail.RequestId");

			DescribeEventDetailResponse.DescribeEventDetail__Event _event = new DescribeEventDetailResponse.DescribeEventDetail__Event();
			_event.Id = _ctx.LongValue("DescribeEventDetail.Event.Id");
			_event.UserId = _ctx.LongValue("DescribeEventDetail.Event.UserId");
			_event.LoginName = _ctx.StringValue("DescribeEventDetail.Event.LoginName");
			_event.DisplayName = _ctx.StringValue("DescribeEventDetail.Event.DisplayName");
			_event.ProductCode = _ctx.StringValue("DescribeEventDetail.Event.ProductCode");
			_event.TypeCode = _ctx.StringValue("DescribeEventDetail.Event.TypeCode");
			_event.TypeName = _ctx.StringValue("DescribeEventDetail.Event.TypeName");
			_event.SubTypeCode = _ctx.StringValue("DescribeEventDetail.Event.SubTypeCode");
			_event.SubTypeName = _ctx.StringValue("DescribeEventDetail.Event.SubTypeName");
			_event.AlertTime = _ctx.LongValue("DescribeEventDetail.Event.AlertTime");
			_event.DataInstance = _ctx.StringValue("DescribeEventDetail.Event.DataInstance");
			_event.EventTime = _ctx.LongValue("DescribeEventDetail.Event.EventTime");
			_event.Status = _ctx.IntegerValue("DescribeEventDetail.Event.Status");
			_event.StatusName = _ctx.StringValue("DescribeEventDetail.Event.StatusName");
			_event.DealUserId = _ctx.LongValue("DescribeEventDetail.Event.DealUserId");
			_event.DealLoginName = _ctx.StringValue("DescribeEventDetail.Event.DealLoginName");
			_event.DealDisplayName = _ctx.StringValue("DescribeEventDetail.Event.DealDisplayName");
			_event.DealTime = _ctx.LongValue("DescribeEventDetail.Event.DealTime");
			_event.DepartName = _ctx.StringValue("DescribeEventDetail.Event.DepartName");
			_event.Backed = _ctx.BooleanValue("DescribeEventDetail.Event.Backed");
			_event.DealReason = _ctx.StringValue("DescribeEventDetail.Event.DealReason");
			_event.UserIdValue = _ctx.StringValue("DescribeEventDetail.Event.UserIdValue");
			_event.DealUserIdValue = _ctx.StringValue("DescribeEventDetail.Event.dealUserIdValue");
			_event.LogDetail = _ctx.StringValue("DescribeEventDetail.Event.LogDetail");

			DescribeEventDetailResponse.DescribeEventDetail__Event.DescribeEventDetail_Detail detail = new DescribeEventDetailResponse.DescribeEventDetail__Event.DescribeEventDetail_Detail();

			List<DescribeEventDetailResponse.DescribeEventDetail__Event.DescribeEventDetail_Detail.DescribeEventDetail_ContentItem> detail_content = new List<DescribeEventDetailResponse.DescribeEventDetail__Event.DescribeEventDetail_Detail.DescribeEventDetail_ContentItem>();
			for (int i = 0; i < _ctx.Length("DescribeEventDetail.Event.Detail.Content.Length"); i++) {
				DescribeEventDetailResponse.DescribeEventDetail__Event.DescribeEventDetail_Detail.DescribeEventDetail_ContentItem contentItem = new DescribeEventDetailResponse.DescribeEventDetail__Event.DescribeEventDetail_Detail.DescribeEventDetail_ContentItem();
				contentItem.Label = _ctx.StringValue("DescribeEventDetail.Event.Detail.Content["+ i +"].Label");
				contentItem._Value = _ctx.StringValue("DescribeEventDetail.Event.Detail.Content["+ i +"].Value");

				detail_content.Add(contentItem);
			}
			detail.Content = detail_content;

			List<DescribeEventDetailResponse.DescribeEventDetail__Event.DescribeEventDetail_Detail.DescribeEventDetail_ChartItem> detail_chart = new List<DescribeEventDetailResponse.DescribeEventDetail__Event.DescribeEventDetail_Detail.DescribeEventDetail_ChartItem>();
			for (int i = 0; i < _ctx.Length("DescribeEventDetail.Event.Detail.Chart.Length"); i++) {
				DescribeEventDetailResponse.DescribeEventDetail__Event.DescribeEventDetail_Detail.DescribeEventDetail_ChartItem chartItem = new DescribeEventDetailResponse.DescribeEventDetail__Event.DescribeEventDetail_Detail.DescribeEventDetail_ChartItem();
				chartItem.Label = _ctx.StringValue("DescribeEventDetail.Event.Detail.Chart["+ i +"].Label");
				chartItem.XLabel = _ctx.StringValue("DescribeEventDetail.Event.Detail.Chart["+ i +"].XLabel");
				chartItem.YLabel = _ctx.StringValue("DescribeEventDetail.Event.Detail.Chart["+ i +"].YLabel");
				chartItem.Type = _ctx.StringValue("DescribeEventDetail.Event.Detail.Chart["+ i +"].Type");

				DescribeEventDetailResponse.DescribeEventDetail__Event.DescribeEventDetail_Detail.DescribeEventDetail_ChartItem.DescribeEventDetail_Data data = new DescribeEventDetailResponse.DescribeEventDetail__Event.DescribeEventDetail_Detail.DescribeEventDetail_ChartItem.DescribeEventDetail_Data();
				data.X = _ctx.StringValue("DescribeEventDetail.Event.Detail.Chart["+ i +"].Data.X");
				data.Y = _ctx.StringValue("DescribeEventDetail.Event.Detail.Chart["+ i +"].Data.Y");
				chartItem.Data = data;

				detail_chart.Add(chartItem);
			}
			detail.Chart = detail_chart;

			List<DescribeEventDetailResponse.DescribeEventDetail__Event.DescribeEventDetail_Detail.DescribeEventDetail_ResourceInfoItem> detail_resourceInfo = new List<DescribeEventDetailResponse.DescribeEventDetail__Event.DescribeEventDetail_Detail.DescribeEventDetail_ResourceInfoItem>();
			for (int i = 0; i < _ctx.Length("DescribeEventDetail.Event.Detail.ResourceInfo.Length"); i++) {
				DescribeEventDetailResponse.DescribeEventDetail__Event.DescribeEventDetail_Detail.DescribeEventDetail_ResourceInfoItem resourceInfoItem = new DescribeEventDetailResponse.DescribeEventDetail__Event.DescribeEventDetail_Detail.DescribeEventDetail_ResourceInfoItem();
				resourceInfoItem.Label = _ctx.StringValue("DescribeEventDetail.Event.Detail.ResourceInfo["+ i +"].Label");
				resourceInfoItem._Value = _ctx.StringValue("DescribeEventDetail.Event.Detail.ResourceInfo["+ i +"].Value");

				detail_resourceInfo.Add(resourceInfoItem);
			}
			detail.ResourceInfo = detail_resourceInfo;
			_event.Detail = detail;

			List<DescribeEventDetailResponse.DescribeEventDetail__Event.DescribeEventDetail_HandleInfo> _event_handleInfoList = new List<DescribeEventDetailResponse.DescribeEventDetail__Event.DescribeEventDetail_HandleInfo>();
			for (int i = 0; i < _ctx.Length("DescribeEventDetail.Event.HandleInfoList.Length"); i++) {
				DescribeEventDetailResponse.DescribeEventDetail__Event.DescribeEventDetail_HandleInfo handleInfo = new DescribeEventDetailResponse.DescribeEventDetail__Event.DescribeEventDetail_HandleInfo();
				handleInfo.HandlerType = _ctx.StringValue("DescribeEventDetail.Event.HandleInfoList["+ i +"].HandlerType");
				handleInfo.HandlerName = _ctx.StringValue("DescribeEventDetail.Event.HandleInfoList["+ i +"].HandlerName");
				handleInfo.HandlerValue = _ctx.IntegerValue("DescribeEventDetail.Event.HandleInfoList["+ i +"].HandlerValue");
				handleInfo.CurrentValue = _ctx.StringValue("DescribeEventDetail.Event.HandleInfoList["+ i +"].CurrentValue");
				handleInfo.DisableTime = _ctx.LongValue("DescribeEventDetail.Event.HandleInfoList["+ i +"].DisableTime");
				handleInfo.EnableTime = _ctx.LongValue("DescribeEventDetail.Event.HandleInfoList["+ i +"].EnableTime");
				handleInfo.Status = _ctx.IntegerValue("DescribeEventDetail.Event.HandleInfoList["+ i +"].Status");
				handleInfo.Id = _ctx.LongValue("DescribeEventDetail.Event.HandleInfoList["+ i +"].Id");

				_event_handleInfoList.Add(handleInfo);
			}
			_event.HandleInfoList = _event_handleInfoList;
			describeEventDetailResponse._Event = _event;
        
			return describeEventDetailResponse;
        }
    }
}
