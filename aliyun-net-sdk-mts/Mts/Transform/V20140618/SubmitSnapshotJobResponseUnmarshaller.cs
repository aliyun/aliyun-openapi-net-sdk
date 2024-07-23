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
    public class SubmitSnapshotJobResponseUnmarshaller
    {
        public static SubmitSnapshotJobResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SubmitSnapshotJobResponse submitSnapshotJobResponse = new SubmitSnapshotJobResponse();

			submitSnapshotJobResponse.HttpResponse = _ctx.HttpResponse;
			submitSnapshotJobResponse.RequestId = _ctx.StringValue("SubmitSnapshotJob.RequestId");

			SubmitSnapshotJobResponse.SubmitSnapshotJob_SnapshotJob snapshotJob = new SubmitSnapshotJobResponse.SubmitSnapshotJob_SnapshotJob();
			snapshotJob.CreationTime = _ctx.StringValue("SubmitSnapshotJob.SnapshotJob.CreationTime");
			snapshotJob.State = _ctx.StringValue("SubmitSnapshotJob.SnapshotJob.State");
			snapshotJob.Message = _ctx.StringValue("SubmitSnapshotJob.SnapshotJob.Message");
			snapshotJob.Count = _ctx.StringValue("SubmitSnapshotJob.SnapshotJob.Count");
			snapshotJob.TileCount = _ctx.StringValue("SubmitSnapshotJob.SnapshotJob.TileCount");
			snapshotJob.UserData = _ctx.StringValue("SubmitSnapshotJob.SnapshotJob.UserData");
			snapshotJob.Code = _ctx.StringValue("SubmitSnapshotJob.SnapshotJob.Code");
			snapshotJob.PipelineId = _ctx.StringValue("SubmitSnapshotJob.SnapshotJob.PipelineId");
			snapshotJob.Id = _ctx.StringValue("SubmitSnapshotJob.SnapshotJob.Id");

			SubmitSnapshotJobResponse.SubmitSnapshotJob_SnapshotJob.SubmitSnapshotJob_SnapshotConfig snapshotConfig = new SubmitSnapshotJobResponse.SubmitSnapshotJob_SnapshotJob.SubmitSnapshotJob_SnapshotConfig();
			snapshotConfig.Time = _ctx.StringValue("SubmitSnapshotJob.SnapshotJob.SnapshotConfig.Time");
			snapshotConfig.Interval = _ctx.StringValue("SubmitSnapshotJob.SnapshotJob.SnapshotConfig.Interval");
			snapshotConfig.FrameType = _ctx.StringValue("SubmitSnapshotJob.SnapshotJob.SnapshotConfig.FrameType");
			snapshotConfig.Width = _ctx.StringValue("SubmitSnapshotJob.SnapshotJob.SnapshotConfig.Width");
			snapshotConfig.Height = _ctx.StringValue("SubmitSnapshotJob.SnapshotJob.SnapshotConfig.Height");
			snapshotConfig.Num = _ctx.StringValue("SubmitSnapshotJob.SnapshotJob.SnapshotConfig.Num");

			List<string> snapshotConfig_timeArray = new List<string>();
			for (int i = 0; i < _ctx.Length("SubmitSnapshotJob.SnapshotJob.SnapshotConfig.TimeArray.Length"); i++) {
				snapshotConfig_timeArray.Add(_ctx.StringValue("SubmitSnapshotJob.SnapshotJob.SnapshotConfig.TimeArray["+ i +"]"));
			}
			snapshotConfig.TimeArray = snapshotConfig_timeArray;

			SubmitSnapshotJobResponse.SubmitSnapshotJob_SnapshotJob.SubmitSnapshotJob_SnapshotConfig.SubmitSnapshotJob_TileOut tileOut = new SubmitSnapshotJobResponse.SubmitSnapshotJob_SnapshotJob.SubmitSnapshotJob_SnapshotConfig.SubmitSnapshotJob_TileOut();
			tileOut.Padding = _ctx.StringValue("SubmitSnapshotJob.SnapshotJob.SnapshotConfig.TileOut.Padding");
			tileOut.Color = _ctx.StringValue("SubmitSnapshotJob.SnapshotJob.SnapshotConfig.TileOut.Color");
			tileOut.CellSelStep = _ctx.StringValue("SubmitSnapshotJob.SnapshotJob.SnapshotConfig.TileOut.CellSelStep");
			tileOut.CellHeight = _ctx.StringValue("SubmitSnapshotJob.SnapshotJob.SnapshotConfig.TileOut.CellHeight");
			tileOut.CellWidth = _ctx.StringValue("SubmitSnapshotJob.SnapshotJob.SnapshotConfig.TileOut.CellWidth");
			tileOut.Margin = _ctx.StringValue("SubmitSnapshotJob.SnapshotJob.SnapshotConfig.TileOut.Margin");
			tileOut.Columns = _ctx.StringValue("SubmitSnapshotJob.SnapshotJob.SnapshotConfig.TileOut.Columns");
			tileOut.IsKeepCellPic = _ctx.StringValue("SubmitSnapshotJob.SnapshotJob.SnapshotConfig.TileOut.IsKeepCellPic");
			tileOut.Lines = _ctx.StringValue("SubmitSnapshotJob.SnapshotJob.SnapshotConfig.TileOut.Lines");
			snapshotConfig.TileOut = tileOut;

			SubmitSnapshotJobResponse.SubmitSnapshotJob_SnapshotJob.SubmitSnapshotJob_SnapshotConfig.SubmitSnapshotJob_OutputFile outputFile = new SubmitSnapshotJobResponse.SubmitSnapshotJob_SnapshotJob.SubmitSnapshotJob_SnapshotConfig.SubmitSnapshotJob_OutputFile();
			outputFile.RoleArn = _ctx.StringValue("SubmitSnapshotJob.SnapshotJob.SnapshotConfig.OutputFile.RoleArn");
			outputFile._Object = _ctx.StringValue("SubmitSnapshotJob.SnapshotJob.SnapshotConfig.OutputFile.Object");
			outputFile.Location = _ctx.StringValue("SubmitSnapshotJob.SnapshotJob.SnapshotConfig.OutputFile.Location");
			outputFile.Bucket = _ctx.StringValue("SubmitSnapshotJob.SnapshotJob.SnapshotConfig.OutputFile.Bucket");
			snapshotConfig.OutputFile = outputFile;

			SubmitSnapshotJobResponse.SubmitSnapshotJob_SnapshotJob.SubmitSnapshotJob_SnapshotConfig.SubmitSnapshotJob_TileOutputFile tileOutputFile = new SubmitSnapshotJobResponse.SubmitSnapshotJob_SnapshotJob.SubmitSnapshotJob_SnapshotConfig.SubmitSnapshotJob_TileOutputFile();
			tileOutputFile.RoleArn = _ctx.StringValue("SubmitSnapshotJob.SnapshotJob.SnapshotConfig.TileOutputFile.RoleArn");
			tileOutputFile._Object = _ctx.StringValue("SubmitSnapshotJob.SnapshotJob.SnapshotConfig.TileOutputFile.Object");
			tileOutputFile.Location = _ctx.StringValue("SubmitSnapshotJob.SnapshotJob.SnapshotConfig.TileOutputFile.Location");
			tileOutputFile.Bucket = _ctx.StringValue("SubmitSnapshotJob.SnapshotJob.SnapshotConfig.TileOutputFile.Bucket");
			snapshotConfig.TileOutputFile = tileOutputFile;
			snapshotJob.SnapshotConfig = snapshotConfig;

			SubmitSnapshotJobResponse.SubmitSnapshotJob_SnapshotJob.SubmitSnapshotJob_MNSMessageResult mNSMessageResult = new SubmitSnapshotJobResponse.SubmitSnapshotJob_SnapshotJob.SubmitSnapshotJob_MNSMessageResult();
			mNSMessageResult.MessageId = _ctx.StringValue("SubmitSnapshotJob.SnapshotJob.MNSMessageResult.MessageId");
			mNSMessageResult.ErrorMessage = _ctx.StringValue("SubmitSnapshotJob.SnapshotJob.MNSMessageResult.ErrorMessage");
			mNSMessageResult.ErrorCode = _ctx.StringValue("SubmitSnapshotJob.SnapshotJob.MNSMessageResult.ErrorCode");
			snapshotJob.MNSMessageResult = mNSMessageResult;

			SubmitSnapshotJobResponse.SubmitSnapshotJob_SnapshotJob.SubmitSnapshotJob_Input input = new SubmitSnapshotJobResponse.SubmitSnapshotJob_SnapshotJob.SubmitSnapshotJob_Input();
			input.RoleArn = _ctx.StringValue("SubmitSnapshotJob.SnapshotJob.Input.RoleArn");
			input._Object = _ctx.StringValue("SubmitSnapshotJob.SnapshotJob.Input.Object");
			input.Location = _ctx.StringValue("SubmitSnapshotJob.SnapshotJob.Input.Location");
			input.Bucket = _ctx.StringValue("SubmitSnapshotJob.SnapshotJob.Input.Bucket");
			snapshotJob.Input = input;
			submitSnapshotJobResponse.SnapshotJob = snapshotJob;
        
			return submitSnapshotJobResponse;
        }
    }
}
