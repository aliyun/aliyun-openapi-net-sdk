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
    public class GetSecretParametersByPathResponseUnmarshaller
    {
        public static GetSecretParametersByPathResponse Unmarshall(UnmarshallerContext context)
        {
			GetSecretParametersByPathResponse getSecretParametersByPathResponse = new GetSecretParametersByPathResponse();

			getSecretParametersByPathResponse.HttpResponse = context.HttpResponse;
			getSecretParametersByPathResponse.RequestId = context.StringValue("GetSecretParametersByPath.RequestId");
			getSecretParametersByPathResponse.NextToken = context.StringValue("GetSecretParametersByPath.NextToken");
			getSecretParametersByPathResponse.MaxResults = context.IntegerValue("GetSecretParametersByPath.MaxResults");
			getSecretParametersByPathResponse.TotalCount = context.IntegerValue("GetSecretParametersByPath.TotalCount");

			List<GetSecretParametersByPathResponse.GetSecretParametersByPath_Parameter> getSecretParametersByPathResponse_parameters = new List<GetSecretParametersByPathResponse.GetSecretParametersByPath_Parameter>();
			for (int i = 0; i < context.Length("GetSecretParametersByPath.Parameters.Length"); i++) {
				GetSecretParametersByPathResponse.GetSecretParametersByPath_Parameter parameter = new GetSecretParametersByPathResponse.GetSecretParametersByPath_Parameter();
				parameter.Id = context.StringValue("GetSecretParametersByPath.Parameters["+ i +"].Id");
				parameter.Name = context.StringValue("GetSecretParametersByPath.Parameters["+ i +"].Name");
				parameter.CreatedDate = context.StringValue("GetSecretParametersByPath.Parameters["+ i +"].CreatedDate");
				parameter.CreatedBy = context.StringValue("GetSecretParametersByPath.Parameters["+ i +"].CreatedBy");
				parameter.UpdatedDate = context.StringValue("GetSecretParametersByPath.Parameters["+ i +"].UpdatedDate");
				parameter.UpdatedBy = context.StringValue("GetSecretParametersByPath.Parameters["+ i +"].UpdatedBy");
				parameter.Description = context.StringValue("GetSecretParametersByPath.Parameters["+ i +"].Description");
				parameter.ShareType = context.StringValue("GetSecretParametersByPath.Parameters["+ i +"].ShareType");
				parameter.ParameterVersion = context.IntegerValue("GetSecretParametersByPath.Parameters["+ i +"].ParameterVersion");
				parameter.Type = context.StringValue("GetSecretParametersByPath.Parameters["+ i +"].Type");
				parameter._Value = context.StringValue("GetSecretParametersByPath.Parameters["+ i +"].Value");
				parameter.Constraints = context.StringValue("GetSecretParametersByPath.Parameters["+ i +"].Constraints");
				parameter.KeyId = context.StringValue("GetSecretParametersByPath.Parameters["+ i +"].KeyId");

				getSecretParametersByPathResponse_parameters.Add(parameter);
			}
			getSecretParametersByPathResponse.Parameters = getSecretParametersByPathResponse_parameters;
        
			return getSecretParametersByPathResponse;
        }
    }
}
