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
    public class GetOcIpTrademarkResponseUnmarshaller
    {
        public static GetOcIpTrademarkResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetOcIpTrademarkResponse getOcIpTrademarkResponse = new GetOcIpTrademarkResponse();

			getOcIpTrademarkResponse.HttpResponse = _ctx.HttpResponse;
			getOcIpTrademarkResponse.Code = _ctx.StringValue("GetOcIpTrademark.Code");
			getOcIpTrademarkResponse.Success = _ctx.BooleanValue("GetOcIpTrademark.Success");
			getOcIpTrademarkResponse.Message = _ctx.StringValue("GetOcIpTrademark.Message");
			getOcIpTrademarkResponse.TotalNum = _ctx.IntegerValue("GetOcIpTrademark.TotalNum");
			getOcIpTrademarkResponse.PageIndex = _ctx.IntegerValue("GetOcIpTrademark.PageIndex");
			getOcIpTrademarkResponse.PageNum = _ctx.IntegerValue("GetOcIpTrademark.PageNum");
			getOcIpTrademarkResponse.RequestId = _ctx.StringValue("GetOcIpTrademark.RequestId");

			List<GetOcIpTrademarkResponse.GetOcIpTrademark_DataItem> getOcIpTrademarkResponse_data = new List<GetOcIpTrademarkResponse.GetOcIpTrademark_DataItem>();
			for (int i = 0; i < _ctx.Length("GetOcIpTrademark.Data.Length"); i++) {
				GetOcIpTrademarkResponse.GetOcIpTrademark_DataItem dataItem = new GetOcIpTrademarkResponse.GetOcIpTrademark_DataItem();
				dataItem.EntName = _ctx.StringValue("GetOcIpTrademark.Data["+ i +"].EntName");
				dataItem.TrademarkName = _ctx.StringValue("GetOcIpTrademark.Data["+ i +"].TrademarkName");
				dataItem.RegNum = _ctx.StringValue("GetOcIpTrademark.Data["+ i +"].RegNum");
				dataItem.TrademarkType = _ctx.StringValue("GetOcIpTrademark.Data["+ i +"].TrademarkType");
				dataItem.TrademarkForm = _ctx.StringValue("GetOcIpTrademark.Data["+ i +"].TrademarkForm");
				dataItem.TrademarkStatus = _ctx.StringValue("GetOcIpTrademark.Data["+ i +"].TrademarkStatus");
				dataItem.ApplyDate = _ctx.StringValue("GetOcIpTrademark.Data["+ i +"].ApplyDate");
				dataItem.ImageUrl = _ctx.StringValue("GetOcIpTrademark.Data["+ i +"].ImageUrl");
				dataItem.TypeName = _ctx.StringValue("GetOcIpTrademark.Data["+ i +"].TypeName");
				dataItem.Period = _ctx.StringValue("GetOcIpTrademark.Data["+ i +"].Period");
				dataItem.Agent = _ctx.StringValue("GetOcIpTrademark.Data["+ i +"].Agent");
				dataItem.RegPubNo = _ctx.StringValue("GetOcIpTrademark.Data["+ i +"].RegPubNo");
				dataItem.RegPubDate = _ctx.StringValue("GetOcIpTrademark.Data["+ i +"].RegPubDate");
				dataItem.FirstPubNo = _ctx.StringValue("GetOcIpTrademark.Data["+ i +"].FirstPubNo");
				dataItem.FirstPubDate = _ctx.StringValue("GetOcIpTrademark.Data["+ i +"].FirstPubDate");

				getOcIpTrademarkResponse_data.Add(dataItem);
			}
			getOcIpTrademarkResponse.Data = getOcIpTrademarkResponse_data;
        
			return getOcIpTrademarkResponse;
        }
    }
}
