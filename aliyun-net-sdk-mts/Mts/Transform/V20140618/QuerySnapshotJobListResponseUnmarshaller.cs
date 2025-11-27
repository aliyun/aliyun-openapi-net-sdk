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
    public class QuerySnapshotJobListResponseUnmarshaller
    {
        public static QuerySnapshotJobListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QuerySnapshotJobListResponse querySnapshotJobListResponse = new QuerySnapshotJobListResponse();

			querySnapshotJobListResponse.HttpResponse = _ctx.HttpResponse;
			querySnapshotJobListResponse.RequestId = _ctx.StringValue("QuerySnapshotJobList.RequestId");
			querySnapshotJobListResponse.NextPageToken = _ctx.StringValue("QuerySnapshotJobList.NextPageToken");

			List<string> querySnapshotJobListResponse_nonExistSnapshotJobIds = new List<string>();
			for (int i = 0; i < _ctx.Length("QuerySnapshotJobList.NonExistSnapshotJobIds.Length"); i++) {
				querySnapshotJobListResponse_nonExistSnapshotJobIds.Add(_ctx.StringValue("QuerySnapshotJobList.NonExistSnapshotJobIds["+ i +"]"));
			}
			querySnapshotJobListResponse.NonExistSnapshotJobIds = querySnapshotJobListResponse_nonExistSnapshotJobIds;

			List<QuerySnapshotJobListResponse.QuerySnapshotJobList_SnapshotJob> querySnapshotJobListResponse_snapshotJobList = new List<QuerySnapshotJobListResponse.QuerySnapshotJobList_SnapshotJob>();
			for (int i = 0; i < _ctx.Length("QuerySnapshotJobList.SnapshotJobList.Length"); i++) {
				QuerySnapshotJobListResponse.QuerySnapshotJobList_SnapshotJob snapshotJob = new QuerySnapshotJobListResponse.QuerySnapshotJobList_SnapshotJob();
				snapshotJob.CreationTime = _ctx.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].CreationTime");
				snapshotJob.State = _ctx.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].State");
				snapshotJob.Message = _ctx.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].Message");
				snapshotJob.Count = _ctx.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].Count");
				snapshotJob.TileCount = _ctx.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].TileCount");
				snapshotJob.UserData = _ctx.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].UserData");
				snapshotJob.Code = _ctx.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].Code");
				snapshotJob.PipelineId = _ctx.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].PipelineId");
				snapshotJob.Id = _ctx.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].Id");

				QuerySnapshotJobListResponse.QuerySnapshotJobList_SnapshotJob.QuerySnapshotJobList_SnapshotConfig snapshotConfig = new QuerySnapshotJobListResponse.QuerySnapshotJobList_SnapshotJob.QuerySnapshotJobList_SnapshotConfig();
				snapshotConfig.Time = _ctx.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].SnapshotConfig.Time");
				snapshotConfig.Interval = _ctx.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].SnapshotConfig.Interval");
				snapshotConfig.FrameType = _ctx.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].SnapshotConfig.FrameType");
				snapshotConfig.Width = _ctx.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].SnapshotConfig.Width");
				snapshotConfig.Height = _ctx.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].SnapshotConfig.Height");
				snapshotConfig.Num = _ctx.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].SnapshotConfig.Num");

				List<string> snapshotConfig_timeArray = new List<string>();
				for (int j = 0; j < _ctx.Length("QuerySnapshotJobList.SnapshotJobList["+ i +"].SnapshotConfig.TimeArray.Length"); j++) {
					snapshotConfig_timeArray.Add(_ctx.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].SnapshotConfig.TimeArray["+ j +"]"));
				}
				snapshotConfig.TimeArray = snapshotConfig_timeArray;

				QuerySnapshotJobListResponse.QuerySnapshotJobList_SnapshotJob.QuerySnapshotJobList_SnapshotConfig.QuerySnapshotJobList_TileOut tileOut = new QuerySnapshotJobListResponse.QuerySnapshotJobList_SnapshotJob.QuerySnapshotJobList_SnapshotConfig.QuerySnapshotJobList_TileOut();
				tileOut.Padding = _ctx.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].SnapshotConfig.TileOut.Padding");
				tileOut.Color = _ctx.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].SnapshotConfig.TileOut.Color");
				tileOut.CellSelStep = _ctx.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].SnapshotConfig.TileOut.CellSelStep");
				tileOut.CellHeight = _ctx.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].SnapshotConfig.TileOut.CellHeight");
				tileOut.CellWidth = _ctx.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].SnapshotConfig.TileOut.CellWidth");
				tileOut.Margin = _ctx.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].SnapshotConfig.TileOut.Margin");
				tileOut.Columns = _ctx.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].SnapshotConfig.TileOut.Columns");
				tileOut.IsKeepCellPic = _ctx.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].SnapshotConfig.TileOut.IsKeepCellPic");
				tileOut.Lines = _ctx.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].SnapshotConfig.TileOut.Lines");
				snapshotConfig.TileOut = tileOut;

				QuerySnapshotJobListResponse.QuerySnapshotJobList_SnapshotJob.QuerySnapshotJobList_SnapshotConfig.QuerySnapshotJobList_OutputFile outputFile = new QuerySnapshotJobListResponse.QuerySnapshotJobList_SnapshotJob.QuerySnapshotJobList_SnapshotConfig.QuerySnapshotJobList_OutputFile();
				outputFile.RoleArn = _ctx.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].SnapshotConfig.OutputFile.RoleArn");
				outputFile._Object = _ctx.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].SnapshotConfig.OutputFile.Object");
				outputFile.Location = _ctx.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].SnapshotConfig.OutputFile.Location");
				outputFile.Bucket = _ctx.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].SnapshotConfig.OutputFile.Bucket");
				snapshotConfig.OutputFile = outputFile;

				QuerySnapshotJobListResponse.QuerySnapshotJobList_SnapshotJob.QuerySnapshotJobList_SnapshotConfig.QuerySnapshotJobList_TileOutputFile tileOutputFile = new QuerySnapshotJobListResponse.QuerySnapshotJobList_SnapshotJob.QuerySnapshotJobList_SnapshotConfig.QuerySnapshotJobList_TileOutputFile();
				tileOutputFile.RoleArn = _ctx.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].SnapshotConfig.TileOutputFile.RoleArn");
				tileOutputFile._Object = _ctx.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].SnapshotConfig.TileOutputFile.Object");
				tileOutputFile.Location = _ctx.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].SnapshotConfig.TileOutputFile.Location");
				tileOutputFile.Bucket = _ctx.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].SnapshotConfig.TileOutputFile.Bucket");
				snapshotConfig.TileOutputFile = tileOutputFile;
				snapshotJob.SnapshotConfig = snapshotConfig;

				QuerySnapshotJobListResponse.QuerySnapshotJobList_SnapshotJob.QuerySnapshotJobList_MNSMessageResult mNSMessageResult = new QuerySnapshotJobListResponse.QuerySnapshotJobList_SnapshotJob.QuerySnapshotJobList_MNSMessageResult();
				mNSMessageResult.MessageId = _ctx.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].MNSMessageResult.MessageId");
				mNSMessageResult.ErrorMessage = _ctx.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].MNSMessageResult.ErrorMessage");
				mNSMessageResult.ErrorCode = _ctx.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].MNSMessageResult.ErrorCode");
				snapshotJob.MNSMessageResult = mNSMessageResult;

				QuerySnapshotJobListResponse.QuerySnapshotJobList_SnapshotJob.QuerySnapshotJobList_Input input = new QuerySnapshotJobListResponse.QuerySnapshotJobList_SnapshotJob.QuerySnapshotJobList_Input();
				input.RoleArn = _ctx.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].Input.RoleArn");
				input._Object = _ctx.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].Input.Object");
				input.Location = _ctx.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].Input.Location");
				input.Bucket = _ctx.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].Input.Bucket");
				snapshotJob.Input = input;

				querySnapshotJobListResponse_snapshotJobList.Add(snapshotJob);
			}
			querySnapshotJobListResponse.SnapshotJobList = querySnapshotJobListResponse_snapshotJobList;
        
			return querySnapshotJobListResponse;
        }
    }
}
