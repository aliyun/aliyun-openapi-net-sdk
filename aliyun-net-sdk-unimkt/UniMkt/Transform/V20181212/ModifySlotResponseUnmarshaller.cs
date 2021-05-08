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
    public class ModifySlotResponseUnmarshaller
    {
        public static ModifySlotResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ModifySlotResponse modifySlotResponse = new ModifySlotResponse();

			modifySlotResponse.HttpResponse = _ctx.HttpResponse;
			modifySlotResponse.Code = _ctx.StringValue("ModifySlot.Code");
			modifySlotResponse.Success = _ctx.BooleanValue("ModifySlot.Success");
			modifySlotResponse.Message = _ctx.StringValue("ModifySlot.Message");
			modifySlotResponse.RequestId = _ctx.StringValue("ModifySlot.RequestId");

			ModifySlotResponse.ModifySlot_Model model = new ModifySlotResponse.ModifySlot_Model();
			model.CreateTime = _ctx.LongValue("ModifySlot.Model.CreateTime");
			model.ModifyTime = _ctx.LongValue("ModifySlot.Model.ModifyTime");
			model.TenantId = _ctx.StringValue("ModifySlot.Model.TenantId");
			model.MediaName = _ctx.StringValue("ModifySlot.Model.MediaName");
			model.MediaId = _ctx.StringValue("ModifySlot.Model.MediaId");
			model.AdSlotId = _ctx.StringValue("ModifySlot.Model.AdSlotId");
			model.AdSlotName = _ctx.StringValue("ModifySlot.Model.AdSlotName");
			model.AdSlotType = _ctx.StringValue("ModifySlot.Model.AdSlotType");
			model.AdSlotTemplateId = _ctx.StringValue("ModifySlot.Model.AdSlotTemplateId");
			model.AdSlotStatus = _ctx.StringValue("ModifySlot.Model.AdSlotStatus");
			model.AdSlotCorporateStatus = _ctx.StringValue("ModifySlot.Model.AdSlotCorporateStatus");
			model.ExtInfo = _ctx.StringValue("ModifySlot.Model.ExtInfo");
			model.BlockingRule = _ctx.StringValue("ModifySlot.Model.BlockingRule");
			model.InspireScene = _ctx.StringValue("ModifySlot.Model.InspireScene");
			model.Version = _ctx.LongValue("ModifySlot.Model.Version");
			modifySlotResponse.Model = model;
        
			return modifySlotResponse;
        }
    }
}
