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
using Aliyun.Acs.Workorder.Model.V20210610;

namespace Aliyun.Acs.Workorder.Transform.V20210610
{
    public class ListTicketsResponseUnmarshaller
    {
        public static ListTicketsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListTicketsResponse listTicketsResponse = new ListTicketsResponse();

			listTicketsResponse.HttpResponse = _ctx.HttpResponse;
			listTicketsResponse.Code = _ctx.IntegerValue("ListTickets.Code");
			listTicketsResponse.RequestId = _ctx.StringValue("ListTickets.RequestId");
			listTicketsResponse.Message = _ctx.StringValue("ListTickets.Message");
			listTicketsResponse.PageNumber = _ctx.IntegerValue("ListTickets.PageNumber");
			listTicketsResponse.PageSize = _ctx.IntegerValue("ListTickets.PageSize");
			listTicketsResponse.TotalCount = _ctx.LongValue("ListTickets.TotalCount");
			listTicketsResponse.Success = _ctx.BooleanValue("ListTickets.Success");

			List<ListTicketsResponse.ListTickets_DataItem> listTicketsResponse_data = new List<ListTicketsResponse.ListTickets_DataItem>();
			for (int i = 0; i < _ctx.Length("ListTickets.Data.Length"); i++) {
				ListTicketsResponse.ListTickets_DataItem dataItem = new ListTicketsResponse.ListTickets_DataItem();
				dataItem.Title = _ctx.StringValue("ListTickets.Data["+ i +"].Title");
				dataItem.TicketId = _ctx.StringValue("ListTickets.Data["+ i +"].TicketId");

				ListTicketsResponse.ListTickets_DataItem.ListTickets_Status status = new ListTicketsResponse.ListTickets_DataItem.ListTickets_Status();
				status.Label = _ctx.StringValue("ListTickets.Data["+ i +"].Status.Label");
				status._Value = _ctx.StringValue("ListTickets.Data["+ i +"].Status.Value");
				dataItem.Status = status;

				listTicketsResponse_data.Add(dataItem);
			}
			listTicketsResponse.Data = listTicketsResponse_data;
        
			return listTicketsResponse;
        }
    }
}
