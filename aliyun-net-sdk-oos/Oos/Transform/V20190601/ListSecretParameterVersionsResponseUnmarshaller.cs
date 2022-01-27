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
    public class ListSecretParameterVersionsResponseUnmarshaller
    {
        public static ListSecretParameterVersionsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListSecretParameterVersionsResponse listSecretParameterVersionsResponse = new ListSecretParameterVersionsResponse();

			listSecretParameterVersionsResponse.HttpResponse = _ctx.HttpResponse;
			listSecretParameterVersionsResponse.RequestId = _ctx.StringValue("ListSecretParameterVersions.RequestId");
			listSecretParameterVersionsResponse.MaxResults = _ctx.IntegerValue("ListSecretParameterVersions.MaxResults");
			listSecretParameterVersionsResponse.NextToken = _ctx.StringValue("ListSecretParameterVersions.NextToken");
			listSecretParameterVersionsResponse.TotalCount = _ctx.IntegerValue("ListSecretParameterVersions.TotalCount");
			listSecretParameterVersionsResponse.Name = _ctx.StringValue("ListSecretParameterVersions.Name");
			listSecretParameterVersionsResponse.Id = _ctx.StringValue("ListSecretParameterVersions.Id");
			listSecretParameterVersionsResponse.Type = _ctx.StringValue("ListSecretParameterVersions.Type");
			listSecretParameterVersionsResponse.Description = _ctx.StringValue("ListSecretParameterVersions.Description");
			listSecretParameterVersionsResponse.CreatedDate = _ctx.StringValue("ListSecretParameterVersions.CreatedDate");
			listSecretParameterVersionsResponse.CreatedBy = _ctx.StringValue("ListSecretParameterVersions.CreatedBy");

			List<ListSecretParameterVersionsResponse.ListSecretParameterVersions_ParameterVersion> listSecretParameterVersionsResponse_parameterVersions = new List<ListSecretParameterVersionsResponse.ListSecretParameterVersions_ParameterVersion>();
			for (int i = 0; i < _ctx.Length("ListSecretParameterVersions.ParameterVersions.Length"); i++) {
				ListSecretParameterVersionsResponse.ListSecretParameterVersions_ParameterVersion parameterVersion = new ListSecretParameterVersionsResponse.ListSecretParameterVersions_ParameterVersion();
				parameterVersion.UpdatedDate = _ctx.StringValue("ListSecretParameterVersions.ParameterVersions["+ i +"].UpdatedDate");
				parameterVersion.UpdatedBy = _ctx.StringValue("ListSecretParameterVersions.ParameterVersions["+ i +"].UpdatedBy");
				parameterVersion.ParameterVersion = _ctx.IntegerValue("ListSecretParameterVersions.ParameterVersions["+ i +"].ParameterVersion");
				parameterVersion._Value = _ctx.StringValue("ListSecretParameterVersions.ParameterVersions["+ i +"].Value");

				listSecretParameterVersionsResponse_parameterVersions.Add(parameterVersion);
			}
			listSecretParameterVersionsResponse.ParameterVersions = listSecretParameterVersionsResponse_parameterVersions;
        
			return listSecretParameterVersionsResponse;
        }
    }
}
