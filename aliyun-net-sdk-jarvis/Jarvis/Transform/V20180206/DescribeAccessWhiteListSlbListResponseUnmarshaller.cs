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
    public class DescribeAccessWhiteListSlbListResponseUnmarshaller
    {
        public static DescribeAccessWhiteListSlbListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeAccessWhiteListSlbListResponse describeAccessWhiteListSlbListResponse = new DescribeAccessWhiteListSlbListResponse();

			describeAccessWhiteListSlbListResponse.HttpResponse = context.HttpResponse;
			describeAccessWhiteListSlbListResponse.RequestId = context.StringValue("DescribeAccessWhiteListSlbList.RequestId");
			describeAccessWhiteListSlbListResponse.TotalCount = context.IntegerValue("DescribeAccessWhiteListSlbList.TotalCount");
			describeAccessWhiteListSlbListResponse.Module = context.StringValue("DescribeAccessWhiteListSlbList.Module");

			List<DescribeAccessWhiteListSlbListResponse.DescribeAccessWhiteListSlbList_Ecs> describeAccessWhiteListSlbListResponse_ecsList = new List<DescribeAccessWhiteListSlbListResponse.DescribeAccessWhiteListSlbList_Ecs>();
			for (int i = 0; i < context.Length("DescribeAccessWhiteListSlbList.EcsList.Length"); i++) {
				DescribeAccessWhiteListSlbListResponse.DescribeAccessWhiteListSlbList_Ecs ecs = new DescribeAccessWhiteListSlbListResponse.DescribeAccessWhiteListSlbList_Ecs();
				ecs.InstanceName = context.StringValue("DescribeAccessWhiteListSlbList.EcsList["+ i +"].InstanceName");
				ecs.InstanceId = context.StringValue("DescribeAccessWhiteListSlbList.EcsList["+ i +"].InstanceId");
				ecs.IP = context.StringValue("DescribeAccessWhiteListSlbList.EcsList["+ i +"].IP");

				describeAccessWhiteListSlbListResponse_ecsList.Add(ecs);
			}
			describeAccessWhiteListSlbListResponse.EcsList = describeAccessWhiteListSlbListResponse_ecsList;
        
			return describeAccessWhiteListSlbListResponse;
        }
    }
}