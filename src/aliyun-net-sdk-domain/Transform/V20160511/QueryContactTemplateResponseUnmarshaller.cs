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
using System.Collections.Generic;

namespace Aliyun.Acs.Domain.Transform.V20160511
{
    public class QueryContactTemplateResponseUnmarshaller
    {
        public static QueryContactTemplateResponse Unmarshall(UnmarshallerContext context)
        {
            QueryContactTemplateResponse queryContactTemplateResponse = new QueryContactTemplateResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("QueryContactTemplate.RequestId")
            };
            List<QueryContactTemplateResponse.ContactTemplate> contactTemplates = new List<QueryContactTemplateResponse.ContactTemplate>();
			for (int i = 0; i < context.Length("QueryContactTemplate.ContactTemplates.Length"); i++) {
                QueryContactTemplateResponse.ContactTemplate contactTemplate = new QueryContactTemplateResponse.ContactTemplate()
                {
                    ContactTemplateId = context.LongValue($"QueryContactTemplate.ContactTemplates[{i}].ContactTemplateId"),
                    CreateTime = context.StringValue($"QueryContactTemplate.ContactTemplates[{i}].CreateTime"),
                    UpdateTime = context.StringValue($"QueryContactTemplate.ContactTemplates[{i}].UpdateTime"),
                    UserId = context.StringValue($"QueryContactTemplate.ContactTemplates[{i}].UserId"),
                    RegType = context.StringValue($"QueryContactTemplate.ContactTemplates[{i}].RegType"),
                    DefaultTemplate = context.BooleanValue($"QueryContactTemplate.ContactTemplates[{i}].DefaultTemplate"),
                    AuditStatus = context.StringValue($"QueryContactTemplate.ContactTemplates[{i}].AuditStatus"),
                    CName = context.StringValue($"QueryContactTemplate.ContactTemplates[{i}].CName"),
                    EName = context.StringValue($"QueryContactTemplate.ContactTemplates[{i}].EName"),
                    CCompany = context.StringValue($"QueryContactTemplate.ContactTemplates[{i}].CCompany"),
                    ECompany = context.StringValue($"QueryContactTemplate.ContactTemplates[{i}].ECompany"),
                    CCountry = context.StringValue($"QueryContactTemplate.ContactTemplates[{i}].CCountry"),
                    CProvince = context.StringValue($"QueryContactTemplate.ContactTemplates[{i}].CProvince"),
                    EProvince = context.StringValue($"QueryContactTemplate.ContactTemplates[{i}].EProvince"),
                    CCity = context.StringValue($"QueryContactTemplate.ContactTemplates[{i}].CCity"),
                    ECity = context.StringValue($"QueryContactTemplate.ContactTemplates[{i}].ECity"),
                    CVenu = context.StringValue($"QueryContactTemplate.ContactTemplates[{i}].CVenu"),
                    EVenu = context.StringValue($"QueryContactTemplate.ContactTemplates[{i}].EVenu"),
                    Email = context.StringValue($"QueryContactTemplate.ContactTemplates[{i}].Email"),
                    TelArea = context.StringValue($"QueryContactTemplate.ContactTemplates[{i}].TelArea"),
                    PostalCode = context.StringValue($"QueryContactTemplate.ContactTemplates[{i}].PostalCode"),
                    TelMain = context.StringValue($"QueryContactTemplate.ContactTemplates[{i}].TelMain"),
                    TelExt = context.StringValue($"QueryContactTemplate.ContactTemplates[{i}].TelExt")
                };
                contactTemplates.Add(contactTemplate);
			}
			queryContactTemplateResponse.ContactTemplates = contactTemplates;
        
			return queryContactTemplateResponse;
        }
    }
}