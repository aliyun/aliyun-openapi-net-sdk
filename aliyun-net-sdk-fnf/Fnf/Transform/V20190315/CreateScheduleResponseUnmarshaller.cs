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
    public class CreateScheduleResponseUnmarshaller
    {
        public static CreateScheduleResponse Unmarshall(UnmarshallerContext context)
        {
			CreateScheduleResponse createScheduleResponse = new CreateScheduleResponse();

			createScheduleResponse.HttpResponse = context.HttpResponse;
			createScheduleResponse.RequestId = context.StringValue("CreateSchedule.RequestId");
			createScheduleResponse.ScheduleName = context.StringValue("CreateSchedule.ScheduleName");
			createScheduleResponse.Description = context.StringValue("CreateSchedule.Description");
			createScheduleResponse.ScheduleId = context.StringValue("CreateSchedule.ScheduleId");
			createScheduleResponse.Payload = context.StringValue("CreateSchedule.Payload");
			createScheduleResponse.CronExpression = context.StringValue("CreateSchedule.CronExpression");
			createScheduleResponse.Enable = context.BooleanValue("CreateSchedule.Enable");
			createScheduleResponse.CreatedTime = context.StringValue("CreateSchedule.CreatedTime");
			createScheduleResponse.LastModifiedTime = context.StringValue("CreateSchedule.LastModifiedTime");
        
			return createScheduleResponse;
        }
    }
}
