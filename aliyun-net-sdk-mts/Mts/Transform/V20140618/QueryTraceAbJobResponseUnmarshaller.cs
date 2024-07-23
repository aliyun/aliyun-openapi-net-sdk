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
    public class QueryTraceAbJobResponseUnmarshaller
    {
        public static QueryTraceAbJobResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryTraceAbJobResponse queryTraceAbJobResponse = new QueryTraceAbJobResponse();

			queryTraceAbJobResponse.HttpResponse = _ctx.HttpResponse;
			queryTraceAbJobResponse.RequestId = _ctx.StringValue("QueryTraceAbJob.RequestId");
			queryTraceAbJobResponse.Message = _ctx.StringValue("QueryTraceAbJob.Message");
			queryTraceAbJobResponse.StatusCode = _ctx.LongValue("QueryTraceAbJob.StatusCode");

			List<QueryTraceAbJobResponse.QueryTraceAbJob_DataItem> queryTraceAbJobResponse_data = new List<QueryTraceAbJobResponse.QueryTraceAbJob_DataItem>();
			for (int i = 0; i < _ctx.Length("QueryTraceAbJob.Data.Length"); i++) {
				QueryTraceAbJobResponse.QueryTraceAbJob_DataItem dataItem = new QueryTraceAbJobResponse.QueryTraceAbJob_DataItem();
				dataItem.Callback = _ctx.StringValue("QueryTraceAbJob.Data["+ i +"].Callback");
				dataItem.GmtCreate = _ctx.LongValue("QueryTraceAbJob.Data["+ i +"].GmtCreate");
				dataItem.GmtModified = _ctx.LongValue("QueryTraceAbJob.Data["+ i +"].GmtModified");
				dataItem.Input = _ctx.StringValue("QueryTraceAbJob.Data["+ i +"].Input");
				dataItem.JobId = _ctx.StringValue("QueryTraceAbJob.Data["+ i +"].JobId");
				dataItem.Level = _ctx.LongValue("QueryTraceAbJob.Data["+ i +"].Level");
				dataItem.MediaId = _ctx.StringValue("QueryTraceAbJob.Data["+ i +"].MediaId");
				dataItem.Output = _ctx.StringValue("QueryTraceAbJob.Data["+ i +"].Output");
				dataItem.Status = _ctx.StringValue("QueryTraceAbJob.Data["+ i +"].Status");
				dataItem.UserData = _ctx.StringValue("QueryTraceAbJob.Data["+ i +"].UserData");
				dataItem.UserId = _ctx.LongValue("QueryTraceAbJob.Data["+ i +"].UserId");
				dataItem.Result = _ctx.StringValue("QueryTraceAbJob.Data["+ i +"].Result");

				queryTraceAbJobResponse_data.Add(dataItem);
			}
			queryTraceAbJobResponse.Data = queryTraceAbJobResponse_data;
        
			return queryTraceAbJobResponse;
        }
    }
}
