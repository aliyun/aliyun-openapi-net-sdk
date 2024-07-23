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
    public class QueryFpDBDeleteJobListResponseUnmarshaller
    {
        public static QueryFpDBDeleteJobListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryFpDBDeleteJobListResponse queryFpDBDeleteJobListResponse = new QueryFpDBDeleteJobListResponse();

			queryFpDBDeleteJobListResponse.HttpResponse = _ctx.HttpResponse;
			queryFpDBDeleteJobListResponse.RequestId = _ctx.StringValue("QueryFpDBDeleteJobList.RequestId");

			List<string> queryFpDBDeleteJobListResponse_nonExistIds = new List<string>();
			for (int i = 0; i < _ctx.Length("QueryFpDBDeleteJobList.NonExistIds.Length"); i++) {
				queryFpDBDeleteJobListResponse_nonExistIds.Add(_ctx.StringValue("QueryFpDBDeleteJobList.NonExistIds["+ i +"]"));
			}
			queryFpDBDeleteJobListResponse.NonExistIds = queryFpDBDeleteJobListResponse_nonExistIds;

			List<QueryFpDBDeleteJobListResponse.QueryFpDBDeleteJobList_FpDBDeleteJob> queryFpDBDeleteJobListResponse_fpDBDeleteJobList = new List<QueryFpDBDeleteJobListResponse.QueryFpDBDeleteJobList_FpDBDeleteJob>();
			for (int i = 0; i < _ctx.Length("QueryFpDBDeleteJobList.FpDBDeleteJobList.Length"); i++) {
				QueryFpDBDeleteJobListResponse.QueryFpDBDeleteJobList_FpDBDeleteJob fpDBDeleteJob = new QueryFpDBDeleteJobListResponse.QueryFpDBDeleteJobList_FpDBDeleteJob();
				fpDBDeleteJob.CreationTime = _ctx.StringValue("QueryFpDBDeleteJobList.FpDBDeleteJobList["+ i +"].CreationTime");
				fpDBDeleteJob.Status = _ctx.StringValue("QueryFpDBDeleteJobList.FpDBDeleteJobList["+ i +"].Status");
				fpDBDeleteJob.FinishTime = _ctx.StringValue("QueryFpDBDeleteJobList.FpDBDeleteJobList["+ i +"].FinishTime");
				fpDBDeleteJob.DelType = _ctx.StringValue("QueryFpDBDeleteJobList.FpDBDeleteJobList["+ i +"].DelType");
				fpDBDeleteJob.UserData = _ctx.StringValue("QueryFpDBDeleteJobList.FpDBDeleteJobList["+ i +"].UserData");
				fpDBDeleteJob.Code = _ctx.StringValue("QueryFpDBDeleteJobList.FpDBDeleteJobList["+ i +"].Code");
				fpDBDeleteJob.Message = _ctx.StringValue("QueryFpDBDeleteJobList.FpDBDeleteJobList["+ i +"].Message");
				fpDBDeleteJob.PipelineId = _ctx.StringValue("QueryFpDBDeleteJobList.FpDBDeleteJobList["+ i +"].PipelineId");
				fpDBDeleteJob.FpDBId = _ctx.StringValue("QueryFpDBDeleteJobList.FpDBDeleteJobList["+ i +"].FpDBId");
				fpDBDeleteJob.Id = _ctx.StringValue("QueryFpDBDeleteJobList.FpDBDeleteJobList["+ i +"].Id");

				queryFpDBDeleteJobListResponse_fpDBDeleteJobList.Add(fpDBDeleteJob);
			}
			queryFpDBDeleteJobListResponse.FpDBDeleteJobList = queryFpDBDeleteJobListResponse_fpDBDeleteJobList;
        
			return queryFpDBDeleteJobListResponse;
        }
    }
}
