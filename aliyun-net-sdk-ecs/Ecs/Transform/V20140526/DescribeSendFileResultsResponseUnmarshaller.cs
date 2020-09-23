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
using Aliyun.Acs.Ecs.Model.V20140526;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeSendFileResultsResponseUnmarshaller
    {
        public static DescribeSendFileResultsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSendFileResultsResponse describeSendFileResultsResponse = new DescribeSendFileResultsResponse();

			describeSendFileResultsResponse.HttpResponse = context.HttpResponse;
			describeSendFileResultsResponse.RequestId = context.StringValue("DescribeSendFileResults.RequestId");
			describeSendFileResultsResponse.TotalCount = context.LongValue("DescribeSendFileResults.TotalCount");
			describeSendFileResultsResponse.PageNumber = context.LongValue("DescribeSendFileResults.PageNumber");
			describeSendFileResultsResponse.PageSize = context.LongValue("DescribeSendFileResults.PageSize");

			List<DescribeSendFileResultsResponse.DescribeSendFileResults_Invocation> describeSendFileResultsResponse_invocations = new List<DescribeSendFileResultsResponse.DescribeSendFileResults_Invocation>();
			for (int i = 0; i < context.Length("DescribeSendFileResults.Invocations.Length"); i++) {
				DescribeSendFileResultsResponse.DescribeSendFileResults_Invocation invocation = new DescribeSendFileResultsResponse.DescribeSendFileResults_Invocation();
				invocation.InvokeId = context.StringValue("DescribeSendFileResults.Invocations["+ i +"].InvokeId");
				invocation.Name = context.StringValue("DescribeSendFileResults.Invocations["+ i +"].Name");
				invocation.Description = context.StringValue("DescribeSendFileResults.Invocations["+ i +"].Description");
				invocation.TargetDir = context.StringValue("DescribeSendFileResults.Invocations["+ i +"].TargetDir");
				invocation.ContentType = context.StringValue("DescribeSendFileResults.Invocations["+ i +"].ContentType");
				invocation.Content = context.StringValue("DescribeSendFileResults.Invocations["+ i +"].Content");
				invocation.FileOwner = context.StringValue("DescribeSendFileResults.Invocations["+ i +"].FileOwner");
				invocation.FileGroup = context.StringValue("DescribeSendFileResults.Invocations["+ i +"].FileGroup");
				invocation.FileMode = context.StringValue("DescribeSendFileResults.Invocations["+ i +"].FileMode");
				invocation.Overwrite = context.StringValue("DescribeSendFileResults.Invocations["+ i +"].Overwrite");
				invocation.VmCount = context.IntegerValue("DescribeSendFileResults.Invocations["+ i +"].VmCount");
				invocation.CreationTime = context.StringValue("DescribeSendFileResults.Invocations["+ i +"].CreationTime");
				invocation.InvocationStatus = context.StringValue("DescribeSendFileResults.Invocations["+ i +"].InvocationStatus");

				List<DescribeSendFileResultsResponse.DescribeSendFileResults_Invocation.DescribeSendFileResults_InvokeInstance> invocation_invokeInstances = new List<DescribeSendFileResultsResponse.DescribeSendFileResults_Invocation.DescribeSendFileResults_InvokeInstance>();
				for (int j = 0; j < context.Length("DescribeSendFileResults.Invocations["+ i +"].InvokeInstances.Length"); j++) {
					DescribeSendFileResultsResponse.DescribeSendFileResults_Invocation.DescribeSendFileResults_InvokeInstance invokeInstance = new DescribeSendFileResultsResponse.DescribeSendFileResults_Invocation.DescribeSendFileResults_InvokeInstance();
					invokeInstance.InstanceId = context.StringValue("DescribeSendFileResults.Invocations["+ i +"].InvokeInstances["+ j +"].InstanceId");
					invokeInstance.InvocationStatus = context.StringValue("DescribeSendFileResults.Invocations["+ i +"].InvokeInstances["+ j +"].InvocationStatus");
					invokeInstance.CreationTime = context.StringValue("DescribeSendFileResults.Invocations["+ i +"].InvokeInstances["+ j +"].CreationTime");
					invokeInstance.StartTime = context.StringValue("DescribeSendFileResults.Invocations["+ i +"].InvokeInstances["+ j +"].StartTime");
					invokeInstance.FinishTime = context.StringValue("DescribeSendFileResults.Invocations["+ i +"].InvokeInstances["+ j +"].FinishTime");
					invokeInstance.UpdateTime = context.StringValue("DescribeSendFileResults.Invocations["+ i +"].InvokeInstances["+ j +"].UpdateTime");
					invokeInstance.ErrorCode = context.StringValue("DescribeSendFileResults.Invocations["+ i +"].InvokeInstances["+ j +"].ErrorCode");
					invokeInstance.ErrorInfo = context.StringValue("DescribeSendFileResults.Invocations["+ i +"].InvokeInstances["+ j +"].ErrorInfo");

					invocation_invokeInstances.Add(invokeInstance);
				}
				invocation.InvokeInstances = invocation_invokeInstances;

				describeSendFileResultsResponse_invocations.Add(invocation);
			}
			describeSendFileResultsResponse.Invocations = describeSendFileResultsResponse_invocations;
        
			return describeSendFileResultsResponse;
        }
    }
}
