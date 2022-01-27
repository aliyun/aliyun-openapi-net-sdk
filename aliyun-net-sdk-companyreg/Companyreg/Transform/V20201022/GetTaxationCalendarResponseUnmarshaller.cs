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
using Aliyun.Acs.companyreg.Model.V20201022;

namespace Aliyun.Acs.companyreg.Transform.V20201022
{
    public class GetTaxationCalendarResponseUnmarshaller
    {
        public static GetTaxationCalendarResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetTaxationCalendarResponse getTaxationCalendarResponse = new GetTaxationCalendarResponse();

			getTaxationCalendarResponse.HttpResponse = _ctx.HttpResponse;
			getTaxationCalendarResponse.RequestId = _ctx.StringValue("GetTaxationCalendar.RequestId");

			List<GetTaxationCalendarResponse.GetTaxationCalendar_CalendarListItem> getTaxationCalendarResponse_calendarList = new List<GetTaxationCalendarResponse.GetTaxationCalendar_CalendarListItem>();
			for (int i = 0; i < _ctx.Length("GetTaxationCalendar.CalendarList.Length"); i++) {
				GetTaxationCalendarResponse.GetTaxationCalendar_CalendarListItem calendarListItem = new GetTaxationCalendarResponse.GetTaxationCalendar_CalendarListItem();
				calendarListItem.DeclareEndDate = _ctx.StringValue("GetTaxationCalendar.CalendarList["+ i +"].DeclareEndDate");
				calendarListItem.DeclareProgress = _ctx.StringValue("GetTaxationCalendar.CalendarList["+ i +"].DeclareProgress");
				calendarListItem.DeclareStartDate = _ctx.StringValue("GetTaxationCalendar.CalendarList["+ i +"].DeclareStartDate");
				calendarListItem.Period = _ctx.StringValue("GetTaxationCalendar.CalendarList["+ i +"].Period");
				calendarListItem.UserTaxStartDate = _ctx.StringValue("GetTaxationCalendar.CalendarList["+ i +"].UserTaxStartDate");
				calendarListItem.UserTaxEndDate = _ctx.StringValue("GetTaxationCalendar.CalendarList["+ i +"].UserTaxEndDate");
				calendarListItem.BookkeepingStartDate = _ctx.StringValue("GetTaxationCalendar.CalendarList["+ i +"].BookkeepingStartDate");
				calendarListItem.BookkeepingEndDate = _ctx.StringValue("GetTaxationCalendar.CalendarList["+ i +"].BookkeepingEndDate");
				calendarListItem.IsCanBookkeeping = _ctx.BooleanValue("GetTaxationCalendar.CalendarList["+ i +"].IsCanBookkeeping");

				getTaxationCalendarResponse_calendarList.Add(calendarListItem);
			}
			getTaxationCalendarResponse.CalendarList = getTaxationCalendarResponse_calendarList;
        
			return getTaxationCalendarResponse;
        }
    }
}
