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
    public class UpdateMCTemplateResponseUnmarshaller
    {
        public static UpdateMCTemplateResponse Unmarshall(UnmarshallerContext context)
        {
			UpdateMCTemplateResponse updateMCTemplateResponse = new UpdateMCTemplateResponse();

			updateMCTemplateResponse.HttpResponse = context.HttpResponse;
			updateMCTemplateResponse.RequestId = context.StringValue("UpdateMCTemplate.RequestId");

			UpdateMCTemplateResponse.UpdateMCTemplate_Template template = new UpdateMCTemplateResponse.UpdateMCTemplate_Template();
			template.TemplateId = context.StringValue("UpdateMCTemplate.Template.TemplateId");
			template.Name = context.StringValue("UpdateMCTemplate.Template.Name");
			template.State = context.StringValue("UpdateMCTemplate.Template.State");
			template.Porn = context.StringValue("UpdateMCTemplate.Template.Porn");
			template.Terrorism = context.StringValue("UpdateMCTemplate.Template.Terrorism");
			template.Politics = context.StringValue("UpdateMCTemplate.Template.Politics");
			template.Ad = context.StringValue("UpdateMCTemplate.Template.Ad");
			template.Qrcode = context.StringValue("UpdateMCTemplate.Template.Qrcode");
			template.Live = context.StringValue("UpdateMCTemplate.Template.Live");
			template.Logo = context.StringValue("UpdateMCTemplate.Template.Logo");
			template.Abuse = context.StringValue("UpdateMCTemplate.Template.Abuse");
			template.Contraband = context.StringValue("UpdateMCTemplate.Template.Contraband");
			template.Spam = context.StringValue("UpdateMCTemplate.Template.Spam");
			updateMCTemplateResponse.Template = template;
        
			return updateMCTemplateResponse;
        }
    }
}
