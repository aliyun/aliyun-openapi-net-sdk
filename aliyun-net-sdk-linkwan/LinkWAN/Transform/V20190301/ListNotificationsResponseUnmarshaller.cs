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
using Aliyun.Acs.LinkWAN.Model.V20190301;

namespace Aliyun.Acs.LinkWAN.Transform.V20190301
{
    public class ListNotificationsResponseUnmarshaller
    {
        public static ListNotificationsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListNotificationsResponse listNotificationsResponse = new ListNotificationsResponse();

			listNotificationsResponse.HttpResponse = _ctx.HttpResponse;
			listNotificationsResponse.RequestId = _ctx.StringValue("ListNotifications.RequestId");
			listNotificationsResponse.Success = _ctx.BooleanValue("ListNotifications.Success");

			ListNotificationsResponse.ListNotifications_Data data = new ListNotificationsResponse.ListNotifications_Data();
			data.TotalCount = _ctx.LongValue("ListNotifications.Data.TotalCount");

			List<ListNotificationsResponse.ListNotifications_Data.ListNotifications_Notification> data_list = new List<ListNotificationsResponse.ListNotifications_Data.ListNotifications_Notification>();
			for (int i = 0; i < _ctx.Length("ListNotifications.Data.List.Length"); i++) {
				ListNotificationsResponse.ListNotifications_Data.ListNotifications_Notification notification = new ListNotificationsResponse.ListNotifications_Data.ListNotifications_Notification();
				notification.NotificationId = _ctx.StringValue("ListNotifications.Data.List["+ i +"].NotificationId");
				notification.Category = _ctx.StringValue("ListNotifications.Data.List["+ i +"].Category");
				notification.HandleState = _ctx.StringValue("ListNotifications.Data.List["+ i +"].HandleState");
				notification.NoticeMillis = _ctx.LongValue("ListNotifications.Data.List["+ i +"].NoticeMillis");
				notification.HandledMillis = _ctx.LongValue("ListNotifications.Data.List["+ i +"].HandledMillis");

				ListNotificationsResponse.ListNotifications_Data.ListNotifications_Notification.ListNotifications_GatewayOfflineInfo gatewayOfflineInfo = new ListNotificationsResponse.ListNotifications_Data.ListNotifications_Notification.ListNotifications_GatewayOfflineInfo();
				gatewayOfflineInfo.GwEui = _ctx.StringValue("ListNotifications.Data.List["+ i +"].GatewayOfflineInfo.GwEui");
				gatewayOfflineInfo.OfflineMillis = _ctx.LongValue("ListNotifications.Data.List["+ i +"].GatewayOfflineInfo.OfflineMillis");
				notification.GatewayOfflineInfo = gatewayOfflineInfo;

				ListNotificationsResponse.ListNotifications_Data.ListNotifications_Notification.ListNotifications_JoinPermissionAuthInfo joinPermissionAuthInfo = new ListNotificationsResponse.ListNotifications_Data.ListNotifications_Notification.ListNotifications_JoinPermissionAuthInfo();
				joinPermissionAuthInfo.OrderId = _ctx.StringValue("ListNotifications.Data.List["+ i +"].JoinPermissionAuthInfo.OrderId");
				joinPermissionAuthInfo.JoinPermissionId = _ctx.StringValue("ListNotifications.Data.List["+ i +"].JoinPermissionAuthInfo.JoinPermissionId");
				joinPermissionAuthInfo.OwnerAliyunId = _ctx.StringValue("ListNotifications.Data.List["+ i +"].JoinPermissionAuthInfo.OwnerAliyunId");
				joinPermissionAuthInfo.RenterAliyunId = _ctx.StringValue("ListNotifications.Data.List["+ i +"].JoinPermissionAuthInfo.RenterAliyunId");
				joinPermissionAuthInfo.OrderState = _ctx.StringValue("ListNotifications.Data.List["+ i +"].JoinPermissionAuthInfo.OrderState");
				joinPermissionAuthInfo.ApplyingMillis = _ctx.LongValue("ListNotifications.Data.List["+ i +"].JoinPermissionAuthInfo.ApplyingMillis");
				joinPermissionAuthInfo.AcceptedMillis = _ctx.LongValue("ListNotifications.Data.List["+ i +"].JoinPermissionAuthInfo.AcceptedMillis");
				joinPermissionAuthInfo.CanceledMillis = _ctx.LongValue("ListNotifications.Data.List["+ i +"].JoinPermissionAuthInfo.CanceledMillis");
				joinPermissionAuthInfo.RejectedMillis = _ctx.LongValue("ListNotifications.Data.List["+ i +"].JoinPermissionAuthInfo.RejectedMillis");
				joinPermissionAuthInfo.JoinEui = _ctx.StringValue("ListNotifications.Data.List["+ i +"].JoinPermissionAuthInfo.JoinEui");
				joinPermissionAuthInfo.JoinPermissionName = _ctx.StringValue("ListNotifications.Data.List["+ i +"].JoinPermissionAuthInfo.JoinPermissionName");
				notification.JoinPermissionAuthInfo = joinPermissionAuthInfo;

				ListNotificationsResponse.ListNotifications_Data.ListNotifications_Notification.ListNotifications_GatewayDataflowLimit gatewayDataflowLimit = new ListNotificationsResponse.ListNotifications_Data.ListNotifications_Notification.ListNotifications_GatewayDataflowLimit();
				gatewayDataflowLimit.DataflowLimitMillis = _ctx.LongValue("ListNotifications.Data.List["+ i +"].GatewayDataflowLimit.DataflowLimitMillis");
				gatewayDataflowLimit.AlarmDetail = _ctx.StringValue("ListNotifications.Data.List["+ i +"].GatewayDataflowLimit.AlarmDetail");
				gatewayDataflowLimit.GwEui = _ctx.StringValue("ListNotifications.Data.List["+ i +"].GatewayDataflowLimit.GwEui");
				notification.GatewayDataflowLimit = gatewayDataflowLimit;

				data_list.Add(notification);
			}
			data.List = data_list;
			listNotificationsResponse.Data = data;
        
			return listNotificationsResponse;
        }
    }
}
