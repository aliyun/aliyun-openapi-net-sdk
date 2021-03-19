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
    public class CreateSecretParameterResponseUnmarshaller
    {
        public static CreateSecretParameterResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateSecretParameterResponse createSecretParameterResponse = new CreateSecretParameterResponse();

			createSecretParameterResponse.HttpResponse = _ctx.HttpResponse;
			createSecretParameterResponse.RequestId = _ctx.StringValue("CreateSecretParameter.RequestId");

			CreateSecretParameterResponse.CreateSecretParameter_Parameter parameter = new CreateSecretParameterResponse.CreateSecretParameter_Parameter();
			parameter.Id = _ctx.StringValue("CreateSecretParameter.Parameter.Id");
			parameter.Name = _ctx.StringValue("CreateSecretParameter.Parameter.Name");
			parameter.CreatedDate = _ctx.StringValue("CreateSecretParameter.Parameter.CreatedDate");
			parameter.CreatedBy = _ctx.StringValue("CreateSecretParameter.Parameter.CreatedBy");
			parameter.UpdatedDate = _ctx.StringValue("CreateSecretParameter.Parameter.UpdatedDate");
			parameter.UpdatedBy = _ctx.StringValue("CreateSecretParameter.Parameter.UpdatedBy");
			parameter.Description = _ctx.StringValue("CreateSecretParameter.Parameter.Description");
			parameter.ShareType = _ctx.StringValue("CreateSecretParameter.Parameter.ShareType");
			parameter.ParameterVersion = _ctx.IntegerValue("CreateSecretParameter.Parameter.ParameterVersion");
			parameter.Type = _ctx.StringValue("CreateSecretParameter.Parameter.Type");
			parameter.Constraints = _ctx.StringValue("CreateSecretParameter.Parameter.Constraints");
			parameter.KeyId = _ctx.StringValue("CreateSecretParameter.Parameter.KeyId");
			parameter.Tags = _ctx.StringValue("CreateSecretParameter.Parameter.Tags");
			createSecretParameterResponse.Parameter = parameter;
        
			return createSecretParameterResponse;
        }
    }
}
