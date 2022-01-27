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
    public class GetParameterResponseUnmarshaller
    {
        public static GetParameterResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetParameterResponse getParameterResponse = new GetParameterResponse();

			getParameterResponse.HttpResponse = _ctx.HttpResponse;
			getParameterResponse.RequestId = _ctx.StringValue("GetParameter.RequestId");

			GetParameterResponse.GetParameter_Parameter parameter = new GetParameterResponse.GetParameter_Parameter();
			parameter.Id = _ctx.StringValue("GetParameter.Parameter.Id");
			parameter.Name = _ctx.StringValue("GetParameter.Parameter.Name");
			parameter.CreatedDate = _ctx.StringValue("GetParameter.Parameter.CreatedDate");
			parameter.CreatedBy = _ctx.StringValue("GetParameter.Parameter.CreatedBy");
			parameter.UpdatedDate = _ctx.StringValue("GetParameter.Parameter.UpdatedDate");
			parameter.UpdatedBy = _ctx.StringValue("GetParameter.Parameter.UpdatedBy");
			parameter.Description = _ctx.StringValue("GetParameter.Parameter.Description");
			parameter.ShareType = _ctx.StringValue("GetParameter.Parameter.ShareType");
			parameter.ParameterVersion = _ctx.IntegerValue("GetParameter.Parameter.ParameterVersion");
			parameter.Type = _ctx.StringValue("GetParameter.Parameter.Type");
			parameter._Value = _ctx.StringValue("GetParameter.Parameter.Value");
			parameter.Constraints = _ctx.StringValue("GetParameter.Parameter.Constraints");
			parameter.Tags = _ctx.StringValue("GetParameter.Parameter.Tags");
			getParameterResponse.Parameter = parameter;
        
			return getParameterResponse;
        }
    }
}
