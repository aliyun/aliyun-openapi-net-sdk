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
using Aliyun.Acs.sgw.Model.V20180511;

namespace Aliyun.Acs.sgw.Transform.V20180511
{
    public class DescribeGatewayActionsResponseUnmarshaller
    {
        public static DescribeGatewayActionsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeGatewayActionsResponse describeGatewayActionsResponse = new DescribeGatewayActionsResponse();

			describeGatewayActionsResponse.HttpResponse = context.HttpResponse;
			describeGatewayActionsResponse.RequestId = context.StringValue("DescribeGatewayActions.RequestId");
			describeGatewayActionsResponse.Success = context.BooleanValue("DescribeGatewayActions.Success");
			describeGatewayActionsResponse.Code = context.StringValue("DescribeGatewayActions.Code");
			describeGatewayActionsResponse.Message = context.StringValue("DescribeGatewayActions.Message");

			List<DescribeGatewayActionsResponse.DescribeGatewayActions_Action> describeGatewayActionsResponse_actions = new List<DescribeGatewayActionsResponse.DescribeGatewayActions_Action>();
			for (int i = 0; i < context.Length("DescribeGatewayActions.Actions.Length"); i++) {
				DescribeGatewayActionsResponse.DescribeGatewayActions_Action action = new DescribeGatewayActionsResponse.DescribeGatewayActions_Action();
				action.GatewayId = context.StringValue("DescribeGatewayActions.Actions["+ i +"].GatewayId");
				action.Self = context.StringValue("DescribeGatewayActions.Actions["+ i +"].Self");
				action.Monitor = context.StringValue("DescribeGatewayActions.Actions["+ i +"].Monitor");
				action.Disk = context.StringValue("DescribeGatewayActions.Actions["+ i +"].Disk");
				action.Cache = context.StringValue("DescribeGatewayActions.Actions["+ i +"].Cache");
				action.SmbUser = context.StringValue("DescribeGatewayActions.Actions["+ i +"].SmbUser");
				action.AdLdap = context.StringValue("DescribeGatewayActions.Actions["+ i +"].AdLdap");
				action.Target = context.StringValue("DescribeGatewayActions.Actions["+ i +"].Target");

				describeGatewayActionsResponse_actions.Add(action);
			}
			describeGatewayActionsResponse.Actions = describeGatewayActionsResponse_actions;
        
			return describeGatewayActionsResponse;
        }
    }
}
