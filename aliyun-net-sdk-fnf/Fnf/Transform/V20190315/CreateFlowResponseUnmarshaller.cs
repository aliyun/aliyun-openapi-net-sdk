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
using Aliyun.Acs.fnf.Model.V20190315;

namespace Aliyun.Acs.fnf.Transform.V20190315
{
    public class CreateFlowResponseUnmarshaller
    {
        public static CreateFlowResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateFlowResponse createFlowResponse = new CreateFlowResponse();

			createFlowResponse.HttpResponse = _ctx.HttpResponse;
			createFlowResponse.Type = _ctx.StringValue("CreateFlow.Type");
			createFlowResponse.Definition = _ctx.StringValue("CreateFlow.Definition");
			createFlowResponse.RoleArn = _ctx.StringValue("CreateFlow.RoleArn");
			createFlowResponse.RequestId = _ctx.StringValue("CreateFlow.RequestId");
			createFlowResponse.Description = _ctx.StringValue("CreateFlow.Description");
			createFlowResponse.ExternalStorageLocation = _ctx.StringValue("CreateFlow.ExternalStorageLocation");
			createFlowResponse.Name = _ctx.StringValue("CreateFlow.Name");
			createFlowResponse.CreatedTime = _ctx.StringValue("CreateFlow.CreatedTime");
			createFlowResponse.LastModifiedTime = _ctx.StringValue("CreateFlow.LastModifiedTime");
			createFlowResponse.Id = _ctx.StringValue("CreateFlow.Id");
			createFlowResponse.ExecutionMode = _ctx.StringValue("CreateFlow.ExecutionMode");
        
			return createFlowResponse;
        }
    }
}
