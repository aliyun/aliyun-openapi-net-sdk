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
    public class GetItemMaterialResponseUnmarshaller
    {
        public static GetItemMaterialResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetItemMaterialResponse getItemMaterialResponse = new GetItemMaterialResponse();

			getItemMaterialResponse.HttpResponse = _ctx.HttpResponse;
			getItemMaterialResponse.RequestId = _ctx.StringValue("GetItemMaterial.RequestId");
			getItemMaterialResponse.Success = _ctx.BooleanValue("GetItemMaterial.Success");
			getItemMaterialResponse.Message = _ctx.StringValue("GetItemMaterial.Message");
			getItemMaterialResponse.ErrorCode = _ctx.StringValue("GetItemMaterial.ErrorCode");
			getItemMaterialResponse.ErrorMessage = _ctx.StringValue("GetItemMaterial.ErrorMessage");
			getItemMaterialResponse.Code = _ctx.StringValue("GetItemMaterial.Code");
			getItemMaterialResponse.DynamicCode = _ctx.StringValue("GetItemMaterial.DynamicCode");
			getItemMaterialResponse.DynamicMessage = _ctx.StringValue("GetItemMaterial.DynamicMessage");

			GetItemMaterialResponse.GetItemMaterial_MaterialInfo materialInfo = new GetItemMaterialResponse.GetItemMaterial_MaterialInfo();
			materialInfo.ItemName = _ctx.StringValue("GetItemMaterial.MaterialInfo.ItemName");
			materialInfo.BarCode = _ctx.StringValue("GetItemMaterial.MaterialInfo.BarCode");
			materialInfo.GmtCreate = _ctx.StringValue("GetItemMaterial.MaterialInfo.GmtCreate");
			materialInfo.MaterialName = _ctx.StringValue("GetItemMaterial.MaterialInfo.MaterialName");
			materialInfo.MaterialId = _ctx.StringValue("GetItemMaterial.MaterialInfo.MaterialId");
			materialInfo.MaterialFeatureA = _ctx.StringValue("GetItemMaterial.MaterialInfo.MaterialFeatureA");
			materialInfo.MaterialFeatureB = _ctx.StringValue("GetItemMaterial.MaterialInfo.MaterialFeatureB");
			materialInfo.MaterialFeatureC = _ctx.StringValue("GetItemMaterial.MaterialInfo.MaterialFeatureC");
			materialInfo.MaterialFeatureD = _ctx.StringValue("GetItemMaterial.MaterialInfo.MaterialFeatureD");
			getItemMaterialResponse.MaterialInfo = materialInfo;
        
			return getItemMaterialResponse;
        }
    }
}
