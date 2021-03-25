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
using Aliyun.Acs.sae.Model.V20190506;

namespace Aliyun.Acs.sae.Transform.V20190506
{
    public class ListAppVersionsResponseUnmarshaller
    {
        public static ListAppVersionsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListAppVersionsResponse listAppVersionsResponse = new ListAppVersionsResponse();

			listAppVersionsResponse.HttpResponse = _ctx.HttpResponse;
			listAppVersionsResponse.RequestId = _ctx.StringValue("ListAppVersions.RequestId");
			listAppVersionsResponse.Code = _ctx.StringValue("ListAppVersions.Code");
			listAppVersionsResponse.Message = _ctx.StringValue("ListAppVersions.Message");
			listAppVersionsResponse.Success = _ctx.BooleanValue("ListAppVersions.Success");
			listAppVersionsResponse.ErrorCode = _ctx.StringValue("ListAppVersions.ErrorCode");

			List<ListAppVersionsResponse.ListAppVersions_PackageVersionEntity> listAppVersionsResponse_data = new List<ListAppVersionsResponse.ListAppVersions_PackageVersionEntity>();
			for (int i = 0; i < _ctx.Length("ListAppVersions.Data.Length"); i++) {
				ListAppVersionsResponse.ListAppVersions_PackageVersionEntity packageVersionEntity = new ListAppVersionsResponse.ListAppVersions_PackageVersionEntity();
				packageVersionEntity.Id = _ctx.StringValue("ListAppVersions.Data["+ i +"].Id");
				packageVersionEntity.CreateTime = _ctx.StringValue("ListAppVersions.Data["+ i +"].CreateTime");
				packageVersionEntity.WarUrl = _ctx.StringValue("ListAppVersions.Data["+ i +"].WarUrl");
				packageVersionEntity.Type = _ctx.StringValue("ListAppVersions.Data["+ i +"].Type");
				packageVersionEntity.BuildPackageUrl = _ctx.StringValue("ListAppVersions.Data["+ i +"].BuildPackageUrl");

				listAppVersionsResponse_data.Add(packageVersionEntity);
			}
			listAppVersionsResponse.Data = listAppVersionsResponse_data;
        
			return listAppVersionsResponse;
        }
    }
}
