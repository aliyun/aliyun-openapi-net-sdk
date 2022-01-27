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
using Aliyun.Acs.oos.Model.V20190601;

namespace Aliyun.Acs.oos.Transform.V20190601
{
    public class ListResourceExecutionStatusResponseUnmarshaller
    {
        public static ListResourceExecutionStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListResourceExecutionStatusResponse listResourceExecutionStatusResponse = new ListResourceExecutionStatusResponse();

			listResourceExecutionStatusResponse.HttpResponse = _ctx.HttpResponse;
			listResourceExecutionStatusResponse.RequestId = _ctx.StringValue("ListResourceExecutionStatus.RequestId");
			listResourceExecutionStatusResponse.MaxResults = _ctx.IntegerValue("ListResourceExecutionStatus.MaxResults");
			listResourceExecutionStatusResponse.NextToken = _ctx.StringValue("ListResourceExecutionStatus.NextToken");

			List<ListResourceExecutionStatusResponse.ListResourceExecutionStatus_Status> listResourceExecutionStatusResponse_resourceExecutionStatus = new List<ListResourceExecutionStatusResponse.ListResourceExecutionStatus_Status>();
			for (int i = 0; i < _ctx.Length("ListResourceExecutionStatus.ResourceExecutionStatus.Length"); i++) {
				ListResourceExecutionStatusResponse.ListResourceExecutionStatus_Status status = new ListResourceExecutionStatusResponse.ListResourceExecutionStatus_Status();
				status.ResourceId = _ctx.StringValue("ListResourceExecutionStatus.ResourceExecutionStatus["+ i +"].ResourceId");
				status.ExecutionTime = _ctx.StringValue("ListResourceExecutionStatus.ResourceExecutionStatus["+ i +"].ExecutionTime");
				status.Status = _ctx.StringValue("ListResourceExecutionStatus.ResourceExecutionStatus["+ i +"].Status");
				status.Outputs = _ctx.StringValue("ListResourceExecutionStatus.ResourceExecutionStatus["+ i +"].Outputs");
				status.ExecutionId = _ctx.StringValue("ListResourceExecutionStatus.ResourceExecutionStatus["+ i +"].ExecutionId");

				listResourceExecutionStatusResponse_resourceExecutionStatus.Add(status);
			}
			listResourceExecutionStatusResponse.ResourceExecutionStatus = listResourceExecutionStatusResponse_resourceExecutionStatus;
        
			return listResourceExecutionStatusResponse;
        }
    }
}
