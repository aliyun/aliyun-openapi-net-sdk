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
        public static UpdateSecretParameterResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdateSecretParameterResponse updateSecretParameterResponse = new UpdateSecretParameterResponse();

			updateSecretParameterResponse.HttpResponse = _ctx.HttpResponse;
			updateSecretParameterResponse.RequestId = _ctx.StringValue("UpdateSecretParameter.RequestId");

			UpdateSecretParameterResponse.UpdateSecretParameter_Parameter parameter = new UpdateSecretParameterResponse.UpdateSecretParameter_Parameter();
			parameter.Type = _ctx.StringValue("UpdateSecretParameter.Parameter.Type");
			parameter.UpdatedDate = _ctx.StringValue("UpdateSecretParameter.Parameter.UpdatedDate");
			parameter.UpdatedBy = _ctx.StringValue("UpdateSecretParameter.Parameter.UpdatedBy");
			parameter.KeyId = _ctx.StringValue("UpdateSecretParameter.Parameter.KeyId");
			parameter.Tags = _ctx.StringValue("UpdateSecretParameter.Parameter.Tags");
			parameter.Description = _ctx.StringValue("UpdateSecretParameter.Parameter.Description");
			parameter.Constraints = _ctx.StringValue("UpdateSecretParameter.Parameter.Constraints");
			parameter.ResourceGroupId = _ctx.StringValue("UpdateSecretParameter.Parameter.ResourceGroupId");
			parameter.CreatedBy = _ctx.StringValue("UpdateSecretParameter.Parameter.CreatedBy");
			parameter.CreatedDate = _ctx.StringValue("UpdateSecretParameter.Parameter.CreatedDate");
			parameter.ParameterVersion = _ctx.IntegerValue("UpdateSecretParameter.Parameter.ParameterVersion");
			parameter.Name = _ctx.StringValue("UpdateSecretParameter.Parameter.Name");
			parameter.Id = _ctx.StringValue("UpdateSecretParameter.Parameter.Id");
			parameter.ShareType = _ctx.StringValue("UpdateSecretParameter.Parameter.ShareType");
			updateSecretParameterResponse.Parameter = parameter;
        
			return updateSecretParameterResponse;
        }
    }
}
