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
using Aliyun.Acs.fnf.Model.V20190315;

namespace Aliyun.Acs.fnf.Transform.V20190315
{
    public class ListExecutionsResponseUnmarshaller
    {
        public static ListExecutionsResponse Unmarshall(UnmarshallerContext context)
        {
			ListExecutionsResponse listExecutionsResponse = new ListExecutionsResponse();

			listExecutionsResponse.HttpResponse = context.HttpResponse;
			listExecutionsResponse.RequestId = context.StringValue("ListExecutions.RequestId");
			listExecutionsResponse.NextToken = context.StringValue("ListExecutions.NextToken");

			List<ListExecutionsResponse.ListExecutions_ExecutionsItem> listExecutionsResponse_executions = new List<ListExecutionsResponse.ListExecutions_ExecutionsItem>();
			for (int i = 0; i < context.Length("ListExecutions.Executions.Length"); i++) {
				ListExecutionsResponse.ListExecutions_ExecutionsItem executionsItem = new ListExecutionsResponse.ListExecutions_ExecutionsItem();
				executionsItem.Name = context.StringValue("ListExecutions.Executions["+ i +"].Name");
				executionsItem.FlowName = context.StringValue("ListExecutions.Executions["+ i +"].FlowName");
				executionsItem.FlowDefinition = context.StringValue("ListExecutions.Executions["+ i +"].FlowDefinition");
				executionsItem.Input = context.StringValue("ListExecutions.Executions["+ i +"].Input");
				executionsItem.Output = context.StringValue("ListExecutions.Executions["+ i +"].Output");
				executionsItem.Status = context.StringValue("ListExecutions.Executions["+ i +"].Status");
				executionsItem.StartedTime = context.StringValue("ListExecutions.Executions["+ i +"].StartedTime");
				executionsItem.StoppedTime = context.StringValue("ListExecutions.Executions["+ i +"].StoppedTime");
				executionsItem.ExternalInputUri = context.StringValue("ListExecutions.Executions["+ i +"].ExternalInputUri");
				executionsItem.ExternalOutputUri = context.StringValue("ListExecutions.Executions["+ i +"].ExternalOutputUri");

				listExecutionsResponse_executions.Add(executionsItem);
			}
			listExecutionsResponse.Executions = listExecutionsResponse_executions;
        
			return listExecutionsResponse;
        }
    }
}
