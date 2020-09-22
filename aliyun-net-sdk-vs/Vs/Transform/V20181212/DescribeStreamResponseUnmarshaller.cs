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
        public static DescribeStreamResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeStreamResponse describeStreamResponse = new DescribeStreamResponse();

			describeStreamResponse.HttpResponse = context.HttpResponse;
			describeStreamResponse.RequestId = context.StringValue("DescribeStream.RequestId");
			describeStreamResponse.Id = context.StringValue("DescribeStream.Id");
			describeStreamResponse.Name = context.StringValue("DescribeStream.Name");
			describeStreamResponse.PushDomain = context.StringValue("DescribeStream.PushDomain");
			describeStreamResponse.PlayDomain = context.StringValue("DescribeStream.PlayDomain");
			describeStreamResponse.App = context.StringValue("DescribeStream.App");
			describeStreamResponse.Protocol = context.StringValue("DescribeStream.Protocol");
			describeStreamResponse.GroupId = context.StringValue("DescribeStream.GroupId");
			describeStreamResponse.DeviceId = context.StringValue("DescribeStream.DeviceId");
			describeStreamResponse.Enabled = context.BooleanValue("DescribeStream.Enabled");
			describeStreamResponse.Status = context.StringValue("DescribeStream.Status");
			describeStreamResponse.Height = context.IntegerValue("DescribeStream.Height");
			describeStreamResponse.Width = context.IntegerValue("DescribeStream.Width");
			describeStreamResponse.CreatedTime = context.StringValue("DescribeStream.CreatedTime");
        
			return describeStreamResponse;
        }
    }
}
