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
    public class QueryFacerecogJobListResponseUnmarshaller
    {
        public static QueryFacerecogJobListResponse Unmarshall(UnmarshallerContext context)
        {
			QueryFacerecogJobListResponse queryFacerecogJobListResponse = new QueryFacerecogJobListResponse();

			queryFacerecogJobListResponse.HttpResponse = context.HttpResponse;
			queryFacerecogJobListResponse.RequestId = context.StringValue("QueryFacerecogJobList.RequestId");

			List<string> queryFacerecogJobListResponse_nonExistIds = new List<string>();
			for (int i = 0; i < context.Length("QueryFacerecogJobList.NonExistIds.Length"); i++) {
				queryFacerecogJobListResponse_nonExistIds.Add(context.StringValue("QueryFacerecogJobList.NonExistIds["+ i +"]"));
			}
			queryFacerecogJobListResponse.NonExistIds = queryFacerecogJobListResponse_nonExistIds;

			List<QueryFacerecogJobListResponse.QueryFacerecogJobList_FacerecogJob> queryFacerecogJobListResponse_facerecogJobList = new List<QueryFacerecogJobListResponse.QueryFacerecogJobList_FacerecogJob>();
			for (int i = 0; i < context.Length("QueryFacerecogJobList.FacerecogJobList.Length"); i++) {
				QueryFacerecogJobListResponse.QueryFacerecogJobList_FacerecogJob facerecogJob = new QueryFacerecogJobListResponse.QueryFacerecogJobList_FacerecogJob();
				facerecogJob.Id = context.StringValue("QueryFacerecogJobList.FacerecogJobList["+ i +"].Id");
				facerecogJob.UserData = context.StringValue("QueryFacerecogJobList.FacerecogJobList["+ i +"].UserData");
				facerecogJob.PipelineId = context.StringValue("QueryFacerecogJobList.FacerecogJobList["+ i +"].PipelineId");
				facerecogJob.State = context.StringValue("QueryFacerecogJobList.FacerecogJobList["+ i +"].State");
				facerecogJob.Code = context.StringValue("QueryFacerecogJobList.FacerecogJobList["+ i +"].Code");
				facerecogJob.Message = context.StringValue("QueryFacerecogJobList.FacerecogJobList["+ i +"].Message");
				facerecogJob.CreationTime = context.StringValue("QueryFacerecogJobList.FacerecogJobList["+ i +"].CreationTime");

				QueryFacerecogJobListResponse.QueryFacerecogJobList_FacerecogJob.QueryFacerecogJobList_Input input = new QueryFacerecogJobListResponse.QueryFacerecogJobList_FacerecogJob.QueryFacerecogJobList_Input();
				input.Bucket = context.StringValue("QueryFacerecogJobList.FacerecogJobList["+ i +"].Input.Bucket");
				input.Location = context.StringValue("QueryFacerecogJobList.FacerecogJobList["+ i +"].Input.Location");
				input._Object = context.StringValue("QueryFacerecogJobList.FacerecogJobList["+ i +"].Input.Object");
				facerecogJob.Input = input;

				QueryFacerecogJobListResponse.QueryFacerecogJobList_FacerecogJob.QueryFacerecogJobList_VideoFacerecogResult videoFacerecogResult = new QueryFacerecogJobListResponse.QueryFacerecogJobList_FacerecogJob.QueryFacerecogJobList_VideoFacerecogResult();

				List<QueryFacerecogJobListResponse.QueryFacerecogJobList_FacerecogJob.QueryFacerecogJobList_VideoFacerecogResult.QueryFacerecogJobList_Facerecog> videoFacerecogResult_facerecogs = new List<QueryFacerecogJobListResponse.QueryFacerecogJobList_FacerecogJob.QueryFacerecogJobList_VideoFacerecogResult.QueryFacerecogJobList_Facerecog>();
				for (int j = 0; j < context.Length("QueryFacerecogJobList.FacerecogJobList["+ i +"].VideoFacerecogResult.Facerecogs.Length"); j++) {
					QueryFacerecogJobListResponse.QueryFacerecogJobList_FacerecogJob.QueryFacerecogJobList_VideoFacerecogResult.QueryFacerecogJobList_Facerecog facerecog = new QueryFacerecogJobListResponse.QueryFacerecogJobList_FacerecogJob.QueryFacerecogJobList_VideoFacerecogResult.QueryFacerecogJobList_Facerecog();
					facerecog.Time = context.StringValue("QueryFacerecogJobList.FacerecogJobList["+ i +"].VideoFacerecogResult.Facerecogs["+ j +"].Time");

					List<QueryFacerecogJobListResponse.QueryFacerecogJobList_FacerecogJob.QueryFacerecogJobList_VideoFacerecogResult.QueryFacerecogJobList_Facerecog.QueryFacerecogJobList_Face> facerecog_faces = new List<QueryFacerecogJobListResponse.QueryFacerecogJobList_FacerecogJob.QueryFacerecogJobList_VideoFacerecogResult.QueryFacerecogJobList_Facerecog.QueryFacerecogJobList_Face>();
					for (int k = 0; k < context.Length("QueryFacerecogJobList.FacerecogJobList["+ i +"].VideoFacerecogResult.Facerecogs["+ j +"].Faces.Length"); k++) {
						QueryFacerecogJobListResponse.QueryFacerecogJobList_FacerecogJob.QueryFacerecogJobList_VideoFacerecogResult.QueryFacerecogJobList_Facerecog.QueryFacerecogJobList_Face face = new QueryFacerecogJobListResponse.QueryFacerecogJobList_FacerecogJob.QueryFacerecogJobList_VideoFacerecogResult.QueryFacerecogJobList_Facerecog.QueryFacerecogJobList_Face();
						face.Name = context.StringValue("QueryFacerecogJobList.FacerecogJobList["+ i +"].VideoFacerecogResult.Facerecogs["+ j +"].Faces["+ k +"].Name");
						face.Score = context.StringValue("QueryFacerecogJobList.FacerecogJobList["+ i +"].VideoFacerecogResult.Facerecogs["+ j +"].Faces["+ k +"].Score");
						face.Target = context.StringValue("QueryFacerecogJobList.FacerecogJobList["+ i +"].VideoFacerecogResult.Facerecogs["+ j +"].Faces["+ k +"].Target");

						facerecog_faces.Add(face);
					}
					facerecog.Faces = facerecog_faces;

					videoFacerecogResult_facerecogs.Add(facerecog);
				}
				videoFacerecogResult.Facerecogs = videoFacerecogResult_facerecogs;
				facerecogJob.VideoFacerecogResult = videoFacerecogResult;

				queryFacerecogJobListResponse_facerecogJobList.Add(facerecogJob);
			}
			queryFacerecogJobListResponse.FacerecogJobList = queryFacerecogJobListResponse_facerecogJobList;
        
			return queryFacerecogJobListResponse;
        }
    }
}