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
using Aliyun.Acs.avatar.Model.V20220130;

namespace Aliyun.Acs.avatar.Transform.V20220130
{
    public class QueryVideoTaskInfoResponseUnmarshaller
    {
        public static QueryVideoTaskInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryVideoTaskInfoResponse queryVideoTaskInfoResponse = new QueryVideoTaskInfoResponse();

			queryVideoTaskInfoResponse.HttpResponse = _ctx.HttpResponse;
			queryVideoTaskInfoResponse.RequestId = _ctx.StringValue("QueryVideoTaskInfo.RequestId");
			queryVideoTaskInfoResponse.Success = _ctx.BooleanValue("QueryVideoTaskInfo.Success");
			queryVideoTaskInfoResponse.Code = _ctx.StringValue("QueryVideoTaskInfo.Code");
			queryVideoTaskInfoResponse.Message = _ctx.StringValue("QueryVideoTaskInfo.Message");

			QueryVideoTaskInfoResponse.QueryVideoTaskInfo_Data data = new QueryVideoTaskInfoResponse.QueryVideoTaskInfo_Data();
			data.PageNo = _ctx.IntegerValue("QueryVideoTaskInfo.Data.PageNo");
			data.PageSize = _ctx.IntegerValue("QueryVideoTaskInfo.Data.PageSize");
			data.TotalCount = _ctx.LongValue("QueryVideoTaskInfo.Data.TotalCount");

			List<QueryVideoTaskInfoResponse.QueryVideoTaskInfo_Data.QueryVideoTaskInfo_ListItem> data_list = new List<QueryVideoTaskInfoResponse.QueryVideoTaskInfo_Data.QueryVideoTaskInfo_ListItem>();
			for (int i = 0; i < _ctx.Length("QueryVideoTaskInfo.Data.List.Length"); i++) {
				QueryVideoTaskInfoResponse.QueryVideoTaskInfo_Data.QueryVideoTaskInfo_ListItem listItem = new QueryVideoTaskInfoResponse.QueryVideoTaskInfo_Data.QueryVideoTaskInfo_ListItem();
				listItem.TaskUuid = _ctx.StringValue("QueryVideoTaskInfo.Data.List["+ i +"].TaskUuid");
				listItem.Title = _ctx.StringValue("QueryVideoTaskInfo.Data.List["+ i +"].Title");
				listItem.Type = _ctx.IntegerValue("QueryVideoTaskInfo.Data.List["+ i +"].Type");
				listItem.Status = _ctx.IntegerValue("QueryVideoTaskInfo.Data.List["+ i +"].Status");

				QueryVideoTaskInfoResponse.QueryVideoTaskInfo_Data.QueryVideoTaskInfo_ListItem.QueryVideoTaskInfo_TaskResult taskResult = new QueryVideoTaskInfoResponse.QueryVideoTaskInfo_Data.QueryVideoTaskInfo_ListItem.QueryVideoTaskInfo_TaskResult();
				taskResult.VideoUrl = _ctx.StringValue("QueryVideoTaskInfo.Data.List["+ i +"].TaskResult.VideoUrl");
				taskResult.SubtitlesUrl = _ctx.StringValue("QueryVideoTaskInfo.Data.List["+ i +"].TaskResult.SubtitlesUrl");
				taskResult.WordSubtitlesUrl = _ctx.StringValue("QueryVideoTaskInfo.Data.List["+ i +"].TaskResult.WordSubtitlesUrl");
				taskResult.VideoDuration = _ctx.IntegerValue("QueryVideoTaskInfo.Data.List["+ i +"].TaskResult.VideoDuration");
				taskResult.FailReason = _ctx.StringValue("QueryVideoTaskInfo.Data.List["+ i +"].TaskResult.FailReason");
				taskResult.FailCode = _ctx.StringValue("QueryVideoTaskInfo.Data.List["+ i +"].TaskResult.FailCode");
				taskResult.AlphaUrl = _ctx.StringValue("QueryVideoTaskInfo.Data.List["+ i +"].TaskResult.AlphaUrl");
				taskResult.PreviewPic = _ctx.StringValue("QueryVideoTaskInfo.Data.List["+ i +"].TaskResult.PreviewPic");
				listItem.TaskResult = taskResult;

				data_list.Add(listItem);
			}
			data.List = data_list;
			queryVideoTaskInfoResponse.Data = data;
        
			return queryVideoTaskInfoResponse;
        }
    }
}
