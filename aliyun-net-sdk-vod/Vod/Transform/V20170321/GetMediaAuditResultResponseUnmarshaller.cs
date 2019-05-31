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
    public class GetMediaAuditResultResponseUnmarshaller
    {
        public static GetMediaAuditResultResponse Unmarshall(UnmarshallerContext context)
        {
			GetMediaAuditResultResponse getMediaAuditResultResponse = new GetMediaAuditResultResponse();

			getMediaAuditResultResponse.HttpResponse = context.HttpResponse;
			getMediaAuditResultResponse.RequestId = context.StringValue("GetMediaAuditResult.RequestId");

			GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult mediaAuditResult = new GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult();
			mediaAuditResult.AbnormalModules = context.StringValue("GetMediaAuditResult.MediaAuditResult.AbnormalModules");
			mediaAuditResult.Label = context.StringValue("GetMediaAuditResult.MediaAuditResult.Label");
			mediaAuditResult.Suggestion = context.StringValue("GetMediaAuditResult.MediaAuditResult.Suggestion");

			GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult videoResult = new GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult();
			videoResult.Suggestion = context.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.Suggestion");
			videoResult.Label = context.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.Label");

			GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_TerrorismResult terrorismResult = new GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_TerrorismResult();
			terrorismResult.Suggestion = context.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.TerrorismResult.Suggestion");
			terrorismResult.Label = context.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.TerrorismResult.Label");
			terrorismResult.MaxScore = context.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.TerrorismResult.MaxScore");
			terrorismResult.AverageScore = context.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.TerrorismResult.AverageScore");

			List<GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_TerrorismResult.GetMediaAuditResult_CounterListItem> terrorismResult_counterList = new List<GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_TerrorismResult.GetMediaAuditResult_CounterListItem>();
			for (int i = 0; i < context.Length("GetMediaAuditResult.MediaAuditResult.VideoResult.TerrorismResult.CounterList.Length"); i++) {
				GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_TerrorismResult.GetMediaAuditResult_CounterListItem counterListItem = new GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_TerrorismResult.GetMediaAuditResult_CounterListItem();
				counterListItem.Label = context.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.TerrorismResult.CounterList["+ i +"].Label");
				counterListItem.Count = context.IntegerValue("GetMediaAuditResult.MediaAuditResult.VideoResult.TerrorismResult.CounterList["+ i +"].Count");

				terrorismResult_counterList.Add(counterListItem);
			}
			terrorismResult.CounterList = terrorismResult_counterList;

			List<GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_TerrorismResult.GetMediaAuditResult_TopListItem> terrorismResult_topList = new List<GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_TerrorismResult.GetMediaAuditResult_TopListItem>();
			for (int i = 0; i < context.Length("GetMediaAuditResult.MediaAuditResult.VideoResult.TerrorismResult.TopList.Length"); i++) {
				GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_TerrorismResult.GetMediaAuditResult_TopListItem topListItem = new GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_TerrorismResult.GetMediaAuditResult_TopListItem();
				topListItem.Label = context.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.TerrorismResult.TopList["+ i +"].Label");
				topListItem.Score = context.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.TerrorismResult.TopList["+ i +"].Score");
				topListItem.Timestamp = context.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.TerrorismResult.TopList["+ i +"].Timestamp");
				topListItem.Url = context.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.TerrorismResult.TopList["+ i +"].Url");

				terrorismResult_topList.Add(topListItem);
			}
			terrorismResult.TopList = terrorismResult_topList;
			videoResult.TerrorismResult = terrorismResult;

			GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_PornResult pornResult = new GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_PornResult();
			pornResult.Suggestion = context.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.PornResult.Suggestion");
			pornResult.Label = context.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.PornResult.Label");
			pornResult.MaxScore = context.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.PornResult.MaxScore");
			pornResult.AverageScore = context.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.PornResult.AverageScore");

			List<GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_PornResult.GetMediaAuditResult_CounterListItem3> pornResult_counterList1 = new List<GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_PornResult.GetMediaAuditResult_CounterListItem3>();
			for (int i = 0; i < context.Length("GetMediaAuditResult.MediaAuditResult.VideoResult.PornResult.CounterList.Length"); i++) {
				GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_PornResult.GetMediaAuditResult_CounterListItem3 counterListItem3 = new GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_PornResult.GetMediaAuditResult_CounterListItem3();
				counterListItem3.Label = context.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.PornResult.CounterList["+ i +"].Label");
				counterListItem3.Count = context.IntegerValue("GetMediaAuditResult.MediaAuditResult.VideoResult.PornResult.CounterList["+ i +"].Count");

				pornResult_counterList1.Add(counterListItem3);
			}
			pornResult.CounterList1 = pornResult_counterList1;

			List<GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_PornResult.GetMediaAuditResult_TopListItem4> pornResult_topList2 = new List<GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_PornResult.GetMediaAuditResult_TopListItem4>();
			for (int i = 0; i < context.Length("GetMediaAuditResult.MediaAuditResult.VideoResult.PornResult.TopList.Length"); i++) {
				GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_PornResult.GetMediaAuditResult_TopListItem4 topListItem4 = new GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_PornResult.GetMediaAuditResult_TopListItem4();
				topListItem4.Label = context.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.PornResult.TopList["+ i +"].Label");
				topListItem4.Score = context.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.PornResult.TopList["+ i +"].Score");
				topListItem4.Timestamp = context.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.PornResult.TopList["+ i +"].Timestamp");
				topListItem4.Url = context.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.PornResult.TopList["+ i +"].Url");

				pornResult_topList2.Add(topListItem4);
			}
			pornResult.TopList2 = pornResult_topList2;
			videoResult.PornResult = pornResult;
			mediaAuditResult.VideoResult = videoResult;

			List<GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_ImageResultItem> mediaAuditResult_imageResult = new List<GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_ImageResultItem>();
			for (int i = 0; i < context.Length("GetMediaAuditResult.MediaAuditResult.ImageResult.Length"); i++) {
				GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_ImageResultItem imageResultItem = new GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_ImageResultItem();
				imageResultItem.Suggestion = context.StringValue("GetMediaAuditResult.MediaAuditResult.ImageResult["+ i +"].Suggestion");
				imageResultItem.Label = context.StringValue("GetMediaAuditResult.MediaAuditResult.ImageResult["+ i +"].Label");
				imageResultItem.Type = context.StringValue("GetMediaAuditResult.MediaAuditResult.ImageResult["+ i +"].Type");
				imageResultItem.Url = context.StringValue("GetMediaAuditResult.MediaAuditResult.ImageResult["+ i +"].Url");

				List<GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_ImageResultItem.GetMediaAuditResult_ResultItem> imageResultItem_result = new List<GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_ImageResultItem.GetMediaAuditResult_ResultItem>();
				for (int j = 0; j < context.Length("GetMediaAuditResult.MediaAuditResult.ImageResult["+ i +"].Result.Length"); j++) {
					GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_ImageResultItem.GetMediaAuditResult_ResultItem resultItem = new GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_ImageResultItem.GetMediaAuditResult_ResultItem();
					resultItem.Suggestion = context.StringValue("GetMediaAuditResult.MediaAuditResult.ImageResult["+ i +"].Result["+ j +"].Suggestion");
					resultItem.Label = context.StringValue("GetMediaAuditResult.MediaAuditResult.ImageResult["+ i +"].Result["+ j +"].Label");
					resultItem.Score = context.StringValue("GetMediaAuditResult.MediaAuditResult.ImageResult["+ i +"].Result["+ j +"].Score");
					resultItem.Scene = context.StringValue("GetMediaAuditResult.MediaAuditResult.ImageResult["+ i +"].Result["+ j +"].Scene");

					imageResultItem_result.Add(resultItem);
				}
				imageResultItem.Result = imageResultItem_result;

				mediaAuditResult_imageResult.Add(imageResultItem);
			}
			mediaAuditResult.ImageResult = mediaAuditResult_imageResult;

			List<GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_TextResultItem> mediaAuditResult_textResult = new List<GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_TextResultItem>();
			for (int i = 0; i < context.Length("GetMediaAuditResult.MediaAuditResult.TextResult.Length"); i++) {
				GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_TextResultItem textResultItem = new GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_TextResultItem();
				textResultItem.Suggestion = context.StringValue("GetMediaAuditResult.MediaAuditResult.TextResult["+ i +"].Suggestion");
				textResultItem.Label = context.StringValue("GetMediaAuditResult.MediaAuditResult.TextResult["+ i +"].Label");
				textResultItem.Score = context.StringValue("GetMediaAuditResult.MediaAuditResult.TextResult["+ i +"].Score");
				textResultItem.Scene = context.StringValue("GetMediaAuditResult.MediaAuditResult.TextResult["+ i +"].Scene");
				textResultItem.Type = context.StringValue("GetMediaAuditResult.MediaAuditResult.TextResult["+ i +"].Type");
				textResultItem.Content = context.StringValue("GetMediaAuditResult.MediaAuditResult.TextResult["+ i +"].Content");

				mediaAuditResult_textResult.Add(textResultItem);
			}
			mediaAuditResult.TextResult = mediaAuditResult_textResult;
			getMediaAuditResultResponse.MediaAuditResult = mediaAuditResult;
        
			return getMediaAuditResultResponse;
        }
    }
}
