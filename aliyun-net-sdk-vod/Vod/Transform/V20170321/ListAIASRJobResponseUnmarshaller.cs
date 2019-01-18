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
    public class ListAIASRJobResponseUnmarshaller
    {
        public static ListAIASRJobResponse Unmarshall(UnmarshallerContext context)
        {
			ListAIASRJobResponse listAIASRJobResponse = new ListAIASRJobResponse();

			listAIASRJobResponse.HttpResponse = context.HttpResponse;
			listAIASRJobResponse.RequestId = context.StringValue("ListAIASRJob.RequestId");

			List<string> listAIASRJobResponse_nonExistAIASRJobIds = new List<string>();
			for (int i = 0; i < context.Length("ListAIASRJob.NonExistAIASRJobIds.Length"); i++) {
				listAIASRJobResponse_nonExistAIASRJobIds.Add(context.StringValue("ListAIASRJob.NonExistAIASRJobIds["+ i +"]"));
			}
			listAIASRJobResponse.NonExistAIASRJobIds = listAIASRJobResponse_nonExistAIASRJobIds;

			List<ListAIASRJobResponse.ListAIASRJob_AIASRJob> listAIASRJobResponse_aIASRJobList = new List<ListAIASRJobResponse.ListAIASRJob_AIASRJob>();
			for (int i = 0; i < context.Length("ListAIASRJob.AIASRJobList.Length"); i++) {
				ListAIASRJobResponse.ListAIASRJob_AIASRJob aIASRJob = new ListAIASRJobResponse.ListAIASRJob_AIASRJob();
				aIASRJob.JobId = context.StringValue("ListAIASRJob.AIASRJobList["+ i +"].JobId");
				aIASRJob.MediaId = context.StringValue("ListAIASRJob.AIASRJobList["+ i +"].MediaId");
				aIASRJob.Status = context.StringValue("ListAIASRJob.AIASRJobList["+ i +"].Status");
				aIASRJob.Code = context.StringValue("ListAIASRJob.AIASRJobList["+ i +"].Code");
				aIASRJob.Message = context.StringValue("ListAIASRJob.AIASRJobList["+ i +"].Message");
				aIASRJob.CreationTime = context.StringValue("ListAIASRJob.AIASRJobList["+ i +"].CreationTime");
				aIASRJob.Data = context.StringValue("ListAIASRJob.AIASRJobList["+ i +"].Data");

				listAIASRJobResponse_aIASRJobList.Add(aIASRJob);
			}
			listAIASRJobResponse.AIASRJobList = listAIASRJobResponse_aIASRJobList;
        
			return listAIASRJobResponse;
        }
    }
}