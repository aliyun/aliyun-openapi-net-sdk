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
    public class GetInstanceResponseUnmarshaller
    {
        public static GetInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetInstanceResponse getInstanceResponse = new GetInstanceResponse();

			getInstanceResponse.HttpResponse = _ctx.HttpResponse;
			getInstanceResponse.ErrorCode = _ctx.StringValue("GetInstance.ErrorCode");
			getInstanceResponse.ErrorMessage = _ctx.StringValue("GetInstance.ErrorMessage");
			getInstanceResponse.HttpStatusCode = _ctx.IntegerValue("GetInstance.HttpStatusCode");
			getInstanceResponse.RequestId = _ctx.StringValue("GetInstance.RequestId");
			getInstanceResponse.Success = _ctx.BooleanValue("GetInstance.Success");

			GetInstanceResponse.GetInstance_Data data = new GetInstanceResponse.GetInstance_Data();
			data.NodeId = _ctx.LongValue("GetInstance.Data.NodeId");
			data.InstanceId = _ctx.LongValue("GetInstance.Data.InstanceId");
			data.DagId = _ctx.LongValue("GetInstance.Data.DagId");
			data.DagType = _ctx.StringValue("GetInstance.Data.DagType");
			data.Status = _ctx.StringValue("GetInstance.Data.Status");
			data.Bizdate = _ctx.LongValue("GetInstance.Data.Bizdate");
			data.ParamValues = _ctx.StringValue("GetInstance.Data.ParamValues");
			data.CycTime = _ctx.LongValue("GetInstance.Data.CycTime");
			data.FinishTime = _ctx.LongValue("GetInstance.Data.FinishTime");
			data.BeginWaitTimeTime = _ctx.LongValue("GetInstance.Data.BeginWaitTimeTime");
			data.BeginWaitResTime = _ctx.LongValue("GetInstance.Data.BeginWaitResTime");
			data.BeginRunningTime = _ctx.LongValue("GetInstance.Data.BeginRunningTime");
			data.CreateTime = _ctx.LongValue("GetInstance.Data.CreateTime");
			data.ModifyTime = _ctx.LongValue("GetInstance.Data.ModifyTime");
			data.NodeName = _ctx.StringValue("GetInstance.Data.NodeName");
			data.Priority = _ctx.IntegerValue("GetInstance.Data.Priority");
			data.BaselineId = _ctx.LongValue("GetInstance.Data.BaselineId");
			data.Repeatability = _ctx.BooleanValue("GetInstance.Data.Repeatability");
			data.RepeatInterval = _ctx.LongValue("GetInstance.Data.RepeatInterval");
			data.Connection = _ctx.StringValue("GetInstance.Data.Connection");
			data.DqcType = _ctx.IntegerValue("GetInstance.Data.DqcType");
			data.DqcDescription = _ctx.StringValue("GetInstance.Data.DqcDescription");
			data.ErrorMessage = _ctx.StringValue("GetInstance.Data.ErrorMessage");
			data.RelatedFlowId = _ctx.LongValue("GetInstance.Data.RelatedFlowId");
			data.TaskType = _ctx.StringValue("GetInstance.Data.TaskType");
			data.TaskRerunTime = _ctx.IntegerValue("GetInstance.Data.TaskRerunTime");
			getInstanceResponse.Data = data;
        
			return getInstanceResponse;
        }
    }
}
