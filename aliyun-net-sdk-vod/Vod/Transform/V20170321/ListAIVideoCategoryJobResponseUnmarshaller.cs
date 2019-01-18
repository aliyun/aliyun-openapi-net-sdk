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
    public class ListAIVideoCategoryJobResponseUnmarshaller
    {
        public static ListAIVideoCategoryJobResponse Unmarshall(UnmarshallerContext context)
        {
			ListAIVideoCategoryJobResponse listAIVideoCategoryJobResponse = new ListAIVideoCategoryJobResponse();

			listAIVideoCategoryJobResponse.HttpResponse = context.HttpResponse;
			listAIVideoCategoryJobResponse.RequestId = context.StringValue("ListAIVideoCategoryJob.RequestId");

			List<string> listAIVideoCategoryJobResponse_nonExistAIVideoCategoryJobIds = new List<string>();
			for (int i = 0; i < context.Length("ListAIVideoCategoryJob.NonExistAIVideoCategoryJobIds.Length"); i++) {
				listAIVideoCategoryJobResponse_nonExistAIVideoCategoryJobIds.Add(context.StringValue("ListAIVideoCategoryJob.NonExistAIVideoCategoryJobIds["+ i +"]"));
			}
			listAIVideoCategoryJobResponse.NonExistAIVideoCategoryJobIds = listAIVideoCategoryJobResponse_nonExistAIVideoCategoryJobIds;

			List<ListAIVideoCategoryJobResponse.ListAIVideoCategoryJob_AIVideoCategoryJob> listAIVideoCategoryJobResponse_aIVideoCategoryJobList = new List<ListAIVideoCategoryJobResponse.ListAIVideoCategoryJob_AIVideoCategoryJob>();
			for (int i = 0; i < context.Length("ListAIVideoCategoryJob.AIVideoCategoryJobList.Length"); i++) {
				ListAIVideoCategoryJobResponse.ListAIVideoCategoryJob_AIVideoCategoryJob aIVideoCategoryJob = new ListAIVideoCategoryJobResponse.ListAIVideoCategoryJob_AIVideoCategoryJob();
				aIVideoCategoryJob.JobId = context.StringValue("ListAIVideoCategoryJob.AIVideoCategoryJobList["+ i +"].JobId");
				aIVideoCategoryJob.MediaId = context.StringValue("ListAIVideoCategoryJob.AIVideoCategoryJobList["+ i +"].MediaId");
				aIVideoCategoryJob.Status = context.StringValue("ListAIVideoCategoryJob.AIVideoCategoryJobList["+ i +"].Status");
				aIVideoCategoryJob.Code = context.StringValue("ListAIVideoCategoryJob.AIVideoCategoryJobList["+ i +"].Code");
				aIVideoCategoryJob.Message = context.StringValue("ListAIVideoCategoryJob.AIVideoCategoryJobList["+ i +"].Message");
				aIVideoCategoryJob.CreationTime = context.StringValue("ListAIVideoCategoryJob.AIVideoCategoryJobList["+ i +"].CreationTime");
				aIVideoCategoryJob.Data = context.StringValue("ListAIVideoCategoryJob.AIVideoCategoryJobList["+ i +"].Data");

				listAIVideoCategoryJobResponse_aIVideoCategoryJobList.Add(aIVideoCategoryJob);
			}
			listAIVideoCategoryJobResponse.AIVideoCategoryJobList = listAIVideoCategoryJobResponse_aIVideoCategoryJobList;
        
			return listAIVideoCategoryJobResponse;
        }
    }
}