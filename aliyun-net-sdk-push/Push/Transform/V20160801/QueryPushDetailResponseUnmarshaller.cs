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
using Aliyun.Acs.Push.Model.V20160801;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Push.Transform.V20160801
{
    public class QueryPushDetailResponseUnmarshaller
    {
        public static QueryPushDetailResponse Unmarshall(UnmarshallerContext context)
        {
			QueryPushDetailResponse queryPushDetailResponse = new QueryPushDetailResponse();

			queryPushDetailResponse.HttpResponse = context.HttpResponse;
			queryPushDetailResponse.RequestId = context.StringValue("QueryPushDetail.RequestId");
			queryPushDetailResponse.AppKey = context.LongValue("QueryPushDetail.AppKey");
			queryPushDetailResponse.Target = context.StringValue("QueryPushDetail.Target");
			queryPushDetailResponse.TargetValue = context.StringValue("QueryPushDetail.TargetValue");
			queryPushDetailResponse.PushType = context.StringValue("QueryPushDetail.PushType");
			queryPushDetailResponse.DeviceType = context.StringValue("QueryPushDetail.DeviceType");
			queryPushDetailResponse.Title = context.StringValue("QueryPushDetail.Title");
			queryPushDetailResponse.Body = context.StringValue("QueryPushDetail.Body");
			queryPushDetailResponse.PushTime = context.StringValue("QueryPushDetail.PushTime");
			queryPushDetailResponse.ExpireTime = context.StringValue("QueryPushDetail.ExpireTime");
			queryPushDetailResponse.AntiHarassStartTime = context.IntegerValue("QueryPushDetail.AntiHarassStartTime");
			queryPushDetailResponse.AntiHarassDuration = context.IntegerValue("QueryPushDetail.AntiHarassDuration");
			queryPushDetailResponse.StoreOffline = context.BooleanValue("QueryPushDetail.StoreOffline");
			queryPushDetailResponse.BatchNumber = context.StringValue("QueryPushDetail.BatchNumber");
			queryPushDetailResponse.ProvinceId = context.StringValue("QueryPushDetail.ProvinceId");
			queryPushDetailResponse.IOSApnsEnv = context.StringValue("QueryPushDetail.IOSApnsEnv");
			queryPushDetailResponse.IOSRemind = context.BooleanValue("QueryPushDetail.IOSRemind");
			queryPushDetailResponse.IOSRemindBody = context.StringValue("QueryPushDetail.IOSRemindBody");
			queryPushDetailResponse.IOSBadge = context.IntegerValue("QueryPushDetail.IOSBadge");
			queryPushDetailResponse.IOSMusic = context.StringValue("QueryPushDetail.IOSMusic");
			queryPushDetailResponse.IOSSubtitle = context.StringValue("QueryPushDetail.IOSSubtitle");
			queryPushDetailResponse.IOSNotificationCategory = context.StringValue("QueryPushDetail.IOSNotificationCategory");
			queryPushDetailResponse.IOSMutableContent = context.BooleanValue("QueryPushDetail.IOSMutableContent");
			queryPushDetailResponse.IOSExtParameters = context.StringValue("QueryPushDetail.IOSExtParameters");
			queryPushDetailResponse.AndroidNotifyType = context.StringValue("QueryPushDetail.AndroidNotifyType");
			queryPushDetailResponse.AndroidOpenType = context.StringValue("QueryPushDetail.AndroidOpenType");
			queryPushDetailResponse.AndroidActivity = context.StringValue("QueryPushDetail.AndroidActivity");
			queryPushDetailResponse.AndroidMusic = context.StringValue("QueryPushDetail.AndroidMusic");
			queryPushDetailResponse.AndroidOpenUrl = context.StringValue("QueryPushDetail.AndroidOpenUrl");
			queryPushDetailResponse.AndroidXiaoMiActivity = context.StringValue("QueryPushDetail.AndroidXiaoMiActivity");
			queryPushDetailResponse.AndroidXiaoMiNotifyTitle = context.StringValue("QueryPushDetail.AndroidXiaoMiNotifyTitle");
			queryPushDetailResponse.AndroidXiaoMiNotifyBody = context.StringValue("QueryPushDetail.AndroidXiaoMiNotifyBody");
			queryPushDetailResponse.AndroidNotificationBarType = context.IntegerValue("QueryPushDetail.AndroidNotificationBarType");
			queryPushDetailResponse.AndroidNotificationBarPriority = context.IntegerValue("QueryPushDetail.AndroidNotificationBarPriority");
			queryPushDetailResponse.AndroidExtParameters = context.StringValue("QueryPushDetail.AndroidExtParameters");
        
			return queryPushDetailResponse;
        }
    }
}