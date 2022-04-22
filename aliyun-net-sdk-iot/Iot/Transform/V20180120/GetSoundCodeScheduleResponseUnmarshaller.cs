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
using Aliyun.Acs.Iot.Model.V20180120;

namespace Aliyun.Acs.Iot.Transform.V20180120
{
    public class GetSoundCodeScheduleResponseUnmarshaller
    {
        public static GetSoundCodeScheduleResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetSoundCodeScheduleResponse getSoundCodeScheduleResponse = new GetSoundCodeScheduleResponse();

			getSoundCodeScheduleResponse.HttpResponse = _ctx.HttpResponse;
			getSoundCodeScheduleResponse.RequestId = _ctx.StringValue("GetSoundCodeSchedule.RequestId");
			getSoundCodeScheduleResponse.Success = _ctx.BooleanValue("GetSoundCodeSchedule.Success");
			getSoundCodeScheduleResponse.Code = _ctx.StringValue("GetSoundCodeSchedule.Code");
			getSoundCodeScheduleResponse.ErrorMessage = _ctx.StringValue("GetSoundCodeSchedule.ErrorMessage");

			GetSoundCodeScheduleResponse.GetSoundCodeSchedule_Data data = new GetSoundCodeScheduleResponse.GetSoundCodeSchedule_Data();
			data.ScheduleCode = _ctx.StringValue("GetSoundCodeSchedule.Data.ScheduleCode");
			data.Name = _ctx.StringValue("GetSoundCodeSchedule.Data.Name");
			data.Description = _ctx.StringValue("GetSoundCodeSchedule.Data.Description");
			data.GmtCreate = _ctx.LongValue("GetSoundCodeSchedule.Data.GmtCreate");
			data.Status = _ctx.StringValue("GetSoundCodeSchedule.Data.Status");
			data.StartTime = _ctx.StringValue("GetSoundCodeSchedule.Data.StartTime");
			data.EndTime = _ctx.StringValue("GetSoundCodeSchedule.Data.EndTime");
			data.StartDate = _ctx.StringValue("GetSoundCodeSchedule.Data.StartDate");
			data.EndDate = _ctx.StringValue("GetSoundCodeSchedule.Data.EndDate");
			getSoundCodeScheduleResponse.Data = data;
        
			return getSoundCodeScheduleResponse;
        }
    }
}
