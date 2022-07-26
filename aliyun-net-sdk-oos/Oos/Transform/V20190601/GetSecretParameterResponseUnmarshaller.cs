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
    public class GetSecretParameterResponseUnmarshaller
    {
        public static GetSecretParameterResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetSecretParameterResponse getSecretParameterResponse = new GetSecretParameterResponse();

			getSecretParameterResponse.HttpResponse = _ctx.HttpResponse;
			getSecretParameterResponse.RequestId = _ctx.StringValue("GetSecretParameter.RequestId");

			GetSecretParameterResponse.GetSecretParameter_Parameter parameter = new GetSecretParameterResponse.GetSecretParameter_Parameter();
			parameter.Type = _ctx.StringValue("GetSecretParameter.Parameter.Type");
			parameter.UpdatedDate = _ctx.StringValue("GetSecretParameter.Parameter.UpdatedDate");
			parameter.UpdatedBy = _ctx.StringValue("GetSecretParameter.Parameter.UpdatedBy");
			parameter.KeyId = _ctx.StringValue("GetSecretParameter.Parameter.KeyId");
			parameter.Tags = _ctx.StringValue("GetSecretParameter.Parameter.Tags");
			parameter._Value = _ctx.StringValue("GetSecretParameter.Parameter.Value");
			parameter.Description = _ctx.StringValue("GetSecretParameter.Parameter.Description");
			parameter.Constraints = _ctx.StringValue("GetSecretParameter.Parameter.Constraints");
			parameter.ResourceGroupId = _ctx.StringValue("GetSecretParameter.Parameter.ResourceGroupId");
			parameter.CreatedBy = _ctx.StringValue("GetSecretParameter.Parameter.CreatedBy");
			parameter.CreatedDate = _ctx.StringValue("GetSecretParameter.Parameter.CreatedDate");
			parameter.ParameterVersion = _ctx.IntegerValue("GetSecretParameter.Parameter.ParameterVersion");
			parameter.Name = _ctx.StringValue("GetSecretParameter.Parameter.Name");
			parameter.Id = _ctx.StringValue("GetSecretParameter.Parameter.Id");
			parameter.ShareType = _ctx.StringValue("GetSecretParameter.Parameter.ShareType");
			getSecretParameterResponse.Parameter = parameter;
        
			return getSecretParameterResponse;
        }
    }
}
