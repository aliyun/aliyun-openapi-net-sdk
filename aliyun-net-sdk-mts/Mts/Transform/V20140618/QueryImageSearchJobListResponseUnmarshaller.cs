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
    public class QueryImageSearchJobListResponseUnmarshaller
    {
        public static QueryImageSearchJobListResponse Unmarshall(UnmarshallerContext context)
        {
			QueryImageSearchJobListResponse queryImageSearchJobListResponse = new QueryImageSearchJobListResponse();

			queryImageSearchJobListResponse.HttpResponse = context.HttpResponse;
			queryImageSearchJobListResponse.RequestId = context.StringValue("QueryImageSearchJobList.RequestId");

			List<string> queryImageSearchJobListResponse_nonExistIds = new List<string>();
			for (int i = 0; i < context.Length("QueryImageSearchJobList.NonExistIds.Length"); i++) {
				queryImageSearchJobListResponse_nonExistIds.Add(context.StringValue("QueryImageSearchJobList.NonExistIds["+ i +"]"));
			}
			queryImageSearchJobListResponse.NonExistIds = queryImageSearchJobListResponse_nonExistIds;

			List<QueryImageSearchJobListResponse.QueryImageSearchJobList_ImageSearchJob> queryImageSearchJobListResponse_imageSearchJobList = new List<QueryImageSearchJobListResponse.QueryImageSearchJobList_ImageSearchJob>();
			for (int i = 0; i < context.Length("QueryImageSearchJobList.ImageSearchJobList.Length"); i++) {
				QueryImageSearchJobListResponse.QueryImageSearchJobList_ImageSearchJob imageSearchJob = new QueryImageSearchJobListResponse.QueryImageSearchJobList_ImageSearchJob();
				imageSearchJob.Id = context.StringValue("QueryImageSearchJobList.ImageSearchJobList["+ i +"].Id");
				imageSearchJob.UserData = context.StringValue("QueryImageSearchJobList.ImageSearchJobList["+ i +"].UserData");
				imageSearchJob.PipelineId = context.StringValue("QueryImageSearchJobList.ImageSearchJobList["+ i +"].PipelineId");
				imageSearchJob.State = context.StringValue("QueryImageSearchJobList.ImageSearchJobList["+ i +"].State");
				imageSearchJob.Code = context.StringValue("QueryImageSearchJobList.ImageSearchJobList["+ i +"].Code");
				imageSearchJob.Message = context.StringValue("QueryImageSearchJobList.ImageSearchJobList["+ i +"].Message");
				imageSearchJob.CreationTime = context.StringValue("QueryImageSearchJobList.ImageSearchJobList["+ i +"].CreationTime");
				imageSearchJob.FinishTime = context.StringValue("QueryImageSearchJobList.ImageSearchJobList["+ i +"].FinishTime");

				QueryImageSearchJobListResponse.QueryImageSearchJobList_ImageSearchJob.QueryImageSearchJobList_InputVideo inputVideo = new QueryImageSearchJobListResponse.QueryImageSearchJobList_ImageSearchJob.QueryImageSearchJobList_InputVideo();
				inputVideo.Bucket = context.StringValue("QueryImageSearchJobList.ImageSearchJobList["+ i +"].InputVideo.Bucket");
				inputVideo.Location = context.StringValue("QueryImageSearchJobList.ImageSearchJobList["+ i +"].InputVideo.Location");
				inputVideo._Object = context.StringValue("QueryImageSearchJobList.ImageSearchJobList["+ i +"].InputVideo.Object");
				imageSearchJob.InputVideo = inputVideo;

				QueryImageSearchJobListResponse.QueryImageSearchJobList_ImageSearchJob.QueryImageSearchJobList_InputImage inputImage = new QueryImageSearchJobListResponse.QueryImageSearchJobList_ImageSearchJob.QueryImageSearchJobList_InputImage();
				inputImage.Bucket = context.StringValue("QueryImageSearchJobList.ImageSearchJobList["+ i +"].InputImage.Bucket");
				inputImage.Location = context.StringValue("QueryImageSearchJobList.ImageSearchJobList["+ i +"].InputImage.Location");
				inputImage._Object = context.StringValue("QueryImageSearchJobList.ImageSearchJobList["+ i +"].InputImage.Object");
				imageSearchJob.InputImage = inputImage;

				QueryImageSearchJobListResponse.QueryImageSearchJobList_ImageSearchJob.QueryImageSearchJobList_Result result = new QueryImageSearchJobListResponse.QueryImageSearchJobList_ImageSearchJob.QueryImageSearchJobList_Result();

				List<QueryImageSearchJobListResponse.QueryImageSearchJobList_ImageSearchJob.QueryImageSearchJobList_Result.QueryImageSearchJobList_ImageSearchShotsItem> result_imageSearchShots = new List<QueryImageSearchJobListResponse.QueryImageSearchJobList_ImageSearchJob.QueryImageSearchJobList_Result.QueryImageSearchJobList_ImageSearchShotsItem>();
				for (int j = 0; j < context.Length("QueryImageSearchJobList.ImageSearchJobList["+ i +"].Result.ImageSearchShots.Length"); j++) {
					QueryImageSearchJobListResponse.QueryImageSearchJobList_ImageSearchJob.QueryImageSearchJobList_Result.QueryImageSearchJobList_ImageSearchShotsItem imageSearchShotsItem = new QueryImageSearchJobListResponse.QueryImageSearchJobList_ImageSearchJob.QueryImageSearchJobList_Result.QueryImageSearchJobList_ImageSearchShotsItem();
					imageSearchShotsItem.MatchedTimestamp = context.StringValue("QueryImageSearchJobList.ImageSearchJobList["+ i +"].Result.ImageSearchShots["+ j +"].MatchedTimestamp");
					imageSearchShotsItem.MatchedFrame = context.StringValue("QueryImageSearchJobList.ImageSearchJobList["+ i +"].Result.ImageSearchShots["+ j +"].MatchedFrame");
					imageSearchShotsItem.Similarity = context.StringValue("QueryImageSearchJobList.ImageSearchJobList["+ i +"].Result.ImageSearchShots["+ j +"].Similarity");

					result_imageSearchShots.Add(imageSearchShotsItem);
				}
				result.ImageSearchShots = result_imageSearchShots;
				imageSearchJob.Result = result;

				queryImageSearchJobListResponse_imageSearchJobList.Add(imageSearchJob);
			}
			queryImageSearchJobListResponse.ImageSearchJobList = queryImageSearchJobListResponse_imageSearchJobList;
        
			return queryImageSearchJobListResponse;
        }
    }
}
