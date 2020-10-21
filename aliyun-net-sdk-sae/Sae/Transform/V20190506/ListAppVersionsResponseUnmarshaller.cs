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
        public static ListAppVersionsResponse Unmarshall(UnmarshallerContext context)
        {
			ListAppVersionsResponse listAppVersionsResponse = new ListAppVersionsResponse();

			listAppVersionsResponse.HttpResponse = context.HttpResponse;
			listAppVersionsResponse.RequestId = context.StringValue("ListAppVersions.RequestId");
			listAppVersionsResponse.Code = context.StringValue("ListAppVersions.Code");
			listAppVersionsResponse.Message = context.StringValue("ListAppVersions.Message");
			listAppVersionsResponse.Success = context.BooleanValue("ListAppVersions.Success");
			listAppVersionsResponse.ErrorCode = context.StringValue("ListAppVersions.ErrorCode");

			List<ListAppVersionsResponse.ListAppVersions_PackageVersionEntity> listAppVersionsResponse_data = new List<ListAppVersionsResponse.ListAppVersions_PackageVersionEntity>();
			for (int i = 0; i < context.Length("ListAppVersions.Data.Length"); i++) {
				ListAppVersionsResponse.ListAppVersions_PackageVersionEntity packageVersionEntity = new ListAppVersionsResponse.ListAppVersions_PackageVersionEntity();
				packageVersionEntity.Id = context.StringValue("ListAppVersions.Data["+ i +"].Id");
				packageVersionEntity.CreateTime = context.StringValue("ListAppVersions.Data["+ i +"].CreateTime");
				packageVersionEntity.WarUrl = context.StringValue("ListAppVersions.Data["+ i +"].WarUrl");
				packageVersionEntity.Type = context.StringValue("ListAppVersions.Data["+ i +"].Type");
				packageVersionEntity.BuildPackageUrl = context.StringValue("ListAppVersions.Data["+ i +"].BuildPackageUrl");

				listAppVersionsResponse_data.Add(packageVersionEntity);
			}
			listAppVersionsResponse.Data = listAppVersionsResponse_data;
        
			return listAppVersionsResponse;
        }
    }
}
