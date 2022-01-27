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
using Aliyun.Acs.Alidns.Model.V20150109;

namespace Aliyun.Acs.Alidns.Transform.V20150109
{
    public class DescribeGtmInstanceStatusResponseUnmarshaller
    {
        public static DescribeGtmInstanceStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeGtmInstanceStatusResponse describeGtmInstanceStatusResponse = new DescribeGtmInstanceStatusResponse();

			describeGtmInstanceStatusResponse.HttpResponse = _ctx.HttpResponse;
			describeGtmInstanceStatusResponse.RequestId = _ctx.StringValue("DescribeGtmInstanceStatus.RequestId");
			describeGtmInstanceStatusResponse.AddrNotAvailableNum = _ctx.IntegerValue("DescribeGtmInstanceStatus.AddrNotAvailableNum");
			describeGtmInstanceStatusResponse.AddrPoolNotAvailableNum = _ctx.IntegerValue("DescribeGtmInstanceStatus.AddrPoolNotAvailableNum");
			describeGtmInstanceStatusResponse.SwitchToFailoverStrategyNum = _ctx.IntegerValue("DescribeGtmInstanceStatus.SwitchToFailoverStrategyNum");
			describeGtmInstanceStatusResponse.StrategyNotAvailableNum = _ctx.IntegerValue("DescribeGtmInstanceStatus.StrategyNotAvailableNum");
			describeGtmInstanceStatusResponse.Status = _ctx.StringValue("DescribeGtmInstanceStatus.Status");
			describeGtmInstanceStatusResponse.StatusReason = _ctx.StringValue("DescribeGtmInstanceStatus.StatusReason");
        
			return describeGtmInstanceStatusResponse;
        }
    }
}
