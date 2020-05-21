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
        public static CreateFlowResponse Unmarshall(UnmarshallerContext context)
        {
			CreateFlowResponse createFlowResponse = new CreateFlowResponse();

			createFlowResponse.HttpResponse = context.HttpResponse;
			createFlowResponse.RequestId = context.StringValue("CreateFlow.RequestId");
			createFlowResponse.Name = context.StringValue("CreateFlow.Name");
			createFlowResponse.Description = context.StringValue("CreateFlow.Description");
			createFlowResponse.Definition = context.StringValue("CreateFlow.Definition");
			createFlowResponse.Id = context.StringValue("CreateFlow.Id");
			createFlowResponse.Type = context.StringValue("CreateFlow.Type");
			createFlowResponse.RoleArn = context.StringValue("CreateFlow.RoleArn");
			createFlowResponse.CreatedTime = context.StringValue("CreateFlow.CreatedTime");
			createFlowResponse.LastModifiedTime = context.StringValue("CreateFlow.LastModifiedTime");
			createFlowResponse.ExternalStorageLocation = context.StringValue("CreateFlow.ExternalStorageLocation");
        
			return createFlowResponse;
        }
    }
}
