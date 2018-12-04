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
using Aliyun.Acs.Baas.Model.V20180731;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Baas.Transform.V20180731
{
    public class DescribeConsortiumOrderersResponseUnmarshaller
    {
        public static DescribeConsortiumOrderersResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeConsortiumOrderersResponse describeConsortiumOrderersResponse = new DescribeConsortiumOrderersResponse();

			describeConsortiumOrderersResponse.HttpResponse = context.HttpResponse;
			describeConsortiumOrderersResponse.RequestId = context.StringValue("DescribeConsortiumOrderers.RequestId");
			describeConsortiumOrderersResponse.Success = context.BooleanValue("DescribeConsortiumOrderers.Success");
			describeConsortiumOrderersResponse.ErrorCode = context.IntegerValue("DescribeConsortiumOrderers.ErrorCode");

			List<DescribeConsortiumOrderersResponse.DescribeConsortiumOrderers_Orderer> describeConsortiumOrderersResponse_result = new List<DescribeConsortiumOrderersResponse.DescribeConsortiumOrderers_Orderer>();
			for (int i = 0; i < context.Length("DescribeConsortiumOrderers.Result.Length"); i++) {
				DescribeConsortiumOrderersResponse.DescribeConsortiumOrderers_Orderer orderer = new DescribeConsortiumOrderersResponse.DescribeConsortiumOrderers_Orderer();
				orderer.Name = context.StringValue("DescribeConsortiumOrderers.Result["+ i +"].Name");
				orderer.Domain = context.StringValue("DescribeConsortiumOrderers.Result["+ i +"].Domain");
				orderer.Port = context.IntegerValue("DescribeConsortiumOrderers.Result["+ i +"].Port");
				orderer.InstanceType = context.StringValue("DescribeConsortiumOrderers.Result["+ i +"].InstanceType");
				orderer.CreateTime = context.StringValue("DescribeConsortiumOrderers.Result["+ i +"].CreateTime");
				orderer.UpdateTime = context.StringValue("DescribeConsortiumOrderers.Result["+ i +"].UpdateTime");

				describeConsortiumOrderersResponse_result.Add(orderer);
			}
			describeConsortiumOrderersResponse.Result = describeConsortiumOrderersResponse_result;
        
			return describeConsortiumOrderersResponse;
        }
    }
}