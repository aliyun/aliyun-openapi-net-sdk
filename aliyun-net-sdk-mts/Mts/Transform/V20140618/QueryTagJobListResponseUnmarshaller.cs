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
    public class QueryTagJobListResponseUnmarshaller
    {
        public static QueryTagJobListResponse Unmarshall(UnmarshallerContext context)
        {
			QueryTagJobListResponse queryTagJobListResponse = new QueryTagJobListResponse();

			queryTagJobListResponse.HttpResponse = context.HttpResponse;
			queryTagJobListResponse.RequestId = context.StringValue("QueryTagJobList.RequestId");

			List<string> queryTagJobListResponse_nonExistIds = new List<string>();
			for (int i = 0; i < context.Length("QueryTagJobList.NonExistIds.Length"); i++) {
				queryTagJobListResponse_nonExistIds.Add(context.StringValue("QueryTagJobList.NonExistIds["+ i +"]"));
			}
			queryTagJobListResponse.NonExistIds = queryTagJobListResponse_nonExistIds;

			List<QueryTagJobListResponse.QueryTagJobList_TagJob> queryTagJobListResponse_tagJobList = new List<QueryTagJobListResponse.QueryTagJobList_TagJob>();
			for (int i = 0; i < context.Length("QueryTagJobList.TagJobList.Length"); i++) {
				QueryTagJobListResponse.QueryTagJobList_TagJob tagJob = new QueryTagJobListResponse.QueryTagJobList_TagJob();
				tagJob.Id = context.StringValue("QueryTagJobList.TagJobList["+ i +"].Id");
				tagJob.UserData = context.StringValue("QueryTagJobList.TagJobList["+ i +"].UserData");
				tagJob.PipelineId = context.StringValue("QueryTagJobList.TagJobList["+ i +"].PipelineId");
				tagJob.State = context.StringValue("QueryTagJobList.TagJobList["+ i +"].State");
				tagJob.Code = context.StringValue("QueryTagJobList.TagJobList["+ i +"].Code");
				tagJob.Message = context.StringValue("QueryTagJobList.TagJobList["+ i +"].Message");
				tagJob.CreationTime = context.StringValue("QueryTagJobList.TagJobList["+ i +"].CreationTime");

				QueryTagJobListResponse.QueryTagJobList_TagJob.QueryTagJobList_Input input = new QueryTagJobListResponse.QueryTagJobList_TagJob.QueryTagJobList_Input();
				input.Bucket = context.StringValue("QueryTagJobList.TagJobList["+ i +"].Input.Bucket");
				input.Location = context.StringValue("QueryTagJobList.TagJobList["+ i +"].Input.Location");
				input._Object = context.StringValue("QueryTagJobList.TagJobList["+ i +"].Input.Object");
				tagJob.Input = input;

				QueryTagJobListResponse.QueryTagJobList_TagJob.QueryTagJobList_VideoTagResult videoTagResult = new QueryTagJobListResponse.QueryTagJobList_TagJob.QueryTagJobList_VideoTagResult();
				videoTagResult.Details = context.StringValue("QueryTagJobList.TagJobList["+ i +"].VideoTagResult.Details");

				List<QueryTagJobListResponse.QueryTagJobList_TagJob.QueryTagJobList_VideoTagResult.QueryTagJobList_TagAnResult> videoTagResult_tagAnResults = new List<QueryTagJobListResponse.QueryTagJobList_TagJob.QueryTagJobList_VideoTagResult.QueryTagJobList_TagAnResult>();
				for (int j = 0; j < context.Length("QueryTagJobList.TagJobList["+ i +"].VideoTagResult.TagAnResults.Length"); j++) {
					QueryTagJobListResponse.QueryTagJobList_TagJob.QueryTagJobList_VideoTagResult.QueryTagJobList_TagAnResult tagAnResult = new QueryTagJobListResponse.QueryTagJobList_TagJob.QueryTagJobList_VideoTagResult.QueryTagJobList_TagAnResult();
					tagAnResult.Label = context.StringValue("QueryTagJobList.TagJobList["+ i +"].VideoTagResult.TagAnResults["+ j +"].Label");
					tagAnResult.Score = context.StringValue("QueryTagJobList.TagJobList["+ i +"].VideoTagResult.TagAnResults["+ j +"].Score");

					videoTagResult_tagAnResults.Add(tagAnResult);
				}
				videoTagResult.TagAnResults = videoTagResult_tagAnResults;

				List<QueryTagJobListResponse.QueryTagJobList_TagJob.QueryTagJobList_VideoTagResult.QueryTagJobList_TagFrResult> videoTagResult_tagFrResults = new List<QueryTagJobListResponse.QueryTagJobList_TagJob.QueryTagJobList_VideoTagResult.QueryTagJobList_TagFrResult>();
				for (int j = 0; j < context.Length("QueryTagJobList.TagJobList["+ i +"].VideoTagResult.TagFrResults.Length"); j++) {
					QueryTagJobListResponse.QueryTagJobList_TagJob.QueryTagJobList_VideoTagResult.QueryTagJobList_TagFrResult tagFrResult = new QueryTagJobListResponse.QueryTagJobList_TagJob.QueryTagJobList_VideoTagResult.QueryTagJobList_TagFrResult();
					tagFrResult.Time = context.StringValue("QueryTagJobList.TagJobList["+ i +"].VideoTagResult.TagFrResults["+ j +"].Time");

					List<QueryTagJobListResponse.QueryTagJobList_TagJob.QueryTagJobList_VideoTagResult.QueryTagJobList_TagFrResult.QueryTagJobList_TagFace> tagFrResult_tagFaces = new List<QueryTagJobListResponse.QueryTagJobList_TagJob.QueryTagJobList_VideoTagResult.QueryTagJobList_TagFrResult.QueryTagJobList_TagFace>();
					for (int k = 0; k < context.Length("QueryTagJobList.TagJobList["+ i +"].VideoTagResult.TagFrResults["+ j +"].TagFaces.Length"); k++) {
						QueryTagJobListResponse.QueryTagJobList_TagJob.QueryTagJobList_VideoTagResult.QueryTagJobList_TagFrResult.QueryTagJobList_TagFace tagFace = new QueryTagJobListResponse.QueryTagJobList_TagJob.QueryTagJobList_VideoTagResult.QueryTagJobList_TagFrResult.QueryTagJobList_TagFace();
						tagFace.Name = context.StringValue("QueryTagJobList.TagJobList["+ i +"].VideoTagResult.TagFrResults["+ j +"].TagFaces["+ k +"].Name");
						tagFace.Score = context.StringValue("QueryTagJobList.TagJobList["+ i +"].VideoTagResult.TagFrResults["+ j +"].TagFaces["+ k +"].Score");
						tagFace.Target = context.StringValue("QueryTagJobList.TagJobList["+ i +"].VideoTagResult.TagFrResults["+ j +"].TagFaces["+ k +"].Target");

						tagFrResult_tagFaces.Add(tagFace);
					}
					tagFrResult.TagFaces = tagFrResult_tagFaces;

					videoTagResult_tagFrResults.Add(tagFrResult);
				}
				videoTagResult.TagFrResults = videoTagResult_tagFrResults;
				tagJob.VideoTagResult = videoTagResult;

				queryTagJobListResponse_tagJobList.Add(tagJob);
			}
			queryTagJobListResponse.TagJobList = queryTagJobListResponse_tagJobList;
        
			return queryTagJobListResponse;
        }
    }
}