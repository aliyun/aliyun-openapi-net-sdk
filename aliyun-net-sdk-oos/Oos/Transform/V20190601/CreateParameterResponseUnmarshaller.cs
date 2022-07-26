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
    public class CreateParameterResponseUnmarshaller
    {
        public static CreateParameterResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateParameterResponse createParameterResponse = new CreateParameterResponse();

			createParameterResponse.HttpResponse = _ctx.HttpResponse;
			createParameterResponse.RequestId = _ctx.StringValue("CreateParameter.RequestId");

			CreateParameterResponse.CreateParameter_Parameter parameter = new CreateParameterResponse.CreateParameter_Parameter();
			parameter.Type = _ctx.StringValue("CreateParameter.Parameter.Type");
			parameter.UpdatedDate = _ctx.StringValue("CreateParameter.Parameter.UpdatedDate");
			parameter.UpdatedBy = _ctx.StringValue("CreateParameter.Parameter.UpdatedBy");
			parameter.Tags = _ctx.StringValue("CreateParameter.Parameter.Tags");
			parameter.Description = _ctx.StringValue("CreateParameter.Parameter.Description");
			parameter.Constraints = _ctx.StringValue("CreateParameter.Parameter.Constraints");
			parameter.ResourceGroupId = _ctx.StringValue("CreateParameter.Parameter.ResourceGroupId");
			parameter.CreatedBy = _ctx.StringValue("CreateParameter.Parameter.CreatedBy");
			parameter.CreatedDate = _ctx.StringValue("CreateParameter.Parameter.CreatedDate");
			parameter.ParameterVersion = _ctx.IntegerValue("CreateParameter.Parameter.ParameterVersion");
			parameter.Name = _ctx.StringValue("CreateParameter.Parameter.Name");
			parameter.Id = _ctx.StringValue("CreateParameter.Parameter.Id");
			parameter.ShareType = _ctx.StringValue("CreateParameter.Parameter.ShareType");
			createParameterResponse.Parameter = parameter;
        
			return createParameterResponse;
        }
    }
}
