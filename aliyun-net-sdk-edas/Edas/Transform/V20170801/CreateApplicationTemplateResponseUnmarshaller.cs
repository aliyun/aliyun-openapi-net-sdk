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
using Aliyun.Acs.Edas.Model.V20170801;

namespace Aliyun.Acs.Edas.Transform.V20170801
{
    public class CreateApplicationTemplateResponseUnmarshaller
    {
        public static CreateApplicationTemplateResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateApplicationTemplateResponse createApplicationTemplateResponse = new CreateApplicationTemplateResponse();

			createApplicationTemplateResponse.HttpResponse = _ctx.HttpResponse;
			createApplicationTemplateResponse.Code = _ctx.IntegerValue("CreateApplicationTemplate.Code");
			createApplicationTemplateResponse.Message = _ctx.StringValue("CreateApplicationTemplate.Message");
			createApplicationTemplateResponse.RequestId = _ctx.StringValue("CreateApplicationTemplate.RequestId");

			CreateApplicationTemplateResponse.CreateApplicationTemplate_Data data = new CreateApplicationTemplateResponse.CreateApplicationTemplate_Data();
			data.ShowName = _ctx.StringValue("CreateApplicationTemplate.Data.ShowName");
			data.Description = _ctx.StringValue("CreateApplicationTemplate.Data.Description");
			data.Name = _ctx.StringValue("CreateApplicationTemplate.Data.Name");
			data.Id = _ctx.LongValue("CreateApplicationTemplate.Data.Id");
			data.Attributes = _ctx.StringValue("CreateApplicationTemplate.Data.Attributes");

			CreateApplicationTemplateResponse.CreateApplicationTemplate_Data.CreateApplicationTemplate_SourceConfig sourceConfig = new CreateApplicationTemplateResponse.CreateApplicationTemplate_Data.CreateApplicationTemplate_SourceConfig();
			sourceConfig.SourceUrl = _ctx.StringValue("CreateApplicationTemplate.Data.SourceConfig.SourceUrl");
			data.SourceConfig = sourceConfig;
			createApplicationTemplateResponse.Data = data;
        
			return createApplicationTemplateResponse;
        }
    }
}
