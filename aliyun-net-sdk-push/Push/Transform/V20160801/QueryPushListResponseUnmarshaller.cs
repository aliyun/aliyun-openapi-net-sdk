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
    public class QueryPushListResponseUnmarshaller
    {
        public static QueryPushListResponse Unmarshall(UnmarshallerContext context)
        {
			QueryPushListResponse queryPushListResponse = new QueryPushListResponse();

			queryPushListResponse.HttpResponse = context.HttpResponse;
			queryPushListResponse.RequestId = context.StringValue("QueryPushList.RequestId");
			queryPushListResponse.HasNext = context.BooleanValue("QueryPushList.HasNext");
			queryPushListResponse.Page = context.IntegerValue("QueryPushList.Page");
			queryPushListResponse.PageSize = context.IntegerValue("QueryPushList.PageSize");

			List<QueryPushListResponse.QueryPushList_PushMessageInfo> queryPushListResponse_pushMessageInfos = new List<QueryPushListResponse.QueryPushList_PushMessageInfo>();
			for (int i = 0; i < context.Length("QueryPushList.PushMessageInfos.Length"); i++) {
				QueryPushListResponse.QueryPushList_PushMessageInfo pushMessageInfo = new QueryPushListResponse.QueryPushList_PushMessageInfo();
				pushMessageInfo.AppKey = context.LongValue("QueryPushList.PushMessageInfos["+ i +"].AppKey");
				pushMessageInfo.AppName = context.StringValue("QueryPushList.PushMessageInfos["+ i +"].AppName");
				pushMessageInfo.MessageId = context.StringValue("QueryPushList.PushMessageInfos["+ i +"].MessageId");
				pushMessageInfo.Type = context.StringValue("QueryPushList.PushMessageInfos["+ i +"].Type");
				pushMessageInfo.DeviceType = context.StringValue("QueryPushList.PushMessageInfos["+ i +"].DeviceType");
				pushMessageInfo.PushTime = context.StringValue("QueryPushList.PushMessageInfos["+ i +"].PushTime");
				pushMessageInfo.Title = context.StringValue("QueryPushList.PushMessageInfos["+ i +"].Title");
				pushMessageInfo.Body = context.StringValue("QueryPushList.PushMessageInfos["+ i +"].Body");

				queryPushListResponse_pushMessageInfos.Add(pushMessageInfo);
			}
			queryPushListResponse.PushMessageInfos = queryPushListResponse_pushMessageInfos;
        
			return queryPushListResponse;
        }
    }
}