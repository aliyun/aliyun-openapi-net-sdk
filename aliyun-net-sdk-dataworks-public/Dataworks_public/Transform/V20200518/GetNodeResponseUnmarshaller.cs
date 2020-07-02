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
        public static GetNodeResponse Unmarshall(UnmarshallerContext context)
        {
			GetNodeResponse getNodeResponse = new GetNodeResponse();

			getNodeResponse.HttpResponse = context.HttpResponse;
			getNodeResponse.Success = context.BooleanValue("GetNode.Success");
			getNodeResponse.ErrorCode = context.StringValue("GetNode.ErrorCode");
			getNodeResponse.ErrorMessage = context.StringValue("GetNode.ErrorMessage");
			getNodeResponse.HttpStatusCode = context.IntegerValue("GetNode.HttpStatusCode");
			getNodeResponse.RequestId = context.StringValue("GetNode.RequestId");

			GetNodeResponse.GetNode_Data data = new GetNodeResponse.GetNode_Data();
			data.NodeId = context.LongValue("GetNode.Data.NodeId");
			data.OwnerId = context.StringValue("GetNode.Data.OwnerId");
			data.Description = context.StringValue("GetNode.Data.Description");
			data.ResGroupName = context.StringValue("GetNode.Data.ResGroupName");
			data.NodeName = context.StringValue("GetNode.Data.NodeName");
			data.CronExpress = context.StringValue("GetNode.Data.CronExpress");
			data.Repeatability = context.StringValue("GetNode.Data.Repeatability");
			data.ProgramType = context.StringValue("GetNode.Data.ProgramType");
			data.ProjectId = context.LongValue("GetNode.Data.ProjectId");
			data.SchedulerType = context.StringValue("GetNode.Data.SchedulerType");
			data.ParamValues = context.StringValue("GetNode.Data.ParamValues");
			getNodeResponse.Data = data;
        
			return getNodeResponse;
        }
    }
}
