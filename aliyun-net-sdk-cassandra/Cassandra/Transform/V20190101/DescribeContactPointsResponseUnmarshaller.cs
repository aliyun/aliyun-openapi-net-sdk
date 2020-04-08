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
using Aliyun.Acs.Cassandra.Model.V20190101;

namespace Aliyun.Acs.Cassandra.Transform.V20190101
{
    public class DescribeContactPointsResponseUnmarshaller
    {
        public static DescribeContactPointsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeContactPointsResponse describeContactPointsResponse = new DescribeContactPointsResponse();

			describeContactPointsResponse.HttpResponse = context.HttpResponse;
			describeContactPointsResponse.RequestId = context.StringValue("DescribeContactPoints.RequestId");

			List<DescribeContactPointsResponse.DescribeContactPoints_ContactPoint> describeContactPointsResponse_contactPoints = new List<DescribeContactPointsResponse.DescribeContactPoints_ContactPoint>();
			for (int i = 0; i < context.Length("DescribeContactPoints.ContactPoints.Length"); i++) {
				DescribeContactPointsResponse.DescribeContactPoints_ContactPoint contactPoint = new DescribeContactPointsResponse.DescribeContactPoints_ContactPoint();
				contactPoint.DataCenterId = context.StringValue("DescribeContactPoints.ContactPoints["+ i +"].DataCenterId");
				contactPoint.Port = context.IntegerValue("DescribeContactPoints.ContactPoints["+ i +"].Port");

				List<string> contactPoint_privateAddresses = new List<string>();
				for (int j = 0; j < context.Length("DescribeContactPoints.ContactPoints["+ i +"].PrivateAddresses.Length"); j++) {
					contactPoint_privateAddresses.Add(context.StringValue("DescribeContactPoints.ContactPoints["+ i +"].PrivateAddresses["+ j +"]"));
				}
				contactPoint.PrivateAddresses = contactPoint_privateAddresses;

				List<string> contactPoint_publicAddresses = new List<string>();
				for (int j = 0; j < context.Length("DescribeContactPoints.ContactPoints["+ i +"].PublicAddresses.Length"); j++) {
					contactPoint_publicAddresses.Add(context.StringValue("DescribeContactPoints.ContactPoints["+ i +"].PublicAddresses["+ j +"]"));
				}
				contactPoint.PublicAddresses = contactPoint_publicAddresses;

				describeContactPointsResponse_contactPoints.Add(contactPoint);
			}
			describeContactPointsResponse.ContactPoints = describeContactPointsResponse_contactPoints;
        
			return describeContactPointsResponse;
        }
    }
}
