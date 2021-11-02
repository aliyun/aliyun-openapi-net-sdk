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
    public class GetAIMediaAuditJobResponseUnmarshaller
    {
        public static GetAIMediaAuditJobResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetAIMediaAuditJobResponse getAIMediaAuditJobResponse = new GetAIMediaAuditJobResponse();

			getAIMediaAuditJobResponse.HttpResponse = _ctx.HttpResponse;
			getAIMediaAuditJobResponse.RequestId = _ctx.StringValue("GetAIMediaAuditJob.RequestId");

			GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob mediaAuditJob = new GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob();
			mediaAuditJob.JobId = _ctx.StringValue("GetAIMediaAuditJob.MediaAuditJob.JobId");
			mediaAuditJob.MediaId = _ctx.StringValue("GetAIMediaAuditJob.MediaAuditJob.MediaId");
			mediaAuditJob.Type = _ctx.StringValue("GetAIMediaAuditJob.MediaAuditJob.Type");
			mediaAuditJob.Status = _ctx.StringValue("GetAIMediaAuditJob.MediaAuditJob.Status");
			mediaAuditJob.Code = _ctx.StringValue("GetAIMediaAuditJob.MediaAuditJob.Code");
			mediaAuditJob.Message = _ctx.StringValue("GetAIMediaAuditJob.MediaAuditJob.Message");
			mediaAuditJob.CreationTime = _ctx.StringValue("GetAIMediaAuditJob.MediaAuditJob.CreationTime");
			mediaAuditJob.CompleteTime = _ctx.StringValue("GetAIMediaAuditJob.MediaAuditJob.CompleteTime");

			GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data data = new GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data();
			data.Suggestion = _ctx.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.Suggestion");
			data.AbnormalModules = _ctx.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.AbnormalModules");
			data.Label = _ctx.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.Label");

			GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_VideoResult videoResult = new GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_VideoResult();
			videoResult.Suggestion = _ctx.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.Suggestion");
			videoResult.Label = _ctx.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.Label");

			GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_VideoResult.GetAIMediaAuditJob_TerrorismResult terrorismResult = new GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_VideoResult.GetAIMediaAuditJob_TerrorismResult();
			terrorismResult.Suggestion = _ctx.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.TerrorismResult.Suggestion");
			terrorismResult.Label = _ctx.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.TerrorismResult.Label");
			terrorismResult.MaxScore = _ctx.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.TerrorismResult.MaxScore");
			terrorismResult.AverageScore = _ctx.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.TerrorismResult.AverageScore");

			List<GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_VideoResult.GetAIMediaAuditJob_TerrorismResult.GetAIMediaAuditJob_CounterListItem> terrorismResult_counterList = new List<GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_VideoResult.GetAIMediaAuditJob_TerrorismResult.GetAIMediaAuditJob_CounterListItem>();
			for (int i = 0; i < _ctx.Length("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.TerrorismResult.CounterList.Length"); i++) {
				GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_VideoResult.GetAIMediaAuditJob_TerrorismResult.GetAIMediaAuditJob_CounterListItem counterListItem = new GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_VideoResult.GetAIMediaAuditJob_TerrorismResult.GetAIMediaAuditJob_CounterListItem();
				counterListItem.Label = _ctx.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.TerrorismResult.CounterList["+ i +"].Label");
				counterListItem.Count = _ctx.IntegerValue("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.TerrorismResult.CounterList["+ i +"].Count");

				terrorismResult_counterList.Add(counterListItem);
			}
			terrorismResult.CounterList = terrorismResult_counterList;

			List<GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_VideoResult.GetAIMediaAuditJob_TerrorismResult.GetAIMediaAuditJob_TopListItem> terrorismResult_topList = new List<GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_VideoResult.GetAIMediaAuditJob_TerrorismResult.GetAIMediaAuditJob_TopListItem>();
			for (int i = 0; i < _ctx.Length("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.TerrorismResult.TopList.Length"); i++) {
				GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_VideoResult.GetAIMediaAuditJob_TerrorismResult.GetAIMediaAuditJob_TopListItem topListItem = new GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_VideoResult.GetAIMediaAuditJob_TerrorismResult.GetAIMediaAuditJob_TopListItem();
				topListItem.Label = _ctx.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.TerrorismResult.TopList["+ i +"].Label");
				topListItem.Score = _ctx.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.TerrorismResult.TopList["+ i +"].Score");
				topListItem.Timestamp = _ctx.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.TerrorismResult.TopList["+ i +"].Timestamp");
				topListItem.Url = _ctx.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.TerrorismResult.TopList["+ i +"].Url");

				terrorismResult_topList.Add(topListItem);
			}
			terrorismResult.TopList = terrorismResult_topList;
			videoResult.TerrorismResult = terrorismResult;

			GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_VideoResult.GetAIMediaAuditJob_PornResult pornResult = new GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_VideoResult.GetAIMediaAuditJob_PornResult();
			pornResult.Suggestion = _ctx.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.PornResult.Suggestion");
			pornResult.Label = _ctx.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.PornResult.Label");
			pornResult.MaxScore = _ctx.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.PornResult.MaxScore");
			pornResult.AverageScore = _ctx.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.PornResult.AverageScore");

			List<GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_VideoResult.GetAIMediaAuditJob_PornResult.GetAIMediaAuditJob_CounterListItem3> pornResult_counterList1 = new List<GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_VideoResult.GetAIMediaAuditJob_PornResult.GetAIMediaAuditJob_CounterListItem3>();
			for (int i = 0; i < _ctx.Length("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.PornResult.CounterList.Length"); i++) {
				GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_VideoResult.GetAIMediaAuditJob_PornResult.GetAIMediaAuditJob_CounterListItem3 counterListItem3 = new GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_VideoResult.GetAIMediaAuditJob_PornResult.GetAIMediaAuditJob_CounterListItem3();
				counterListItem3.Label = _ctx.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.PornResult.CounterList["+ i +"].Label");
				counterListItem3.Count = _ctx.IntegerValue("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.PornResult.CounterList["+ i +"].Count");

				pornResult_counterList1.Add(counterListItem3);
			}
			pornResult.CounterList1 = pornResult_counterList1;

			List<GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_VideoResult.GetAIMediaAuditJob_PornResult.GetAIMediaAuditJob_TopListItem4> pornResult_topList2 = new List<GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_VideoResult.GetAIMediaAuditJob_PornResult.GetAIMediaAuditJob_TopListItem4>();
			for (int i = 0; i < _ctx.Length("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.PornResult.TopList.Length"); i++) {
				GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_VideoResult.GetAIMediaAuditJob_PornResult.GetAIMediaAuditJob_TopListItem4 topListItem4 = new GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_VideoResult.GetAIMediaAuditJob_PornResult.GetAIMediaAuditJob_TopListItem4();
				topListItem4.Label = _ctx.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.PornResult.TopList["+ i +"].Label");
				topListItem4.Score = _ctx.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.PornResult.TopList["+ i +"].Score");
				topListItem4.Timestamp = _ctx.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.PornResult.TopList["+ i +"].Timestamp");
				topListItem4.Url = _ctx.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.PornResult.TopList["+ i +"].Url");

				pornResult_topList2.Add(topListItem4);
			}
			pornResult.TopList2 = pornResult_topList2;
			videoResult.PornResult = pornResult;

			GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_VideoResult.GetAIMediaAuditJob_AdResult adResult = new GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_VideoResult.GetAIMediaAuditJob_AdResult();
			adResult.Suggestion = _ctx.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.AdResult.Suggestion");
			adResult.Label = _ctx.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.AdResult.Label");
			adResult.MaxScore = _ctx.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.AdResult.MaxScore");
			adResult.AverageScore = _ctx.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.AdResult.AverageScore");

			List<GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_VideoResult.GetAIMediaAuditJob_AdResult.GetAIMediaAuditJob_CounterListItem7> adResult_counterList5 = new List<GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_VideoResult.GetAIMediaAuditJob_AdResult.GetAIMediaAuditJob_CounterListItem7>();
			for (int i = 0; i < _ctx.Length("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.AdResult.CounterList.Length"); i++) {
				GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_VideoResult.GetAIMediaAuditJob_AdResult.GetAIMediaAuditJob_CounterListItem7 counterListItem7 = new GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_VideoResult.GetAIMediaAuditJob_AdResult.GetAIMediaAuditJob_CounterListItem7();
				counterListItem7.Label = _ctx.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.AdResult.CounterList["+ i +"].Label");
				counterListItem7.Count = _ctx.IntegerValue("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.AdResult.CounterList["+ i +"].Count");

				adResult_counterList5.Add(counterListItem7);
			}
			adResult.CounterList5 = adResult_counterList5;

			List<GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_VideoResult.GetAIMediaAuditJob_AdResult.GetAIMediaAuditJob_TopListItem8> adResult_topList6 = new List<GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_VideoResult.GetAIMediaAuditJob_AdResult.GetAIMediaAuditJob_TopListItem8>();
			for (int i = 0; i < _ctx.Length("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.AdResult.TopList.Length"); i++) {
				GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_VideoResult.GetAIMediaAuditJob_AdResult.GetAIMediaAuditJob_TopListItem8 topListItem8 = new GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_VideoResult.GetAIMediaAuditJob_AdResult.GetAIMediaAuditJob_TopListItem8();
				topListItem8.Label = _ctx.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.AdResult.TopList["+ i +"].Label");
				topListItem8.Score = _ctx.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.AdResult.TopList["+ i +"].Score");
				topListItem8.Timestamp = _ctx.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.AdResult.TopList["+ i +"].Timestamp");
				topListItem8.Url = _ctx.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.AdResult.TopList["+ i +"].Url");

				adResult_topList6.Add(topListItem8);
			}
			adResult.TopList6 = adResult_topList6;
			videoResult.AdResult = adResult;

			GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_VideoResult.GetAIMediaAuditJob_LiveResult liveResult = new GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_VideoResult.GetAIMediaAuditJob_LiveResult();
			liveResult.Suggestion = _ctx.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.LiveResult.Suggestion");
			liveResult.Label = _ctx.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.LiveResult.Label");
			liveResult.MaxScore = _ctx.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.LiveResult.MaxScore");
			liveResult.AverageScore = _ctx.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.LiveResult.AverageScore");

			List<GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_VideoResult.GetAIMediaAuditJob_LiveResult.GetAIMediaAuditJob_CounterListItem11> liveResult_counterList9 = new List<GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_VideoResult.GetAIMediaAuditJob_LiveResult.GetAIMediaAuditJob_CounterListItem11>();
			for (int i = 0; i < _ctx.Length("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.LiveResult.CounterList.Length"); i++) {
				GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_VideoResult.GetAIMediaAuditJob_LiveResult.GetAIMediaAuditJob_CounterListItem11 counterListItem11 = new GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_VideoResult.GetAIMediaAuditJob_LiveResult.GetAIMediaAuditJob_CounterListItem11();
				counterListItem11.Label = _ctx.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.LiveResult.CounterList["+ i +"].Label");
				counterListItem11.Count = _ctx.IntegerValue("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.LiveResult.CounterList["+ i +"].Count");

				liveResult_counterList9.Add(counterListItem11);
			}
			liveResult.CounterList9 = liveResult_counterList9;

			List<GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_VideoResult.GetAIMediaAuditJob_LiveResult.GetAIMediaAuditJob_TopListItem12> liveResult_topList10 = new List<GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_VideoResult.GetAIMediaAuditJob_LiveResult.GetAIMediaAuditJob_TopListItem12>();
			for (int i = 0; i < _ctx.Length("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.LiveResult.TopList.Length"); i++) {
				GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_VideoResult.GetAIMediaAuditJob_LiveResult.GetAIMediaAuditJob_TopListItem12 topListItem12 = new GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_VideoResult.GetAIMediaAuditJob_LiveResult.GetAIMediaAuditJob_TopListItem12();
				topListItem12.Label = _ctx.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.LiveResult.TopList["+ i +"].Label");
				topListItem12.Score = _ctx.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.LiveResult.TopList["+ i +"].Score");
				topListItem12.Timestamp = _ctx.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.LiveResult.TopList["+ i +"].Timestamp");
				topListItem12.Url = _ctx.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.LiveResult.TopList["+ i +"].Url");

				liveResult_topList10.Add(topListItem12);
			}
			liveResult.TopList10 = liveResult_topList10;
			videoResult.LiveResult = liveResult;

			GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_VideoResult.GetAIMediaAuditJob_LogoResult logoResult = new GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_VideoResult.GetAIMediaAuditJob_LogoResult();
			logoResult.Suggestion = _ctx.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.LogoResult.Suggestion");
			logoResult.Label = _ctx.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.LogoResult.Label");
			logoResult.MaxScore = _ctx.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.LogoResult.MaxScore");
			logoResult.AverageScore = _ctx.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.LogoResult.AverageScore");

			List<GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_VideoResult.GetAIMediaAuditJob_LogoResult.GetAIMediaAuditJob_CounterListItem15> logoResult_counterList13 = new List<GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_VideoResult.GetAIMediaAuditJob_LogoResult.GetAIMediaAuditJob_CounterListItem15>();
			for (int i = 0; i < _ctx.Length("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.LogoResult.CounterList.Length"); i++) {
				GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_VideoResult.GetAIMediaAuditJob_LogoResult.GetAIMediaAuditJob_CounterListItem15 counterListItem15 = new GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_VideoResult.GetAIMediaAuditJob_LogoResult.GetAIMediaAuditJob_CounterListItem15();
				counterListItem15.Label = _ctx.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.LogoResult.CounterList["+ i +"].Label");
				counterListItem15.Count = _ctx.IntegerValue("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.LogoResult.CounterList["+ i +"].Count");

				logoResult_counterList13.Add(counterListItem15);
			}
			logoResult.CounterList13 = logoResult_counterList13;

			List<GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_VideoResult.GetAIMediaAuditJob_LogoResult.GetAIMediaAuditJob_TopListItem16> logoResult_topList14 = new List<GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_VideoResult.GetAIMediaAuditJob_LogoResult.GetAIMediaAuditJob_TopListItem16>();
			for (int i = 0; i < _ctx.Length("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.LogoResult.TopList.Length"); i++) {
				GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_VideoResult.GetAIMediaAuditJob_LogoResult.GetAIMediaAuditJob_TopListItem16 topListItem16 = new GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_VideoResult.GetAIMediaAuditJob_LogoResult.GetAIMediaAuditJob_TopListItem16();
				topListItem16.Label = _ctx.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.LogoResult.TopList["+ i +"].Label");
				topListItem16.Score = _ctx.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.LogoResult.TopList["+ i +"].Score");
				topListItem16.Timestamp = _ctx.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.LogoResult.TopList["+ i +"].Timestamp");
				topListItem16.Url = _ctx.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.VideoResult.LogoResult.TopList["+ i +"].Url");

				logoResult_topList14.Add(topListItem16);
			}
			logoResult.TopList14 = logoResult_topList14;
			videoResult.LogoResult = logoResult;
			data.VideoResult = videoResult;

			List<GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_ImageResultItem> data_imageResult = new List<GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_ImageResultItem>();
			for (int i = 0; i < _ctx.Length("GetAIMediaAuditJob.MediaAuditJob.Data.ImageResult.Length"); i++) {
				GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_ImageResultItem imageResultItem = new GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_ImageResultItem();
				imageResultItem.Suggestion = _ctx.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.ImageResult["+ i +"].Suggestion");
				imageResultItem.Label = _ctx.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.ImageResult["+ i +"].Label");
				imageResultItem.Type = _ctx.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.ImageResult["+ i +"].Type");
				imageResultItem.Url = _ctx.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.ImageResult["+ i +"].Url");

				List<GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_ImageResultItem.GetAIMediaAuditJob_ResultItem> imageResultItem_result = new List<GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_ImageResultItem.GetAIMediaAuditJob_ResultItem>();
				for (int j = 0; j < _ctx.Length("GetAIMediaAuditJob.MediaAuditJob.Data.ImageResult["+ i +"].Result.Length"); j++) {
					GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_ImageResultItem.GetAIMediaAuditJob_ResultItem resultItem = new GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_ImageResultItem.GetAIMediaAuditJob_ResultItem();
					resultItem.Suggestion = _ctx.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.ImageResult["+ i +"].Result["+ j +"].Suggestion");
					resultItem.Label = _ctx.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.ImageResult["+ i +"].Result["+ j +"].Label");
					resultItem.Score = _ctx.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.ImageResult["+ i +"].Result["+ j +"].Score");
					resultItem.Scene = _ctx.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.ImageResult["+ i +"].Result["+ j +"].Scene");

					imageResultItem_result.Add(resultItem);
				}
				imageResultItem.Result = imageResultItem_result;

				data_imageResult.Add(imageResultItem);
			}
			data.ImageResult = data_imageResult;

			List<GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_TextResultItem> data_textResult = new List<GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_TextResultItem>();
			for (int i = 0; i < _ctx.Length("GetAIMediaAuditJob.MediaAuditJob.Data.TextResult.Length"); i++) {
				GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_TextResultItem textResultItem = new GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_TextResultItem();
				textResultItem.Suggestion = _ctx.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.TextResult["+ i +"].Suggestion");
				textResultItem.Label = _ctx.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.TextResult["+ i +"].Label");
				textResultItem.Score = _ctx.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.TextResult["+ i +"].Score");
				textResultItem.Scene = _ctx.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.TextResult["+ i +"].Scene");
				textResultItem.Type = _ctx.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.TextResult["+ i +"].Type");
				textResultItem.Content = _ctx.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.TextResult["+ i +"].Content");

				data_textResult.Add(textResultItem);
			}
			data.TextResult = data_textResult;

			List<GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_AudioResultItem> data_audioResult = new List<GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_AudioResultItem>();
			for (int i = 0; i < _ctx.Length("GetAIMediaAuditJob.MediaAuditJob.Data.AudioResult.Length"); i++) {
				GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_AudioResultItem audioResultItem = new GetAIMediaAuditJobResponse.GetAIMediaAuditJob_MediaAuditJob.GetAIMediaAuditJob_Data.GetAIMediaAuditJob_AudioResultItem();
				audioResultItem.Suggestion = _ctx.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.AudioResult["+ i +"].Suggestion");
				audioResultItem.Label = _ctx.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.AudioResult["+ i +"].Label");
				audioResultItem.Scene = _ctx.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.AudioResult["+ i +"].Scene");
				audioResultItem.Score = _ctx.StringValue("GetAIMediaAuditJob.MediaAuditJob.Data.AudioResult["+ i +"].Score");

				data_audioResult.Add(audioResultItem);
			}
			data.AudioResult = data_audioResult;
			mediaAuditJob.Data = data;
			getAIMediaAuditJobResponse.MediaAuditJob = mediaAuditJob;
        
			return getAIMediaAuditJobResponse;
        }
    }
}
