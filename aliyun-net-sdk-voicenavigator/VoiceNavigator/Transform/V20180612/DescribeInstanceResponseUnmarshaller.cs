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
using Aliyun.Acs.VoiceNavigator.Model.V20180612;

namespace Aliyun.Acs.VoiceNavigator.Transform.V20180612
{
    public class DescribeInstanceResponseUnmarshaller
    {
        public static DescribeInstanceResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeInstanceResponse describeInstanceResponse = new DescribeInstanceResponse();

			describeInstanceResponse.HttpResponse = context.HttpResponse;
			describeInstanceResponse.RequestId = context.StringValue("DescribeInstance.RequestId");
			describeInstanceResponse.InstanceId = context.StringValue("DescribeInstance.InstanceId");
			describeInstanceResponse.Name = context.StringValue("DescribeInstance.Name");
			describeInstanceResponse.Description = context.StringValue("DescribeInstance.Description");
			describeInstanceResponse.Status = context.StringValue("DescribeInstance.Status");
			describeInstanceResponse.Concurrency = context.LongValue("DescribeInstance.Concurrency");
			describeInstanceResponse.ModifyTime = context.LongValue("DescribeInstance.ModifyTime");
			describeInstanceResponse.ModifyUserName = context.StringValue("DescribeInstance.ModifyUserName");
			describeInstanceResponse.NluServiceType = context.StringValue("DescribeInstance.NluServiceType");

			List<string> describeInstanceResponse_applicableOperations = new List<string>();
			for (int i = 0; i < context.Length("DescribeInstance.ApplicableOperations.Length"); i++) {
				describeInstanceResponse_applicableOperations.Add(context.StringValue("DescribeInstance.ApplicableOperations["+ i +"]"));
			}
			describeInstanceResponse.ApplicableOperations = describeInstanceResponse_applicableOperations;
        
			return describeInstanceResponse;
        }
    }
}
