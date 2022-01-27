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
using Aliyun.Acs.companyreg.Model.V20201022;

namespace Aliyun.Acs.companyreg.Transform.V20201022
{
    public class GetEnterprisesInfoResponseUnmarshaller
    {
        public static GetEnterprisesInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetEnterprisesInfoResponse getEnterprisesInfoResponse = new GetEnterprisesInfoResponse();

			getEnterprisesInfoResponse.HttpResponse = _ctx.HttpResponse;
			getEnterprisesInfoResponse.RequestId = _ctx.StringValue("GetEnterprisesInfo.RequestId");
			getEnterprisesInfoResponse.EnterpriseName = _ctx.StringValue("GetEnterprisesInfo.EnterpriseName");
			getEnterprisesInfoResponse.TaxNo = _ctx.StringValue("GetEnterprisesInfo.TaxNo");
			getEnterprisesInfoResponse.Corporation = _ctx.StringValue("GetEnterprisesInfo.Corporation");
			getEnterprisesInfoResponse.EstablishDate = _ctx.StringValue("GetEnterprisesInfo.EstablishDate");
			getEnterprisesInfoResponse.EnterpriseType = _ctx.StringValue("GetEnterprisesInfo.EnterpriseType");
			getEnterprisesInfoResponse.RegisteredCapital = _ctx.StringValue("GetEnterprisesInfo.RegisteredCapital");
			getEnterprisesInfoResponse.Address = _ctx.StringValue("GetEnterprisesInfo.Address");
			getEnterprisesInfoResponse.BusinessScope = _ctx.StringValue("GetEnterprisesInfo.BusinessScope");
			getEnterprisesInfoResponse.FromBusinessTerm = _ctx.StringValue("GetEnterprisesInfo.FromBusinessTerm");
			getEnterprisesInfoResponse.ToBusinessTerm = _ctx.StringValue("GetEnterprisesInfo.ToBusinessTerm");
			getEnterprisesInfoResponse.EnterpriseStatus = _ctx.StringValue("GetEnterprisesInfo.EnterpriseStatus");
			getEnterprisesInfoResponse.IndustryCoName = _ctx.StringValue("GetEnterprisesInfo.IndustryCoName");
			getEnterprisesInfoResponse.IndustryCode = _ctx.StringValue("GetEnterprisesInfo.IndustryCode");
			getEnterprisesInfoResponse.EntityType = _ctx.StringValue("GetEnterprisesInfo.EntityType");
			getEnterprisesInfoResponse.AreaName = _ctx.StringValue("GetEnterprisesInfo.AreaName");
			getEnterprisesInfoResponse.RegCityName = _ctx.StringValue("GetEnterprisesInfo.RegCityName");
			getEnterprisesInfoResponse.ChangeDate = _ctx.StringValue("GetEnterprisesInfo.ChangeDate");
        
			return getEnterprisesInfoResponse;
        }
    }
}
