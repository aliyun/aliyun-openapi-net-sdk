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
using Aliyun.Acs.vs.Model.V20181212;

namespace Aliyun.Acs.vs.Transform.V20181212
{
    public class DescribeParentPlatformResponseUnmarshaller
    {
        public static DescribeParentPlatformResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeParentPlatformResponse describeParentPlatformResponse = new DescribeParentPlatformResponse();

			describeParentPlatformResponse.HttpResponse = context.HttpResponse;
			describeParentPlatformResponse.RequestId = context.StringValue("DescribeParentPlatform.RequestId");
			describeParentPlatformResponse.Id = context.StringValue("DescribeParentPlatform.Id");
			describeParentPlatformResponse.Name = context.StringValue("DescribeParentPlatform.Name");
			describeParentPlatformResponse.Description = context.StringValue("DescribeParentPlatform.Description");
			describeParentPlatformResponse.Protocol = context.StringValue("DescribeParentPlatform.Protocol");
			describeParentPlatformResponse.Status = context.StringValue("DescribeParentPlatform.Status");
			describeParentPlatformResponse.GbId = context.StringValue("DescribeParentPlatform.GbId");
			describeParentPlatformResponse.Ip = context.StringValue("DescribeParentPlatform.Ip");
			describeParentPlatformResponse.Port = context.LongValue("DescribeParentPlatform.Port");
			describeParentPlatformResponse.ClientGbId = context.StringValue("DescribeParentPlatform.ClientGbId");
			describeParentPlatformResponse.ClientAuth = context.BooleanValue("DescribeParentPlatform.ClientAuth");
			describeParentPlatformResponse.ClientUsername = context.StringValue("DescribeParentPlatform.ClientUsername");
			describeParentPlatformResponse.ClientPassword = context.StringValue("DescribeParentPlatform.ClientPassword");
			describeParentPlatformResponse.ClientIp = context.StringValue("DescribeParentPlatform.ClientIp");
			describeParentPlatformResponse.ClientPort = context.LongValue("DescribeParentPlatform.ClientPort");
			describeParentPlatformResponse.AutoStart = context.BooleanValue("DescribeParentPlatform.AutoStart");
			describeParentPlatformResponse.CreatedTime = context.StringValue("DescribeParentPlatform.CreatedTime");
        
			return describeParentPlatformResponse;
        }
    }
}
