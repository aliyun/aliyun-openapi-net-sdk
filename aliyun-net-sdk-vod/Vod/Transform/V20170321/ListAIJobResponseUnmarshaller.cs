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
using Aliyun.Acs.vod.Model.V20170321;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class ListAIJobResponseUnmarshaller
    {
        public static ListAIJobResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListAIJobResponse listAIJobResponse = new ListAIJobResponse();

			listAIJobResponse.HttpResponse = _ctx.HttpResponse;
			listAIJobResponse.RequestId = _ctx.StringValue("ListAIJob.RequestId");

			List<string> listAIJobResponse_nonExistAIJobIds = new List<string>();
			for (int i = 0; i < _ctx.Length("ListAIJob.NonExistAIJobIds.Length"); i++) {
				listAIJobResponse_nonExistAIJobIds.Add(_ctx.StringValue("ListAIJob.NonExistAIJobIds["+ i +"]"));
			}
			listAIJobResponse.NonExistAIJobIds = listAIJobResponse_nonExistAIJobIds;

			List<ListAIJobResponse.ListAIJob_AIJob> listAIJobResponse_aIJobList = new List<ListAIJobResponse.ListAIJob_AIJob>();
			for (int i = 0; i < _ctx.Length("ListAIJob.AIJobList.Length"); i++) {
				ListAIJobResponse.ListAIJob_AIJob aIJob = new ListAIJobResponse.ListAIJob_AIJob();
				aIJob.CreationTime = _ctx.StringValue("ListAIJob.AIJobList["+ i +"].CreationTime");
				aIJob.Status = _ctx.StringValue("ListAIJob.AIJobList["+ i +"].Status");
				aIJob.Type = _ctx.StringValue("ListAIJob.AIJobList["+ i +"].Type");
				aIJob.Data = _ctx.StringValue("ListAIJob.AIJobList["+ i +"].Data");
				aIJob.CompleteTime = _ctx.StringValue("ListAIJob.AIJobList["+ i +"].CompleteTime");
				aIJob.JobId = _ctx.StringValue("ListAIJob.AIJobList["+ i +"].JobId");
				aIJob.Code = _ctx.StringValue("ListAIJob.AIJobList["+ i +"].Code");
				aIJob.Message = _ctx.StringValue("ListAIJob.AIJobList["+ i +"].Message");
				aIJob.MediaId = _ctx.StringValue("ListAIJob.AIJobList["+ i +"].MediaId");

				listAIJobResponse_aIJobList.Add(aIJob);
			}
			listAIJobResponse.AIJobList = listAIJobResponse_aIJobList;
        
			return listAIJobResponse;
        }
    }
}
