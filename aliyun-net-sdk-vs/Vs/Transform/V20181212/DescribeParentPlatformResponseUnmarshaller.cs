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
        public static DescribeParentPlatformResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeParentPlatformResponse describeParentPlatformResponse = new DescribeParentPlatformResponse();

			describeParentPlatformResponse.HttpResponse = _ctx.HttpResponse;
			describeParentPlatformResponse.RequestId = _ctx.StringValue("DescribeParentPlatform.RequestId");
			describeParentPlatformResponse.Id = _ctx.StringValue("DescribeParentPlatform.Id");
			describeParentPlatformResponse.Name = _ctx.StringValue("DescribeParentPlatform.Name");
			describeParentPlatformResponse.Description = _ctx.StringValue("DescribeParentPlatform.Description");
			describeParentPlatformResponse.Protocol = _ctx.StringValue("DescribeParentPlatform.Protocol");
			describeParentPlatformResponse.Status = _ctx.StringValue("DescribeParentPlatform.Status");
			describeParentPlatformResponse.GbId = _ctx.StringValue("DescribeParentPlatform.GbId");
			describeParentPlatformResponse.Ip = _ctx.StringValue("DescribeParentPlatform.Ip");
			describeParentPlatformResponse.Port = _ctx.LongValue("DescribeParentPlatform.Port");
			describeParentPlatformResponse.ClientGbId = _ctx.StringValue("DescribeParentPlatform.ClientGbId");
			describeParentPlatformResponse.ClientAuth = _ctx.BooleanValue("DescribeParentPlatform.ClientAuth");
			describeParentPlatformResponse.ClientUsername = _ctx.StringValue("DescribeParentPlatform.ClientUsername");
			describeParentPlatformResponse.ClientPassword = _ctx.StringValue("DescribeParentPlatform.ClientPassword");
			describeParentPlatformResponse.ClientIp = _ctx.StringValue("DescribeParentPlatform.ClientIp");
			describeParentPlatformResponse.ClientPort = _ctx.LongValue("DescribeParentPlatform.ClientPort");
			describeParentPlatformResponse.AutoStart = _ctx.BooleanValue("DescribeParentPlatform.AutoStart");
			describeParentPlatformResponse.CreatedTime = _ctx.StringValue("DescribeParentPlatform.CreatedTime");
        
			return describeParentPlatformResponse;
        }
    }
}
