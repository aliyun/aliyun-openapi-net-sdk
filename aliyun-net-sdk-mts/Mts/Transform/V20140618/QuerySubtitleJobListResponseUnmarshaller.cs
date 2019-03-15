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
    public class QuerySubtitleJobListResponseUnmarshaller
    {
        public static QuerySubtitleJobListResponse Unmarshall(UnmarshallerContext context)
        {
			QuerySubtitleJobListResponse querySubtitleJobListResponse = new QuerySubtitleJobListResponse();

			querySubtitleJobListResponse.HttpResponse = context.HttpResponse;
			querySubtitleJobListResponse.RequestId = context.StringValue("QuerySubtitleJobList.RequestId");

			List<string> querySubtitleJobListResponse_nonExistJobIds = new List<string>();
			for (int i = 0; i < context.Length("QuerySubtitleJobList.NonExistJobIds.Length"); i++) {
				querySubtitleJobListResponse_nonExistJobIds.Add(context.StringValue("QuerySubtitleJobList.NonExistJobIds["+ i +"]"));
			}
			querySubtitleJobListResponse.NonExistJobIds = querySubtitleJobListResponse_nonExistJobIds;

			List<QuerySubtitleJobListResponse.QuerySubtitleJobList_Job> querySubtitleJobListResponse_jobList = new List<QuerySubtitleJobListResponse.QuerySubtitleJobList_Job>();
			for (int i = 0; i < context.Length("QuerySubtitleJobList.JobList.Length"); i++) {
				QuerySubtitleJobListResponse.QuerySubtitleJobList_Job job = new QuerySubtitleJobListResponse.QuerySubtitleJobList_Job();
				job.JobId = context.StringValue("QuerySubtitleJobList.JobList["+ i +"].JobId");
				job.InputConfig = context.StringValue("QuerySubtitleJobList.JobList["+ i +"].InputConfig");
				job.OutputConfig = context.StringValue("QuerySubtitleJobList.JobList["+ i +"].OutputConfig");
				job.UserData = context.StringValue("QuerySubtitleJobList.JobList["+ i +"].UserData");
				job.State = context.StringValue("QuerySubtitleJobList.JobList["+ i +"].State");

				QuerySubtitleJobListResponse.QuerySubtitleJobList_Job.QuerySubtitleJobList_MNSMessageResult mNSMessageResult = new QuerySubtitleJobListResponse.QuerySubtitleJobList_Job.QuerySubtitleJobList_MNSMessageResult();
				mNSMessageResult.MessageId = context.StringValue("QuerySubtitleJobList.JobList["+ i +"].MNSMessageResult.MessageId");
				mNSMessageResult.ErrorMessage = context.StringValue("QuerySubtitleJobList.JobList["+ i +"].MNSMessageResult.ErrorMessage");
				mNSMessageResult.ErrorCode = context.StringValue("QuerySubtitleJobList.JobList["+ i +"].MNSMessageResult.ErrorCode");
				job.MNSMessageResult = mNSMessageResult;

				querySubtitleJobListResponse_jobList.Add(job);
			}
			querySubtitleJobListResponse.JobList = querySubtitleJobListResponse_jobList;
        
			return querySubtitleJobListResponse;
        }
    }
}
