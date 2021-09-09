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
using Aliyun.Acs.companyreg.Model.V20190508;

namespace Aliyun.Acs.companyreg.Transform.V20190508
{
    public class CheckCompanyRegResponseUnmarshaller
    {
        public static CheckCompanyRegResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CheckCompanyRegResponse checkCompanyRegResponse = new CheckCompanyRegResponse();

			checkCompanyRegResponse.HttpResponse = _ctx.HttpResponse;
			checkCompanyRegResponse.RequestId = _ctx.StringValue("CheckCompanyReg.RequestId");
			checkCompanyRegResponse.MatchCity = _ctx.StringValue("CheckCompanyReg.MatchCity");
			checkCompanyRegResponse.MatchBrand = _ctx.StringValue("CheckCompanyReg.MatchBrand");
			checkCompanyRegResponse.MatchSensitive = _ctx.StringValue("CheckCompanyReg.MatchSensitive");
			checkCompanyRegResponse.Level = _ctx.StringValue("CheckCompanyReg.Level");

			List<CheckCompanyRegResponse.CheckCompanyReg_Company> checkCompanyRegResponse_similarCompanies = new List<CheckCompanyRegResponse.CheckCompanyReg_Company>();
			for (int i = 0; i < _ctx.Length("CheckCompanyReg.SimilarCompanies.Length"); i++) {
				CheckCompanyRegResponse.CheckCompanyReg_Company company = new CheckCompanyRegResponse.CheckCompanyReg_Company();
				company.CompanyName = _ctx.StringValue("CheckCompanyReg.SimilarCompanies["+ i +"].CompanyName");
				company.Level = _ctx.StringValue("CheckCompanyReg.SimilarCompanies["+ i +"].Level");

				checkCompanyRegResponse_similarCompanies.Add(company);
			}
			checkCompanyRegResponse.SimilarCompanies = checkCompanyRegResponse_similarCompanies;
        
			return checkCompanyRegResponse;
        }
    }
}
