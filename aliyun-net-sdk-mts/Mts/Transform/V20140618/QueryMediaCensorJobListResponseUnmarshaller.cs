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
    public class QueryMediaCensorJobListResponseUnmarshaller
    {
        public static QueryMediaCensorJobListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryMediaCensorJobListResponse queryMediaCensorJobListResponse = new QueryMediaCensorJobListResponse();

			queryMediaCensorJobListResponse.HttpResponse = _ctx.HttpResponse;
			queryMediaCensorJobListResponse.RequestId = _ctx.StringValue("QueryMediaCensorJobList.RequestId");
			queryMediaCensorJobListResponse.NextPageToken = _ctx.StringValue("QueryMediaCensorJobList.NextPageToken");

			List<string> queryMediaCensorJobListResponse_nonExistIds = new List<string>();
			for (int i = 0; i < _ctx.Length("QueryMediaCensorJobList.NonExistIds.Length"); i++) {
				queryMediaCensorJobListResponse_nonExistIds.Add(_ctx.StringValue("QueryMediaCensorJobList.NonExistIds["+ i +"]"));
			}
			queryMediaCensorJobListResponse.NonExistIds = queryMediaCensorJobListResponse_nonExistIds;

			List<QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob> queryMediaCensorJobListResponse_mediaCensorJobList = new List<QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob>();
			for (int i = 0; i < _ctx.Length("QueryMediaCensorJobList.MediaCensorJobList.Length"); i++) {
				QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob mediaCensorJob = new QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob();
				mediaCensorJob.CreationTime = _ctx.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].CreationTime");
				mediaCensorJob.FinishTime = _ctx.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].FinishTime");
				mediaCensorJob.Suggestion = _ctx.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].Suggestion");
				mediaCensorJob.State = _ctx.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].State");
				mediaCensorJob.Message = _ctx.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].Message");
				mediaCensorJob.JobId = _ctx.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].JobId");
				mediaCensorJob.UserData = _ctx.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].UserData");
				mediaCensorJob.Code = _ctx.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].Code");
				mediaCensorJob.PipelineId = _ctx.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].PipelineId");

				QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob.QueryMediaCensorJobList_TitleCensorResult titleCensorResult = new QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob.QueryMediaCensorJobList_TitleCensorResult();
				titleCensorResult.Suggestion = _ctx.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].TitleCensorResult.Suggestion");
				titleCensorResult.Label = _ctx.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].TitleCensorResult.Label");
				titleCensorResult.Scene = _ctx.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].TitleCensorResult.Scene");
				titleCensorResult.Rate = _ctx.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].TitleCensorResult.Rate");
				mediaCensorJob.TitleCensorResult = titleCensorResult;

				QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob.QueryMediaCensorJobList_Input input = new QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob.QueryMediaCensorJobList_Input();
				input._Object = _ctx.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].Input.Object");
				input.Location = _ctx.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].Input.Location");
				input.Bucket = _ctx.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].Input.Bucket");
				mediaCensorJob.Input = input;

				QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob.QueryMediaCensorJobList_BarrageCensorResult barrageCensorResult = new QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob.QueryMediaCensorJobList_BarrageCensorResult();
				barrageCensorResult.Suggestion = _ctx.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].BarrageCensorResult.Suggestion");
				barrageCensorResult.Label = _ctx.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].BarrageCensorResult.Label");
				barrageCensorResult.Scene = _ctx.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].BarrageCensorResult.Scene");
				barrageCensorResult.Rate = _ctx.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].BarrageCensorResult.Rate");
				mediaCensorJob.BarrageCensorResult = barrageCensorResult;

				QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob.QueryMediaCensorJobList_DescCensorResult descCensorResult = new QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob.QueryMediaCensorJobList_DescCensorResult();
				descCensorResult.Suggestion = _ctx.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].DescCensorResult.Suggestion");
				descCensorResult.Label = _ctx.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].DescCensorResult.Label");
				descCensorResult.Scene = _ctx.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].DescCensorResult.Scene");
				descCensorResult.Rate = _ctx.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].DescCensorResult.Rate");
				mediaCensorJob.DescCensorResult = descCensorResult;

				QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob.QueryMediaCensorJobList_VideoCensorConfig videoCensorConfig = new QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob.QueryMediaCensorJobList_VideoCensorConfig();
				videoCensorConfig.VideoCensor = _ctx.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].VideoCensorConfig.VideoCensor");
				videoCensorConfig.BizType = _ctx.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].VideoCensorConfig.BizType");

				QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob.QueryMediaCensorJobList_VideoCensorConfig.QueryMediaCensorJobList_OutputFile outputFile = new QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob.QueryMediaCensorJobList_VideoCensorConfig.QueryMediaCensorJobList_OutputFile();
				outputFile._Object = _ctx.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].VideoCensorConfig.OutputFile.Object");
				outputFile.Location = _ctx.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].VideoCensorConfig.OutputFile.Location");
				outputFile.Bucket = _ctx.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].VideoCensorConfig.OutputFile.Bucket");
				videoCensorConfig.OutputFile = outputFile;
				mediaCensorJob.VideoCensorConfig = videoCensorConfig;

				QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob.QueryMediaCensorJobList_VensorCensorResult vensorCensorResult = new QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob.QueryMediaCensorJobList_VensorCensorResult();
				vensorCensorResult.NextPageToken = _ctx.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].VensorCensorResult.NextPageToken");

				List<QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob.QueryMediaCensorJobList_VensorCensorResult.QueryMediaCensorJobList_VideoTimeline> vensorCensorResult_videoTimelines = new List<QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob.QueryMediaCensorJobList_VensorCensorResult.QueryMediaCensorJobList_VideoTimeline>();
				for (int j = 0; j < _ctx.Length("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].VensorCensorResult.VideoTimelines.Length"); j++) {
					QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob.QueryMediaCensorJobList_VensorCensorResult.QueryMediaCensorJobList_VideoTimeline videoTimeline = new QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob.QueryMediaCensorJobList_VensorCensorResult.QueryMediaCensorJobList_VideoTimeline();
					videoTimeline.Timestamp = _ctx.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].VensorCensorResult.VideoTimelines["+ j +"].Timestamp");
					videoTimeline._Object = _ctx.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].VensorCensorResult.VideoTimelines["+ j +"].Object");

					List<QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob.QueryMediaCensorJobList_VensorCensorResult.QueryMediaCensorJobList_VideoTimeline.QueryMediaCensorJobList_CensorResult> videoTimeline_censorResults1 = new List<QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob.QueryMediaCensorJobList_VensorCensorResult.QueryMediaCensorJobList_VideoTimeline.QueryMediaCensorJobList_CensorResult>();
					for (int k = 0; k < _ctx.Length("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].VensorCensorResult.VideoTimelines["+ j +"].CensorResults.Length"); k++) {
						QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob.QueryMediaCensorJobList_VensorCensorResult.QueryMediaCensorJobList_VideoTimeline.QueryMediaCensorJobList_CensorResult censorResult = new QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob.QueryMediaCensorJobList_VensorCensorResult.QueryMediaCensorJobList_VideoTimeline.QueryMediaCensorJobList_CensorResult();
						censorResult.Suggestion = _ctx.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].VensorCensorResult.VideoTimelines["+ j +"].CensorResults["+ k +"].Suggestion");
						censorResult.Label = _ctx.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].VensorCensorResult.VideoTimelines["+ j +"].CensorResults["+ k +"].Label");
						censorResult.Scene = _ctx.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].VensorCensorResult.VideoTimelines["+ j +"].CensorResults["+ k +"].Scene");
						censorResult.Rate = _ctx.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].VensorCensorResult.VideoTimelines["+ j +"].CensorResults["+ k +"].Rate");

						videoTimeline_censorResults1.Add(censorResult);
					}
					videoTimeline.CensorResults1 = videoTimeline_censorResults1;

					vensorCensorResult_videoTimelines.Add(videoTimeline);
				}
				vensorCensorResult.VideoTimelines = vensorCensorResult_videoTimelines;

				List<QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob.QueryMediaCensorJobList_VensorCensorResult.QueryMediaCensorJobList_CensorResult2> vensorCensorResult_censorResults = new List<QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob.QueryMediaCensorJobList_VensorCensorResult.QueryMediaCensorJobList_CensorResult2>();
				for (int j = 0; j < _ctx.Length("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].VensorCensorResult.CensorResults.Length"); j++) {
					QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob.QueryMediaCensorJobList_VensorCensorResult.QueryMediaCensorJobList_CensorResult2 censorResult2 = new QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob.QueryMediaCensorJobList_VensorCensorResult.QueryMediaCensorJobList_CensorResult2();
					censorResult2.Suggestion = _ctx.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].VensorCensorResult.CensorResults["+ j +"].Suggestion");
					censorResult2.Label = _ctx.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].VensorCensorResult.CensorResults["+ j +"].Label");
					censorResult2.Scene = _ctx.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].VensorCensorResult.CensorResults["+ j +"].Scene");
					censorResult2.Rate = _ctx.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].VensorCensorResult.CensorResults["+ j +"].Rate");

					vensorCensorResult_censorResults.Add(censorResult2);
				}
				vensorCensorResult.CensorResults = vensorCensorResult_censorResults;
				mediaCensorJob.VensorCensorResult = vensorCensorResult;

				QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob.QueryMediaCensorJobList_AudioCensorResult audioCensorResult = new QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob.QueryMediaCensorJobList_AudioCensorResult();
				audioCensorResult.Suggestion = _ctx.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].AudioCensorResult.Suggestion");
				audioCensorResult.Label = _ctx.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].AudioCensorResult.Label");
				mediaCensorJob.AudioCensorResult = audioCensorResult;

				List<QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob.QueryMediaCensorJobList_CoverImageCensorResult> mediaCensorJob_coverImageCensorResults = new List<QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob.QueryMediaCensorJobList_CoverImageCensorResult>();
				for (int j = 0; j < _ctx.Length("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].CoverImageCensorResults.Length"); j++) {
					QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob.QueryMediaCensorJobList_CoverImageCensorResult coverImageCensorResult = new QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob.QueryMediaCensorJobList_CoverImageCensorResult();
					coverImageCensorResult._Object = _ctx.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].CoverImageCensorResults["+ j +"].Object");
					coverImageCensorResult.Location = _ctx.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].CoverImageCensorResults["+ j +"].Location");
					coverImageCensorResult.Bucket = _ctx.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].CoverImageCensorResults["+ j +"].Bucket");

					List<QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob.QueryMediaCensorJobList_CoverImageCensorResult.QueryMediaCensorJobList_Result> coverImageCensorResult_results = new List<QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob.QueryMediaCensorJobList_CoverImageCensorResult.QueryMediaCensorJobList_Result>();
					for (int k = 0; k < _ctx.Length("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].CoverImageCensorResults["+ j +"].Results.Length"); k++) {
						QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob.QueryMediaCensorJobList_CoverImageCensorResult.QueryMediaCensorJobList_Result result = new QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob.QueryMediaCensorJobList_CoverImageCensorResult.QueryMediaCensorJobList_Result();
						result.Suggestion = _ctx.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].CoverImageCensorResults["+ j +"].Results["+ k +"].Suggestion");
						result.Label = _ctx.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].CoverImageCensorResults["+ j +"].Results["+ k +"].Label");
						result.Scene = _ctx.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].CoverImageCensorResults["+ j +"].Results["+ k +"].Scene");
						result.Rate = _ctx.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].CoverImageCensorResults["+ j +"].Results["+ k +"].Rate");

						coverImageCensorResult_results.Add(result);
					}
					coverImageCensorResult.Results = coverImageCensorResult_results;

					mediaCensorJob_coverImageCensorResults.Add(coverImageCensorResult);
				}
				mediaCensorJob.CoverImageCensorResults = mediaCensorJob_coverImageCensorResults;

				queryMediaCensorJobListResponse_mediaCensorJobList.Add(mediaCensorJob);
			}
			queryMediaCensorJobListResponse.MediaCensorJobList = queryMediaCensorJobListResponse_mediaCensorJobList;
        
			return queryMediaCensorJobListResponse;
        }
    }
}
