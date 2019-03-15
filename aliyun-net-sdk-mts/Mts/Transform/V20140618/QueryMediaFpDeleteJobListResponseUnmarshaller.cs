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
    public class QueryMediaFpDeleteJobListResponseUnmarshaller
    {
        public static QueryMediaFpDeleteJobListResponse Unmarshall(UnmarshallerContext context)
        {
			QueryMediaFpDeleteJobListResponse queryMediaFpDeleteJobListResponse = new QueryMediaFpDeleteJobListResponse();

			queryMediaFpDeleteJobListResponse.HttpResponse = context.HttpResponse;
			queryMediaFpDeleteJobListResponse.RequestId = context.StringValue("QueryMediaFpDeleteJobList.RequestId");

			List<string> queryMediaFpDeleteJobListResponse_nonExistIds = new List<string>();
			for (int i = 0; i < context.Length("QueryMediaFpDeleteJobList.NonExistIds.Length"); i++) {
				queryMediaFpDeleteJobListResponse_nonExistIds.Add(context.StringValue("QueryMediaFpDeleteJobList.NonExistIds["+ i +"]"));
			}
			queryMediaFpDeleteJobListResponse.NonExistIds = queryMediaFpDeleteJobListResponse_nonExistIds;

			List<QueryMediaFpDeleteJobListResponse.QueryMediaFpDeleteJobList_MediaFpDeleteJob> queryMediaFpDeleteJobListResponse_mediaFpDeleteJobList = new List<QueryMediaFpDeleteJobListResponse.QueryMediaFpDeleteJobList_MediaFpDeleteJob>();
			for (int i = 0; i < context.Length("QueryMediaFpDeleteJobList.MediaFpDeleteJobList.Length"); i++) {
				QueryMediaFpDeleteJobListResponse.QueryMediaFpDeleteJobList_MediaFpDeleteJob mediaFpDeleteJob = new QueryMediaFpDeleteJobListResponse.QueryMediaFpDeleteJobList_MediaFpDeleteJob();
				mediaFpDeleteJob.Id = context.StringValue("QueryMediaFpDeleteJobList.MediaFpDeleteJobList["+ i +"].Id");
				mediaFpDeleteJob.UserData = context.StringValue("QueryMediaFpDeleteJobList.MediaFpDeleteJobList["+ i +"].UserData");
				mediaFpDeleteJob.PipelineId = context.StringValue("QueryMediaFpDeleteJobList.MediaFpDeleteJobList["+ i +"].PipelineId");
				mediaFpDeleteJob.State = context.StringValue("QueryMediaFpDeleteJobList.MediaFpDeleteJobList["+ i +"].State");
				mediaFpDeleteJob.Code = context.StringValue("QueryMediaFpDeleteJobList.MediaFpDeleteJobList["+ i +"].Code");
				mediaFpDeleteJob.Message = context.StringValue("QueryMediaFpDeleteJobList.MediaFpDeleteJobList["+ i +"].Message");
				mediaFpDeleteJob.CreationTime = context.StringValue("QueryMediaFpDeleteJobList.MediaFpDeleteJobList["+ i +"].CreationTime");
				mediaFpDeleteJob.FinishTime = context.StringValue("QueryMediaFpDeleteJobList.MediaFpDeleteJobList["+ i +"].FinishTime");
				mediaFpDeleteJob.PrimaryKey = context.StringValue("QueryMediaFpDeleteJobList.MediaFpDeleteJobList["+ i +"].PrimaryKey");
				mediaFpDeleteJob.FpDBId = context.StringValue("QueryMediaFpDeleteJobList.MediaFpDeleteJobList["+ i +"].FpDBId");

				queryMediaFpDeleteJobListResponse_mediaFpDeleteJobList.Add(mediaFpDeleteJob);
			}
			queryMediaFpDeleteJobListResponse.MediaFpDeleteJobList = queryMediaFpDeleteJobListResponse_mediaFpDeleteJobList;
        
			return queryMediaFpDeleteJobListResponse;
        }
    }
}
