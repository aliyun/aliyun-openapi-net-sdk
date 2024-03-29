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
    public class GetBaselineStatusResponseUnmarshaller
    {
        public static GetBaselineStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetBaselineStatusResponse getBaselineStatusResponse = new GetBaselineStatusResponse();

			getBaselineStatusResponse.HttpResponse = _ctx.HttpResponse;
			getBaselineStatusResponse.HttpStatusCode = _ctx.IntegerValue("GetBaselineStatus.HttpStatusCode");
			getBaselineStatusResponse.RequestId = _ctx.StringValue("GetBaselineStatus.RequestId");
			getBaselineStatusResponse.ErrorMessage = _ctx.StringValue("GetBaselineStatus.ErrorMessage");
			getBaselineStatusResponse.ErrorCode = _ctx.StringValue("GetBaselineStatus.ErrorCode");
			getBaselineStatusResponse.Success = _ctx.BooleanValue("GetBaselineStatus.Success");

			GetBaselineStatusResponse.GetBaselineStatus_Data data = new GetBaselineStatusResponse.GetBaselineStatus_Data();
			data.Status = _ctx.StringValue("GetBaselineStatus.Data.Status");
			data.Owner = _ctx.StringValue("GetBaselineStatus.Data.Owner");
			data.FinishTime = _ctx.LongValue("GetBaselineStatus.Data.FinishTime");
			data.ProjectId = _ctx.LongValue("GetBaselineStatus.Data.ProjectId");
			data.Priority = _ctx.IntegerValue("GetBaselineStatus.Data.Priority");
			data.EndCast = _ctx.LongValue("GetBaselineStatus.Data.EndCast");
			data.InGroupId = _ctx.IntegerValue("GetBaselineStatus.Data.InGroupId");
			data.BaselineName = _ctx.StringValue("GetBaselineStatus.Data.BaselineName");
			data.BaselineId = _ctx.LongValue("GetBaselineStatus.Data.BaselineId");
			data.FinishStatus = _ctx.StringValue("GetBaselineStatus.Data.FinishStatus");
			data.Bizdate = _ctx.LongValue("GetBaselineStatus.Data.Bizdate");
			data.Buffer = _ctx.FloatValue("GetBaselineStatus.Data.Buffer");
			data.SlaTime = _ctx.LongValue("GetBaselineStatus.Data.SlaTime");
			data.ExpTime = _ctx.LongValue("GetBaselineStatus.Data.ExpTime");

			GetBaselineStatusResponse.GetBaselineStatus_Data.GetBaselineStatus_LastInstance lastInstance = new GetBaselineStatusResponse.GetBaselineStatus_Data.GetBaselineStatus_LastInstance();
			lastInstance.Status = _ctx.StringValue("GetBaselineStatus.Data.LastInstance.Status");
			lastInstance.Owner = _ctx.StringValue("GetBaselineStatus.Data.LastInstance.Owner");
			lastInstance.FinishTime = _ctx.LongValue("GetBaselineStatus.Data.LastInstance.FinishTime");
			lastInstance.NodeName = _ctx.StringValue("GetBaselineStatus.Data.LastInstance.NodeName");
			lastInstance.ProjectId = _ctx.LongValue("GetBaselineStatus.Data.LastInstance.ProjectId");
			lastInstance.InstanceId = _ctx.LongValue("GetBaselineStatus.Data.LastInstance.InstanceId");
			lastInstance.EndCast = _ctx.LongValue("GetBaselineStatus.Data.LastInstance.EndCast");
			lastInstance.NodeId = _ctx.LongValue("GetBaselineStatus.Data.LastInstance.NodeId");
			data.LastInstance = lastInstance;

			GetBaselineStatusResponse.GetBaselineStatus_Data.GetBaselineStatus_BlockInstance blockInstance = new GetBaselineStatusResponse.GetBaselineStatus_Data.GetBaselineStatus_BlockInstance();
			blockInstance.Status = _ctx.StringValue("GetBaselineStatus.Data.BlockInstance.Status");
			blockInstance.Owner = _ctx.StringValue("GetBaselineStatus.Data.BlockInstance.Owner");
			blockInstance.FinishTime = _ctx.LongValue("GetBaselineStatus.Data.BlockInstance.FinishTime");
			blockInstance.NodeName = _ctx.StringValue("GetBaselineStatus.Data.BlockInstance.NodeName");
			blockInstance.ProjectId = _ctx.LongValue("GetBaselineStatus.Data.BlockInstance.ProjectId");
			blockInstance.InstanceId = _ctx.LongValue("GetBaselineStatus.Data.BlockInstance.InstanceId");
			blockInstance.EndCast = _ctx.LongValue("GetBaselineStatus.Data.BlockInstance.EndCast");
			blockInstance.NodeId = _ctx.LongValue("GetBaselineStatus.Data.BlockInstance.NodeId");
			data.BlockInstance = blockInstance;
			getBaselineStatusResponse.Data = data;
        
			return getBaselineStatusResponse;
        }
    }
}
