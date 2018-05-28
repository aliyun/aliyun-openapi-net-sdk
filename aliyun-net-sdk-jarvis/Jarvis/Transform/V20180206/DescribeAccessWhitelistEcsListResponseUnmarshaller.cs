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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.jarvis.Model.V20180206;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.jarvis.Transform.V20180206
{
    public class DescribeAccessWhitelistEcsListResponseUnmarshaller
    {
        public static DescribeAccessWhitelistEcsListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeAccessWhitelistEcsListResponse describeAccessWhitelistEcsListResponse = new DescribeAccessWhitelistEcsListResponse();

			describeAccessWhitelistEcsListResponse.HttpResponse = context.HttpResponse;
			describeAccessWhitelistEcsListResponse.RequestId = context.StringValue("DescribeAccessWhitelistEcsList.RequestId");
			describeAccessWhitelistEcsListResponse.TotalCount = context.IntegerValue("DescribeAccessWhitelistEcsList.TotalCount");
			describeAccessWhitelistEcsListResponse.Module = context.StringValue("DescribeAccessWhitelistEcsList.Module");

			List<DescribeAccessWhitelistEcsListResponse.DescribeAccessWhitelistEcsList_Ecs> describeAccessWhitelistEcsListResponse_ecsList = new List<DescribeAccessWhitelistEcsListResponse.DescribeAccessWhitelistEcsList_Ecs>();
			for (int i = 0; i < context.Length("DescribeAccessWhitelistEcsList.EcsList.Length"); i++) {
				DescribeAccessWhitelistEcsListResponse.DescribeAccessWhitelistEcsList_Ecs ecs = new DescribeAccessWhitelistEcsListResponse.DescribeAccessWhitelistEcsList_Ecs();
				ecs.InstanceName = context.StringValue("DescribeAccessWhitelistEcsList.EcsList["+ i +"].InstanceName");
				ecs.InstanceId = context.StringValue("DescribeAccessWhitelistEcsList.EcsList["+ i +"].InstanceId");
				ecs.IP = context.StringValue("DescribeAccessWhitelistEcsList.EcsList["+ i +"].IP");

				describeAccessWhitelistEcsListResponse_ecsList.Add(ecs);
			}
			describeAccessWhitelistEcsListResponse.EcsList = describeAccessWhitelistEcsListResponse_ecsList;
        
			return describeAccessWhitelistEcsListResponse;
        }
    }
}