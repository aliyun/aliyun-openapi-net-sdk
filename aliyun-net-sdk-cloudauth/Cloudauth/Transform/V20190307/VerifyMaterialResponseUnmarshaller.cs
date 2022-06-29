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
using Aliyun.Acs.Cloudauth.Model.V20190307;

namespace Aliyun.Acs.Cloudauth.Transform.V20190307
{
    public class VerifyMaterialResponseUnmarshaller
    {
        public static VerifyMaterialResponse Unmarshall(UnmarshallerContext _ctx)
        {
			VerifyMaterialResponse verifyMaterialResponse = new VerifyMaterialResponse();

			verifyMaterialResponse.HttpResponse = _ctx.HttpResponse;
			verifyMaterialResponse.AuthorityComparisionScore = _ctx.FloatValue("VerifyMaterial.AuthorityComparisionScore");
			verifyMaterialResponse.VerifyStatus = _ctx.IntegerValue("VerifyMaterial.VerifyStatus");
			verifyMaterialResponse.RequestId = _ctx.StringValue("VerifyMaterial.RequestId");
			verifyMaterialResponse.VerifyToken = _ctx.StringValue("VerifyMaterial.VerifyToken");
			verifyMaterialResponse.IdCardFaceComparisonScore = _ctx.FloatValue("VerifyMaterial.IdCardFaceComparisonScore");

			VerifyMaterialResponse.VerifyMaterial_Material material = new VerifyMaterialResponse.VerifyMaterial_Material();
			material.IdCardNumber = _ctx.StringValue("VerifyMaterial.Material.IdCardNumber");
			material.FaceGlobalUrl = _ctx.StringValue("VerifyMaterial.Material.FaceGlobalUrl");
			material.FaceImageUrl = _ctx.StringValue("VerifyMaterial.Material.FaceImageUrl");
			material.FaceMask = _ctx.StringValue("VerifyMaterial.Material.FaceMask");
			material.IdCardName = _ctx.StringValue("VerifyMaterial.Material.IdCardName");
			material.FaceQuality = _ctx.StringValue("VerifyMaterial.Material.FaceQuality");

			VerifyMaterialResponse.VerifyMaterial_Material.VerifyMaterial_IdCardInfo idCardInfo = new VerifyMaterialResponse.VerifyMaterial_Material.VerifyMaterial_IdCardInfo();
			idCardInfo.Sex = _ctx.StringValue("VerifyMaterial.Material.IdCardInfo.Sex");
			idCardInfo.EndDate = _ctx.StringValue("VerifyMaterial.Material.IdCardInfo.EndDate");
			idCardInfo.Authority = _ctx.StringValue("VerifyMaterial.Material.IdCardInfo.Authority");
			idCardInfo.Address = _ctx.StringValue("VerifyMaterial.Material.IdCardInfo.Address");
			idCardInfo.Number = _ctx.StringValue("VerifyMaterial.Material.IdCardInfo.Number");
			idCardInfo.StartDate = _ctx.StringValue("VerifyMaterial.Material.IdCardInfo.StartDate");
			idCardInfo.BackImageUrl = _ctx.StringValue("VerifyMaterial.Material.IdCardInfo.BackImageUrl");
			idCardInfo.Nationality = _ctx.StringValue("VerifyMaterial.Material.IdCardInfo.Nationality");
			idCardInfo.Birth = _ctx.StringValue("VerifyMaterial.Material.IdCardInfo.Birth");
			idCardInfo.Name = _ctx.StringValue("VerifyMaterial.Material.IdCardInfo.Name");
			idCardInfo.FrontImageUrl = _ctx.StringValue("VerifyMaterial.Material.IdCardInfo.FrontImageUrl");
			material.IdCardInfo = idCardInfo;
			verifyMaterialResponse.Material = material;
        
			return verifyMaterialResponse;
        }
    }
}
