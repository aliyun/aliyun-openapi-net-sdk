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
using Aliyun.Acs.vod.Model.V20170321;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class ListAIVideoSummaryJobResponseUnmarshaller
    {
        public static ListAIVideoSummaryJobResponse Unmarshall(UnmarshallerContext context)
        {
			ListAIVideoSummaryJobResponse listAIVideoSummaryJobResponse = new ListAIVideoSummaryJobResponse();

			listAIVideoSummaryJobResponse.HttpResponse = context.HttpResponse;
			listAIVideoSummaryJobResponse.RequestId = context.StringValue("ListAIVideoSummaryJob.RequestId");

			List<string> listAIVideoSummaryJobResponse_nonExistAIVideoSummaryJobIds = new List<string>();
			for (int i = 0; i < context.Length("ListAIVideoSummaryJob.NonExistAIVideoSummaryJobIds.Length"); i++) {
				listAIVideoSummaryJobResponse_nonExistAIVideoSummaryJobIds.Add(context.StringValue("ListAIVideoSummaryJob.NonExistAIVideoSummaryJobIds["+ i +"]"));
			}
			listAIVideoSummaryJobResponse.NonExistAIVideoSummaryJobIds = listAIVideoSummaryJobResponse_nonExistAIVideoSummaryJobIds;

			List<ListAIVideoSummaryJobResponse.ListAIVideoSummaryJob_AIVideoSummaryJob> listAIVideoSummaryJobResponse_aIVideoSummaryJobList = new List<ListAIVideoSummaryJobResponse.ListAIVideoSummaryJob_AIVideoSummaryJob>();
			for (int i = 0; i < context.Length("ListAIVideoSummaryJob.AIVideoSummaryJobList.Length"); i++) {
				ListAIVideoSummaryJobResponse.ListAIVideoSummaryJob_AIVideoSummaryJob aIVideoSummaryJob = new ListAIVideoSummaryJobResponse.ListAIVideoSummaryJob_AIVideoSummaryJob();
				aIVideoSummaryJob.JobId = context.StringValue("ListAIVideoSummaryJob.AIVideoSummaryJobList["+ i +"].JobId");
				aIVideoSummaryJob.MediaId = context.StringValue("ListAIVideoSummaryJob.AIVideoSummaryJobList["+ i +"].MediaId");
				aIVideoSummaryJob.Status = context.StringValue("ListAIVideoSummaryJob.AIVideoSummaryJobList["+ i +"].Status");
				aIVideoSummaryJob.Code = context.StringValue("ListAIVideoSummaryJob.AIVideoSummaryJobList["+ i +"].Code");
				aIVideoSummaryJob.Message = context.StringValue("ListAIVideoSummaryJob.AIVideoSummaryJobList["+ i +"].Message");
				aIVideoSummaryJob.CreationTime = context.StringValue("ListAIVideoSummaryJob.AIVideoSummaryJobList["+ i +"].CreationTime");
				aIVideoSummaryJob.Data = context.StringValue("ListAIVideoSummaryJob.AIVideoSummaryJobList["+ i +"].Data");

				listAIVideoSummaryJobResponse_aIVideoSummaryJobList.Add(aIVideoSummaryJob);
			}
			listAIVideoSummaryJobResponse.AIVideoSummaryJobList = listAIVideoSummaryJobResponse_aIVideoSummaryJobList;
        
			return listAIVideoSummaryJobResponse;
        }
    }
}