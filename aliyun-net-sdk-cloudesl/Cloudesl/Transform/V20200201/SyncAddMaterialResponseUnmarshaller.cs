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
    public class SyncAddMaterialResponseUnmarshaller
    {
        public static SyncAddMaterialResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SyncAddMaterialResponse syncAddMaterialResponse = new SyncAddMaterialResponse();

			syncAddMaterialResponse.HttpResponse = _ctx.HttpResponse;
			syncAddMaterialResponse.RequestId = _ctx.StringValue("SyncAddMaterial.RequestId");
			syncAddMaterialResponse.Success = _ctx.BooleanValue("SyncAddMaterial.Success");
			syncAddMaterialResponse.Message = _ctx.StringValue("SyncAddMaterial.Message");
			syncAddMaterialResponse.ErrorCode = _ctx.StringValue("SyncAddMaterial.ErrorCode");
			syncAddMaterialResponse.ErrorMessage = _ctx.StringValue("SyncAddMaterial.ErrorMessage");
			syncAddMaterialResponse.Code = _ctx.StringValue("SyncAddMaterial.Code");
			syncAddMaterialResponse.DynamicCode = _ctx.StringValue("SyncAddMaterial.DynamicCode");
			syncAddMaterialResponse.DynamicMessage = _ctx.StringValue("SyncAddMaterial.DynamicMessage");

			SyncAddMaterialResponse.SyncAddMaterial_Result result = new SyncAddMaterialResponse.SyncAddMaterial_Result();
			result.Success = _ctx.BooleanValue("SyncAddMaterial.Result.Success");
			result.Message = _ctx.StringValue("SyncAddMaterial.Result.Message");
			result.DynamicMessage = _ctx.StringValue("SyncAddMaterial.Result.DynamicMessage");
			result.DynamicCode = _ctx.StringValue("SyncAddMaterial.Result.DynamicCode");
			result.ErrorCode = _ctx.StringValue("SyncAddMaterial.Result.ErrorCode");
			syncAddMaterialResponse.Result = result;
        
			return syncAddMaterialResponse;
        }
    }
}
