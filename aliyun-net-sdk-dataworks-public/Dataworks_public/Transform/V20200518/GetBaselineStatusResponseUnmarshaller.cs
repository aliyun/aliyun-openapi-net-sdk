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
        public static GetBaselineStatusResponse Unmarshall(UnmarshallerContext context)
        {
			GetBaselineStatusResponse getBaselineStatusResponse = new GetBaselineStatusResponse();

			getBaselineStatusResponse.HttpResponse = context.HttpResponse;
			getBaselineStatusResponse.Success = context.BooleanValue("GetBaselineStatus.Success");
			getBaselineStatusResponse.ErrorCode = context.StringValue("GetBaselineStatus.ErrorCode");
			getBaselineStatusResponse.ErrorMessage = context.StringValue("GetBaselineStatus.ErrorMessage");
			getBaselineStatusResponse.HttpStatusCode = context.IntegerValue("GetBaselineStatus.HttpStatusCode");
			getBaselineStatusResponse.RequestId = context.StringValue("GetBaselineStatus.RequestId");

			GetBaselineStatusResponse.GetBaselineStatus_Data data = new GetBaselineStatusResponse.GetBaselineStatus_Data();
			data.BaselineName = context.StringValue("GetBaselineStatus.Data.BaselineName");
			data.BaselineId = context.LongValue("GetBaselineStatus.Data.BaselineId");
			data.Bizdate = context.LongValue("GetBaselineStatus.Data.Bizdate");
			data.Owner = context.StringValue("GetBaselineStatus.Data.Owner");
			data.ExpTime = context.LongValue("GetBaselineStatus.Data.ExpTime");
			data.FinishTime = context.LongValue("GetBaselineStatus.Data.FinishTime");
			data.EndCast = context.LongValue("GetBaselineStatus.Data.EndCast");
			data.SlaTime = context.LongValue("GetBaselineStatus.Data.SlaTime");
			data.Priority = context.IntegerValue("GetBaselineStatus.Data.Priority");
			data.ProjectId = context.LongValue("GetBaselineStatus.Data.ProjectId");
			data.Buffer = context.FloatValue("GetBaselineStatus.Data.Buffer");
			data.Status = context.StringValue("GetBaselineStatus.Data.Status");
			data.FinishStatus = context.StringValue("GetBaselineStatus.Data.FinishStatus");
			data.InGroupId = context.IntegerValue("GetBaselineStatus.Data.InGroupId");

			GetBaselineStatusResponse.GetBaselineStatus_Data.GetBaselineStatus_LastInstance lastInstance = new GetBaselineStatusResponse.GetBaselineStatus_Data.GetBaselineStatus_LastInstance();
			lastInstance.InstanceId = context.LongValue("GetBaselineStatus.Data.LastInstance.InstanceId");
			lastInstance.Status = context.StringValue("GetBaselineStatus.Data.LastInstance.Status");
			lastInstance.ProjectId = context.LongValue("GetBaselineStatus.Data.LastInstance.ProjectId");
			lastInstance.Owner = context.StringValue("GetBaselineStatus.Data.LastInstance.Owner");
			lastInstance.NodeId = context.LongValue("GetBaselineStatus.Data.LastInstance.NodeId");
			lastInstance.FinishTime = context.LongValue("GetBaselineStatus.Data.LastInstance.FinishTime");
			lastInstance.EndCast = context.LongValue("GetBaselineStatus.Data.LastInstance.EndCast");
			lastInstance.NodeName = context.StringValue("GetBaselineStatus.Data.LastInstance.NodeName");
			data.LastInstance = lastInstance;

			GetBaselineStatusResponse.GetBaselineStatus_Data.GetBaselineStatus_BlockInstance blockInstance = new GetBaselineStatusResponse.GetBaselineStatus_Data.GetBaselineStatus_BlockInstance();
			blockInstance.InstanceId = context.LongValue("GetBaselineStatus.Data.BlockInstance.InstanceId");
			blockInstance.Status = context.StringValue("GetBaselineStatus.Data.BlockInstance.Status");
			blockInstance.ProjectId = context.LongValue("GetBaselineStatus.Data.BlockInstance.ProjectId");
			blockInstance.Owner = context.StringValue("GetBaselineStatus.Data.BlockInstance.Owner");
			blockInstance.NodeId = context.LongValue("GetBaselineStatus.Data.BlockInstance.NodeId");
			blockInstance.FinishTime = context.LongValue("GetBaselineStatus.Data.BlockInstance.FinishTime");
			blockInstance.EndCast = context.LongValue("GetBaselineStatus.Data.BlockInstance.EndCast");
			blockInstance.NodeName = context.StringValue("GetBaselineStatus.Data.BlockInstance.NodeName");
			data.BlockInstance = blockInstance;
			getBaselineStatusResponse.Data = data;
        
			return getBaselineStatusResponse;
        }
    }
}
