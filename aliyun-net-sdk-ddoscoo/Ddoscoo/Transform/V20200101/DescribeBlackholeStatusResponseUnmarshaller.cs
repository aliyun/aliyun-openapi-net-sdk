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
    public class DescribeBlackholeStatusResponseUnmarshaller
    {
        public static DescribeBlackholeStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeBlackholeStatusResponse describeBlackholeStatusResponse = new DescribeBlackholeStatusResponse();

			describeBlackholeStatusResponse.HttpResponse = _ctx.HttpResponse;
			describeBlackholeStatusResponse.RequestId = _ctx.StringValue("DescribeBlackholeStatus.RequestId");

			List<DescribeBlackholeStatusResponse.DescribeBlackholeStatus_BlackholeStatusItem> describeBlackholeStatusResponse_blackholeStatus = new List<DescribeBlackholeStatusResponse.DescribeBlackholeStatus_BlackholeStatusItem>();
			for (int i = 0; i < _ctx.Length("DescribeBlackholeStatus.BlackholeStatus.Length"); i++) {
				DescribeBlackholeStatusResponse.DescribeBlackholeStatus_BlackholeStatusItem blackholeStatusItem = new DescribeBlackholeStatusResponse.DescribeBlackholeStatus_BlackholeStatusItem();
				blackholeStatusItem.StartTime = _ctx.LongValue("DescribeBlackholeStatus.BlackholeStatus["+ i +"].StartTime");
				blackholeStatusItem.EndTime = _ctx.LongValue("DescribeBlackholeStatus.BlackholeStatus["+ i +"].EndTime");
				blackholeStatusItem.Ip = _ctx.StringValue("DescribeBlackholeStatus.BlackholeStatus["+ i +"].Ip");
				blackholeStatusItem.BlackStatus = _ctx.StringValue("DescribeBlackholeStatus.BlackholeStatus["+ i +"].BlackStatus");

				describeBlackholeStatusResponse_blackholeStatus.Add(blackholeStatusItem);
			}
			describeBlackholeStatusResponse.BlackholeStatus = describeBlackholeStatusResponse_blackholeStatus;
        
			return describeBlackholeStatusResponse;
        }
    }
}
