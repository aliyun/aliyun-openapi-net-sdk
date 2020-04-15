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
using Aliyun.Acs.Smartag.Model.V20180313;

namespace Aliyun.Acs.Smartag.Transform.V20180313
{
    public class DescribeSagUserDnsResponseUnmarshaller
    {
        public static DescribeSagUserDnsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSagUserDnsResponse describeSagUserDnsResponse = new DescribeSagUserDnsResponse();

			describeSagUserDnsResponse.HttpResponse = context.HttpResponse;
			describeSagUserDnsResponse.RequestId = context.StringValue("DescribeSagUserDns.RequestId");
			describeSagUserDnsResponse.MasterDns = context.StringValue("DescribeSagUserDns.MasterDns");
			describeSagUserDnsResponse.SlaveDns = context.StringValue("DescribeSagUserDns.SlaveDns");

			List<DescribeSagUserDnsResponse.DescribeSagUserDns_TaskState> describeSagUserDnsResponse_taskStates = new List<DescribeSagUserDnsResponse.DescribeSagUserDns_TaskState>();
			for (int i = 0; i < context.Length("DescribeSagUserDns.TaskStates.Length"); i++) {
				DescribeSagUserDnsResponse.DescribeSagUserDns_TaskState taskState = new DescribeSagUserDnsResponse.DescribeSagUserDns_TaskState();
				taskState.State = context.StringValue("DescribeSagUserDns.TaskStates["+ i +"].State");
				taskState.ErrorCode = context.StringValue("DescribeSagUserDns.TaskStates["+ i +"].ErrorCode");
				taskState.ErrorMessage = context.StringValue("DescribeSagUserDns.TaskStates["+ i +"].ErrorMessage");
				taskState.CreateTime = context.StringValue("DescribeSagUserDns.TaskStates["+ i +"].CreateTime");

				describeSagUserDnsResponse_taskStates.Add(taskState);
			}
			describeSagUserDnsResponse.TaskStates = describeSagUserDnsResponse_taskStates;
        
			return describeSagUserDnsResponse;
        }
    }
}
