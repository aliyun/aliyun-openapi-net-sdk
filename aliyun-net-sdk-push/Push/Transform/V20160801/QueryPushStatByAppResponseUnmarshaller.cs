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
        public static QueryPushStatByAppResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryPushStatByAppResponse queryPushStatByAppResponse = new QueryPushStatByAppResponse();

			queryPushStatByAppResponse.HttpResponse = _ctx.HttpResponse;
			queryPushStatByAppResponse.RequestId = _ctx.StringValue("QueryPushStatByApp.RequestId");

			List<QueryPushStatByAppResponse.QueryPushStatByApp_AppPushStat> queryPushStatByAppResponse_appPushStats = new List<QueryPushStatByAppResponse.QueryPushStatByApp_AppPushStat>();
			for (int i = 0; i < _ctx.Length("QueryPushStatByApp.AppPushStats.Length"); i++) {
				QueryPushStatByAppResponse.QueryPushStatByApp_AppPushStat appPushStat = new QueryPushStatByAppResponse.QueryPushStatByApp_AppPushStat();
				appPushStat.Time = _ctx.StringValue("QueryPushStatByApp.AppPushStats["+ i +"].Time");
				appPushStat.DeletedCount = _ctx.LongValue("QueryPushStatByApp.AppPushStats["+ i +"].DeletedCount");
				appPushStat.OpenedCount = _ctx.LongValue("QueryPushStatByApp.AppPushStats["+ i +"].OpenedCount");
				appPushStat.SmsReceiveSuccessCount = _ctx.LongValue("QueryPushStatByApp.AppPushStats["+ i +"].SmsReceiveSuccessCount");
				appPushStat.SmsSkipCount = _ctx.LongValue("QueryPushStatByApp.AppPushStats["+ i +"].SmsSkipCount");
				appPushStat.SmsReceiveFailedCount = _ctx.LongValue("QueryPushStatByApp.AppPushStats["+ i +"].SmsReceiveFailedCount");
				appPushStat.SmsFailedCount = _ctx.LongValue("QueryPushStatByApp.AppPushStats["+ i +"].SmsFailedCount");
				appPushStat.ReceivedCount = _ctx.LongValue("QueryPushStatByApp.AppPushStats["+ i +"].ReceivedCount");
				appPushStat.SentCount = _ctx.LongValue("QueryPushStatByApp.AppPushStats["+ i +"].SentCount");
				appPushStat.SmsSentCount = _ctx.LongValue("QueryPushStatByApp.AppPushStats["+ i +"].SmsSentCount");
				appPushStat.AcceptCount = _ctx.LongValue("QueryPushStatByApp.AppPushStats["+ i +"].AcceptCount");

				queryPushStatByAppResponse_appPushStats.Add(appPushStat);
			}
			queryPushStatByAppResponse.AppPushStats = queryPushStatByAppResponse_appPushStats;
        
			return queryPushStatByAppResponse;
        }
    }
}
