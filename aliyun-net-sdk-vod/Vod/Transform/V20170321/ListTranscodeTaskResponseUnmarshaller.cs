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
        public static ListTranscodeTaskResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListTranscodeTaskResponse listTranscodeTaskResponse = new ListTranscodeTaskResponse();

			listTranscodeTaskResponse.HttpResponse = _ctx.HttpResponse;
			listTranscodeTaskResponse.RequestId = _ctx.StringValue("ListTranscodeTask.RequestId");

			List<ListTranscodeTaskResponse.ListTranscodeTask_TranscodeTask> listTranscodeTaskResponse_transcodeTaskList = new List<ListTranscodeTaskResponse.ListTranscodeTask_TranscodeTask>();
			for (int i = 0; i < _ctx.Length("ListTranscodeTask.TranscodeTaskList.Length"); i++) {
				ListTranscodeTaskResponse.ListTranscodeTask_TranscodeTask transcodeTask = new ListTranscodeTaskResponse.ListTranscodeTask_TranscodeTask();
				transcodeTask.CreationTime = _ctx.StringValue("ListTranscodeTask.TranscodeTaskList["+ i +"].CreationTime");
				transcodeTask.Trigger = _ctx.StringValue("ListTranscodeTask.TranscodeTaskList["+ i +"].Trigger");
				transcodeTask.TaskStatus = _ctx.StringValue("ListTranscodeTask.TranscodeTaskList["+ i +"].TaskStatus");
				transcodeTask.VideoId = _ctx.StringValue("ListTranscodeTask.TranscodeTaskList["+ i +"].VideoId");
				transcodeTask.CompleteTime = _ctx.StringValue("ListTranscodeTask.TranscodeTaskList["+ i +"].CompleteTime");
				transcodeTask.TranscodeTemplateGroupId = _ctx.StringValue("ListTranscodeTask.TranscodeTaskList["+ i +"].TranscodeTemplateGroupId");
				transcodeTask.TranscodeTaskId = _ctx.StringValue("ListTranscodeTask.TranscodeTaskList["+ i +"].TranscodeTaskId");

				listTranscodeTaskResponse_transcodeTaskList.Add(transcodeTask);
			}
			listTranscodeTaskResponse.TranscodeTaskList = listTranscodeTaskResponse_transcodeTaskList;
        
			return listTranscodeTaskResponse;
        }
    }
}
