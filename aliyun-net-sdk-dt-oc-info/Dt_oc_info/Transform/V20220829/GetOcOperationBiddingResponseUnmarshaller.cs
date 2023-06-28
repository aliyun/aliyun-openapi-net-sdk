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
    public class GetOcOperationBiddingResponseUnmarshaller
    {
        public static GetOcOperationBiddingResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetOcOperationBiddingResponse getOcOperationBiddingResponse = new GetOcOperationBiddingResponse();

			getOcOperationBiddingResponse.HttpResponse = _ctx.HttpResponse;
			getOcOperationBiddingResponse.Code = _ctx.StringValue("GetOcOperationBidding.Code");
			getOcOperationBiddingResponse.Success = _ctx.BooleanValue("GetOcOperationBidding.Success");
			getOcOperationBiddingResponse.Message = _ctx.StringValue("GetOcOperationBidding.Message");
			getOcOperationBiddingResponse.TotalNum = _ctx.IntegerValue("GetOcOperationBidding.TotalNum");
			getOcOperationBiddingResponse.PageIndex = _ctx.IntegerValue("GetOcOperationBidding.PageIndex");
			getOcOperationBiddingResponse.PageNum = _ctx.IntegerValue("GetOcOperationBidding.PageNum");
			getOcOperationBiddingResponse.RequestId = _ctx.StringValue("GetOcOperationBidding.RequestId");

			List<GetOcOperationBiddingResponse.GetOcOperationBidding_DataItem> getOcOperationBiddingResponse_data = new List<GetOcOperationBiddingResponse.GetOcOperationBidding_DataItem>();
			for (int i = 0; i < _ctx.Length("GetOcOperationBidding.Data.Length"); i++) {
				GetOcOperationBiddingResponse.GetOcOperationBidding_DataItem dataItem = new GetOcOperationBiddingResponse.GetOcOperationBidding_DataItem();
				dataItem.EntName = _ctx.StringValue("GetOcOperationBidding.Data["+ i +"].EntName");
				dataItem.BidTitle = _ctx.StringValue("GetOcOperationBidding.Data["+ i +"].BidTitle");
				dataItem.BidType = _ctx.StringValue("GetOcOperationBidding.Data["+ i +"].BidType");
				dataItem.RegionName = _ctx.StringValue("GetOcOperationBidding.Data["+ i +"].RegionName");
				dataItem.BidIndustry = _ctx.StringValue("GetOcOperationBidding.Data["+ i +"].BidIndustry");
				dataItem.PublicDate = _ctx.StringValue("GetOcOperationBidding.Data["+ i +"].PublicDate");
				dataItem.ProjectNum = _ctx.StringValue("GetOcOperationBidding.Data["+ i +"].ProjectNum");
				dataItem.ProjectName = _ctx.StringValue("GetOcOperationBidding.Data["+ i +"].ProjectName");
				dataItem.ProjectAmount = _ctx.StringValue("GetOcOperationBidding.Data["+ i +"].ProjectAmount");
				dataItem.TenderEntName = _ctx.StringValue("GetOcOperationBidding.Data["+ i +"].TenderEntName");
				dataItem.AgentEntName = _ctx.StringValue("GetOcOperationBidding.Data["+ i +"].AgentEntName");
				dataItem.WinnerEntName = _ctx.StringValue("GetOcOperationBidding.Data["+ i +"].WinnerEntName");
				dataItem.Content = _ctx.StringValue("GetOcOperationBidding.Data["+ i +"].Content");
				dataItem.InfoType = _ctx.StringValue("GetOcOperationBidding.Data["+ i +"].InfoType");
				dataItem.SubType = _ctx.StringValue("GetOcOperationBidding.Data["+ i +"].SubType");
				dataItem.OpeningTime = _ctx.StringValue("GetOcOperationBidding.Data["+ i +"].OpeningTime");

				getOcOperationBiddingResponse_data.Add(dataItem);
			}
			getOcOperationBiddingResponse.Data = getOcOperationBiddingResponse_data;
        
			return getOcOperationBiddingResponse;
        }
    }
}
