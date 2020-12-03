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
    public class GetNodeResponseUnmarshaller
    {
        public static GetNodeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetNodeResponse getNodeResponse = new GetNodeResponse();

			getNodeResponse.HttpResponse = _ctx.HttpResponse;
			getNodeResponse.Success = _ctx.BooleanValue("GetNode.Success");
			getNodeResponse.ErrorCode = _ctx.StringValue("GetNode.ErrorCode");
			getNodeResponse.ErrorMessage = _ctx.StringValue("GetNode.ErrorMessage");
			getNodeResponse.HttpStatusCode = _ctx.IntegerValue("GetNode.HttpStatusCode");
			getNodeResponse.RequestId = _ctx.StringValue("GetNode.RequestId");

			GetNodeResponse.GetNode_Data data = new GetNodeResponse.GetNode_Data();
			data.NodeId = _ctx.LongValue("GetNode.Data.NodeId");
			data.OwnerId = _ctx.StringValue("GetNode.Data.OwnerId");
			data.Description = _ctx.StringValue("GetNode.Data.Description");
			data.ResGroupName = _ctx.StringValue("GetNode.Data.ResGroupName");
			data.NodeName = _ctx.StringValue("GetNode.Data.NodeName");
			data.CronExpress = _ctx.StringValue("GetNode.Data.CronExpress");
			data.Repeatability = _ctx.StringValue("GetNode.Data.Repeatability");
			data.ProgramType = _ctx.StringValue("GetNode.Data.ProgramType");
			data.ProjectId = _ctx.LongValue("GetNode.Data.ProjectId");
			data.SchedulerType = _ctx.StringValue("GetNode.Data.SchedulerType");
			data.ParamValues = _ctx.StringValue("GetNode.Data.ParamValues");
			data.Priority = _ctx.IntegerValue("GetNode.Data.Priority");
			data.BaselineId = _ctx.LongValue("GetNode.Data.BaselineId");
			data.RepeatInterval = _ctx.LongValue("GetNode.Data.RepeatInterval");
			data.Connection = _ctx.StringValue("GetNode.Data.Connection");
			data.DqcType = _ctx.IntegerValue("GetNode.Data.DqcType");
			data.DqcDescription = _ctx.StringValue("GetNode.Data.DqcDescription");
			data.RelatedFlowId = _ctx.LongValue("GetNode.Data.RelatedFlowId");
			getNodeResponse.Data = data;
        
			return getNodeResponse;
        }
    }
}
