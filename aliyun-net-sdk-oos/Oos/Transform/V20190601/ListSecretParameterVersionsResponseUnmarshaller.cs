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
        public static ListSecretParameterVersionsResponse Unmarshall(UnmarshallerContext context)
        {
			ListSecretParameterVersionsResponse listSecretParameterVersionsResponse = new ListSecretParameterVersionsResponse();

			listSecretParameterVersionsResponse.HttpResponse = context.HttpResponse;
			listSecretParameterVersionsResponse.RequestId = context.StringValue("ListSecretParameterVersions.RequestId");
			listSecretParameterVersionsResponse.MaxResults = context.IntegerValue("ListSecretParameterVersions.MaxResults");
			listSecretParameterVersionsResponse.NextToken = context.StringValue("ListSecretParameterVersions.NextToken");
			listSecretParameterVersionsResponse.TotalCount = context.IntegerValue("ListSecretParameterVersions.TotalCount");
			listSecretParameterVersionsResponse.Name = context.StringValue("ListSecretParameterVersions.Name");
			listSecretParameterVersionsResponse.Id = context.StringValue("ListSecretParameterVersions.Id");
			listSecretParameterVersionsResponse.Type = context.StringValue("ListSecretParameterVersions.Type");
			listSecretParameterVersionsResponse.Description = context.StringValue("ListSecretParameterVersions.Description");
			listSecretParameterVersionsResponse.CreatedDate = context.StringValue("ListSecretParameterVersions.CreatedDate");
			listSecretParameterVersionsResponse.CreatedBy = context.StringValue("ListSecretParameterVersions.CreatedBy");

			List<ListSecretParameterVersionsResponse.ListSecretParameterVersions_ParameterVersion> listSecretParameterVersionsResponse_parameterVersions = new List<ListSecretParameterVersionsResponse.ListSecretParameterVersions_ParameterVersion>();
			for (int i = 0; i < context.Length("ListSecretParameterVersions.ParameterVersions.Length"); i++) {
				ListSecretParameterVersionsResponse.ListSecretParameterVersions_ParameterVersion parameterVersion = new ListSecretParameterVersionsResponse.ListSecretParameterVersions_ParameterVersion();
				parameterVersion.UpdatedDate = context.StringValue("ListSecretParameterVersions.ParameterVersions["+ i +"].UpdatedDate");
				parameterVersion.UpdatedBy = context.StringValue("ListSecretParameterVersions.ParameterVersions["+ i +"].UpdatedBy");
				parameterVersion.ParameterVersion = context.IntegerValue("ListSecretParameterVersions.ParameterVersions["+ i +"].ParameterVersion");
				parameterVersion._Value = context.StringValue("ListSecretParameterVersions.ParameterVersions["+ i +"].Value");

				listSecretParameterVersionsResponse_parameterVersions.Add(parameterVersion);
			}
			listSecretParameterVersionsResponse.ParameterVersions = listSecretParameterVersionsResponse_parameterVersions;
        
			return listSecretParameterVersionsResponse;
        }
    }
}
