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
using Aliyun.Acs.Domain.Model.V20180129;

namespace Aliyun.Acs.Domain.Transform.V20180129
{
    public class QueryContactInfoResponseUnmarshaller
    {
        public static QueryContactInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryContactInfoResponse queryContactInfoResponse = new QueryContactInfoResponse();

			queryContactInfoResponse.HttpResponse = _ctx.HttpResponse;
			queryContactInfoResponse.ZhProvince = _ctx.StringValue("QueryContactInfo.ZhProvince");
			queryContactInfoResponse.Email = _ctx.StringValue("QueryContactInfo.Email");
			queryContactInfoResponse.Telephone = _ctx.StringValue("QueryContactInfo.Telephone");
			queryContactInfoResponse.RequestId = _ctx.StringValue("QueryContactInfo.RequestId");
			queryContactInfoResponse.Address = _ctx.StringValue("QueryContactInfo.Address");
			queryContactInfoResponse.PostalCode = _ctx.StringValue("QueryContactInfo.PostalCode");
			queryContactInfoResponse.ZhRegistrantName = _ctx.StringValue("QueryContactInfo.ZhRegistrantName");
			queryContactInfoResponse.City = _ctx.StringValue("QueryContactInfo.City");
			queryContactInfoResponse.CreateDate = _ctx.StringValue("QueryContactInfo.CreateDate");
			queryContactInfoResponse.Province = _ctx.StringValue("QueryContactInfo.Province");
			queryContactInfoResponse.ZhCity = _ctx.StringValue("QueryContactInfo.ZhCity");
			queryContactInfoResponse.RegistrantName = _ctx.StringValue("QueryContactInfo.RegistrantName");
			queryContactInfoResponse.ZhRegistrantOrganization = _ctx.StringValue("QueryContactInfo.ZhRegistrantOrganization");
			queryContactInfoResponse.Country = _ctx.StringValue("QueryContactInfo.Country");
			queryContactInfoResponse.RegistrantOrganization = _ctx.StringValue("QueryContactInfo.RegistrantOrganization");
			queryContactInfoResponse.TelExt = _ctx.StringValue("QueryContactInfo.TelExt");
			queryContactInfoResponse.TelArea = _ctx.StringValue("QueryContactInfo.TelArea");
			queryContactInfoResponse.ZhAddress = _ctx.StringValue("QueryContactInfo.ZhAddress");
        
			return queryContactInfoResponse;
        }
    }
}
