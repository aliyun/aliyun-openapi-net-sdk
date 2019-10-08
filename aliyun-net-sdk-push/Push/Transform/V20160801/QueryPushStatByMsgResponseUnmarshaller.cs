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
using Aliyun.Acs.Push.Model.V20160801;

namespace Aliyun.Acs.Push.Transform.V20160801
{
    public class QueryPushStatByMsgResponseUnmarshaller
    {
        public static QueryPushStatByMsgResponse Unmarshall(UnmarshallerContext context)
        {
			QueryPushStatByMsgResponse queryPushStatByMsgResponse = new QueryPushStatByMsgResponse();

			queryPushStatByMsgResponse.HttpResponse = context.HttpResponse;
			queryPushStatByMsgResponse.RequestId = context.StringValue("QueryPushStatByMsg.RequestId");

			List<QueryPushStatByMsgResponse.QueryPushStatByMsg_PushStat> queryPushStatByMsgResponse_pushStats = new List<QueryPushStatByMsgResponse.QueryPushStatByMsg_PushStat>();
			for (int i = 0; i < context.Length("QueryPushStatByMsg.PushStats.Length"); i++) {
				QueryPushStatByMsgResponse.QueryPushStatByMsg_PushStat pushStat = new QueryPushStatByMsgResponse.QueryPushStatByMsg_PushStat();
				pushStat.MessageId = context.StringValue("QueryPushStatByMsg.PushStats["+ i +"].MessageId");
				pushStat.AcceptCount = context.LongValue("QueryPushStatByMsg.PushStats["+ i +"].AcceptCount");
				pushStat.SentCount = context.LongValue("QueryPushStatByMsg.PushStats["+ i +"].SentCount");
				pushStat.ReceivedCount = context.LongValue("QueryPushStatByMsg.PushStats["+ i +"].ReceivedCount");
				pushStat.OpenedCount = context.LongValue("QueryPushStatByMsg.PushStats["+ i +"].OpenedCount");
				pushStat.DeletedCount = context.LongValue("QueryPushStatByMsg.PushStats["+ i +"].DeletedCount");
				pushStat.SmsSentCount = context.LongValue("QueryPushStatByMsg.PushStats["+ i +"].SmsSentCount");
				pushStat.SmsSkipCount = context.LongValue("QueryPushStatByMsg.PushStats["+ i +"].SmsSkipCount");
				pushStat.SmsFailedCount = context.LongValue("QueryPushStatByMsg.PushStats["+ i +"].SmsFailedCount");
				pushStat.SmsReceiveSuccessCount = context.LongValue("QueryPushStatByMsg.PushStats["+ i +"].SmsReceiveSuccessCount");
				pushStat.SmsReceiveFailedCount = context.LongValue("QueryPushStatByMsg.PushStats["+ i +"].SmsReceiveFailedCount");

				queryPushStatByMsgResponse_pushStats.Add(pushStat);
			}
			queryPushStatByMsgResponse.PushStats = queryPushStatByMsgResponse_pushStats;
        
			return queryPushStatByMsgResponse;
        }
    }
}
