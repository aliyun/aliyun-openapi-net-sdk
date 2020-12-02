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
        public static DescribeInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeInstanceResponse describeInstanceResponse = new DescribeInstanceResponse();

			describeInstanceResponse.HttpResponse = _ctx.HttpResponse;
			describeInstanceResponse.RequestId = _ctx.StringValue("DescribeInstance.RequestId");
			describeInstanceResponse.InstanceId = _ctx.StringValue("DescribeInstance.InstanceId");
			describeInstanceResponse.Name = _ctx.StringValue("DescribeInstance.Name");
			describeInstanceResponse.Description = _ctx.StringValue("DescribeInstance.Description");
			describeInstanceResponse.Status = _ctx.StringValue("DescribeInstance.Status");
			describeInstanceResponse.Concurrency = _ctx.LongValue("DescribeInstance.Concurrency");
			describeInstanceResponse.ModifyTime = _ctx.LongValue("DescribeInstance.ModifyTime");
			describeInstanceResponse.ModifyUserName = _ctx.StringValue("DescribeInstance.ModifyUserName");
			describeInstanceResponse.NluServiceType = _ctx.StringValue("DescribeInstance.NluServiceType");

			List<string> describeInstanceResponse_applicableOperations = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeInstance.ApplicableOperations.Length"); i++) {
				describeInstanceResponse_applicableOperations.Add(_ctx.StringValue("DescribeInstance.ApplicableOperations["+ i +"]"));
			}
			describeInstanceResponse.ApplicableOperations = describeInstanceResponse_applicableOperations;
        
			return describeInstanceResponse;
        }
    }
}
