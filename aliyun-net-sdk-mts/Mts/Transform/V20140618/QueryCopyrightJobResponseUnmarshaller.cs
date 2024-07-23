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
    public class QueryCopyrightJobResponseUnmarshaller
    {
        public static QueryCopyrightJobResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryCopyrightJobResponse queryCopyrightJobResponse = new QueryCopyrightJobResponse();

			queryCopyrightJobResponse.HttpResponse = _ctx.HttpResponse;
			queryCopyrightJobResponse.RequestId = _ctx.StringValue("QueryCopyrightJob.RequestId");
			queryCopyrightJobResponse.Message = _ctx.StringValue("QueryCopyrightJob.Message");
			queryCopyrightJobResponse.StatusCode = _ctx.LongValue("QueryCopyrightJob.StatusCode");

			List<QueryCopyrightJobResponse.QueryCopyrightJob_DataItem> queryCopyrightJobResponse_data = new List<QueryCopyrightJobResponse.QueryCopyrightJob_DataItem>();
			for (int i = 0; i < _ctx.Length("QueryCopyrightJob.Data.Length"); i++) {
				QueryCopyrightJobResponse.QueryCopyrightJob_DataItem dataItem = new QueryCopyrightJobResponse.QueryCopyrightJob_DataItem();
				dataItem.Callback = _ctx.StringValue("QueryCopyrightJob.Data["+ i +"].Callback");
				dataItem.GmtCreate = _ctx.LongValue("QueryCopyrightJob.Data["+ i +"].GmtCreate");
				dataItem.GmtModified = _ctx.LongValue("QueryCopyrightJob.Data["+ i +"].GmtModified");
				dataItem.Input = _ctx.StringValue("QueryCopyrightJob.Data["+ i +"].Input");
				dataItem.JobId = _ctx.StringValue("QueryCopyrightJob.Data["+ i +"].JobId");
				dataItem.Level = _ctx.LongValue("QueryCopyrightJob.Data["+ i +"].Level");
				dataItem.Message = _ctx.StringValue("QueryCopyrightJob.Data["+ i +"].Message");
				dataItem.MessageId = _ctx.LongValue("QueryCopyrightJob.Data["+ i +"].MessageId");
				dataItem.Output = _ctx.StringValue("QueryCopyrightJob.Data["+ i +"].Output");
				dataItem.Status = _ctx.StringValue("QueryCopyrightJob.Data["+ i +"].Status");
				dataItem.UserData = _ctx.StringValue("QueryCopyrightJob.Data["+ i +"].UserData");
				dataItem.UserId = _ctx.LongValue("QueryCopyrightJob.Data["+ i +"].UserId");
				dataItem.Result = _ctx.StringValue("QueryCopyrightJob.Data["+ i +"].Result");

				queryCopyrightJobResponse_data.Add(dataItem);
			}
			queryCopyrightJobResponse.Data = queryCopyrightJobResponse_data;
        
			return queryCopyrightJobResponse;
        }
    }
}
