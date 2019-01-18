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
    public class DescribeOrganizationsResponseUnmarshaller
    {
        public static DescribeOrganizationsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeOrganizationsResponse describeOrganizationsResponse = new DescribeOrganizationsResponse();

			describeOrganizationsResponse.HttpResponse = context.HttpResponse;
			describeOrganizationsResponse.RequestId = context.StringValue("DescribeOrganizations.RequestId");
			describeOrganizationsResponse.Success = context.BooleanValue("DescribeOrganizations.Success");
			describeOrganizationsResponse.ErrorCode = context.IntegerValue("DescribeOrganizations.ErrorCode");

			List<DescribeOrganizationsResponse.DescribeOrganizations_ResultItem> describeOrganizationsResponse_result = new List<DescribeOrganizationsResponse.DescribeOrganizations_ResultItem>();
			for (int i = 0; i < context.Length("DescribeOrganizations.Result.Length"); i++) {
				DescribeOrganizationsResponse.DescribeOrganizations_ResultItem resultItem = new DescribeOrganizationsResponse.DescribeOrganizations_ResultItem();
				resultItem.OrganizationId = context.StringValue("DescribeOrganizations.Result["+ i +"].OrganizationId");
				resultItem.Name = context.StringValue("DescribeOrganizations.Result["+ i +"].Name");
				resultItem.RegionId = context.StringValue("DescribeOrganizations.Result["+ i +"].RegionId");
				resultItem.ZoneId = context.StringValue("DescribeOrganizations.Result["+ i +"].ZoneId");
				resultItem.CodeName = context.StringValue("DescribeOrganizations.Result["+ i +"].CodeName");
				resultItem.Domain = context.StringValue("DescribeOrganizations.Result["+ i +"].Domain");
				resultItem.Description = context.StringValue("DescribeOrganizations.Result["+ i +"].Description");
				resultItem.OwnerBid = context.StringValue("DescribeOrganizations.Result["+ i +"].OwnerBid");
				resultItem.OwnerUid = context.IntegerValue("DescribeOrganizations.Result["+ i +"].OwnerUid");
				resultItem.OwnerName = context.StringValue("DescribeOrganizations.Result["+ i +"].OwnerName");
				resultItem.PeerCount = context.IntegerValue("DescribeOrganizations.Result["+ i +"].PeerCount");
				resultItem.UserCount = context.IntegerValue("DescribeOrganizations.Result["+ i +"].UserCount");
				resultItem.ConsortiumCount = context.IntegerValue("DescribeOrganizations.Result["+ i +"].ConsortiumCount");
				resultItem.SpecName = context.StringValue("DescribeOrganizations.Result["+ i +"].SpecName");
				resultItem.RequestId = context.StringValue("DescribeOrganizations.Result["+ i +"].RequestId");
				resultItem.CreateTime = context.StringValue("DescribeOrganizations.Result["+ i +"].CreateTime");
				resultItem.State = context.StringValue("DescribeOrganizations.Result["+ i +"].State");

				describeOrganizationsResponse_result.Add(resultItem);
			}
			describeOrganizationsResponse.Result = describeOrganizationsResponse_result;
        
			return describeOrganizationsResponse;
        }
    }
}