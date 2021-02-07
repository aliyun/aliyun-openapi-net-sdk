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
    public class ListInstancePatchesResponseUnmarshaller
    {
        public static ListInstancePatchesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListInstancePatchesResponse listInstancePatchesResponse = new ListInstancePatchesResponse();

			listInstancePatchesResponse.HttpResponse = _ctx.HttpResponse;
			listInstancePatchesResponse.MaxResults = _ctx.IntegerValue("ListInstancePatches.MaxResults");
			listInstancePatchesResponse.NextToken = _ctx.StringValue("ListInstancePatches.NextToken");
			listInstancePatchesResponse.RequestId = _ctx.StringValue("ListInstancePatches.RequestId");

			List<ListInstancePatchesResponse.ListInstancePatches_Patch> listInstancePatchesResponse_patches = new List<ListInstancePatchesResponse.ListInstancePatches_Patch>();
			for (int i = 0; i < _ctx.Length("ListInstancePatches.Patches.Length"); i++) {
				ListInstancePatchesResponse.ListInstancePatches_Patch patch = new ListInstancePatchesResponse.ListInstancePatches_Patch();
				patch.Classification = _ctx.StringValue("ListInstancePatches.Patches["+ i +"].Classification");
				patch.InstalledTime = _ctx.StringValue("ListInstancePatches.Patches["+ i +"].InstalledTime");
				patch.KBId = _ctx.StringValue("ListInstancePatches.Patches["+ i +"].KBId");
				patch.Severity = _ctx.StringValue("ListInstancePatches.Patches["+ i +"].Severity");
				patch.Status = _ctx.StringValue("ListInstancePatches.Patches["+ i +"].Status");
				patch.Title = _ctx.StringValue("ListInstancePatches.Patches["+ i +"].Title");

				listInstancePatchesResponse_patches.Add(patch);
			}
			listInstancePatchesResponse.Patches = listInstancePatchesResponse_patches;
        
			return listInstancePatchesResponse;
        }
    }
}
