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
    public class DescribePortAutoCcStatusResponseUnmarshaller
    {
        public static DescribePortAutoCcStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePortAutoCcStatusResponse describePortAutoCcStatusResponse = new DescribePortAutoCcStatusResponse();

			describePortAutoCcStatusResponse.HttpResponse = _ctx.HttpResponse;
			describePortAutoCcStatusResponse.RequestId = _ctx.StringValue("DescribePortAutoCcStatus.RequestId");

			List<DescribePortAutoCcStatusResponse.DescribePortAutoCcStatus_Status> describePortAutoCcStatusResponse_portAutoCcStatus = new List<DescribePortAutoCcStatusResponse.DescribePortAutoCcStatus_Status>();
			for (int i = 0; i < _ctx.Length("DescribePortAutoCcStatus.PortAutoCcStatus.Length"); i++) {
				DescribePortAutoCcStatusResponse.DescribePortAutoCcStatus_Status status = new DescribePortAutoCcStatusResponse.DescribePortAutoCcStatus_Status();
				status.Mode = _ctx.StringValue("DescribePortAutoCcStatus.PortAutoCcStatus["+ i +"].Mode");
				status.WebSwitch = _ctx.StringValue("DescribePortAutoCcStatus.PortAutoCcStatus["+ i +"].WebSwitch");
				status.WebMode = _ctx.StringValue("DescribePortAutoCcStatus.PortAutoCcStatus["+ i +"].WebMode");
				status._Switch = _ctx.StringValue("DescribePortAutoCcStatus.PortAutoCcStatus["+ i +"].Switch");

				describePortAutoCcStatusResponse_portAutoCcStatus.Add(status);
			}
			describePortAutoCcStatusResponse.PortAutoCcStatus = describePortAutoCcStatusResponse_portAutoCcStatus;
        
			return describePortAutoCcStatusResponse;
        }
    }
}
