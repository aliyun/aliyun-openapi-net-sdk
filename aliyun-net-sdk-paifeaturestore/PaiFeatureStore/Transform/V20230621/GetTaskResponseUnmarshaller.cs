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
using Aliyun.Acs.PaiFeatureStore.Model.V20230621;

namespace Aliyun.Acs.PaiFeatureStore.Transform.V20230621
{
    public class GetTaskResponseUnmarshaller
    {
        public static GetTaskResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetTaskResponse getTaskResponse = new GetTaskResponse();

			getTaskResponse.HttpResponse = _ctx.HttpResponse;
			getTaskResponse.RequestId = _ctx.StringValue("GetTask.RequestId");
			getTaskResponse.ProjectId = _ctx.StringValue("GetTask.ProjectId");
			getTaskResponse.ProjectName = _ctx.StringValue("GetTask.ProjectName");
			getTaskResponse.Type = _ctx.StringValue("GetTask.Type");
			getTaskResponse.ObjectType = _ctx.StringValue("GetTask.ObjectType");
			getTaskResponse.ObjectId = _ctx.StringValue("GetTask.ObjectId");
			getTaskResponse.Status = _ctx.StringValue("GetTask.Status");
			getTaskResponse.Config = _ctx.StringValue("GetTask.Config");
			getTaskResponse.RunningConfig = _ctx.StringValue("GetTask.RunningConfig");
			getTaskResponse.GmtCreateTime = _ctx.StringValue("GetTask.GmtCreateTime");
			getTaskResponse.GmtModifiedTime = _ctx.StringValue("GetTask.GmtModifiedTime");
			getTaskResponse.GmtExecutedTime = _ctx.StringValue("GetTask.GmtExecutedTime");
			getTaskResponse.GmtFinishedTime = _ctx.StringValue("GetTask.GmtFinishedTime");
        
			return getTaskResponse;
        }
    }
}
