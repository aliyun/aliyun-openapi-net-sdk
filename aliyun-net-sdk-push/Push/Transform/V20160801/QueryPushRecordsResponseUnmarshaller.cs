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
        public static QueryPushRecordsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryPushRecordsResponse queryPushRecordsResponse = new QueryPushRecordsResponse();

			queryPushRecordsResponse.HttpResponse = _ctx.HttpResponse;
			queryPushRecordsResponse.NextToken = _ctx.StringValue("QueryPushRecords.NextToken");
			queryPushRecordsResponse.PageSize = _ctx.IntegerValue("QueryPushRecords.PageSize");
			queryPushRecordsResponse.RequestId = _ctx.StringValue("QueryPushRecords.RequestId");
			queryPushRecordsResponse.Total = _ctx.IntegerValue("QueryPushRecords.Total");
			queryPushRecordsResponse.Page = _ctx.IntegerValue("QueryPushRecords.Page");

			List<QueryPushRecordsResponse.QueryPushRecords_PushInfo> queryPushRecordsResponse_pushInfos = new List<QueryPushRecordsResponse.QueryPushRecords_PushInfo>();
			for (int i = 0; i < _ctx.Length("QueryPushRecords.PushInfos.Length"); i++) {
				QueryPushRecordsResponse.QueryPushRecords_PushInfo pushInfo = new QueryPushRecordsResponse.QueryPushRecords_PushInfo();
				pushInfo.Status = _ctx.StringValue("QueryPushRecords.PushInfos["+ i +"].Status");
				pushInfo.MessageId = _ctx.StringValue("QueryPushRecords.PushInfos["+ i +"].MessageId");
				pushInfo.AppKey = _ctx.LongValue("QueryPushRecords.PushInfos["+ i +"].AppKey");
				pushInfo.DeviceType = _ctx.StringValue("QueryPushRecords.PushInfos["+ i +"].DeviceType");
				pushInfo.PushType = _ctx.StringValue("QueryPushRecords.PushInfos["+ i +"].PushType");
				pushInfo.Body = _ctx.StringValue("QueryPushRecords.PushInfos["+ i +"].Body");
				pushInfo.Title = _ctx.StringValue("QueryPushRecords.PushInfos["+ i +"].Title");
				pushInfo.Source = _ctx.StringValue("QueryPushRecords.PushInfos["+ i +"].Source");
				pushInfo.PushTime = _ctx.StringValue("QueryPushRecords.PushInfos["+ i +"].PushTime");
				pushInfo.Target = _ctx.StringValue("QueryPushRecords.PushInfos["+ i +"].Target");

				queryPushRecordsResponse_pushInfos.Add(pushInfo);
			}
			queryPushRecordsResponse.PushInfos = queryPushRecordsResponse_pushInfos;
        
			return queryPushRecordsResponse;
        }
    }
}
