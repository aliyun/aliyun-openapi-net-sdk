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
    public class DescribeWebAccessModeResponseUnmarshaller
    {
        public static DescribeWebAccessModeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeWebAccessModeResponse describeWebAccessModeResponse = new DescribeWebAccessModeResponse();

			describeWebAccessModeResponse.HttpResponse = _ctx.HttpResponse;
			describeWebAccessModeResponse.RequestId = _ctx.StringValue("DescribeWebAccessMode.RequestId");

			List<DescribeWebAccessModeResponse.DescribeWebAccessMode_DomainMode> describeWebAccessModeResponse_domainModes = new List<DescribeWebAccessModeResponse.DescribeWebAccessMode_DomainMode>();
			for (int i = 0; i < _ctx.Length("DescribeWebAccessMode.DomainModes.Length"); i++) {
				DescribeWebAccessModeResponse.DescribeWebAccessMode_DomainMode domainMode = new DescribeWebAccessModeResponse.DescribeWebAccessMode_DomainMode();
				domainMode.Domain = _ctx.StringValue("DescribeWebAccessMode.DomainModes["+ i +"].Domain");
				domainMode.AccessMode = _ctx.IntegerValue("DescribeWebAccessMode.DomainModes["+ i +"].AccessMode");

				describeWebAccessModeResponse_domainModes.Add(domainMode);
			}
			describeWebAccessModeResponse.DomainModes = describeWebAccessModeResponse_domainModes;
        
			return describeWebAccessModeResponse;
        }
    }
}
