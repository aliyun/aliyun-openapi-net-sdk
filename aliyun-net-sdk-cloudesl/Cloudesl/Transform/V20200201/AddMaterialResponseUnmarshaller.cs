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
using Aliyun.Acs.cloudesl.Model.V20200201;

namespace Aliyun.Acs.cloudesl.Transform.V20200201
{
    public class AddMaterialResponseUnmarshaller
    {
        public static AddMaterialResponse Unmarshall(UnmarshallerContext _ctx)
        {
			AddMaterialResponse addMaterialResponse = new AddMaterialResponse();

			addMaterialResponse.HttpResponse = _ctx.HttpResponse;
			addMaterialResponse.RequestId = _ctx.StringValue("AddMaterial.RequestId");
			addMaterialResponse.Success = _ctx.BooleanValue("AddMaterial.Success");
			addMaterialResponse.Message = _ctx.StringValue("AddMaterial.Message");
			addMaterialResponse.ErrorCode = _ctx.StringValue("AddMaterial.ErrorCode");
			addMaterialResponse.ErrorMessage = _ctx.StringValue("AddMaterial.ErrorMessage");
			addMaterialResponse.Code = _ctx.StringValue("AddMaterial.Code");
			addMaterialResponse.DynamicCode = _ctx.StringValue("AddMaterial.DynamicCode");
			addMaterialResponse.DynamicMessage = _ctx.StringValue("AddMaterial.DynamicMessage");

			AddMaterialResponse.AddMaterial_Result result = new AddMaterialResponse.AddMaterial_Result();
			result.Success = _ctx.BooleanValue("AddMaterial.Result.Success");
			result.Message = _ctx.StringValue("AddMaterial.Result.Message");
			result.DynamicMessage = _ctx.StringValue("AddMaterial.Result.DynamicMessage");
			result.DynamicCode = _ctx.StringValue("AddMaterial.Result.DynamicCode");
			result.ErrorCode = _ctx.StringValue("AddMaterial.Result.ErrorCode");
			addMaterialResponse.Result = result;
        
			return addMaterialResponse;
        }
    }
}
