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
    public class DescribeSagLanListResponseUnmarshaller
    {
        public static DescribeSagLanListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSagLanListResponse describeSagLanListResponse = new DescribeSagLanListResponse();

			describeSagLanListResponse.HttpResponse = context.HttpResponse;
			describeSagLanListResponse.RequestId = context.StringValue("DescribeSagLanList.RequestId");

			List<DescribeSagLanListResponse.DescribeSagLanList_Lan> describeSagLanListResponse_lans = new List<DescribeSagLanListResponse.DescribeSagLanList_Lan>();
			for (int i = 0; i < context.Length("DescribeSagLanList.Lans.Length"); i++) {
				DescribeSagLanListResponse.DescribeSagLanList_Lan lan = new DescribeSagLanListResponse.DescribeSagLanList_Lan();
				lan.PortName = context.StringValue("DescribeSagLanList.Lans["+ i +"].PortName");
				lan.IPType = context.StringValue("DescribeSagLanList.Lans["+ i +"].IPType");
				lan.IP = context.StringValue("DescribeSagLanList.Lans["+ i +"].IP");
				lan.Mask = context.StringValue("DescribeSagLanList.Lans["+ i +"].Mask");
				lan.StartIp = context.StringValue("DescribeSagLanList.Lans["+ i +"].StartIp");
				lan.EndIp = context.StringValue("DescribeSagLanList.Lans["+ i +"].EndIp");
				lan.Lease = context.StringValue("DescribeSagLanList.Lans["+ i +"].Lease");

				describeSagLanListResponse_lans.Add(lan);
			}
			describeSagLanListResponse.Lans = describeSagLanListResponse_lans;

			List<DescribeSagLanListResponse.DescribeSagLanList_TaskState> describeSagLanListResponse_taskStates = new List<DescribeSagLanListResponse.DescribeSagLanList_TaskState>();
			for (int i = 0; i < context.Length("DescribeSagLanList.TaskStates.Length"); i++) {
				DescribeSagLanListResponse.DescribeSagLanList_TaskState taskState = new DescribeSagLanListResponse.DescribeSagLanList_TaskState();
				taskState.State = context.StringValue("DescribeSagLanList.TaskStates["+ i +"].State");
				taskState.ErrorCode = context.StringValue("DescribeSagLanList.TaskStates["+ i +"].ErrorCode");
				taskState.ErrorMessage = context.StringValue("DescribeSagLanList.TaskStates["+ i +"].ErrorMessage");
				taskState.CreateTime = context.StringValue("DescribeSagLanList.TaskStates["+ i +"].CreateTime");

				describeSagLanListResponse_taskStates.Add(taskState);
			}
			describeSagLanListResponse.TaskStates = describeSagLanListResponse_taskStates;
        
			return describeSagLanListResponse;
        }
    }
}
