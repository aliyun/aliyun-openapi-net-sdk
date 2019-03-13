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
using Aliyun.Acs.jarvis_public.Model.V20180621;

namespace Aliyun.Acs.jarvis_public.Transform.V20180621
{
    public class DescribeAttackEventResponseUnmarshaller
    {
        public static DescribeAttackEventResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeAttackEventResponse describeAttackEventResponse = new DescribeAttackEventResponse();

			describeAttackEventResponse.HttpResponse = context.HttpResponse;
			describeAttackEventResponse.RequestId = context.StringValue("DescribeAttackEvent.RequestId");
			describeAttackEventResponse.Module = context.StringValue("DescribeAttackEvent.Module");

			List<DescribeAttackEventResponse.DescribeAttackEvent__Event> describeAttackEventResponse_eventList = new List<DescribeAttackEventResponse.DescribeAttackEvent__Event>();
			for (int i = 0; i < context.Length("DescribeAttackEvent.EventList.Length"); i++) {
				DescribeAttackEventResponse.DescribeAttackEvent__Event _event = new DescribeAttackEventResponse.DescribeAttackEvent__Event();
				_event.VmIp = context.StringValue("DescribeAttackEvent.EventList["+ i +"].VmIp");
				_event.SourceIp = context.StringValue("DescribeAttackEvent.EventList["+ i +"].SourceIp");
				_event.Url = context.StringValue("DescribeAttackEvent.EventList["+ i +"].Url");
				_event.AttackType = context.StringValue("DescribeAttackEvent.EventList["+ i +"].AttackType");
				_event.GmtCreate = context.StringValue("DescribeAttackEvent.EventList["+ i +"].GmtCreate");
				_event.GmtCreateStamp = context.IntegerValue("DescribeAttackEvent.EventList["+ i +"].GmtCreateStamp");
				_event.GmtModified = context.StringValue("DescribeAttackEvent.EventList["+ i +"].GmtModified");

				describeAttackEventResponse_eventList.Add(_event);
			}
			describeAttackEventResponse.EventList = describeAttackEventResponse_eventList;
        
			return describeAttackEventResponse;
        }
    }
}
