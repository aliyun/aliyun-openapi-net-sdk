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
    public class ListAIVideoTerrorismRecogJobResponseUnmarshaller
    {
        public static ListAIVideoTerrorismRecogJobResponse Unmarshall(UnmarshallerContext context)
        {
			ListAIVideoTerrorismRecogJobResponse listAIVideoTerrorismRecogJobResponse = new ListAIVideoTerrorismRecogJobResponse();

			listAIVideoTerrorismRecogJobResponse.HttpResponse = context.HttpResponse;
			listAIVideoTerrorismRecogJobResponse.RequestId = context.StringValue("ListAIVideoTerrorismRecogJob.RequestId");

			List<string> listAIVideoTerrorismRecogJobResponse_nonExistTerrorismRecogJobIds = new List<string>();
			for (int i = 0; i < context.Length("ListAIVideoTerrorismRecogJob.NonExistTerrorismRecogJobIds.Length"); i++) {
				listAIVideoTerrorismRecogJobResponse_nonExistTerrorismRecogJobIds.Add(context.StringValue("ListAIVideoTerrorismRecogJob.NonExistTerrorismRecogJobIds["+ i +"]"));
			}
			listAIVideoTerrorismRecogJobResponse.NonExistTerrorismRecogJobIds = listAIVideoTerrorismRecogJobResponse_nonExistTerrorismRecogJobIds;

			List<ListAIVideoTerrorismRecogJobResponse.ListAIVideoTerrorismRecogJob_AIVideoTerrorismRecogJob> listAIVideoTerrorismRecogJobResponse_aIVideoTerrorismRecogJobList = new List<ListAIVideoTerrorismRecogJobResponse.ListAIVideoTerrorismRecogJob_AIVideoTerrorismRecogJob>();
			for (int i = 0; i < context.Length("ListAIVideoTerrorismRecogJob.AIVideoTerrorismRecogJobList.Length"); i++) {
				ListAIVideoTerrorismRecogJobResponse.ListAIVideoTerrorismRecogJob_AIVideoTerrorismRecogJob aIVideoTerrorismRecogJob = new ListAIVideoTerrorismRecogJobResponse.ListAIVideoTerrorismRecogJob_AIVideoTerrorismRecogJob();
				aIVideoTerrorismRecogJob.JobId = context.StringValue("ListAIVideoTerrorismRecogJob.AIVideoTerrorismRecogJobList["+ i +"].JobId");
				aIVideoTerrorismRecogJob.MediaId = context.StringValue("ListAIVideoTerrorismRecogJob.AIVideoTerrorismRecogJobList["+ i +"].MediaId");
				aIVideoTerrorismRecogJob.Status = context.StringValue("ListAIVideoTerrorismRecogJob.AIVideoTerrorismRecogJobList["+ i +"].Status");
				aIVideoTerrorismRecogJob.Code = context.StringValue("ListAIVideoTerrorismRecogJob.AIVideoTerrorismRecogJobList["+ i +"].Code");
				aIVideoTerrorismRecogJob.Message = context.StringValue("ListAIVideoTerrorismRecogJob.AIVideoTerrorismRecogJobList["+ i +"].Message");
				aIVideoTerrorismRecogJob.CreationTime = context.StringValue("ListAIVideoTerrorismRecogJob.AIVideoTerrorismRecogJobList["+ i +"].CreationTime");
				aIVideoTerrorismRecogJob.Data = context.StringValue("ListAIVideoTerrorismRecogJob.AIVideoTerrorismRecogJobList["+ i +"].Data");

				listAIVideoTerrorismRecogJobResponse_aIVideoTerrorismRecogJobList.Add(aIVideoTerrorismRecogJob);
			}
			listAIVideoTerrorismRecogJobResponse.AIVideoTerrorismRecogJobList = listAIVideoTerrorismRecogJobResponse_aIVideoTerrorismRecogJobList;
        
			return listAIVideoTerrorismRecogJobResponse;
        }
    }
}