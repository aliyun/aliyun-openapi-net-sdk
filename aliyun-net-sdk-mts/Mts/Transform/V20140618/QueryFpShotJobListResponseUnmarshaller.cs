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
    public class QueryFpShotJobListResponseUnmarshaller
    {
        public static QueryFpShotJobListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryFpShotJobListResponse queryFpShotJobListResponse = new QueryFpShotJobListResponse();

			queryFpShotJobListResponse.HttpResponse = _ctx.HttpResponse;
			queryFpShotJobListResponse.RequestId = _ctx.StringValue("QueryFpShotJobList.RequestId");
			queryFpShotJobListResponse.NextPageToken = _ctx.StringValue("QueryFpShotJobList.NextPageToken");

			List<string> queryFpShotJobListResponse_nonExistPrimaryKeys = new List<string>();
			for (int i = 0; i < _ctx.Length("QueryFpShotJobList.NonExistPrimaryKeys.Length"); i++) {
				queryFpShotJobListResponse_nonExistPrimaryKeys.Add(_ctx.StringValue("QueryFpShotJobList.NonExistPrimaryKeys["+ i +"]"));
			}
			queryFpShotJobListResponse.NonExistPrimaryKeys = queryFpShotJobListResponse_nonExistPrimaryKeys;

			List<string> queryFpShotJobListResponse_nonExistIds = new List<string>();
			for (int i = 0; i < _ctx.Length("QueryFpShotJobList.NonExistIds.Length"); i++) {
				queryFpShotJobListResponse_nonExistIds.Add(_ctx.StringValue("QueryFpShotJobList.NonExistIds["+ i +"]"));
			}
			queryFpShotJobListResponse.NonExistIds = queryFpShotJobListResponse_nonExistIds;

			List<QueryFpShotJobListResponse.QueryFpShotJobList_FpShotJob> queryFpShotJobListResponse_fpShotJobList = new List<QueryFpShotJobListResponse.QueryFpShotJobList_FpShotJob>();
			for (int i = 0; i < _ctx.Length("QueryFpShotJobList.FpShotJobList.Length"); i++) {
				QueryFpShotJobListResponse.QueryFpShotJobList_FpShotJob fpShotJob = new QueryFpShotJobListResponse.QueryFpShotJobList_FpShotJob();
				fpShotJob.CreationTime = _ctx.StringValue("QueryFpShotJobList.FpShotJobList["+ i +"].CreationTime");
				fpShotJob.FinishTime = _ctx.StringValue("QueryFpShotJobList.FpShotJobList["+ i +"].FinishTime");
				fpShotJob.State = _ctx.StringValue("QueryFpShotJobList.FpShotJobList["+ i +"].State");
				fpShotJob.Message = _ctx.StringValue("QueryFpShotJobList.FpShotJobList["+ i +"].Message");
				fpShotJob.TxHash = _ctx.StringValue("QueryFpShotJobList.FpShotJobList["+ i +"].TxHash");
				fpShotJob.TransactionId = _ctx.StringValue("QueryFpShotJobList.FpShotJobList["+ i +"].TransactionId");
				fpShotJob.FileId = _ctx.StringValue("QueryFpShotJobList.FpShotJobList["+ i +"].FileId");
				fpShotJob.UserData = _ctx.StringValue("QueryFpShotJobList.FpShotJobList["+ i +"].UserData");
				fpShotJob.Duration = _ctx.IntegerValue("QueryFpShotJobList.FpShotJobList["+ i +"].Duration");
				fpShotJob.Code = _ctx.StringValue("QueryFpShotJobList.FpShotJobList["+ i +"].Code");
				fpShotJob.PipelineId = _ctx.StringValue("QueryFpShotJobList.FpShotJobList["+ i +"].PipelineId");
				fpShotJob.Id = _ctx.StringValue("QueryFpShotJobList.FpShotJobList["+ i +"].Id");
				fpShotJob.Input = _ctx.StringValue("QueryFpShotJobList.FpShotJobList["+ i +"].Input");

				QueryFpShotJobListResponse.QueryFpShotJobList_FpShotJob.QueryFpShotJobList_FpShotResult fpShotResult = new QueryFpShotJobListResponse.QueryFpShotJobList_FpShotJob.QueryFpShotJobList_FpShotResult();

				List<QueryFpShotJobListResponse.QueryFpShotJobList_FpShotJob.QueryFpShotJobList_FpShotResult.QueryFpShotJobList_FpShot> fpShotResult_audioFpShots = new List<QueryFpShotJobListResponse.QueryFpShotJobList_FpShotJob.QueryFpShotJobList_FpShotResult.QueryFpShotJobList_FpShot>();
				for (int j = 0; j < _ctx.Length("QueryFpShotJobList.FpShotJobList["+ i +"].FpShotResult.AudioFpShots.Length"); j++) {
					QueryFpShotJobListResponse.QueryFpShotJobList_FpShotJob.QueryFpShotJobList_FpShotResult.QueryFpShotJobList_FpShot fpShot = new QueryFpShotJobListResponse.QueryFpShotJobList_FpShotJob.QueryFpShotJobList_FpShotResult.QueryFpShotJobList_FpShot();
					fpShot.PrimaryKey = _ctx.StringValue("QueryFpShotJobList.FpShotJobList["+ i +"].FpShotResult.AudioFpShots["+ j +"].PrimaryKey");
					fpShot.Similarity = _ctx.StringValue("QueryFpShotJobList.FpShotJobList["+ i +"].FpShotResult.AudioFpShots["+ j +"].Similarity");

					List<QueryFpShotJobListResponse.QueryFpShotJobList_FpShotJob.QueryFpShotJobList_FpShotResult.QueryFpShotJobList_FpShot.QueryFpShotJobList_FpShotSlice> fpShot_fpShotSlices = new List<QueryFpShotJobListResponse.QueryFpShotJobList_FpShotJob.QueryFpShotJobList_FpShotResult.QueryFpShotJobList_FpShot.QueryFpShotJobList_FpShotSlice>();
					for (int k = 0; k < _ctx.Length("QueryFpShotJobList.FpShotJobList["+ i +"].FpShotResult.AudioFpShots["+ j +"].FpShotSlices.Length"); k++) {
						QueryFpShotJobListResponse.QueryFpShotJobList_FpShotJob.QueryFpShotJobList_FpShotResult.QueryFpShotJobList_FpShot.QueryFpShotJobList_FpShotSlice fpShotSlice = new QueryFpShotJobListResponse.QueryFpShotJobList_FpShotJob.QueryFpShotJobList_FpShotResult.QueryFpShotJobList_FpShot.QueryFpShotJobList_FpShotSlice();
						fpShotSlice.Similarity = _ctx.StringValue("QueryFpShotJobList.FpShotJobList["+ i +"].FpShotResult.AudioFpShots["+ j +"].FpShotSlices["+ k +"].Similarity");

						QueryFpShotJobListResponse.QueryFpShotJobList_FpShotJob.QueryFpShotJobList_FpShotResult.QueryFpShotJobList_FpShot.QueryFpShotJobList_FpShotSlice.QueryFpShotJobList_Duplication duplication = new QueryFpShotJobListResponse.QueryFpShotJobList_FpShotJob.QueryFpShotJobList_FpShotResult.QueryFpShotJobList_FpShot.QueryFpShotJobList_FpShotSlice.QueryFpShotJobList_Duplication();
						duplication.Start = _ctx.StringValue("QueryFpShotJobList.FpShotJobList["+ i +"].FpShotResult.AudioFpShots["+ j +"].FpShotSlices["+ k +"].Duplication.Start");
						duplication.Duration = _ctx.StringValue("QueryFpShotJobList.FpShotJobList["+ i +"].FpShotResult.AudioFpShots["+ j +"].FpShotSlices["+ k +"].Duplication.Duration");
						fpShotSlice.Duplication = duplication;

						QueryFpShotJobListResponse.QueryFpShotJobList_FpShotJob.QueryFpShotJobList_FpShotResult.QueryFpShotJobList_FpShot.QueryFpShotJobList_FpShotSlice.QueryFpShotJobList_Input input = new QueryFpShotJobListResponse.QueryFpShotJobList_FpShotJob.QueryFpShotJobList_FpShotResult.QueryFpShotJobList_FpShot.QueryFpShotJobList_FpShotSlice.QueryFpShotJobList_Input();
						input.Start = _ctx.StringValue("QueryFpShotJobList.FpShotJobList["+ i +"].FpShotResult.AudioFpShots["+ j +"].FpShotSlices["+ k +"].Input.Start");
						input.Duration = _ctx.StringValue("QueryFpShotJobList.FpShotJobList["+ i +"].FpShotResult.AudioFpShots["+ j +"].FpShotSlices["+ k +"].Input.Duration");
						fpShotSlice.Input = input;

						fpShot_fpShotSlices.Add(fpShotSlice);
					}
					fpShot.FpShotSlices = fpShot_fpShotSlices;

					fpShotResult_audioFpShots.Add(fpShot);
				}
				fpShotResult.AudioFpShots = fpShotResult_audioFpShots;

				List<QueryFpShotJobListResponse.QueryFpShotJobList_FpShotJob.QueryFpShotJobList_FpShotResult.QueryFpShotJobList_FpShot> fpShotResult_fpShots = new List<QueryFpShotJobListResponse.QueryFpShotJobList_FpShotJob.QueryFpShotJobList_FpShotResult.QueryFpShotJobList_FpShot>();
				for (int j = 0; j < _ctx.Length("QueryFpShotJobList.FpShotJobList["+ i +"].FpShotResult.FpShots.Length"); j++) {
					QueryFpShotJobListResponse.QueryFpShotJobList_FpShotJob.QueryFpShotJobList_FpShotResult.QueryFpShotJobList_FpShot fpShot = new QueryFpShotJobListResponse.QueryFpShotJobList_FpShotJob.QueryFpShotJobList_FpShotResult.QueryFpShotJobList_FpShot();
					fpShot.PrimaryKey = _ctx.StringValue("QueryFpShotJobList.FpShotJobList["+ i +"].FpShotResult.FpShots["+ j +"].PrimaryKey");
					fpShot.Similarity = _ctx.StringValue("QueryFpShotJobList.FpShotJobList["+ i +"].FpShotResult.FpShots["+ j +"].Similarity");

					List<QueryFpShotJobListResponse.QueryFpShotJobList_FpShotJob.QueryFpShotJobList_FpShotResult.QueryFpShotJobList_FpShot.QueryFpShotJobList_FpShotSlice> fpShot_fpShotSlices = new List<QueryFpShotJobListResponse.QueryFpShotJobList_FpShotJob.QueryFpShotJobList_FpShotResult.QueryFpShotJobList_FpShot.QueryFpShotJobList_FpShotSlice>();
					for (int k = 0; k < _ctx.Length("QueryFpShotJobList.FpShotJobList["+ i +"].FpShotResult.FpShots["+ j +"].FpShotSlices.Length"); k++) {
						QueryFpShotJobListResponse.QueryFpShotJobList_FpShotJob.QueryFpShotJobList_FpShotResult.QueryFpShotJobList_FpShot.QueryFpShotJobList_FpShotSlice fpShotSlice = new QueryFpShotJobListResponse.QueryFpShotJobList_FpShotJob.QueryFpShotJobList_FpShotResult.QueryFpShotJobList_FpShot.QueryFpShotJobList_FpShotSlice();
						fpShotSlice.Similarity = _ctx.StringValue("QueryFpShotJobList.FpShotJobList["+ i +"].FpShotResult.FpShots["+ j +"].FpShotSlices["+ k +"].Similarity");

						QueryFpShotJobListResponse.QueryFpShotJobList_FpShotJob.QueryFpShotJobList_FpShotResult.QueryFpShotJobList_FpShot.QueryFpShotJobList_FpShotSlice.QueryFpShotJobList_Duplication queryFpShotJobList_FpShotSliceQueryFpShotJobList_Duplication = new QueryFpShotJobListResponse.QueryFpShotJobList_FpShotJob.QueryFpShotJobList_FpShotResult.QueryFpShotJobList_FpShot.QueryFpShotJobList_FpShotSlice.QueryFpShotJobList_Duplication();
						queryFpShotJobList_FpShotSliceQueryFpShotJobList_Duplication.Start = _ctx.StringValue("QueryFpShotJobList.FpShotJobList["+ i +"].FpShotResult.FpShots["+ j +"].FpShotSlices["+ k +"].Duplication.Start");
						queryFpShotJobList_FpShotSliceQueryFpShotJobList_Duplication.Duration = _ctx.StringValue("QueryFpShotJobList.FpShotJobList["+ i +"].FpShotResult.FpShots["+ j +"].FpShotSlices["+ k +"].Duplication.Duration");
						fpShotSlice.Duplication = queryFpShotJobList_FpShotSliceQueryFpShotJobList_Duplication;

						QueryFpShotJobListResponse.QueryFpShotJobList_FpShotJob.QueryFpShotJobList_FpShotResult.QueryFpShotJobList_FpShot.QueryFpShotJobList_FpShotSlice.QueryFpShotJobList_Input queryFpShotJobList_FpShotSliceQueryFpShotJobList_Input = new QueryFpShotJobListResponse.QueryFpShotJobList_FpShotJob.QueryFpShotJobList_FpShotResult.QueryFpShotJobList_FpShot.QueryFpShotJobList_FpShotSlice.QueryFpShotJobList_Input();
						queryFpShotJobList_FpShotSliceQueryFpShotJobList_Input.Start = _ctx.StringValue("QueryFpShotJobList.FpShotJobList["+ i +"].FpShotResult.FpShots["+ j +"].FpShotSlices["+ k +"].Input.Start");
						queryFpShotJobList_FpShotSliceQueryFpShotJobList_Input.Duration = _ctx.StringValue("QueryFpShotJobList.FpShotJobList["+ i +"].FpShotResult.FpShots["+ j +"].FpShotSlices["+ k +"].Input.Duration");
						fpShotSlice.Input = queryFpShotJobList_FpShotSliceQueryFpShotJobList_Input;

						fpShot_fpShotSlices.Add(fpShotSlice);
					}
					fpShot.FpShotSlices = fpShot_fpShotSlices;

					fpShotResult_fpShots.Add(fpShot);
				}
				fpShotResult.FpShots = fpShotResult_fpShots;

				List<QueryFpShotJobListResponse.QueryFpShotJobList_FpShotJob.QueryFpShotJobList_FpShotResult.QueryFpShotJobList_TextFpShot> fpShotResult_textFpShots = new List<QueryFpShotJobListResponse.QueryFpShotJobList_FpShotJob.QueryFpShotJobList_FpShotResult.QueryFpShotJobList_TextFpShot>();
				for (int j = 0; j < _ctx.Length("QueryFpShotJobList.FpShotJobList["+ i +"].FpShotResult.TextFpShots.Length"); j++) {
					QueryFpShotJobListResponse.QueryFpShotJobList_FpShotJob.QueryFpShotJobList_FpShotResult.QueryFpShotJobList_TextFpShot textFpShot = new QueryFpShotJobListResponse.QueryFpShotJobList_FpShotJob.QueryFpShotJobList_FpShotResult.QueryFpShotJobList_TextFpShot();
					textFpShot.PrimaryKey = _ctx.StringValue("QueryFpShotJobList.FpShotJobList["+ i +"].FpShotResult.TextFpShots["+ j +"].PrimaryKey");
					textFpShot.Similarity = _ctx.StringValue("QueryFpShotJobList.FpShotJobList["+ i +"].FpShotResult.TextFpShots["+ j +"].Similarity");

					List<QueryFpShotJobListResponse.QueryFpShotJobList_FpShotJob.QueryFpShotJobList_FpShotResult.QueryFpShotJobList_TextFpShot.QueryFpShotJobList_TextFpShotSlice> textFpShot_textFpShotSlices = new List<QueryFpShotJobListResponse.QueryFpShotJobList_FpShotJob.QueryFpShotJobList_FpShotResult.QueryFpShotJobList_TextFpShot.QueryFpShotJobList_TextFpShotSlice>();
					for (int k = 0; k < _ctx.Length("QueryFpShotJobList.FpShotJobList["+ i +"].FpShotResult.TextFpShots["+ j +"].TextFpShotSlices.Length"); k++) {
						QueryFpShotJobListResponse.QueryFpShotJobList_FpShotJob.QueryFpShotJobList_FpShotResult.QueryFpShotJobList_TextFpShot.QueryFpShotJobList_TextFpShotSlice textFpShotSlice = new QueryFpShotJobListResponse.QueryFpShotJobList_FpShotJob.QueryFpShotJobList_FpShotResult.QueryFpShotJobList_TextFpShot.QueryFpShotJobList_TextFpShotSlice();
						textFpShotSlice.Similarity = _ctx.StringValue("QueryFpShotJobList.FpShotJobList["+ i +"].FpShotResult.TextFpShots["+ j +"].TextFpShotSlices["+ k +"].Similarity");
						textFpShotSlice.InputText = _ctx.StringValue("QueryFpShotJobList.FpShotJobList["+ i +"].FpShotResult.TextFpShots["+ j +"].TextFpShotSlices["+ k +"].InputText");
						textFpShotSlice.DuplicationText = _ctx.StringValue("QueryFpShotJobList.FpShotJobList["+ i +"].FpShotResult.TextFpShots["+ j +"].TextFpShotSlices["+ k +"].DuplicationText");

						QueryFpShotJobListResponse.QueryFpShotJobList_FpShotJob.QueryFpShotJobList_FpShotResult.QueryFpShotJobList_TextFpShot.QueryFpShotJobList_TextFpShotSlice.QueryFpShotJobList_InputFragment inputFragment = new QueryFpShotJobListResponse.QueryFpShotJobList_FpShotJob.QueryFpShotJobList_FpShotResult.QueryFpShotJobList_TextFpShot.QueryFpShotJobList_TextFpShotSlice.QueryFpShotJobList_InputFragment();
						inputFragment.Start = _ctx.StringValue("QueryFpShotJobList.FpShotJobList["+ i +"].FpShotResult.TextFpShots["+ j +"].TextFpShotSlices["+ k +"].InputFragment.Start");
						inputFragment.Duration = _ctx.StringValue("QueryFpShotJobList.FpShotJobList["+ i +"].FpShotResult.TextFpShots["+ j +"].TextFpShotSlices["+ k +"].InputFragment.Duration");
						textFpShotSlice.InputFragment = inputFragment;

						textFpShot_textFpShotSlices.Add(textFpShotSlice);
					}
					textFpShot.TextFpShotSlices = textFpShot_textFpShotSlices;

					fpShotResult_textFpShots.Add(textFpShot);
				}
				fpShotResult.TextFpShots = fpShotResult_textFpShots;
				fpShotJob.FpShotResult = fpShotResult;

				QueryFpShotJobListResponse.QueryFpShotJobList_FpShotJob.QueryFpShotJobList_FpShotConfig fpShotConfig = new QueryFpShotJobListResponse.QueryFpShotJobList_FpShotJob.QueryFpShotJobList_FpShotConfig();
				fpShotConfig.PrimaryKey = _ctx.StringValue("QueryFpShotJobList.FpShotJobList["+ i +"].FpShotConfig.PrimaryKey");
				fpShotConfig.SaveType = _ctx.StringValue("QueryFpShotJobList.FpShotJobList["+ i +"].FpShotConfig.SaveType");
				fpShotConfig.Notary = _ctx.StringValue("QueryFpShotJobList.FpShotJobList["+ i +"].FpShotConfig.Notary");
				fpShotConfig.FpDBId = _ctx.StringValue("QueryFpShotJobList.FpShotJobList["+ i +"].FpShotConfig.FpDBId");
				fpShotJob.FpShotConfig = fpShotConfig;

				QueryFpShotJobListResponse.QueryFpShotJobList_FpShotJob.QueryFpShotJobList_InputFile inputFile = new QueryFpShotJobListResponse.QueryFpShotJobList_FpShotJob.QueryFpShotJobList_InputFile();
				inputFile._Object = _ctx.StringValue("QueryFpShotJobList.FpShotJobList["+ i +"].InputFile.Object");
				inputFile.Location = _ctx.StringValue("QueryFpShotJobList.FpShotJobList["+ i +"].InputFile.Location");
				inputFile.Bucket = _ctx.StringValue("QueryFpShotJobList.FpShotJobList["+ i +"].InputFile.Bucket");
				fpShotJob.InputFile = inputFile;

				queryFpShotJobListResponse_fpShotJobList.Add(fpShotJob);
			}
			queryFpShotJobListResponse.FpShotJobList = queryFpShotJobListResponse_fpShotJobList;
        
			return queryFpShotJobListResponse;
        }
    }
}
