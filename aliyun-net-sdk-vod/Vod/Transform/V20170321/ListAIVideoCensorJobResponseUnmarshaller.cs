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
    public class ListAIVideoCensorJobResponseUnmarshaller
    {
        public static ListAIVideoCensorJobResponse Unmarshall(UnmarshallerContext context)
        {
			ListAIVideoCensorJobResponse listAIVideoCensorJobResponse = new ListAIVideoCensorJobResponse();

			listAIVideoCensorJobResponse.HttpResponse = context.HttpResponse;
			listAIVideoCensorJobResponse.RequestId = context.StringValue("ListAIVideoCensorJob.RequestId");

			List<string> listAIVideoCensorJobResponse_nonExistAIVideoCensorJobIds = new List<string>();
			for (int i = 0; i < context.Length("ListAIVideoCensorJob.NonExistAIVideoCensorJobIds.Length"); i++) {
				listAIVideoCensorJobResponse_nonExistAIVideoCensorJobIds.Add(context.StringValue("ListAIVideoCensorJob.NonExistAIVideoCensorJobIds["+ i +"]"));
			}
			listAIVideoCensorJobResponse.NonExistAIVideoCensorJobIds = listAIVideoCensorJobResponse_nonExistAIVideoCensorJobIds;

			List<ListAIVideoCensorJobResponse.ListAIVideoCensorJob_AIVideoCensorJob> listAIVideoCensorJobResponse_aIVideoCensorJobList = new List<ListAIVideoCensorJobResponse.ListAIVideoCensorJob_AIVideoCensorJob>();
			for (int i = 0; i < context.Length("ListAIVideoCensorJob.AIVideoCensorJobList.Length"); i++) {
				ListAIVideoCensorJobResponse.ListAIVideoCensorJob_AIVideoCensorJob aIVideoCensorJob = new ListAIVideoCensorJobResponse.ListAIVideoCensorJob_AIVideoCensorJob();
				aIVideoCensorJob.JobId = context.StringValue("ListAIVideoCensorJob.AIVideoCensorJobList["+ i +"].JobId");
				aIVideoCensorJob.MediaId = context.StringValue("ListAIVideoCensorJob.AIVideoCensorJobList["+ i +"].MediaId");
				aIVideoCensorJob.Status = context.StringValue("ListAIVideoCensorJob.AIVideoCensorJobList["+ i +"].Status");
				aIVideoCensorJob.Code = context.StringValue("ListAIVideoCensorJob.AIVideoCensorJobList["+ i +"].Code");
				aIVideoCensorJob.Message = context.StringValue("ListAIVideoCensorJob.AIVideoCensorJobList["+ i +"].Message");
				aIVideoCensorJob.CreationTime = context.StringValue("ListAIVideoCensorJob.AIVideoCensorJobList["+ i +"].CreationTime");
				aIVideoCensorJob.Data = context.StringValue("ListAIVideoCensorJob.AIVideoCensorJobList["+ i +"].Data");

				listAIVideoCensorJobResponse_aIVideoCensorJobList.Add(aIVideoCensorJob);
			}
			listAIVideoCensorJobResponse.AIVideoCensorJobList = listAIVideoCensorJobResponse_aIVideoCensorJobList;
        
			return listAIVideoCensorJobResponse;
        }
    }
}