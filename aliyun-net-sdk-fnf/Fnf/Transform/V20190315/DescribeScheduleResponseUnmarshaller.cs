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
    public class DescribeScheduleResponseUnmarshaller
    {
        public static DescribeScheduleResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeScheduleResponse describeScheduleResponse = new DescribeScheduleResponse();

			describeScheduleResponse.HttpResponse = _ctx.HttpResponse;
			describeScheduleResponse.RequestId = _ctx.StringValue("DescribeSchedule.RequestId");
			describeScheduleResponse.ScheduleName = _ctx.StringValue("DescribeSchedule.ScheduleName");
			describeScheduleResponse.Description = _ctx.StringValue("DescribeSchedule.Description");
			describeScheduleResponse.ScheduleId = _ctx.StringValue("DescribeSchedule.ScheduleId");
			describeScheduleResponse.Payload = _ctx.StringValue("DescribeSchedule.Payload");
			describeScheduleResponse.CronExpression = _ctx.StringValue("DescribeSchedule.CronExpression");
			describeScheduleResponse.Enable = _ctx.BooleanValue("DescribeSchedule.Enable");
			describeScheduleResponse.CreatedTime = _ctx.StringValue("DescribeSchedule.CreatedTime");
			describeScheduleResponse.LastModifiedTime = _ctx.StringValue("DescribeSchedule.LastModifiedTime");
        
			return describeScheduleResponse;
        }
    }
}
