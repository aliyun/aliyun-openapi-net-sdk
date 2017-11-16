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
    public class QuerySnapshotJobListResponseUnmarshaller
    {
        public static QuerySnapshotJobListResponse Unmarshall(UnmarshallerContext context)
        {
			QuerySnapshotJobListResponse querySnapshotJobListResponse = new QuerySnapshotJobListResponse();

			querySnapshotJobListResponse.HttpResponse = context.HttpResponse;
			querySnapshotJobListResponse.RequestId = context.StringValue("QuerySnapshotJobList.RequestId");

			List<string> querySnapshotJobListResponse_nonExistSnapshotJobIds = new List<string>();
			for (int i = 0; i < context.Length("QuerySnapshotJobList.NonExistSnapshotJobIds.Length"); i++) {
				querySnapshotJobListResponse_nonExistSnapshotJobIds.Add(context.StringValue("QuerySnapshotJobList.NonExistSnapshotJobIds["+ i +"]"));
			}
			querySnapshotJobListResponse.NonExistSnapshotJobIds = querySnapshotJobListResponse_nonExistSnapshotJobIds;

			List<QuerySnapshotJobListResponse.QuerySnapshotJobList_SnapshotJob> querySnapshotJobListResponse_snapshotJobList = new List<QuerySnapshotJobListResponse.QuerySnapshotJobList_SnapshotJob>();
			for (int i = 0; i < context.Length("QuerySnapshotJobList.SnapshotJobList.Length"); i++) {
				QuerySnapshotJobListResponse.QuerySnapshotJobList_SnapshotJob snapshotJob = new QuerySnapshotJobListResponse.QuerySnapshotJobList_SnapshotJob();
				snapshotJob.Id = context.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].Id");
				snapshotJob.UserData = context.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].UserData");
				snapshotJob.PipelineId = context.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].PipelineId");
				snapshotJob.State = context.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].State");
				snapshotJob.Code = context.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].Code");
				snapshotJob.Count = context.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].Count");
				snapshotJob.TileCount = context.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].TileCount");
				snapshotJob.Message = context.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].Message");
				snapshotJob.CreationTime = context.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].CreationTime");

				QuerySnapshotJobListResponse.QuerySnapshotJobList_SnapshotJob.QuerySnapshotJobList_Input input = new QuerySnapshotJobListResponse.QuerySnapshotJobList_SnapshotJob.QuerySnapshotJobList_Input();
				input.Bucket = context.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].Input.Bucket");
				input.Location = context.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].Input.Location");
				input._Object = context.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].Input.Object");
				input.RoleArn = context.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].Input.RoleArn");
				snapshotJob.Input = input;

				QuerySnapshotJobListResponse.QuerySnapshotJobList_SnapshotJob.QuerySnapshotJobList_SnapshotConfig snapshotConfig = new QuerySnapshotJobListResponse.QuerySnapshotJobList_SnapshotJob.QuerySnapshotJobList_SnapshotConfig();
				snapshotConfig.Time = context.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].SnapshotConfig.Time");
				snapshotConfig.Interval = context.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].SnapshotConfig.Interval");
				snapshotConfig.Num = context.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].SnapshotConfig.Num");
				snapshotConfig.Width = context.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].SnapshotConfig.Width");
				snapshotConfig.Height = context.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].SnapshotConfig.Height");
				snapshotConfig.FrameType = context.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].SnapshotConfig.FrameType");

				QuerySnapshotJobListResponse.QuerySnapshotJobList_SnapshotJob.QuerySnapshotJobList_SnapshotConfig.QuerySnapshotJobList_OutputFile outputFile = new QuerySnapshotJobListResponse.QuerySnapshotJobList_SnapshotJob.QuerySnapshotJobList_SnapshotConfig.QuerySnapshotJobList_OutputFile();
				outputFile.Bucket = context.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].SnapshotConfig.OutputFile.Bucket");
				outputFile.Location = context.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].SnapshotConfig.OutputFile.Location");
				outputFile._Object = context.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].SnapshotConfig.OutputFile.Object");
				outputFile.RoleArn = context.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].SnapshotConfig.OutputFile.RoleArn");
				snapshotConfig.OutputFile = outputFile;

				QuerySnapshotJobListResponse.QuerySnapshotJobList_SnapshotJob.QuerySnapshotJobList_SnapshotConfig.QuerySnapshotJobList_TileOutputFile tileOutputFile = new QuerySnapshotJobListResponse.QuerySnapshotJobList_SnapshotJob.QuerySnapshotJobList_SnapshotConfig.QuerySnapshotJobList_TileOutputFile();
				tileOutputFile.Bucket = context.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].SnapshotConfig.TileOutputFile.Bucket");
				tileOutputFile.Location = context.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].SnapshotConfig.TileOutputFile.Location");
				tileOutputFile._Object = context.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].SnapshotConfig.TileOutputFile.Object");
				tileOutputFile.RoleArn = context.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].SnapshotConfig.TileOutputFile.RoleArn");
				snapshotConfig.TileOutputFile = tileOutputFile;

				QuerySnapshotJobListResponse.QuerySnapshotJobList_SnapshotJob.QuerySnapshotJobList_SnapshotConfig.QuerySnapshotJobList_TileOut tileOut = new QuerySnapshotJobListResponse.QuerySnapshotJobList_SnapshotJob.QuerySnapshotJobList_SnapshotConfig.QuerySnapshotJobList_TileOut();
				tileOut.Lines = context.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].SnapshotConfig.TileOut.Lines");
				tileOut.Columns = context.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].SnapshotConfig.TileOut.Columns");
				tileOut.CellWidth = context.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].SnapshotConfig.TileOut.CellWidth");
				tileOut.CellHeight = context.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].SnapshotConfig.TileOut.CellHeight");
				tileOut.Margin = context.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].SnapshotConfig.TileOut.Margin");
				tileOut.Padding = context.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].SnapshotConfig.TileOut.Padding");
				tileOut.Color = context.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].SnapshotConfig.TileOut.Color");
				tileOut.IsKeepCellPic = context.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].SnapshotConfig.TileOut.IsKeepCellPic");
				snapshotConfig.TileOut = tileOut;
				snapshotJob.SnapshotConfig = snapshotConfig;

				QuerySnapshotJobListResponse.QuerySnapshotJobList_SnapshotJob.QuerySnapshotJobList_MNSMessageResult mNSMessageResult = new QuerySnapshotJobListResponse.QuerySnapshotJobList_SnapshotJob.QuerySnapshotJobList_MNSMessageResult();
				mNSMessageResult.MessageId = context.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].MNSMessageResult.MessageId");
				mNSMessageResult.ErrorMessage = context.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].MNSMessageResult.ErrorMessage");
				mNSMessageResult.ErrorCode = context.StringValue("QuerySnapshotJobList.SnapshotJobList["+ i +"].MNSMessageResult.ErrorCode");
				snapshotJob.MNSMessageResult = mNSMessageResult;

				querySnapshotJobListResponse_snapshotJobList.Add(snapshotJob);
			}
			querySnapshotJobListResponse.SnapshotJobList = querySnapshotJobListResponse_snapshotJobList;
        
			return querySnapshotJobListResponse;
        }
    }
}