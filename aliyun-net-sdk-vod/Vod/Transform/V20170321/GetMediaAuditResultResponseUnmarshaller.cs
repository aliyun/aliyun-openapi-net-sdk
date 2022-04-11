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
        public static GetMediaAuditResultResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetMediaAuditResultResponse getMediaAuditResultResponse = new GetMediaAuditResultResponse();

			getMediaAuditResultResponse.HttpResponse = _ctx.HttpResponse;
			getMediaAuditResultResponse.RequestId = _ctx.StringValue("GetMediaAuditResult.RequestId");

			GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult mediaAuditResult = new GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult();
			mediaAuditResult.Suggestion = _ctx.StringValue("GetMediaAuditResult.MediaAuditResult.Suggestion");
			mediaAuditResult.AbnormalModules = _ctx.StringValue("GetMediaAuditResult.MediaAuditResult.AbnormalModules");
			mediaAuditResult.Label = _ctx.StringValue("GetMediaAuditResult.MediaAuditResult.Label");

			GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult videoResult = new GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult();
			videoResult.Label = _ctx.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.Label");
			videoResult.Suggestion = _ctx.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.Suggestion");

			GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_PornResult pornResult = new GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_PornResult();
			pornResult.Suggestion = _ctx.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.PornResult.Suggestion");
			pornResult.AverageScore = _ctx.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.PornResult.AverageScore");
			pornResult.Label = _ctx.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.PornResult.Label");
			pornResult.MaxScore = _ctx.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.PornResult.MaxScore");

			List<GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_PornResult.GetMediaAuditResult_CounterListItem> pornResult_counterList = new List<GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_PornResult.GetMediaAuditResult_CounterListItem>();
			for (int i = 0; i < _ctx.Length("GetMediaAuditResult.MediaAuditResult.VideoResult.PornResult.CounterList.Length"); i++) {
				GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_PornResult.GetMediaAuditResult_CounterListItem counterListItem = new GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_PornResult.GetMediaAuditResult_CounterListItem();
				counterListItem.Label = _ctx.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.PornResult.CounterList["+ i +"].Label");
				counterListItem.Count = _ctx.IntegerValue("GetMediaAuditResult.MediaAuditResult.VideoResult.PornResult.CounterList["+ i +"].Count");

				pornResult_counterList.Add(counterListItem);
			}
			pornResult.CounterList = pornResult_counterList;

			List<GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_PornResult.GetMediaAuditResult_TopListItem> pornResult_topList = new List<GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_PornResult.GetMediaAuditResult_TopListItem>();
			for (int i = 0; i < _ctx.Length("GetMediaAuditResult.MediaAuditResult.VideoResult.PornResult.TopList.Length"); i++) {
				GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_PornResult.GetMediaAuditResult_TopListItem topListItem = new GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_PornResult.GetMediaAuditResult_TopListItem();
				topListItem.Url = _ctx.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.PornResult.TopList["+ i +"].Url");
				topListItem.Score = _ctx.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.PornResult.TopList["+ i +"].Score");
				topListItem.Timestamp = _ctx.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.PornResult.TopList["+ i +"].Timestamp");
				topListItem.Label = _ctx.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.PornResult.TopList["+ i +"].Label");

				pornResult_topList.Add(topListItem);
			}
			pornResult.TopList = pornResult_topList;
			videoResult.PornResult = pornResult;

			GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_AdResult adResult = new GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_AdResult();
			adResult.Suggestion = _ctx.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.AdResult.Suggestion");
			adResult.AverageScore = _ctx.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.AdResult.AverageScore");
			adResult.Label = _ctx.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.AdResult.Label");
			adResult.MaxScore = _ctx.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.AdResult.MaxScore");

			List<GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_AdResult.GetMediaAuditResult_CounterListItem3> adResult_counterList1 = new List<GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_AdResult.GetMediaAuditResult_CounterListItem3>();
			for (int i = 0; i < _ctx.Length("GetMediaAuditResult.MediaAuditResult.VideoResult.AdResult.CounterList.Length"); i++) {
				GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_AdResult.GetMediaAuditResult_CounterListItem3 counterListItem3 = new GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_AdResult.GetMediaAuditResult_CounterListItem3();
				counterListItem3.Label = _ctx.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.AdResult.CounterList["+ i +"].Label");
				counterListItem3.Count = _ctx.IntegerValue("GetMediaAuditResult.MediaAuditResult.VideoResult.AdResult.CounterList["+ i +"].Count");

				adResult_counterList1.Add(counterListItem3);
			}
			adResult.CounterList1 = adResult_counterList1;

			List<GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_AdResult.GetMediaAuditResult_TopListItem4> adResult_topList2 = new List<GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_AdResult.GetMediaAuditResult_TopListItem4>();
			for (int i = 0; i < _ctx.Length("GetMediaAuditResult.MediaAuditResult.VideoResult.AdResult.TopList.Length"); i++) {
				GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_AdResult.GetMediaAuditResult_TopListItem4 topListItem4 = new GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_AdResult.GetMediaAuditResult_TopListItem4();
				topListItem4.Url = _ctx.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.AdResult.TopList["+ i +"].Url");
				topListItem4.Score = _ctx.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.AdResult.TopList["+ i +"].Score");
				topListItem4.Timestamp = _ctx.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.AdResult.TopList["+ i +"].Timestamp");
				topListItem4.Label = _ctx.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.AdResult.TopList["+ i +"].Label");

				adResult_topList2.Add(topListItem4);
			}
			adResult.TopList2 = adResult_topList2;
			videoResult.AdResult = adResult;

			GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_LogoResult logoResult = new GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_LogoResult();
			logoResult.Suggestion = _ctx.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.LogoResult.Suggestion");
			logoResult.AverageScore = _ctx.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.LogoResult.AverageScore");
			logoResult.Label = _ctx.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.LogoResult.Label");
			logoResult.MaxScore = _ctx.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.LogoResult.MaxScore");

			List<GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_LogoResult.GetMediaAuditResult_CounterListItem7> logoResult_counterList5 = new List<GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_LogoResult.GetMediaAuditResult_CounterListItem7>();
			for (int i = 0; i < _ctx.Length("GetMediaAuditResult.MediaAuditResult.VideoResult.LogoResult.CounterList.Length"); i++) {
				GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_LogoResult.GetMediaAuditResult_CounterListItem7 counterListItem7 = new GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_LogoResult.GetMediaAuditResult_CounterListItem7();
				counterListItem7.Label = _ctx.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.LogoResult.CounterList["+ i +"].Label");
				counterListItem7.Count = _ctx.IntegerValue("GetMediaAuditResult.MediaAuditResult.VideoResult.LogoResult.CounterList["+ i +"].Count");

				logoResult_counterList5.Add(counterListItem7);
			}
			logoResult.CounterList5 = logoResult_counterList5;

			List<GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_LogoResult.GetMediaAuditResult_TopListItem8> logoResult_topList6 = new List<GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_LogoResult.GetMediaAuditResult_TopListItem8>();
			for (int i = 0; i < _ctx.Length("GetMediaAuditResult.MediaAuditResult.VideoResult.LogoResult.TopList.Length"); i++) {
				GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_LogoResult.GetMediaAuditResult_TopListItem8 topListItem8 = new GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_LogoResult.GetMediaAuditResult_TopListItem8();
				topListItem8.Url = _ctx.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.LogoResult.TopList["+ i +"].Url");
				topListItem8.Score = _ctx.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.LogoResult.TopList["+ i +"].Score");
				topListItem8.Timestamp = _ctx.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.LogoResult.TopList["+ i +"].Timestamp");
				topListItem8.Label = _ctx.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.LogoResult.TopList["+ i +"].Label");

				logoResult_topList6.Add(topListItem8);
			}
			logoResult.TopList6 = logoResult_topList6;
			videoResult.LogoResult = logoResult;

			GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_LiveResult liveResult = new GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_LiveResult();
			liveResult.Suggestion = _ctx.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.LiveResult.Suggestion");
			liveResult.AverageScore = _ctx.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.LiveResult.AverageScore");
			liveResult.Label = _ctx.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.LiveResult.Label");
			liveResult.MaxScore = _ctx.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.LiveResult.MaxScore");

			List<GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_LiveResult.GetMediaAuditResult_CounterListItem11> liveResult_counterList9 = new List<GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_LiveResult.GetMediaAuditResult_CounterListItem11>();
			for (int i = 0; i < _ctx.Length("GetMediaAuditResult.MediaAuditResult.VideoResult.LiveResult.CounterList.Length"); i++) {
				GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_LiveResult.GetMediaAuditResult_CounterListItem11 counterListItem11 = new GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_LiveResult.GetMediaAuditResult_CounterListItem11();
				counterListItem11.Label = _ctx.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.LiveResult.CounterList["+ i +"].Label");
				counterListItem11.Count = _ctx.IntegerValue("GetMediaAuditResult.MediaAuditResult.VideoResult.LiveResult.CounterList["+ i +"].Count");

				liveResult_counterList9.Add(counterListItem11);
			}
			liveResult.CounterList9 = liveResult_counterList9;

			List<GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_LiveResult.GetMediaAuditResult_TopListItem12> liveResult_topList10 = new List<GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_LiveResult.GetMediaAuditResult_TopListItem12>();
			for (int i = 0; i < _ctx.Length("GetMediaAuditResult.MediaAuditResult.VideoResult.LiveResult.TopList.Length"); i++) {
				GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_LiveResult.GetMediaAuditResult_TopListItem12 topListItem12 = new GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_LiveResult.GetMediaAuditResult_TopListItem12();
				topListItem12.Url = _ctx.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.LiveResult.TopList["+ i +"].Url");
				topListItem12.Score = _ctx.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.LiveResult.TopList["+ i +"].Score");
				topListItem12.Timestamp = _ctx.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.LiveResult.TopList["+ i +"].Timestamp");
				topListItem12.Label = _ctx.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.LiveResult.TopList["+ i +"].Label");

				liveResult_topList10.Add(topListItem12);
			}
			liveResult.TopList10 = liveResult_topList10;
			videoResult.LiveResult = liveResult;

			GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_TerrorismResult terrorismResult = new GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_TerrorismResult();
			terrorismResult.Suggestion = _ctx.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.TerrorismResult.Suggestion");
			terrorismResult.AverageScore = _ctx.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.TerrorismResult.AverageScore");
			terrorismResult.Label = _ctx.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.TerrorismResult.Label");
			terrorismResult.MaxScore = _ctx.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.TerrorismResult.MaxScore");

			List<GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_TerrorismResult.GetMediaAuditResult_CounterListItem15> terrorismResult_counterList13 = new List<GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_TerrorismResult.GetMediaAuditResult_CounterListItem15>();
			for (int i = 0; i < _ctx.Length("GetMediaAuditResult.MediaAuditResult.VideoResult.TerrorismResult.CounterList.Length"); i++) {
				GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_TerrorismResult.GetMediaAuditResult_CounterListItem15 counterListItem15 = new GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_TerrorismResult.GetMediaAuditResult_CounterListItem15();
				counterListItem15.Label = _ctx.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.TerrorismResult.CounterList["+ i +"].Label");
				counterListItem15.Count = _ctx.IntegerValue("GetMediaAuditResult.MediaAuditResult.VideoResult.TerrorismResult.CounterList["+ i +"].Count");

				terrorismResult_counterList13.Add(counterListItem15);
			}
			terrorismResult.CounterList13 = terrorismResult_counterList13;

			List<GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_TerrorismResult.GetMediaAuditResult_TopListItem16> terrorismResult_topList14 = new List<GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_TerrorismResult.GetMediaAuditResult_TopListItem16>();
			for (int i = 0; i < _ctx.Length("GetMediaAuditResult.MediaAuditResult.VideoResult.TerrorismResult.TopList.Length"); i++) {
				GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_TerrorismResult.GetMediaAuditResult_TopListItem16 topListItem16 = new GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_VideoResult.GetMediaAuditResult_TerrorismResult.GetMediaAuditResult_TopListItem16();
				topListItem16.Url = _ctx.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.TerrorismResult.TopList["+ i +"].Url");
				topListItem16.Score = _ctx.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.TerrorismResult.TopList["+ i +"].Score");
				topListItem16.Timestamp = _ctx.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.TerrorismResult.TopList["+ i +"].Timestamp");
				topListItem16.Label = _ctx.StringValue("GetMediaAuditResult.MediaAuditResult.VideoResult.TerrorismResult.TopList["+ i +"].Label");

				terrorismResult_topList14.Add(topListItem16);
			}
			terrorismResult.TopList14 = terrorismResult_topList14;
			videoResult.TerrorismResult = terrorismResult;
			mediaAuditResult.VideoResult = videoResult;

			List<GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_AudioResultItem> mediaAuditResult_audioResult = new List<GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_AudioResultItem>();
			for (int i = 0; i < _ctx.Length("GetMediaAuditResult.MediaAuditResult.AudioResult.Length"); i++) {
				GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_AudioResultItem audioResultItem = new GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_AudioResultItem();
				audioResultItem.Score = _ctx.StringValue("GetMediaAuditResult.MediaAuditResult.AudioResult["+ i +"].Score");
				audioResultItem.Suggestion = _ctx.StringValue("GetMediaAuditResult.MediaAuditResult.AudioResult["+ i +"].Suggestion");
				audioResultItem.Label = _ctx.StringValue("GetMediaAuditResult.MediaAuditResult.AudioResult["+ i +"].Label");
				audioResultItem.Scene = _ctx.StringValue("GetMediaAuditResult.MediaAuditResult.AudioResult["+ i +"].Scene");

				mediaAuditResult_audioResult.Add(audioResultItem);
			}
			mediaAuditResult.AudioResult = mediaAuditResult_audioResult;

			List<GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_ImageResultItem> mediaAuditResult_imageResult = new List<GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_ImageResultItem>();
			for (int i = 0; i < _ctx.Length("GetMediaAuditResult.MediaAuditResult.ImageResult.Length"); i++) {
				GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_ImageResultItem imageResultItem = new GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_ImageResultItem();
				imageResultItem.Type = _ctx.StringValue("GetMediaAuditResult.MediaAuditResult.ImageResult["+ i +"].Type");
				imageResultItem.Url = _ctx.StringValue("GetMediaAuditResult.MediaAuditResult.ImageResult["+ i +"].Url");
				imageResultItem.Suggestion = _ctx.StringValue("GetMediaAuditResult.MediaAuditResult.ImageResult["+ i +"].Suggestion");
				imageResultItem.Label = _ctx.StringValue("GetMediaAuditResult.MediaAuditResult.ImageResult["+ i +"].Label");

				List<GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_ImageResultItem.GetMediaAuditResult_ResultItem> imageResultItem_result = new List<GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_ImageResultItem.GetMediaAuditResult_ResultItem>();
				for (int j = 0; j < _ctx.Length("GetMediaAuditResult.MediaAuditResult.ImageResult["+ i +"].Result.Length"); j++) {
					GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_ImageResultItem.GetMediaAuditResult_ResultItem resultItem = new GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_ImageResultItem.GetMediaAuditResult_ResultItem();
					resultItem.Score = _ctx.StringValue("GetMediaAuditResult.MediaAuditResult.ImageResult["+ i +"].Result["+ j +"].Score");
					resultItem.Suggestion = _ctx.StringValue("GetMediaAuditResult.MediaAuditResult.ImageResult["+ i +"].Result["+ j +"].Suggestion");
					resultItem.Label = _ctx.StringValue("GetMediaAuditResult.MediaAuditResult.ImageResult["+ i +"].Result["+ j +"].Label");
					resultItem.Scene = _ctx.StringValue("GetMediaAuditResult.MediaAuditResult.ImageResult["+ i +"].Result["+ j +"].Scene");

					imageResultItem_result.Add(resultItem);
				}
				imageResultItem.Result = imageResultItem_result;

				mediaAuditResult_imageResult.Add(imageResultItem);
			}
			mediaAuditResult.ImageResult = mediaAuditResult_imageResult;

			List<GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_TextResultItem> mediaAuditResult_textResult = new List<GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_TextResultItem>();
			for (int i = 0; i < _ctx.Length("GetMediaAuditResult.MediaAuditResult.TextResult.Length"); i++) {
				GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_TextResultItem textResultItem = new GetMediaAuditResultResponse.GetMediaAuditResult_MediaAuditResult.GetMediaAuditResult_TextResultItem();
				textResultItem.Type = _ctx.StringValue("GetMediaAuditResult.MediaAuditResult.TextResult["+ i +"].Type");
				textResultItem.Suggestion = _ctx.StringValue("GetMediaAuditResult.MediaAuditResult.TextResult["+ i +"].Suggestion");
				textResultItem.Score = _ctx.StringValue("GetMediaAuditResult.MediaAuditResult.TextResult["+ i +"].Score");
				textResultItem.Label = _ctx.StringValue("GetMediaAuditResult.MediaAuditResult.TextResult["+ i +"].Label");
				textResultItem.Content = _ctx.StringValue("GetMediaAuditResult.MediaAuditResult.TextResult["+ i +"].Content");
				textResultItem.Scene = _ctx.StringValue("GetMediaAuditResult.MediaAuditResult.TextResult["+ i +"].Scene");

				mediaAuditResult_textResult.Add(textResultItem);
			}
			mediaAuditResult.TextResult = mediaAuditResult_textResult;
			getMediaAuditResultResponse.MediaAuditResult = mediaAuditResult;
        
			return getMediaAuditResultResponse;
        }
    }
}
