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
    public class CreateSlotResponseUnmarshaller
    {
        public static CreateSlotResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateSlotResponse createSlotResponse = new CreateSlotResponse();

			createSlotResponse.HttpResponse = _ctx.HttpResponse;
			createSlotResponse.Code = _ctx.StringValue("CreateSlot.Code");
			createSlotResponse.Success = _ctx.BooleanValue("CreateSlot.Success");
			createSlotResponse.Message = _ctx.StringValue("CreateSlot.Message");
			createSlotResponse.RequestId = _ctx.StringValue("CreateSlot.RequestId");

			CreateSlotResponse.CreateSlot_Model model = new CreateSlotResponse.CreateSlot_Model();
			model.CreateTime = _ctx.LongValue("CreateSlot.Model.CreateTime");
			model.ModifyTime = _ctx.LongValue("CreateSlot.Model.ModifyTime");
			model.TenantId = _ctx.StringValue("CreateSlot.Model.TenantId");
			model.MediaName = _ctx.StringValue("CreateSlot.Model.MediaName");
			model.MediaId = _ctx.StringValue("CreateSlot.Model.MediaId");
			model.AdSlotId = _ctx.StringValue("CreateSlot.Model.AdSlotId");
			model.AdSlotName = _ctx.StringValue("CreateSlot.Model.AdSlotName");
			model.AdSlotType = _ctx.StringValue("CreateSlot.Model.AdSlotType");
			model.AdSlotTemplateId = _ctx.StringValue("CreateSlot.Model.AdSlotTemplateId");
			model.AdSlotStatus = _ctx.StringValue("CreateSlot.Model.AdSlotStatus");
			model.AdSlotCorporateStatus = _ctx.StringValue("CreateSlot.Model.AdSlotCorporateStatus");
			model.ExtInfo = _ctx.StringValue("CreateSlot.Model.ExtInfo");
			model.BlockingRule = _ctx.StringValue("CreateSlot.Model.BlockingRule");
			model.InspireScene = _ctx.StringValue("CreateSlot.Model.InspireScene");
			model.Version = _ctx.LongValue("CreateSlot.Model.Version");
			createSlotResponse.Model = model;
        
			return createSlotResponse;
        }
    }
}
