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
    public class DescribeWhitelistTemplateResponseUnmarshaller
    {
        public static DescribeWhitelistTemplateResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeWhitelistTemplateResponse describeWhitelistTemplateResponse = new DescribeWhitelistTemplateResponse();

			describeWhitelistTemplateResponse.HttpResponse = _ctx.HttpResponse;
			describeWhitelistTemplateResponse.RequestId = _ctx.StringValue("DescribeWhitelistTemplate.RequestId");
			describeWhitelistTemplateResponse.Success = _ctx.BooleanValue("DescribeWhitelistTemplate.Success");
			describeWhitelistTemplateResponse.Code = _ctx.StringValue("DescribeWhitelistTemplate.Code");
			describeWhitelistTemplateResponse.Message = _ctx.StringValue("DescribeWhitelistTemplate.Message");
			describeWhitelistTemplateResponse.HttpStatusCode = _ctx.IntegerValue("DescribeWhitelistTemplate.HttpStatusCode");

			DescribeWhitelistTemplateResponse.DescribeWhitelistTemplate_Data data = new DescribeWhitelistTemplateResponse.DescribeWhitelistTemplate_Data();

			DescribeWhitelistTemplateResponse.DescribeWhitelistTemplate_Data.DescribeWhitelistTemplate_Template template = new DescribeWhitelistTemplateResponse.DescribeWhitelistTemplate_Data.DescribeWhitelistTemplate_Template();
			template.Id = _ctx.IntegerValue("DescribeWhitelistTemplate.Data.Template.Id");
			template.UserId = _ctx.IntegerValue("DescribeWhitelistTemplate.Data.Template.UserId");
			template.TemplateId = _ctx.IntegerValue("DescribeWhitelistTemplate.Data.Template.TemplateId");
			template.TemplateName = _ctx.StringValue("DescribeWhitelistTemplate.Data.Template.TemplateName");
			template.Ips = _ctx.StringValue("DescribeWhitelistTemplate.Data.Template.Ips");
			data.Template = template;
			describeWhitelistTemplateResponse.Data = data;
        
			return describeWhitelistTemplateResponse;
        }
    }
}
