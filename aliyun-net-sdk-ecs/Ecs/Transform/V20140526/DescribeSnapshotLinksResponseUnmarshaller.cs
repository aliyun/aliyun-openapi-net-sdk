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
using Aliyun.Acs.Ecs.Model.V20140526;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeSnapshotLinksResponseUnmarshaller
    {
        public static DescribeSnapshotLinksResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSnapshotLinksResponse describeSnapshotLinksResponse = new DescribeSnapshotLinksResponse();

			describeSnapshotLinksResponse.HttpResponse = context.HttpResponse;
			describeSnapshotLinksResponse.RequestId = context.StringValue("DescribeSnapshotLinks.RequestId");
			describeSnapshotLinksResponse.TotalCount = context.IntegerValue("DescribeSnapshotLinks.TotalCount");
			describeSnapshotLinksResponse.PageNumber = context.IntegerValue("DescribeSnapshotLinks.PageNumber");
			describeSnapshotLinksResponse.PageSize = context.IntegerValue("DescribeSnapshotLinks.PageSize");

			List<DescribeSnapshotLinksResponse.DescribeSnapshotLinks_SnapshotLink> describeSnapshotLinksResponse_snapshotLinks = new List<DescribeSnapshotLinksResponse.DescribeSnapshotLinks_SnapshotLink>();
			for (int i = 0; i < context.Length("DescribeSnapshotLinks.SnapshotLinks.Length"); i++) {
				DescribeSnapshotLinksResponse.DescribeSnapshotLinks_SnapshotLink snapshotLink = new DescribeSnapshotLinksResponse.DescribeSnapshotLinks_SnapshotLink();
				snapshotLink.SnapshotLinkId = context.StringValue("DescribeSnapshotLinks.SnapshotLinks["+ i +"].SnapshotLinkId");
				snapshotLink.RegionId = context.StringValue("DescribeSnapshotLinks.SnapshotLinks["+ i +"].RegionId");
				snapshotLink.InstanceId = context.StringValue("DescribeSnapshotLinks.SnapshotLinks["+ i +"].InstanceId");
				snapshotLink.InstanceName = context.StringValue("DescribeSnapshotLinks.SnapshotLinks["+ i +"].InstanceName");
				snapshotLink.SourceDiskId = context.StringValue("DescribeSnapshotLinks.SnapshotLinks["+ i +"].SourceDiskId");
				snapshotLink.SourceDiskName = context.StringValue("DescribeSnapshotLinks.SnapshotLinks["+ i +"].SourceDiskName");
				snapshotLink.SourceDiskSize = context.IntegerValue("DescribeSnapshotLinks.SnapshotLinks["+ i +"].SourceDiskSize");
				snapshotLink.SourceDiskType = context.StringValue("DescribeSnapshotLinks.SnapshotLinks["+ i +"].SourceDiskType");
				snapshotLink.Category = context.StringValue("DescribeSnapshotLinks.SnapshotLinks["+ i +"].Category");
				snapshotLink.TotalSize = context.LongValue("DescribeSnapshotLinks.SnapshotLinks["+ i +"].TotalSize");
				snapshotLink.TotalCount = context.IntegerValue("DescribeSnapshotLinks.SnapshotLinks["+ i +"].TotalCount");

				describeSnapshotLinksResponse_snapshotLinks.Add(snapshotLink);
			}
			describeSnapshotLinksResponse.SnapshotLinks = describeSnapshotLinksResponse_snapshotLinks;
        
			return describeSnapshotLinksResponse;
        }
    }
}
