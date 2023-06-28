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
using Aliyun.Acs.dt_oc_info.Model.V20220829;

namespace Aliyun.Acs.dt_oc_info.Transform.V20220829
{
    public class GetOcIcEquityFrozenResponseUnmarshaller
    {
        public static GetOcIcEquityFrozenResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetOcIcEquityFrozenResponse getOcIcEquityFrozenResponse = new GetOcIcEquityFrozenResponse();

			getOcIcEquityFrozenResponse.HttpResponse = _ctx.HttpResponse;
			getOcIcEquityFrozenResponse.Code = _ctx.StringValue("GetOcIcEquityFrozen.Code");
			getOcIcEquityFrozenResponse.Success = _ctx.BooleanValue("GetOcIcEquityFrozen.Success");
			getOcIcEquityFrozenResponse.Message = _ctx.StringValue("GetOcIcEquityFrozen.Message");
			getOcIcEquityFrozenResponse.TotalNum = _ctx.IntegerValue("GetOcIcEquityFrozen.TotalNum");
			getOcIcEquityFrozenResponse.PageIndex = _ctx.IntegerValue("GetOcIcEquityFrozen.PageIndex");
			getOcIcEquityFrozenResponse.PageNum = _ctx.IntegerValue("GetOcIcEquityFrozen.PageNum");
			getOcIcEquityFrozenResponse.RequestId = _ctx.StringValue("GetOcIcEquityFrozen.RequestId");

			List<GetOcIcEquityFrozenResponse.GetOcIcEquityFrozen_DataItem> getOcIcEquityFrozenResponse_data = new List<GetOcIcEquityFrozenResponse.GetOcIcEquityFrozen_DataItem>();
			for (int i = 0; i < _ctx.Length("GetOcIcEquityFrozen.Data.Length"); i++) {
				GetOcIcEquityFrozenResponse.GetOcIcEquityFrozen_DataItem dataItem = new GetOcIcEquityFrozenResponse.GetOcIcEquityFrozen_DataItem();
				dataItem.Status = _ctx.StringValue("GetOcIcEquityFrozen.Data["+ i +"].Status");
				dataItem.FreezeExecPerson = _ctx.StringValue("GetOcIcEquityFrozen.Data["+ i +"].FreezeExecPerson");
				dataItem.FreezeAmount = _ctx.StringValue("GetOcIcEquityFrozen.Data["+ i +"].FreezeAmount");
				dataItem.FreezeCourt = _ctx.StringValue("GetOcIcEquityFrozen.Data["+ i +"].FreezeCourt");
				dataItem.FreezeNoticeNum = _ctx.StringValue("GetOcIcEquityFrozen.Data["+ i +"].FreezeNoticeNum");
				dataItem.FreezePublishDate = _ctx.StringValue("GetOcIcEquityFrozen.Data["+ i +"].FreezePublishDate");
				dataItem.FreezeCardType = _ctx.StringValue("GetOcIcEquityFrozen.Data["+ i +"].FreezeCardType");
				dataItem.FreezeCardNum = _ctx.StringValue("GetOcIcEquityFrozen.Data["+ i +"].FreezeCardNum");
				dataItem.FreezeExecItem = _ctx.StringValue("GetOcIcEquityFrozen.Data["+ i +"].FreezeExecItem");
				dataItem.FreezeStartDate = _ctx.StringValue("GetOcIcEquityFrozen.Data["+ i +"].FreezeStartDate");
				dataItem.FreezeEndDate = _ctx.StringValue("GetOcIcEquityFrozen.Data["+ i +"].FreezeEndDate");
				dataItem.UnfreezeCourt = _ctx.StringValue("GetOcIcEquityFrozen.Data["+ i +"].UnfreezeCourt");
				dataItem.UnfreezeAdjustNum = _ctx.StringValue("GetOcIcEquityFrozen.Data["+ i +"].UnfreezeAdjustNum");
				dataItem.UnfreezeReason = _ctx.StringValue("GetOcIcEquityFrozen.Data["+ i +"].UnfreezeReason");
				dataItem.UnfreezeDate = _ctx.StringValue("GetOcIcEquityFrozen.Data["+ i +"].UnfreezeDate");

				getOcIcEquityFrozenResponse_data.Add(dataItem);
			}
			getOcIcEquityFrozenResponse.Data = getOcIcEquityFrozenResponse_data;
        
			return getOcIcEquityFrozenResponse;
        }
    }
}
