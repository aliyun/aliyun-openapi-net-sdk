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
    public class ListFpShotImportJobResponseUnmarshaller
    {
        public static ListFpShotImportJobResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListFpShotImportJobResponse listFpShotImportJobResponse = new ListFpShotImportJobResponse();

			listFpShotImportJobResponse.HttpResponse = _ctx.HttpResponse;
			listFpShotImportJobResponse.RequestId = _ctx.StringValue("ListFpShotImportJob.RequestId");

			List<string> listFpShotImportJobResponse_nonExistIds = new List<string>();
			for (int i = 0; i < _ctx.Length("ListFpShotImportJob.NonExistIds.Length"); i++) {
				listFpShotImportJobResponse_nonExistIds.Add(_ctx.StringValue("ListFpShotImportJob.NonExistIds["+ i +"]"));
			}
			listFpShotImportJobResponse.NonExistIds = listFpShotImportJobResponse_nonExistIds;

			List<ListFpShotImportJobResponse.ListFpShotImportJob_FpShotImportJob> listFpShotImportJobResponse_fpShotImportJobList = new List<ListFpShotImportJobResponse.ListFpShotImportJob_FpShotImportJob>();
			for (int i = 0; i < _ctx.Length("ListFpShotImportJob.FpShotImportJobList.Length"); i++) {
				ListFpShotImportJobResponse.ListFpShotImportJob_FpShotImportJob fpShotImportJob = new ListFpShotImportJobResponse.ListFpShotImportJob_FpShotImportJob();
				fpShotImportJob.Id = _ctx.StringValue("ListFpShotImportJob.FpShotImportJobList["+ i +"].Id");
				fpShotImportJob.FpDBId = _ctx.StringValue("ListFpShotImportJob.FpShotImportJobList["+ i +"].FpDBId");
				fpShotImportJob.PipelineId = _ctx.StringValue("ListFpShotImportJob.FpShotImportJobList["+ i +"].PipelineId");
				fpShotImportJob.FpImportConfig = _ctx.StringValue("ListFpShotImportJob.FpShotImportJobList["+ i +"].FpImportConfig");
				fpShotImportJob.Status = _ctx.StringValue("ListFpShotImportJob.FpShotImportJobList["+ i +"].Status");
				fpShotImportJob.Code = _ctx.StringValue("ListFpShotImportJob.FpShotImportJobList["+ i +"].Code");
				fpShotImportJob.Message = _ctx.StringValue("ListFpShotImportJob.FpShotImportJobList["+ i +"].Message");
				fpShotImportJob.CreateTime = _ctx.StringValue("ListFpShotImportJob.FpShotImportJobList["+ i +"].CreateTime");
				fpShotImportJob.FinishTime = _ctx.StringValue("ListFpShotImportJob.FpShotImportJobList["+ i +"].FinishTime");
				fpShotImportJob.UserData = _ctx.StringValue("ListFpShotImportJob.FpShotImportJobList["+ i +"].UserData");
				fpShotImportJob.Input = _ctx.StringValue("ListFpShotImportJob.FpShotImportJobList["+ i +"].Input");
				fpShotImportJob.ProcessMessage = _ctx.StringValue("ListFpShotImportJob.FpShotImportJobList["+ i +"].ProcessMessage");

				listFpShotImportJobResponse_fpShotImportJobList.Add(fpShotImportJob);
			}
			listFpShotImportJobResponse.FpShotImportJobList = listFpShotImportJobResponse_fpShotImportJobList;
        
			return listFpShotImportJobResponse;
        }
    }
}
