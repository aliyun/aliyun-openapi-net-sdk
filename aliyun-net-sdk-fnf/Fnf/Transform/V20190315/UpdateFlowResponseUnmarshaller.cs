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
    public class UpdateFlowResponseUnmarshaller
    {
        public static UpdateFlowResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdateFlowResponse updateFlowResponse = new UpdateFlowResponse();

			updateFlowResponse.HttpResponse = _ctx.HttpResponse;
			updateFlowResponse.RequestId = _ctx.StringValue("UpdateFlow.RequestId");
			updateFlowResponse.Name = _ctx.StringValue("UpdateFlow.Name");
			updateFlowResponse.Description = _ctx.StringValue("UpdateFlow.Description");
			updateFlowResponse.Definition = _ctx.StringValue("UpdateFlow.Definition");
			updateFlowResponse.Id = _ctx.StringValue("UpdateFlow.Id");
			updateFlowResponse.Type = _ctx.StringValue("UpdateFlow.Type");
			updateFlowResponse.RoleArn = _ctx.StringValue("UpdateFlow.RoleArn");
			updateFlowResponse.CreatedTime = _ctx.StringValue("UpdateFlow.CreatedTime");
			updateFlowResponse.LastModifiedTime = _ctx.StringValue("UpdateFlow.LastModifiedTime");
			updateFlowResponse.ExternalStorageLocation = _ctx.StringValue("UpdateFlow.ExternalStorageLocation");
        
			return updateFlowResponse;
        }
    }
}
