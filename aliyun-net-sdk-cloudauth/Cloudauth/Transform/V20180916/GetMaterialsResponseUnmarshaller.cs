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
using Aliyun.Acs.Cloudauth.Model.V20180916;

namespace Aliyun.Acs.Cloudauth.Transform.V20180916
{
    public class GetMaterialsResponseUnmarshaller
    {
        public static GetMaterialsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetMaterialsResponse getMaterialsResponse = new GetMaterialsResponse();

			getMaterialsResponse.HttpResponse = _ctx.HttpResponse;
			getMaterialsResponse.RequestId = _ctx.StringValue("GetMaterials.RequestId");
			getMaterialsResponse.Success = _ctx.BooleanValue("GetMaterials.Success");
			getMaterialsResponse.Code = _ctx.StringValue("GetMaterials.Code");
			getMaterialsResponse.Message = _ctx.StringValue("GetMaterials.Message");

			GetMaterialsResponse.GetMaterials_Data data = new GetMaterialsResponse.GetMaterials_Data();
			data.Name = _ctx.StringValue("GetMaterials.Data.Name");
			data.IdentificationNumber = _ctx.StringValue("GetMaterials.Data.IdentificationNumber");
			data.IdCardType = _ctx.StringValue("GetMaterials.Data.IdCardType");
			data.IdCardStartDate = _ctx.StringValue("GetMaterials.Data.IdCardStartDate");
			data.IdCardExpiry = _ctx.StringValue("GetMaterials.Data.IdCardExpiry");
			data.Address = _ctx.StringValue("GetMaterials.Data.Address");
			data.Sex = _ctx.StringValue("GetMaterials.Data.Sex");
			data.IdCardFrontPic = _ctx.StringValue("GetMaterials.Data.IdCardFrontPic");
			data.IdCardBackPic = _ctx.StringValue("GetMaterials.Data.IdCardBackPic");
			data.FacePic = _ctx.StringValue("GetMaterials.Data.FacePic");
			data.EthnicGroup = _ctx.StringValue("GetMaterials.Data.EthnicGroup");
			data.Authority = _ctx.StringValue("GetMaterials.Data.Authority");
			getMaterialsResponse.Data = data;
        
			return getMaterialsResponse;
        }
    }
}
