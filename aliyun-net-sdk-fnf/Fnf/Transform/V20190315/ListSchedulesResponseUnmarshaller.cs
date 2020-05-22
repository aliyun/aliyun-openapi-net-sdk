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
using Aliyun.Acs.fnf.Model.V20190315;

namespace Aliyun.Acs.fnf.Transform.V20190315
{
    public class ListSchedulesResponseUnmarshaller
    {
        public static ListSchedulesResponse Unmarshall(UnmarshallerContext context)
        {
			ListSchedulesResponse listSchedulesResponse = new ListSchedulesResponse();

			listSchedulesResponse.HttpResponse = context.HttpResponse;
			listSchedulesResponse.RequestId = context.StringValue("ListSchedules.RequestId");
			listSchedulesResponse.NextToken = context.StringValue("ListSchedules.NextToken");

			List<ListSchedulesResponse.ListSchedules_SchedulesItem> listSchedulesResponse_schedules = new List<ListSchedulesResponse.ListSchedules_SchedulesItem>();
			for (int i = 0; i < context.Length("ListSchedules.Schedules.Length"); i++) {
				ListSchedulesResponse.ListSchedules_SchedulesItem schedulesItem = new ListSchedulesResponse.ListSchedules_SchedulesItem();
				schedulesItem.ScheduleName = context.StringValue("ListSchedules.Schedules["+ i +"].ScheduleName");
				schedulesItem.Description = context.StringValue("ListSchedules.Schedules["+ i +"].Description");
				schedulesItem.ScheduleId = context.StringValue("ListSchedules.Schedules["+ i +"].ScheduleId");
				schedulesItem.Payload = context.StringValue("ListSchedules.Schedules["+ i +"].Payload");
				schedulesItem.CronExpression = context.StringValue("ListSchedules.Schedules["+ i +"].CronExpression");
				schedulesItem.Enable = context.BooleanValue("ListSchedules.Schedules["+ i +"].Enable");
				schedulesItem.CreatedTime = context.StringValue("ListSchedules.Schedules["+ i +"].CreatedTime");
				schedulesItem.LastModifiedTime = context.StringValue("ListSchedules.Schedules["+ i +"].LastModifiedTime");

				listSchedulesResponse_schedules.Add(schedulesItem);
			}
			listSchedulesResponse.Schedules = listSchedulesResponse_schedules;
        
			return listSchedulesResponse;
        }
    }
}
