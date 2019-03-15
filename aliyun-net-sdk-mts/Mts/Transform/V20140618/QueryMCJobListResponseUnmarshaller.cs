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
using Aliyun.Acs.Mts.Model.V20140618;

namespace Aliyun.Acs.Mts.Transform.V20140618
{
    public class QueryMCJobListResponseUnmarshaller
    {
        public static QueryMCJobListResponse Unmarshall(UnmarshallerContext context)
        {
			QueryMCJobListResponse queryMCJobListResponse = new QueryMCJobListResponse();

			queryMCJobListResponse.HttpResponse = context.HttpResponse;
			queryMCJobListResponse.RequestId = context.StringValue("QueryMCJobList.RequestId");
			queryMCJobListResponse.NextPageToken = context.StringValue("QueryMCJobList.NextPageToken");

			List<string> queryMCJobListResponse_nonExistIds = new List<string>();
			for (int i = 0; i < context.Length("QueryMCJobList.NonExistIds.Length"); i++) {
				queryMCJobListResponse_nonExistIds.Add(context.StringValue("QueryMCJobList.NonExistIds["+ i +"]"));
			}
			queryMCJobListResponse.NonExistIds = queryMCJobListResponse_nonExistIds;

			List<QueryMCJobListResponse.QueryMCJobList_Job> queryMCJobListResponse_jobList = new List<QueryMCJobListResponse.QueryMCJobList_Job>();
			for (int i = 0; i < context.Length("QueryMCJobList.JobList.Length"); i++) {
				QueryMCJobListResponse.QueryMCJobList_Job job = new QueryMCJobListResponse.QueryMCJobList_Job();
				job.JobId = context.StringValue("QueryMCJobList.JobList["+ i +"].JobId");
				job.UserData = context.StringValue("QueryMCJobList.JobList["+ i +"].UserData");
				job.PipelineId = context.StringValue("QueryMCJobList.JobList["+ i +"].PipelineId");
				job.State = context.StringValue("QueryMCJobList.JobList["+ i +"].State");
				job.Code = context.StringValue("QueryMCJobList.JobList["+ i +"].Code");
				job.Message = context.StringValue("QueryMCJobList.JobList["+ i +"].Message");
				job.CreationTime = context.StringValue("QueryMCJobList.JobList["+ i +"].CreationTime");
				job.ResultOutputFile = context.StringValue("QueryMCJobList.JobList["+ i +"].ResultOutputFile");

				QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result result = new QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result();
				result.Suggestion = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.Suggestion");
				result.Score = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.Score");

				QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_PornResult pornResult = new QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_PornResult();

				List<QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_PornResult.QueryMCJobList_PornVideo> pornResult_pornVideos = new List<QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_PornResult.QueryMCJobList_PornVideo>();
				for (int j = 0; j < context.Length("QueryMCJobList.JobList["+ i +"].Result.PornResult.PornVideos.Length"); j++) {
					QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_PornResult.QueryMCJobList_PornVideo pornVideo = new QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_PornResult.QueryMCJobList_PornVideo();
					pornVideo.Suggestion = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.PornResult.PornVideos["+ j +"].Suggestion");
					pornVideo.Score = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.PornResult.PornVideos["+ j +"].Score");
					pornVideo.Time = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.PornResult.PornVideos["+ j +"].Time");
					pornVideo._Object = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.PornResult.PornVideos["+ j +"].Object");

					pornResult_pornVideos.Add(pornVideo);
				}
				pornResult.PornVideos = pornResult_pornVideos;

				List<QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_PornResult.QueryMCJobList_PornAudio> pornResult_pornAudios = new List<QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_PornResult.QueryMCJobList_PornAudio>();
				for (int j = 0; j < context.Length("QueryMCJobList.JobList["+ i +"].Result.PornResult.PornAudios.Length"); j++) {
					QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_PornResult.QueryMCJobList_PornAudio pornAudio = new QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_PornResult.QueryMCJobList_PornAudio();
					pornAudio.Suggestion = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.PornResult.PornAudios["+ j +"].Suggestion");
					pornAudio.Score = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.PornResult.PornAudios["+ j +"].Score");
					pornAudio.StartTime = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.PornResult.PornAudios["+ j +"].StartTime");
					pornAudio.EndTime = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.PornResult.PornAudios["+ j +"].EndTime");
					pornAudio.Text = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.PornResult.PornAudios["+ j +"].Text");
					pornAudio._Object = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.PornResult.PornAudios["+ j +"].Object");

					pornResult_pornAudios.Add(pornAudio);
				}
				pornResult.PornAudios = pornResult_pornAudios;

				List<QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_PornResult.QueryMCJobList_PornText> pornResult_pornTexts = new List<QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_PornResult.QueryMCJobList_PornText>();
				for (int j = 0; j < context.Length("QueryMCJobList.JobList["+ i +"].Result.PornResult.PornTexts.Length"); j++) {
					QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_PornResult.QueryMCJobList_PornText pornText = new QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_PornResult.QueryMCJobList_PornText();
					pornText.Suggestion = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.PornResult.PornTexts["+ j +"].Suggestion");
					pornText.Score = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.PornResult.PornTexts["+ j +"].Score");
					pornText.Text = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.PornResult.PornTexts["+ j +"].Text");

					pornResult_pornTexts.Add(pornText);
				}
				pornResult.PornTexts = pornResult_pornTexts;

				List<QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_PornResult.QueryMCJobList_PornImage> pornResult_pornImages = new List<QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_PornResult.QueryMCJobList_PornImage>();
				for (int j = 0; j < context.Length("QueryMCJobList.JobList["+ i +"].Result.PornResult.PornImages.Length"); j++) {
					QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_PornResult.QueryMCJobList_PornImage pornImage = new QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_PornResult.QueryMCJobList_PornImage();
					pornImage.Suggestion = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.PornResult.PornImages["+ j +"].Suggestion");
					pornImage.Score = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.PornResult.PornImages["+ j +"].Score");
					pornImage.Url = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.PornResult.PornImages["+ j +"].Url");
					pornImage.Text = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.PornResult.PornImages["+ j +"].Text");

					pornResult_pornImages.Add(pornImage);
				}
				pornResult.PornImages = pornResult_pornImages;

				List<QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_PornResult.QueryMCJobList_PornOcr> pornResult_pornOcrs = new List<QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_PornResult.QueryMCJobList_PornOcr>();
				for (int j = 0; j < context.Length("QueryMCJobList.JobList["+ i +"].Result.PornResult.PornOcrs.Length"); j++) {
					QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_PornResult.QueryMCJobList_PornOcr pornOcr = new QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_PornResult.QueryMCJobList_PornOcr();
					pornOcr.Suggestion = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.PornResult.PornOcrs["+ j +"].Suggestion");
					pornOcr.Score = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.PornResult.PornOcrs["+ j +"].Score");
					pornOcr.Time = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.PornResult.PornOcrs["+ j +"].Time");
					pornOcr._Object = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.PornResult.PornOcrs["+ j +"].Object");
					pornOcr.Text = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.PornResult.PornOcrs["+ j +"].Text");

					pornResult_pornOcrs.Add(pornOcr);
				}
				pornResult.PornOcrs = pornResult_pornOcrs;
				result.PornResult = pornResult;

				QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_TerrorismResult terrorismResult = new QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_TerrorismResult();

				List<QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_TerrorismResult.QueryMCJobList_TerrorismVideo> terrorismResult_terrorismVideos = new List<QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_TerrorismResult.QueryMCJobList_TerrorismVideo>();
				for (int j = 0; j < context.Length("QueryMCJobList.JobList["+ i +"].Result.TerrorismResult.TerrorismVideos.Length"); j++) {
					QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_TerrorismResult.QueryMCJobList_TerrorismVideo terrorismVideo = new QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_TerrorismResult.QueryMCJobList_TerrorismVideo();
					terrorismVideo.Suggestion = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.TerrorismResult.TerrorismVideos["+ j +"].Suggestion");
					terrorismVideo.Score = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.TerrorismResult.TerrorismVideos["+ j +"].Score");
					terrorismVideo.Time = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.TerrorismResult.TerrorismVideos["+ j +"].Time");
					terrorismVideo._Object = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.TerrorismResult.TerrorismVideos["+ j +"].Object");

					terrorismResult_terrorismVideos.Add(terrorismVideo);
				}
				terrorismResult.TerrorismVideos = terrorismResult_terrorismVideos;

				List<QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_TerrorismResult.QueryMCJobList_TerrorismAudio> terrorismResult_terrorismAudios = new List<QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_TerrorismResult.QueryMCJobList_TerrorismAudio>();
				for (int j = 0; j < context.Length("QueryMCJobList.JobList["+ i +"].Result.TerrorismResult.TerrorismAudios.Length"); j++) {
					QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_TerrorismResult.QueryMCJobList_TerrorismAudio terrorismAudio = new QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_TerrorismResult.QueryMCJobList_TerrorismAudio();
					terrorismAudio.Suggestion = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.TerrorismResult.TerrorismAudios["+ j +"].Suggestion");
					terrorismAudio.Score = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.TerrorismResult.TerrorismAudios["+ j +"].Score");
					terrorismAudio.StartTime = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.TerrorismResult.TerrorismAudios["+ j +"].StartTime");
					terrorismAudio.EndTime = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.TerrorismResult.TerrorismAudios["+ j +"].EndTime");
					terrorismAudio.Text = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.TerrorismResult.TerrorismAudios["+ j +"].Text");
					terrorismAudio._Object = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.TerrorismResult.TerrorismAudios["+ j +"].Object");

					terrorismResult_terrorismAudios.Add(terrorismAudio);
				}
				terrorismResult.TerrorismAudios = terrorismResult_terrorismAudios;

				List<QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_TerrorismResult.QueryMCJobList_TerrorismText> terrorismResult_terrorismTexts = new List<QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_TerrorismResult.QueryMCJobList_TerrorismText>();
				for (int j = 0; j < context.Length("QueryMCJobList.JobList["+ i +"].Result.TerrorismResult.TerrorismTexts.Length"); j++) {
					QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_TerrorismResult.QueryMCJobList_TerrorismText terrorismText = new QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_TerrorismResult.QueryMCJobList_TerrorismText();
					terrorismText.Suggestion = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.TerrorismResult.TerrorismTexts["+ j +"].Suggestion");
					terrorismText.Score = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.TerrorismResult.TerrorismTexts["+ j +"].Score");
					terrorismText.Text = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.TerrorismResult.TerrorismTexts["+ j +"].Text");

					terrorismResult_terrorismTexts.Add(terrorismText);
				}
				terrorismResult.TerrorismTexts = terrorismResult_terrorismTexts;

				List<QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_TerrorismResult.QueryMCJobList_TerrorismImage> terrorismResult_terrorismImages = new List<QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_TerrorismResult.QueryMCJobList_TerrorismImage>();
				for (int j = 0; j < context.Length("QueryMCJobList.JobList["+ i +"].Result.TerrorismResult.TerrorismImages.Length"); j++) {
					QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_TerrorismResult.QueryMCJobList_TerrorismImage terrorismImage = new QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_TerrorismResult.QueryMCJobList_TerrorismImage();
					terrorismImage.Suggestion = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.TerrorismResult.TerrorismImages["+ j +"].Suggestion");
					terrorismImage.Score = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.TerrorismResult.TerrorismImages["+ j +"].Score");
					terrorismImage.Url = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.TerrorismResult.TerrorismImages["+ j +"].Url");
					terrorismImage.Text = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.TerrorismResult.TerrorismImages["+ j +"].Text");

					terrorismResult_terrorismImages.Add(terrorismImage);
				}
				terrorismResult.TerrorismImages = terrorismResult_terrorismImages;

				List<QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_TerrorismResult.QueryMCJobList_TerrorismOcr> terrorismResult_terrorismOcrs = new List<QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_TerrorismResult.QueryMCJobList_TerrorismOcr>();
				for (int j = 0; j < context.Length("QueryMCJobList.JobList["+ i +"].Result.TerrorismResult.TerrorismOcrs.Length"); j++) {
					QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_TerrorismResult.QueryMCJobList_TerrorismOcr terrorismOcr = new QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_TerrorismResult.QueryMCJobList_TerrorismOcr();
					terrorismOcr.Suggestion = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.TerrorismResult.TerrorismOcrs["+ j +"].Suggestion");
					terrorismOcr.Score = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.TerrorismResult.TerrorismOcrs["+ j +"].Score");
					terrorismOcr.Time = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.TerrorismResult.TerrorismOcrs["+ j +"].Time");
					terrorismOcr._Object = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.TerrorismResult.TerrorismOcrs["+ j +"].Object");
					terrorismOcr.Text = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.TerrorismResult.TerrorismOcrs["+ j +"].Text");

					terrorismResult_terrorismOcrs.Add(terrorismOcr);
				}
				terrorismResult.TerrorismOcrs = terrorismResult_terrorismOcrs;
				result.TerrorismResult = terrorismResult;

				QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_PoliticsResult politicsResult = new QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_PoliticsResult();

				List<QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_PoliticsResult.QueryMCJobList_PoliticsVideo> politicsResult_politicsVideos = new List<QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_PoliticsResult.QueryMCJobList_PoliticsVideo>();
				for (int j = 0; j < context.Length("QueryMCJobList.JobList["+ i +"].Result.PoliticsResult.PoliticsVideos.Length"); j++) {
					QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_PoliticsResult.QueryMCJobList_PoliticsVideo politicsVideo = new QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_PoliticsResult.QueryMCJobList_PoliticsVideo();
					politicsVideo.Suggestion = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.PoliticsResult.PoliticsVideos["+ j +"].Suggestion");
					politicsVideo.Score = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.PoliticsResult.PoliticsVideos["+ j +"].Score");
					politicsVideo.Time = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.PoliticsResult.PoliticsVideos["+ j +"].Time");
					politicsVideo._Object = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.PoliticsResult.PoliticsVideos["+ j +"].Object");

					politicsResult_politicsVideos.Add(politicsVideo);
				}
				politicsResult.PoliticsVideos = politicsResult_politicsVideos;

				List<QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_PoliticsResult.QueryMCJobList_PoliticsAudio> politicsResult_politicsAudios = new List<QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_PoliticsResult.QueryMCJobList_PoliticsAudio>();
				for (int j = 0; j < context.Length("QueryMCJobList.JobList["+ i +"].Result.PoliticsResult.PoliticsAudios.Length"); j++) {
					QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_PoliticsResult.QueryMCJobList_PoliticsAudio politicsAudio = new QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_PoliticsResult.QueryMCJobList_PoliticsAudio();
					politicsAudio.Suggestion = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.PoliticsResult.PoliticsAudios["+ j +"].Suggestion");
					politicsAudio.Score = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.PoliticsResult.PoliticsAudios["+ j +"].Score");
					politicsAudio.StartTime = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.PoliticsResult.PoliticsAudios["+ j +"].StartTime");
					politicsAudio.EndTime = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.PoliticsResult.PoliticsAudios["+ j +"].EndTime");
					politicsAudio.Text = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.PoliticsResult.PoliticsAudios["+ j +"].Text");
					politicsAudio._Object = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.PoliticsResult.PoliticsAudios["+ j +"].Object");

					politicsResult_politicsAudios.Add(politicsAudio);
				}
				politicsResult.PoliticsAudios = politicsResult_politicsAudios;

				List<QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_PoliticsResult.QueryMCJobList_PoliticsText> politicsResult_politicsTexts = new List<QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_PoliticsResult.QueryMCJobList_PoliticsText>();
				for (int j = 0; j < context.Length("QueryMCJobList.JobList["+ i +"].Result.PoliticsResult.PoliticsTexts.Length"); j++) {
					QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_PoliticsResult.QueryMCJobList_PoliticsText politicsText = new QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_PoliticsResult.QueryMCJobList_PoliticsText();
					politicsText.Suggestion = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.PoliticsResult.PoliticsTexts["+ j +"].Suggestion");
					politicsText.Score = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.PoliticsResult.PoliticsTexts["+ j +"].Score");
					politicsText.Text = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.PoliticsResult.PoliticsTexts["+ j +"].Text");

					politicsResult_politicsTexts.Add(politicsText);
				}
				politicsResult.PoliticsTexts = politicsResult_politicsTexts;

				List<QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_PoliticsResult.QueryMCJobList_PoliticsImage> politicsResult_politicsImages = new List<QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_PoliticsResult.QueryMCJobList_PoliticsImage>();
				for (int j = 0; j < context.Length("QueryMCJobList.JobList["+ i +"].Result.PoliticsResult.PoliticsImages.Length"); j++) {
					QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_PoliticsResult.QueryMCJobList_PoliticsImage politicsImage = new QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_PoliticsResult.QueryMCJobList_PoliticsImage();
					politicsImage.Suggestion = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.PoliticsResult.PoliticsImages["+ j +"].Suggestion");
					politicsImage.Score = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.PoliticsResult.PoliticsImages["+ j +"].Score");
					politicsImage.Url = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.PoliticsResult.PoliticsImages["+ j +"].Url");
					politicsImage.Text = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.PoliticsResult.PoliticsImages["+ j +"].Text");

					politicsResult_politicsImages.Add(politicsImage);
				}
				politicsResult.PoliticsImages = politicsResult_politicsImages;

				List<QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_PoliticsResult.QueryMCJobList_PoliticsOcr> politicsResult_politicsOcrs = new List<QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_PoliticsResult.QueryMCJobList_PoliticsOcr>();
				for (int j = 0; j < context.Length("QueryMCJobList.JobList["+ i +"].Result.PoliticsResult.PoliticsOcrs.Length"); j++) {
					QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_PoliticsResult.QueryMCJobList_PoliticsOcr politicsOcr = new QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_PoliticsResult.QueryMCJobList_PoliticsOcr();
					politicsOcr.Suggestion = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.PoliticsResult.PoliticsOcrs["+ j +"].Suggestion");
					politicsOcr.Score = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.PoliticsResult.PoliticsOcrs["+ j +"].Score");
					politicsOcr.Time = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.PoliticsResult.PoliticsOcrs["+ j +"].Time");
					politicsOcr._Object = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.PoliticsResult.PoliticsOcrs["+ j +"].Object");
					politicsOcr.Text = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.PoliticsResult.PoliticsOcrs["+ j +"].Text");

					politicsResult_politicsOcrs.Add(politicsOcr);
				}
				politicsResult.PoliticsOcrs = politicsResult_politicsOcrs;
				result.PoliticsResult = politicsResult;

				QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_AdResult adResult = new QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_AdResult();

				List<QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_AdResult.QueryMCJobList_AdVideo> adResult_adVideos = new List<QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_AdResult.QueryMCJobList_AdVideo>();
				for (int j = 0; j < context.Length("QueryMCJobList.JobList["+ i +"].Result.AdResult.AdVideos.Length"); j++) {
					QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_AdResult.QueryMCJobList_AdVideo adVideo = new QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_AdResult.QueryMCJobList_AdVideo();
					adVideo.Suggestion = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.AdResult.AdVideos["+ j +"].Suggestion");
					adVideo.Score = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.AdResult.AdVideos["+ j +"].Score");
					adVideo.Time = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.AdResult.AdVideos["+ j +"].Time");
					adVideo._Object = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.AdResult.AdVideos["+ j +"].Object");

					adResult_adVideos.Add(adVideo);
				}
				adResult.AdVideos = adResult_adVideos;

				List<QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_AdResult.QueryMCJobList_AdAudio> adResult_adAudios = new List<QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_AdResult.QueryMCJobList_AdAudio>();
				for (int j = 0; j < context.Length("QueryMCJobList.JobList["+ i +"].Result.AdResult.AdAudios.Length"); j++) {
					QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_AdResult.QueryMCJobList_AdAudio adAudio = new QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_AdResult.QueryMCJobList_AdAudio();
					adAudio.Suggestion = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.AdResult.AdAudios["+ j +"].Suggestion");
					adAudio.Score = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.AdResult.AdAudios["+ j +"].Score");
					adAudio.StartTime = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.AdResult.AdAudios["+ j +"].StartTime");
					adAudio.EndTime = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.AdResult.AdAudios["+ j +"].EndTime");
					adAudio.Text = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.AdResult.AdAudios["+ j +"].Text");
					adAudio._Object = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.AdResult.AdAudios["+ j +"].Object");

					adResult_adAudios.Add(adAudio);
				}
				adResult.AdAudios = adResult_adAudios;

				List<QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_AdResult.QueryMCJobList_AdText> adResult_adTexts = new List<QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_AdResult.QueryMCJobList_AdText>();
				for (int j = 0; j < context.Length("QueryMCJobList.JobList["+ i +"].Result.AdResult.AdTexts.Length"); j++) {
					QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_AdResult.QueryMCJobList_AdText adText = new QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_AdResult.QueryMCJobList_AdText();
					adText.Suggestion = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.AdResult.AdTexts["+ j +"].Suggestion");
					adText.Score = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.AdResult.AdTexts["+ j +"].Score");
					adText.Text = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.AdResult.AdTexts["+ j +"].Text");

					adResult_adTexts.Add(adText);
				}
				adResult.AdTexts = adResult_adTexts;

				List<QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_AdResult.QueryMCJobList_AdImage> adResult_adImages = new List<QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_AdResult.QueryMCJobList_AdImage>();
				for (int j = 0; j < context.Length("QueryMCJobList.JobList["+ i +"].Result.AdResult.AdImages.Length"); j++) {
					QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_AdResult.QueryMCJobList_AdImage adImage = new QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_AdResult.QueryMCJobList_AdImage();
					adImage.Suggestion = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.AdResult.AdImages["+ j +"].Suggestion");
					adImage.Score = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.AdResult.AdImages["+ j +"].Score");
					adImage.Url = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.AdResult.AdImages["+ j +"].Url");
					adImage.Text = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.AdResult.AdImages["+ j +"].Text");

					adResult_adImages.Add(adImage);
				}
				adResult.AdImages = adResult_adImages;

				List<QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_AdResult.QueryMCJobList_AdOcr> adResult_adOcrs = new List<QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_AdResult.QueryMCJobList_AdOcr>();
				for (int j = 0; j < context.Length("QueryMCJobList.JobList["+ i +"].Result.AdResult.AdOcrs.Length"); j++) {
					QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_AdResult.QueryMCJobList_AdOcr adOcr = new QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_AdResult.QueryMCJobList_AdOcr();
					adOcr.Suggestion = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.AdResult.AdOcrs["+ j +"].Suggestion");
					adOcr.Score = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.AdResult.AdOcrs["+ j +"].Score");
					adOcr.Time = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.AdResult.AdOcrs["+ j +"].Time");
					adOcr._Object = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.AdResult.AdOcrs["+ j +"].Object");
					adOcr.Text = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.AdResult.AdOcrs["+ j +"].Text");

					adResult_adOcrs.Add(adOcr);
				}
				adResult.AdOcrs = adResult_adOcrs;
				result.AdResult = adResult;

				QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_QrcodeResult qrcodeResult = new QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_QrcodeResult();

				List<QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_QrcodeResult.QueryMCJobList_QrcodeVideo> qrcodeResult_qrcodeVideos = new List<QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_QrcodeResult.QueryMCJobList_QrcodeVideo>();
				for (int j = 0; j < context.Length("QueryMCJobList.JobList["+ i +"].Result.QrcodeResult.QrcodeVideos.Length"); j++) {
					QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_QrcodeResult.QueryMCJobList_QrcodeVideo qrcodeVideo = new QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_QrcodeResult.QueryMCJobList_QrcodeVideo();
					qrcodeVideo.Suggestion = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.QrcodeResult.QrcodeVideos["+ j +"].Suggestion");
					qrcodeVideo.Score = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.QrcodeResult.QrcodeVideos["+ j +"].Score");
					qrcodeVideo.Time = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.QrcodeResult.QrcodeVideos["+ j +"].Time");
					qrcodeVideo._Object = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.QrcodeResult.QrcodeVideos["+ j +"].Object");

					qrcodeResult_qrcodeVideos.Add(qrcodeVideo);
				}
				qrcodeResult.QrcodeVideos = qrcodeResult_qrcodeVideos;

				List<QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_QrcodeResult.QueryMCJobList_QrcodeImage> qrcodeResult_qrcodeImages = new List<QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_QrcodeResult.QueryMCJobList_QrcodeImage>();
				for (int j = 0; j < context.Length("QueryMCJobList.JobList["+ i +"].Result.QrcodeResult.QrcodeImages.Length"); j++) {
					QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_QrcodeResult.QueryMCJobList_QrcodeImage qrcodeImage = new QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_QrcodeResult.QueryMCJobList_QrcodeImage();
					qrcodeImage.Suggestion = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.QrcodeResult.QrcodeImages["+ j +"].Suggestion");
					qrcodeImage.Score = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.QrcodeResult.QrcodeImages["+ j +"].Score");
					qrcodeImage.Url = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.QrcodeResult.QrcodeImages["+ j +"].Url");
					qrcodeImage.Text = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.QrcodeResult.QrcodeImages["+ j +"].Text");

					qrcodeResult_qrcodeImages.Add(qrcodeImage);
				}
				qrcodeResult.QrcodeImages = qrcodeResult_qrcodeImages;
				result.QrcodeResult = qrcodeResult;

				QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_LiveResult liveResult = new QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_LiveResult();

				List<QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_LiveResult.QueryMCJobList_LiveVideo> liveResult_liveVideos = new List<QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_LiveResult.QueryMCJobList_LiveVideo>();
				for (int j = 0; j < context.Length("QueryMCJobList.JobList["+ i +"].Result.LiveResult.LiveVideos.Length"); j++) {
					QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_LiveResult.QueryMCJobList_LiveVideo liveVideo = new QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_LiveResult.QueryMCJobList_LiveVideo();
					liveVideo.Suggestion = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.LiveResult.LiveVideos["+ j +"].Suggestion");
					liveVideo.Score = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.LiveResult.LiveVideos["+ j +"].Score");
					liveVideo.Time = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.LiveResult.LiveVideos["+ j +"].Time");
					liveVideo._Object = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.LiveResult.LiveVideos["+ j +"].Object");

					liveResult_liveVideos.Add(liveVideo);
				}
				liveResult.LiveVideos = liveResult_liveVideos;

				List<QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_LiveResult.QueryMCJobList_LiveImage> liveResult_liveImages = new List<QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_LiveResult.QueryMCJobList_LiveImage>();
				for (int j = 0; j < context.Length("QueryMCJobList.JobList["+ i +"].Result.LiveResult.LiveImages.Length"); j++) {
					QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_LiveResult.QueryMCJobList_LiveImage liveImage = new QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_LiveResult.QueryMCJobList_LiveImage();
					liveImage.Suggestion = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.LiveResult.LiveImages["+ j +"].Suggestion");
					liveImage.Score = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.LiveResult.LiveImages["+ j +"].Score");
					liveImage.Url = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.LiveResult.LiveImages["+ j +"].Url");
					liveImage.Text = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.LiveResult.LiveImages["+ j +"].Text");

					liveResult_liveImages.Add(liveImage);
				}
				liveResult.LiveImages = liveResult_liveImages;
				result.LiveResult = liveResult;

				QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_LogoResult logoResult = new QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_LogoResult();

				List<QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_LogoResult.QueryMCJobList_LogoVideo> logoResult_logoVideos = new List<QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_LogoResult.QueryMCJobList_LogoVideo>();
				for (int j = 0; j < context.Length("QueryMCJobList.JobList["+ i +"].Result.LogoResult.LogoVideos.Length"); j++) {
					QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_LogoResult.QueryMCJobList_LogoVideo logoVideo = new QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_LogoResult.QueryMCJobList_LogoVideo();
					logoVideo.Suggestion = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.LogoResult.LogoVideos["+ j +"].Suggestion");
					logoVideo.Score = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.LogoResult.LogoVideos["+ j +"].Score");
					logoVideo.Time = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.LogoResult.LogoVideos["+ j +"].Time");
					logoVideo._Object = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.LogoResult.LogoVideos["+ j +"].Object");

					logoResult_logoVideos.Add(logoVideo);
				}
				logoResult.LogoVideos = logoResult_logoVideos;

				List<QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_LogoResult.QueryMCJobList_LogoImage> logoResult_logoImages = new List<QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_LogoResult.QueryMCJobList_LogoImage>();
				for (int j = 0; j < context.Length("QueryMCJobList.JobList["+ i +"].Result.LogoResult.LogoImages.Length"); j++) {
					QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_LogoResult.QueryMCJobList_LogoImage logoImage = new QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_LogoResult.QueryMCJobList_LogoImage();
					logoImage.Suggestion = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.LogoResult.LogoImages["+ j +"].Suggestion");
					logoImage.Score = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.LogoResult.LogoImages["+ j +"].Score");
					logoImage.Url = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.LogoResult.LogoImages["+ j +"].Url");
					logoImage.Text = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.LogoResult.LogoImages["+ j +"].Text");

					logoResult_logoImages.Add(logoImage);
				}
				logoResult.LogoImages = logoResult_logoImages;
				result.LogoResult = logoResult;

				QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_AbuseResult abuseResult = new QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_AbuseResult();

				List<QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_AbuseResult.QueryMCJobList_AbuseAudio> abuseResult_abuseAudios = new List<QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_AbuseResult.QueryMCJobList_AbuseAudio>();
				for (int j = 0; j < context.Length("QueryMCJobList.JobList["+ i +"].Result.AbuseResult.AbuseAudios.Length"); j++) {
					QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_AbuseResult.QueryMCJobList_AbuseAudio abuseAudio = new QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_AbuseResult.QueryMCJobList_AbuseAudio();
					abuseAudio.Suggestion = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.AbuseResult.AbuseAudios["+ j +"].Suggestion");
					abuseAudio.Score = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.AbuseResult.AbuseAudios["+ j +"].Score");
					abuseAudio.StartTime = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.AbuseResult.AbuseAudios["+ j +"].StartTime");
					abuseAudio.EndTime = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.AbuseResult.AbuseAudios["+ j +"].EndTime");
					abuseAudio.Text = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.AbuseResult.AbuseAudios["+ j +"].Text");
					abuseAudio._Object = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.AbuseResult.AbuseAudios["+ j +"].Object");

					abuseResult_abuseAudios.Add(abuseAudio);
				}
				abuseResult.AbuseAudios = abuseResult_abuseAudios;

				List<QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_AbuseResult.QueryMCJobList_AbuseText> abuseResult_abuseTexts = new List<QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_AbuseResult.QueryMCJobList_AbuseText>();
				for (int j = 0; j < context.Length("QueryMCJobList.JobList["+ i +"].Result.AbuseResult.AbuseTexts.Length"); j++) {
					QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_AbuseResult.QueryMCJobList_AbuseText abuseText = new QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_AbuseResult.QueryMCJobList_AbuseText();
					abuseText.Suggestion = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.AbuseResult.AbuseTexts["+ j +"].Suggestion");
					abuseText.Score = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.AbuseResult.AbuseTexts["+ j +"].Score");
					abuseText.Text = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.AbuseResult.AbuseTexts["+ j +"].Text");

					abuseResult_abuseTexts.Add(abuseText);
				}
				abuseResult.AbuseTexts = abuseResult_abuseTexts;

				List<QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_AbuseResult.QueryMCJobList_AbuseOcr> abuseResult_abuseOcrs = new List<QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_AbuseResult.QueryMCJobList_AbuseOcr>();
				for (int j = 0; j < context.Length("QueryMCJobList.JobList["+ i +"].Result.AbuseResult.AbuseOcrs.Length"); j++) {
					QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_AbuseResult.QueryMCJobList_AbuseOcr abuseOcr = new QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_AbuseResult.QueryMCJobList_AbuseOcr();
					abuseOcr.Suggestion = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.AbuseResult.AbuseOcrs["+ j +"].Suggestion");
					abuseOcr.Score = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.AbuseResult.AbuseOcrs["+ j +"].Score");
					abuseOcr.Time = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.AbuseResult.AbuseOcrs["+ j +"].Time");
					abuseOcr._Object = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.AbuseResult.AbuseOcrs["+ j +"].Object");
					abuseOcr.Text = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.AbuseResult.AbuseOcrs["+ j +"].Text");

					abuseResult_abuseOcrs.Add(abuseOcr);
				}
				abuseResult.AbuseOcrs = abuseResult_abuseOcrs;
				result.AbuseResult = abuseResult;

				QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_ContrabandResult contrabandResult = new QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_ContrabandResult();

				List<QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_ContrabandResult.QueryMCJobList_ContrabandAudio> contrabandResult_contrabandAudios = new List<QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_ContrabandResult.QueryMCJobList_ContrabandAudio>();
				for (int j = 0; j < context.Length("QueryMCJobList.JobList["+ i +"].Result.ContrabandResult.ContrabandAudios.Length"); j++) {
					QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_ContrabandResult.QueryMCJobList_ContrabandAudio contrabandAudio = new QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_ContrabandResult.QueryMCJobList_ContrabandAudio();
					contrabandAudio.Suggestion = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.ContrabandResult.ContrabandAudios["+ j +"].Suggestion");
					contrabandAudio.Score = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.ContrabandResult.ContrabandAudios["+ j +"].Score");
					contrabandAudio.StartTime = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.ContrabandResult.ContrabandAudios["+ j +"].StartTime");
					contrabandAudio.EndTime = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.ContrabandResult.ContrabandAudios["+ j +"].EndTime");
					contrabandAudio.Text = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.ContrabandResult.ContrabandAudios["+ j +"].Text");
					contrabandAudio._Object = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.ContrabandResult.ContrabandAudios["+ j +"].Object");

					contrabandResult_contrabandAudios.Add(contrabandAudio);
				}
				contrabandResult.ContrabandAudios = contrabandResult_contrabandAudios;

				List<QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_ContrabandResult.QueryMCJobList_ContrabandText> contrabandResult_contrabandTexts = new List<QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_ContrabandResult.QueryMCJobList_ContrabandText>();
				for (int j = 0; j < context.Length("QueryMCJobList.JobList["+ i +"].Result.ContrabandResult.ContrabandTexts.Length"); j++) {
					QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_ContrabandResult.QueryMCJobList_ContrabandText contrabandText = new QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_ContrabandResult.QueryMCJobList_ContrabandText();
					contrabandText.Suggestion = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.ContrabandResult.ContrabandTexts["+ j +"].Suggestion");
					contrabandText.Score = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.ContrabandResult.ContrabandTexts["+ j +"].Score");
					contrabandText.Text = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.ContrabandResult.ContrabandTexts["+ j +"].Text");

					contrabandResult_contrabandTexts.Add(contrabandText);
				}
				contrabandResult.ContrabandTexts = contrabandResult_contrabandTexts;

				List<QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_ContrabandResult.QueryMCJobList_ContrabandOcr> contrabandResult_contrabandOcrs = new List<QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_ContrabandResult.QueryMCJobList_ContrabandOcr>();
				for (int j = 0; j < context.Length("QueryMCJobList.JobList["+ i +"].Result.ContrabandResult.ContrabandOcrs.Length"); j++) {
					QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_ContrabandResult.QueryMCJobList_ContrabandOcr contrabandOcr = new QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_ContrabandResult.QueryMCJobList_ContrabandOcr();
					contrabandOcr.Suggestion = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.ContrabandResult.ContrabandOcrs["+ j +"].Suggestion");
					contrabandOcr.Score = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.ContrabandResult.ContrabandOcrs["+ j +"].Score");
					contrabandOcr.Time = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.ContrabandResult.ContrabandOcrs["+ j +"].Time");
					contrabandOcr._Object = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.ContrabandResult.ContrabandOcrs["+ j +"].Object");
					contrabandOcr.Text = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.ContrabandResult.ContrabandOcrs["+ j +"].Text");

					contrabandResult_contrabandOcrs.Add(contrabandOcr);
				}
				contrabandResult.ContrabandOcrs = contrabandResult_contrabandOcrs;
				result.ContrabandResult = contrabandResult;

				QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_SpamResult spamResult = new QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_SpamResult();

				List<QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_SpamResult.QueryMCJobList_SpamAudio> spamResult_spamAudios = new List<QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_SpamResult.QueryMCJobList_SpamAudio>();
				for (int j = 0; j < context.Length("QueryMCJobList.JobList["+ i +"].Result.SpamResult.SpamAudios.Length"); j++) {
					QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_SpamResult.QueryMCJobList_SpamAudio spamAudio = new QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_SpamResult.QueryMCJobList_SpamAudio();
					spamAudio.Suggestion = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.SpamResult.SpamAudios["+ j +"].Suggestion");
					spamAudio.Score = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.SpamResult.SpamAudios["+ j +"].Score");
					spamAudio.StartTime = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.SpamResult.SpamAudios["+ j +"].StartTime");
					spamAudio.EndTime = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.SpamResult.SpamAudios["+ j +"].EndTime");
					spamAudio.Text = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.SpamResult.SpamAudios["+ j +"].Text");
					spamAudio._Object = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.SpamResult.SpamAudios["+ j +"].Object");

					spamResult_spamAudios.Add(spamAudio);
				}
				spamResult.SpamAudios = spamResult_spamAudios;

				List<QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_SpamResult.QueryMCJobList_SpamText> spamResult_spamTexts = new List<QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_SpamResult.QueryMCJobList_SpamText>();
				for (int j = 0; j < context.Length("QueryMCJobList.JobList["+ i +"].Result.SpamResult.SpamTexts.Length"); j++) {
					QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_SpamResult.QueryMCJobList_SpamText spamText = new QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_SpamResult.QueryMCJobList_SpamText();
					spamText.Suggestion = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.SpamResult.SpamTexts["+ j +"].Suggestion");
					spamText.Score = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.SpamResult.SpamTexts["+ j +"].Score");
					spamText.Text = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.SpamResult.SpamTexts["+ j +"].Text");

					spamResult_spamTexts.Add(spamText);
				}
				spamResult.SpamTexts = spamResult_spamTexts;

				List<QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_SpamResult.QueryMCJobList_SpamOcr> spamResult_spamOcrs = new List<QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_SpamResult.QueryMCJobList_SpamOcr>();
				for (int j = 0; j < context.Length("QueryMCJobList.JobList["+ i +"].Result.SpamResult.SpamOcrs.Length"); j++) {
					QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_SpamResult.QueryMCJobList_SpamOcr spamOcr = new QueryMCJobListResponse.QueryMCJobList_Job.QueryMCJobList_Result.QueryMCJobList_SpamResult.QueryMCJobList_SpamOcr();
					spamOcr.Suggestion = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.SpamResult.SpamOcrs["+ j +"].Suggestion");
					spamOcr.Score = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.SpamResult.SpamOcrs["+ j +"].Score");
					spamOcr.Time = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.SpamResult.SpamOcrs["+ j +"].Time");
					spamOcr._Object = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.SpamResult.SpamOcrs["+ j +"].Object");
					spamOcr.Text = context.StringValue("QueryMCJobList.JobList["+ i +"].Result.SpamResult.SpamOcrs["+ j +"].Text");

					spamResult_spamOcrs.Add(spamOcr);
				}
				spamResult.SpamOcrs = spamResult_spamOcrs;
				result.SpamResult = spamResult;
				job.Result = result;

				queryMCJobListResponse_jobList.Add(job);
			}
			queryMCJobListResponse.JobList = queryMCJobListResponse_jobList;
        
			return queryMCJobListResponse;
        }
    }
}
