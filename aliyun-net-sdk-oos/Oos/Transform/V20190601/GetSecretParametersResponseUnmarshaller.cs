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
    public class GetSecretParametersResponseUnmarshaller
    {
        public static GetSecretParametersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetSecretParametersResponse getSecretParametersResponse = new GetSecretParametersResponse();

			getSecretParametersResponse.HttpResponse = _ctx.HttpResponse;
			getSecretParametersResponse.RequestId = _ctx.StringValue("GetSecretParameters.RequestId");

			List<string> getSecretParametersResponse_invalidParameters = new List<string>();
			for (int i = 0; i < _ctx.Length("GetSecretParameters.InvalidParameters.Length"); i++) {
				getSecretParametersResponse_invalidParameters.Add(_ctx.StringValue("GetSecretParameters.InvalidParameters["+ i +"]"));
			}
			getSecretParametersResponse.InvalidParameters = getSecretParametersResponse_invalidParameters;

			List<GetSecretParametersResponse.GetSecretParameters_Parameter> getSecretParametersResponse_parameters = new List<GetSecretParametersResponse.GetSecretParameters_Parameter>();
			for (int i = 0; i < _ctx.Length("GetSecretParameters.Parameters.Length"); i++) {
				GetSecretParametersResponse.GetSecretParameters_Parameter parameter = new GetSecretParametersResponse.GetSecretParameters_Parameter();
				parameter.Id = _ctx.StringValue("GetSecretParameters.Parameters["+ i +"].Id");
				parameter.Name = _ctx.StringValue("GetSecretParameters.Parameters["+ i +"].Name");
				parameter.CreatedDate = _ctx.StringValue("GetSecretParameters.Parameters["+ i +"].CreatedDate");
				parameter.CreatedBy = _ctx.StringValue("GetSecretParameters.Parameters["+ i +"].CreatedBy");
				parameter.UpdatedDate = _ctx.StringValue("GetSecretParameters.Parameters["+ i +"].UpdatedDate");
				parameter.UpdatedBy = _ctx.StringValue("GetSecretParameters.Parameters["+ i +"].UpdatedBy");
				parameter.Description = _ctx.StringValue("GetSecretParameters.Parameters["+ i +"].Description");
				parameter.ShareType = _ctx.StringValue("GetSecretParameters.Parameters["+ i +"].ShareType");
				parameter.ParameterVersion = _ctx.IntegerValue("GetSecretParameters.Parameters["+ i +"].ParameterVersion");
				parameter.Type = _ctx.StringValue("GetSecretParameters.Parameters["+ i +"].Type");
				parameter._Value = _ctx.StringValue("GetSecretParameters.Parameters["+ i +"].Value");
				parameter.Constraints = _ctx.StringValue("GetSecretParameters.Parameters["+ i +"].Constraints");
				parameter.KeyId = _ctx.StringValue("GetSecretParameters.Parameters["+ i +"].KeyId");
				parameter.Tags = _ctx.StringValue("GetSecretParameters.Parameters["+ i +"].Tags");

				getSecretParametersResponse_parameters.Add(parameter);
			}
			getSecretParametersResponse.Parameters = getSecretParametersResponse_parameters;
        
			return getSecretParametersResponse;
        }
    }
}
