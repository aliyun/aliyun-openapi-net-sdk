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
    public class GetParametersByPathResponseUnmarshaller
    {
        public static GetParametersByPathResponse Unmarshall(UnmarshallerContext context)
        {
			GetParametersByPathResponse getParametersByPathResponse = new GetParametersByPathResponse();

			getParametersByPathResponse.HttpResponse = context.HttpResponse;
			getParametersByPathResponse.RequestId = context.StringValue("GetParametersByPath.RequestId");
			getParametersByPathResponse.NextToken = context.StringValue("GetParametersByPath.NextToken");
			getParametersByPathResponse.MaxResults = context.IntegerValue("GetParametersByPath.MaxResults");
			getParametersByPathResponse.TotalCount = context.IntegerValue("GetParametersByPath.TotalCount");

			List<GetParametersByPathResponse.GetParametersByPath_Parameter> getParametersByPathResponse_parameters = new List<GetParametersByPathResponse.GetParametersByPath_Parameter>();
			for (int i = 0; i < context.Length("GetParametersByPath.Parameters.Length"); i++) {
				GetParametersByPathResponse.GetParametersByPath_Parameter parameter = new GetParametersByPathResponse.GetParametersByPath_Parameter();
				parameter.Id = context.StringValue("GetParametersByPath.Parameters["+ i +"].Id");
				parameter.Name = context.StringValue("GetParametersByPath.Parameters["+ i +"].Name");
				parameter.CreatedDate = context.StringValue("GetParametersByPath.Parameters["+ i +"].CreatedDate");
				parameter.CreatedBy = context.StringValue("GetParametersByPath.Parameters["+ i +"].CreatedBy");
				parameter.UpdatedDate = context.StringValue("GetParametersByPath.Parameters["+ i +"].UpdatedDate");
				parameter.UpdatedBy = context.StringValue("GetParametersByPath.Parameters["+ i +"].UpdatedBy");
				parameter.Description = context.StringValue("GetParametersByPath.Parameters["+ i +"].Description");
				parameter.ShareType = context.StringValue("GetParametersByPath.Parameters["+ i +"].ShareType");
				parameter.ParameterVersion = context.IntegerValue("GetParametersByPath.Parameters["+ i +"].ParameterVersion");
				parameter.Type = context.StringValue("GetParametersByPath.Parameters["+ i +"].Type");
				parameter._Value = context.StringValue("GetParametersByPath.Parameters["+ i +"].Value");
				parameter.Constraints = context.StringValue("GetParametersByPath.Parameters["+ i +"].Constraints");

				getParametersByPathResponse_parameters.Add(parameter);
			}
			getParametersByPathResponse.Parameters = getParametersByPathResponse_parameters;
        
			return getParametersByPathResponse;
        }
    }
}
