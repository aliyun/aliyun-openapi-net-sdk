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
    public class QuerySlotResponseUnmarshaller
    {
        public static QuerySlotResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QuerySlotResponse querySlotResponse = new QuerySlotResponse();

			querySlotResponse.HttpResponse = _ctx.HttpResponse;
			querySlotResponse.Code = _ctx.StringValue("QuerySlot.Code");
			querySlotResponse.Success = _ctx.BooleanValue("QuerySlot.Success");
			querySlotResponse.Message = _ctx.StringValue("QuerySlot.Message");
			querySlotResponse.RequestId = _ctx.StringValue("QuerySlot.RequestId");

			QuerySlotResponse.QuerySlot_Model model = new QuerySlotResponse.QuerySlot_Model();
			model.CreateTime = _ctx.LongValue("QuerySlot.Model.CreateTime");
			model.ModifyTime = _ctx.LongValue("QuerySlot.Model.ModifyTime");
			model.TenantId = _ctx.StringValue("QuerySlot.Model.TenantId");
			model.MediaName = _ctx.StringValue("QuerySlot.Model.MediaName");
			model.MediaId = _ctx.StringValue("QuerySlot.Model.MediaId");
			model.AdSlotId = _ctx.StringValue("QuerySlot.Model.AdSlotId");
			model.AdSlotName = _ctx.StringValue("QuerySlot.Model.AdSlotName");
			model.AdSlotType = _ctx.StringValue("QuerySlot.Model.AdSlotType");
			model.AdSlotTemplateId = _ctx.StringValue("QuerySlot.Model.AdSlotTemplateId");
			model.AdSlotStatus = _ctx.StringValue("QuerySlot.Model.AdSlotStatus");
			model.AdSlotCorporateStatus = _ctx.StringValue("QuerySlot.Model.AdSlotCorporateStatus");
			model.ExtInfo = _ctx.StringValue("QuerySlot.Model.ExtInfo");
			model.BlockingRule = _ctx.StringValue("QuerySlot.Model.BlockingRule");
			model.InspireScene = _ctx.StringValue("QuerySlot.Model.InspireScene");
			model.Version = _ctx.LongValue("QuerySlot.Model.Version");
			querySlotResponse.Model = model;
        
			return querySlotResponse;
        }
    }
}
