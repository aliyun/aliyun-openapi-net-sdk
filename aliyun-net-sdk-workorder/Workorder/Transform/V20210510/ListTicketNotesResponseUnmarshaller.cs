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
using Aliyun.Acs.Workorder.Model.V20210510;

namespace Aliyun.Acs.Workorder.Transform.V20210510
{
    public class ListTicketNotesResponseUnmarshaller
    {
        public static ListTicketNotesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListTicketNotesResponse listTicketNotesResponse = new ListTicketNotesResponse();

			listTicketNotesResponse.HttpResponse = _ctx.HttpResponse;
			listTicketNotesResponse.Code = _ctx.IntegerValue("ListTicketNotes.Code");
			listTicketNotesResponse.RequestId = _ctx.StringValue("ListTicketNotes.RequestId");
			listTicketNotesResponse.Message = _ctx.StringValue("ListTicketNotes.Message");
			listTicketNotesResponse.Success = _ctx.BooleanValue("ListTicketNotes.Success");

			List<ListTicketNotesResponse.ListTicketNotes_DataItem> listTicketNotesResponse_data = new List<ListTicketNotesResponse.ListTicketNotes_DataItem>();
			for (int i = 0; i < _ctx.Length("ListTicketNotes.Data.Length"); i++) {
				ListTicketNotesResponse.ListTicketNotes_DataItem dataItem = new ListTicketNotesResponse.ListTicketNotes_DataItem();
				dataItem.Status = _ctx.IntegerValue("ListTicketNotes.Data["+ i +"].Status");
				dataItem.CreateTime = _ctx.LongValue("ListTicketNotes.Data["+ i +"].CreateTime");
				dataItem.Type = _ctx.IntegerValue("ListTicketNotes.Data["+ i +"].Type");
				dataItem.DialogId = _ctx.LongValue("ListTicketNotes.Data["+ i +"].DialogId");
				dataItem.Tip = _ctx.StringValue("ListTicketNotes.Data["+ i +"].Tip");

				ListTicketNotesResponse.ListTicketNotes_DataItem.ListTicketNotes_DataInfo dataInfo = new ListTicketNotesResponse.ListTicketNotes_DataItem.ListTicketNotes_DataInfo();
				dataInfo.Content = _ctx.StringValue("ListTicketNotes.Data["+ i +"].DataInfo.Content");
				dataInfo.Schema = _ctx.StringValue("ListTicketNotes.Data["+ i +"].DataInfo.Schema");
				dataItem.DataInfo = dataInfo;

				ListTicketNotesResponse.ListTicketNotes_DataItem.ListTicketNotes_UserInfo userInfo = new ListTicketNotesResponse.ListTicketNotes_DataItem.ListTicketNotes_UserInfo();
				userInfo.UserName = _ctx.StringValue("ListTicketNotes.Data["+ i +"].UserInfo.UserName");
				userInfo.Role = _ctx.IntegerValue("ListTicketNotes.Data["+ i +"].UserInfo.Role");
				dataItem.UserInfo = userInfo;

				listTicketNotesResponse_data.Add(dataItem);
			}
			listTicketNotesResponse.Data = listTicketNotesResponse_data;
        
			return listTicketNotesResponse;
        }
    }
}
