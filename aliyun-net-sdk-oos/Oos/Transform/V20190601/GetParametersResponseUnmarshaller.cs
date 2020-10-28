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
        public static GetParametersResponse Unmarshall(UnmarshallerContext context)
        {
			GetParametersResponse getParametersResponse = new GetParametersResponse();

			getParametersResponse.HttpResponse = context.HttpResponse;
			getParametersResponse.RequestId = context.StringValue("GetParameters.RequestId");

			List<string> getParametersResponse_invalidParameters = new List<string>();
			for (int i = 0; i < context.Length("GetParameters.InvalidParameters.Length"); i++) {
				getParametersResponse_invalidParameters.Add(context.StringValue("GetParameters.InvalidParameters["+ i +"]"));
			}
			getParametersResponse.InvalidParameters = getParametersResponse_invalidParameters;

			List<GetParametersResponse.GetParameters_Parameter> getParametersResponse_parameters = new List<GetParametersResponse.GetParameters_Parameter>();
			for (int i = 0; i < context.Length("GetParameters.Parameters.Length"); i++) {
				GetParametersResponse.GetParameters_Parameter parameter = new GetParametersResponse.GetParameters_Parameter();
				parameter.Id = context.StringValue("GetParameters.Parameters["+ i +"].Id");
				parameter.Name = context.StringValue("GetParameters.Parameters["+ i +"].Name");
				parameter.CreatedDate = context.StringValue("GetParameters.Parameters["+ i +"].CreatedDate");
				parameter.CreatedBy = context.StringValue("GetParameters.Parameters["+ i +"].CreatedBy");
				parameter.UpdatedDate = context.StringValue("GetParameters.Parameters["+ i +"].UpdatedDate");
				parameter.UpdatedBy = context.StringValue("GetParameters.Parameters["+ i +"].UpdatedBy");
				parameter.Description = context.StringValue("GetParameters.Parameters["+ i +"].Description");
				parameter.ShareType = context.StringValue("GetParameters.Parameters["+ i +"].ShareType");
				parameter.ParameterVersion = context.IntegerValue("GetParameters.Parameters["+ i +"].ParameterVersion");
				parameter.Type = context.StringValue("GetParameters.Parameters["+ i +"].Type");
				parameter._Value = context.StringValue("GetParameters.Parameters["+ i +"].Value");
				parameter.Constraints = context.StringValue("GetParameters.Parameters["+ i +"].Constraints");

				getParametersResponse_parameters.Add(parameter);
			}
			getParametersResponse.Parameters = getParametersResponse_parameters;
        
			return getParametersResponse;
        }
    }
}
