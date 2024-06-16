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
using Aliyun.Acs.Rds.Model.V20140815;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeAllWhitelistTemplateResponseUnmarshaller
    {
        public static DescribeAllWhitelistTemplateResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAllWhitelistTemplateResponse describeAllWhitelistTemplateResponse = new DescribeAllWhitelistTemplateResponse();

			describeAllWhitelistTemplateResponse.HttpResponse = _ctx.HttpResponse;
			describeAllWhitelistTemplateResponse.RequestId = _ctx.StringValue("DescribeAllWhitelistTemplate.RequestId");
			describeAllWhitelistTemplateResponse.Success = _ctx.BooleanValue("DescribeAllWhitelistTemplate.Success");
			describeAllWhitelistTemplateResponse.Code = _ctx.StringValue("DescribeAllWhitelistTemplate.Code");
			describeAllWhitelistTemplateResponse.Message = _ctx.StringValue("DescribeAllWhitelistTemplate.Message");
			describeAllWhitelistTemplateResponse.HttpStatusCode = _ctx.IntegerValue("DescribeAllWhitelistTemplate.HttpStatusCode");

			DescribeAllWhitelistTemplateResponse.DescribeAllWhitelistTemplate_Data data = new DescribeAllWhitelistTemplateResponse.DescribeAllWhitelistTemplate_Data();
			data.TotalRecords = _ctx.IntegerValue("DescribeAllWhitelistTemplate.Data.TotalRecords");
			data.MaxRecordsPerPage = _ctx.IntegerValue("DescribeAllWhitelistTemplate.Data.MaxRecordsPerPage");
			data.CurrPageNumbers = _ctx.IntegerValue("DescribeAllWhitelistTemplate.Data.CurrPageNumbers");
			data.TotalPageNumbers = _ctx.IntegerValue("DescribeAllWhitelistTemplate.Data.TotalPageNumbers");
			data.HasNext = _ctx.BooleanValue("DescribeAllWhitelistTemplate.Data.HasNext");
			data.HasPrev = _ctx.BooleanValue("DescribeAllWhitelistTemplate.Data.HasPrev");

			List<DescribeAllWhitelistTemplateResponse.DescribeAllWhitelistTemplate_Data.DescribeAllWhitelistTemplate_Template> data_templates = new List<DescribeAllWhitelistTemplateResponse.DescribeAllWhitelistTemplate_Data.DescribeAllWhitelistTemplate_Template>();
			for (int i = 0; i < _ctx.Length("DescribeAllWhitelistTemplate.Data.Templates.Length"); i++) {
				DescribeAllWhitelistTemplateResponse.DescribeAllWhitelistTemplate_Data.DescribeAllWhitelistTemplate_Template template = new DescribeAllWhitelistTemplateResponse.DescribeAllWhitelistTemplate_Data.DescribeAllWhitelistTemplate_Template();
				template.Id = _ctx.IntegerValue("DescribeAllWhitelistTemplate.Data.Templates["+ i +"].Id");
				template.UserId = _ctx.IntegerValue("DescribeAllWhitelistTemplate.Data.Templates["+ i +"].UserId");
				template.TemplateId = _ctx.IntegerValue("DescribeAllWhitelistTemplate.Data.Templates["+ i +"].TemplateId");
				template.TemplateName = _ctx.StringValue("DescribeAllWhitelistTemplate.Data.Templates["+ i +"].TemplateName");
				template.Ips = _ctx.StringValue("DescribeAllWhitelistTemplate.Data.Templates["+ i +"].Ips");

				data_templates.Add(template);
			}
			data.Templates = data_templates;
			describeAllWhitelistTemplateResponse.Data = data;
        
			return describeAllWhitelistTemplateResponse;
        }
    }
}
