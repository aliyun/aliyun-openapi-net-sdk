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
    public class DescribeStreamResponseUnmarshaller
    {
        public static DescribeStreamResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeStreamResponse describeStreamResponse = new DescribeStreamResponse();

			describeStreamResponse.HttpResponse = _ctx.HttpResponse;
			describeStreamResponse.RequestId = _ctx.StringValue("DescribeStream.RequestId");
			describeStreamResponse.Id = _ctx.StringValue("DescribeStream.Id");
			describeStreamResponse.Name = _ctx.StringValue("DescribeStream.Name");
			describeStreamResponse.PushDomain = _ctx.StringValue("DescribeStream.PushDomain");
			describeStreamResponse.PlayDomain = _ctx.StringValue("DescribeStream.PlayDomain");
			describeStreamResponse.App = _ctx.StringValue("DescribeStream.App");
			describeStreamResponse.Protocol = _ctx.StringValue("DescribeStream.Protocol");
			describeStreamResponse.GroupId = _ctx.StringValue("DescribeStream.GroupId");
			describeStreamResponse.DeviceId = _ctx.StringValue("DescribeStream.DeviceId");
			describeStreamResponse.Enabled = _ctx.BooleanValue("DescribeStream.Enabled");
			describeStreamResponse.Status = _ctx.StringValue("DescribeStream.Status");
			describeStreamResponse.Height = _ctx.IntegerValue("DescribeStream.Height");
			describeStreamResponse.Width = _ctx.IntegerValue("DescribeStream.Width");
			describeStreamResponse.CreatedTime = _ctx.StringValue("DescribeStream.CreatedTime");
        
			return describeStreamResponse;
        }
    }
}
