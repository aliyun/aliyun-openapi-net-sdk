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
    public class ListAIVideoCoverJobResponseUnmarshaller
    {
        public static ListAIVideoCoverJobResponse Unmarshall(UnmarshallerContext context)
        {
			ListAIVideoCoverJobResponse listAIVideoCoverJobResponse = new ListAIVideoCoverJobResponse();

			listAIVideoCoverJobResponse.HttpResponse = context.HttpResponse;
			listAIVideoCoverJobResponse.RequestId = context.StringValue("ListAIVideoCoverJob.RequestId");

			List<string> listAIVideoCoverJobResponse_nonExistAIVideoCoverJobIds = new List<string>();
			for (int i = 0; i < context.Length("ListAIVideoCoverJob.NonExistAIVideoCoverJobIds.Length"); i++) {
				listAIVideoCoverJobResponse_nonExistAIVideoCoverJobIds.Add(context.StringValue("ListAIVideoCoverJob.NonExistAIVideoCoverJobIds["+ i +"]"));
			}
			listAIVideoCoverJobResponse.NonExistAIVideoCoverJobIds = listAIVideoCoverJobResponse_nonExistAIVideoCoverJobIds;

			List<ListAIVideoCoverJobResponse.ListAIVideoCoverJob_AIVideoCoverJob> listAIVideoCoverJobResponse_aIVideoCoverJobList = new List<ListAIVideoCoverJobResponse.ListAIVideoCoverJob_AIVideoCoverJob>();
			for (int i = 0; i < context.Length("ListAIVideoCoverJob.AIVideoCoverJobList.Length"); i++) {
				ListAIVideoCoverJobResponse.ListAIVideoCoverJob_AIVideoCoverJob aIVideoCoverJob = new ListAIVideoCoverJobResponse.ListAIVideoCoverJob_AIVideoCoverJob();
				aIVideoCoverJob.JobId = context.StringValue("ListAIVideoCoverJob.AIVideoCoverJobList["+ i +"].JobId");
				aIVideoCoverJob.MediaId = context.StringValue("ListAIVideoCoverJob.AIVideoCoverJobList["+ i +"].MediaId");
				aIVideoCoverJob.Status = context.StringValue("ListAIVideoCoverJob.AIVideoCoverJobList["+ i +"].Status");
				aIVideoCoverJob.Code = context.StringValue("ListAIVideoCoverJob.AIVideoCoverJobList["+ i +"].Code");
				aIVideoCoverJob.Message = context.StringValue("ListAIVideoCoverJob.AIVideoCoverJobList["+ i +"].Message");
				aIVideoCoverJob.CreationTime = context.StringValue("ListAIVideoCoverJob.AIVideoCoverJobList["+ i +"].CreationTime");
				aIVideoCoverJob.Data = context.StringValue("ListAIVideoCoverJob.AIVideoCoverJobList["+ i +"].Data");

				listAIVideoCoverJobResponse_aIVideoCoverJobList.Add(aIVideoCoverJob);
			}
			listAIVideoCoverJobResponse.AIVideoCoverJobList = listAIVideoCoverJobResponse_aIVideoCoverJobList;
        
			return listAIVideoCoverJobResponse;
        }
    }
}