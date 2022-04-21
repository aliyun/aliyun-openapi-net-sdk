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
using Aliyun.Acs.Sas.Model.V20181203;

namespace Aliyun.Acs.Sas.Transform.V20181203
{
    public class DescribeFrontVulPatchListResponseUnmarshaller
    {
        public static DescribeFrontVulPatchListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeFrontVulPatchListResponse describeFrontVulPatchListResponse = new DescribeFrontVulPatchListResponse();

			describeFrontVulPatchListResponse.HttpResponse = _ctx.HttpResponse;
			describeFrontVulPatchListResponse.RequestId = _ctx.StringValue("DescribeFrontVulPatchList.RequestId");

			List<DescribeFrontVulPatchListResponse.DescribeFrontVulPatchList_FrontPatch> describeFrontVulPatchListResponse_frontPatchList = new List<DescribeFrontVulPatchListResponse.DescribeFrontVulPatchList_FrontPatch>();
			for (int i = 0; i < _ctx.Length("DescribeFrontVulPatchList.FrontPatchList.Length"); i++) {
				DescribeFrontVulPatchListResponse.DescribeFrontVulPatchList_FrontPatch frontPatch = new DescribeFrontVulPatchListResponse.DescribeFrontVulPatchList_FrontPatch();
				frontPatch.Uuid = _ctx.StringValue("DescribeFrontVulPatchList.FrontPatchList["+ i +"].Uuid");

				List<DescribeFrontVulPatchListResponse.DescribeFrontVulPatchList_FrontPatch.DescribeFrontVulPatchList_Patch> frontPatch_patchList = new List<DescribeFrontVulPatchListResponse.DescribeFrontVulPatchList_FrontPatch.DescribeFrontVulPatchList_Patch>();
				for (int j = 0; j < _ctx.Length("DescribeFrontVulPatchList.FrontPatchList["+ i +"].PatchList.Length"); j++) {
					DescribeFrontVulPatchListResponse.DescribeFrontVulPatchList_FrontPatch.DescribeFrontVulPatchList_Patch patch = new DescribeFrontVulPatchListResponse.DescribeFrontVulPatchList_FrontPatch.DescribeFrontVulPatchList_Patch();
					patch.Name = _ctx.StringValue("DescribeFrontVulPatchList.FrontPatchList["+ i +"].PatchList["+ j +"].Name");
					patch.AliasName = _ctx.StringValue("DescribeFrontVulPatchList.FrontPatchList["+ i +"].PatchList["+ j +"].AliasName");

					frontPatch_patchList.Add(patch);
				}
				frontPatch.PatchList = frontPatch_patchList;

				describeFrontVulPatchListResponse_frontPatchList.Add(frontPatch);
			}
			describeFrontVulPatchListResponse.FrontPatchList = describeFrontVulPatchListResponse_frontPatchList;
        
			return describeFrontVulPatchListResponse;
        }
    }
}
