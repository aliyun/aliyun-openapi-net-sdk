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
    public class ListSlotResponseUnmarshaller
    {
        public static ListSlotResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListSlotResponse listSlotResponse = new ListSlotResponse();

			listSlotResponse.HttpResponse = _ctx.HttpResponse;
			listSlotResponse.Code = _ctx.StringValue("ListSlot.Code");
			listSlotResponse.Success = _ctx.BooleanValue("ListSlot.Success");
			listSlotResponse.Message = _ctx.StringValue("ListSlot.Message");
			listSlotResponse.RequestId = _ctx.StringValue("ListSlot.RequestId");
			listSlotResponse.PageNumber = _ctx.IntegerValue("ListSlot.PageNumber");
			listSlotResponse.PageSize = _ctx.IntegerValue("ListSlot.PageSize");
			listSlotResponse.Total = _ctx.LongValue("ListSlot.Total");

			List<ListSlotResponse.ListSlot_AdSlot> listSlotResponse_model = new List<ListSlotResponse.ListSlot_AdSlot>();
			for (int i = 0; i < _ctx.Length("ListSlot.Model.Length"); i++) {
				ListSlotResponse.ListSlot_AdSlot adSlot = new ListSlotResponse.ListSlot_AdSlot();
				adSlot.CreateTime = _ctx.LongValue("ListSlot.Model["+ i +"].CreateTime");
				adSlot.ModifyTime = _ctx.LongValue("ListSlot.Model["+ i +"].ModifyTime");
				adSlot.TenantId = _ctx.StringValue("ListSlot.Model["+ i +"].TenantId");
				adSlot.MediaName = _ctx.StringValue("ListSlot.Model["+ i +"].MediaName");
				adSlot.MediaId = _ctx.StringValue("ListSlot.Model["+ i +"].MediaId");
				adSlot.AdSlotId = _ctx.StringValue("ListSlot.Model["+ i +"].AdSlotId");
				adSlot.AdSlotName = _ctx.StringValue("ListSlot.Model["+ i +"].AdSlotName");
				adSlot.AdSlotType = _ctx.StringValue("ListSlot.Model["+ i +"].AdSlotType");
				adSlot.AdSlotTemplateId = _ctx.StringValue("ListSlot.Model["+ i +"].AdSlotTemplateId");
				adSlot.AdSlotStatus = _ctx.StringValue("ListSlot.Model["+ i +"].AdSlotStatus");
				adSlot.AdSlotCorporateStatus = _ctx.StringValue("ListSlot.Model["+ i +"].AdSlotCorporateStatus");
				adSlot.ExtInfo = _ctx.StringValue("ListSlot.Model["+ i +"].ExtInfo");
				adSlot.BlockingRule = _ctx.StringValue("ListSlot.Model["+ i +"].BlockingRule");
				adSlot.InspireScene = _ctx.StringValue("ListSlot.Model["+ i +"].InspireScene");
				adSlot.Version = _ctx.LongValue("ListSlot.Model["+ i +"].Version");

				listSlotResponse_model.Add(adSlot);
			}
			listSlotResponse.Model = listSlotResponse_model;
        
			return listSlotResponse;
        }
    }
}
