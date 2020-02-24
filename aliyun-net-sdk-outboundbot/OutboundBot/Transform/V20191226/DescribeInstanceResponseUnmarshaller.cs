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
using Aliyun.Acs.OutboundBot.Model.V20191226;

namespace Aliyun.Acs.OutboundBot.Transform.V20191226
{
    public class DescribeInstanceResponseUnmarshaller
    {
        public static DescribeInstanceResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeInstanceResponse describeInstanceResponse = new DescribeInstanceResponse();

			describeInstanceResponse.HttpResponse = context.HttpResponse;
			describeInstanceResponse.RequestId = context.StringValue("DescribeInstance.RequestId");
			describeInstanceResponse.Success = context.BooleanValue("DescribeInstance.Success");
			describeInstanceResponse.Code = context.StringValue("DescribeInstance.Code");
			describeInstanceResponse.Message = context.StringValue("DescribeInstance.Message");
			describeInstanceResponse.HttpStatusCode = context.IntegerValue("DescribeInstance.HttpStatusCode");

			DescribeInstanceResponse.DescribeInstance_Instance instance = new DescribeInstanceResponse.DescribeInstance_Instance();
			instance.InstanceId = context.StringValue("DescribeInstance.Instance.InstanceId");
			instance.InstanceName = context.StringValue("DescribeInstance.Instance.InstanceName");
			instance.InstanceDescription = context.StringValue("DescribeInstance.Instance.InstanceDescription");
			instance.MaxConcurrentConversation = context.IntegerValue("DescribeInstance.Instance.MaxConcurrentConversation");
			instance.Owner = context.StringValue("DescribeInstance.Instance.Owner");
			instance.CreationTime = context.LongValue("DescribeInstance.Instance.CreationTime");
			instance.CallCenterInstanceId = context.StringValue("DescribeInstance.Instance.CallCenterInstanceId");
			describeInstanceResponse.Instance = instance;
        
			return describeInstanceResponse;
        }
    }
}
