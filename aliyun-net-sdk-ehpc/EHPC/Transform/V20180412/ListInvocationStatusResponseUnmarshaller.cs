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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.EHPC.Model.V20180412;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.EHPC.Transform.V20180412
{
    public class ListInvocationStatusResponseUnmarshaller
    {
        public static ListInvocationStatusResponse Unmarshall(UnmarshallerContext context)
        {
			ListInvocationStatusResponse listInvocationStatusResponse = new ListInvocationStatusResponse();

			listInvocationStatusResponse.HttpResponse = context.HttpResponse;
			listInvocationStatusResponse.RequestId = context.StringValue("ListInvocationStatus.RequestId");
			listInvocationStatusResponse.CommandId = context.StringValue("ListInvocationStatus.CommandId");
			listInvocationStatusResponse.InvokeStatus = context.StringValue("ListInvocationStatus.InvokeStatus");

			List<ListInvocationStatusResponse.ListInvocationStatus_InvokeInstance> listInvocationStatusResponse_invokeInstances = new List<ListInvocationStatusResponse.ListInvocationStatus_InvokeInstance>();
			for (int i = 0; i < context.Length("ListInvocationStatus.InvokeInstances.Length"); i++) {
				ListInvocationStatusResponse.ListInvocationStatus_InvokeInstance invokeInstance = new ListInvocationStatusResponse.ListInvocationStatus_InvokeInstance();
				invokeInstance.InstanceId = context.StringValue("ListInvocationStatus.InvokeInstances["+ i +"].InstanceId");
				invokeInstance.InstanceInvokeStatus = context.StringValue("ListInvocationStatus.InvokeInstances["+ i +"].InstanceInvokeStatus");

				listInvocationStatusResponse_invokeInstances.Add(invokeInstance);
			}
			listInvocationStatusResponse.InvokeInstances = listInvocationStatusResponse_invokeInstances;
        
			return listInvocationStatusResponse;
        }
    }
}