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
    public class QueryMediaCensorJobDetailResponseUnmarshaller
    {
        public static QueryMediaCensorJobDetailResponse Unmarshall(UnmarshallerContext context)
        {
			QueryMediaCensorJobDetailResponse queryMediaCensorJobDetailResponse = new QueryMediaCensorJobDetailResponse();

			queryMediaCensorJobDetailResponse.HttpResponse = context.HttpResponse;
			queryMediaCensorJobDetailResponse.RequestId = context.StringValue("QueryMediaCensorJobDetail.RequestId");

			QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail mediaCensorJobDetail = new QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail();
			mediaCensorJobDetail.Id = context.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.Id");
			mediaCensorJobDetail.UserData = context.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.UserData");
			mediaCensorJobDetail.PipelineId = context.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.PipelineId");
			mediaCensorJobDetail.State = context.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.State");
			mediaCensorJobDetail.Code = context.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.Code");
			mediaCensorJobDetail.Suggestion = context.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.Suggestion");
			mediaCensorJobDetail.Message = context.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.Message");
			mediaCensorJobDetail.CreationTime = context.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.CreationTime");

			QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail.QueryMediaCensorJobDetail_TitleCensorResult titleCensorResult = new QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail.QueryMediaCensorJobDetail_TitleCensorResult();
			titleCensorResult.Rate = context.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.TitleCensorResult.Rate");
			titleCensorResult.Scene = context.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.TitleCensorResult.Scene");
			titleCensorResult.Label = context.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.TitleCensorResult.Label");
			titleCensorResult.Suggestion = context.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.TitleCensorResult.Suggestion");
			mediaCensorJobDetail.TitleCensorResult = titleCensorResult;

			QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail.QueryMediaCensorJobDetail_DescCensorResult descCensorResult = new QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail.QueryMediaCensorJobDetail_DescCensorResult();
			descCensorResult.Rate = context.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.DescCensorResult.Rate");
			descCensorResult.Scene = context.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.DescCensorResult.Scene");
			descCensorResult.Label = context.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.DescCensorResult.Label");
			descCensorResult.Suggestion = context.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.DescCensorResult.Suggestion");
			mediaCensorJobDetail.DescCensorResult = descCensorResult;

			QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail.QueryMediaCensorJobDetail_BarrageCensorResult barrageCensorResult = new QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail.QueryMediaCensorJobDetail_BarrageCensorResult();
			barrageCensorResult.Rate = context.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.BarrageCensorResult.Rate");
			barrageCensorResult.Scene = context.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.BarrageCensorResult.Scene");
			barrageCensorResult.Label = context.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.BarrageCensorResult.Label");
			barrageCensorResult.Suggestion = context.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.BarrageCensorResult.Suggestion");
			mediaCensorJobDetail.BarrageCensorResult = barrageCensorResult;

			QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail.QueryMediaCensorJobDetail_Input input = new QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail.QueryMediaCensorJobDetail_Input();
			input.Bucket = context.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.Input.Bucket");
			input.Location = context.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.Input.Location");
			input._Object = context.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.Input.Object");
			mediaCensorJobDetail.Input = input;

			QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail.QueryMediaCensorJobDetail_VideoCensorConfig videoCensorConfig = new QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail.QueryMediaCensorJobDetail_VideoCensorConfig();
			videoCensorConfig.BizType = context.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.VideoCensorConfig.BizType");
			videoCensorConfig.VideoCensor = context.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.VideoCensorConfig.VideoCensor");

			QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail.QueryMediaCensorJobDetail_VideoCensorConfig.QueryMediaCensorJobDetail_OutputFile outputFile = new QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail.QueryMediaCensorJobDetail_VideoCensorConfig.QueryMediaCensorJobDetail_OutputFile();
			outputFile.Bucket = context.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.VideoCensorConfig.OutputFile.Bucket");
			outputFile.Location = context.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.VideoCensorConfig.OutputFile.Location");
			outputFile._Object = context.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.VideoCensorConfig.OutputFile.Object");
			videoCensorConfig.OutputFile = outputFile;
			mediaCensorJobDetail.VideoCensorConfig = videoCensorConfig;

			QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail.QueryMediaCensorJobDetail_VensorCensorResult vensorCensorResult = new QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail.QueryMediaCensorJobDetail_VensorCensorResult();
			vensorCensorResult.NextPageToken = context.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.VensorCensorResult.NextPageToken");

			List<QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail.QueryMediaCensorJobDetail_VensorCensorResult.QueryMediaCensorJobDetail_CensorResult> vensorCensorResult_censorResults = new List<QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail.QueryMediaCensorJobDetail_VensorCensorResult.QueryMediaCensorJobDetail_CensorResult>();
			for (int i = 0; i < context.Length("QueryMediaCensorJobDetail.MediaCensorJobDetail.VensorCensorResult.CensorResults.Length"); i++) {
				QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail.QueryMediaCensorJobDetail_VensorCensorResult.QueryMediaCensorJobDetail_CensorResult censorResult = new QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail.QueryMediaCensorJobDetail_VensorCensorResult.QueryMediaCensorJobDetail_CensorResult();
				censorResult.Rate = context.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.VensorCensorResult.CensorResults["+ i +"].Rate");
				censorResult.Scene = context.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.VensorCensorResult.CensorResults["+ i +"].Scene");
				censorResult.Label = context.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.VensorCensorResult.CensorResults["+ i +"].Label");
				censorResult.Suggestion = context.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.VensorCensorResult.CensorResults["+ i +"].Suggestion");

				vensorCensorResult_censorResults.Add(censorResult);
			}
			vensorCensorResult.CensorResults = vensorCensorResult_censorResults;

			List<QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail.QueryMediaCensorJobDetail_VensorCensorResult.QueryMediaCensorJobDetail_VideoTimeline> vensorCensorResult_videoTimelines = new List<QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail.QueryMediaCensorJobDetail_VensorCensorResult.QueryMediaCensorJobDetail_VideoTimeline>();
			for (int i = 0; i < context.Length("QueryMediaCensorJobDetail.MediaCensorJobDetail.VensorCensorResult.VideoTimelines.Length"); i++) {
				QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail.QueryMediaCensorJobDetail_VensorCensorResult.QueryMediaCensorJobDetail_VideoTimeline videoTimeline = new QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail.QueryMediaCensorJobDetail_VensorCensorResult.QueryMediaCensorJobDetail_VideoTimeline();
				videoTimeline._Object = context.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.VensorCensorResult.VideoTimelines["+ i +"].Object");
				videoTimeline.Timestamp = context.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.VensorCensorResult.VideoTimelines["+ i +"].Timestamp");

				List<QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail.QueryMediaCensorJobDetail_VensorCensorResult.QueryMediaCensorJobDetail_VideoTimeline.QueryMediaCensorJobDetail_CensorResult2> videoTimeline_censorResults1 = new List<QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail.QueryMediaCensorJobDetail_VensorCensorResult.QueryMediaCensorJobDetail_VideoTimeline.QueryMediaCensorJobDetail_CensorResult2>();
				for (int j = 0; j < context.Length("QueryMediaCensorJobDetail.MediaCensorJobDetail.VensorCensorResult.VideoTimelines["+ i +"].CensorResults.Length"); j++) {
					QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail.QueryMediaCensorJobDetail_VensorCensorResult.QueryMediaCensorJobDetail_VideoTimeline.QueryMediaCensorJobDetail_CensorResult2 censorResult2 = new QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail.QueryMediaCensorJobDetail_VensorCensorResult.QueryMediaCensorJobDetail_VideoTimeline.QueryMediaCensorJobDetail_CensorResult2();
					censorResult2.Rate = context.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.VensorCensorResult.VideoTimelines["+ i +"].CensorResults["+ j +"].Rate");
					censorResult2.Scene = context.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.VensorCensorResult.VideoTimelines["+ i +"].CensorResults["+ j +"].Scene");
					censorResult2.Label = context.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.VensorCensorResult.VideoTimelines["+ i +"].CensorResults["+ j +"].Label");
					censorResult2.Suggestion = context.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.VensorCensorResult.VideoTimelines["+ i +"].CensorResults["+ j +"].Suggestion");

					videoTimeline_censorResults1.Add(censorResult2);
				}
				videoTimeline.CensorResults1 = videoTimeline_censorResults1;

				vensorCensorResult_videoTimelines.Add(videoTimeline);
			}
			vensorCensorResult.VideoTimelines = vensorCensorResult_videoTimelines;
			mediaCensorJobDetail.VensorCensorResult = vensorCensorResult;

			List<QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail.QueryMediaCensorJobDetail_CoverImageCensorResult> mediaCensorJobDetail_coverImageCensorResults = new List<QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail.QueryMediaCensorJobDetail_CoverImageCensorResult>();
			for (int i = 0; i < context.Length("QueryMediaCensorJobDetail.MediaCensorJobDetail.CoverImageCensorResults.Length"); i++) {
				QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail.QueryMediaCensorJobDetail_CoverImageCensorResult coverImageCensorResult = new QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail.QueryMediaCensorJobDetail_CoverImageCensorResult();
				coverImageCensorResult.Location = context.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.CoverImageCensorResults["+ i +"].Location");
				coverImageCensorResult.Bucket = context.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.CoverImageCensorResults["+ i +"].Bucket");
				coverImageCensorResult._Object = context.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.CoverImageCensorResults["+ i +"].Object");

				List<QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail.QueryMediaCensorJobDetail_CoverImageCensorResult.QueryMediaCensorJobDetail_Result> coverImageCensorResult_results = new List<QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail.QueryMediaCensorJobDetail_CoverImageCensorResult.QueryMediaCensorJobDetail_Result>();
				for (int j = 0; j < context.Length("QueryMediaCensorJobDetail.MediaCensorJobDetail.CoverImageCensorResults["+ i +"].Results.Length"); j++) {
					QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail.QueryMediaCensorJobDetail_CoverImageCensorResult.QueryMediaCensorJobDetail_Result result = new QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail.QueryMediaCensorJobDetail_CoverImageCensorResult.QueryMediaCensorJobDetail_Result();
					result.Rate = context.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.CoverImageCensorResults["+ i +"].Results["+ j +"].Rate");
					result.Scene = context.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.CoverImageCensorResults["+ i +"].Results["+ j +"].Scene");
					result.Label = context.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.CoverImageCensorResults["+ i +"].Results["+ j +"].Label");
					result.Suggestion = context.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.CoverImageCensorResults["+ i +"].Results["+ j +"].Suggestion");

					coverImageCensorResult_results.Add(result);
				}
				coverImageCensorResult.Results = coverImageCensorResult_results;

				mediaCensorJobDetail_coverImageCensorResults.Add(coverImageCensorResult);
			}
			mediaCensorJobDetail.CoverImageCensorResults = mediaCensorJobDetail_coverImageCensorResults;
			queryMediaCensorJobDetailResponse.MediaCensorJobDetail = mediaCensorJobDetail;
        
			return queryMediaCensorJobDetailResponse;
        }
    }
}
