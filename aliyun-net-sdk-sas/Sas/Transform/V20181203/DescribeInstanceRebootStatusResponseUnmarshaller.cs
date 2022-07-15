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
using Aliyun.Acs.Sas.Model.V20181203;

namespace Aliyun.Acs.Sas.Transform.V20181203
{
    public class DescribeInstanceRebootStatusResponseUnmarshaller
    {
        public static DescribeInstanceRebootStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeInstanceRebootStatusResponse describeInstanceRebootStatusResponse = new DescribeInstanceRebootStatusResponse();

			describeInstanceRebootStatusResponse.HttpResponse = _ctx.HttpResponse;
			describeInstanceRebootStatusResponse.TotalCount = _ctx.IntegerValue("DescribeInstanceRebootStatus.TotalCount");
			describeInstanceRebootStatusResponse.RequestId = _ctx.StringValue("DescribeInstanceRebootStatus.RequestId");

			List<DescribeInstanceRebootStatusResponse.DescribeInstanceRebootStatus_RebootStatus> describeInstanceRebootStatusResponse_rebootStatuses = new List<DescribeInstanceRebootStatusResponse.DescribeInstanceRebootStatus_RebootStatus>();
			for (int i = 0; i < _ctx.Length("DescribeInstanceRebootStatus.RebootStatuses.Length"); i++) {
				DescribeInstanceRebootStatusResponse.DescribeInstanceRebootStatus_RebootStatus rebootStatus = new DescribeInstanceRebootStatusResponse.DescribeInstanceRebootStatus_RebootStatus();
				rebootStatus.Uuid = _ctx.StringValue("DescribeInstanceRebootStatus.RebootStatuses["+ i +"].Uuid");
				rebootStatus.RebootStatus = _ctx.IntegerValue("DescribeInstanceRebootStatus.RebootStatuses["+ i +"].RebootStatus");
				rebootStatus.Code = _ctx.StringValue("DescribeInstanceRebootStatus.RebootStatuses["+ i +"].Code");
				rebootStatus.Msg = _ctx.StringValue("DescribeInstanceRebootStatus.RebootStatuses["+ i +"].Msg");

				describeInstanceRebootStatusResponse_rebootStatuses.Add(rebootStatus);
			}
			describeInstanceRebootStatusResponse.RebootStatuses = describeInstanceRebootStatusResponse_rebootStatuses;
        
			return describeInstanceRebootStatusResponse;
        }
    }
}
