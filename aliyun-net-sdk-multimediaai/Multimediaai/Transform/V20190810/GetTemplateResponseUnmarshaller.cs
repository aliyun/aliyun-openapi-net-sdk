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
using Aliyun.Acs.multimediaai.Model.V20190810;

namespace Aliyun.Acs.multimediaai.Transform.V20190810
{
    public class GetTemplateResponseUnmarshaller
    {
        public static GetTemplateResponse Unmarshall(UnmarshallerContext context)
        {
			GetTemplateResponse getTemplateResponse = new GetTemplateResponse();

			getTemplateResponse.HttpResponse = context.HttpResponse;
			getTemplateResponse.RequestId = context.StringValue("GetTemplate.RequestId");
			getTemplateResponse.TemplateId = context.StringValue("GetTemplate.TemplateId");
			getTemplateResponse.TemplateName = context.StringValue("GetTemplate.TemplateName");
			getTemplateResponse.Content = context.StringValue("GetTemplate.Content");
			getTemplateResponse.Category = context.IntegerValue("GetTemplate.Category");
			getTemplateResponse.IsDefault = context.BooleanValue("GetTemplate.IsDefault");
			getTemplateResponse.CreateTime = context.StringValue("GetTemplate.CreateTime");
			getTemplateResponse.UpdateTime = context.StringValue("GetTemplate.UpdateTime");
        
			return getTemplateResponse;
        }
    }
}
