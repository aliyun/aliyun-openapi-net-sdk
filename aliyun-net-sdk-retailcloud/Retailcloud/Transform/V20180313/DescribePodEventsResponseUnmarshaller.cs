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
    public class DescribePodEventsResponseUnmarshaller
    {
        public static DescribePodEventsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePodEventsResponse describePodEventsResponse = new DescribePodEventsResponse();

			describePodEventsResponse.HttpResponse = _ctx.HttpResponse;
			describePodEventsResponse.Code = _ctx.IntegerValue("DescribePodEvents.Code");
			describePodEventsResponse.ErrMsg = _ctx.StringValue("DescribePodEvents.ErrMsg");
			describePodEventsResponse.RequestId = _ctx.StringValue("DescribePodEvents.RequestId");
			describePodEventsResponse.Success = _ctx.BooleanValue("DescribePodEvents.Success");

			DescribePodEventsResponse.DescribePodEvents_Result result = new DescribePodEventsResponse.DescribePodEvents_Result();
			result.DeployOrderName = _ctx.StringValue("DescribePodEvents.Result.DeployOrderName");

			List<DescribePodEventsResponse.DescribePodEvents_Result.DescribePodEvents_PodEvent> result_podEvents = new List<DescribePodEventsResponse.DescribePodEvents_Result.DescribePodEvents_PodEvent>();
			for (int i = 0; i < _ctx.Length("DescribePodEvents.Result.PodEvents.Length"); i++) {
				DescribePodEventsResponse.DescribePodEvents_Result.DescribePodEvents_PodEvent podEvent = new DescribePodEventsResponse.DescribePodEvents_Result.DescribePodEvents_PodEvent();
				podEvent.Action = _ctx.StringValue("DescribePodEvents.Result.PodEvents["+ i +"].Action");
				podEvent.Count = _ctx.IntegerValue("DescribePodEvents.Result.PodEvents["+ i +"].Count");
				podEvent.EventTime = _ctx.StringValue("DescribePodEvents.Result.PodEvents["+ i +"].EventTime");
				podEvent.FirstTimestamp = _ctx.StringValue("DescribePodEvents.Result.PodEvents["+ i +"].FirstTimestamp");
				podEvent.LastTimestamp = _ctx.StringValue("DescribePodEvents.Result.PodEvents["+ i +"].LastTimestamp");
				podEvent.Message = _ctx.StringValue("DescribePodEvents.Result.PodEvents["+ i +"].Message");
				podEvent.Reason = _ctx.StringValue("DescribePodEvents.Result.PodEvents["+ i +"].Reason");
				podEvent.Type = _ctx.StringValue("DescribePodEvents.Result.PodEvents["+ i +"].Type");

				result_podEvents.Add(podEvent);
			}
			result.PodEvents = result_podEvents;
			describePodEventsResponse.Result = result;
        
			return describePodEventsResponse;
        }
    }
}
