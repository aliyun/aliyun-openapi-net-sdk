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
using Aliyun.Acs.Copyright.Model.V20190123;

namespace Aliyun.Acs.Copyright.Transform.V20190123
{
    public class GetDownloadTicketsListResponseUnmarshaller
    {
        public static GetDownloadTicketsListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetDownloadTicketsListResponse getDownloadTicketsListResponse = new GetDownloadTicketsListResponse();

			getDownloadTicketsListResponse.HttpResponse = _ctx.HttpResponse;
			getDownloadTicketsListResponse.PageNum = _ctx.IntegerValue("GetDownloadTicketsList.PageNum");
			getDownloadTicketsListResponse.RequestId = _ctx.StringValue("GetDownloadTicketsList.RequestId");
			getDownloadTicketsListResponse.Success = _ctx.BooleanValue("GetDownloadTicketsList.Success");
			getDownloadTicketsListResponse.TotalItemNum = _ctx.IntegerValue("GetDownloadTicketsList.TotalItemNum");
			getDownloadTicketsListResponse.PageSize = _ctx.IntegerValue("GetDownloadTicketsList.PageSize");
			getDownloadTicketsListResponse.TotalPageNum = _ctx.IntegerValue("GetDownloadTicketsList.TotalPageNum");

			List<GetDownloadTicketsListResponse.GetDownloadTicketsList_DataItem> getDownloadTicketsListResponse_data = new List<GetDownloadTicketsListResponse.GetDownloadTicketsList_DataItem>();
			for (int i = 0; i < _ctx.Length("GetDownloadTicketsList.Data.Length"); i++) {
				GetDownloadTicketsListResponse.GetDownloadTicketsList_DataItem dataItem = new GetDownloadTicketsListResponse.GetDownloadTicketsList_DataItem();
				dataItem.Status = _ctx.StringValue("GetDownloadTicketsList.Data["+ i +"].Status");
				dataItem.Date = _ctx.LongValue("GetDownloadTicketsList.Data["+ i +"].Date");
				dataItem.DownloadId = _ctx.LongValue("GetDownloadTicketsList.Data["+ i +"].DownloadId");
				dataItem.Url = _ctx.StringValue("GetDownloadTicketsList.Data["+ i +"].Url");
				dataItem.Name = _ctx.StringValue("GetDownloadTicketsList.Data["+ i +"].Name");

				getDownloadTicketsListResponse_data.Add(dataItem);
			}
			getDownloadTicketsListResponse.Data = getDownloadTicketsListResponse_data;
        
			return getDownloadTicketsListResponse;
        }
    }
}
