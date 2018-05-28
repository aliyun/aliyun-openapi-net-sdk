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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.jarvis.Model.V20180206;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.jarvis.Transform.V20180206
{
    public class DescribeCpmcPunishListResponseUnmarshaller
    {
        public static DescribeCpmcPunishListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeCpmcPunishListResponse describeCpmcPunishListResponse = new DescribeCpmcPunishListResponse();

			describeCpmcPunishListResponse.HttpResponse = context.HttpResponse;
			describeCpmcPunishListResponse.RequestId = context.StringValue("DescribeCpmcPunishList.RequestId");
			describeCpmcPunishListResponse.Module = context.StringValue("DescribeCpmcPunishList.Module");

			DescribeCpmcPunishListResponse.DescribeCpmcPunishList_PageInfo pageInfo = new DescribeCpmcPunishListResponse.DescribeCpmcPunishList_PageInfo();
			pageInfo.Total = context.IntegerValue("DescribeCpmcPunishList.PageInfo.Total");
			pageInfo.PageSize = context.IntegerValue("DescribeCpmcPunishList.PageInfo.PageSize");
			pageInfo.CurrentPage = context.IntegerValue("DescribeCpmcPunishList.PageInfo.CurrentPage");
			describeCpmcPunishListResponse.PageInfo = pageInfo;

			List<DescribeCpmcPunishListResponse.DescribeCpmcPunishList_Data> describeCpmcPunishListResponse_dataList = new List<DescribeCpmcPunishListResponse.DescribeCpmcPunishList_Data>();
			for (int i = 0; i < context.Length("DescribeCpmcPunishList.DataList.Length"); i++) {
				DescribeCpmcPunishListResponse.DescribeCpmcPunishList_Data data = new DescribeCpmcPunishListResponse.DescribeCpmcPunishList_Data();
				data.GmtCreate = context.StringValue("DescribeCpmcPunishList.DataList["+ i +"].GmtCreate");
				data.SrcPort = context.IntegerValue("DescribeCpmcPunishList.DataList["+ i +"].SrcPort");
				data.FeedBack = context.IntegerValue("DescribeCpmcPunishList.DataList["+ i +"].FeedBack");
				data.GmtExpire = context.StringValue("DescribeCpmcPunishList.DataList["+ i +"].GmtExpire");
				data.PunishType = context.StringValue("DescribeCpmcPunishList.DataList["+ i +"].PunishType");
				data.DstIP = context.StringValue("DescribeCpmcPunishList.DataList["+ i +"].DstIP");
				data.PunishResult = context.StringValue("DescribeCpmcPunishList.DataList["+ i +"].PunishResult");
				data.RegionId = context.StringValue("DescribeCpmcPunishList.DataList["+ i +"].RegionId");
				data.DstPort = context.IntegerValue("DescribeCpmcPunishList.DataList["+ i +"].DstPort");
				data.Protocol = context.StringValue("DescribeCpmcPunishList.DataList["+ i +"].Protocol");
				data.SrcIP = context.StringValue("DescribeCpmcPunishList.DataList["+ i +"].SrcIP");
				data.Reason = context.StringValue("DescribeCpmcPunishList.DataList["+ i +"].Reason");

				describeCpmcPunishListResponse_dataList.Add(data);
			}
			describeCpmcPunishListResponse.DataList = describeCpmcPunishListResponse_dataList;
        
			return describeCpmcPunishListResponse;
        }
    }
}