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
    public class GetNotificationResponseUnmarshaller
    {
        public static GetNotificationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetNotificationResponse getNotificationResponse = new GetNotificationResponse();

			getNotificationResponse.HttpResponse = _ctx.HttpResponse;
			getNotificationResponse.RequestId = _ctx.StringValue("GetNotification.RequestId");
			getNotificationResponse.Success = _ctx.BooleanValue("GetNotification.Success");

			GetNotificationResponse.GetNotification_Data data = new GetNotificationResponse.GetNotification_Data();
			data.NotificationId = _ctx.StringValue("GetNotification.Data.NotificationId");
			data.Category = _ctx.StringValue("GetNotification.Data.Category");
			data.HandleState = _ctx.StringValue("GetNotification.Data.HandleState");
			data.NoticeMillis = _ctx.LongValue("GetNotification.Data.NoticeMillis");
			data.HandledMillis = _ctx.LongValue("GetNotification.Data.HandledMillis");

			GetNotificationResponse.GetNotification_Data.GetNotification_GatewayOfflineInfo gatewayOfflineInfo = new GetNotificationResponse.GetNotification_Data.GetNotification_GatewayOfflineInfo();
			gatewayOfflineInfo.GwEui = _ctx.StringValue("GetNotification.Data.GatewayOfflineInfo.GwEui");
			gatewayOfflineInfo.OfflineMillis = _ctx.LongValue("GetNotification.Data.GatewayOfflineInfo.OfflineMillis");
			data.GatewayOfflineInfo = gatewayOfflineInfo;

			GetNotificationResponse.GetNotification_Data.GetNotification_JoinPermissionAuthInfo joinPermissionAuthInfo = new GetNotificationResponse.GetNotification_Data.GetNotification_JoinPermissionAuthInfo();
			joinPermissionAuthInfo.OrderId = _ctx.StringValue("GetNotification.Data.JoinPermissionAuthInfo.OrderId");
			joinPermissionAuthInfo.JoinPermissionId = _ctx.StringValue("GetNotification.Data.JoinPermissionAuthInfo.JoinPermissionId");
			joinPermissionAuthInfo.OwnerAliyunId = _ctx.StringValue("GetNotification.Data.JoinPermissionAuthInfo.OwnerAliyunId");
			joinPermissionAuthInfo.RenterAliyunId = _ctx.StringValue("GetNotification.Data.JoinPermissionAuthInfo.RenterAliyunId");
			joinPermissionAuthInfo.OrderState = _ctx.StringValue("GetNotification.Data.JoinPermissionAuthInfo.OrderState");
			joinPermissionAuthInfo.ApplyingMillis = _ctx.LongValue("GetNotification.Data.JoinPermissionAuthInfo.ApplyingMillis");
			joinPermissionAuthInfo.AcceptedMillis = _ctx.LongValue("GetNotification.Data.JoinPermissionAuthInfo.AcceptedMillis");
			joinPermissionAuthInfo.CanceledMillis = _ctx.LongValue("GetNotification.Data.JoinPermissionAuthInfo.CanceledMillis");
			joinPermissionAuthInfo.RejectedMillis = _ctx.LongValue("GetNotification.Data.JoinPermissionAuthInfo.RejectedMillis");
			joinPermissionAuthInfo.JoinEui = _ctx.StringValue("GetNotification.Data.JoinPermissionAuthInfo.JoinEui");
			joinPermissionAuthInfo.JoinPermissionName = _ctx.StringValue("GetNotification.Data.JoinPermissionAuthInfo.JoinPermissionName");
			data.JoinPermissionAuthInfo = joinPermissionAuthInfo;
			getNotificationResponse.Data = data;
        
			return getNotificationResponse;
        }
    }
}
