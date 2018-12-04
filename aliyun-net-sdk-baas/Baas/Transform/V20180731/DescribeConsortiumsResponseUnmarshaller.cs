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
    public class DescribeConsortiumsResponseUnmarshaller
    {
        public static DescribeConsortiumsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeConsortiumsResponse describeConsortiumsResponse = new DescribeConsortiumsResponse();

			describeConsortiumsResponse.HttpResponse = context.HttpResponse;
			describeConsortiumsResponse.RequestId = context.StringValue("DescribeConsortiums.RequestId");
			describeConsortiumsResponse.Success = context.BooleanValue("DescribeConsortiums.Success");
			describeConsortiumsResponse.ErrorCode = context.IntegerValue("DescribeConsortiums.ErrorCode");

			List<DescribeConsortiumsResponse.DescribeConsortiums_ResultItem> describeConsortiumsResponse_result = new List<DescribeConsortiumsResponse.DescribeConsortiums_ResultItem>();
			for (int i = 0; i < context.Length("DescribeConsortiums.Result.Length"); i++) {
				DescribeConsortiumsResponse.DescribeConsortiums_ResultItem resultItem = new DescribeConsortiumsResponse.DescribeConsortiums_ResultItem();
				resultItem.RequestId = context.StringValue("DescribeConsortiums.Result["+ i +"].RequestId");
				resultItem.ConsortiumId = context.StringValue("DescribeConsortiums.Result["+ i +"].ConsortiumId");
				resultItem.Name = context.StringValue("DescribeConsortiums.Result["+ i +"].Name");
				resultItem.CodeName = context.StringValue("DescribeConsortiums.Result["+ i +"].CodeName");
				resultItem.OwnerBid = context.StringValue("DescribeConsortiums.Result["+ i +"].OwnerBid");
				resultItem.OwnerUid = context.IntegerValue("DescribeConsortiums.Result["+ i +"].OwnerUid");
				resultItem.OwnerName = context.StringValue("DescribeConsortiums.Result["+ i +"].OwnerName");
				resultItem.ChannelPolicy = context.StringValue("DescribeConsortiums.Result["+ i +"].ChannelPolicy");
				resultItem.OrganizationCount = context.IntegerValue("DescribeConsortiums.Result["+ i +"].OrganizationCount");
				resultItem.ChannelCount = context.IntegerValue("DescribeConsortiums.Result["+ i +"].ChannelCount");
				resultItem.CreateTime = context.StringValue("DescribeConsortiums.Result["+ i +"].CreateTime");
				resultItem.State = context.StringValue("DescribeConsortiums.Result["+ i +"].State");
				resultItem.RegionId = context.StringValue("DescribeConsortiums.Result["+ i +"].RegionId");
				resultItem.Domain = context.StringValue("DescribeConsortiums.Result["+ i +"].Domain");

				describeConsortiumsResponse_result.Add(resultItem);
			}
			describeConsortiumsResponse.Result = describeConsortiumsResponse_result;
        
			return describeConsortiumsResponse;
        }
    }
}