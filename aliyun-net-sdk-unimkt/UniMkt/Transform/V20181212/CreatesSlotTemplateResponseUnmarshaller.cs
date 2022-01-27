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
    public class CreatesSlotTemplateResponseUnmarshaller
    {
        public static CreatesSlotTemplateResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreatesSlotTemplateResponse createsSlotTemplateResponse = new CreatesSlotTemplateResponse();

			createsSlotTemplateResponse.HttpResponse = _ctx.HttpResponse;
			createsSlotTemplateResponse.Code = _ctx.StringValue("CreatesSlotTemplate.Code");
			createsSlotTemplateResponse.Success = _ctx.BooleanValue("CreatesSlotTemplate.Success");
			createsSlotTemplateResponse.Message = _ctx.StringValue("CreatesSlotTemplate.Message");
			createsSlotTemplateResponse.RequestId = _ctx.StringValue("CreatesSlotTemplate.RequestId");

			CreatesSlotTemplateResponse.CreatesSlotTemplate_Model model = new CreatesSlotTemplateResponse.CreatesSlotTemplate_Model();
			model.CreateTime = _ctx.LongValue("CreatesSlotTemplate.Model.CreateTime");
			model.ModifyTime = _ctx.LongValue("CreatesSlotTemplate.Model.ModifyTime");
			model.TenantId = _ctx.StringValue("CreatesSlotTemplate.Model.TenantId");
			model.AdSlotTemplateId = _ctx.StringValue("CreatesSlotTemplate.Model.AdSlotTemplateId");
			model.AdSlotTemplateName = _ctx.StringValue("CreatesSlotTemplate.Model.AdSlotTemplateName");
			model.AdSlotTemplateTitle = _ctx.StringValue("CreatesSlotTemplate.Model.AdSlotTemplateTitle");
			model.AdSlotTemplatePic = _ctx.StringValue("CreatesSlotTemplate.Model.AdSlotTemplatePic");
			model.AdSlotTemplatePreview = _ctx.StringValue("CreatesSlotTemplate.Model.AdSlotTemplatePreview");
			model.AdSlotTemplateDescription = _ctx.StringValue("CreatesSlotTemplate.Model.AdSlotTemplateDescription");
			model.AdSlotType = _ctx.StringValue("CreatesSlotTemplate.Model.AdSlotType");
			model.TemplateConfig = _ctx.StringValue("CreatesSlotTemplate.Model.TemplateConfig");
			model.ExtInfo = _ctx.StringValue("CreatesSlotTemplate.Model.ExtInfo");
			model.Version = _ctx.LongValue("CreatesSlotTemplate.Model.Version");
			createsSlotTemplateResponse.Model = model;
        
			return createsSlotTemplateResponse;
        }
    }
}
