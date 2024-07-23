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
    public class QueryFpFileDeleteJobListResponseUnmarshaller
    {
        public static QueryFpFileDeleteJobListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryFpFileDeleteJobListResponse queryFpFileDeleteJobListResponse = new QueryFpFileDeleteJobListResponse();

			queryFpFileDeleteJobListResponse.HttpResponse = _ctx.HttpResponse;
			queryFpFileDeleteJobListResponse.RequestId = _ctx.StringValue("QueryFpFileDeleteJobList.RequestId");

			List<string> queryFpFileDeleteJobListResponse_nonExistIds = new List<string>();
			for (int i = 0; i < _ctx.Length("QueryFpFileDeleteJobList.NonExistIds.Length"); i++) {
				queryFpFileDeleteJobListResponse_nonExistIds.Add(_ctx.StringValue("QueryFpFileDeleteJobList.NonExistIds["+ i +"]"));
			}
			queryFpFileDeleteJobListResponse.NonExistIds = queryFpFileDeleteJobListResponse_nonExistIds;

			List<QueryFpFileDeleteJobListResponse.QueryFpFileDeleteJobList_FpFileDeleteJob> queryFpFileDeleteJobListResponse_fpFileDeleteJobList = new List<QueryFpFileDeleteJobListResponse.QueryFpFileDeleteJobList_FpFileDeleteJob>();
			for (int i = 0; i < _ctx.Length("QueryFpFileDeleteJobList.FpFileDeleteJobList.Length"); i++) {
				QueryFpFileDeleteJobListResponse.QueryFpFileDeleteJobList_FpFileDeleteJob fpFileDeleteJob = new QueryFpFileDeleteJobListResponse.QueryFpFileDeleteJobList_FpFileDeleteJob();
				fpFileDeleteJob.CreationTime = _ctx.StringValue("QueryFpFileDeleteJobList.FpFileDeleteJobList["+ i +"].CreationTime");
				fpFileDeleteJob.Status = _ctx.StringValue("QueryFpFileDeleteJobList.FpFileDeleteJobList["+ i +"].Status");
				fpFileDeleteJob.FinishTime = _ctx.StringValue("QueryFpFileDeleteJobList.FpFileDeleteJobList["+ i +"].FinishTime");
				fpFileDeleteJob.UserData = _ctx.StringValue("QueryFpFileDeleteJobList.FpFileDeleteJobList["+ i +"].UserData");
				fpFileDeleteJob.Code = _ctx.StringValue("QueryFpFileDeleteJobList.FpFileDeleteJobList["+ i +"].Code");
				fpFileDeleteJob.Message = _ctx.StringValue("QueryFpFileDeleteJobList.FpFileDeleteJobList["+ i +"].Message");
				fpFileDeleteJob.PipelineId = _ctx.StringValue("QueryFpFileDeleteJobList.FpFileDeleteJobList["+ i +"].PipelineId");
				fpFileDeleteJob.FpDBId = _ctx.StringValue("QueryFpFileDeleteJobList.FpFileDeleteJobList["+ i +"].FpDBId");
				fpFileDeleteJob.Id = _ctx.StringValue("QueryFpFileDeleteJobList.FpFileDeleteJobList["+ i +"].Id");
				fpFileDeleteJob.FileIds = _ctx.StringValue("QueryFpFileDeleteJobList.FpFileDeleteJobList["+ i +"].FileIds");

				queryFpFileDeleteJobListResponse_fpFileDeleteJobList.Add(fpFileDeleteJob);
			}
			queryFpFileDeleteJobListResponse.FpFileDeleteJobList = queryFpFileDeleteJobListResponse_fpFileDeleteJobList;
        
			return queryFpFileDeleteJobListResponse;
        }
    }
}
