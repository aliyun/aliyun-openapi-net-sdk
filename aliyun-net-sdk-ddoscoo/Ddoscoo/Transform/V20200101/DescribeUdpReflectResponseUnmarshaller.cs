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
using Aliyun.Acs.ddoscoo.Model.V20200101;

namespace Aliyun.Acs.ddoscoo.Transform.V20200101
{
    public class DescribeUdpReflectResponseUnmarshaller
    {
        public static DescribeUdpReflectResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeUdpReflectResponse describeUdpReflectResponse = new DescribeUdpReflectResponse();

			describeUdpReflectResponse.HttpResponse = _ctx.HttpResponse;
			describeUdpReflectResponse.RequestId = _ctx.StringValue("DescribeUdpReflect.RequestId");

			List<string> describeUdpReflectResponse_udpSports = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeUdpReflect.UdpSports.Length"); i++) {
				describeUdpReflectResponse_udpSports.Add(_ctx.StringValue("DescribeUdpReflect.UdpSports["+ i +"]"));
			}
			describeUdpReflectResponse.UdpSports = describeUdpReflectResponse_udpSports;
        
			return describeUdpReflectResponse;
        }
    }
}
