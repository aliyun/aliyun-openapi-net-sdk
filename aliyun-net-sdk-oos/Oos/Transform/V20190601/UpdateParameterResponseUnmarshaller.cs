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
        public static UpdateParameterResponse Unmarshall(UnmarshallerContext context)
        {
			UpdateParameterResponse updateParameterResponse = new UpdateParameterResponse();

			updateParameterResponse.HttpResponse = context.HttpResponse;
			updateParameterResponse.RequestId = context.StringValue("UpdateParameter.RequestId");

			UpdateParameterResponse.UpdateParameter_Parameter parameter = new UpdateParameterResponse.UpdateParameter_Parameter();
			parameter.Id = context.StringValue("UpdateParameter.Parameter.Id");
			parameter.Name = context.StringValue("UpdateParameter.Parameter.Name");
			parameter.CreatedDate = context.StringValue("UpdateParameter.Parameter.CreatedDate");
			parameter.CreatedBy = context.StringValue("UpdateParameter.Parameter.CreatedBy");
			parameter.UpdatedDate = context.StringValue("UpdateParameter.Parameter.UpdatedDate");
			parameter.UpdatedBy = context.StringValue("UpdateParameter.Parameter.UpdatedBy");
			parameter.Description = context.StringValue("UpdateParameter.Parameter.Description");
			parameter.ShareType = context.StringValue("UpdateParameter.Parameter.ShareType");
			parameter.ParameterVersion = context.IntegerValue("UpdateParameter.Parameter.ParameterVersion");
			parameter.Type = context.StringValue("UpdateParameter.Parameter.Type");
			parameter.Constraints = context.StringValue("UpdateParameter.Parameter.Constraints");
			updateParameterResponse.Parameter = parameter;
        
			return updateParameterResponse;
        }
    }
}
