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
    public class ListPatchBaselinesResponseUnmarshaller
    {
        public static ListPatchBaselinesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListPatchBaselinesResponse listPatchBaselinesResponse = new ListPatchBaselinesResponse();

			listPatchBaselinesResponse.HttpResponse = _ctx.HttpResponse;
			listPatchBaselinesResponse.RequestId = _ctx.StringValue("ListPatchBaselines.RequestId");
			listPatchBaselinesResponse.MaxResults = _ctx.IntegerValue("ListPatchBaselines.MaxResults");
			listPatchBaselinesResponse.NextToken = _ctx.StringValue("ListPatchBaselines.NextToken");

			List<ListPatchBaselinesResponse.ListPatchBaselines_PatchBaseline> listPatchBaselinesResponse_patchBaselines = new List<ListPatchBaselinesResponse.ListPatchBaselines_PatchBaseline>();
			for (int i = 0; i < _ctx.Length("ListPatchBaselines.PatchBaselines.Length"); i++) {
				ListPatchBaselinesResponse.ListPatchBaselines_PatchBaseline patchBaseline = new ListPatchBaselinesResponse.ListPatchBaselines_PatchBaseline();
				patchBaseline.Id = _ctx.StringValue("ListPatchBaselines.PatchBaselines["+ i +"].Id");
				patchBaseline.Name = _ctx.StringValue("ListPatchBaselines.PatchBaselines["+ i +"].Name");
				patchBaseline.CreatedDate = _ctx.StringValue("ListPatchBaselines.PatchBaselines["+ i +"].CreatedDate");
				patchBaseline.CreatedBy = _ctx.StringValue("ListPatchBaselines.PatchBaselines["+ i +"].CreatedBy");
				patchBaseline.UpdatedDate = _ctx.StringValue("ListPatchBaselines.PatchBaselines["+ i +"].UpdatedDate");
				patchBaseline.UpdatedBy = _ctx.StringValue("ListPatchBaselines.PatchBaselines["+ i +"].UpdatedBy");
				patchBaseline.Description = _ctx.StringValue("ListPatchBaselines.PatchBaselines["+ i +"].Description");
				patchBaseline.ShareType = _ctx.StringValue("ListPatchBaselines.PatchBaselines["+ i +"].ShareType");
				patchBaseline.OperationSystem = _ctx.StringValue("ListPatchBaselines.PatchBaselines["+ i +"].OperationSystem");
				patchBaseline.IsDefault = _ctx.BooleanValue("ListPatchBaselines.PatchBaselines["+ i +"].IsDefault");

				listPatchBaselinesResponse_patchBaselines.Add(patchBaseline);
			}
			listPatchBaselinesResponse.PatchBaselines = listPatchBaselinesResponse_patchBaselines;
        
			return listPatchBaselinesResponse;
        }
    }
}
