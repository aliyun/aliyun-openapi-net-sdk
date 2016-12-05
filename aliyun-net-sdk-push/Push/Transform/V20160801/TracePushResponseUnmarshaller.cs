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
    public class TracePushResponseUnmarshaller
    {
        public static TracePushResponse Unmarshall(UnmarshallerContext context)
        {
			TracePushResponse tracePushResponse = new TracePushResponse();

			tracePushResponse.HttpResponse = context.HttpResponse;
			tracePushResponse.RequestId = context.StringValue("TracePush.RequestId");

			TracePushResponse.PushBasicInfo_ pushBasicInfo = new TracePushResponse.PushBasicInfo_();
			pushBasicInfo.AppId = context.LongValue("TracePush.PushBasicInfo.AppId");
			pushBasicInfo.Title = context.StringValue("TracePush.PushBasicInfo.Title");
			pushBasicInfo.TargetType = context.StringValue("TracePush.PushBasicInfo.TargetType");
			pushBasicInfo.PushType = context.StringValue("TracePush.PushBasicInfo.PushType");
			pushBasicInfo.PushTime = context.StringValue("TracePush.PushBasicInfo.PushTime");
			pushBasicInfo.ExpireTime = context.StringValue("TracePush.PushBasicInfo.ExpireTime");
			tracePushResponse.PushBasicInfo = pushBasicInfo;

			TracePushResponse.PushTaskInfo_ pushTaskInfo = new TracePushResponse.PushTaskInfo_();
			pushTaskInfo.Broadcast = context.BooleanValue("TracePush.PushTaskInfo.Broadcast");
			pushTaskInfo.AcceptTime = context.StringValue("TracePush.PushTaskInfo.AcceptTime");
			pushTaskInfo.AndroidTaskStatus = context.StringValue("TracePush.PushTaskInfo.AndroidTaskStatus");
			pushTaskInfo.IOSTaskStatus = context.StringValue("TracePush.PushTaskInfo.IOSTaskStatus");
			pushTaskInfo.AndroidTaskErrCode = context.StringValue("TracePush.PushTaskInfo.AndroidTaskErrCode");
			pushTaskInfo.IOSTaskErrCode = context.StringValue("TracePush.PushTaskInfo.IOSTaskErrCode");

			List<string> deviceSet = new List<string>();
			for (int i = 0; i < context.Length("TracePush.PushTaskInfo.DeviceSet.Length"); i++) {
				deviceSet.Add(context.StringValue("TracePush.PushTaskInfo.DeviceSet["+ i +"]"));
			}
			pushTaskInfo.DeviceSet = deviceSet;
			tracePushResponse.PushTaskInfo = pushTaskInfo;

			TracePushResponse.PushDeviceInfo_ pushDeviceInfo = new TracePushResponse.PushDeviceInfo_();
			pushDeviceInfo.Online = context.BooleanValue("TracePush.PushDeviceInfo.Online");
			pushDeviceInfo.CreateTime = context.StringValue("TracePush.PushDeviceInfo.CreateTime");
			pushDeviceInfo.SentTime = context.StringValue("TracePush.PushDeviceInfo.SentTime");
			pushDeviceInfo.ArriveTime = context.StringValue("TracePush.PushDeviceInfo.ArriveTime");
			pushDeviceInfo.ClickTime = context.StringValue("TracePush.PushDeviceInfo.ClickTime");
			pushDeviceInfo.CleanTime = context.StringValue("TracePush.PushDeviceInfo.CleanTime");
			pushDeviceInfo.DeviceStatus = context.StringValue("TracePush.PushDeviceInfo.DeviceStatus");
			pushDeviceInfo.DeviceErrCode = context.StringValue("TracePush.PushDeviceInfo.DeviceErrCode");
			tracePushResponse.PushDeviceInfo = pushDeviceInfo;
        
			return tracePushResponse;
        }
    }
}