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
using System.Collections.Generic;

namespace Aliyun.Acs.Push.Transform.V20160801
{
    public class QueryAppPushStatResponseUnmarshaller
    {
        public static QueryAppPushStatResponse Unmarshall(UnmarshallerContext context)
        {
            QueryAppPushStatResponse queryAppPushStatResponse = new QueryAppPushStatResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("QueryAppPushStat.RequestId")
            };
            List<QueryAppPushStatResponse.AppPushStat> appPushStats = new List<QueryAppPushStatResponse.AppPushStat>();
			for (int i = 0; i < context.Length("QueryAppPushStat.AppPushStats.Length"); i++) {
                QueryAppPushStatResponse.AppPushStat appPushStat = new QueryAppPushStatResponse.AppPushStat()
                {
                    Time = context.StringValue($"QueryAppPushStat.AppPushStats[{i}].Time"),
                    SentCount = context.LongValue($"QueryAppPushStat.AppPushStats[{i}].SentCount"),
                    ReceivedCount = context.LongValue($"QueryAppPushStat.AppPushStats[{i}].ReceivedCount"),
                    OpenedCount = context.LongValue($"QueryAppPushStat.AppPushStats[{i}].OpenedCount"),
                    DeletedCount = context.LongValue($"QueryAppPushStat.AppPushStats[{i}].DeletedCount")
                };
                appPushStats.Add(appPushStat);
			}
			queryAppPushStatResponse.AppPushStats = appPushStats;
        
			return queryAppPushStatResponse;
        }
    }
}