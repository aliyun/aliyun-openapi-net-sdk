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
using Aliyun.Acs.Trademark.Model.V20180724;

namespace Aliyun.Acs.Trademark.Transform.V20180724
{
    public class QueryMaterialResponseUnmarshaller
    {
        public static QueryMaterialResponse Unmarshall(UnmarshallerContext context)
        {
			QueryMaterialResponse queryMaterialResponse = new QueryMaterialResponse();

			queryMaterialResponse.HttpResponse = context.HttpResponse;
			queryMaterialResponse.RequestId = context.StringValue("QueryMaterial.RequestId");
			queryMaterialResponse.Type = context.IntegerValue("QueryMaterial.Type");
			queryMaterialResponse.Region = context.IntegerValue("QueryMaterial.Region");
			queryMaterialResponse.ContactName = context.StringValue("QueryMaterial.ContactName");
			queryMaterialResponse.ContactNumber = context.StringValue("QueryMaterial.ContactNumber");
			queryMaterialResponse.ContactEmail = context.StringValue("QueryMaterial.ContactEmail");
			queryMaterialResponse.ContactAddress = context.StringValue("QueryMaterial.ContactAddress");
			queryMaterialResponse.ContactZipcode = context.StringValue("QueryMaterial.ContactZipcode");
			queryMaterialResponse.Status = context.IntegerValue("QueryMaterial.Status");
			queryMaterialResponse.LoaUrl = context.StringValue("QueryMaterial.LoaUrl");
			queryMaterialResponse.Name = context.StringValue("QueryMaterial.Name");
			queryMaterialResponse.CardNumber = context.StringValue("QueryMaterial.CardNumber");
			queryMaterialResponse.ExpirationDate = context.LongValue("QueryMaterial.ExpirationDate");
			queryMaterialResponse.Province = context.StringValue("QueryMaterial.Province");
			queryMaterialResponse.City = context.StringValue("QueryMaterial.City");
			queryMaterialResponse.Town = context.StringValue("QueryMaterial.Town");
			queryMaterialResponse.Address = context.StringValue("QueryMaterial.Address");
			queryMaterialResponse.EName = context.StringValue("QueryMaterial.EName");
			queryMaterialResponse.EAddress = context.StringValue("QueryMaterial.EAddress");
			queryMaterialResponse.LoaStatus = context.IntegerValue("QueryMaterial.LoaStatus");
			queryMaterialResponse.IdCardUrl = context.StringValue("QueryMaterial.IdCardUrl");
			queryMaterialResponse.BusinessLicenceUrl = context.StringValue("QueryMaterial.BusinessLicenceUrl");
			queryMaterialResponse.PassportUrl = context.StringValue("QueryMaterial.PassportUrl");
			queryMaterialResponse.Id = context.LongValue("QueryMaterial.Id");
			queryMaterialResponse.LegalNoticeUrl = context.StringValue("QueryMaterial.LegalNoticeUrl");
			queryMaterialResponse.Note = context.StringValue("QueryMaterial.Note");
			queryMaterialResponse.Country = context.StringValue("QueryMaterial.Country");
			queryMaterialResponse.ReviewApplicationFile = context.StringValue("QueryMaterial.ReviewApplicationFile");
			queryMaterialResponse.PrincipalName = context.IntegerValue("QueryMaterial.PrincipalName");
			queryMaterialResponse.ValidDate = context.LongValue("QueryMaterial.ValidDate");

			List<string> queryMaterialResponse_reviewAdditionalFiles = new List<string>();
			for (int i = 0; i < context.Length("QueryMaterial.ReviewAdditionalFiles.Length"); i++) {
				queryMaterialResponse_reviewAdditionalFiles.Add(context.StringValue("QueryMaterial.ReviewAdditionalFiles["+ i +"]"));
			}
			queryMaterialResponse.ReviewAdditionalFiles = queryMaterialResponse_reviewAdditionalFiles;
        
			return queryMaterialResponse;
        }
    }
}
