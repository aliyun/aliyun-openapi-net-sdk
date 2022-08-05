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
using Aliyun.Acs.oos.Model.V20190601;

namespace Aliyun.Acs.oos.Transform.V20190601
{
    public class CreatePatchBaselineResponseUnmarshaller
    {
        public static CreatePatchBaselineResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreatePatchBaselineResponse createPatchBaselineResponse = new CreatePatchBaselineResponse();

			createPatchBaselineResponse.HttpResponse = _ctx.HttpResponse;
			createPatchBaselineResponse.RequestId = _ctx.StringValue("CreatePatchBaseline.RequestId");

			CreatePatchBaselineResponse.CreatePatchBaseline_PatchBaseline patchBaseline = new CreatePatchBaselineResponse.CreatePatchBaseline_PatchBaseline();
			patchBaseline.OperationSystem = _ctx.StringValue("CreatePatchBaseline.PatchBaseline.OperationSystem");
			patchBaseline.Description = _ctx.StringValue("CreatePatchBaseline.PatchBaseline.Description");
			patchBaseline.UpdatedDate = _ctx.StringValue("CreatePatchBaseline.PatchBaseline.UpdatedDate");
			patchBaseline.UpdatedBy = _ctx.StringValue("CreatePatchBaseline.PatchBaseline.UpdatedBy");
			patchBaseline.CreatedBy = _ctx.StringValue("CreatePatchBaseline.PatchBaseline.CreatedBy");
			patchBaseline.CreatedDate = _ctx.StringValue("CreatePatchBaseline.PatchBaseline.CreatedDate");
			patchBaseline.Name = _ctx.StringValue("CreatePatchBaseline.PatchBaseline.Name");
			patchBaseline.ApprovalRules = _ctx.StringValue("CreatePatchBaseline.PatchBaseline.ApprovalRules");
			patchBaseline.Id = _ctx.StringValue("CreatePatchBaseline.PatchBaseline.Id");
			patchBaseline.ShareType = _ctx.StringValue("CreatePatchBaseline.PatchBaseline.ShareType");
			createPatchBaselineResponse.PatchBaseline = patchBaseline;
        
			return createPatchBaselineResponse;
        }
    }
}
