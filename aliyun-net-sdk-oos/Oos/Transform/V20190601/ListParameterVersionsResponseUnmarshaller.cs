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
    public class ListParameterVersionsResponseUnmarshaller
    {
        public static ListParameterVersionsResponse Unmarshall(UnmarshallerContext context)
        {
			ListParameterVersionsResponse listParameterVersionsResponse = new ListParameterVersionsResponse();

			listParameterVersionsResponse.HttpResponse = context.HttpResponse;
			listParameterVersionsResponse.RequestId = context.StringValue("ListParameterVersions.RequestId");
			listParameterVersionsResponse.MaxResults = context.IntegerValue("ListParameterVersions.MaxResults");
			listParameterVersionsResponse.NextToken = context.StringValue("ListParameterVersions.NextToken");
			listParameterVersionsResponse.TotalCount = context.IntegerValue("ListParameterVersions.TotalCount");
			listParameterVersionsResponse.Name = context.StringValue("ListParameterVersions.Name");
			listParameterVersionsResponse.Id = context.StringValue("ListParameterVersions.Id");
			listParameterVersionsResponse.Type = context.StringValue("ListParameterVersions.Type");
			listParameterVersionsResponse.Description = context.StringValue("ListParameterVersions.Description");
			listParameterVersionsResponse.CreatedDate = context.StringValue("ListParameterVersions.CreatedDate");
			listParameterVersionsResponse.CreatedBy = context.StringValue("ListParameterVersions.CreatedBy");

			List<ListParameterVersionsResponse.ListParameterVersions_ParameterVersion> listParameterVersionsResponse_parameterVersions = new List<ListParameterVersionsResponse.ListParameterVersions_ParameterVersion>();
			for (int i = 0; i < context.Length("ListParameterVersions.ParameterVersions.Length"); i++) {
				ListParameterVersionsResponse.ListParameterVersions_ParameterVersion parameterVersion = new ListParameterVersionsResponse.ListParameterVersions_ParameterVersion();
				parameterVersion.UpdatedDate = context.StringValue("ListParameterVersions.ParameterVersions["+ i +"].UpdatedDate");
				parameterVersion.UpdatedBy = context.StringValue("ListParameterVersions.ParameterVersions["+ i +"].UpdatedBy");
				parameterVersion.ParameterVersion = context.IntegerValue("ListParameterVersions.ParameterVersions["+ i +"].ParameterVersion");
				parameterVersion._Value = context.StringValue("ListParameterVersions.ParameterVersions["+ i +"].Value");

				listParameterVersionsResponse_parameterVersions.Add(parameterVersion);
			}
			listParameterVersionsResponse.ParameterVersions = listParameterVersionsResponse_parameterVersions;
        
			return listParameterVersionsResponse;
        }
    }
}
