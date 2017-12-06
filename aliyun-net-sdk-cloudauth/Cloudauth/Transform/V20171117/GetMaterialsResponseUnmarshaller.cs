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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Cloudauth.Model.V20171117;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Cloudauth.Transform.V20171117
{
    public class GetMaterialsResponseUnmarshaller
    {
        public static GetMaterialsResponse Unmarshall(UnmarshallerContext context)
        {
			GetMaterialsResponse getMaterialsResponse = new GetMaterialsResponse();

			getMaterialsResponse.HttpResponse = context.HttpResponse;
			getMaterialsResponse.RequestId = context.StringValue("GetMaterials.RequestId");
			getMaterialsResponse.Success = context.BooleanValue("GetMaterials.Success");
			getMaterialsResponse.Code = context.StringValue("GetMaterials.Code");
			getMaterialsResponse.Message = context.StringValue("GetMaterials.Message");

			GetMaterialsResponse.GetMaterials_Data data = new GetMaterialsResponse.GetMaterials_Data();
			data.Name = context.StringValue("GetMaterials.Data.Name");
			data.IdentificationNumber = context.StringValue("GetMaterials.Data.IdentificationNumber");
			data.IdCardType = context.StringValue("GetMaterials.Data.IdCardType");
			data.IdCardExpiry = context.StringValue("GetMaterials.Data.IdCardExpiry");
			data.Address = context.StringValue("GetMaterials.Data.Address");
			data.Sex = context.StringValue("GetMaterials.Data.Sex");
			data.IdCardFrontPic = context.StringValue("GetMaterials.Data.IdCardFrontPic");
			data.IdCardBackPic = context.StringValue("GetMaterials.Data.IdCardBackPic");
			data.FacePic = context.StringValue("GetMaterials.Data.FacePic");
			getMaterialsResponse.Data = data;
        
			return getMaterialsResponse;
        }
    }
}