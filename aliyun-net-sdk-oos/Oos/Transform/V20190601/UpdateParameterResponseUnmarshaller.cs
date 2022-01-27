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
    public class UpdateParameterResponseUnmarshaller
    {
        public static UpdateParameterResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdateParameterResponse updateParameterResponse = new UpdateParameterResponse();

			updateParameterResponse.HttpResponse = _ctx.HttpResponse;
			updateParameterResponse.RequestId = _ctx.StringValue("UpdateParameter.RequestId");

			UpdateParameterResponse.UpdateParameter_Parameter parameter = new UpdateParameterResponse.UpdateParameter_Parameter();
			parameter.Id = _ctx.StringValue("UpdateParameter.Parameter.Id");
			parameter.Name = _ctx.StringValue("UpdateParameter.Parameter.Name");
			parameter.CreatedDate = _ctx.StringValue("UpdateParameter.Parameter.CreatedDate");
			parameter.CreatedBy = _ctx.StringValue("UpdateParameter.Parameter.CreatedBy");
			parameter.UpdatedDate = _ctx.StringValue("UpdateParameter.Parameter.UpdatedDate");
			parameter.UpdatedBy = _ctx.StringValue("UpdateParameter.Parameter.UpdatedBy");
			parameter.Description = _ctx.StringValue("UpdateParameter.Parameter.Description");
			parameter.ShareType = _ctx.StringValue("UpdateParameter.Parameter.ShareType");
			parameter.ParameterVersion = _ctx.IntegerValue("UpdateParameter.Parameter.ParameterVersion");
			parameter.Type = _ctx.StringValue("UpdateParameter.Parameter.Type");
			parameter.Constraints = _ctx.StringValue("UpdateParameter.Parameter.Constraints");
			parameter.Tags = _ctx.StringValue("UpdateParameter.Parameter.Tags");
			updateParameterResponse.Parameter = parameter;
        
			return updateParameterResponse;
        }
    }
}
