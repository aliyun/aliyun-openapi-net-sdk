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
using Aliyun.Acs.dataworks_public.Model.V20200518;

namespace Aliyun.Acs.dataworks_public.Transform.V20200518
{
    public class GetDISyncTaskResponseUnmarshaller
    {
        public static GetDISyncTaskResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetDISyncTaskResponse getDISyncTaskResponse = new GetDISyncTaskResponse();

			getDISyncTaskResponse.HttpResponse = _ctx.HttpResponse;
			getDISyncTaskResponse.Success = _ctx.BooleanValue("GetDISyncTask.Success");
			getDISyncTaskResponse.RequestId = _ctx.StringValue("GetDISyncTask.RequestId");

			GetDISyncTaskResponse.GetDISyncTask_Data data = new GetDISyncTaskResponse.GetDISyncTask_Data();
			data.Code = _ctx.StringValue("GetDISyncTask.Data.Code");
			data.Status = _ctx.StringValue("GetDISyncTask.Data.Status");
			data.Message = _ctx.StringValue("GetDISyncTask.Data.Message");

			GetDISyncTaskResponse.GetDISyncTask_Data.GetDISyncTask_SolutionDetail solutionDetail = new GetDISyncTaskResponse.GetDISyncTask_Data.GetDISyncTask_SolutionDetail();
			solutionDetail.Status = _ctx.StringValue("GetDISyncTask.Data.SolutionDetail.Status");
			solutionDetail.Type = _ctx.StringValue("GetDISyncTask.Data.SolutionDetail.Type");
			solutionDetail.StartTime = _ctx.StringValue("GetDISyncTask.Data.SolutionDetail.StartTime");
			solutionDetail.CreatorName = _ctx.StringValue("GetDISyncTask.Data.SolutionDetail.CreatorName");
			solutionDetail.ProjectId = _ctx.LongValue("GetDISyncTask.Data.SolutionDetail.ProjectId");
			solutionDetail.SourceType = _ctx.StringValue("GetDISyncTask.Data.SolutionDetail.SourceType");
			solutionDetail.ProcessContent = _ctx.StringValue("GetDISyncTask.Data.SolutionDetail.ProcessContent");
			solutionDetail.Name = _ctx.StringValue("GetDISyncTask.Data.SolutionDetail.Name");
			solutionDetail.ProcessExtra = _ctx.StringValue("GetDISyncTask.Data.SolutionDetail.ProcessExtra");
			solutionDetail.SubmitTime = _ctx.StringValue("GetDISyncTask.Data.SolutionDetail.SubmitTime");
			solutionDetail.Id = _ctx.LongValue("GetDISyncTask.Data.SolutionDetail.Id");
			data.SolutionDetail = solutionDetail;
			getDISyncTaskResponse.Data = data;
        
			return getDISyncTaskResponse;
        }
    }
}
