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
    public class QueryRegistrantProfilesResponseUnmarshaller
    {
        public static QueryRegistrantProfilesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryRegistrantProfilesResponse queryRegistrantProfilesResponse = new QueryRegistrantProfilesResponse();

			queryRegistrantProfilesResponse.HttpResponse = _ctx.HttpResponse;
			queryRegistrantProfilesResponse.NextPage = _ctx.BooleanValue("QueryRegistrantProfiles.NextPage");
			queryRegistrantProfilesResponse.RequestId = _ctx.StringValue("QueryRegistrantProfiles.RequestId");
			queryRegistrantProfilesResponse.TotalItemNum = _ctx.IntegerValue("QueryRegistrantProfiles.TotalItemNum");
			queryRegistrantProfilesResponse.PrePage = _ctx.BooleanValue("QueryRegistrantProfiles.PrePage");
			queryRegistrantProfilesResponse.CurrentPageNum = _ctx.IntegerValue("QueryRegistrantProfiles.CurrentPageNum");
			queryRegistrantProfilesResponse.TotalPageNum = _ctx.IntegerValue("QueryRegistrantProfiles.TotalPageNum");
			queryRegistrantProfilesResponse.PageSize = _ctx.IntegerValue("QueryRegistrantProfiles.PageSize");

			List<QueryRegistrantProfilesResponse.QueryRegistrantProfiles_RegistrantProfile> queryRegistrantProfilesResponse_registrantProfiles = new List<QueryRegistrantProfilesResponse.QueryRegistrantProfiles_RegistrantProfile>();
			for (int i = 0; i < _ctx.Length("QueryRegistrantProfiles.RegistrantProfiles.Length"); i++) {
				QueryRegistrantProfilesResponse.QueryRegistrantProfiles_RegistrantProfile registrantProfile = new QueryRegistrantProfilesResponse.QueryRegistrantProfiles_RegistrantProfile();
				registrantProfile.TelExt = _ctx.StringValue("QueryRegistrantProfiles.RegistrantProfiles["+ i +"].TelExt");
				registrantProfile.UpdateTime = _ctx.StringValue("QueryRegistrantProfiles.RegistrantProfiles["+ i +"].UpdateTime");
				registrantProfile.ZhProvince = _ctx.StringValue("QueryRegistrantProfiles.RegistrantProfiles["+ i +"].ZhProvince");
				registrantProfile.CreateTime = _ctx.StringValue("QueryRegistrantProfiles.RegistrantProfiles["+ i +"].CreateTime");
				registrantProfile.Telephone = _ctx.StringValue("QueryRegistrantProfiles.RegistrantProfiles["+ i +"].Telephone");
				registrantProfile.RegistrantOrganization = _ctx.StringValue("QueryRegistrantProfiles.RegistrantProfiles["+ i +"].RegistrantOrganization");
				registrantProfile.City = _ctx.StringValue("QueryRegistrantProfiles.RegistrantProfiles["+ i +"].City");
				registrantProfile.ZhCity = _ctx.StringValue("QueryRegistrantProfiles.RegistrantProfiles["+ i +"].ZhCity");
				registrantProfile.TelArea = _ctx.StringValue("QueryRegistrantProfiles.RegistrantProfiles["+ i +"].TelArea");
				registrantProfile.Address = _ctx.StringValue("QueryRegistrantProfiles.RegistrantProfiles["+ i +"].Address");
				registrantProfile.RealNameStatus = _ctx.StringValue("QueryRegistrantProfiles.RegistrantProfiles["+ i +"].RealNameStatus");
				registrantProfile.PostalCode = _ctx.StringValue("QueryRegistrantProfiles.RegistrantProfiles["+ i +"].PostalCode");
				registrantProfile.RegistrantProfileType = _ctx.StringValue("QueryRegistrantProfiles.RegistrantProfiles["+ i +"].RegistrantProfileType");
				registrantProfile.RegistrantProfileId = _ctx.LongValue("QueryRegistrantProfiles.RegistrantProfiles["+ i +"].RegistrantProfileId");
				registrantProfile.ZhRegistrantOrganization = _ctx.StringValue("QueryRegistrantProfiles.RegistrantProfiles["+ i +"].ZhRegistrantOrganization");
				registrantProfile.DefaultRegistrantProfile = _ctx.BooleanValue("QueryRegistrantProfiles.RegistrantProfiles["+ i +"].DefaultRegistrantProfile");
				registrantProfile.Email = _ctx.StringValue("QueryRegistrantProfiles.RegistrantProfiles["+ i +"].Email");
				registrantProfile.ZhRegistrantName = _ctx.StringValue("QueryRegistrantProfiles.RegistrantProfiles["+ i +"].ZhRegistrantName");
				registrantProfile.RegistrantType = _ctx.StringValue("QueryRegistrantProfiles.RegistrantProfiles["+ i +"].RegistrantType");
				registrantProfile.Country = _ctx.StringValue("QueryRegistrantProfiles.RegistrantProfiles["+ i +"].Country");
				registrantProfile.RegistrantName = _ctx.StringValue("QueryRegistrantProfiles.RegistrantProfiles["+ i +"].RegistrantName");
				registrantProfile.EmailVerificationStatus = _ctx.IntegerValue("QueryRegistrantProfiles.RegistrantProfiles["+ i +"].EmailVerificationStatus");
				registrantProfile.ZhAddress = _ctx.StringValue("QueryRegistrantProfiles.RegistrantProfiles["+ i +"].ZhAddress");
				registrantProfile.Province = _ctx.StringValue("QueryRegistrantProfiles.RegistrantProfiles["+ i +"].Province");

				queryRegistrantProfilesResponse_registrantProfiles.Add(registrantProfile);
			}
			queryRegistrantProfilesResponse.RegistrantProfiles = queryRegistrantProfilesResponse_registrantProfiles;
        
			return queryRegistrantProfilesResponse;
        }
    }
}
