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
using Aliyun.Acs.jarvis.Model.V20180206;

namespace Aliyun.Acs.jarvis.Transform.V20180206
{
    public class DescribePunishListResponseUnmarshaller
    {
        public static DescribePunishListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribePunishListResponse describePunishListResponse = new DescribePunishListResponse();

			describePunishListResponse.HttpResponse = context.HttpResponse;
			describePunishListResponse.RequestId = context.StringValue("DescribePunishList.RequestId");
			describePunishListResponse.Module = context.StringValue("DescribePunishList.Module");

			DescribePunishListResponse.DescribePunishList_PageInfo pageInfo = new DescribePunishListResponse.DescribePunishList_PageInfo();
			pageInfo.Total = context.IntegerValue("DescribePunishList.PageInfo.Total");
			pageInfo.PageSize = context.IntegerValue("DescribePunishList.PageInfo.PageSize");
			pageInfo.CurrentPage = context.IntegerValue("DescribePunishList.PageInfo.CurrentPage");
			describePunishListResponse.PageInfo = pageInfo;

			List<DescribePunishListResponse.DescribePunishList_Data> describePunishListResponse_dataList = new List<DescribePunishListResponse.DescribePunishList_Data>();
			for (int i = 0; i < context.Length("DescribePunishList.DataList.Length"); i++) {
				DescribePunishListResponse.DescribePunishList_Data data = new DescribePunishListResponse.DescribePunishList_Data();
				data.GmtCreate = context.StringValue("DescribePunishList.DataList["+ i +"].GmtCreate");
				data.SrcPort = context.IntegerValue("DescribePunishList.DataList["+ i +"].SrcPort");
				data.FeedBack = context.IntegerValue("DescribePunishList.DataList["+ i +"].FeedBack");
				data.GmtExpire = context.StringValue("DescribePunishList.DataList["+ i +"].GmtExpire");
				data.PunishType = context.StringValue("DescribePunishList.DataList["+ i +"].PunishType");
				data.DstIP = context.StringValue("DescribePunishList.DataList["+ i +"].DstIP");
				data.PunishResult = context.StringValue("DescribePunishList.DataList["+ i +"].PunishResult");
				data.RegionId = context.StringValue("DescribePunishList.DataList["+ i +"].RegionId");
				data.DstPort = context.IntegerValue("DescribePunishList.DataList["+ i +"].DstPort");
				data.Protocol = context.StringValue("DescribePunishList.DataList["+ i +"].Protocol");
				data.SrcIP = context.StringValue("DescribePunishList.DataList["+ i +"].SrcIP");
				data.Reason = context.StringValue("DescribePunishList.DataList["+ i +"].Reason");

				describePunishListResponse_dataList.Add(data);
			}
			describePunishListResponse.DataList = describePunishListResponse_dataList;
        
			return describePunishListResponse;
        }
    }
}
