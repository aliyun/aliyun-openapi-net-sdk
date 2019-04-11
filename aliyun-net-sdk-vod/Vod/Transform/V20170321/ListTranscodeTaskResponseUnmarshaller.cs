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
    public class ListTranscodeTaskResponseUnmarshaller
    {
        public static ListTranscodeTaskResponse Unmarshall(UnmarshallerContext context)
        {
			ListTranscodeTaskResponse listTranscodeTaskResponse = new ListTranscodeTaskResponse();

			listTranscodeTaskResponse.HttpResponse = context.HttpResponse;
			listTranscodeTaskResponse.RequestId = context.StringValue("ListTranscodeTask.RequestId");

			List<ListTranscodeTaskResponse.ListTranscodeTask_TranscodeTask> listTranscodeTaskResponse_transcodeTaskList = new List<ListTranscodeTaskResponse.ListTranscodeTask_TranscodeTask>();
			for (int i = 0; i < context.Length("ListTranscodeTask.TranscodeTaskList.Length"); i++) {
				ListTranscodeTaskResponse.ListTranscodeTask_TranscodeTask transcodeTask = new ListTranscodeTaskResponse.ListTranscodeTask_TranscodeTask();
				transcodeTask.TranscodeTaskId = context.StringValue("ListTranscodeTask.TranscodeTaskList["+ i +"].TranscodeTaskId");
				transcodeTask.VideoId = context.StringValue("ListTranscodeTask.TranscodeTaskList["+ i +"].VideoId");
				transcodeTask.TaskStatus = context.StringValue("ListTranscodeTask.TranscodeTaskList["+ i +"].TaskStatus");
				transcodeTask.TranscodeTemplateGroupId = context.StringValue("ListTranscodeTask.TranscodeTaskList["+ i +"].TranscodeTemplateGroupId");
				transcodeTask.CreationTime = context.StringValue("ListTranscodeTask.TranscodeTaskList["+ i +"].CreationTime");
				transcodeTask.CompleteTime = context.StringValue("ListTranscodeTask.TranscodeTaskList["+ i +"].CompleteTime");
				transcodeTask.Trigger = context.StringValue("ListTranscodeTask.TranscodeTaskList["+ i +"].Trigger");

				listTranscodeTaskResponse_transcodeTaskList.Add(transcodeTask);
			}
			listTranscodeTaskResponse.TranscodeTaskList = listTranscodeTaskResponse_transcodeTaskList;
        
			return listTranscodeTaskResponse;
        }
    }
}
