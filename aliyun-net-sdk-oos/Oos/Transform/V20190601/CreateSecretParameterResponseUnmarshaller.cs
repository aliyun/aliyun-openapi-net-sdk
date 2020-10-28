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
        public static CreateSecretParameterResponse Unmarshall(UnmarshallerContext context)
        {
			CreateSecretParameterResponse createSecretParameterResponse = new CreateSecretParameterResponse();

			createSecretParameterResponse.HttpResponse = context.HttpResponse;
			createSecretParameterResponse.RequestId = context.StringValue("CreateSecretParameter.RequestId");

			CreateSecretParameterResponse.CreateSecretParameter_Parameter parameter = new CreateSecretParameterResponse.CreateSecretParameter_Parameter();
			parameter.Id = context.StringValue("CreateSecretParameter.Parameter.Id");
			parameter.Name = context.StringValue("CreateSecretParameter.Parameter.Name");
			parameter.CreatedDate = context.StringValue("CreateSecretParameter.Parameter.CreatedDate");
			parameter.CreatedBy = context.StringValue("CreateSecretParameter.Parameter.CreatedBy");
			parameter.UpdatedDate = context.StringValue("CreateSecretParameter.Parameter.UpdatedDate");
			parameter.UpdatedBy = context.StringValue("CreateSecretParameter.Parameter.UpdatedBy");
			parameter.Description = context.StringValue("CreateSecretParameter.Parameter.Description");
			parameter.ShareType = context.StringValue("CreateSecretParameter.Parameter.ShareType");
			parameter.ParameterVersion = context.IntegerValue("CreateSecretParameter.Parameter.ParameterVersion");
			parameter.Type = context.StringValue("CreateSecretParameter.Parameter.Type");
			parameter.Constraints = context.StringValue("CreateSecretParameter.Parameter.Constraints");
			parameter.KeyId = context.StringValue("CreateSecretParameter.Parameter.KeyId");
			createSecretParameterResponse.Parameter = parameter;
        
			return createSecretParameterResponse;
        }
    }
}
