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
        public static DescribeSendFileResultsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSendFileResultsResponse describeSendFileResultsResponse = new DescribeSendFileResultsResponse();

			describeSendFileResultsResponse.HttpResponse = _ctx.HttpResponse;
			describeSendFileResultsResponse.PageSize = _ctx.LongValue("DescribeSendFileResults.PageSize");
			describeSendFileResultsResponse.RequestId = _ctx.StringValue("DescribeSendFileResults.RequestId");
			describeSendFileResultsResponse.PageNumber = _ctx.LongValue("DescribeSendFileResults.PageNumber");
			describeSendFileResultsResponse.TotalCount = _ctx.LongValue("DescribeSendFileResults.TotalCount");

			List<DescribeSendFileResultsResponse.DescribeSendFileResults_Invocation> describeSendFileResultsResponse_invocations = new List<DescribeSendFileResultsResponse.DescribeSendFileResults_Invocation>();
			for (int i = 0; i < _ctx.Length("DescribeSendFileResults.Invocations.Length"); i++) {
				DescribeSendFileResultsResponse.DescribeSendFileResults_Invocation invocation = new DescribeSendFileResultsResponse.DescribeSendFileResults_Invocation();
				invocation.CreationTime = _ctx.StringValue("DescribeSendFileResults.Invocations["+ i +"].CreationTime");
				invocation.InvocationStatus = _ctx.StringValue("DescribeSendFileResults.Invocations["+ i +"].InvocationStatus");
				invocation.ContentType = _ctx.StringValue("DescribeSendFileResults.Invocations["+ i +"].ContentType");
				invocation.TargetDir = _ctx.StringValue("DescribeSendFileResults.Invocations["+ i +"].TargetDir");
				invocation.FileOwner = _ctx.StringValue("DescribeSendFileResults.Invocations["+ i +"].FileOwner");
				invocation.Description = _ctx.StringValue("DescribeSendFileResults.Invocations["+ i +"].Description");
				invocation.VmCount = _ctx.IntegerValue("DescribeSendFileResults.Invocations["+ i +"].VmCount");
				invocation.FileMode = _ctx.StringValue("DescribeSendFileResults.Invocations["+ i +"].FileMode");
				invocation.FileGroup = _ctx.StringValue("DescribeSendFileResults.Invocations["+ i +"].FileGroup");
				invocation.InvokeId = _ctx.StringValue("DescribeSendFileResults.Invocations["+ i +"].InvokeId");
				invocation.Name = _ctx.StringValue("DescribeSendFileResults.Invocations["+ i +"].Name");
				invocation.Content = _ctx.StringValue("DescribeSendFileResults.Invocations["+ i +"].Content");
				invocation.Overwrite = _ctx.StringValue("DescribeSendFileResults.Invocations["+ i +"].Overwrite");

				List<DescribeSendFileResultsResponse.DescribeSendFileResults_Invocation.DescribeSendFileResults_InvokeInstance> invocation_invokeInstances = new List<DescribeSendFileResultsResponse.DescribeSendFileResults_Invocation.DescribeSendFileResults_InvokeInstance>();
				for (int j = 0; j < _ctx.Length("DescribeSendFileResults.Invocations["+ i +"].InvokeInstances.Length"); j++) {
					DescribeSendFileResultsResponse.DescribeSendFileResults_Invocation.DescribeSendFileResults_InvokeInstance invokeInstance = new DescribeSendFileResultsResponse.DescribeSendFileResults_Invocation.DescribeSendFileResults_InvokeInstance();
					invokeInstance.CreationTime = _ctx.StringValue("DescribeSendFileResults.Invocations["+ i +"].InvokeInstances["+ j +"].CreationTime");
					invokeInstance.StartTime = _ctx.StringValue("DescribeSendFileResults.Invocations["+ i +"].InvokeInstances["+ j +"].StartTime");
					invokeInstance.InvocationStatus = _ctx.StringValue("DescribeSendFileResults.Invocations["+ i +"].InvokeInstances["+ j +"].InvocationStatus");
					invokeInstance.FinishTime = _ctx.StringValue("DescribeSendFileResults.Invocations["+ i +"].InvokeInstances["+ j +"].FinishTime");
					invokeInstance.UpdateTime = _ctx.StringValue("DescribeSendFileResults.Invocations["+ i +"].InvokeInstances["+ j +"].UpdateTime");
					invokeInstance.ErrorInfo = _ctx.StringValue("DescribeSendFileResults.Invocations["+ i +"].InvokeInstances["+ j +"].ErrorInfo");
					invokeInstance.ErrorCode = _ctx.StringValue("DescribeSendFileResults.Invocations["+ i +"].InvokeInstances["+ j +"].ErrorCode");
					invokeInstance.InstanceId = _ctx.StringValue("DescribeSendFileResults.Invocations["+ i +"].InvokeInstances["+ j +"].InstanceId");

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
