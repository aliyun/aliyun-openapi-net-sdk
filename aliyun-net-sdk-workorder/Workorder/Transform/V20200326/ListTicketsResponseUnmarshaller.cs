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
using Aliyun.Acs.Workorder.Model.V20200326;

namespace Aliyun.Acs.Workorder.Transform.V20200326
{
    public class ListTicketsResponseUnmarshaller
    {
        public static ListTicketsResponse Unmarshall(UnmarshallerContext context)
        {
			ListTicketsResponse listTicketsResponse = new ListTicketsResponse();

			listTicketsResponse.HttpResponse = context.HttpResponse;
			listTicketsResponse.Code = context.IntegerValue("ListTickets.Code");
			listTicketsResponse.Success = context.BooleanValue("ListTickets.Success");
			listTicketsResponse.Message = context.StringValue("ListTickets.Message");
			listTicketsResponse.RequestId = context.StringValue("ListTickets.RequestId");

			ListTicketsResponse.ListTickets_Data data = new ListTicketsResponse.ListTickets_Data();
			data.Total = context.IntegerValue("ListTickets.Data.Total");
			data.PageSize = context.IntegerValue("ListTickets.Data.PageSize");
			data.CurrentPage = context.IntegerValue("ListTickets.Data.CurrentPage");

			List<ListTicketsResponse.ListTickets_Data.ListTickets_ListItem> data_list = new List<ListTicketsResponse.ListTickets_Data.ListTickets_ListItem>();
			for (int i = 0; i < context.Length("ListTickets.Data.List.Length"); i++) {
				ListTicketsResponse.ListTickets_Data.ListTickets_ListItem listItem = new ListTicketsResponse.ListTickets_Data.ListTickets_ListItem();
				listItem.AddTime = context.IntegerValue("ListTickets.Data.List["+ i +"].AddTime");
				listItem.TicketStatus = context.StringValue("ListTickets.Data.List["+ i +"].TicketStatus");
				listItem.CreatorId = context.StringValue("ListTickets.Data.List["+ i +"].CreatorId");
				listItem.Id = context.StringValue("ListTickets.Data.List["+ i +"].Id");
				listItem.Title = context.StringValue("ListTickets.Data.List["+ i +"].Title");

				data_list.Add(listItem);
			}
			data.List = data_list;
			listTicketsResponse.Data = data;
        
			return listTicketsResponse;
        }
    }
}
