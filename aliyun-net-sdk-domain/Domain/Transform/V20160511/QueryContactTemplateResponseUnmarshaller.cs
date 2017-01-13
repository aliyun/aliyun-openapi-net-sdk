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
    public class QueryContactTemplateResponseUnmarshaller
    {
        public static QueryContactTemplateResponse Unmarshall(UnmarshallerContext context)
        {
			QueryContactTemplateResponse queryContactTemplateResponse = new QueryContactTemplateResponse();

			queryContactTemplateResponse.HttpResponse = context.HttpResponse;
			queryContactTemplateResponse.RequestId = context.StringValue("QueryContactTemplate.RequestId");

			List<QueryContactTemplateResponse.ContactTemplate> contactTemplates = new List<QueryContactTemplateResponse.ContactTemplate>();
			for (int i = 0; i < context.Length("QueryContactTemplate.ContactTemplates.Length"); i++) {
				QueryContactTemplateResponse.ContactTemplate contactTemplate = new QueryContactTemplateResponse.ContactTemplate();
				contactTemplate.ContactTemplateId = context.LongValue("QueryContactTemplate.ContactTemplates["+ i +"].ContactTemplateId");
				contactTemplate.CreateTime = context.StringValue("QueryContactTemplate.ContactTemplates["+ i +"].CreateTime");
				contactTemplate.UpdateTime = context.StringValue("QueryContactTemplate.ContactTemplates["+ i +"].UpdateTime");
				contactTemplate.UserId = context.StringValue("QueryContactTemplate.ContactTemplates["+ i +"].UserId");
				contactTemplate.RegType = context.StringValue("QueryContactTemplate.ContactTemplates["+ i +"].RegType");
				contactTemplate.DefaultTemplate = context.BooleanValue("QueryContactTemplate.ContactTemplates["+ i +"].DefaultTemplate");
				contactTemplate.AuditStatus = context.StringValue("QueryContactTemplate.ContactTemplates["+ i +"].AuditStatus");
				contactTemplate.CName = context.StringValue("QueryContactTemplate.ContactTemplates["+ i +"].CName");
				contactTemplate.EName = context.StringValue("QueryContactTemplate.ContactTemplates["+ i +"].EName");
				contactTemplate.CCompany = context.StringValue("QueryContactTemplate.ContactTemplates["+ i +"].CCompany");
				contactTemplate.ECompany = context.StringValue("QueryContactTemplate.ContactTemplates["+ i +"].ECompany");
				contactTemplate.CCountry = context.StringValue("QueryContactTemplate.ContactTemplates["+ i +"].CCountry");
				contactTemplate.CProvince = context.StringValue("QueryContactTemplate.ContactTemplates["+ i +"].CProvince");
				contactTemplate.EProvince = context.StringValue("QueryContactTemplate.ContactTemplates["+ i +"].EProvince");
				contactTemplate.CCity = context.StringValue("QueryContactTemplate.ContactTemplates["+ i +"].CCity");
				contactTemplate.ECity = context.StringValue("QueryContactTemplate.ContactTemplates["+ i +"].ECity");
				contactTemplate.CVenu = context.StringValue("QueryContactTemplate.ContactTemplates["+ i +"].CVenu");
				contactTemplate.EVenu = context.StringValue("QueryContactTemplate.ContactTemplates["+ i +"].EVenu");
				contactTemplate.Email = context.StringValue("QueryContactTemplate.ContactTemplates["+ i +"].Email");
				contactTemplate.TelArea = context.StringValue("QueryContactTemplate.ContactTemplates["+ i +"].TelArea");
				contactTemplate.PostalCode = context.StringValue("QueryContactTemplate.ContactTemplates["+ i +"].PostalCode");
				contactTemplate.TelMain = context.StringValue("QueryContactTemplate.ContactTemplates["+ i +"].TelMain");
				contactTemplate.TelExt = context.StringValue("QueryContactTemplate.ContactTemplates["+ i +"].TelExt");

				contactTemplates.Add(contactTemplate);
			}
			queryContactTemplateResponse.ContactTemplates = contactTemplates;
        
			return queryContactTemplateResponse;
        }
    }
}