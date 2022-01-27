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
using Aliyun.Acs.DBFS.Model.V20200418;

namespace Aliyun.Acs.DBFS.Transform.V20200418
{
    public class DescribeDbfsSpecificationsResponseUnmarshaller
    {
        public static DescribeDbfsSpecificationsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDbfsSpecificationsResponse describeDbfsSpecificationsResponse = new DescribeDbfsSpecificationsResponse();

			describeDbfsSpecificationsResponse.HttpResponse = _ctx.HttpResponse;
			describeDbfsSpecificationsResponse.RequestId = _ctx.StringValue("DescribeDbfsSpecifications.RequestId");
			describeDbfsSpecificationsResponse.MaxDbfsNumberPerEcs = _ctx.StringValue("DescribeDbfsSpecifications.MaxDbfsNumberPerEcs");

			List<string> describeDbfsSpecificationsResponse_supportedEcsInstanceTypeFamily = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeDbfsSpecifications.SupportedEcsInstanceTypeFamily.Length"); i++) {
				describeDbfsSpecificationsResponse_supportedEcsInstanceTypeFamily.Add(_ctx.StringValue("DescribeDbfsSpecifications.SupportedEcsInstanceTypeFamily["+ i +"]"));
			}
			describeDbfsSpecificationsResponse.SupportedEcsInstanceTypeFamily = describeDbfsSpecificationsResponse_supportedEcsInstanceTypeFamily;
        
			return describeDbfsSpecificationsResponse;
        }
    }
}
