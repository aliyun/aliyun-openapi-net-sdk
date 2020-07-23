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
        public static DescribeJobLogResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeJobLogResponse describeJobLogResponse = new DescribeJobLogResponse();

			describeJobLogResponse.HttpResponse = context.HttpResponse;
			describeJobLogResponse.Code = context.IntegerValue("DescribeJobLog.Code");
			describeJobLogResponse.RequestId = context.StringValue("DescribeJobLog.RequestId");
			describeJobLogResponse.ErrMsg = context.StringValue("DescribeJobLog.ErrMsg");

			DescribeJobLogResponse.DescribeJobLog_Result result = new DescribeJobLogResponse.DescribeJobLog_Result();
			result.AppId = context.LongValue("DescribeJobLog.Result.AppId");
			result.EnvId = context.LongValue("DescribeJobLog.Result.EnvId");
			result.PodName = context.StringValue("DescribeJobLog.Result.PodName");
			result.JobLog = context.StringValue("DescribeJobLog.Result.JobLog");

			List<DescribeJobLogResponse.DescribeJobLog_Result.DescribeJobLog__Event> result_events = new List<DescribeJobLogResponse.DescribeJobLog_Result.DescribeJobLog__Event>();
			for (int i = 0; i < context.Length("DescribeJobLog.Result.Events.Length"); i++) {
				DescribeJobLogResponse.DescribeJobLog_Result.DescribeJobLog__Event _event = new DescribeJobLogResponse.DescribeJobLog_Result.DescribeJobLog__Event();
				_event.Action = context.StringValue("DescribeJobLog.Result.Events["+ i +"].Action");
				_event.Count = context.IntegerValue("DescribeJobLog.Result.Events["+ i +"].Count");
				_event.EventTime = context.StringValue("DescribeJobLog.Result.Events["+ i +"].EventTime");
				_event.FirstTimestamp = context.StringValue("DescribeJobLog.Result.Events["+ i +"].FirstTimestamp");
				_event.LastTimestamp = context.StringValue("DescribeJobLog.Result.Events["+ i +"].LastTimestamp");
				_event.Mesage = context.StringValue("DescribeJobLog.Result.Events["+ i +"].Mesage");
				_event.Reason = context.StringValue("DescribeJobLog.Result.Events["+ i +"].Reason");
				_event.Type = context.StringValue("DescribeJobLog.Result.Events["+ i +"].Type");

				result_events.Add(_event);
			}
			result.Events = result_events;
			describeJobLogResponse.Result = result;
        
			return describeJobLogResponse;
        }
    }
}
