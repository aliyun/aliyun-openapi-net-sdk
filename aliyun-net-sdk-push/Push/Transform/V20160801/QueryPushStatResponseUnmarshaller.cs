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
    public class QueryPushStatResponseUnmarshaller
    {
        public static QueryPushStatResponse Unmarshall(UnmarshallerContext context)
        {
			QueryPushStatResponse queryPushStatResponse = new QueryPushStatResponse();

			queryPushStatResponse.HttpResponse = context.HttpResponse;
			queryPushStatResponse.RequestId = context.StringValue("QueryPushStat.RequestId");

			List<QueryPushStatResponse.PushStat> pushStats = new List<QueryPushStatResponse.PushStat>();
			for (int i = 0; i < context.Length("QueryPushStat.PushStats.Length"); i++) {
				QueryPushStatResponse.PushStat pushStat = new QueryPushStatResponse.PushStat();
				pushStat.MessageId = context.StringValue("QueryPushStat.PushStats["+ i +"].MessageId");
				pushStat.SentCount = context.LongValue("QueryPushStat.PushStats["+ i +"].SentCount");
				pushStat.ReceivedCount = context.LongValue("QueryPushStat.PushStats["+ i +"].ReceivedCount");
				pushStat.OpenedCount = context.LongValue("QueryPushStat.PushStats["+ i +"].OpenedCount");
				pushStat.DeletedCount = context.LongValue("QueryPushStat.PushStats["+ i +"].DeletedCount");

				pushStats.Add(pushStat);
			}
			queryPushStatResponse.PushStats = pushStats;
        
			return queryPushStatResponse;
        }
    }
}