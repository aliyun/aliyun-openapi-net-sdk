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
        public static VerifyMaterialResponse Unmarshall(UnmarshallerContext context)
        {
			VerifyMaterialResponse verifyMaterialResponse = new VerifyMaterialResponse();

			verifyMaterialResponse.HttpResponse = context.HttpResponse;
			verifyMaterialResponse.RequestId = context.StringValue("VerifyMaterial.RequestId");
			verifyMaterialResponse.VerifyToken = context.StringValue("VerifyMaterial.VerifyToken");
			verifyMaterialResponse.VerifyStatus = context.IntegerValue("VerifyMaterial.VerifyStatus");
			verifyMaterialResponse.AuthorityComparisionScore = context.FloatValue("VerifyMaterial.AuthorityComparisionScore");
			verifyMaterialResponse.IdCardFaceComparisonScore = context.FloatValue("VerifyMaterial.IdCardFaceComparisonScore");

			VerifyMaterialResponse.VerifyMaterial_Material material = new VerifyMaterialResponse.VerifyMaterial_Material();
			material.FaceImageUrl = context.StringValue("VerifyMaterial.Material.FaceImageUrl");
			material.IdCardName = context.StringValue("VerifyMaterial.Material.IdCardName");
			material.IdCardNumber = context.StringValue("VerifyMaterial.Material.IdCardNumber");
			material.FaceQuality = context.StringValue("VerifyMaterial.Material.FaceQuality");
			material.FaceGlobalUrl = context.StringValue("VerifyMaterial.Material.FaceGlobalUrl");
			material.FaceMask = context.StringValue("VerifyMaterial.Material.FaceMask");

			VerifyMaterialResponse.VerifyMaterial_Material.VerifyMaterial_IdCardInfo idCardInfo = new VerifyMaterialResponse.VerifyMaterial_Material.VerifyMaterial_IdCardInfo();
			idCardInfo.Number = context.StringValue("VerifyMaterial.Material.IdCardInfo.Number");
			idCardInfo.Address = context.StringValue("VerifyMaterial.Material.IdCardInfo.Address");
			idCardInfo.Nationality = context.StringValue("VerifyMaterial.Material.IdCardInfo.Nationality");
			idCardInfo.EndDate = context.StringValue("VerifyMaterial.Material.IdCardInfo.EndDate");
			idCardInfo.FrontImageUrl = context.StringValue("VerifyMaterial.Material.IdCardInfo.FrontImageUrl");
			idCardInfo.Authority = context.StringValue("VerifyMaterial.Material.IdCardInfo.Authority");
			idCardInfo.Sex = context.StringValue("VerifyMaterial.Material.IdCardInfo.Sex");
			idCardInfo.Name = context.StringValue("VerifyMaterial.Material.IdCardInfo.Name");
			idCardInfo.Birth = context.StringValue("VerifyMaterial.Material.IdCardInfo.Birth");
			idCardInfo.BackImageUrl = context.StringValue("VerifyMaterial.Material.IdCardInfo.BackImageUrl");
			idCardInfo.StartDate = context.StringValue("VerifyMaterial.Material.IdCardInfo.StartDate");
			material.IdCardInfo = idCardInfo;
			verifyMaterialResponse.Material = material;
        
			return verifyMaterialResponse;
        }
    }
}
