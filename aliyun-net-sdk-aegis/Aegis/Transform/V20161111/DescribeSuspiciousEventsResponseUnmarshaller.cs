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
using Aliyun.Acs.aegis.Model.V20161111;

namespace Aliyun.Acs.aegis.Transform.V20161111
{
    public class DescribeSuspiciousEventsResponseUnmarshaller
    {
        public static DescribeSuspiciousEventsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSuspiciousEventsResponse describeSuspiciousEventsResponse = new DescribeSuspiciousEventsResponse();

			describeSuspiciousEventsResponse.HttpResponse = context.HttpResponse;
			describeSuspiciousEventsResponse.RequestId = context.StringValue("DescribeSuspiciousEvents.RequestId");
			describeSuspiciousEventsResponse.PageSize = context.IntegerValue("DescribeSuspiciousEvents.PageSize");
			describeSuspiciousEventsResponse.TotalCount = context.IntegerValue("DescribeSuspiciousEvents.TotalCount");
			describeSuspiciousEventsResponse.CurrentPage = context.IntegerValue("DescribeSuspiciousEvents.CurrentPage");

			List<DescribeSuspiciousEventsResponse.DescribeSuspiciousEvents_LogListItem> describeSuspiciousEventsResponse_logList = new List<DescribeSuspiciousEventsResponse.DescribeSuspiciousEvents_LogListItem>();
			for (int i = 0; i < context.Length("DescribeSuspiciousEvents.LogList.Length"); i++) {
				DescribeSuspiciousEventsResponse.DescribeSuspiciousEvents_LogListItem logListItem = new DescribeSuspiciousEventsResponse.DescribeSuspiciousEvents_LogListItem();
				logListItem.AliasEventType = context.StringValue("DescribeSuspiciousEvents.LogList["+ i +"].AliasEventType");
				logListItem.LastTime = context.LongValue("DescribeSuspiciousEvents.LogList["+ i +"].LastTime");
				logListItem.Level = context.StringValue("DescribeSuspiciousEvents.LogList["+ i +"].Level");
				logListItem.InstanceName = context.StringValue("DescribeSuspiciousEvents.LogList["+ i +"].InstanceName");
				logListItem.GroupId = context.LongValue("DescribeSuspiciousEvents.LogList["+ i +"].GroupId");
				logListItem.Ip = context.StringValue("DescribeSuspiciousEvents.LogList["+ i +"].Ip");
				logListItem.EventType = context.StringValue("DescribeSuspiciousEvents.LogList["+ i +"].EventType");
				logListItem.Uuid = context.StringValue("DescribeSuspiciousEvents.LogList["+ i +"].Uuid");
				logListItem.FirstTime = context.LongValue("DescribeSuspiciousEvents.LogList["+ i +"].FirstTime");
				logListItem.InstanceId = context.StringValue("DescribeSuspiciousEvents.LogList["+ i +"].InstanceId");
				logListItem.Tag = context.StringValue("DescribeSuspiciousEvents.LogList["+ i +"].Tag");
				logListItem.AliasEventName = context.StringValue("DescribeSuspiciousEvents.LogList["+ i +"].AliasEventName");
				logListItem.OsVersion = context.StringValue("DescribeSuspiciousEvents.LogList["+ i +"].OsVersion");
				logListItem.ClientIp = context.StringValue("DescribeSuspiciousEvents.LogList["+ i +"].ClientIp");
				logListItem.EventName = context.StringValue("DescribeSuspiciousEvents.LogList["+ i +"].EventName");

				List<DescribeSuspiciousEventsResponse.DescribeSuspiciousEvents_LogListItem.DescribeSuspiciousEvents_DetailListItem> logListItem_detailList = new List<DescribeSuspiciousEventsResponse.DescribeSuspiciousEvents_LogListItem.DescribeSuspiciousEvents_DetailListItem>();
				for (int j = 0; j < context.Length("DescribeSuspiciousEvents.LogList["+ i +"].DetailList.Length"); j++) {
					DescribeSuspiciousEventsResponse.DescribeSuspiciousEvents_LogListItem.DescribeSuspiciousEvents_DetailListItem detailListItem = new DescribeSuspiciousEventsResponse.DescribeSuspiciousEvents_LogListItem.DescribeSuspiciousEvents_DetailListItem();
					detailListItem.Name = context.StringValue("DescribeSuspiciousEvents.LogList["+ i +"].DetailList["+ j +"].Name");
					detailListItem.Type = context.StringValue("DescribeSuspiciousEvents.LogList["+ i +"].DetailList["+ j +"].Type");
					detailListItem._Value = context.StringValue("DescribeSuspiciousEvents.LogList["+ i +"].DetailList["+ j +"].Value");
					detailListItem.InfoType = context.StringValue("DescribeSuspiciousEvents.LogList["+ i +"].DetailList["+ j +"].InfoType");

					logListItem_detailList.Add(detailListItem);
				}
				logListItem.DetailList = logListItem_detailList;

				describeSuspiciousEventsResponse_logList.Add(logListItem);
			}
			describeSuspiciousEventsResponse.LogList = describeSuspiciousEventsResponse_logList;
        
			return describeSuspiciousEventsResponse;
        }
    }
}
