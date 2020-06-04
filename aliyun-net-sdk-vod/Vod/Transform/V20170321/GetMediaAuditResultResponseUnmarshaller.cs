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
			videoResult.Label = context.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.Label");
			videoResult.Suggestion = context.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.Suggestion");

			GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_PornResult pornResult = new GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_PornResult();
			pornResult.AverageScore = context.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.PornResult.AverageScore");
			pornResult.Label = context.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.PornResult.Label");
			pornResult.MaxScore = context.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.PornResult.MaxScore");
			pornResult.Suggestion = context.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.PornResult.Suggestion");

			List<GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_PornResult.GetMediaAuditResult_CounterListItem> pornResult_counterList = new List<GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_PornResult.GetMediaAuditResult_CounterListItem>();
			for (int i = 0; i < context.Length("GetMediaAuditResult.MediaAuditResult.VideoResult.PornResult.CounterList.Length"); i++) {
				GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_PornResult.GetMediaAuditResult_CounterListItem counterListItem = new GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_PornResult.GetMediaAuditResult_CounterListItem();
				counterListItem.Count = context.IntegerValue("GetMediaAuditResult.MediaAuditResult.VideoResult.PornResult.CounterList["+ i +"].Count");
				counterListItem.Label = context.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.PornResult.CounterList["+ i +"].Label");

				pornResult_counterList.Add(counterListItem);
			}
			pornResult.CounterList = pornResult_counterList;

			List<GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_PornResult.GetMediaAuditResult_TopListItem> pornResult_topList = new List<GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_PornResult.GetMediaAuditResult_TopListItem>();
			for (int i = 0; i < context.Length("GetMediaAuditResult.MediaAuditResult.VideoResult.PornResult.TopList.Length"); i++) {
				GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_PornResult.GetMediaAuditResult_TopListItem topListItem = new GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_PornResult.GetMediaAuditResult_TopListItem();
				topListItem.Label = context.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.PornResult.TopList["+ i +"].Label");
				topListItem.Score = context.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.PornResult.TopList["+ i +"].Score");
				topListItem.Timestamp = context.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.PornResult.TopList["+ i +"].Timestamp");
				topListItem.Url = context.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.PornResult.TopList["+ i +"].Url");

				pornResult_topList.Add(topListItem);
			}
			pornResult.TopList = pornResult_topList;
			videoResult.PornResult = pornResult;

			GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_AdResult adResult = new GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_AdResult();
			adResult.AverageScore = context.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.AdResult.AverageScore");
			adResult.Label = context.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.AdResult.Label");
			adResult.MaxScore = context.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.AdResult.MaxScore");
			adResult.Suggestion = context.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.AdResult.Suggestion");

			List<GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_AdResult.GetMediaAuditResult_CounterListItem3> adResult_counterList1 = new List<GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_AdResult.GetMediaAuditResult_CounterListItem3>();
			for (int i = 0; i < context.Length("GetMediaAuditResult.MediaAuditResult.VideoResult.AdResult.CounterList.Length"); i++) {
				GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_AdResult.GetMediaAuditResult_CounterListItem3 counterListItem3 = new GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_AdResult.GetMediaAuditResult_CounterListItem3();
				counterListItem3.Count = context.IntegerValue("GetMediaAuditResult.MediaAuditResult.VideoResult.AdResult.CounterList["+ i +"].Count");
				counterListItem3.Label = context.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.AdResult.CounterList["+ i +"].Label");

				adResult_counterList1.Add(counterListItem3);
			}
			adResult.CounterList1 = adResult_counterList1;

			List<GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_AdResult.GetMediaAuditResult_TopListItem4> adResult_topList2 = new List<GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_AdResult.GetMediaAuditResult_TopListItem4>();
			for (int i = 0; i < context.Length("GetMediaAuditResult.MediaAuditResult.VideoResult.AdResult.TopList.Length"); i++) {
				GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_AdResult.GetMediaAuditResult_TopListItem4 topListItem4 = new GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_AdResult.GetMediaAuditResult_TopListItem4();
				topListItem4.Label = context.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.AdResult.TopList["+ i +"].Label");
				topListItem4.Score = context.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.AdResult.TopList["+ i +"].Score");
				topListItem4.Timestamp = context.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.AdResult.TopList["+ i +"].Timestamp");
				topListItem4.Url = context.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.AdResult.TopList["+ i +"].Url");

				adResult_topList2.Add(topListItem4);
			}
			adResult.TopList2 = adResult_topList2;
			videoResult.AdResult = adResult;

			GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_LogoResult logoResult = new GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_LogoResult();
			logoResult.AverageScore = context.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.LogoResult.AverageScore");
			logoResult.Label = context.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.LogoResult.Label");
			logoResult.MaxScore = context.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.LogoResult.MaxScore");
			logoResult.Suggestion = context.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.LogoResult.Suggestion");

			List<GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_LogoResult.GetMediaAuditResult_CounterListItem7> logoResult_counterList5 = new List<GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_LogoResult.GetMediaAuditResult_CounterListItem7>();
			for (int i = 0; i < context.Length("GetMediaAuditResult.MediaAuditResult.VideoResult.LogoResult.CounterList.Length"); i++) {
				GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_LogoResult.GetMediaAuditResult_CounterListItem7 counterListItem7 = new GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_LogoResult.GetMediaAuditResult_CounterListItem7();
				counterListItem7.Count = context.IntegerValue("GetMediaAuditResult.MediaAuditResult.VideoResult.LogoResult.CounterList["+ i +"].Count");
				counterListItem7.Label = context.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.LogoResult.CounterList["+ i +"].Label");

				logoResult_counterList5.Add(counterListItem7);
			}
			logoResult.CounterList5 = logoResult_counterList5;

			List<GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_LogoResult.GetMediaAuditResult_TopListItem8> logoResult_topList6 = new List<GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_LogoResult.GetMediaAuditResult_TopListItem8>();
			for (int i = 0; i < context.Length("GetMediaAuditResult.MediaAuditResult.VideoResult.LogoResult.TopList.Length"); i++) {
				GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_LogoResult.GetMediaAuditResult_TopListItem8 topListItem8 = new GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_LogoResult.GetMediaAuditResult_TopListItem8();
				topListItem8.Label = context.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.LogoResult.TopList["+ i +"].Label");
				topListItem8.Score = context.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.LogoResult.TopList["+ i +"].Score");
				topListItem8.Timestamp = context.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.LogoResult.TopList["+ i +"].Timestamp");
				topListItem8.Url = context.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.LogoResult.TopList["+ i +"].Url");

				logoResult_topList6.Add(topListItem8);
			}
			logoResult.TopList6 = logoResult_topList6;
			videoResult.LogoResult = logoResult;

			GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_LiveResult liveResult = new GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_LiveResult();
			liveResult.AverageScore = context.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.LiveResult.AverageScore");
			liveResult.Label = context.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.LiveResult.Label");
			liveResult.MaxScore = context.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.LiveResult.MaxScore");
			liveResult.Suggestion = context.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.LiveResult.Suggestion");

			List<GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_LiveResult.GetMediaAuditResult_CounterListItem11> liveResult_counterList9 = new List<GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_LiveResult.GetMediaAuditResult_CounterListItem11>();
			for (int i = 0; i < context.Length("GetMediaAuditResult.MediaAuditResult.VideoResult.LiveResult.CounterList.Length"); i++) {
				GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_LiveResult.GetMediaAuditResult_CounterListItem11 counterListItem11 = new GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_LiveResult.GetMediaAuditResult_CounterListItem11();
				counterListItem11.Count = context.IntegerValue("GetMediaAuditResult.MediaAuditResult.VideoResult.LiveResult.CounterList["+ i +"].Count");
				counterListItem11.Label = context.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.LiveResult.CounterList["+ i +"].Label");

				liveResult_counterList9.Add(counterListItem11);
			}
			liveResult.CounterList9 = liveResult_counterList9;

			List<GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_LiveResult.GetMediaAuditResult_TopListItem12> liveResult_topList10 = new List<GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_LiveResult.GetMediaAuditResult_TopListItem12>();
			for (int i = 0; i < context.Length("GetMediaAuditResult.MediaAuditResult.VideoResult.LiveResult.TopList.Length"); i++) {
				GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_LiveResult.GetMediaAuditResult_TopListItem12 topListItem12 = new GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_LiveResult.GetMediaAuditResult_TopListItem12();
				topListItem12.Label = context.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.LiveResult.TopList["+ i +"].Label");
				topListItem12.Score = context.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.LiveResult.TopList["+ i +"].Score");
				topListItem12.Timestamp = context.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.LiveResult.TopList["+ i +"].Timestamp");
				topListItem12.Url = context.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.LiveResult.TopList["+ i +"].Url");

				liveResult_topList10.Add(topListItem12);
			}
			liveResult.TopList10 = liveResult_topList10;
			videoResult.LiveResult = liveResult;

			GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_TerrorismResult terrorismResult = new GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_TerrorismResult();
			terrorismResult.AverageScore = context.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.TerrorismResult.AverageScore");
			terrorismResult.Label = context.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.TerrorismResult.Label");
			terrorismResult.MaxScore = context.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.TerrorismResult.MaxScore");
			terrorismResult.Suggestion = context.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.TerrorismResult.Suggestion");

			List<GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_TerrorismResult.GetMediaAuditResult_CounterListItem15> terrorismResult_counterList13 = new List<GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_TerrorismResult.GetMediaAuditResult_CounterListItem15>();
			for (int i = 0; i < context.Length("GetMediaAuditResult.MediaAuditResult.VideoResult.TerrorismResult.CounterList.Length"); i++) {
				GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_TerrorismResult.GetMediaAuditResult_CounterListItem15 counterListItem15 = new GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_TerrorismResult.GetMediaAuditResult_CounterListItem15();
				counterListItem15.Count = context.IntegerValue("GetMediaAuditResult.MediaAuditResult.VideoResult.TerrorismResult.CounterList["+ i +"].Count");
				counterListItem15.Label = context.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.TerrorismResult.CounterList["+ i +"].Label");

				terrorismResult_counterList13.Add(counterListItem15);
			}
			terrorismResult.CounterList13 = terrorismResult_counterList13;

			List<GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_TerrorismResult.GetMediaAuditResult_TopListItem16> terrorismResult_topList14 = new List<GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_TerrorismResult.GetMediaAuditResult_TopListItem16>();
			for (int i = 0; i < context.Length("GetMediaAuditResult.MediaAuditResult.VideoResult.TerrorismResult.TopList.Length"); i++) {
				GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_TerrorismResult.GetMediaAuditResult_TopListItem16 topListItem16 = new GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_TerrorismResult.GetMediaAuditResult_TopListItem16();
				topListItem16.Label = context.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.TerrorismResult.TopList["+ i +"].Label");
				topListItem16.Score = context.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.TerrorismResult.TopList["+ i +"].Score");
				topListItem16.Timestamp = context.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.TerrorismResult.TopList["+ i +"].Timestamp");
				topListItem16.Url = context.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.TerrorismResult.TopList["+ i +"].Url");

				terrorismResult_topList14.Add(topListItem16);
			}
			terrorismResult.TopList14 = terrorismResult_topList14;
			videoResult.TerrorismResult = terrorismResult;
			mediaAuditResult.VideoResult = videoResult;

			List<GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_AudioResultItem> mediaAuditResult_audioResult = new List<GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_AudioResultItem>();
			for (int i = 0; i < context.Length("GetMediaAuditResult.MediaAuditResult.AudioResult.Length"); i++) {
				GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_AudioResultItem audioResultItem = new GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_AudioResultItem();
				audioResultItem.Label = context.StringValue("GetMediaAuditResult.MediaAuditResult.AudioResult["+ i +"].Label");
				audioResultItem.Scene = context.StringValue("GetMediaAuditResult.MediaAuditResult.AudioResult["+ i +"].Scene");
				audioResultItem.Score = context.StringValue("GetMediaAuditResult.MediaAuditResult.AudioResult["+ i +"].Score");
				audioResultItem.Suggestion = context.StringValue("GetMediaAuditResult.MediaAuditResult.AudioResult["+ i +"].Suggestion");

				mediaAuditResult_audioResult.Add(audioResultItem);
			}
			mediaAuditResult.AudioResult = mediaAuditResult_audioResult;

			List<GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_ImageResultItem> mediaAuditResult_imageResult = new List<GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_ImageResultItem>();
			for (int i = 0; i < context.Length("GetMediaAuditResult.MediaAuditResult.ImageResult.Length"); i++) {
				GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_ImageResultItem imageResultItem = new GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_ImageResultItem();
				imageResultItem.Label = context.StringValue("GetMediaAuditResult.MediaAuditResult.ImageResult["+ i +"].Label");
				imageResultItem.Suggestion = context.StringValue("GetMediaAuditResult.MediaAuditResult.ImageResult["+ i +"].Suggestion");
				imageResultItem.Type = context.StringValue("GetMediaAuditResult.MediaAuditResult.ImageResult["+ i +"].Type");
				imageResultItem.Url = context.StringValue("GetMediaAuditResult.MediaAuditResult.ImageResult["+ i +"].Url");

				List<GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_ImageResultItem.GetMediaAuditResult_ResultItem> imageResultItem_result = new List<GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_ImageResultItem.GetMediaAuditResult_ResultItem>();
				for (int j = 0; j < context.Length("GetMediaAuditResult.MediaAuditResult.ImageResult["+ i +"].Result.Length"); j++) {
					GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_ImageResultItem.GetMediaAuditResult_ResultItem resultItem = new GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_ImageResultItem.GetMediaAuditResult_ResultItem();
					resultItem.Label = context.StringValue("GetMediaAuditResult.MediaAuditResult.ImageResult["+ i +"].Result["+ j +"].Label");
					resultItem.Scene = context.StringValue("GetMediaAuditResult.MediaAuditResult.ImageResult["+ i +"].Result["+ j +"].Scene");
					resultItem.Score = context.StringValue("GetMediaAuditResult.MediaAuditResult.ImageResult["+ i +"].Result["+ j +"].Score");
					resultItem.Suggestion = context.StringValue("GetMediaAuditResult.MediaAuditResult.ImageResult["+ i +"].Result["+ j +"].Suggestion");

					imageResultItem_result.Add(resultItem);
				}
				imageResultItem.Result = imageResultItem_result;

				mediaAuditResult_imageResult.Add(imageResultItem);
			}
			mediaAuditResult.ImageResult = mediaAuditResult_imageResult;

			List<GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_TextResultItem> mediaAuditResult_textResult = new List<GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_TextResultItem>();
			for (int i = 0; i < context.Length("GetMediaAuditResult.MediaAuditResult.TextResult.Length"); i++) {
				GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_TextResultItem textResultItem = new GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_TextResultItem();
				textResultItem.Content = context.StringValue("GetMediaAuditResult.MediaAuditResult.TextResult["+ i +"].Content");
				textResultItem.Label = context.StringValue("GetMediaAuditResult.MediaAuditResult.TextResult["+ i +"].Label");
				textResultItem.Scene = context.StringValue("GetMediaAuditResult.MediaAuditResult.TextResult["+ i +"].Scene");
				textResultItem.Score = context.StringValue("GetMediaAuditResult.MediaAuditResult.TextResult["+ i +"].Score");
				textResultItem.Suggestion = context.StringValue("GetMediaAuditResult.MediaAuditResult.TextResult["+ i +"].Suggestion");
				textResultItem.Type = context.StringValue("GetMediaAuditResult.MediaAuditResult.TextResult["+ i +"].Type");

				mediaAuditResult_textResult.Add(textResultItem);
			}
			mediaAuditResult.TextResult = mediaAuditResult_textResult;
			getMediaAuditResultResponse.MediaAuditResult = mediaAuditResult;
        
			return getMediaAuditResultResponse;
        }
    }
}
