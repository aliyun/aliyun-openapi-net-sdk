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
    public class DescribeSagWifiResponseUnmarshaller
    {
        public static DescribeSagWifiResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSagWifiResponse describeSagWifiResponse = new DescribeSagWifiResponse();

			describeSagWifiResponse.HttpResponse = context.HttpResponse;
			describeSagWifiResponse.RequestId = context.StringValue("DescribeSagWifi.RequestId");
			describeSagWifiResponse.IsEnable = context.StringValue("DescribeSagWifi.IsEnable");
			describeSagWifiResponse.Ssid = context.StringValue("DescribeSagWifi.Ssid");
			describeSagWifiResponse.IsBroadcast = context.StringValue("DescribeSagWifi.IsBroadcast");
			describeSagWifiResponse.Channel = context.StringValue("DescribeSagWifi.Channel");
			describeSagWifiResponse.Bandwidth = context.StringValue("DescribeSagWifi.Bandwidth");
			describeSagWifiResponse.IsAuth = context.StringValue("DescribeSagWifi.IsAuth");
			describeSagWifiResponse.AuthenticationType = context.StringValue("DescribeSagWifi.AuthenticationType");
			describeSagWifiResponse.EncryptAlgorithm = context.StringValue("DescribeSagWifi.EncryptAlgorithm");

			List<DescribeSagWifiResponse.DescribeSagWifi_TaskState> describeSagWifiResponse_taskStates = new List<DescribeSagWifiResponse.DescribeSagWifi_TaskState>();
			for (int i = 0; i < context.Length("DescribeSagWifi.TaskStates.Length"); i++) {
				DescribeSagWifiResponse.DescribeSagWifi_TaskState taskState = new DescribeSagWifiResponse.DescribeSagWifi_TaskState();
				taskState.State = context.StringValue("DescribeSagWifi.TaskStates["+ i +"].State");
				taskState.ErrorCode = context.StringValue("DescribeSagWifi.TaskStates["+ i +"].ErrorCode");
				taskState.ErrorMessage = context.StringValue("DescribeSagWifi.TaskStates["+ i +"].ErrorMessage");
				taskState.CreateTime = context.StringValue("DescribeSagWifi.TaskStates["+ i +"].CreateTime");

				describeSagWifiResponse_taskStates.Add(taskState);
			}
			describeSagWifiResponse.TaskStates = describeSagWifiResponse_taskStates;
        
			return describeSagWifiResponse;
        }
    }
}
