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
        public static QueryRegistrantProfilesResponse Unmarshall(UnmarshallerContext context)
        {
			QueryRegistrantProfilesResponse queryRegistrantProfilesResponse = new QueryRegistrantProfilesResponse();

			queryRegistrantProfilesResponse.HttpResponse = context.HttpResponse;
			queryRegistrantProfilesResponse.RequestId = context.StringValue("QueryRegistrantProfiles.RequestId");
			queryRegistrantProfilesResponse.TotalItemNum = context.IntegerValue("QueryRegistrantProfiles.TotalItemNum");
			queryRegistrantProfilesResponse.CurrentPageNum = context.IntegerValue("QueryRegistrantProfiles.CurrentPageNum");
			queryRegistrantProfilesResponse.TotalPageNum = context.IntegerValue("QueryRegistrantProfiles.TotalPageNum");
			queryRegistrantProfilesResponse.PageSize = context.IntegerValue("QueryRegistrantProfiles.PageSize");
			queryRegistrantProfilesResponse.PrePage = context.BooleanValue("QueryRegistrantProfiles.PrePage");
			queryRegistrantProfilesResponse.NextPage = context.BooleanValue("QueryRegistrantProfiles.NextPage");

			List<QueryRegistrantProfilesResponse.QueryRegistrantProfiles_RegistrantProfile> queryRegistrantProfilesResponse_registrantProfiles = new List<QueryRegistrantProfilesResponse.QueryRegistrantProfiles_RegistrantProfile>();
			for (int i = 0; i < context.Length("QueryRegistrantProfiles.RegistrantProfiles.Length"); i++) {
				QueryRegistrantProfilesResponse.QueryRegistrantProfiles_RegistrantProfile registrantProfile = new QueryRegistrantProfilesResponse.QueryRegistrantProfiles_RegistrantProfile();
				registrantProfile.RegistrantProfileId = context.LongValue("QueryRegistrantProfiles.RegistrantProfiles["+ i +"].RegistrantProfileId");
				registrantProfile.CreateTime = context.StringValue("QueryRegistrantProfiles.RegistrantProfiles["+ i +"].CreateTime");
				registrantProfile.UpdateTime = context.StringValue("QueryRegistrantProfiles.RegistrantProfiles["+ i +"].UpdateTime");
				registrantProfile.DefaultRegistrantProfile = context.BooleanValue("QueryRegistrantProfiles.RegistrantProfiles["+ i +"].DefaultRegistrantProfile");
				registrantProfile.RegistrantName = context.StringValue("QueryRegistrantProfiles.RegistrantProfiles["+ i +"].RegistrantName");
				registrantProfile.RegistrantOrganization = context.StringValue("QueryRegistrantProfiles.RegistrantProfiles["+ i +"].RegistrantOrganization");
				registrantProfile.Country = context.StringValue("QueryRegistrantProfiles.RegistrantProfiles["+ i +"].Country");
				registrantProfile.Province = context.StringValue("QueryRegistrantProfiles.RegistrantProfiles["+ i +"].Province");
				registrantProfile.City = context.StringValue("QueryRegistrantProfiles.RegistrantProfiles["+ i +"].City");
				registrantProfile.Address = context.StringValue("QueryRegistrantProfiles.RegistrantProfiles["+ i +"].Address");
				registrantProfile.Email = context.StringValue("QueryRegistrantProfiles.RegistrantProfiles["+ i +"].Email");
				registrantProfile.PostalCode = context.StringValue("QueryRegistrantProfiles.RegistrantProfiles["+ i +"].PostalCode");
				registrantProfile.TelArea = context.StringValue("QueryRegistrantProfiles.RegistrantProfiles["+ i +"].TelArea");
				registrantProfile.Telephone = context.StringValue("QueryRegistrantProfiles.RegistrantProfiles["+ i +"].Telephone");
				registrantProfile.TelExt = context.StringValue("QueryRegistrantProfiles.RegistrantProfiles["+ i +"].TelExt");
				registrantProfile.EmailVerificationStatus = context.IntegerValue("QueryRegistrantProfiles.RegistrantProfiles["+ i +"].EmailVerificationStatus");
				registrantProfile.ZhRegistrantName = context.StringValue("QueryRegistrantProfiles.RegistrantProfiles["+ i +"].ZhRegistrantName");
				registrantProfile.ZhRegistrantOrganization = context.StringValue("QueryRegistrantProfiles.RegistrantProfiles["+ i +"].ZhRegistrantOrganization");
				registrantProfile.ZhProvince = context.StringValue("QueryRegistrantProfiles.RegistrantProfiles["+ i +"].ZhProvince");
				registrantProfile.ZhCity = context.StringValue("QueryRegistrantProfiles.RegistrantProfiles["+ i +"].ZhCity");
				registrantProfile.ZhAddress = context.StringValue("QueryRegistrantProfiles.RegistrantProfiles["+ i +"].ZhAddress");
				registrantProfile.RegistrantType = context.StringValue("QueryRegistrantProfiles.RegistrantProfiles["+ i +"].RegistrantType");
				registrantProfile.RealNameStatus = context.StringValue("QueryRegistrantProfiles.RegistrantProfiles["+ i +"].RealNameStatus");
				registrantProfile.RegistrantProfileType = context.StringValue("QueryRegistrantProfiles.RegistrantProfiles["+ i +"].RegistrantProfileType");

				queryRegistrantProfilesResponse_registrantProfiles.Add(registrantProfile);
			}
			queryRegistrantProfilesResponse.RegistrantProfiles = queryRegistrantProfilesResponse_registrantProfiles;
        
			return queryRegistrantProfilesResponse;
        }
    }
}
