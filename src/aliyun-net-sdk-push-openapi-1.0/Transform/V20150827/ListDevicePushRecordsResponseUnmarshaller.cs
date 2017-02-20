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
using Aliyun.Acs.Push.Model.V20150827;
using System.Collections.Generic;

namespace Aliyun.Acs.Push.Transform.V20150827
{
    public class ListDevicePushRecordsResponseUnmarshaller
    {
        public static ListDevicePushRecordsResponse Unmarshall(UnmarshallerContext context)
        {
            ListDevicePushRecordsResponse listDevicePushRecordsResponse = new ListDevicePushRecordsResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("ListDevicePushRecords.RequestId"),
                Total = context.IntegerValue("ListDevicePushRecords.Total"),
                PageSize = context.IntegerValue("ListDevicePushRecords.PageSize"),
                Page = context.IntegerValue("ListDevicePushRecords.Page")
            };
            List<ListDevicePushRecordsResponse.DevicePushStat> messageList = new List<ListDevicePushRecordsResponse.DevicePushStat>();
			for (int i = 0; i < context.Length("ListDevicePushRecords.MessageList.Length"); i++) {
                ListDevicePushRecordsResponse.DevicePushStat devicePushStat = new ListDevicePushRecordsResponse.DevicePushStat()
                {
                    MessageId = context.StringValue($"ListDevicePushRecords.MessageList[{i}].MessageId"),
                    PushStatus = context.StringValue($"ListDevicePushRecords.MessageList[{i}].PushStatus"),
                    DeviceStatusWhenPush = context.StringValue($"ListDevicePushRecords.MessageList[{i}].DeviceStatusWhenPush"),
                    PushTime = context.StringValue($"ListDevicePushRecords.MessageList[{i}].PushTime"),
                    LastModifyTime = context.StringValue($"ListDevicePushRecords.MessageList[{i}].LastModifyTime")
                };
                messageList.Add(devicePushStat);
			}
			listDevicePushRecordsResponse.MessageList = messageList;
        
			return listDevicePushRecordsResponse;
        }
    }
}