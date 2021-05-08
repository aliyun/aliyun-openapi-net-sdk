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
    public class ChangeSlotStatusResponseUnmarshaller
    {
        public static ChangeSlotStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ChangeSlotStatusResponse changeSlotStatusResponse = new ChangeSlotStatusResponse();

			changeSlotStatusResponse.HttpResponse = _ctx.HttpResponse;
			changeSlotStatusResponse.Code = _ctx.StringValue("ChangeSlotStatus.Code");
			changeSlotStatusResponse.Success = _ctx.BooleanValue("ChangeSlotStatus.Success");
			changeSlotStatusResponse.Message = _ctx.StringValue("ChangeSlotStatus.Message");
			changeSlotStatusResponse.RequestId = _ctx.StringValue("ChangeSlotStatus.RequestId");

			ChangeSlotStatusResponse.ChangeSlotStatus_Model model = new ChangeSlotStatusResponse.ChangeSlotStatus_Model();
			model.CreateTime = _ctx.LongValue("ChangeSlotStatus.Model.CreateTime");
			model.ModifyTime = _ctx.LongValue("ChangeSlotStatus.Model.ModifyTime");
			model.TenantId = _ctx.StringValue("ChangeSlotStatus.Model.TenantId");
			model.MediaName = _ctx.StringValue("ChangeSlotStatus.Model.MediaName");
			model.MediaId = _ctx.StringValue("ChangeSlotStatus.Model.MediaId");
			model.AdSlotId = _ctx.StringValue("ChangeSlotStatus.Model.AdSlotId");
			model.AdSlotName = _ctx.StringValue("ChangeSlotStatus.Model.AdSlotName");
			model.AdSlotType = _ctx.StringValue("ChangeSlotStatus.Model.AdSlotType");
			model.AdSlotTemplateId = _ctx.StringValue("ChangeSlotStatus.Model.AdSlotTemplateId");
			model.AdSlotStatus = _ctx.StringValue("ChangeSlotStatus.Model.AdSlotStatus");
			model.AdSlotCorporateStatus = _ctx.StringValue("ChangeSlotStatus.Model.AdSlotCorporateStatus");
			model.BlockingRule = _ctx.StringValue("ChangeSlotStatus.Model.BlockingRule");
			model.InspireScene = _ctx.StringValue("ChangeSlotStatus.Model.InspireScene");
			model.ExtInfo = _ctx.StringValue("ChangeSlotStatus.Model.ExtInfo");
			model.Version = _ctx.LongValue("ChangeSlotStatus.Model.Version");
			changeSlotStatusResponse.Model = model;
        
			return changeSlotStatusResponse;
        }
    }
}
