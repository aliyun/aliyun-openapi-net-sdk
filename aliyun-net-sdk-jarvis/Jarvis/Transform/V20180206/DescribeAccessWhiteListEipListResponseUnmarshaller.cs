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
    public class DescribeAccessWhiteListEipListResponseUnmarshaller
    {
        public static DescribeAccessWhiteListEipListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeAccessWhiteListEipListResponse describeAccessWhiteListEipListResponse = new DescribeAccessWhiteListEipListResponse();

			describeAccessWhiteListEipListResponse.HttpResponse = context.HttpResponse;
			describeAccessWhiteListEipListResponse.RequestId = context.StringValue("DescribeAccessWhiteListEipList.RequestId");
			describeAccessWhiteListEipListResponse.TotalCount = context.IntegerValue("DescribeAccessWhiteListEipList.TotalCount");
			describeAccessWhiteListEipListResponse.Module = context.StringValue("DescribeAccessWhiteListEipList.Module");

			List<DescribeAccessWhiteListEipListResponse.DescribeAccessWhiteListEipList_Ecs> describeAccessWhiteListEipListResponse_ecsList = new List<DescribeAccessWhiteListEipListResponse.DescribeAccessWhiteListEipList_Ecs>();
			for (int i = 0; i < context.Length("DescribeAccessWhiteListEipList.EcsList.Length"); i++) {
				DescribeAccessWhiteListEipListResponse.DescribeAccessWhiteListEipList_Ecs ecs = new DescribeAccessWhiteListEipListResponse.DescribeAccessWhiteListEipList_Ecs();
				ecs.InstanceName = context.StringValue("DescribeAccessWhiteListEipList.EcsList["+ i +"].InstanceName");
				ecs.InstanceId = context.StringValue("DescribeAccessWhiteListEipList.EcsList["+ i +"].InstanceId");
				ecs.IP = context.StringValue("DescribeAccessWhiteListEipList.EcsList["+ i +"].IP");

				describeAccessWhiteListEipListResponse_ecsList.Add(ecs);
			}
			describeAccessWhiteListEipListResponse.EcsList = describeAccessWhiteListEipListResponse_ecsList;
        
			return describeAccessWhiteListEipListResponse;
        }
    }
}