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
    public class GetAIMediaAuditJobResponseUnmarshaller
    {
        public static GetAIMediaAuditJobResponse Unmarshall(UnmarshallerContext context)
        {
			GetAIMediaAuditJobResponse getAIMediaAuditJobResponse = new GetAIMediaAuditJobResponse();

			getAIMediaAuditJobResponse.HttpResponse = context.HttpResponse;
			getAIMediaAuditJobResponse.RequestId = context.StringValue("GetAIMediaAuditJob.RequestId");

			GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob mediaAuditJob = new GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob();
			mediaAuditJob.JobId = context.StringValue("GetAIMediaAuditJob.MediaAuditJob.JobId");
			mediaAuditJob.MediaId = context.StringValue("GetAIMediaAuditJob.MediaAuditJob.MediaId");
			mediaAuditJob.Type = context.StringValue("GetAIMediaAuditJob.MediaAuditJob.Type");
			mediaAuditJob.Status = context.StringValue("GetAIMediaAuditJob.MediaAuditJob.Status");
			mediaAuditJob.Code = context.StringValue("GetAIMediaAuditJob.MediaAuditJob.Code");
			mediaAuditJob.Message = context.StringValue("GetAIMediaAuditJob.MediaAuditJob.Message");
			mediaAuditJob.CreationTime = context.StringValue("GetAIMediaAuditJob.MediaAuditJob.CreationTime");
			mediaAuditJob.CompleteTime = context.StringValue("GetAIMediaAuditJob.MediaAuditJob.CompleteTime");

			GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data data = new GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data();
			data.Suggestion = context.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.Suggestion");
			data.AbnormalModules = context.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.AbnormalModules");
			data.Label = context.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.Label");

			GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_VideoResult videoResult = new GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_VideoResult();
			videoResult.Suggestion = context.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.Suggestion");
			videoResult.Label = context.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.Label");

			GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_VideoResult.GetAIMediaAuditJob_TerrorismResult terrorismResult = new GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_VideoResult.GetAIMediaAuditJob_TerrorismResult();
			terrorismResult.Suggestion = context.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.TerrorismResult.Suggestion");
			terrorismResult.Label = context.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.TerrorismResult.Label");
			terrorismResult.MaxScore = context.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.TerrorismResult.MaxScore");
			terrorismResult.AverageScore = context.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.TerrorismResult.AverageScore");

			List<GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_VideoResult.GetAIMediaAuditJob_TerrorismResult.GetAIMediaAuditJob_CounterListItem> terrorismResult_counterList = new List<GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_VideoResult.GetAIMediaAuditJob_TerrorismResult.GetAIMediaAuditJob_CounterListItem>();
			for (int i = 0; i < context.Length("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.TerrorismResult.CounterList.Length"); i++) {
				GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_VideoResult.GetAIMediaAuditJob_TerrorismResult.GetAIMediaAuditJob_CounterListItem counterListItem = new GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_VideoResult.GetAIMediaAuditJob_TerrorismResult.GetAIMediaAuditJob_CounterListItem();
				counterListItem.Label = context.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.TerrorismResult.CounterList["+ i +"].Label");
				counterListItem.Count = context.IntegerValue("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.TerrorismResult.CounterList["+ i +"].Count");

				terrorismResult_counterList.Add(counterListItem);
			}
			terrorismResult.CounterList = terrorismResult_counterList;

			List<GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_VideoResult.GetAIMediaAuditJob_TerrorismResult.GetAIMediaAuditJob_TopListItem> terrorismResult_topList = new List<GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_VideoResult.GetAIMediaAuditJob_TerrorismResult.GetAIMediaAuditJob_TopListItem>();
			for (int i = 0; i < context.Length("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.TerrorismResult.TopList.Length"); i++) {
				GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_VideoResult.GetAIMediaAuditJob_TerrorismResult.GetAIMediaAuditJob_TopListItem topListItem = new GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_VideoResult.GetAIMediaAuditJob_TerrorismResult.GetAIMediaAuditJob_TopListItem();
				topListItem.Label = context.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.TerrorismResult.TopList["+ i +"].Label");
				topListItem.Score = context.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.TerrorismResult.TopList["+ i +"].Score");
				topListItem.Timestamp = context.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.TerrorismResult.TopList["+ i +"].Timestamp");
				topListItem.Url = context.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.TerrorismResult.TopList["+ i +"].Url");

				terrorismResult_topList.Add(topListItem);
			}
			terrorismResult.TopList = terrorismResult_topList;
			videoResult.TerrorismResult = terrorismResult;

			GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_VideoResult.GetAIMediaAuditJob_PornResult pornResult = new GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_VideoResult.GetAIMediaAuditJob_PornResult();
			pornResult.Suggestion = context.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.PornResult.Suggestion");
			pornResult.Label = context.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.PornResult.Label");
			pornResult.MaxScore = context.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.PornResult.MaxScore");
			pornResult.AverageScore = context.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.PornResult.AverageScore");

			List<GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_VideoResult.GetAIMediaAuditJob_PornResult.GetAIMediaAuditJob_CounterListItem3> pornResult_counterList1 = new List<GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_VideoResult.GetAIMediaAuditJob_PornResult.GetAIMediaAuditJob_CounterListItem3>();
			for (int i = 0; i < context.Length("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.PornResult.CounterList.Length"); i++) {
				GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_VideoResult.GetAIMediaAuditJob_PornResult.GetAIMediaAuditJob_CounterListItem3 counterListItem3 = new GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_VideoResult.GetAIMediaAuditJob_PornResult.GetAIMediaAuditJob_CounterListItem3();
				counterListItem3.Label = context.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.PornResult.CounterList["+ i +"].Label");
				counterListItem3.Count = context.IntegerValue("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.PornResult.CounterList["+ i +"].Count");

				pornResult_counterList1.Add(counterListItem3);
			}
			pornResult.CounterList1 = pornResult_counterList1;

			List<GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_VideoResult.GetAIMediaAuditJob_PornResult.GetAIMediaAuditJob_TopListItem4> pornResult_topList2 = new List<GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_VideoResult.GetAIMediaAuditJob_PornResult.GetAIMediaAuditJob_TopListItem4>();
			for (int i = 0; i < context.Length("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.PornResult.TopList.Length"); i++) {
				GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_VideoResult.GetAIMediaAuditJob_PornResult.GetAIMediaAuditJob_TopListItem4 topListItem4 = new GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_VideoResult.GetAIMediaAuditJob_PornResult.GetAIMediaAuditJob_TopListItem4();
				topListItem4.Label = context.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.PornResult.TopList["+ i +"].Label");
				topListItem4.Score = context.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.PornResult.TopList["+ i +"].Score");
				topListItem4.Timestamp = context.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.PornResult.TopList["+ i +"].Timestamp");
				topListItem4.Url = context.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.PornResult.TopList["+ i +"].Url");

				pornResult_topList2.Add(topListItem4);
			}
			pornResult.TopList2 = pornResult_topList2;
			videoResult.PornResult = pornResult;
			data.VideoResult = videoResult;

			List<GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_ImageResultItem> data_imageResult = new List<GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_ImageResultItem>();
			for (int i = 0; i < context.Length("GetAIMediaAuditJob.MediaAuditJob.Data.ImageResult.Length"); i++) {
				GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_ImageResultItem imageResultItem = new GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_ImageResultItem();
				imageResultItem.Suggestion = context.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.ImageResult["+ i +"].Suggestion");
				imageResultItem.Label = context.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.ImageResult["+ i +"].Label");
				imageResultItem.Type = context.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.ImageResult["+ i +"].Type");
				imageResultItem.Url = context.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.ImageResult["+ i +"].Url");

				List<GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_ImageResultItem.GetAIMediaAuditJob_ResultItem> imageResultItem_result = new List<GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_ImageResultItem.GetAIMediaAuditJob_ResultItem>();
				for (int j = 0; j < context.Length("GetAIMediaAuditJob.MediaAuditJob.Data.ImageResult["+ i +"].Result.Length"); j++) {
					GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_ImageResultItem.GetAIMediaAuditJob_ResultItem resultItem = new GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_ImageResultItem.GetAIMediaAuditJob_ResultItem();
					resultItem.Suggestion = context.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.ImageResult["+ i +"].Result["+ j +"].Suggestion");
					resultItem.Label = context.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.ImageResult["+ i +"].Result["+ j +"].Label");
					resultItem.Score = context.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.ImageResult["+ i +"].Result["+ j +"].Score");
					resultItem.Scene = context.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.ImageResult["+ i +"].Result["+ j +"].Scene");

					imageResultItem_result.Add(resultItem);
				}
				imageResultItem.Result = imageResultItem_result;

				data_imageResult.Add(imageResultItem);
			}
			data.ImageResult = data_imageResult;

			List<GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_TextResultItem> data_textResult = new List<GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_TextResultItem>();
			for (int i = 0; i < context.Length("GetAIMediaAuditJob.MediaAuditJob.Data.TextResult.Length"); i++) {
				GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_TextResultItem textResultItem = new GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_TextResultItem();
				textResultItem.Suggestion = context.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.TextResult["+ i +"].Suggestion");
				textResultItem.Label = context.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.TextResult["+ i +"].Label");
				textResultItem.Score = context.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.TextResult["+ i +"].Score");
				textResultItem.Scene = context.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.TextResult["+ i +"].Scene");
				textResultItem.Type = context.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.TextResult["+ i +"].Type");
				textResultItem.Content = context.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.TextResult["+ i +"].Content");

				data_textResult.Add(textResultItem);
			}
			data.TextResult = data_textResult;
			mediaAuditJob.Data = data;
			getAIMediaAuditJobResponse.MediaAuditJob = mediaAuditJob;
        
			return getAIMediaAuditJobResponse;
        }
    }
}