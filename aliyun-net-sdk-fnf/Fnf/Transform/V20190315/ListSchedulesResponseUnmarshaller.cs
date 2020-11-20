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
        public static ListSchedulesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListSchedulesResponse listSchedulesResponse = new ListSchedulesResponse();

			listSchedulesResponse.HttpResponse = _ctx.HttpResponse;
			listSchedulesResponse.RequestId = _ctx.StringValue("ListSchedules.RequestId");
			listSchedulesResponse.NextToken = _ctx.StringValue("ListSchedules.NextToken");

			List<ListSchedulesResponse.ListSchedules_SchedulesItem> listSchedulesResponse_schedules = new List<ListSchedulesResponse.ListSchedules_SchedulesItem>();
			for (int i = 0; i < _ctx.Length("ListSchedules.Schedules.Length"); i++) {
				ListSchedulesResponse.ListSchedules_SchedulesItem schedulesItem = new ListSchedulesResponse.ListSchedules_SchedulesItem();
				schedulesItem.ScheduleName = _ctx.StringValue("ListSchedules.Schedules["+ i +"].ScheduleName");
				schedulesItem.Description = _ctx.StringValue("ListSchedules.Schedules["+ i +"].Description");
				schedulesItem.ScheduleId = _ctx.StringValue("ListSchedules.Schedules["+ i +"].ScheduleId");
				schedulesItem.Payload = _ctx.StringValue("ListSchedules.Schedules["+ i +"].Payload");
				schedulesItem.CronExpression = _ctx.StringValue("ListSchedules.Schedules["+ i +"].CronExpression");
				schedulesItem.Enable = _ctx.BooleanValue("ListSchedules.Schedules["+ i +"].Enable");
				schedulesItem.CreatedTime = _ctx.StringValue("ListSchedules.Schedules["+ i +"].CreatedTime");
				schedulesItem.LastModifiedTime = _ctx.StringValue("ListSchedules.Schedules["+ i +"].LastModifiedTime");

				listSchedulesResponse_schedules.Add(schedulesItem);
			}
			listSchedulesResponse.Schedules = listSchedulesResponse_schedules;
        
			return listSchedulesResponse;
        }
    }
}
