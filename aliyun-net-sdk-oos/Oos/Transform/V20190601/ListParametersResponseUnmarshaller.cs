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
    public class ListParametersResponseUnmarshaller
    {
        public static ListParametersResponse Unmarshall(UnmarshallerContext context)
        {
			ListParametersResponse listParametersResponse = new ListParametersResponse();

			listParametersResponse.HttpResponse = context.HttpResponse;
			listParametersResponse.RequestId = context.StringValue("ListParameters.RequestId");
			listParametersResponse.MaxResults = context.IntegerValue("ListParameters.MaxResults");
			listParametersResponse.NextToken = context.StringValue("ListParameters.NextToken");
			listParametersResponse.TotalCount = context.IntegerValue("ListParameters.TotalCount");

			List<ListParametersResponse.ListParameters_Parameter> listParametersResponse_parameters = new List<ListParametersResponse.ListParameters_Parameter>();
			for (int i = 0; i < context.Length("ListParameters.Parameters.Length"); i++) {
				ListParametersResponse.ListParameters_Parameter parameter = new ListParametersResponse.ListParameters_Parameter();
				parameter.Name = context.StringValue("ListParameters.Parameters["+ i +"].Name");
				parameter.Id = context.StringValue("ListParameters.Parameters["+ i +"].Id");
				parameter.CreatedDate = context.StringValue("ListParameters.Parameters["+ i +"].CreatedDate");
				parameter.CreatedBy = context.StringValue("ListParameters.Parameters["+ i +"].CreatedBy");
				parameter.UpdatedDate = context.StringValue("ListParameters.Parameters["+ i +"].UpdatedDate");
				parameter.UpdatedBy = context.StringValue("ListParameters.Parameters["+ i +"].UpdatedBy");
				parameter.Description = context.StringValue("ListParameters.Parameters["+ i +"].Description");
				parameter.ShareType = context.StringValue("ListParameters.Parameters["+ i +"].ShareType");
				parameter.ParameterVersion = context.StringValue("ListParameters.Parameters["+ i +"].ParameterVersion");
				parameter.Type = context.StringValue("ListParameters.Parameters["+ i +"].Type");

				listParametersResponse_parameters.Add(parameter);
			}
			listParametersResponse.Parameters = listParametersResponse_parameters;
        
			return listParametersResponse;
        }
    }
}
