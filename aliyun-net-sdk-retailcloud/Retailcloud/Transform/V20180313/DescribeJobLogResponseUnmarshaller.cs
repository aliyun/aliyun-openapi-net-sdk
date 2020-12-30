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
using Aliyun.Acs.retailcloud.Model.V20180313;

namespace Aliyun.Acs.retailcloud.Transform.V20180313
{
    public class DescribeJobLogResponseUnmarshaller
    {
        public static DescribeJobLogResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeJobLogResponse describeJobLogResponse = new DescribeJobLogResponse();

			describeJobLogResponse.HttpResponse = _ctx.HttpResponse;
			describeJobLogResponse.Code = _ctx.IntegerValue("DescribeJobLog.Code");
			describeJobLogResponse.RequestId = _ctx.StringValue("DescribeJobLog.RequestId");
			describeJobLogResponse.ErrMsg = _ctx.StringValue("DescribeJobLog.ErrMsg");

			DescribeJobLogResponse.DescribeJobLog_Result result = new DescribeJobLogResponse.DescribeJobLog_Result();
			result.AppId = _ctx.LongValue("DescribeJobLog.Result.AppId");
			result.EnvId = _ctx.LongValue("DescribeJobLog.Result.EnvId");
			result.PodName = _ctx.StringValue("DescribeJobLog.Result.PodName");
			result.JobLog = _ctx.StringValue("DescribeJobLog.Result.JobLog");

			List<DescribeJobLogResponse.DescribeJobLog_Result.DescribeJobLog__Event> result_events = new List<DescribeJobLogResponse.DescribeJobLog_Result.DescribeJobLog__Event>();
			for (int i = 0; i < _ctx.Length("DescribeJobLog.Result.Events.Length"); i++) {
				DescribeJobLogResponse.DescribeJobLog_Result.DescribeJobLog__Event _event = new DescribeJobLogResponse.DescribeJobLog_Result.DescribeJobLog__Event();
				_event.Action = _ctx.StringValue("DescribeJobLog.Result.Events["+ i +"].Action");
				_event.Count = _ctx.IntegerValue("DescribeJobLog.Result.Events["+ i +"].Count");
				_event.EventTime = _ctx.StringValue("DescribeJobLog.Result.Events["+ i +"].EventTime");
				_event.FirstTimestamp = _ctx.StringValue("DescribeJobLog.Result.Events["+ i +"].FirstTimestamp");
				_event.LastTimestamp = _ctx.StringValue("DescribeJobLog.Result.Events["+ i +"].LastTimestamp");
				_event.Mesage = _ctx.StringValue("DescribeJobLog.Result.Events["+ i +"].Mesage");
				_event.Reason = _ctx.StringValue("DescribeJobLog.Result.Events["+ i +"].Reason");
				_event.Type = _ctx.StringValue("DescribeJobLog.Result.Events["+ i +"].Type");

				result_events.Add(_event);
			}
			result.Events = result_events;
			describeJobLogResponse.Result = result;
        
			return describeJobLogResponse;
        }
    }
}
