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
using Aliyun.Acs.Config.Model.V20190108;

namespace Aliyun.Acs.Config.Transform.V20190108
{
    public class ListRemediationTemplatesResponseUnmarshaller
    {
        public static ListRemediationTemplatesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListRemediationTemplatesResponse listRemediationTemplatesResponse = new ListRemediationTemplatesResponse();

			listRemediationTemplatesResponse.HttpResponse = _ctx.HttpResponse;
			listRemediationTemplatesResponse.RequestId = _ctx.StringValue("ListRemediationTemplates.RequestId");

			List<ListRemediationTemplatesResponse.ListRemediationTemplates_RemediationTemplate> listRemediationTemplatesResponse_remediationTemplates = new List<ListRemediationTemplatesResponse.ListRemediationTemplates_RemediationTemplate>();
			for (int i = 0; i < _ctx.Length("ListRemediationTemplates.RemediationTemplates.Length"); i++) {
				ListRemediationTemplatesResponse.ListRemediationTemplates_RemediationTemplate remediationTemplate = new ListRemediationTemplatesResponse.ListRemediationTemplates_RemediationTemplate();
				remediationTemplate.CompulsoryParameters = _ctx.StringValue("ListRemediationTemplates.RemediationTemplates["+ i +"].CompulsoryParameters");
				remediationTemplate.RemediationType = _ctx.StringValue("ListRemediationTemplates.RemediationTemplates["+ i +"].RemediationType");
				remediationTemplate.TemplateIdentifier = _ctx.StringValue("ListRemediationTemplates.RemediationTemplates["+ i +"].TemplateIdentifier");
				remediationTemplate.TemplateName = _ctx.StringValue("ListRemediationTemplates.RemediationTemplates["+ i +"].TemplateName");
				remediationTemplate.TemplateDefinition = _ctx.StringValue("ListRemediationTemplates.RemediationTemplates["+ i +"].TemplateDefinition");

				listRemediationTemplatesResponse_remediationTemplates.Add(remediationTemplate);
			}
			listRemediationTemplatesResponse.RemediationTemplates = listRemediationTemplatesResponse_remediationTemplates;
        
			return listRemediationTemplatesResponse;
        }
    }
}
