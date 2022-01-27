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
    public class UpdatePatchBaselineResponseUnmarshaller
    {
        public static UpdatePatchBaselineResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdatePatchBaselineResponse updatePatchBaselineResponse = new UpdatePatchBaselineResponse();

			updatePatchBaselineResponse.HttpResponse = _ctx.HttpResponse;
			updatePatchBaselineResponse.RequestId = _ctx.StringValue("UpdatePatchBaseline.RequestId");

			UpdatePatchBaselineResponse.UpdatePatchBaseline_PatchBaseline patchBaseline = new UpdatePatchBaselineResponse.UpdatePatchBaseline_PatchBaseline();
			patchBaseline.Id = _ctx.StringValue("UpdatePatchBaseline.PatchBaseline.Id");
			patchBaseline.Name = _ctx.StringValue("UpdatePatchBaseline.PatchBaseline.Name");
			patchBaseline.CreatedDate = _ctx.StringValue("UpdatePatchBaseline.PatchBaseline.CreatedDate");
			patchBaseline.CreatedBy = _ctx.StringValue("UpdatePatchBaseline.PatchBaseline.CreatedBy");
			patchBaseline.UpdatedDate = _ctx.StringValue("UpdatePatchBaseline.PatchBaseline.UpdatedDate");
			patchBaseline.UpdatedBy = _ctx.StringValue("UpdatePatchBaseline.PatchBaseline.UpdatedBy");
			patchBaseline.Description = _ctx.StringValue("UpdatePatchBaseline.PatchBaseline.Description");
			patchBaseline.ShareType = _ctx.StringValue("UpdatePatchBaseline.PatchBaseline.ShareType");
			patchBaseline.OperationSystem = _ctx.StringValue("UpdatePatchBaseline.PatchBaseline.OperationSystem");
			patchBaseline.ApprovalRules = _ctx.StringValue("UpdatePatchBaseline.PatchBaseline.ApprovalRules");
			updatePatchBaselineResponse.PatchBaseline = patchBaseline;
        
			return updatePatchBaselineResponse;
        }
    }
}
