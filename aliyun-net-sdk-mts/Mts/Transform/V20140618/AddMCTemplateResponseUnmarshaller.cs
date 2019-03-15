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
using Aliyun.Acs.Mts.Model.V20140618;

namespace Aliyun.Acs.Mts.Transform.V20140618
{
    public class AddMCTemplateResponseUnmarshaller
    {
        public static AddMCTemplateResponse Unmarshall(UnmarshallerContext context)
        {
			AddMCTemplateResponse addMCTemplateResponse = new AddMCTemplateResponse();

			addMCTemplateResponse.HttpResponse = context.HttpResponse;
			addMCTemplateResponse.RequestId = context.StringValue("AddMCTemplate.RequestId");

			AddMCTemplateResponse.AddMCTemplate_Template template = new AddMCTemplateResponse.AddMCTemplate_Template();
			template.TemplateId = context.StringValue("AddMCTemplate.Template.TemplateId");
			template.Name = context.StringValue("AddMCTemplate.Template.Name");
			template.Porn = context.StringValue("AddMCTemplate.Template.Porn");
			template.Terrorism = context.StringValue("AddMCTemplate.Template.Terrorism");
			template.Politics = context.StringValue("AddMCTemplate.Template.Politics");
			template.Ad = context.StringValue("AddMCTemplate.Template.Ad");
			template.Qrcode = context.StringValue("AddMCTemplate.Template.Qrcode");
			template.Live = context.StringValue("AddMCTemplate.Template.Live");
			template.Logo = context.StringValue("AddMCTemplate.Template.Logo");
			template.Abuse = context.StringValue("AddMCTemplate.Template.Abuse");
			template.Contraband = context.StringValue("AddMCTemplate.Template.Contraband");
			template.Spam = context.StringValue("AddMCTemplate.Template.Spam");
			addMCTemplateResponse.Template = template;
        
			return addMCTemplateResponse;
        }
    }
}
