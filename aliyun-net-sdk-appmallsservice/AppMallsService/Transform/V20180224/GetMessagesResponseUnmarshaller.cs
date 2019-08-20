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
using Aliyun.Acs.AppMallsService.Model.V20180224;

namespace Aliyun.Acs.AppMallsService.Transform.V20180224
{
    public class GetMessagesResponseUnmarshaller
    {
        public static GetMessagesResponse Unmarshall(UnmarshallerContext context)
        {
			GetMessagesResponse getMessagesResponse = new GetMessagesResponse();

			getMessagesResponse.HttpResponse = context.HttpResponse;
			getMessagesResponse.ErrorCode = context.StringValue("GetMessages.ErrorCode");
			getMessagesResponse.Msg = context.StringValue("GetMessages.Msg");
			getMessagesResponse.SubCode = context.StringValue("GetMessages.SubCode");
			getMessagesResponse.SubMsg = context.StringValue("GetMessages.SubMsg");
			getMessagesResponse.LogsId = context.StringValue("GetMessages.LogsId");
			getMessagesResponse.RequestId = context.StringValue("GetMessages.RequestId");

			List<GetMessagesResponse.GetMessages_BizMessagesItem> getMessagesResponse_bizMessages = new List<GetMessagesResponse.GetMessages_BizMessagesItem>();
			for (int i = 0; i < context.Length("GetMessages.BizMessages.Length"); i++) {
				GetMessagesResponse.GetMessages_BizMessagesItem bizMessagesItem = new GetMessagesResponse.GetMessages_BizMessagesItem();
				bizMessagesItem.PubTime = context.StringValue("GetMessages.BizMessages["+ i +"].PubTime");
				bizMessagesItem.Topic = context.StringValue("GetMessages.BizMessages["+ i +"].Topic");
				bizMessagesItem.DataId = context.LongValue("GetMessages.BizMessages["+ i +"].DataId");
				bizMessagesItem.ContentMapJson = context.StringValue("GetMessages.BizMessages["+ i +"].ContentMapJson");

				getMessagesResponse_bizMessages.Add(bizMessagesItem);
			}
			getMessagesResponse.BizMessages = getMessagesResponse_bizMessages;
        
			return getMessagesResponse;
        }
    }
}
