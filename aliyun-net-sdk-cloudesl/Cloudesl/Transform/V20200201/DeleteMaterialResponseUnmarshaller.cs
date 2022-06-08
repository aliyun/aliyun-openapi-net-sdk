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
    public class DeleteMaterialResponseUnmarshaller
    {
        public static DeleteMaterialResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DeleteMaterialResponse deleteMaterialResponse = new DeleteMaterialResponse();

			deleteMaterialResponse.HttpResponse = _ctx.HttpResponse;
			deleteMaterialResponse.RequestId = _ctx.StringValue("DeleteMaterial.RequestId");
			deleteMaterialResponse.Success = _ctx.BooleanValue("DeleteMaterial.Success");
			deleteMaterialResponse.Message = _ctx.StringValue("DeleteMaterial.Message");
			deleteMaterialResponse.ErrorCode = _ctx.StringValue("DeleteMaterial.ErrorCode");
			deleteMaterialResponse.ErrorMessage = _ctx.StringValue("DeleteMaterial.ErrorMessage");
			deleteMaterialResponse.Code = _ctx.StringValue("DeleteMaterial.Code");
			deleteMaterialResponse.DynamicCode = _ctx.StringValue("DeleteMaterial.DynamicCode");
			deleteMaterialResponse.DynamicMessage = _ctx.StringValue("DeleteMaterial.DynamicMessage");
        
			return deleteMaterialResponse;
        }
    }
}
