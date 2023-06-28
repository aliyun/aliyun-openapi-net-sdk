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
    public class GetOcJusticeAuctionResponseUnmarshaller
    {
        public static GetOcJusticeAuctionResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetOcJusticeAuctionResponse getOcJusticeAuctionResponse = new GetOcJusticeAuctionResponse();

			getOcJusticeAuctionResponse.HttpResponse = _ctx.HttpResponse;
			getOcJusticeAuctionResponse.Code = _ctx.StringValue("GetOcJusticeAuction.Code");
			getOcJusticeAuctionResponse.Success = _ctx.BooleanValue("GetOcJusticeAuction.Success");
			getOcJusticeAuctionResponse.Message = _ctx.StringValue("GetOcJusticeAuction.Message");
			getOcJusticeAuctionResponse.TotalNum = _ctx.IntegerValue("GetOcJusticeAuction.TotalNum");
			getOcJusticeAuctionResponse.PageIndex = _ctx.IntegerValue("GetOcJusticeAuction.PageIndex");
			getOcJusticeAuctionResponse.PageNum = _ctx.IntegerValue("GetOcJusticeAuction.PageNum");
			getOcJusticeAuctionResponse.RequestId = _ctx.StringValue("GetOcJusticeAuction.RequestId");

			List<GetOcJusticeAuctionResponse.GetOcJusticeAuction_DataItem> getOcJusticeAuctionResponse_data = new List<GetOcJusticeAuctionResponse.GetOcJusticeAuction_DataItem>();
			for (int i = 0; i < _ctx.Length("GetOcJusticeAuction.Data.Length"); i++) {
				GetOcJusticeAuctionResponse.GetOcJusticeAuction_DataItem dataItem = new GetOcJusticeAuctionResponse.GetOcJusticeAuction_DataItem();
				dataItem.EntName = _ctx.StringValue("GetOcJusticeAuction.Data["+ i +"].EntName");
				dataItem.AuctionName = _ctx.StringValue("GetOcJusticeAuction.Data["+ i +"].AuctionName");
				dataItem.Court = _ctx.StringValue("GetOcJusticeAuction.Data["+ i +"].Court");
				dataItem.AuctionDate = _ctx.StringValue("GetOcJusticeAuction.Data["+ i +"].AuctionDate");
				dataItem.StartPrice = _ctx.StringValue("GetOcJusticeAuction.Data["+ i +"].StartPrice");
				dataItem.EstPrice = _ctx.StringValue("GetOcJusticeAuction.Data["+ i +"].EstPrice");
				dataItem.Owner = _ctx.StringValue("GetOcJusticeAuction.Data["+ i +"].Owner");
				dataItem.Restrict = _ctx.StringValue("GetOcJusticeAuction.Data["+ i +"].Restrict");
				dataItem.Certificate = _ctx.StringValue("GetOcJusticeAuction.Data["+ i +"].Certificate");
				dataItem.Document = _ctx.StringValue("GetOcJusticeAuction.Data["+ i +"].Document");
				dataItem.Basis = _ctx.StringValue("GetOcJusticeAuction.Data["+ i +"].Basis");
				dataItem.Description = _ctx.StringValue("GetOcJusticeAuction.Data["+ i +"].Description");

				getOcJusticeAuctionResponse_data.Add(dataItem);
			}
			getOcJusticeAuctionResponse.Data = getOcJusticeAuctionResponse_data;
        
			return getOcJusticeAuctionResponse;
        }
    }
}
