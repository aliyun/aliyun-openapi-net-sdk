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
        public static QueryMediaCensorJobListResponse Unmarshall(UnmarshallerContext context)
        {
			QueryMediaCensorJobListResponse queryMediaCensorJobListResponse = new QueryMediaCensorJobListResponse();

			queryMediaCensorJobListResponse.HttpResponse = context.HttpResponse;
			queryMediaCensorJobListResponse.RequestId = context.StringValue("QueryMediaCensorJobList.RequestId");
			queryMediaCensorJobListResponse.NextPageToken = context.StringValue("QueryMediaCensorJobList.NextPageToken");

			List<string> queryMediaCensorJobListResponse_nonExistIds = new List<string>();
			for (int i = 0; i < context.Length("QueryMediaCensorJobList.NonExistIds.Length"); i++) {
				queryMediaCensorJobListResponse_nonExistIds.Add(context.StringValue("QueryMediaCensorJobList.NonExistIds["+ i +"]"));
			}
			queryMediaCensorJobListResponse.NonExistIds = queryMediaCensorJobListResponse_nonExistIds;

			List<QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob> queryMediaCensorJobListResponse_mediaCensorJobList = new List<QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob>();
			for (int i = 0; i < context.Length("QueryMediaCensorJobList.MediaCensorJobList.Length"); i++) {
				QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob mediaCensorJob = new QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob();
				mediaCensorJob.JobId = context.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].JobId");
				mediaCensorJob.UserData = context.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].UserData");
				mediaCensorJob.PipelineId = context.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].PipelineId");
				mediaCensorJob.State = context.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].State");
				mediaCensorJob.Code = context.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].Code");
				mediaCensorJob.Suggestion = context.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].Suggestion");
				mediaCensorJob.Message = context.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].Message");
				mediaCensorJob.CreationTime = context.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].CreationTime");
				mediaCensorJob.FinishTime = context.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].FinishTime");

				QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob.QueryMediaCensorJobList_TitleCensorResult titleCensorResult = new QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob.QueryMediaCensorJobList_TitleCensorResult();
				titleCensorResult.Rate = context.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].TitleCensorResult.Rate");
				titleCensorResult.Scene = context.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].TitleCensorResult.Scene");
				titleCensorResult.Label = context.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].TitleCensorResult.Label");
				titleCensorResult.Suggestion = context.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].TitleCensorResult.Suggestion");
				mediaCensorJob.TitleCensorResult = titleCensorResult;

				QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob.QueryMediaCensorJobList_DescCensorResult descCensorResult = new QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob.QueryMediaCensorJobList_DescCensorResult();
				descCensorResult.Rate = context.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].DescCensorResult.Rate");
				descCensorResult.Scene = context.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].DescCensorResult.Scene");
				descCensorResult.Label = context.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].DescCensorResult.Label");
				descCensorResult.Suggestion = context.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].DescCensorResult.Suggestion");
				mediaCensorJob.DescCensorResult = descCensorResult;

				QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob.QueryMediaCensorJobList_BarrageCensorResult barrageCensorResult = new QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob.QueryMediaCensorJobList_BarrageCensorResult();
				barrageCensorResult.Rate = context.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].BarrageCensorResult.Rate");
				barrageCensorResult.Scene = context.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].BarrageCensorResult.Scene");
				barrageCensorResult.Label = context.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].BarrageCensorResult.Label");
				barrageCensorResult.Suggestion = context.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].BarrageCensorResult.Suggestion");
				mediaCensorJob.BarrageCensorResult = barrageCensorResult;

				QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob.QueryMediaCensorJobList_Input input = new QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob.QueryMediaCensorJobList_Input();
				input.Bucket = context.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].Input.Bucket");
				input.Location = context.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].Input.Location");
				input._Object = context.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].Input.Object");
				mediaCensorJob.Input = input;

				QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob.QueryMediaCensorJobList_VideoCensorConfig videoCensorConfig = new QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob.QueryMediaCensorJobList_VideoCensorConfig();
				videoCensorConfig.BizType = context.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].VideoCensorConfig.BizType");
				videoCensorConfig.VideoCensor = context.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].VideoCensorConfig.VideoCensor");

				QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob.QueryMediaCensorJobList_VideoCensorConfig.QueryMediaCensorJobList_OutputFile outputFile = new QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob.QueryMediaCensorJobList_VideoCensorConfig.QueryMediaCensorJobList_OutputFile();
				outputFile.Bucket = context.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].VideoCensorConfig.OutputFile.Bucket");
				outputFile.Location = context.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].VideoCensorConfig.OutputFile.Location");
				outputFile._Object = context.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].VideoCensorConfig.OutputFile.Object");
				videoCensorConfig.OutputFile = outputFile;
				mediaCensorJob.VideoCensorConfig = videoCensorConfig;

				QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob.QueryMediaCensorJobList_VensorCensorResult vensorCensorResult = new QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob.QueryMediaCensorJobList_VensorCensorResult();
				vensorCensorResult.NextPageToken = context.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].VensorCensorResult.NextPageToken");

				List<QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob.QueryMediaCensorJobList_VensorCensorResult.QueryMediaCensorJobList_CensorResult> vensorCensorResult_censorResults = new List<QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob.QueryMediaCensorJobList_VensorCensorResult.QueryMediaCensorJobList_CensorResult>();
				for (int j = 0; j < context.Length("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].VensorCensorResult.CensorResults.Length"); j++) {
					QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob.QueryMediaCensorJobList_VensorCensorResult.QueryMediaCensorJobList_CensorResult censorResult = new QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob.QueryMediaCensorJobList_VensorCensorResult.QueryMediaCensorJobList_CensorResult();
					censorResult.Rate = context.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].VensorCensorResult.CensorResults["+ j +"].Rate");
					censorResult.Scene = context.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].VensorCensorResult.CensorResults["+ j +"].Scene");
					censorResult.Label = context.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].VensorCensorResult.CensorResults["+ j +"].Label");
					censorResult.Suggestion = context.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].VensorCensorResult.CensorResults["+ j +"].Suggestion");

					vensorCensorResult_censorResults.Add(censorResult);
				}
				vensorCensorResult.CensorResults = vensorCensorResult_censorResults;

				List<QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob.QueryMediaCensorJobList_VensorCensorResult.QueryMediaCensorJobList_VideoTimeline> vensorCensorResult_videoTimelines = new List<QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob.QueryMediaCensorJobList_VensorCensorResult.QueryMediaCensorJobList_VideoTimeline>();
				for (int j = 0; j < context.Length("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].VensorCensorResult.VideoTimelines.Length"); j++) {
					QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob.QueryMediaCensorJobList_VensorCensorResult.QueryMediaCensorJobList_VideoTimeline videoTimeline = new QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob.QueryMediaCensorJobList_VensorCensorResult.QueryMediaCensorJobList_VideoTimeline();
					videoTimeline._Object = context.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].VensorCensorResult.VideoTimelines["+ j +"].Object");
					videoTimeline.Timestamp = context.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].VensorCensorResult.VideoTimelines["+ j +"].Timestamp");

					List<QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob.QueryMediaCensorJobList_VensorCensorResult.QueryMediaCensorJobList_VideoTimeline.QueryMediaCensorJobList_CensorResult2> videoTimeline_censorResults1 = new List<QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob.QueryMediaCensorJobList_VensorCensorResult.QueryMediaCensorJobList_VideoTimeline.QueryMediaCensorJobList_CensorResult2>();
					for (int k = 0; k < context.Length("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].VensorCensorResult.VideoTimelines["+ j +"].CensorResults.Length"); k++) {
						QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob.QueryMediaCensorJobList_VensorCensorResult.QueryMediaCensorJobList_VideoTimeline.QueryMediaCensorJobList_CensorResult2 censorResult2 = new QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob.QueryMediaCensorJobList_VensorCensorResult.QueryMediaCensorJobList_VideoTimeline.QueryMediaCensorJobList_CensorResult2();
						censorResult2.Rate = context.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].VensorCensorResult.VideoTimelines["+ j +"].CensorResults["+ k +"].Rate");
						censorResult2.Scene = context.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].VensorCensorResult.VideoTimelines["+ j +"].CensorResults["+ k +"].Scene");
						censorResult2.Label = context.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].VensorCensorResult.VideoTimelines["+ j +"].CensorResults["+ k +"].Label");
						censorResult2.Suggestion = context.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].VensorCensorResult.VideoTimelines["+ j +"].CensorResults["+ k +"].Suggestion");

						videoTimeline_censorResults1.Add(censorResult2);
					}
					videoTimeline.CensorResults1 = videoTimeline_censorResults1;

					vensorCensorResult_videoTimelines.Add(videoTimeline);
				}
				vensorCensorResult.VideoTimelines = vensorCensorResult_videoTimelines;
				mediaCensorJob.VensorCensorResult = vensorCensorResult;

				List<QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob.QueryMediaCensorJobList_CoverImageCensorResult> mediaCensorJob_coverImageCensorResults = new List<QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob.QueryMediaCensorJobList_CoverImageCensorResult>();
				for (int j = 0; j < context.Length("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].CoverImageCensorResults.Length"); j++) {
					QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob.QueryMediaCensorJobList_CoverImageCensorResult coverImageCensorResult = new QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob.QueryMediaCensorJobList_CoverImageCensorResult();
					coverImageCensorResult.Location = context.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].CoverImageCensorResults["+ j +"].Location");
					coverImageCensorResult.Bucket = context.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].CoverImageCensorResults["+ j +"].Bucket");
					coverImageCensorResult._Object = context.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].CoverImageCensorResults["+ j +"].Object");

					List<QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob.QueryMediaCensorJobList_CoverImageCensorResult.QueryMediaCensorJobList_Result> coverImageCensorResult_results = new List<QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob.QueryMediaCensorJobList_CoverImageCensorResult.QueryMediaCensorJobList_Result>();
					for (int k = 0; k < context.Length("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].CoverImageCensorResults["+ j +"].Results.Length"); k++) {
						QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob.QueryMediaCensorJobList_CoverImageCensorResult.QueryMediaCensorJobList_Result result = new QueryMediaCensorJobListResponse.QueryMediaCensorJobList_MediaCensorJob.QueryMediaCensorJobList_CoverImageCensorResult.QueryMediaCensorJobList_Result();
						result.Rate = context.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].CoverImageCensorResults["+ j +"].Results["+ k +"].Rate");
						result.Scene = context.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].CoverImageCensorResults["+ j +"].Results["+ k +"].Scene");
						result.Label = context.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].CoverImageCensorResults["+ j +"].Results["+ k +"].Label");
						result.Suggestion = context.StringValue("QueryMediaCensorJobList.MediaCensorJobList["+ i +"].CoverImageCensorResults["+ j +"].Results["+ k +"].Suggestion");

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
