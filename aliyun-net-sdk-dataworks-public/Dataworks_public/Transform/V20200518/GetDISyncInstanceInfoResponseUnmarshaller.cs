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
    public class GetDISyncInstanceInfoResponseUnmarshaller
    {
        public static GetDISyncInstanceInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetDISyncInstanceInfoResponse getDISyncInstanceInfoResponse = new GetDISyncInstanceInfoResponse();

			getDISyncInstanceInfoResponse.HttpResponse = _ctx.HttpResponse;
			getDISyncInstanceInfoResponse.RequestId = _ctx.StringValue("GetDISyncInstanceInfo.RequestId");
			getDISyncInstanceInfoResponse.Success = _ctx.BooleanValue("GetDISyncInstanceInfo.Success");

			GetDISyncInstanceInfoResponse.GetDISyncInstanceInfo_Data data = new GetDISyncInstanceInfoResponse.GetDISyncInstanceInfo_Data();
			data.Status = _ctx.StringValue("GetDISyncInstanceInfo.Data.Status");
			data.Name = _ctx.StringValue("GetDISyncInstanceInfo.Data.Name");
			data.Message = _ctx.StringValue("GetDISyncInstanceInfo.Data.Message");

			GetDISyncInstanceInfoResponse.GetDISyncInstanceInfo_Data.GetDISyncInstanceInfo_SolutionInfo solutionInfo = new GetDISyncInstanceInfoResponse.GetDISyncInstanceInfo_Data.GetDISyncInstanceInfo_SolutionInfo();
			solutionInfo.Id = _ctx.LongValue("GetDISyncInstanceInfo.Data.SolutionInfo.Id");
			solutionInfo.Status = _ctx.StringValue("GetDISyncInstanceInfo.Data.SolutionInfo.Status");
			solutionInfo.CreatorName = _ctx.StringValue("GetDISyncInstanceInfo.Data.SolutionInfo.CreatorName");

			List<GetDISyncInstanceInfoResponse.GetDISyncInstanceInfo_Data.GetDISyncInstanceInfo_SolutionInfo.GetDISyncInstanceInfo_StepDetailItem> solutionInfo_stepDetail = new List<GetDISyncInstanceInfoResponse.GetDISyncInstanceInfo_Data.GetDISyncInstanceInfo_SolutionInfo.GetDISyncInstanceInfo_StepDetailItem>();
			for (int i = 0; i < _ctx.Length("GetDISyncInstanceInfo.Data.SolutionInfo.StepDetail.Length"); i++) {
				GetDISyncInstanceInfoResponse.GetDISyncInstanceInfo_Data.GetDISyncInstanceInfo_SolutionInfo.GetDISyncInstanceInfo_StepDetailItem stepDetailItem = new GetDISyncInstanceInfoResponse.GetDISyncInstanceInfo_Data.GetDISyncInstanceInfo_SolutionInfo.GetDISyncInstanceInfo_StepDetailItem();
				stepDetailItem.StepName = _ctx.StringValue("GetDISyncInstanceInfo.Data.SolutionInfo.StepDetail["+ i +"].StepName");
				stepDetailItem.StepId = _ctx.LongValue("GetDISyncInstanceInfo.Data.SolutionInfo.StepDetail["+ i +"].StepId");
				stepDetailItem.Status = _ctx.StringValue("GetDISyncInstanceInfo.Data.SolutionInfo.StepDetail["+ i +"].Status");

				solutionInfo_stepDetail.Add(stepDetailItem);
			}
			solutionInfo.StepDetail = solutionInfo_stepDetail;
			data.SolutionInfo = solutionInfo;
			getDISyncInstanceInfoResponse.Data = data;
        
			return getDISyncInstanceInfoResponse;
        }
    }
}
