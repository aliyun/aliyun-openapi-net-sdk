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
    public class GetOcIcEquityPledgeResponseUnmarshaller
    {
        public static GetOcIcEquityPledgeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetOcIcEquityPledgeResponse getOcIcEquityPledgeResponse = new GetOcIcEquityPledgeResponse();

			getOcIcEquityPledgeResponse.HttpResponse = _ctx.HttpResponse;
			getOcIcEquityPledgeResponse.Code = _ctx.StringValue("GetOcIcEquityPledge.Code");
			getOcIcEquityPledgeResponse.Success = _ctx.BooleanValue("GetOcIcEquityPledge.Success");
			getOcIcEquityPledgeResponse.Message = _ctx.StringValue("GetOcIcEquityPledge.Message");
			getOcIcEquityPledgeResponse.TotalNum = _ctx.IntegerValue("GetOcIcEquityPledge.TotalNum");
			getOcIcEquityPledgeResponse.PageIndex = _ctx.IntegerValue("GetOcIcEquityPledge.PageIndex");
			getOcIcEquityPledgeResponse.PageNum = _ctx.IntegerValue("GetOcIcEquityPledge.PageNum");
			getOcIcEquityPledgeResponse.RequestId = _ctx.StringValue("GetOcIcEquityPledge.RequestId");

			List<GetOcIcEquityPledgeResponse.GetOcIcEquityPledge_DataItem> getOcIcEquityPledgeResponse_data = new List<GetOcIcEquityPledgeResponse.GetOcIcEquityPledge_DataItem>();
			for (int i = 0; i < _ctx.Length("GetOcIcEquityPledge.Data.Length"); i++) {
				GetOcIcEquityPledgeResponse.GetOcIcEquityPledge_DataItem dataItem = new GetOcIcEquityPledgeResponse.GetOcIcEquityPledge_DataItem();
				dataItem.Number = _ctx.StringValue("GetOcIcEquityPledge.Data["+ i +"].Number");
				dataItem.Pledgor = _ctx.StringValue("GetOcIcEquityPledge.Data["+ i +"].Pledgor");
				dataItem.RelatedComp = _ctx.StringValue("GetOcIcEquityPledge.Data["+ i +"].RelatedComp");
				dataItem.Pawnee = _ctx.StringValue("GetOcIcEquityPledge.Data["+ i +"].Pawnee");
				dataItem.RegDate = _ctx.StringValue("GetOcIcEquityPledge.Data["+ i +"].RegDate");
				dataItem.Status = _ctx.StringValue("GetOcIcEquityPledge.Data["+ i +"].Status");
				dataItem.PledgorAmount = _ctx.StringValue("GetOcIcEquityPledge.Data["+ i +"].PledgorAmount");
				dataItem.PawneeIdentifyNo = _ctx.StringValue("GetOcIcEquityPledge.Data["+ i +"].PawneeIdentifyNo");
				dataItem.PledgorIdentifyNo = _ctx.StringValue("GetOcIcEquityPledge.Data["+ i +"].PledgorIdentifyNo");
				dataItem.PublicDate = _ctx.StringValue("GetOcIcEquityPledge.Data["+ i +"].PublicDate");

				getOcIcEquityPledgeResponse_data.Add(dataItem);
			}
			getOcIcEquityPledgeResponse.Data = getOcIcEquityPledgeResponse_data;
        
			return getOcIcEquityPledgeResponse;
        }
    }
}
