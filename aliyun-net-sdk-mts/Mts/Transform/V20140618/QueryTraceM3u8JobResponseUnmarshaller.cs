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
using Aliyun.Acs.Mts.Model.V20140618;

namespace Aliyun.Acs.Mts.Transform.V20140618
{
    public class QueryTraceM3u8JobResponseUnmarshaller
    {
        public static QueryTraceM3u8JobResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryTraceM3u8JobResponse queryTraceM3u8JobResponse = new QueryTraceM3u8JobResponse();

			queryTraceM3u8JobResponse.HttpResponse = _ctx.HttpResponse;
			queryTraceM3u8JobResponse.RequestId = _ctx.StringValue("QueryTraceM3u8Job.RequestId");
			queryTraceM3u8JobResponse.Message = _ctx.StringValue("QueryTraceM3u8Job.Message");
			queryTraceM3u8JobResponse.StatusCode = _ctx.LongValue("QueryTraceM3u8Job.StatusCode");

			List<QueryTraceM3u8JobResponse.QueryTraceM3u8Job_DataItem> queryTraceM3u8JobResponse_data = new List<QueryTraceM3u8JobResponse.QueryTraceM3u8Job_DataItem>();
			for (int i = 0; i < _ctx.Length("QueryTraceM3u8Job.Data.Length"); i++) {
				QueryTraceM3u8JobResponse.QueryTraceM3u8Job_DataItem dataItem = new QueryTraceM3u8JobResponse.QueryTraceM3u8Job_DataItem();
				dataItem.GmtCreate = _ctx.LongValue("QueryTraceM3u8Job.Data["+ i +"].GmtCreate");
				dataItem.GmtModified = _ctx.LongValue("QueryTraceM3u8Job.Data["+ i +"].GmtModified");
				dataItem.MediaId = _ctx.StringValue("QueryTraceM3u8Job.Data["+ i +"].MediaId");
				dataItem.JobId = _ctx.StringValue("QueryTraceM3u8Job.Data["+ i +"].JobId");
				dataItem.Trace = _ctx.StringValue("QueryTraceM3u8Job.Data["+ i +"].Trace");
				dataItem.TraceId = _ctx.LongValue("QueryTraceM3u8Job.Data["+ i +"].TraceId");
				dataItem.Output = _ctx.StringValue("QueryTraceM3u8Job.Data["+ i +"].Output");
				dataItem.Status = _ctx.StringValue("QueryTraceM3u8Job.Data["+ i +"].Status");
				dataItem.UserData = _ctx.StringValue("QueryTraceM3u8Job.Data["+ i +"].UserData");
				dataItem.UserId = _ctx.LongValue("QueryTraceM3u8Job.Data["+ i +"].UserId");

				queryTraceM3u8JobResponse_data.Add(dataItem);
			}
			queryTraceM3u8JobResponse.Data = queryTraceM3u8JobResponse_data;
        
			return queryTraceM3u8JobResponse;
        }
    }
}
