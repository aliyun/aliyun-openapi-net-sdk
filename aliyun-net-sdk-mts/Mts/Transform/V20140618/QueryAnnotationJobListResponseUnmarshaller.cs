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
    public class QueryAnnotationJobListResponseUnmarshaller
    {
        public static QueryAnnotationJobListResponse Unmarshall(UnmarshallerContext context)
        {
			QueryAnnotationJobListResponse queryAnnotationJobListResponse = new QueryAnnotationJobListResponse();

			queryAnnotationJobListResponse.HttpResponse = context.HttpResponse;
			queryAnnotationJobListResponse.RequestId = context.StringValue("QueryAnnotationJobList.RequestId");

			List<string> queryAnnotationJobListResponse_nonExistIds = new List<string>();
			for (int i = 0; i < context.Length("QueryAnnotationJobList.NonExistIds.Length"); i++) {
				queryAnnotationJobListResponse_nonExistIds.Add(context.StringValue("QueryAnnotationJobList.NonExistIds["+ i +"]"));
			}
			queryAnnotationJobListResponse.NonExistIds = queryAnnotationJobListResponse_nonExistIds;

			List<QueryAnnotationJobListResponse.QueryAnnotationJobList_AnnotationJob> queryAnnotationJobListResponse_annotationJobList = new List<QueryAnnotationJobListResponse.QueryAnnotationJobList_AnnotationJob>();
			for (int i = 0; i < context.Length("QueryAnnotationJobList.AnnotationJobList.Length"); i++) {
				QueryAnnotationJobListResponse.QueryAnnotationJobList_AnnotationJob annotationJob = new QueryAnnotationJobListResponse.QueryAnnotationJobList_AnnotationJob();
				annotationJob.Id = context.StringValue("QueryAnnotationJobList.AnnotationJobList["+ i +"].Id");
				annotationJob.UserData = context.StringValue("QueryAnnotationJobList.AnnotationJobList["+ i +"].UserData");
				annotationJob.PipelineId = context.StringValue("QueryAnnotationJobList.AnnotationJobList["+ i +"].PipelineId");
				annotationJob.State = context.StringValue("QueryAnnotationJobList.AnnotationJobList["+ i +"].State");
				annotationJob.Code = context.StringValue("QueryAnnotationJobList.AnnotationJobList["+ i +"].Code");
				annotationJob.Message = context.StringValue("QueryAnnotationJobList.AnnotationJobList["+ i +"].Message");
				annotationJob.CreationTime = context.StringValue("QueryAnnotationJobList.AnnotationJobList["+ i +"].CreationTime");

				QueryAnnotationJobListResponse.QueryAnnotationJobList_AnnotationJob.QueryAnnotationJobList_Input input = new QueryAnnotationJobListResponse.QueryAnnotationJobList_AnnotationJob.QueryAnnotationJobList_Input();
				input.Bucket = context.StringValue("QueryAnnotationJobList.AnnotationJobList["+ i +"].Input.Bucket");
				input.Location = context.StringValue("QueryAnnotationJobList.AnnotationJobList["+ i +"].Input.Location");
				input._Object = context.StringValue("QueryAnnotationJobList.AnnotationJobList["+ i +"].Input.Object");
				annotationJob.Input = input;

				QueryAnnotationJobListResponse.QueryAnnotationJobList_AnnotationJob.QueryAnnotationJobList_VideoAnnotationResult videoAnnotationResult = new QueryAnnotationJobListResponse.QueryAnnotationJobList_AnnotationJob.QueryAnnotationJobList_VideoAnnotationResult();
				videoAnnotationResult.Details = context.StringValue("QueryAnnotationJobList.AnnotationJobList["+ i +"].VideoAnnotationResult.Details");

				List<QueryAnnotationJobListResponse.QueryAnnotationJobList_AnnotationJob.QueryAnnotationJobList_VideoAnnotationResult.QueryAnnotationJobList_Annotation> videoAnnotationResult_annotations = new List<QueryAnnotationJobListResponse.QueryAnnotationJobList_AnnotationJob.QueryAnnotationJobList_VideoAnnotationResult.QueryAnnotationJobList_Annotation>();
				for (int j = 0; j < context.Length("QueryAnnotationJobList.AnnotationJobList["+ i +"].VideoAnnotationResult.Annotations.Length"); j++) {
					QueryAnnotationJobListResponse.QueryAnnotationJobList_AnnotationJob.QueryAnnotationJobList_VideoAnnotationResult.QueryAnnotationJobList_Annotation annotation = new QueryAnnotationJobListResponse.QueryAnnotationJobList_AnnotationJob.QueryAnnotationJobList_VideoAnnotationResult.QueryAnnotationJobList_Annotation();
					annotation.Label = context.StringValue("QueryAnnotationJobList.AnnotationJobList["+ i +"].VideoAnnotationResult.Annotations["+ j +"].Label");
					annotation.Score = context.StringValue("QueryAnnotationJobList.AnnotationJobList["+ i +"].VideoAnnotationResult.Annotations["+ j +"].Score");

					videoAnnotationResult_annotations.Add(annotation);
				}
				videoAnnotationResult.Annotations = videoAnnotationResult_annotations;
				annotationJob.VideoAnnotationResult = videoAnnotationResult;

				queryAnnotationJobListResponse_annotationJobList.Add(annotationJob);
			}
			queryAnnotationJobListResponse.AnnotationJobList = queryAnnotationJobListResponse_annotationJobList;
        
			return queryAnnotationJobListResponse;
        }
    }
}