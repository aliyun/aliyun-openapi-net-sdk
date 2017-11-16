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
    public class QueryCoverJobListResponseUnmarshaller
    {
        public static QueryCoverJobListResponse Unmarshall(UnmarshallerContext context)
        {
			QueryCoverJobListResponse queryCoverJobListResponse = new QueryCoverJobListResponse();

			queryCoverJobListResponse.HttpResponse = context.HttpResponse;
			queryCoverJobListResponse.RequestId = context.StringValue("QueryCoverJobList.RequestId");

			List<string> queryCoverJobListResponse_nonExistIds = new List<string>();
			for (int i = 0; i < context.Length("QueryCoverJobList.NonExistIds.Length"); i++) {
				queryCoverJobListResponse_nonExistIds.Add(context.StringValue("QueryCoverJobList.NonExistIds["+ i +"]"));
			}
			queryCoverJobListResponse.NonExistIds = queryCoverJobListResponse_nonExistIds;

			List<QueryCoverJobListResponse.QueryCoverJobList_CoverJob> queryCoverJobListResponse_coverJobList = new List<QueryCoverJobListResponse.QueryCoverJobList_CoverJob>();
			for (int i = 0; i < context.Length("QueryCoverJobList.CoverJobList.Length"); i++) {
				QueryCoverJobListResponse.QueryCoverJobList_CoverJob coverJob = new QueryCoverJobListResponse.QueryCoverJobList_CoverJob();
				coverJob.Id = context.StringValue("QueryCoverJobList.CoverJobList["+ i +"].Id");
				coverJob.UserData = context.StringValue("QueryCoverJobList.CoverJobList["+ i +"].UserData");
				coverJob.PipelineId = context.StringValue("QueryCoverJobList.CoverJobList["+ i +"].PipelineId");
				coverJob.State = context.StringValue("QueryCoverJobList.CoverJobList["+ i +"].State");
				coverJob.Code = context.StringValue("QueryCoverJobList.CoverJobList["+ i +"].Code");
				coverJob.Message = context.StringValue("QueryCoverJobList.CoverJobList["+ i +"].Message");
				coverJob.CreationTime = context.StringValue("QueryCoverJobList.CoverJobList["+ i +"].CreationTime");

				QueryCoverJobListResponse.QueryCoverJobList_CoverJob.QueryCoverJobList_Input input = new QueryCoverJobListResponse.QueryCoverJobList_CoverJob.QueryCoverJobList_Input();
				input.Bucket = context.StringValue("QueryCoverJobList.CoverJobList["+ i +"].Input.Bucket");
				input.Location = context.StringValue("QueryCoverJobList.CoverJobList["+ i +"].Input.Location");
				input._Object = context.StringValue("QueryCoverJobList.CoverJobList["+ i +"].Input.Object");
				coverJob.Input = input;

				QueryCoverJobListResponse.QueryCoverJobList_CoverJob.QueryCoverJobList_CoverConfig coverConfig = new QueryCoverJobListResponse.QueryCoverJobList_CoverJob.QueryCoverJobList_CoverConfig();

				QueryCoverJobListResponse.QueryCoverJobList_CoverJob.QueryCoverJobList_CoverConfig.QueryCoverJobList_OutputFile outputFile = new QueryCoverJobListResponse.QueryCoverJobList_CoverJob.QueryCoverJobList_CoverConfig.QueryCoverJobList_OutputFile();
				outputFile.Bucket = context.StringValue("QueryCoverJobList.CoverJobList["+ i +"].CoverConfig.OutputFile.Bucket");
				outputFile.Location = context.StringValue("QueryCoverJobList.CoverJobList["+ i +"].CoverConfig.OutputFile.Location");
				outputFile._Object = context.StringValue("QueryCoverJobList.CoverJobList["+ i +"].CoverConfig.OutputFile.Object");
				coverConfig.OutputFile = outputFile;
				coverJob.CoverConfig = coverConfig;

				List<QueryCoverJobListResponse.QueryCoverJobList_CoverJob.QueryCoverJobList_CoverImage> coverJob_coverImageList = new List<QueryCoverJobListResponse.QueryCoverJobList_CoverJob.QueryCoverJobList_CoverImage>();
				for (int j = 0; j < context.Length("QueryCoverJobList.CoverJobList["+ i +"].CoverImageList.Length"); j++) {
					QueryCoverJobListResponse.QueryCoverJobList_CoverJob.QueryCoverJobList_CoverImage coverImage = new QueryCoverJobListResponse.QueryCoverJobList_CoverJob.QueryCoverJobList_CoverImage();
					coverImage.Score = context.StringValue("QueryCoverJobList.CoverJobList["+ i +"].CoverImageList["+ j +"].Score");
					coverImage.Url = context.StringValue("QueryCoverJobList.CoverJobList["+ i +"].CoverImageList["+ j +"].Url");
					coverImage.Time = context.StringValue("QueryCoverJobList.CoverJobList["+ i +"].CoverImageList["+ j +"].Time");

					coverJob_coverImageList.Add(coverImage);
				}
				coverJob.CoverImageList = coverJob_coverImageList;

				queryCoverJobListResponse_coverJobList.Add(coverJob);
			}
			queryCoverJobListResponse.CoverJobList = queryCoverJobListResponse_coverJobList;
        
			return queryCoverJobListResponse;
        }
    }
}