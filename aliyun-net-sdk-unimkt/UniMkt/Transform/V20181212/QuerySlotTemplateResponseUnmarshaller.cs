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
using Aliyun.Acs.UniMkt.Model.V20181212;

namespace Aliyun.Acs.UniMkt.Transform.V20181212
{
    public class QuerySlotTemplateResponseUnmarshaller
    {
        public static QuerySlotTemplateResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QuerySlotTemplateResponse querySlotTemplateResponse = new QuerySlotTemplateResponse();

			querySlotTemplateResponse.HttpResponse = _ctx.HttpResponse;
			querySlotTemplateResponse.Code = _ctx.StringValue("QuerySlotTemplate.Code");
			querySlotTemplateResponse.Success = _ctx.BooleanValue("QuerySlotTemplate.Success");
			querySlotTemplateResponse.Message = _ctx.StringValue("QuerySlotTemplate.Message");
			querySlotTemplateResponse.RequestId = _ctx.StringValue("QuerySlotTemplate.RequestId");

			QuerySlotTemplateResponse.QuerySlotTemplate_Model model = new QuerySlotTemplateResponse.QuerySlotTemplate_Model();
			model.CreateTime = _ctx.LongValue("QuerySlotTemplate.Model.CreateTime");
			model.ModifyTime = _ctx.LongValue("QuerySlotTemplate.Model.ModifyTime");
			model.TenantId = _ctx.StringValue("QuerySlotTemplate.Model.TenantId");
			model.AdSlotTemplateId = _ctx.StringValue("QuerySlotTemplate.Model.AdSlotTemplateId");
			model.AdSlotTemplateName = _ctx.StringValue("QuerySlotTemplate.Model.AdSlotTemplateName");
			model.AdSlotTemplateTitle = _ctx.StringValue("QuerySlotTemplate.Model.AdSlotTemplateTitle");
			model.AdSlotTemplatePic = _ctx.StringValue("QuerySlotTemplate.Model.AdSlotTemplatePic");
			model.AdSlotTemplatePreview = _ctx.StringValue("QuerySlotTemplate.Model.AdSlotTemplatePreview");
			model.AdSlotTemplateDescription = _ctx.StringValue("QuerySlotTemplate.Model.AdSlotTemplateDescription");
			model.AdSlotType = _ctx.StringValue("QuerySlotTemplate.Model.AdSlotType");
			model.TemplateConfig = _ctx.StringValue("QuerySlotTemplate.Model.TemplateConfig");
			model.ExtInfo = _ctx.StringValue("QuerySlotTemplate.Model.ExtInfo");
			model.Version = _ctx.LongValue("QuerySlotTemplate.Model.Version");
			querySlotTemplateResponse.Model = model;
        
			return querySlotTemplateResponse;
        }
    }
}
