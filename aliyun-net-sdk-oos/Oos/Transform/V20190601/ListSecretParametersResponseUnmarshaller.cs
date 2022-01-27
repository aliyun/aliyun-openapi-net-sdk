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
    public class ListSecretParametersResponseUnmarshaller
    {
        public static ListSecretParametersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListSecretParametersResponse listSecretParametersResponse = new ListSecretParametersResponse();

			listSecretParametersResponse.HttpResponse = _ctx.HttpResponse;
			listSecretParametersResponse.RequestId = _ctx.StringValue("ListSecretParameters.RequestId");
			listSecretParametersResponse.MaxResults = _ctx.IntegerValue("ListSecretParameters.MaxResults");
			listSecretParametersResponse.NextToken = _ctx.StringValue("ListSecretParameters.NextToken");

			List<ListSecretParametersResponse.ListSecretParameters_Parameter> listSecretParametersResponse_parameters = new List<ListSecretParametersResponse.ListSecretParameters_Parameter>();
			for (int i = 0; i < _ctx.Length("ListSecretParameters.Parameters.Length"); i++) {
				ListSecretParametersResponse.ListSecretParameters_Parameter parameter = new ListSecretParametersResponse.ListSecretParameters_Parameter();
				parameter.Name = _ctx.StringValue("ListSecretParameters.Parameters["+ i +"].Name");
				parameter.Id = _ctx.StringValue("ListSecretParameters.Parameters["+ i +"].Id");
				parameter.CreatedDate = _ctx.StringValue("ListSecretParameters.Parameters["+ i +"].CreatedDate");
				parameter.CreatedBy = _ctx.StringValue("ListSecretParameters.Parameters["+ i +"].CreatedBy");
				parameter.UpdatedDate = _ctx.StringValue("ListSecretParameters.Parameters["+ i +"].UpdatedDate");
				parameter.UpdatedBy = _ctx.StringValue("ListSecretParameters.Parameters["+ i +"].UpdatedBy");
				parameter.Description = _ctx.StringValue("ListSecretParameters.Parameters["+ i +"].Description");
				parameter.ShareType = _ctx.StringValue("ListSecretParameters.Parameters["+ i +"].ShareType");
				parameter.ParameterVersion = _ctx.StringValue("ListSecretParameters.Parameters["+ i +"].ParameterVersion");
				parameter.Type = _ctx.StringValue("ListSecretParameters.Parameters["+ i +"].Type");
				parameter.KeyId = _ctx.StringValue("ListSecretParameters.Parameters["+ i +"].KeyId");
				parameter.Tags = _ctx.StringValue("ListSecretParameters.Parameters["+ i +"].Tags");

				listSecretParametersResponse_parameters.Add(parameter);
			}
			listSecretParametersResponse.Parameters = listSecretParametersResponse_parameters;
        
			return listSecretParametersResponse;
        }
    }
}
