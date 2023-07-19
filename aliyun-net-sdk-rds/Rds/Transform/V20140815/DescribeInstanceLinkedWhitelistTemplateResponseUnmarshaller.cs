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
    public class DescribeInstanceLinkedWhitelistTemplateResponseUnmarshaller
    {
        public static DescribeInstanceLinkedWhitelistTemplateResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeInstanceLinkedWhitelistTemplateResponse describeInstanceLinkedWhitelistTemplateResponse = new DescribeInstanceLinkedWhitelistTemplateResponse();

			describeInstanceLinkedWhitelistTemplateResponse.HttpResponse = _ctx.HttpResponse;
			describeInstanceLinkedWhitelistTemplateResponse.RequestId = _ctx.StringValue("DescribeInstanceLinkedWhitelistTemplate.RequestId");
			describeInstanceLinkedWhitelistTemplateResponse.Success = _ctx.BooleanValue("DescribeInstanceLinkedWhitelistTemplate.Success");
			describeInstanceLinkedWhitelistTemplateResponse.Code = _ctx.StringValue("DescribeInstanceLinkedWhitelistTemplate.Code");
			describeInstanceLinkedWhitelistTemplateResponse.Message = _ctx.StringValue("DescribeInstanceLinkedWhitelistTemplate.Message");
			describeInstanceLinkedWhitelistTemplateResponse.HttpStatusCode = _ctx.IntegerValue("DescribeInstanceLinkedWhitelistTemplate.HttpStatusCode");

			DescribeInstanceLinkedWhitelistTemplateResponse.DescribeInstanceLinkedWhitelistTemplate_Data data = new DescribeInstanceLinkedWhitelistTemplateResponse.DescribeInstanceLinkedWhitelistTemplate_Data();
			data.InsName = _ctx.StringValue("DescribeInstanceLinkedWhitelistTemplate.Data.InsName");

			List<DescribeInstanceLinkedWhitelistTemplateResponse.DescribeInstanceLinkedWhitelistTemplate_Data.DescribeInstanceLinkedWhitelistTemplate_Template> data_templates = new List<DescribeInstanceLinkedWhitelistTemplateResponse.DescribeInstanceLinkedWhitelistTemplate_Data.DescribeInstanceLinkedWhitelistTemplate_Template>();
			for (int i = 0; i < _ctx.Length("DescribeInstanceLinkedWhitelistTemplate.Data.Templates.Length"); i++) {
				DescribeInstanceLinkedWhitelistTemplateResponse.DescribeInstanceLinkedWhitelistTemplate_Data.DescribeInstanceLinkedWhitelistTemplate_Template template = new DescribeInstanceLinkedWhitelistTemplateResponse.DescribeInstanceLinkedWhitelistTemplate_Data.DescribeInstanceLinkedWhitelistTemplate_Template();
				template.Id = _ctx.IntegerValue("DescribeInstanceLinkedWhitelistTemplate.Data.Templates["+ i +"].Id");
				template.UserId = _ctx.IntegerValue("DescribeInstanceLinkedWhitelistTemplate.Data.Templates["+ i +"].UserId");
				template.TemplateId = _ctx.IntegerValue("DescribeInstanceLinkedWhitelistTemplate.Data.Templates["+ i +"].TemplateId");
				template.TemplateName = _ctx.StringValue("DescribeInstanceLinkedWhitelistTemplate.Data.Templates["+ i +"].TemplateName");
				template.Ips = _ctx.StringValue("DescribeInstanceLinkedWhitelistTemplate.Data.Templates["+ i +"].Ips");

				data_templates.Add(template);
			}
			data.Templates = data_templates;
			describeInstanceLinkedWhitelistTemplateResponse.Data = data;
        
			return describeInstanceLinkedWhitelistTemplateResponse;
        }
    }
}
