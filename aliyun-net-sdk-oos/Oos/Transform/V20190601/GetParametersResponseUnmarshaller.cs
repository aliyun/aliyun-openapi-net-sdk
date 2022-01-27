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
    public class GetParametersResponseUnmarshaller
    {
        public static GetParametersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetParametersResponse getParametersResponse = new GetParametersResponse();

			getParametersResponse.HttpResponse = _ctx.HttpResponse;
			getParametersResponse.RequestId = _ctx.StringValue("GetParameters.RequestId");

			List<string> getParametersResponse_invalidParameters = new List<string>();
			for (int i = 0; i < _ctx.Length("GetParameters.InvalidParameters.Length"); i++) {
				getParametersResponse_invalidParameters.Add(_ctx.StringValue("GetParameters.InvalidParameters["+ i +"]"));
			}
			getParametersResponse.InvalidParameters = getParametersResponse_invalidParameters;

			List<GetParametersResponse.GetParameters_Parameter> getParametersResponse_parameters = new List<GetParametersResponse.GetParameters_Parameter>();
			for (int i = 0; i < _ctx.Length("GetParameters.Parameters.Length"); i++) {
				GetParametersResponse.GetParameters_Parameter parameter = new GetParametersResponse.GetParameters_Parameter();
				parameter.Id = _ctx.StringValue("GetParameters.Parameters["+ i +"].Id");
				parameter.Name = _ctx.StringValue("GetParameters.Parameters["+ i +"].Name");
				parameter.CreatedDate = _ctx.StringValue("GetParameters.Parameters["+ i +"].CreatedDate");
				parameter.CreatedBy = _ctx.StringValue("GetParameters.Parameters["+ i +"].CreatedBy");
				parameter.UpdatedDate = _ctx.StringValue("GetParameters.Parameters["+ i +"].UpdatedDate");
				parameter.UpdatedBy = _ctx.StringValue("GetParameters.Parameters["+ i +"].UpdatedBy");
				parameter.Description = _ctx.StringValue("GetParameters.Parameters["+ i +"].Description");
				parameter.ShareType = _ctx.StringValue("GetParameters.Parameters["+ i +"].ShareType");
				parameter.ParameterVersion = _ctx.IntegerValue("GetParameters.Parameters["+ i +"].ParameterVersion");
				parameter.Type = _ctx.StringValue("GetParameters.Parameters["+ i +"].Type");
				parameter._Value = _ctx.StringValue("GetParameters.Parameters["+ i +"].Value");
				parameter.Constraints = _ctx.StringValue("GetParameters.Parameters["+ i +"].Constraints");
				parameter.Tags = _ctx.StringValue("GetParameters.Parameters["+ i +"].Tags");

				getParametersResponse_parameters.Add(parameter);
			}
			getParametersResponse.Parameters = getParametersResponse_parameters;
        
			return getParametersResponse;
        }
    }
}
