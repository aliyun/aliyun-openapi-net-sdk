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
using System.Collections.Generic;

namespace Aliyun.Acs.Push.Transform.V20160801
{
    public class TracePushResponseUnmarshaller
    {
        public static TracePushResponse Unmarshall(UnmarshallerContext context)
        {
            TracePushResponse tracePushResponse = new TracePushResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("TracePush.RequestId")
            };
            TracePushResponse.PushBasicInfo_ pushBasicInfo = new TracePushResponse.PushBasicInfo_()
            {
                AppId = context.LongValue("TracePush.PushBasicInfo.AppId"),
                Title = context.StringValue("TracePush.PushBasicInfo.Title"),
                TargetType = context.StringValue("TracePush.PushBasicInfo.TargetType"),
                PushType = context.StringValue("TracePush.PushBasicInfo.PushType"),
                PushTime = context.StringValue("TracePush.PushBasicInfo.PushTime"),
                ExpireTime = context.StringValue("TracePush.PushBasicInfo.ExpireTime")
            };
            tracePushResponse.PushBasicInfo = pushBasicInfo;

            TracePushResponse.PushTaskInfo_ pushTaskInfo = new TracePushResponse.PushTaskInfo_()
            {
                Broadcast = context.BooleanValue("TracePush.PushTaskInfo.Broadcast"),
                AcceptTime = context.StringValue("TracePush.PushTaskInfo.AcceptTime"),
                AndroidTaskStatus = context.StringValue("TracePush.PushTaskInfo.AndroidTaskStatus"),
                IosTaskStatus = context.StringValue("TracePush.PushTaskInfo.IOSTaskStatus"),
                AndroidTaskErrCode = context.StringValue("TracePush.PushTaskInfo.AndroidTaskErrCode"),
                IosTaskErrCode = context.StringValue("TracePush.PushTaskInfo.IOSTaskErrCode")
            };
            List<string> deviceSet = new List<string>();
			for (int i = 0; i < context.Length("TracePush.PushTaskInfo.DeviceSet.Length"); i++) {
				deviceSet.Add(context.StringValue($"TracePush.PushTaskInfo.DeviceSet[{i}]"));
			}
			pushTaskInfo.DeviceSet = deviceSet;
			tracePushResponse.PushTaskInfo = pushTaskInfo;

            TracePushResponse.PushDeviceInfo_ pushDeviceInfo = new TracePushResponse.PushDeviceInfo_()
            {
                Online = context.BooleanValue("TracePush.PushDeviceInfo.Online"),
                CreateTime = context.StringValue("TracePush.PushDeviceInfo.CreateTime"),
                SentTime = context.StringValue("TracePush.PushDeviceInfo.SentTime"),
                ArriveTime = context.StringValue("TracePush.PushDeviceInfo.ArriveTime"),
                ClickTime = context.StringValue("TracePush.PushDeviceInfo.ClickTime"),
                CleanTime = context.StringValue("TracePush.PushDeviceInfo.CleanTime"),
                DeviceStatus = context.StringValue("TracePush.PushDeviceInfo.DeviceStatus"),
                DeviceErrCode = context.StringValue("TracePush.PushDeviceInfo.DeviceErrCode")
            };
            tracePushResponse.PushDeviceInfo = pushDeviceInfo;
        
			return tracePushResponse;
        }
    }
}