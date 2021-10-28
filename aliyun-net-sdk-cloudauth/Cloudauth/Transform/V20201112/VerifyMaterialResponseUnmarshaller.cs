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
using Aliyun.Acs.Cloudauth.Model.V20201112;

namespace Aliyun.Acs.Cloudauth.Transform.V20201112
{
    public class VerifyMaterialResponseUnmarshaller
    {
        public static VerifyMaterialResponse Unmarshall(UnmarshallerContext _ctx)
        {
			VerifyMaterialResponse verifyMaterialResponse = new VerifyMaterialResponse();

			verifyMaterialResponse.HttpResponse = _ctx.HttpResponse;
			verifyMaterialResponse.RequestId = _ctx.StringValue("VerifyMaterial.RequestId");
			verifyMaterialResponse.Code = _ctx.StringValue("VerifyMaterial.Code");
			verifyMaterialResponse.Message = _ctx.StringValue("VerifyMaterial.Message");
			verifyMaterialResponse.Success = _ctx.BooleanValue("VerifyMaterial.Success");

			VerifyMaterialResponse.VerifyMaterial_ResultObject resultObject = new VerifyMaterialResponse.VerifyMaterial_ResultObject();
			resultObject.VerifyToken = _ctx.StringValue("VerifyMaterial.ResultObject.VerifyToken");
			resultObject.VerifyStatus = _ctx.IntegerValue("VerifyMaterial.ResultObject.VerifyStatus");
			resultObject.AuthorityComparisionScore = _ctx.FloatValue("VerifyMaterial.ResultObject.AuthorityComparisionScore");
			resultObject.IdCardFaceComparisonScore = _ctx.FloatValue("VerifyMaterial.ResultObject.IdCardFaceComparisonScore");

			VerifyMaterialResponse.VerifyMaterial_ResultObject.VerifyMaterial_Material material = new VerifyMaterialResponse.VerifyMaterial_ResultObject.VerifyMaterial_Material();
			material.FaceImageUrl = _ctx.StringValue("VerifyMaterial.ResultObject.Material.FaceImageUrl");
			material.IdCardName = _ctx.StringValue("VerifyMaterial.ResultObject.Material.IdCardName");
			material.IdCardNumber = _ctx.StringValue("VerifyMaterial.ResultObject.Material.IdCardNumber");
			material.FaceQuality = _ctx.StringValue("VerifyMaterial.ResultObject.Material.FaceQuality");
			material.FaceGlobalUrl = _ctx.StringValue("VerifyMaterial.ResultObject.Material.FaceGlobalUrl");
			material.FaceMask = _ctx.StringValue("VerifyMaterial.ResultObject.Material.FaceMask");

			VerifyMaterialResponse.VerifyMaterial_ResultObject.VerifyMaterial_Material.VerifyMaterial_IdCardInfo idCardInfo = new VerifyMaterialResponse.VerifyMaterial_ResultObject.VerifyMaterial_Material.VerifyMaterial_IdCardInfo();
			idCardInfo.Number = _ctx.StringValue("VerifyMaterial.ResultObject.Material.IdCardInfo.Number");
			idCardInfo.Address = _ctx.StringValue("VerifyMaterial.ResultObject.Material.IdCardInfo.Address");
			idCardInfo.Nationality = _ctx.StringValue("VerifyMaterial.ResultObject.Material.IdCardInfo.Nationality");
			idCardInfo.EndDate = _ctx.StringValue("VerifyMaterial.ResultObject.Material.IdCardInfo.EndDate");
			idCardInfo.FrontImageUrl = _ctx.StringValue("VerifyMaterial.ResultObject.Material.IdCardInfo.FrontImageUrl");
			idCardInfo.Authority = _ctx.StringValue("VerifyMaterial.ResultObject.Material.IdCardInfo.Authority");
			idCardInfo.Sex = _ctx.StringValue("VerifyMaterial.ResultObject.Material.IdCardInfo.Sex");
			idCardInfo.Name = _ctx.StringValue("VerifyMaterial.ResultObject.Material.IdCardInfo.Name");
			idCardInfo.Birth = _ctx.StringValue("VerifyMaterial.ResultObject.Material.IdCardInfo.Birth");
			idCardInfo.BackImageUrl = _ctx.StringValue("VerifyMaterial.ResultObject.Material.IdCardInfo.BackImageUrl");
			idCardInfo.StartDate = _ctx.StringValue("VerifyMaterial.ResultObject.Material.IdCardInfo.StartDate");
			material.IdCardInfo = idCardInfo;
			resultObject.Material = material;
			verifyMaterialResponse.ResultObject = resultObject;
        
			return verifyMaterialResponse;
        }
    }
}
