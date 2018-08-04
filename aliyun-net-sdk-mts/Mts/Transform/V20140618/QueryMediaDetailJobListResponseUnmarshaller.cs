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
using Aliyun.Acs.Mts.Model.V20140618;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Mts.Transform.V20140618
{
    public class QueryMediaDetailJobListResponseUnmarshaller
    {
        public static QueryMediaDetailJobListResponse Unmarshall(UnmarshallerContext context)
        {
			QueryMediaDetailJobListResponse queryMediaDetailJobListResponse = new QueryMediaDetailJobListResponse();

			queryMediaDetailJobListResponse.HttpResponse = context.HttpResponse;
			queryMediaDetailJobListResponse.RequestId = context.StringValue("QueryMediaDetailJobList.RequestId");

			List<string> queryMediaDetailJobListResponse_nonExistIds = new List<string>();
			for (int i = 0; i < context.Length("QueryMediaDetailJobList.NonExistIds.Length"); i++) {
				queryMediaDetailJobListResponse_nonExistIds.Add(context.StringValue("QueryMediaDetailJobList.NonExistIds["+ i +"]"));
			}
			queryMediaDetailJobListResponse.NonExistIds = queryMediaDetailJobListResponse_nonExistIds;

			List<QueryMediaDetailJobListResponse.QueryMediaDetailJobList_Job> queryMediaDetailJobListResponse_jobList = new List<QueryMediaDetailJobListResponse.QueryMediaDetailJobList_Job>();
			for (int i = 0; i < context.Length("QueryMediaDetailJobList.JobList.Length"); i++) {
				QueryMediaDetailJobListResponse.QueryMediaDetailJobList_Job job = new QueryMediaDetailJobListResponse.QueryMediaDetailJobList_Job();
				job.Id = context.StringValue("QueryMediaDetailJobList.JobList["+ i +"].Id");
				job.UserData = context.StringValue("QueryMediaDetailJobList.JobList["+ i +"].UserData");
				job.PipelineId = context.StringValue("QueryMediaDetailJobList.JobList["+ i +"].PipelineId");
				job.State = context.StringValue("QueryMediaDetailJobList.JobList["+ i +"].State");
				job.Code = context.StringValue("QueryMediaDetailJobList.JobList["+ i +"].Code");
				job.Message = context.StringValue("QueryMediaDetailJobList.JobList["+ i +"].Message");
				job.CreationTime = context.StringValue("QueryMediaDetailJobList.JobList["+ i +"].CreationTime");

				QueryMediaDetailJobListResponse.QueryMediaDetailJobList_Job.QueryMediaDetailJobList_Input input = new QueryMediaDetailJobListResponse.QueryMediaDetailJobList_Job.QueryMediaDetailJobList_Input();
				input.Bucket = context.StringValue("QueryMediaDetailJobList.JobList["+ i +"].Input.Bucket");
				input.Location = context.StringValue("QueryMediaDetailJobList.JobList["+ i +"].Input.Location");
				input._Object = context.StringValue("QueryMediaDetailJobList.JobList["+ i +"].Input.Object");
				job.Input = input;

				QueryMediaDetailJobListResponse.QueryMediaDetailJobList_Job.QueryMediaDetailJobList_MediaDetailConfig mediaDetailConfig = new QueryMediaDetailJobListResponse.QueryMediaDetailJobList_Job.QueryMediaDetailJobList_MediaDetailConfig();
				mediaDetailConfig.Scenario = context.StringValue("QueryMediaDetailJobList.JobList["+ i +"].MediaDetailConfig.Scenario");
				mediaDetailConfig.DetailType = context.StringValue("QueryMediaDetailJobList.JobList["+ i +"].MediaDetailConfig.DetailType");

				QueryMediaDetailJobListResponse.QueryMediaDetailJobList_Job.QueryMediaDetailJobList_MediaDetailConfig.QueryMediaDetailJobList_OutputFile outputFile = new QueryMediaDetailJobListResponse.QueryMediaDetailJobList_Job.QueryMediaDetailJobList_MediaDetailConfig.QueryMediaDetailJobList_OutputFile();
				outputFile.Bucket = context.StringValue("QueryMediaDetailJobList.JobList["+ i +"].MediaDetailConfig.OutputFile.Bucket");
				outputFile.Location = context.StringValue("QueryMediaDetailJobList.JobList["+ i +"].MediaDetailConfig.OutputFile.Location");
				outputFile._Object = context.StringValue("QueryMediaDetailJobList.JobList["+ i +"].MediaDetailConfig.OutputFile.Object");
				mediaDetailConfig.OutputFile = outputFile;
				job.MediaDetailConfig = mediaDetailConfig;

				QueryMediaDetailJobListResponse.QueryMediaDetailJobList_Job.QueryMediaDetailJobList_MediaDetailResult mediaDetailResult = new QueryMediaDetailJobListResponse.QueryMediaDetailJobList_Job.QueryMediaDetailJobList_MediaDetailResult();
				mediaDetailResult.Status = context.StringValue("QueryMediaDetailJobList.JobList["+ i +"].MediaDetailResult.Status");

				List<string> mediaDetailResult_tags = new List<string>();
				for (int j = 0; j < context.Length("QueryMediaDetailJobList.JobList["+ i +"].MediaDetailResult.Tags.Length"); j++) {
					mediaDetailResult_tags.Add(context.StringValue("QueryMediaDetailJobList.JobList["+ i +"].MediaDetailResult.Tags["+ j +"]"));
				}
				mediaDetailResult.Tags = mediaDetailResult_tags;

				List<QueryMediaDetailJobListResponse.QueryMediaDetailJobList_Job.QueryMediaDetailJobList_MediaDetailResult.QueryMediaDetailJobList_MediaDetailRecgResult> mediaDetailResult_mediaDetailRecgResults = new List<QueryMediaDetailJobListResponse.QueryMediaDetailJobList_Job.QueryMediaDetailJobList_MediaDetailResult.QueryMediaDetailJobList_MediaDetailRecgResult>();
				for (int j = 0; j < context.Length("QueryMediaDetailJobList.JobList["+ i +"].MediaDetailResult.MediaDetailRecgResults.Length"); j++) {
					QueryMediaDetailJobListResponse.QueryMediaDetailJobList_Job.QueryMediaDetailJobList_MediaDetailResult.QueryMediaDetailJobList_MediaDetailRecgResult mediaDetailRecgResult = new QueryMediaDetailJobListResponse.QueryMediaDetailJobList_Job.QueryMediaDetailJobList_MediaDetailResult.QueryMediaDetailJobList_MediaDetailRecgResult();
					mediaDetailRecgResult.ImageUrl = context.StringValue("QueryMediaDetailJobList.JobList["+ i +"].MediaDetailResult.MediaDetailRecgResults["+ j +"].ImageUrl");
					mediaDetailRecgResult.Time = context.StringValue("QueryMediaDetailJobList.JobList["+ i +"].MediaDetailResult.MediaDetailRecgResults["+ j +"].Time");
					mediaDetailRecgResult.OcrText = context.StringValue("QueryMediaDetailJobList.JobList["+ i +"].MediaDetailResult.MediaDetailRecgResults["+ j +"].OcrText");

					List<string> mediaDetailRecgResult_frameTags = new List<string>();
					for (int k = 0; k < context.Length("QueryMediaDetailJobList.JobList["+ i +"].MediaDetailResult.MediaDetailRecgResults["+ j +"].FrameTags.Length"); k++) {
						mediaDetailRecgResult_frameTags.Add(context.StringValue("QueryMediaDetailJobList.JobList["+ i +"].MediaDetailResult.MediaDetailRecgResults["+ j +"].FrameTags["+ k +"]"));
					}
					mediaDetailRecgResult.FrameTags = mediaDetailRecgResult_frameTags;

					List<QueryMediaDetailJobListResponse.QueryMediaDetailJobList_Job.QueryMediaDetailJobList_MediaDetailResult.QueryMediaDetailJobList_MediaDetailRecgResult.QueryMediaDetailJobList_Celebrity> mediaDetailRecgResult_celebrities = new List<QueryMediaDetailJobListResponse.QueryMediaDetailJobList_Job.QueryMediaDetailJobList_MediaDetailResult.QueryMediaDetailJobList_MediaDetailRecgResult.QueryMediaDetailJobList_Celebrity>();
					for (int k = 0; k < context.Length("QueryMediaDetailJobList.JobList["+ i +"].MediaDetailResult.MediaDetailRecgResults["+ j +"].Celebrities.Length"); k++) {
						QueryMediaDetailJobListResponse.QueryMediaDetailJobList_Job.QueryMediaDetailJobList_MediaDetailResult.QueryMediaDetailJobList_MediaDetailRecgResult.QueryMediaDetailJobList_Celebrity celebrity = new QueryMediaDetailJobListResponse.QueryMediaDetailJobList_Job.QueryMediaDetailJobList_MediaDetailResult.QueryMediaDetailJobList_MediaDetailRecgResult.QueryMediaDetailJobList_Celebrity();
						celebrity.Name = context.StringValue("QueryMediaDetailJobList.JobList["+ i +"].MediaDetailResult.MediaDetailRecgResults["+ j +"].Celebrities["+ k +"].Name");
						celebrity.Score = context.StringValue("QueryMediaDetailJobList.JobList["+ i +"].MediaDetailResult.MediaDetailRecgResults["+ j +"].Celebrities["+ k +"].Score");
						celebrity.Target = context.StringValue("QueryMediaDetailJobList.JobList["+ i +"].MediaDetailResult.MediaDetailRecgResults["+ j +"].Celebrities["+ k +"].Target");

						mediaDetailRecgResult_celebrities.Add(celebrity);
					}
					mediaDetailRecgResult.Celebrities = mediaDetailRecgResult_celebrities;

					List<QueryMediaDetailJobListResponse.QueryMediaDetailJobList_Job.QueryMediaDetailJobList_MediaDetailResult.QueryMediaDetailJobList_MediaDetailRecgResult.QueryMediaDetailJobList_Sensitive> mediaDetailRecgResult_sensitives = new List<QueryMediaDetailJobListResponse.QueryMediaDetailJobList_Job.QueryMediaDetailJobList_MediaDetailResult.QueryMediaDetailJobList_MediaDetailRecgResult.QueryMediaDetailJobList_Sensitive>();
					for (int k = 0; k < context.Length("QueryMediaDetailJobList.JobList["+ i +"].MediaDetailResult.MediaDetailRecgResults["+ j +"].Sensitives.Length"); k++) {
						QueryMediaDetailJobListResponse.QueryMediaDetailJobList_Job.QueryMediaDetailJobList_MediaDetailResult.QueryMediaDetailJobList_MediaDetailRecgResult.QueryMediaDetailJobList_Sensitive sensitive = new QueryMediaDetailJobListResponse.QueryMediaDetailJobList_Job.QueryMediaDetailJobList_MediaDetailResult.QueryMediaDetailJobList_MediaDetailRecgResult.QueryMediaDetailJobList_Sensitive();
						sensitive.Name = context.StringValue("QueryMediaDetailJobList.JobList["+ i +"].MediaDetailResult.MediaDetailRecgResults["+ j +"].Sensitives["+ k +"].Name");
						sensitive.Score = context.StringValue("QueryMediaDetailJobList.JobList["+ i +"].MediaDetailResult.MediaDetailRecgResults["+ j +"].Sensitives["+ k +"].Score");
						sensitive.Target = context.StringValue("QueryMediaDetailJobList.JobList["+ i +"].MediaDetailResult.MediaDetailRecgResults["+ j +"].Sensitives["+ k +"].Target");

						mediaDetailRecgResult_sensitives.Add(sensitive);
					}
					mediaDetailRecgResult.Sensitives = mediaDetailRecgResult_sensitives;

					List<QueryMediaDetailJobListResponse.QueryMediaDetailJobList_Job.QueryMediaDetailJobList_MediaDetailResult.QueryMediaDetailJobList_MediaDetailRecgResult.QueryMediaDetailJobList_Politician> mediaDetailRecgResult_politicians = new List<QueryMediaDetailJobListResponse.QueryMediaDetailJobList_Job.QueryMediaDetailJobList_MediaDetailResult.QueryMediaDetailJobList_MediaDetailRecgResult.QueryMediaDetailJobList_Politician>();
					for (int k = 0; k < context.Length("QueryMediaDetailJobList.JobList["+ i +"].MediaDetailResult.MediaDetailRecgResults["+ j +"].Politicians.Length"); k++) {
						QueryMediaDetailJobListResponse.QueryMediaDetailJobList_Job.QueryMediaDetailJobList_MediaDetailResult.QueryMediaDetailJobList_MediaDetailRecgResult.QueryMediaDetailJobList_Politician politician = new QueryMediaDetailJobListResponse.QueryMediaDetailJobList_Job.QueryMediaDetailJobList_MediaDetailResult.QueryMediaDetailJobList_MediaDetailRecgResult.QueryMediaDetailJobList_Politician();
						politician.Name = context.StringValue("QueryMediaDetailJobList.JobList["+ i +"].MediaDetailResult.MediaDetailRecgResults["+ j +"].Politicians["+ k +"].Name");
						politician.Score = context.StringValue("QueryMediaDetailJobList.JobList["+ i +"].MediaDetailResult.MediaDetailRecgResults["+ j +"].Politicians["+ k +"].Score");
						politician.Target = context.StringValue("QueryMediaDetailJobList.JobList["+ i +"].MediaDetailResult.MediaDetailRecgResults["+ j +"].Politicians["+ k +"].Target");

						mediaDetailRecgResult_politicians.Add(politician);
					}
					mediaDetailRecgResult.Politicians = mediaDetailRecgResult_politicians;

					List<QueryMediaDetailJobListResponse.QueryMediaDetailJobList_Job.QueryMediaDetailJobList_MediaDetailResult.QueryMediaDetailJobList_MediaDetailRecgResult.QueryMediaDetailJobList_FrameTagInfo> mediaDetailRecgResult_frameTagInfos = new List<QueryMediaDetailJobListResponse.QueryMediaDetailJobList_Job.QueryMediaDetailJobList_MediaDetailResult.QueryMediaDetailJobList_MediaDetailRecgResult.QueryMediaDetailJobList_FrameTagInfo>();
					for (int k = 0; k < context.Length("QueryMediaDetailJobList.JobList["+ i +"].MediaDetailResult.MediaDetailRecgResults["+ j +"].FrameTagInfos.Length"); k++) {
						QueryMediaDetailJobListResponse.QueryMediaDetailJobList_Job.QueryMediaDetailJobList_MediaDetailResult.QueryMediaDetailJobList_MediaDetailRecgResult.QueryMediaDetailJobList_FrameTagInfo frameTagInfo = new QueryMediaDetailJobListResponse.QueryMediaDetailJobList_Job.QueryMediaDetailJobList_MediaDetailResult.QueryMediaDetailJobList_MediaDetailRecgResult.QueryMediaDetailJobList_FrameTagInfo();
						frameTagInfo.Tag = context.StringValue("QueryMediaDetailJobList.JobList["+ i +"].MediaDetailResult.MediaDetailRecgResults["+ j +"].FrameTagInfos["+ k +"].Tag");
						frameTagInfo.Score = context.StringValue("QueryMediaDetailJobList.JobList["+ i +"].MediaDetailResult.MediaDetailRecgResults["+ j +"].FrameTagInfos["+ k +"].Score");
						frameTagInfo.Category = context.StringValue("QueryMediaDetailJobList.JobList["+ i +"].MediaDetailResult.MediaDetailRecgResults["+ j +"].FrameTagInfos["+ k +"].Category");

						mediaDetailRecgResult_frameTagInfos.Add(frameTagInfo);
					}
					mediaDetailRecgResult.FrameTagInfos = mediaDetailRecgResult_frameTagInfos;

					List<QueryMediaDetailJobListResponse.QueryMediaDetailJobList_Job.QueryMediaDetailJobList_MediaDetailResult.QueryMediaDetailJobList_MediaDetailRecgResult.QueryMediaDetailJobList_Custom> mediaDetailRecgResult_customs = new List<QueryMediaDetailJobListResponse.QueryMediaDetailJobList_Job.QueryMediaDetailJobList_MediaDetailResult.QueryMediaDetailJobList_MediaDetailRecgResult.QueryMediaDetailJobList_Custom>();
					for (int k = 0; k < context.Length("QueryMediaDetailJobList.JobList["+ i +"].MediaDetailResult.MediaDetailRecgResults["+ j +"].Customs.Length"); k++) {
						QueryMediaDetailJobListResponse.QueryMediaDetailJobList_Job.QueryMediaDetailJobList_MediaDetailResult.QueryMediaDetailJobList_MediaDetailRecgResult.QueryMediaDetailJobList_Custom custom = new QueryMediaDetailJobListResponse.QueryMediaDetailJobList_Job.QueryMediaDetailJobList_MediaDetailResult.QueryMediaDetailJobList_MediaDetailRecgResult.QueryMediaDetailJobList_Custom();
						custom.Name = context.StringValue("QueryMediaDetailJobList.JobList["+ i +"].MediaDetailResult.MediaDetailRecgResults["+ j +"].Customs["+ k +"].Name");

						List<QueryMediaDetailJobListResponse.QueryMediaDetailJobList_Job.QueryMediaDetailJobList_MediaDetailResult.QueryMediaDetailJobList_MediaDetailRecgResult.QueryMediaDetailJobList_Custom.QueryMediaDetailJobList_Clip> custom_clips = new List<QueryMediaDetailJobListResponse.QueryMediaDetailJobList_Job.QueryMediaDetailJobList_MediaDetailResult.QueryMediaDetailJobList_MediaDetailRecgResult.QueryMediaDetailJobList_Custom.QueryMediaDetailJobList_Clip>();
						for (int l = 0; l < context.Length("QueryMediaDetailJobList.JobList["+ i +"].MediaDetailResult.MediaDetailRecgResults["+ j +"].Customs["+ k +"].Clips.Length"); l++) {
							QueryMediaDetailJobListResponse.QueryMediaDetailJobList_Job.QueryMediaDetailJobList_MediaDetailResult.QueryMediaDetailJobList_MediaDetailRecgResult.QueryMediaDetailJobList_Custom.QueryMediaDetailJobList_Clip clip = new QueryMediaDetailJobListResponse.QueryMediaDetailJobList_Job.QueryMediaDetailJobList_MediaDetailResult.QueryMediaDetailJobList_MediaDetailRecgResult.QueryMediaDetailJobList_Custom.QueryMediaDetailJobList_Clip();
							clip.MinScore = context.StringValue("QueryMediaDetailJobList.JobList["+ i +"].MediaDetailResult.MediaDetailRecgResults["+ j +"].Customs["+ k +"].Clips["+ l +"].MinScore");
							clip.MaxScore = context.StringValue("QueryMediaDetailJobList.JobList["+ i +"].MediaDetailResult.MediaDetailRecgResults["+ j +"].Customs["+ k +"].Clips["+ l +"].MaxScore");
							clip.AvgScore = context.StringValue("QueryMediaDetailJobList.JobList["+ i +"].MediaDetailResult.MediaDetailRecgResults["+ j +"].Customs["+ k +"].Clips["+ l +"].AvgScore");
							clip.StartTarget = context.StringValue("QueryMediaDetailJobList.JobList["+ i +"].MediaDetailResult.MediaDetailRecgResults["+ j +"].Customs["+ k +"].Clips["+ l +"].StartTarget");
							clip.EndTarget = context.StringValue("QueryMediaDetailJobList.JobList["+ i +"].MediaDetailResult.MediaDetailRecgResults["+ j +"].Customs["+ k +"].Clips["+ l +"].EndTarget");
							clip.StartTime = context.StringValue("QueryMediaDetailJobList.JobList["+ i +"].MediaDetailResult.MediaDetailRecgResults["+ j +"].Customs["+ k +"].Clips["+ l +"].StartTime");
							clip.EndTime = context.StringValue("QueryMediaDetailJobList.JobList["+ i +"].MediaDetailResult.MediaDetailRecgResults["+ j +"].Customs["+ k +"].Clips["+ l +"].EndTime");

							custom_clips.Add(clip);
						}
						custom.Clips = custom_clips;

						mediaDetailRecgResult_customs.Add(custom);
					}
					mediaDetailRecgResult.Customs = mediaDetailRecgResult_customs;

					mediaDetailResult_mediaDetailRecgResults.Add(mediaDetailRecgResult);
				}
				mediaDetailResult.MediaDetailRecgResults = mediaDetailResult_mediaDetailRecgResults;
				job.MediaDetailResult = mediaDetailResult;

				queryMediaDetailJobListResponse_jobList.Add(job);
			}
			queryMediaDetailJobListResponse.JobList = queryMediaDetailJobListResponse_jobList;
        
			return queryMediaDetailJobListResponse;
        }
    }
}