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
using Aliyun.Acs.Dm.Model.V20170622;

namespace Aliyun.Acs.Dm.Transform.V20170622
{
    public class DescTemplateResponseUnmarshaller
    {
        public static DescTemplateResponse Unmarshall(UnmarshallerContext context)
        {
			DescTemplateResponse descTemplateResponse = new DescTemplateResponse();

			descTemplateResponse.HttpResponse = context.HttpResponse;
			descTemplateResponse.RequestId = context.StringValue("DescTemplate.RequestId");
			descTemplateResponse.TemplateName = context.StringValue("DescTemplate.TemplateName");
			descTemplateResponse.TemplateSubject = context.StringValue("DescTemplate.TemplateSubject");
			descTemplateResponse.TemplateNickName = context.StringValue("DescTemplate.TemplateNickName");
			descTemplateResponse.TemplateStatus = context.StringValue("DescTemplate.TemplateStatus");
			descTemplateResponse.TemplateType = context.StringValue("DescTemplate.TemplateType");
			descTemplateResponse.CreateTime = context.StringValue("DescTemplate.CreateTime");
			descTemplateResponse.TemplateText = context.StringValue("DescTemplate.TemplateText");
			descTemplateResponse.SmsContent = context.StringValue("DescTemplate.SmsContent");
			descTemplateResponse.SmsType = context.StringValue("DescTemplate.SmsType");
			descTemplateResponse.Remark = context.StringValue("DescTemplate.Remark");
        
			return descTemplateResponse;
        }
    }
}
