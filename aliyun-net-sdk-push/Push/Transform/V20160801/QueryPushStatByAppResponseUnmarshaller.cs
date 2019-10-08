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
    public class QueryPushStatByAppResponseUnmarshaller
    {
        public static QueryPushStatByAppResponse Unmarshall(UnmarshallerContext context)
        {
			QueryPushStatByAppResponse queryPushStatByAppResponse = new QueryPushStatByAppResponse();

			queryPushStatByAppResponse.HttpResponse = context.HttpResponse;
			queryPushStatByAppResponse.RequestId = context.StringValue("QueryPushStatByApp.RequestId");

			List<QueryPushStatByAppResponse.QueryPushStatByApp_AppPushStat> queryPushStatByAppResponse_appPushStats = new List<QueryPushStatByAppResponse.QueryPushStatByApp_AppPushStat>();
			for (int i = 0; i < context.Length("QueryPushStatByApp.AppPushStats.Length"); i++) {
				QueryPushStatByAppResponse.QueryPushStatByApp_AppPushStat appPushStat = new QueryPushStatByAppResponse.QueryPushStatByApp_AppPushStat();
				appPushStat.Time = context.StringValue("QueryPushStatByApp.AppPushStats["+ i +"].Time");
				appPushStat.AcceptCount = context.LongValue("QueryPushStatByApp.AppPushStats["+ i +"].AcceptCount");
				appPushStat.SentCount = context.LongValue("QueryPushStatByApp.AppPushStats["+ i +"].SentCount");
				appPushStat.ReceivedCount = context.LongValue("QueryPushStatByApp.AppPushStats["+ i +"].ReceivedCount");
				appPushStat.OpenedCount = context.LongValue("QueryPushStatByApp.AppPushStats["+ i +"].OpenedCount");
				appPushStat.DeletedCount = context.LongValue("QueryPushStatByApp.AppPushStats["+ i +"].DeletedCount");
				appPushStat.SmsSentCount = context.LongValue("QueryPushStatByApp.AppPushStats["+ i +"].SmsSentCount");
				appPushStat.SmsSkipCount = context.LongValue("QueryPushStatByApp.AppPushStats["+ i +"].SmsSkipCount");
				appPushStat.SmsFailedCount = context.LongValue("QueryPushStatByApp.AppPushStats["+ i +"].SmsFailedCount");
				appPushStat.SmsReceiveSuccessCount = context.LongValue("QueryPushStatByApp.AppPushStats["+ i +"].SmsReceiveSuccessCount");
				appPushStat.SmsReceiveFailedCount = context.LongValue("QueryPushStatByApp.AppPushStats["+ i +"].SmsReceiveFailedCount");

				queryPushStatByAppResponse_appPushStats.Add(appPushStat);
			}
			queryPushStatByAppResponse.AppPushStats = queryPushStatByAppResponse_appPushStats;
        
			return queryPushStatByAppResponse;
        }
    }
}
