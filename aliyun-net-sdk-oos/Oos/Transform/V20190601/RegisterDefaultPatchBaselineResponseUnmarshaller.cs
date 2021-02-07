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
    public class RegisterDefaultPatchBaselineResponseUnmarshaller
    {
        public static RegisterDefaultPatchBaselineResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RegisterDefaultPatchBaselineResponse registerDefaultPatchBaselineResponse = new RegisterDefaultPatchBaselineResponse();

			registerDefaultPatchBaselineResponse.HttpResponse = _ctx.HttpResponse;
			registerDefaultPatchBaselineResponse.RequestId = _ctx.StringValue("RegisterDefaultPatchBaseline.RequestId");

			RegisterDefaultPatchBaselineResponse.RegisterDefaultPatchBaseline_PatchBaseline patchBaseline = new RegisterDefaultPatchBaselineResponse.RegisterDefaultPatchBaseline_PatchBaseline();
			patchBaseline.Id = _ctx.StringValue("RegisterDefaultPatchBaseline.PatchBaseline.Id");
			patchBaseline.Name = _ctx.StringValue("RegisterDefaultPatchBaseline.PatchBaseline.Name");
			patchBaseline.CreatedDate = _ctx.StringValue("RegisterDefaultPatchBaseline.PatchBaseline.CreatedDate");
			patchBaseline.CreatedBy = _ctx.StringValue("RegisterDefaultPatchBaseline.PatchBaseline.CreatedBy");
			patchBaseline.UpdatedDate = _ctx.StringValue("RegisterDefaultPatchBaseline.PatchBaseline.UpdatedDate");
			patchBaseline.UpdatedBy = _ctx.StringValue("RegisterDefaultPatchBaseline.PatchBaseline.UpdatedBy");
			patchBaseline.Description = _ctx.StringValue("RegisterDefaultPatchBaseline.PatchBaseline.Description");
			patchBaseline.ShareType = _ctx.StringValue("RegisterDefaultPatchBaseline.PatchBaseline.ShareType");
			patchBaseline.OperationSystem = _ctx.StringValue("RegisterDefaultPatchBaseline.PatchBaseline.OperationSystem");
			patchBaseline.ApprovalRules = _ctx.StringValue("RegisterDefaultPatchBaseline.PatchBaseline.ApprovalRules");
			registerDefaultPatchBaselineResponse.PatchBaseline = patchBaseline;
        
			return registerDefaultPatchBaselineResponse;
        }
    }
}
