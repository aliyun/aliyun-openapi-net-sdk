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
    public class DescribeSagWanListResponseUnmarshaller
    {
        public static DescribeSagWanListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSagWanListResponse describeSagWanListResponse = new DescribeSagWanListResponse();

			describeSagWanListResponse.HttpResponse = context.HttpResponse;
			describeSagWanListResponse.RequestId = context.StringValue("DescribeSagWanList.RequestId");

			List<DescribeSagWanListResponse.DescribeSagWanList_Wan> describeSagWanListResponse_wans = new List<DescribeSagWanListResponse.DescribeSagWanList_Wan>();
			for (int i = 0; i < context.Length("DescribeSagWanList.Wans.Length"); i++) {
				DescribeSagWanListResponse.DescribeSagWanList_Wan wan = new DescribeSagWanListResponse.DescribeSagWanList_Wan();
				wan.PortName = context.StringValue("DescribeSagWanList.Wans["+ i +"].PortName");
				wan.IPType = context.StringValue("DescribeSagWanList.Wans["+ i +"].IPType");
				wan.IP = context.StringValue("DescribeSagWanList.Wans["+ i +"].IP");
				wan.Mask = context.StringValue("DescribeSagWanList.Wans["+ i +"].Mask");
				wan.Gateway = context.StringValue("DescribeSagWanList.Wans["+ i +"].Gateway");
				wan.Username = context.StringValue("DescribeSagWanList.Wans["+ i +"].Username");

				describeSagWanListResponse_wans.Add(wan);
			}
			describeSagWanListResponse.Wans = describeSagWanListResponse_wans;

			List<DescribeSagWanListResponse.DescribeSagWanList_TaskState> describeSagWanListResponse_taskStates = new List<DescribeSagWanListResponse.DescribeSagWanList_TaskState>();
			for (int i = 0; i < context.Length("DescribeSagWanList.TaskStates.Length"); i++) {
				DescribeSagWanListResponse.DescribeSagWanList_TaskState taskState = new DescribeSagWanListResponse.DescribeSagWanList_TaskState();
				taskState.State = context.StringValue("DescribeSagWanList.TaskStates["+ i +"].State");
				taskState.ErrorCode = context.StringValue("DescribeSagWanList.TaskStates["+ i +"].ErrorCode");
				taskState.ErrorMessage = context.StringValue("DescribeSagWanList.TaskStates["+ i +"].ErrorMessage");
				taskState.CreateTime = context.StringValue("DescribeSagWanList.TaskStates["+ i +"].CreateTime");

				describeSagWanListResponse_taskStates.Add(taskState);
			}
			describeSagWanListResponse.TaskStates = describeSagWanListResponse_taskStates;
        
			return describeSagWanListResponse;
        }
    }
}
