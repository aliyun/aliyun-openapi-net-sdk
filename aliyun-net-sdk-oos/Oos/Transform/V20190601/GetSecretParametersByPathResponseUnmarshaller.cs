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
        public static GetSecretParametersByPathResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetSecretParametersByPathResponse getSecretParametersByPathResponse = new GetSecretParametersByPathResponse();

			getSecretParametersByPathResponse.HttpResponse = _ctx.HttpResponse;
			getSecretParametersByPathResponse.RequestId = _ctx.StringValue("GetSecretParametersByPath.RequestId");
			getSecretParametersByPathResponse.NextToken = _ctx.StringValue("GetSecretParametersByPath.NextToken");
			getSecretParametersByPathResponse.MaxResults = _ctx.IntegerValue("GetSecretParametersByPath.MaxResults");
			getSecretParametersByPathResponse.TotalCount = _ctx.IntegerValue("GetSecretParametersByPath.TotalCount");

			List<GetSecretParametersByPathResponse.GetSecretParametersByPath_Parameter> getSecretParametersByPathResponse_parameters = new List<GetSecretParametersByPathResponse.GetSecretParametersByPath_Parameter>();
			for (int i = 0; i < _ctx.Length("GetSecretParametersByPath.Parameters.Length"); i++) {
				GetSecretParametersByPathResponse.GetSecretParametersByPath_Parameter parameter = new GetSecretParametersByPathResponse.GetSecretParametersByPath_Parameter();
				parameter.Id = _ctx.StringValue("GetSecretParametersByPath.Parameters["+ i +"].Id");
				parameter.Name = _ctx.StringValue("GetSecretParametersByPath.Parameters["+ i +"].Name");
				parameter.CreatedDate = _ctx.StringValue("GetSecretParametersByPath.Parameters["+ i +"].CreatedDate");
				parameter.CreatedBy = _ctx.StringValue("GetSecretParametersByPath.Parameters["+ i +"].CreatedBy");
				parameter.UpdatedDate = _ctx.StringValue("GetSecretParametersByPath.Parameters["+ i +"].UpdatedDate");
				parameter.UpdatedBy = _ctx.StringValue("GetSecretParametersByPath.Parameters["+ i +"].UpdatedBy");
				parameter.Description = _ctx.StringValue("GetSecretParametersByPath.Parameters["+ i +"].Description");
				parameter.ShareType = _ctx.StringValue("GetSecretParametersByPath.Parameters["+ i +"].ShareType");
				parameter.ParameterVersion = _ctx.IntegerValue("GetSecretParametersByPath.Parameters["+ i +"].ParameterVersion");
				parameter.Type = _ctx.StringValue("GetSecretParametersByPath.Parameters["+ i +"].Type");
				parameter._Value = _ctx.StringValue("GetSecretParametersByPath.Parameters["+ i +"].Value");
				parameter.Constraints = _ctx.StringValue("GetSecretParametersByPath.Parameters["+ i +"].Constraints");
				parameter.KeyId = _ctx.StringValue("GetSecretParametersByPath.Parameters["+ i +"].KeyId");

				getSecretParametersByPathResponse_parameters.Add(parameter);
			}
			getSecretParametersByPathResponse.Parameters = getSecretParametersByPathResponse_parameters;
        
			return getSecretParametersByPathResponse;
        }
    }
}
