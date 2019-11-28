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
    public class QueryPushRecordsResponseUnmarshaller
    {
        public static QueryPushRecordsResponse Unmarshall(UnmarshallerContext context)
        {
			QueryPushRecordsResponse queryPushRecordsResponse = new QueryPushRecordsResponse();

			queryPushRecordsResponse.HttpResponse = context.HttpResponse;
			queryPushRecordsResponse.RequestId = context.StringValue("QueryPushRecords.RequestId");
			queryPushRecordsResponse.NextToken = context.StringValue("QueryPushRecords.NextToken");
			queryPushRecordsResponse.PageSize = context.IntegerValue("QueryPushRecords.PageSize");

			List<QueryPushRecordsResponse.QueryPushRecords_PushInfo> queryPushRecordsResponse_pushInfos = new List<QueryPushRecordsResponse.QueryPushRecords_PushInfo>();
			for (int i = 0; i < context.Length("QueryPushRecords.PushInfos.Length"); i++) {
				QueryPushRecordsResponse.QueryPushRecords_PushInfo pushInfo = new QueryPushRecordsResponse.QueryPushRecords_PushInfo();
				pushInfo.AppKey = context.LongValue("QueryPushRecords.PushInfos["+ i +"].AppKey");
				pushInfo.MessageId = context.StringValue("QueryPushRecords.PushInfos["+ i +"].MessageId");
				pushInfo.PushType = context.StringValue("QueryPushRecords.PushInfos["+ i +"].PushType");
				pushInfo.DeviceType = context.StringValue("QueryPushRecords.PushInfos["+ i +"].DeviceType");
				pushInfo.Target = context.StringValue("QueryPushRecords.PushInfos["+ i +"].Target");
				pushInfo.Source = context.StringValue("QueryPushRecords.PushInfos["+ i +"].Source");
				pushInfo.PushTime = context.StringValue("QueryPushRecords.PushInfos["+ i +"].PushTime");
				pushInfo.Title = context.StringValue("QueryPushRecords.PushInfos["+ i +"].Title");
				pushInfo.Body = context.StringValue("QueryPushRecords.PushInfos["+ i +"].Body");
				pushInfo.Status = context.StringValue("QueryPushRecords.PushInfos["+ i +"].Status");

				queryPushRecordsResponse_pushInfos.Add(pushInfo);
			}
			queryPushRecordsResponse.PushInfos = queryPushRecordsResponse_pushInfos;
        
			return queryPushRecordsResponse;
        }
    }
}
