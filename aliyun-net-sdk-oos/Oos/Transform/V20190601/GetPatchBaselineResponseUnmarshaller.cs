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
    public class GetPatchBaselineResponseUnmarshaller
    {
        public static GetPatchBaselineResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetPatchBaselineResponse getPatchBaselineResponse = new GetPatchBaselineResponse();

			getPatchBaselineResponse.HttpResponse = _ctx.HttpResponse;
			getPatchBaselineResponse.RequestId = _ctx.StringValue("GetPatchBaseline.RequestId");

			GetPatchBaselineResponse.GetPatchBaseline_PatchBaseline patchBaseline = new GetPatchBaselineResponse.GetPatchBaseline_PatchBaseline();
			patchBaseline.OperationSystem = _ctx.StringValue("GetPatchBaseline.PatchBaseline.OperationSystem");
			patchBaseline.IsDefault = _ctx.BooleanValue("GetPatchBaseline.PatchBaseline.IsDefault");
			patchBaseline.Description = _ctx.StringValue("GetPatchBaseline.PatchBaseline.Description");
			patchBaseline.UpdatedDate = _ctx.StringValue("GetPatchBaseline.PatchBaseline.UpdatedDate");
			patchBaseline.UpdatedBy = _ctx.StringValue("GetPatchBaseline.PatchBaseline.UpdatedBy");
			patchBaseline.CreatedBy = _ctx.StringValue("GetPatchBaseline.PatchBaseline.CreatedBy");
			patchBaseline.CreatedDate = _ctx.StringValue("GetPatchBaseline.PatchBaseline.CreatedDate");
			patchBaseline.Name = _ctx.StringValue("GetPatchBaseline.PatchBaseline.Name");
			patchBaseline.ApprovalRules = _ctx.StringValue("GetPatchBaseline.PatchBaseline.ApprovalRules");
			patchBaseline.Id = _ctx.StringValue("GetPatchBaseline.PatchBaseline.Id");
			patchBaseline.ShareType = _ctx.StringValue("GetPatchBaseline.PatchBaseline.ShareType");
			patchBaseline.RejectedPatchesAction = _ctx.StringValue("GetPatchBaseline.PatchBaseline.RejectedPatchesAction");

			List<string> patchBaseline_rejectedPatches = new List<string>();
			for (int i = 0; i < _ctx.Length("GetPatchBaseline.PatchBaseline.RejectedPatches.Length"); i++) {
				patchBaseline_rejectedPatches.Add(_ctx.StringValue("GetPatchBaseline.PatchBaseline.RejectedPatches["+ i +"]"));
			}
			patchBaseline.RejectedPatches = patchBaseline_rejectedPatches;
			getPatchBaselineResponse.PatchBaseline = patchBaseline;
        
			return getPatchBaselineResponse;
        }
    }
}
