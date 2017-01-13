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
using Aliyun.Acs.Domain.Model.V20160511;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Domain.Transform.V20160511
{
    public class QueryContactResponseUnmarshaller
    {
        public static QueryContactResponse Unmarshall(UnmarshallerContext context)
        {
			QueryContactResponse queryContactResponse = new QueryContactResponse();

			queryContactResponse.HttpResponse = context.HttpResponse;
			queryContactResponse.RequestId = context.StringValue("QueryContact.RequestId");
			queryContactResponse.CreateDate = context.StringValue("QueryContact.CreateDate");
			queryContactResponse.UpdateDate = context.StringValue("QueryContact.UpdateDate");
			queryContactResponse.CName = context.StringValue("QueryContact.CName");
			queryContactResponse.EName = context.StringValue("QueryContact.EName");
			queryContactResponse.CCompany = context.StringValue("QueryContact.CCompany");
			queryContactResponse.ECompany = context.StringValue("QueryContact.ECompany");
			queryContactResponse.CCountry = context.StringValue("QueryContact.CCountry");
			queryContactResponse.CProvince = context.StringValue("QueryContact.CProvince");
			queryContactResponse.EProvince = context.StringValue("QueryContact.EProvince");
			queryContactResponse.CCity = context.StringValue("QueryContact.CCity");
			queryContactResponse.ECity = context.StringValue("QueryContact.ECity");
			queryContactResponse.CVenu = context.StringValue("QueryContact.CVenu");
			queryContactResponse.EVenu = context.StringValue("QueryContact.EVenu");
			queryContactResponse.Email = context.StringValue("QueryContact.Email");
			queryContactResponse.TelArea = context.StringValue("QueryContact.TelArea");
			queryContactResponse.PostalCode = context.StringValue("QueryContact.PostalCode");
			queryContactResponse.TelMain = context.StringValue("QueryContact.TelMain");
			queryContactResponse.TelExt = context.StringValue("QueryContact.TelExt");
			queryContactResponse.RegType = context.StringValue("QueryContact.RegType");
        
			return queryContactResponse;
        }
    }
}