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
    public class ModifySlotTemplateResponseUnmarshaller
    {
        public static ModifySlotTemplateResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ModifySlotTemplateResponse modifySlotTemplateResponse = new ModifySlotTemplateResponse();

			modifySlotTemplateResponse.HttpResponse = _ctx.HttpResponse;
			modifySlotTemplateResponse.Code = _ctx.StringValue("ModifySlotTemplate.Code");
			modifySlotTemplateResponse.Success = _ctx.BooleanValue("ModifySlotTemplate.Success");
			modifySlotTemplateResponse.Message = _ctx.StringValue("ModifySlotTemplate.Message");
			modifySlotTemplateResponse.RequestId = _ctx.StringValue("ModifySlotTemplate.RequestId");

			ModifySlotTemplateResponse.ModifySlotTemplate_Model model = new ModifySlotTemplateResponse.ModifySlotTemplate_Model();
			model.CreateTime = _ctx.LongValue("ModifySlotTemplate.Model.CreateTime");
			model.ModifyTime = _ctx.LongValue("ModifySlotTemplate.Model.ModifyTime");
			model.TenantId = _ctx.StringValue("ModifySlotTemplate.Model.TenantId");
			model.AdSlotTemplateId = _ctx.StringValue("ModifySlotTemplate.Model.AdSlotTemplateId");
			model.AdSlotTemplateName = _ctx.StringValue("ModifySlotTemplate.Model.AdSlotTemplateName");
			model.AdSlotTemplateTitle = _ctx.StringValue("ModifySlotTemplate.Model.AdSlotTemplateTitle");
			model.AdSlotTemplatePic = _ctx.StringValue("ModifySlotTemplate.Model.AdSlotTemplatePic");
			model.AdSlotTemplatePreview = _ctx.StringValue("ModifySlotTemplate.Model.AdSlotTemplatePreview");
			model.AdSlotTemplateDescription = _ctx.StringValue("ModifySlotTemplate.Model.AdSlotTemplateDescription");
			model.AdSlotType = _ctx.StringValue("ModifySlotTemplate.Model.AdSlotType");
			model.TemplateConfig = _ctx.StringValue("ModifySlotTemplate.Model.TemplateConfig");
			model.ExtInfo = _ctx.StringValue("ModifySlotTemplate.Model.ExtInfo");
			model.Version = _ctx.LongValue("ModifySlotTemplate.Model.Version");
			modifySlotTemplateResponse.Model = model;
        
			return modifySlotTemplateResponse;
        }
    }
}
