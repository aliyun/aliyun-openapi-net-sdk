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
using Aliyun.Acs.ROS.Model.V20190910;

namespace Aliyun.Acs.ROS.Transform.V20190910
{
    public class ListStackGroupOperationsResponseUnmarshaller
    {
        public static ListStackGroupOperationsResponse Unmarshall(UnmarshallerContext context)
        {
			ListStackGroupOperationsResponse listStackGroupOperationsResponse = new ListStackGroupOperationsResponse();

			listStackGroupOperationsResponse.HttpResponse = context.HttpResponse;
			listStackGroupOperationsResponse.RequestId = context.StringValue("ListStackGroupOperations.RequestId");
			listStackGroupOperationsResponse.PageNumber = context.IntegerValue("ListStackGroupOperations.PageNumber");
			listStackGroupOperationsResponse.PageSize = context.IntegerValue("ListStackGroupOperations.PageSize");
			listStackGroupOperationsResponse.TotalCount = context.IntegerValue("ListStackGroupOperations.TotalCount");

			List<ListStackGroupOperationsResponse.ListStackGroupOperations_StackGroupOperation> listStackGroupOperationsResponse_stackGroupOperations = new List<ListStackGroupOperationsResponse.ListStackGroupOperations_StackGroupOperation>();
			for (int i = 0; i < context.Length("ListStackGroupOperations.StackGroupOperations.Length"); i++) {
				ListStackGroupOperationsResponse.ListStackGroupOperations_StackGroupOperation stackGroupOperation = new ListStackGroupOperationsResponse.ListStackGroupOperations_StackGroupOperation();
				stackGroupOperation.StackGroupName = context.StringValue("ListStackGroupOperations.StackGroupOperations["+ i +"].StackGroupName");
				stackGroupOperation.StackGroupId = context.StringValue("ListStackGroupOperations.StackGroupOperations["+ i +"].StackGroupId");
				stackGroupOperation.OperationId = context.StringValue("ListStackGroupOperations.StackGroupOperations["+ i +"].OperationId");
				stackGroupOperation.OperationDescription = context.StringValue("ListStackGroupOperations.StackGroupOperations["+ i +"].OperationDescription");
				stackGroupOperation.CreateTime = context.StringValue("ListStackGroupOperations.StackGroupOperations["+ i +"].CreateTime");
				stackGroupOperation.EndTime = context.StringValue("ListStackGroupOperations.StackGroupOperations["+ i +"].EndTime");
				stackGroupOperation.Action = context.StringValue("ListStackGroupOperations.StackGroupOperations["+ i +"].Action");
				stackGroupOperation.Status = context.StringValue("ListStackGroupOperations.StackGroupOperations["+ i +"].Status");

				listStackGroupOperationsResponse_stackGroupOperations.Add(stackGroupOperation);
			}
			listStackGroupOperationsResponse.StackGroupOperations = listStackGroupOperationsResponse_stackGroupOperations;
        
			return listStackGroupOperationsResponse;
        }
    }
}
