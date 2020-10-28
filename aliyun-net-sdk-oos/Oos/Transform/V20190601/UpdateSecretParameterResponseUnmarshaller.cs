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
    public class UpdateSecretParameterResponseUnmarshaller
    {
        public static UpdateSecretParameterResponse Unmarshall(UnmarshallerContext context)
        {
			UpdateSecretParameterResponse updateSecretParameterResponse = new UpdateSecretParameterResponse();

			updateSecretParameterResponse.HttpResponse = context.HttpResponse;
			updateSecretParameterResponse.RequestId = context.StringValue("UpdateSecretParameter.RequestId");

			UpdateSecretParameterResponse.UpdateSecretParameter_Parameter parameter = new UpdateSecretParameterResponse.UpdateSecretParameter_Parameter();
			parameter.Id = context.StringValue("UpdateSecretParameter.Parameter.Id");
			parameter.Name = context.StringValue("UpdateSecretParameter.Parameter.Name");
			parameter.CreatedDate = context.StringValue("UpdateSecretParameter.Parameter.CreatedDate");
			parameter.CreatedBy = context.StringValue("UpdateSecretParameter.Parameter.CreatedBy");
			parameter.UpdatedDate = context.StringValue("UpdateSecretParameter.Parameter.UpdatedDate");
			parameter.UpdatedBy = context.StringValue("UpdateSecretParameter.Parameter.UpdatedBy");
			parameter.Description = context.StringValue("UpdateSecretParameter.Parameter.Description");
			parameter.ShareType = context.StringValue("UpdateSecretParameter.Parameter.ShareType");
			parameter.ParameterVersion = context.IntegerValue("UpdateSecretParameter.Parameter.ParameterVersion");
			parameter.Type = context.StringValue("UpdateSecretParameter.Parameter.Type");
			parameter.Constraints = context.StringValue("UpdateSecretParameter.Parameter.Constraints");
			parameter.KeyId = context.StringValue("UpdateSecretParameter.Parameter.KeyId");
			updateSecretParameterResponse.Parameter = parameter;
        
			return updateSecretParameterResponse;
        }
    }
}
