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
    public class ListPushRecordsResponseUnmarshaller
    {
        public static ListPushRecordsResponse Unmarshall(UnmarshallerContext context)
        {
			ListPushRecordsResponse listPushRecordsResponse = new ListPushRecordsResponse();

			listPushRecordsResponse.HttpResponse = context.HttpResponse;
			listPushRecordsResponse.RequestId = context.StringValue("ListPushRecords.RequestId");
			listPushRecordsResponse.Total = context.IntegerValue("ListPushRecords.Total");
			listPushRecordsResponse.Page = context.IntegerValue("ListPushRecords.Page");
			listPushRecordsResponse.PageSize = context.IntegerValue("ListPushRecords.PageSize");

			List<ListPushRecordsResponse.PushMessageInfo> pushMessageInfos = new List<ListPushRecordsResponse.PushMessageInfo>();
			for (int i = 0; i < context.Length("ListPushRecords.PushMessageInfos.Length"); i++) {
				ListPushRecordsResponse.PushMessageInfo pushMessageInfo = new ListPushRecordsResponse.PushMessageInfo();
				pushMessageInfo.AppKey = context.LongValue("ListPushRecords.PushMessageInfos["+ i +"].AppKey");
				pushMessageInfo.AppName = context.StringValue("ListPushRecords.PushMessageInfos["+ i +"].AppName");
				pushMessageInfo.MessageId = context.StringValue("ListPushRecords.PushMessageInfos["+ i +"].MessageId");
				pushMessageInfo.Type = context.StringValue("ListPushRecords.PushMessageInfos["+ i +"].Type");
				pushMessageInfo.DeviceType = context.StringValue("ListPushRecords.PushMessageInfos["+ i +"].DeviceType");
				pushMessageInfo.PushTime = context.StringValue("ListPushRecords.PushMessageInfos["+ i +"].PushTime");
				pushMessageInfo.Title = context.StringValue("ListPushRecords.PushMessageInfos["+ i +"].Title");
				pushMessageInfo.Body = context.StringValue("ListPushRecords.PushMessageInfos["+ i +"].Body");

				pushMessageInfos.Add(pushMessageInfo);
			}
			listPushRecordsResponse.PushMessageInfos = pushMessageInfos;
        
			return listPushRecordsResponse;
        }
    }
}