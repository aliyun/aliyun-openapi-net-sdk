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
        public static GetParameterResponse Unmarshall(UnmarshallerContext context)
        {
			GetParameterResponse getParameterResponse = new GetParameterResponse();

			getParameterResponse.HttpResponse = context.HttpResponse;
			getParameterResponse.RequestId = context.StringValue("GetParameter.RequestId");

			GetParameterResponse.GetParameter_Parameter parameter = new GetParameterResponse.GetParameter_Parameter();
			parameter.Id = context.StringValue("GetParameter.Parameter.Id");
			parameter.Name = context.StringValue("GetParameter.Parameter.Name");
			parameter.CreatedDate = context.StringValue("GetParameter.Parameter.CreatedDate");
			parameter.CreatedBy = context.StringValue("GetParameter.Parameter.CreatedBy");
			parameter.UpdatedDate = context.StringValue("GetParameter.Parameter.UpdatedDate");
			parameter.UpdatedBy = context.StringValue("GetParameter.Parameter.UpdatedBy");
			parameter.Description = context.StringValue("GetParameter.Parameter.Description");
			parameter.ShareType = context.StringValue("GetParameter.Parameter.ShareType");
			parameter.ParameterVersion = context.IntegerValue("GetParameter.Parameter.ParameterVersion");
			parameter.Type = context.StringValue("GetParameter.Parameter.Type");
			parameter._Value = context.StringValue("GetParameter.Parameter.Value");
			parameter.Constraints = context.StringValue("GetParameter.Parameter.Constraints");
			getParameterResponse.Parameter = parameter;
        
			return getParameterResponse;
        }
    }
}
