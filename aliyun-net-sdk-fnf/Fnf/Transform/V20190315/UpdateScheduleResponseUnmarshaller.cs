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
    public class UpdateScheduleResponseUnmarshaller
    {
        public static UpdateScheduleResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdateScheduleResponse updateScheduleResponse = new UpdateScheduleResponse();

			updateScheduleResponse.HttpResponse = _ctx.HttpResponse;
			updateScheduleResponse.RequestId = _ctx.StringValue("UpdateSchedule.RequestId");
			updateScheduleResponse.ScheduleName = _ctx.StringValue("UpdateSchedule.ScheduleName");
			updateScheduleResponse.Description = _ctx.StringValue("UpdateSchedule.Description");
			updateScheduleResponse.ScheduleId = _ctx.StringValue("UpdateSchedule.ScheduleId");
			updateScheduleResponse.Payload = _ctx.StringValue("UpdateSchedule.Payload");
			updateScheduleResponse.CronExpression = _ctx.StringValue("UpdateSchedule.CronExpression");
			updateScheduleResponse.Enable = _ctx.BooleanValue("UpdateSchedule.Enable");
			updateScheduleResponse.CreatedTime = _ctx.StringValue("UpdateSchedule.CreatedTime");
			updateScheduleResponse.LastModifiedTime = _ctx.StringValue("UpdateSchedule.LastModifiedTime");
        
			return updateScheduleResponse;
        }
    }
}
