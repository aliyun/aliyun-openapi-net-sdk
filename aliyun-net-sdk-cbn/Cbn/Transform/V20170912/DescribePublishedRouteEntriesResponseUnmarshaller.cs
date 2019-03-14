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
using Aliyun.Acs.Cbn.Model.V20170912;

namespace Aliyun.Acs.Cbn.Transform.V20170912
{
    public class DescribePublishedRouteEntriesResponseUnmarshaller
    {
        public static DescribePublishedRouteEntriesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribePublishedRouteEntriesResponse describePublishedRouteEntriesResponse = new DescribePublishedRouteEntriesResponse();

			describePublishedRouteEntriesResponse.HttpResponse = context.HttpResponse;
			describePublishedRouteEntriesResponse.RequestId = context.StringValue("DescribePublishedRouteEntries.RequestId");
			describePublishedRouteEntriesResponse.PageNumber = context.IntegerValue("DescribePublishedRouteEntries.PageNumber");
			describePublishedRouteEntriesResponse.TotalCount = context.IntegerValue("DescribePublishedRouteEntries.TotalCount");
			describePublishedRouteEntriesResponse.PageSize = context.IntegerValue("DescribePublishedRouteEntries.PageSize");

			List<DescribePublishedRouteEntriesResponse.DescribePublishedRouteEntries_PublishedRouteEntry> describePublishedRouteEntriesResponse_publishedRouteEntries = new List<DescribePublishedRouteEntriesResponse.DescribePublishedRouteEntries_PublishedRouteEntry>();
			for (int i = 0; i < context.Length("DescribePublishedRouteEntries.PublishedRouteEntries.Length"); i++) {
				DescribePublishedRouteEntriesResponse.DescribePublishedRouteEntries_PublishedRouteEntry publishedRouteEntry = new DescribePublishedRouteEntriesResponse.DescribePublishedRouteEntries_PublishedRouteEntry();
				publishedRouteEntry.DestinationCidrBlock = context.StringValue("DescribePublishedRouteEntries.PublishedRouteEntries["+ i +"].DestinationCidrBlock");
				publishedRouteEntry.ChildInstanceRouteTableId = context.StringValue("DescribePublishedRouteEntries.PublishedRouteEntries["+ i +"].ChildInstanceRouteTableId");
				publishedRouteEntry.NextHopType = context.StringValue("DescribePublishedRouteEntries.PublishedRouteEntries["+ i +"].NextHopType");
				publishedRouteEntry.RouteType = context.StringValue("DescribePublishedRouteEntries.PublishedRouteEntries["+ i +"].RouteType");
				publishedRouteEntry.NextHopId = context.StringValue("DescribePublishedRouteEntries.PublishedRouteEntries["+ i +"].NextHopId");
				publishedRouteEntry.OperationalMode = context.BooleanValue("DescribePublishedRouteEntries.PublishedRouteEntries["+ i +"].OperationalMode");
				publishedRouteEntry.PublishStatus = context.StringValue("DescribePublishedRouteEntries.PublishedRouteEntries["+ i +"].PublishStatus");

				List<DescribePublishedRouteEntriesResponse.DescribePublishedRouteEntries_PublishedRouteEntry.DescribePublishedRouteEntries_Conflict> publishedRouteEntry_conflicts = new List<DescribePublishedRouteEntriesResponse.DescribePublishedRouteEntries_PublishedRouteEntry.DescribePublishedRouteEntries_Conflict>();
				for (int j = 0; j < context.Length("DescribePublishedRouteEntries.PublishedRouteEntries["+ i +"].Conflicts.Length"); j++) {
					DescribePublishedRouteEntriesResponse.DescribePublishedRouteEntries_PublishedRouteEntry.DescribePublishedRouteEntries_Conflict conflict = new DescribePublishedRouteEntriesResponse.DescribePublishedRouteEntries_PublishedRouteEntry.DescribePublishedRouteEntries_Conflict();
					conflict.DestinationCidrBlock = context.StringValue("DescribePublishedRouteEntries.PublishedRouteEntries["+ i +"].Conflicts["+ j +"].DestinationCidrBlock");
					conflict.RegionId = context.StringValue("DescribePublishedRouteEntries.PublishedRouteEntries["+ i +"].Conflicts["+ j +"].RegionId");
					conflict.InstanceId = context.StringValue("DescribePublishedRouteEntries.PublishedRouteEntries["+ i +"].Conflicts["+ j +"].InstanceId");
					conflict.InstanceType = context.StringValue("DescribePublishedRouteEntries.PublishedRouteEntries["+ i +"].Conflicts["+ j +"].InstanceType");
					conflict.Status = context.StringValue("DescribePublishedRouteEntries.PublishedRouteEntries["+ i +"].Conflicts["+ j +"].Status");

					publishedRouteEntry_conflicts.Add(conflict);
				}
				publishedRouteEntry.Conflicts = publishedRouteEntry_conflicts;

				describePublishedRouteEntriesResponse_publishedRouteEntries.Add(publishedRouteEntry);
			}
			describePublishedRouteEntriesResponse.PublishedRouteEntries = describePublishedRouteEntriesResponse_publishedRouteEntries;
        
			return describePublishedRouteEntriesResponse;
        }
    }
}
