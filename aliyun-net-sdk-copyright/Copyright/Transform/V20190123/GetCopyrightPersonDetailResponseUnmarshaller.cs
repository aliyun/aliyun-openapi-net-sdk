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
using Aliyun.Acs.Copyright.Model.V20190123;

namespace Aliyun.Acs.Copyright.Transform.V20190123
{
    public class GetCopyrightPersonDetailResponseUnmarshaller
    {
        public static GetCopyrightPersonDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetCopyrightPersonDetailResponse getCopyrightPersonDetailResponse = new GetCopyrightPersonDetailResponse();

			getCopyrightPersonDetailResponse.HttpResponse = _ctx.HttpResponse;
			getCopyrightPersonDetailResponse.RequestId = _ctx.StringValue("GetCopyrightPersonDetail.RequestId");
			getCopyrightPersonDetailResponse.Success = _ctx.BooleanValue("GetCopyrightPersonDetail.Success");

			GetCopyrightPersonDetailResponse.GetCopyrightPersonDetail_Data data = new GetCopyrightPersonDetailResponse.GetCopyrightPersonDetail_Data();
			data.Address = _ctx.StringValue("GetCopyrightPersonDetail.Data.Address");
			data.CardNum = _ctx.StringValue("GetCopyrightPersonDetail.Data.CardNum");
			data.CardType = _ctx.StringValue("GetCopyrightPersonDetail.Data.CardType");
			data.City = _ctx.StringValue("GetCopyrightPersonDetail.Data.City");
			data.County = _ctx.StringValue("GetCopyrightPersonDetail.Data.County");
			data.Email = _ctx.StringValue("GetCopyrightPersonDetail.Data.Email");
			data.EnterpriseLicensePath = _ctx.StringValue("GetCopyrightPersonDetail.Data.EnterpriseLicensePath");
			data.EnterprisePark = _ctx.StringValue("GetCopyrightPersonDetail.Data.EnterprisePark");
			data.EnterpriseTime = _ctx.StringValue("GetCopyrightPersonDetail.Data.EnterpriseTime");
			data.EnterpriseType = _ctx.StringValue("GetCopyrightPersonDetail.Data.EnterpriseType");
			data.IdBackImage = _ctx.StringValue("GetCopyrightPersonDetail.Data.IdBackImage");
			data.IdFrontImage = _ctx.StringValue("GetCopyrightPersonDetail.Data.IdFrontImage");
			data.IdHandedImage = _ctx.StringValue("GetCopyrightPersonDetail.Data.IdHandedImage");
			data.LegalPersonType = _ctx.StringValue("GetCopyrightPersonDetail.Data.LegalPersonType");
			data.Name = _ctx.StringValue("GetCopyrightPersonDetail.Data.Name");
			data.OwnerType = _ctx.IntegerValue("GetCopyrightPersonDetail.Data.OwnerType");
			data.PersonId = _ctx.StringValue("GetCopyrightPersonDetail.Data.PersonId");
			data.Phone = _ctx.StringValue("GetCopyrightPersonDetail.Data.Phone");
			data.Province = _ctx.StringValue("GetCopyrightPersonDetail.Data.Province");
			data.RoleType = _ctx.IntegerValue("GetCopyrightPersonDetail.Data.RoleType");
			data.UserPk = _ctx.StringValue("GetCopyrightPersonDetail.Data.UserPk");
			data.UseType = _ctx.IntegerValue("GetCopyrightPersonDetail.Data.UseType");
			data.AuditStatus = _ctx.IntegerValue("GetCopyrightPersonDetail.Data.AuditStatus");
			data.ExpiredDate = _ctx.StringValue("GetCopyrightPersonDetail.Data.ExpiredDate");
			getCopyrightPersonDetailResponse.Data = data;
        
			return getCopyrightPersonDetailResponse;
        }
    }
}
