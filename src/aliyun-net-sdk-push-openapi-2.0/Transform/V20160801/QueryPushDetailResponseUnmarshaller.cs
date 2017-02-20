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

namespace Aliyun.Acs.Push.Transform.V20160801
{
    public class QueryPushDetailResponseUnmarshaller
    {
        public static QueryPushDetailResponse Unmarshall(UnmarshallerContext context)
        {
            QueryPushDetailResponse queryPushDetailResponse = new QueryPushDetailResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("QueryPushDetail.RequestId"),
                AppKey = context.LongValue("QueryPushDetail.AppKey"),
                Target = context.StringValue("QueryPushDetail.Target"),
                TargetValue = context.StringValue("QueryPushDetail.TargetValue"),
                PushType = context.StringValue("QueryPushDetail.PushType"),
                DeviceType = context.StringValue("QueryPushDetail.DeviceType"),
                Title = context.StringValue("QueryPushDetail.Title"),
                Body = context.StringValue("QueryPushDetail.Body"),
                PushTime = context.StringValue("QueryPushDetail.PushTime"),
                ExpireTime = context.StringValue("QueryPushDetail.ExpireTime"),
                AntiHarassStartTime = context.IntegerValue("QueryPushDetail.AntiHarassStartTime"),
                AntiHarassDuration = context.IntegerValue("QueryPushDetail.AntiHarassDuration"),
                StoreOffline = context.BooleanValue("QueryPushDetail.StoreOffline"),
                BatchNumber = context.StringValue("QueryPushDetail.BatchNumber"),
                ProvinceId = context.StringValue("QueryPushDetail.ProvinceId"),
                IosApnsEnv = context.StringValue("QueryPushDetail.IOSApnsEnv"),
                IosRemind = context.BooleanValue("QueryPushDetail.IOSRemind"),
                IosRemindBody = context.StringValue("QueryPushDetail.IOSRemindBody"),
                IosBadge = context.IntegerValue("QueryPushDetail.IOSBadge"),
                IosMusic = context.StringValue("QueryPushDetail.IOSMusic"),
                IosSubtitle = context.StringValue("QueryPushDetail.IOSSubtitle"),
                IosNotificationCategory = context.StringValue("QueryPushDetail.IOSNotificationCategory"),
                IosMutableContent = context.BooleanValue("QueryPushDetail.IOSMutableContent"),
                IosExtParameters = context.StringValue("QueryPushDetail.IOSExtParameters"),
                AndroidNotifyType = context.StringValue("QueryPushDetail.AndroidNotifyType"),
                AndroidOpenType = context.StringValue("QueryPushDetail.AndroidOpenType"),
                AndroidActivity = context.StringValue("QueryPushDetail.AndroidActivity"),
                AndroidMusic = context.StringValue("QueryPushDetail.AndroidMusic"),
                AndroidOpenUrl = context.StringValue("QueryPushDetail.AndroidOpenUrl"),
                AndroidXiaoMiActivity = context.StringValue("QueryPushDetail.AndroidXiaoMiActivity"),
                AndroidXiaoMiNotifyTitle = context.StringValue("QueryPushDetail.AndroidXiaoMiNotifyTitle"),
                AndroidXiaoMiNotifyBody = context.StringValue("QueryPushDetail.AndroidXiaoMiNotifyBody"),
                AndroidNotificationBarType = context.IntegerValue("QueryPushDetail.AndroidNotificationBarType"),
                AndroidNotificationBarPriority = context.IntegerValue("QueryPushDetail.AndroidNotificationBarPriority"),
                AndroidExtParameters = context.StringValue("QueryPushDetail.AndroidExtParameters")
            };
            return queryPushDetailResponse;
        }
    }
}