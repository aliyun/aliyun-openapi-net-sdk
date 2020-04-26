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
    public class ListTicketNotesResponseUnmarshaller
    {
        public static ListTicketNotesResponse Unmarshall(UnmarshallerContext context)
        {
			ListTicketNotesResponse listTicketNotesResponse = new ListTicketNotesResponse();

			listTicketNotesResponse.HttpResponse = context.HttpResponse;
			listTicketNotesResponse.Code = context.IntegerValue("ListTicketNotes.Code");
			listTicketNotesResponse.Success = context.BooleanValue("ListTicketNotes.Success");
			listTicketNotesResponse.Message = context.StringValue("ListTicketNotes.Message");
			listTicketNotesResponse.RequestId = context.StringValue("ListTicketNotes.RequestId");

			ListTicketNotesResponse.ListTicketNotes_Data data = new ListTicketNotesResponse.ListTicketNotes_Data();

			List<ListTicketNotesResponse.ListTicketNotes_Data.ListTicketNotes_ListItem> data_list = new List<ListTicketNotesResponse.ListTicketNotes_Data.ListTicketNotes_ListItem>();
			for (int i = 0; i < context.Length("ListTicketNotes.Data.List.Length"); i++) {
				ListTicketNotesResponse.ListTicketNotes_Data.ListTicketNotes_ListItem listItem = new ListTicketNotesResponse.ListTicketNotes_Data.ListTicketNotes_ListItem();
				listItem.FromOfficial = context.BooleanValue("ListTicketNotes.Data.List["+ i +"].FromOfficial");
				listItem.GmtCreated = context.IntegerValue("ListTicketNotes.Data.List["+ i +"].GmtCreated");
				listItem.NoteId = context.StringValue("ListTicketNotes.Data.List["+ i +"].NoteId");
				listItem.Content = context.StringValue("ListTicketNotes.Data.List["+ i +"].Content");

				data_list.Add(listItem);
			}
			data.List = data_list;
			listTicketNotesResponse.Data = data;
        
			return listTicketNotesResponse;
        }
    }
}
