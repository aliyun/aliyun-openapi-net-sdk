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
    public class QueryFpCompareJobListResponseUnmarshaller
    {
        public static QueryFpCompareJobListResponse Unmarshall(UnmarshallerContext context)
        {
			QueryFpCompareJobListResponse queryFpCompareJobListResponse = new QueryFpCompareJobListResponse();

			queryFpCompareJobListResponse.HttpResponse = context.HttpResponse;
			queryFpCompareJobListResponse.RequestId = context.StringValue("QueryFpCompareJobList.RequestId");

			List<string> queryFpCompareJobListResponse_nonExistIds = new List<string>();
			for (int i = 0; i < context.Length("QueryFpCompareJobList.NonExistIds.Length"); i++) {
				queryFpCompareJobListResponse_nonExistIds.Add(context.StringValue("QueryFpCompareJobList.NonExistIds["+ i +"]"));
			}
			queryFpCompareJobListResponse.NonExistIds = queryFpCompareJobListResponse_nonExistIds;

			List<QueryFpCompareJobListResponse.QueryFpCompareJobList_FpCompareJob> queryFpCompareJobListResponse_fpCompareJobList = new List<QueryFpCompareJobListResponse.QueryFpCompareJobList_FpCompareJob>();
			for (int i = 0; i < context.Length("QueryFpCompareJobList.FpCompareJobList.Length"); i++) {
				QueryFpCompareJobListResponse.QueryFpCompareJobList_FpCompareJob fpCompareJob = new QueryFpCompareJobListResponse.QueryFpCompareJobList_FpCompareJob();
				fpCompareJob.Id = context.StringValue("QueryFpCompareJobList.FpCompareJobList["+ i +"].Id");
				fpCompareJob.UserData = context.StringValue("QueryFpCompareJobList.FpCompareJobList["+ i +"].UserData");
				fpCompareJob.PipelineId = context.StringValue("QueryFpCompareJobList.FpCompareJobList["+ i +"].PipelineId");
				fpCompareJob.FpDBId = context.StringValue("QueryFpCompareJobList.FpCompareJobList["+ i +"].FpDBId");
				fpCompareJob.State = context.StringValue("QueryFpCompareJobList.FpCompareJobList["+ i +"].State");
				fpCompareJob.Code = context.StringValue("QueryFpCompareJobList.FpCompareJobList["+ i +"].Code");
				fpCompareJob.Message = context.StringValue("QueryFpCompareJobList.FpCompareJobList["+ i +"].Message");
				fpCompareJob.CreationTime = context.StringValue("QueryFpCompareJobList.FpCompareJobList["+ i +"].CreationTime");
				fpCompareJob.FinishTime = context.StringValue("QueryFpCompareJobList.FpCompareJobList["+ i +"].FinishTime");

				QueryFpCompareJobListResponse.QueryFpCompareJobList_FpCompareJob.QueryFpCompareJobList_MasterFile masterFile = new QueryFpCompareJobListResponse.QueryFpCompareJobList_FpCompareJob.QueryFpCompareJobList_MasterFile();
				masterFile.Bucket = context.StringValue("QueryFpCompareJobList.FpCompareJobList["+ i +"].MasterFile.Bucket");
				masterFile.Location = context.StringValue("QueryFpCompareJobList.FpCompareJobList["+ i +"].MasterFile.Location");
				masterFile._Object = context.StringValue("QueryFpCompareJobList.FpCompareJobList["+ i +"].MasterFile.Object");
				fpCompareJob.MasterFile = masterFile;

				QueryFpCompareJobListResponse.QueryFpCompareJobList_FpCompareJob.QueryFpCompareJobList_QueryFile queryFile = new QueryFpCompareJobListResponse.QueryFpCompareJobList_FpCompareJob.QueryFpCompareJobList_QueryFile();
				queryFile.Bucket = context.StringValue("QueryFpCompareJobList.FpCompareJobList["+ i +"].QueryFile.Bucket");
				queryFile.Location = context.StringValue("QueryFpCompareJobList.FpCompareJobList["+ i +"].QueryFile.Location");
				queryFile._Object = context.StringValue("QueryFpCompareJobList.FpCompareJobList["+ i +"].QueryFile.Object");
				fpCompareJob.QueryFile = queryFile;

				QueryFpCompareJobListResponse.QueryFpCompareJobList_FpCompareJob.QueryFpCompareJobList_MatchFrameStorage matchFrameStorage = new QueryFpCompareJobListResponse.QueryFpCompareJobList_FpCompareJob.QueryFpCompareJobList_MatchFrameStorage();

				QueryFpCompareJobListResponse.QueryFpCompareJobList_FpCompareJob.QueryFpCompareJobList_MatchFrameStorage.QueryFpCompareJobList_MasterMediaFrames masterMediaFrames = new QueryFpCompareJobListResponse.QueryFpCompareJobList_FpCompareJob.QueryFpCompareJobList_MatchFrameStorage.QueryFpCompareJobList_MasterMediaFrames();
				masterMediaFrames.Bucket = context.StringValue("QueryFpCompareJobList.FpCompareJobList["+ i +"].MatchFrameStorage.MasterMediaFrames.Bucket");
				masterMediaFrames.Location = context.StringValue("QueryFpCompareJobList.FpCompareJobList["+ i +"].MatchFrameStorage.MasterMediaFrames.Location");
				masterMediaFrames._Object = context.StringValue("QueryFpCompareJobList.FpCompareJobList["+ i +"].MatchFrameStorage.MasterMediaFrames.Object");
				matchFrameStorage.MasterMediaFrames = masterMediaFrames;

				QueryFpCompareJobListResponse.QueryFpCompareJobList_FpCompareJob.QueryFpCompareJobList_MatchFrameStorage.QueryFpCompareJobList_QueryMediaFrames queryMediaFrames = new QueryFpCompareJobListResponse.QueryFpCompareJobList_FpCompareJob.QueryFpCompareJobList_MatchFrameStorage.QueryFpCompareJobList_QueryMediaFrames();
				queryMediaFrames.Bucket = context.StringValue("QueryFpCompareJobList.FpCompareJobList["+ i +"].MatchFrameStorage.QueryMediaFrames.Bucket");
				queryMediaFrames.Location = context.StringValue("QueryFpCompareJobList.FpCompareJobList["+ i +"].MatchFrameStorage.QueryMediaFrames.Location");
				queryMediaFrames._Object = context.StringValue("QueryFpCompareJobList.FpCompareJobList["+ i +"].MatchFrameStorage.QueryMediaFrames.Object");
				matchFrameStorage.QueryMediaFrames = queryMediaFrames;

				QueryFpCompareJobListResponse.QueryFpCompareJobList_FpCompareJob.QueryFpCompareJobList_MatchFrameStorage.QueryFpCompareJobList_MatchedFramesDescFile matchedFramesDescFile = new QueryFpCompareJobListResponse.QueryFpCompareJobList_FpCompareJob.QueryFpCompareJobList_MatchFrameStorage.QueryFpCompareJobList_MatchedFramesDescFile();
				matchedFramesDescFile.Bucket = context.StringValue("QueryFpCompareJobList.FpCompareJobList["+ i +"].MatchFrameStorage.MatchedFramesDescFile.Bucket");
				matchedFramesDescFile.Location = context.StringValue("QueryFpCompareJobList.FpCompareJobList["+ i +"].MatchFrameStorage.MatchedFramesDescFile.Location");
				matchedFramesDescFile._Object = context.StringValue("QueryFpCompareJobList.FpCompareJobList["+ i +"].MatchFrameStorage.MatchedFramesDescFile.Object");
				matchFrameStorage.MatchedFramesDescFile = matchedFramesDescFile;
				fpCompareJob.MatchFrameStorage = matchFrameStorage;

				QueryFpCompareJobListResponse.QueryFpCompareJobList_FpCompareJob.QueryFpCompareJobList_FpCompareResult fpCompareResult = new QueryFpCompareJobListResponse.QueryFpCompareJobList_FpCompareJob.QueryFpCompareJobList_FpCompareResult();

				QueryFpCompareJobListResponse.QueryFpCompareJobList_FpCompareJob.QueryFpCompareJobList_FpCompareResult.QueryFpCompareJobList_MasterMediaInfo masterMediaInfo = new QueryFpCompareJobListResponse.QueryFpCompareJobList_FpCompareJob.QueryFpCompareJobList_FpCompareResult.QueryFpCompareJobList_MasterMediaInfo();
				masterMediaInfo.Duration = context.StringValue("QueryFpCompareJobList.FpCompareJobList["+ i +"].FpCompareResult.MasterMediaInfo.Duration");
				masterMediaInfo.FpNum = context.StringValue("QueryFpCompareJobList.FpCompareJobList["+ i +"].FpCompareResult.MasterMediaInfo.FpNum");
				masterMediaInfo.Width = context.StringValue("QueryFpCompareJobList.FpCompareJobList["+ i +"].FpCompareResult.MasterMediaInfo.Width");
				masterMediaInfo.Height = context.StringValue("QueryFpCompareJobList.FpCompareJobList["+ i +"].FpCompareResult.MasterMediaInfo.Height");
				masterMediaInfo.Fps = context.StringValue("QueryFpCompareJobList.FpCompareJobList["+ i +"].FpCompareResult.MasterMediaInfo.Fps");
				masterMediaInfo.TotalVideoFrame = context.StringValue("QueryFpCompareJobList.FpCompareJobList["+ i +"].FpCompareResult.MasterMediaInfo.TotalVideoFrame");
				masterMediaInfo.AudioBitRate = context.StringValue("QueryFpCompareJobList.FpCompareJobList["+ i +"].FpCompareResult.MasterMediaInfo.AudioBitRate");
				masterMediaInfo.AudioChannels = context.StringValue("QueryFpCompareJobList.FpCompareJobList["+ i +"].FpCompareResult.MasterMediaInfo.AudioChannels");
				masterMediaInfo.AudioSampleRate = context.StringValue("QueryFpCompareJobList.FpCompareJobList["+ i +"].FpCompareResult.MasterMediaInfo.AudioSampleRate");
				fpCompareResult.MasterMediaInfo = masterMediaInfo;

				QueryFpCompareJobListResponse.QueryFpCompareJobList_FpCompareJob.QueryFpCompareJobList_FpCompareResult.QueryFpCompareJobList_QueryMediaInfo queryMediaInfo = new QueryFpCompareJobListResponse.QueryFpCompareJobList_FpCompareJob.QueryFpCompareJobList_FpCompareResult.QueryFpCompareJobList_QueryMediaInfo();
				queryMediaInfo.Duration = context.StringValue("QueryFpCompareJobList.FpCompareJobList["+ i +"].FpCompareResult.QueryMediaInfo.Duration");
				queryMediaInfo.FpNum = context.StringValue("QueryFpCompareJobList.FpCompareJobList["+ i +"].FpCompareResult.QueryMediaInfo.FpNum");
				queryMediaInfo.Width = context.StringValue("QueryFpCompareJobList.FpCompareJobList["+ i +"].FpCompareResult.QueryMediaInfo.Width");
				queryMediaInfo.Height = context.StringValue("QueryFpCompareJobList.FpCompareJobList["+ i +"].FpCompareResult.QueryMediaInfo.Height");
				queryMediaInfo.Fps = context.StringValue("QueryFpCompareJobList.FpCompareJobList["+ i +"].FpCompareResult.QueryMediaInfo.Fps");
				queryMediaInfo.TotalVideoFrame = context.StringValue("QueryFpCompareJobList.FpCompareJobList["+ i +"].FpCompareResult.QueryMediaInfo.TotalVideoFrame");
				queryMediaInfo.AudioBitRate = context.StringValue("QueryFpCompareJobList.FpCompareJobList["+ i +"].FpCompareResult.QueryMediaInfo.AudioBitRate");
				queryMediaInfo.AudioChannels = context.StringValue("QueryFpCompareJobList.FpCompareJobList["+ i +"].FpCompareResult.QueryMediaInfo.AudioChannels");
				queryMediaInfo.AudioSampleRate = context.StringValue("QueryFpCompareJobList.FpCompareJobList["+ i +"].FpCompareResult.QueryMediaInfo.AudioSampleRate");
				fpCompareResult.QueryMediaInfo = queryMediaInfo;

				List<QueryFpCompareJobListResponse.QueryFpCompareJobList_FpCompareJob.QueryFpCompareJobList_FpCompareResult.QueryFpCompareJobList_MediaMatchSegment> fpCompareResult_mediaMatchSegments = new List<QueryFpCompareJobListResponse.QueryFpCompareJobList_FpCompareJob.QueryFpCompareJobList_FpCompareResult.QueryFpCompareJobList_MediaMatchSegment>();
				for (int j = 0; j < context.Length("QueryFpCompareJobList.FpCompareJobList["+ i +"].FpCompareResult.MediaMatchSegments.Length"); j++) {
					QueryFpCompareJobListResponse.QueryFpCompareJobList_FpCompareJob.QueryFpCompareJobList_FpCompareResult.QueryFpCompareJobList_MediaMatchSegment mediaMatchSegment = new QueryFpCompareJobListResponse.QueryFpCompareJobList_FpCompareJob.QueryFpCompareJobList_FpCompareResult.QueryFpCompareJobList_MediaMatchSegment();
					mediaMatchSegment.QueryStartFrame = context.StringValue("QueryFpCompareJobList.FpCompareJobList["+ i +"].FpCompareResult.MediaMatchSegments["+ j +"].QueryStartFrame");
					mediaMatchSegment.QueryEndFrame = context.StringValue("QueryFpCompareJobList.FpCompareJobList["+ i +"].FpCompareResult.MediaMatchSegments["+ j +"].QueryEndFrame");
					mediaMatchSegment.MasterStartFrame = context.StringValue("QueryFpCompareJobList.FpCompareJobList["+ i +"].FpCompareResult.MediaMatchSegments["+ j +"].MasterStartFrame");
					mediaMatchSegment.MasterEndFrame = context.StringValue("QueryFpCompareJobList.FpCompareJobList["+ i +"].FpCompareResult.MediaMatchSegments["+ j +"].MasterEndFrame");
					mediaMatchSegment.QueryStartTime = context.StringValue("QueryFpCompareJobList.FpCompareJobList["+ i +"].FpCompareResult.MediaMatchSegments["+ j +"].QueryStartTime");
					mediaMatchSegment.QueryEndTime = context.StringValue("QueryFpCompareJobList.FpCompareJobList["+ i +"].FpCompareResult.MediaMatchSegments["+ j +"].QueryEndTime");
					mediaMatchSegment.MasterStartTime = context.StringValue("QueryFpCompareJobList.FpCompareJobList["+ i +"].FpCompareResult.MediaMatchSegments["+ j +"].MasterStartTime");
					mediaMatchSegment.MasterEndTime = context.StringValue("QueryFpCompareJobList.FpCompareJobList["+ i +"].FpCompareResult.MediaMatchSegments["+ j +"].MasterEndTime");
					mediaMatchSegment.TotalMatchFrameNum = context.StringValue("QueryFpCompareJobList.FpCompareJobList["+ i +"].FpCompareResult.MediaMatchSegments["+ j +"].TotalMatchFrameNum");
					mediaMatchSegment.Score = context.StringValue("QueryFpCompareJobList.FpCompareJobList["+ i +"].FpCompareResult.MediaMatchSegments["+ j +"].Score");

					fpCompareResult_mediaMatchSegments.Add(mediaMatchSegment);
				}
				fpCompareResult.MediaMatchSegments = fpCompareResult_mediaMatchSegments;
				fpCompareJob.FpCompareResult = fpCompareResult;

				queryFpCompareJobListResponse_fpCompareJobList.Add(fpCompareJob);
			}
			queryFpCompareJobListResponse.FpCompareJobList = queryFpCompareJobListResponse_fpCompareJobList;
        
			return queryFpCompareJobListResponse;
        }
    }
}
