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
    public class ListAIVideoPornRecogJobResponseUnmarshaller
    {
        public static ListAIVideoPornRecogJobResponse Unmarshall(UnmarshallerContext context)
        {
			ListAIVideoPornRecogJobResponse listAIVideoPornRecogJobResponse = new ListAIVideoPornRecogJobResponse();

			listAIVideoPornRecogJobResponse.HttpResponse = context.HttpResponse;
			listAIVideoPornRecogJobResponse.RequestId = context.StringValue("ListAIVideoPornRecogJob.RequestId");

			List<string> listAIVideoPornRecogJobResponse_nonExistPornRecogJobIds = new List<string>();
			for (int i = 0; i < context.Length("ListAIVideoPornRecogJob.NonExistPornRecogJobIds.Length"); i++) {
				listAIVideoPornRecogJobResponse_nonExistPornRecogJobIds.Add(context.StringValue("ListAIVideoPornRecogJob.NonExistPornRecogJobIds["+ i +"]"));
			}
			listAIVideoPornRecogJobResponse.NonExistPornRecogJobIds = listAIVideoPornRecogJobResponse_nonExistPornRecogJobIds;

			List<ListAIVideoPornRecogJobResponse.ListAIVideoPornRecogJob_AIVideoPornRecogJob> listAIVideoPornRecogJobResponse_aIVideoPornRecogJobList = new List<ListAIVideoPornRecogJobResponse.ListAIVideoPornRecogJob_AIVideoPornRecogJob>();
			for (int i = 0; i < context.Length("ListAIVideoPornRecogJob.AIVideoPornRecogJobList.Length"); i++) {
				ListAIVideoPornRecogJobResponse.ListAIVideoPornRecogJob_AIVideoPornRecogJob aIVideoPornRecogJob = new ListAIVideoPornRecogJobResponse.ListAIVideoPornRecogJob_AIVideoPornRecogJob();
				aIVideoPornRecogJob.JobId = context.StringValue("ListAIVideoPornRecogJob.AIVideoPornRecogJobList["+ i +"].JobId");
				aIVideoPornRecogJob.MediaId = context.StringValue("ListAIVideoPornRecogJob.AIVideoPornRecogJobList["+ i +"].MediaId");
				aIVideoPornRecogJob.Status = context.StringValue("ListAIVideoPornRecogJob.AIVideoPornRecogJobList["+ i +"].Status");
				aIVideoPornRecogJob.Code = context.StringValue("ListAIVideoPornRecogJob.AIVideoPornRecogJobList["+ i +"].Code");
				aIVideoPornRecogJob.Message = context.StringValue("ListAIVideoPornRecogJob.AIVideoPornRecogJobList["+ i +"].Message");
				aIVideoPornRecogJob.CreationTime = context.StringValue("ListAIVideoPornRecogJob.AIVideoPornRecogJobList["+ i +"].CreationTime");
				aIVideoPornRecogJob.Data = context.StringValue("ListAIVideoPornRecogJob.AIVideoPornRecogJobList["+ i +"].Data");

				listAIVideoPornRecogJobResponse_aIVideoPornRecogJobList.Add(aIVideoPornRecogJob);
			}
			listAIVideoPornRecogJobResponse.AIVideoPornRecogJobList = listAIVideoPornRecogJobResponse_aIVideoPornRecogJobList;
        
			return listAIVideoPornRecogJobResponse;
        }
    }
}