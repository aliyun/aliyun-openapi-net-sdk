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
    public class QueryMcuJobResponseUnmarshaller
    {
        public static QueryMcuJobResponse Unmarshall(UnmarshallerContext context)
        {
			QueryMcuJobResponse queryMcuJobResponse = new QueryMcuJobResponse();

			queryMcuJobResponse.HttpResponse = context.HttpResponse;
			queryMcuJobResponse.RequestId = context.StringValue("QueryMcuJob.RequestId");

			List<string> queryMcuJobResponse_nonExistJobIds = new List<string>();
			for (int i = 0; i < context.Length("QueryMcuJob.NonExistJobIds.Length"); i++) {
				queryMcuJobResponse_nonExistJobIds.Add(context.StringValue("QueryMcuJob.NonExistJobIds["+ i +"]"));
			}
			queryMcuJobResponse.NonExistJobIds = queryMcuJobResponse_nonExistJobIds;

			List<QueryMcuJobResponse.QueryMcuJob_Job> queryMcuJobResponse_jobResult = new List<QueryMcuJobResponse.QueryMcuJob_Job>();
			for (int i = 0; i < context.Length("QueryMcuJob.JobResult.Length"); i++) {
				QueryMcuJobResponse.QueryMcuJob_Job job = new QueryMcuJobResponse.QueryMcuJob_Job();
				job.JobId = context.StringValue("QueryMcuJob.JobResult["+ i +"].JobId");
				job.UserData = context.StringValue("QueryMcuJob.JobResult["+ i +"].UserData");
				job.TemplateId = context.StringValue("QueryMcuJob.JobResult["+ i +"].TemplateId");
				job.Template = context.StringValue("QueryMcuJob.JobResult["+ i +"].Template");

				QueryMcuJobResponse.QueryMcuJob_Job.QueryMcuJob_Input input = new QueryMcuJobResponse.QueryMcuJob_Job.QueryMcuJob_Input();
				input.Bucket = context.StringValue("QueryMcuJob.JobResult["+ i +"].Input.Bucket");
				input.Location = context.StringValue("QueryMcuJob.JobResult["+ i +"].Input.Location");
				input._Object = context.StringValue("QueryMcuJob.JobResult["+ i +"].Input.Object");
				job.Input = input;

				QueryMcuJobResponse.QueryMcuJob_Job.QueryMcuJob_AsrResult asrResult = new QueryMcuJobResponse.QueryMcuJob_Job.QueryMcuJob_AsrResult();
				asrResult.Duration = context.StringValue("QueryMcuJob.JobResult["+ i +"].AsrResult.Duration");

				List<QueryMcuJobResponse.QueryMcuJob_Job.QueryMcuJob_AsrResult.QueryMcuJob_AsrText> asrResult_asrTextList = new List<QueryMcuJobResponse.QueryMcuJob_Job.QueryMcuJob_AsrResult.QueryMcuJob_AsrText>();
				for (int j = 0; j < context.Length("QueryMcuJob.JobResult["+ i +"].AsrResult.AsrTextList.Length"); j++) {
					QueryMcuJobResponse.QueryMcuJob_Job.QueryMcuJob_AsrResult.QueryMcuJob_AsrText asrText = new QueryMcuJobResponse.QueryMcuJob_Job.QueryMcuJob_AsrResult.QueryMcuJob_AsrText();
					asrText.StartTime = context.IntegerValue("QueryMcuJob.JobResult["+ i +"].AsrResult.AsrTextList["+ j +"].StartTime");
					asrText.EndTime = context.StringValue("QueryMcuJob.JobResult["+ i +"].AsrResult.AsrTextList["+ j +"].EndTime");
					asrText.ChannelId = context.StringValue("QueryMcuJob.JobResult["+ i +"].AsrResult.AsrTextList["+ j +"].ChannelId");
					asrText.SpeechRate = context.StringValue("QueryMcuJob.JobResult["+ i +"].AsrResult.AsrTextList["+ j +"].SpeechRate");
					asrText.Text = context.StringValue("QueryMcuJob.JobResult["+ i +"].AsrResult.AsrTextList["+ j +"].Text");

					asrResult_asrTextList.Add(asrText);
				}
				asrResult.AsrTextList = asrResult_asrTextList;
				job.AsrResult = asrResult;

				QueryMcuJobResponse.QueryMcuJob_Job.QueryMcuJob_CategoryResult categoryResult = new QueryMcuJobResponse.QueryMcuJob_Job.QueryMcuJob_CategoryResult();
				categoryResult.Details = context.StringValue("QueryMcuJob.JobResult["+ i +"].CategoryResult.Details");

				List<QueryMcuJobResponse.QueryMcuJob_Job.QueryMcuJob_CategoryResult.QueryMcuJob_Category> categoryResult_categories = new List<QueryMcuJobResponse.QueryMcuJob_Job.QueryMcuJob_CategoryResult.QueryMcuJob_Category>();
				for (int j = 0; j < context.Length("QueryMcuJob.JobResult["+ i +"].CategoryResult.Categories.Length"); j++) {
					QueryMcuJobResponse.QueryMcuJob_Job.QueryMcuJob_CategoryResult.QueryMcuJob_Category category = new QueryMcuJobResponse.QueryMcuJob_Job.QueryMcuJob_CategoryResult.QueryMcuJob_Category();
					category.Label = context.StringValue("QueryMcuJob.JobResult["+ i +"].CategoryResult.Categories["+ j +"].Label");
					category.Score = context.StringValue("QueryMcuJob.JobResult["+ i +"].CategoryResult.Categories["+ j +"].Score");

					categoryResult_categories.Add(category);
				}
				categoryResult.Categories = categoryResult_categories;
				job.CategoryResult = categoryResult;

				List<QueryMcuJobResponse.QueryMcuJob_Job.QueryMcuJob_Ocr> job_ocrResult = new List<QueryMcuJobResponse.QueryMcuJob_Job.QueryMcuJob_Ocr>();
				for (int j = 0; j < context.Length("QueryMcuJob.JobResult["+ i +"].OcrResult.Length"); j++) {
					QueryMcuJobResponse.QueryMcuJob_Job.QueryMcuJob_Ocr ocr = new QueryMcuJobResponse.QueryMcuJob_Job.QueryMcuJob_Ocr();
					ocr.Time = context.StringValue("QueryMcuJob.JobResult["+ i +"].OcrResult["+ j +"].Time");
					ocr.OcrText = context.StringValue("QueryMcuJob.JobResult["+ i +"].OcrResult["+ j +"].OcrText");
					ocr.ImageUrl = context.StringValue("QueryMcuJob.JobResult["+ i +"].OcrResult["+ j +"].ImageUrl");
					ocr.ImageId = context.StringValue("QueryMcuJob.JobResult["+ i +"].OcrResult["+ j +"].ImageId");

					job_ocrResult.Add(ocr);
				}
				job.OcrResult = job_ocrResult;

				List<QueryMcuJobResponse.QueryMcuJob_Job.QueryMcuJob_Tag> job_tagResult = new List<QueryMcuJobResponse.QueryMcuJob_Job.QueryMcuJob_Tag>();
				for (int j = 0; j < context.Length("QueryMcuJob.JobResult["+ i +"].TagResult.Length"); j++) {
					QueryMcuJobResponse.QueryMcuJob_Job.QueryMcuJob_Tag tag = new QueryMcuJobResponse.QueryMcuJob_Job.QueryMcuJob_Tag();
					tag.Time = context.StringValue("QueryMcuJob.JobResult["+ i +"].TagResult["+ j +"].Time");
					tag.ImageUrl = context.StringValue("QueryMcuJob.JobResult["+ i +"].TagResult["+ j +"].ImageUrl");
					tag.ImageId = context.StringValue("QueryMcuJob.JobResult["+ i +"].TagResult["+ j +"].ImageId");

					List<QueryMcuJobResponse.QueryMcuJob_Job.QueryMcuJob_Tag.QueryMcuJob_FrameTagInfo> tag_frameTagInfos = new List<QueryMcuJobResponse.QueryMcuJob_Job.QueryMcuJob_Tag.QueryMcuJob_FrameTagInfo>();
					for (int k = 0; k < context.Length("QueryMcuJob.JobResult["+ i +"].TagResult["+ j +"].FrameTagInfos.Length"); k++) {
						QueryMcuJobResponse.QueryMcuJob_Job.QueryMcuJob_Tag.QueryMcuJob_FrameTagInfo frameTagInfo = new QueryMcuJobResponse.QueryMcuJob_Job.QueryMcuJob_Tag.QueryMcuJob_FrameTagInfo();
						frameTagInfo.Tag = context.StringValue("QueryMcuJob.JobResult["+ i +"].TagResult["+ j +"].FrameTagInfos["+ k +"].Tag");
						frameTagInfo.Score = context.StringValue("QueryMcuJob.JobResult["+ i +"].TagResult["+ j +"].FrameTagInfos["+ k +"].Score");
						frameTagInfo.Category = context.StringValue("QueryMcuJob.JobResult["+ i +"].TagResult["+ j +"].FrameTagInfos["+ k +"].Category");

						tag_frameTagInfos.Add(frameTagInfo);
					}
					tag.FrameTagInfos = tag_frameTagInfos;

					job_tagResult.Add(tag);
				}
				job.TagResult = job_tagResult;

				List<QueryMcuJobResponse.QueryMcuJob_Job.QueryMcuJob_Face> job_faceResult = new List<QueryMcuJobResponse.QueryMcuJob_Job.QueryMcuJob_Face>();
				for (int j = 0; j < context.Length("QueryMcuJob.JobResult["+ i +"].FaceResult.Length"); j++) {
					QueryMcuJobResponse.QueryMcuJob_Job.QueryMcuJob_Face face = new QueryMcuJobResponse.QueryMcuJob_Job.QueryMcuJob_Face();
					face.Time = context.StringValue("QueryMcuJob.JobResult["+ i +"].FaceResult["+ j +"].Time");
					face.ImageUrl = context.StringValue("QueryMcuJob.JobResult["+ i +"].FaceResult["+ j +"].ImageUrl");
					face.ImageId = context.StringValue("QueryMcuJob.JobResult["+ i +"].FaceResult["+ j +"].ImageId");

					List<QueryMcuJobResponse.QueryMcuJob_Job.QueryMcuJob_Face.QueryMcuJob_Celebrity> face_celebrities = new List<QueryMcuJobResponse.QueryMcuJob_Job.QueryMcuJob_Face.QueryMcuJob_Celebrity>();
					for (int k = 0; k < context.Length("QueryMcuJob.JobResult["+ i +"].FaceResult["+ j +"].Celebrities.Length"); k++) {
						QueryMcuJobResponse.QueryMcuJob_Job.QueryMcuJob_Face.QueryMcuJob_Celebrity celebrity = new QueryMcuJobResponse.QueryMcuJob_Job.QueryMcuJob_Face.QueryMcuJob_Celebrity();
						celebrity.Name = context.StringValue("QueryMcuJob.JobResult["+ i +"].FaceResult["+ j +"].Celebrities["+ k +"].Name");
						celebrity.Score = context.StringValue("QueryMcuJob.JobResult["+ i +"].FaceResult["+ j +"].Celebrities["+ k +"].Score");
						celebrity.Target = context.StringValue("QueryMcuJob.JobResult["+ i +"].FaceResult["+ j +"].Celebrities["+ k +"].Target");

						face_celebrities.Add(celebrity);
					}
					face.Celebrities = face_celebrities;

					job_faceResult.Add(face);
				}
				job.FaceResult = job_faceResult;

				List<QueryMcuJobResponse.QueryMcuJob_Job.QueryMcuJob_SubTask> job_subTaskInfo = new List<QueryMcuJobResponse.QueryMcuJob_Job.QueryMcuJob_SubTask>();
				for (int j = 0; j < context.Length("QueryMcuJob.JobResult["+ i +"].SubTaskInfo.Length"); j++) {
					QueryMcuJobResponse.QueryMcuJob_Job.QueryMcuJob_SubTask subTask = new QueryMcuJobResponse.QueryMcuJob_Job.QueryMcuJob_SubTask();
					subTask.Type = context.StringValue("QueryMcuJob.JobResult["+ i +"].SubTaskInfo["+ j +"].Type");
					subTask.Code = context.StringValue("QueryMcuJob.JobResult["+ i +"].SubTaskInfo["+ j +"].Code");
					subTask.Message = context.StringValue("QueryMcuJob.JobResult["+ i +"].SubTaskInfo["+ j +"].Message");

					job_subTaskInfo.Add(subTask);
				}
				job.SubTaskInfo = job_subTaskInfo;

				queryMcuJobResponse_jobResult.Add(job);
			}
			queryMcuJobResponse.JobResult = queryMcuJobResponse_jobResult;
        
			return queryMcuJobResponse;
        }
    }
}
