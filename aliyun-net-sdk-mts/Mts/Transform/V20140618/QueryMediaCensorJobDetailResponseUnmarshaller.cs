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
        public static QueryMediaCensorJobDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryMediaCensorJobDetailResponse queryMediaCensorJobDetailResponse = new QueryMediaCensorJobDetailResponse();

			queryMediaCensorJobDetailResponse.HttpResponse = _ctx.HttpResponse;
			queryMediaCensorJobDetailResponse.RequestId = _ctx.StringValue("QueryMediaCensorJobDetail.RequestId");

			QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail mediaCensorJobDetail = new QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail();
			mediaCensorJobDetail.CreationTime = _ctx.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.CreationTime");
			mediaCensorJobDetail.FinishTime = _ctx.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.FinishTime");
			mediaCensorJobDetail.Suggestion = _ctx.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.Suggestion");
			mediaCensorJobDetail.State = _ctx.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.State");
			mediaCensorJobDetail.Message = _ctx.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.Message");
			mediaCensorJobDetail.JobId = _ctx.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.JobId");
			mediaCensorJobDetail.UserData = _ctx.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.UserData");
			mediaCensorJobDetail.Code = _ctx.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.Code");
			mediaCensorJobDetail.PipelineId = _ctx.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.PipelineId");

			QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail.QueryMediaCensorJobDetail_TitleCensorResult titleCensorResult = new QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail.QueryMediaCensorJobDetail_TitleCensorResult();
			titleCensorResult.Suggestion = _ctx.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.TitleCensorResult.Suggestion");
			titleCensorResult.Label = _ctx.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.TitleCensorResult.Label");
			titleCensorResult.Scene = _ctx.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.TitleCensorResult.Scene");
			titleCensorResult.Rate = _ctx.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.TitleCensorResult.Rate");
			mediaCensorJobDetail.TitleCensorResult = titleCensorResult;

			QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail.QueryMediaCensorJobDetail_Input input = new QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail.QueryMediaCensorJobDetail_Input();
			input._Object = _ctx.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.Input.Object");
			input.Location = _ctx.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.Input.Location");
			input.Bucket = _ctx.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.Input.Bucket");
			mediaCensorJobDetail.Input = input;

			QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail.QueryMediaCensorJobDetail_BarrageCensorResult barrageCensorResult = new QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail.QueryMediaCensorJobDetail_BarrageCensorResult();
			barrageCensorResult.Suggestion = _ctx.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.BarrageCensorResult.Suggestion");
			barrageCensorResult.Label = _ctx.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.BarrageCensorResult.Label");
			barrageCensorResult.Scene = _ctx.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.BarrageCensorResult.Scene");
			barrageCensorResult.Rate = _ctx.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.BarrageCensorResult.Rate");
			mediaCensorJobDetail.BarrageCensorResult = barrageCensorResult;

			QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail.QueryMediaCensorJobDetail_DescCensorResult descCensorResult = new QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail.QueryMediaCensorJobDetail_DescCensorResult();
			descCensorResult.Suggestion = _ctx.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.DescCensorResult.Suggestion");
			descCensorResult.Label = _ctx.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.DescCensorResult.Label");
			descCensorResult.Scene = _ctx.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.DescCensorResult.Scene");
			descCensorResult.Rate = _ctx.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.DescCensorResult.Rate");
			mediaCensorJobDetail.DescCensorResult = descCensorResult;

			QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail.QueryMediaCensorJobDetail_VideoCensorConfig videoCensorConfig = new QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail.QueryMediaCensorJobDetail_VideoCensorConfig();
			videoCensorConfig.VideoCensor = _ctx.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.VideoCensorConfig.VideoCensor");
			videoCensorConfig.BizType = _ctx.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.VideoCensorConfig.BizType");

			QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail.QueryMediaCensorJobDetail_VideoCensorConfig.QueryMediaCensorJobDetail_OutputFile outputFile = new QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail.QueryMediaCensorJobDetail_VideoCensorConfig.QueryMediaCensorJobDetail_OutputFile();
			outputFile._Object = _ctx.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.VideoCensorConfig.OutputFile.Object");
			outputFile.Location = _ctx.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.VideoCensorConfig.OutputFile.Location");
			outputFile.Bucket = _ctx.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.VideoCensorConfig.OutputFile.Bucket");
			videoCensorConfig.OutputFile = outputFile;
			mediaCensorJobDetail.VideoCensorConfig = videoCensorConfig;

			QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail.QueryMediaCensorJobDetail_VensorCensorResult vensorCensorResult = new QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail.QueryMediaCensorJobDetail_VensorCensorResult();
			vensorCensorResult.NextPageToken = _ctx.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.VensorCensorResult.NextPageToken");

			List<QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail.QueryMediaCensorJobDetail_VensorCensorResult.QueryMediaCensorJobDetail_VideoTimeline> vensorCensorResult_videoTimelines = new List<QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail.QueryMediaCensorJobDetail_VensorCensorResult.QueryMediaCensorJobDetail_VideoTimeline>();
			for (int i = 0; i < _ctx.Length("QueryMediaCensorJobDetail.MediaCensorJobDetail.VensorCensorResult.VideoTimelines.Length"); i++) {
				QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail.QueryMediaCensorJobDetail_VensorCensorResult.QueryMediaCensorJobDetail_VideoTimeline videoTimeline = new QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail.QueryMediaCensorJobDetail_VensorCensorResult.QueryMediaCensorJobDetail_VideoTimeline();
				videoTimeline.Timestamp = _ctx.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.VensorCensorResult.VideoTimelines["+ i +"].Timestamp");
				videoTimeline._Object = _ctx.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.VensorCensorResult.VideoTimelines["+ i +"].Object");

				List<QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail.QueryMediaCensorJobDetail_VensorCensorResult.QueryMediaCensorJobDetail_VideoTimeline.QueryMediaCensorJobDetail_CensorResult> videoTimeline_censorResults1 = new List<QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail.QueryMediaCensorJobDetail_VensorCensorResult.QueryMediaCensorJobDetail_VideoTimeline.QueryMediaCensorJobDetail_CensorResult>();
				for (int j = 0; j < _ctx.Length("QueryMediaCensorJobDetail.MediaCensorJobDetail.VensorCensorResult.VideoTimelines["+ i +"].CensorResults.Length"); j++) {
					QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail.QueryMediaCensorJobDetail_VensorCensorResult.QueryMediaCensorJobDetail_VideoTimeline.QueryMediaCensorJobDetail_CensorResult censorResult = new QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail.QueryMediaCensorJobDetail_VensorCensorResult.QueryMediaCensorJobDetail_VideoTimeline.QueryMediaCensorJobDetail_CensorResult();
					censorResult.Suggestion = _ctx.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.VensorCensorResult.VideoTimelines["+ i +"].CensorResults["+ j +"].Suggestion");
					censorResult.Label = _ctx.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.VensorCensorResult.VideoTimelines["+ i +"].CensorResults["+ j +"].Label");
					censorResult.Scene = _ctx.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.VensorCensorResult.VideoTimelines["+ i +"].CensorResults["+ j +"].Scene");
					censorResult.Rate = _ctx.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.VensorCensorResult.VideoTimelines["+ i +"].CensorResults["+ j +"].Rate");

					videoTimeline_censorResults1.Add(censorResult);
				}
				videoTimeline.CensorResults1 = videoTimeline_censorResults1;

				vensorCensorResult_videoTimelines.Add(videoTimeline);
			}
			vensorCensorResult.VideoTimelines = vensorCensorResult_videoTimelines;

			List<QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail.QueryMediaCensorJobDetail_VensorCensorResult.QueryMediaCensorJobDetail_CensorResult2> vensorCensorResult_censorResults = new List<QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail.QueryMediaCensorJobDetail_VensorCensorResult.QueryMediaCensorJobDetail_CensorResult2>();
			for (int i = 0; i < _ctx.Length("QueryMediaCensorJobDetail.MediaCensorJobDetail.VensorCensorResult.CensorResults.Length"); i++) {
				QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail.QueryMediaCensorJobDetail_VensorCensorResult.QueryMediaCensorJobDetail_CensorResult2 censorResult2 = new QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail.QueryMediaCensorJobDetail_VensorCensorResult.QueryMediaCensorJobDetail_CensorResult2();
				censorResult2.Suggestion = _ctx.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.VensorCensorResult.CensorResults["+ i +"].Suggestion");
				censorResult2.Label = _ctx.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.VensorCensorResult.CensorResults["+ i +"].Label");
				censorResult2.Scene = _ctx.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.VensorCensorResult.CensorResults["+ i +"].Scene");
				censorResult2.Rate = _ctx.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.VensorCensorResult.CensorResults["+ i +"].Rate");

				vensorCensorResult_censorResults.Add(censorResult2);
			}
			vensorCensorResult.CensorResults = vensorCensorResult_censorResults;
			mediaCensorJobDetail.VensorCensorResult = vensorCensorResult;

			QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail.QueryMediaCensorJobDetail_AudioCensorResult audioCensorResult = new QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail.QueryMediaCensorJobDetail_AudioCensorResult();
			audioCensorResult.Suggestion = _ctx.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.AudioCensorResult.Suggestion");
			audioCensorResult.Label = _ctx.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.AudioCensorResult.Label");

			List<QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail.QueryMediaCensorJobDetail_AudioCensorResult.QueryMediaCensorJobDetail_AudioDetailResult> audioCensorResult_audioDetailResultList = new List<QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail.QueryMediaCensorJobDetail_AudioCensorResult.QueryMediaCensorJobDetail_AudioDetailResult>();
			for (int i = 0; i < _ctx.Length("QueryMediaCensorJobDetail.MediaCensorJobDetail.AudioCensorResult.AudioDetailResultList.Length"); i++) {
				QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail.QueryMediaCensorJobDetail_AudioCensorResult.QueryMediaCensorJobDetail_AudioDetailResult audioDetailResult = new QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail.QueryMediaCensorJobDetail_AudioCensorResult.QueryMediaCensorJobDetail_AudioDetailResult();
				audioDetailResult.StartTime = _ctx.IntegerValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.AudioCensorResult.AudioDetailResultList["+ i +"].StartTime");
				audioDetailResult.EndTime = _ctx.IntegerValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.AudioCensorResult.AudioDetailResultList["+ i +"].EndTime");
				audioDetailResult.Text = _ctx.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.AudioCensorResult.AudioDetailResultList["+ i +"].Text");
				audioDetailResult.Label = _ctx.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.AudioCensorResult.AudioDetailResultList["+ i +"].Label");

				audioCensorResult_audioDetailResultList.Add(audioDetailResult);
			}
			audioCensorResult.AudioDetailResultList = audioCensorResult_audioDetailResultList;
			mediaCensorJobDetail.AudioCensorResult = audioCensorResult;

			List<QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail.QueryMediaCensorJobDetail_CoverImageCensorResult> mediaCensorJobDetail_coverImageCensorResults = new List<QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail.QueryMediaCensorJobDetail_CoverImageCensorResult>();
			for (int i = 0; i < _ctx.Length("QueryMediaCensorJobDetail.MediaCensorJobDetail.CoverImageCensorResults.Length"); i++) {
				QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail.QueryMediaCensorJobDetail_CoverImageCensorResult coverImageCensorResult = new QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail.QueryMediaCensorJobDetail_CoverImageCensorResult();
				coverImageCensorResult._Object = _ctx.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.CoverImageCensorResults["+ i +"].Object");
				coverImageCensorResult.Location = _ctx.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.CoverImageCensorResults["+ i +"].Location");
				coverImageCensorResult.Bucket = _ctx.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.CoverImageCensorResults["+ i +"].Bucket");

				List<QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail.QueryMediaCensorJobDetail_CoverImageCensorResult.QueryMediaCensorJobDetail_Result> coverImageCensorResult_results = new List<QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail.QueryMediaCensorJobDetail_CoverImageCensorResult.QueryMediaCensorJobDetail_Result>();
				for (int j = 0; j < _ctx.Length("QueryMediaCensorJobDetail.MediaCensorJobDetail.CoverImageCensorResults["+ i +"].Results.Length"); j++) {
					QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail.QueryMediaCensorJobDetail_CoverImageCensorResult.QueryMediaCensorJobDetail_Result result = new QueryMediaCensorJobDetailResponse.QueryMediaCensorJobDetail_MediaCensorJobDetail.QueryMediaCensorJobDetail_CoverImageCensorResult.QueryMediaCensorJobDetail_Result();
					result.Suggestion = _ctx.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.CoverImageCensorResults["+ i +"].Results["+ j +"].Suggestion");
					result.Label = _ctx.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.CoverImageCensorResults["+ i +"].Results["+ j +"].Label");
					result.Scene = _ctx.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.CoverImageCensorResults["+ i +"].Results["+ j +"].Scene");
					result.Rate = _ctx.StringValue("QueryMediaCensorJobDetail.MediaCensorJobDetail.CoverImageCensorResults["+ i +"].Results["+ j +"].Rate");

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
