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
    public class DescribeSnapshotPackageResponseUnmarshaller
    {
        public static DescribeSnapshotPackageResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSnapshotPackageResponse describeSnapshotPackageResponse = new DescribeSnapshotPackageResponse();

			describeSnapshotPackageResponse.HttpResponse = _ctx.HttpResponse;
			describeSnapshotPackageResponse.PageSize = _ctx.IntegerValue("DescribeSnapshotPackage.PageSize");
			describeSnapshotPackageResponse.RequestId = _ctx.StringValue("DescribeSnapshotPackage.RequestId");
			describeSnapshotPackageResponse.PageNumber = _ctx.IntegerValue("DescribeSnapshotPackage.PageNumber");
			describeSnapshotPackageResponse.TotalCount = _ctx.IntegerValue("DescribeSnapshotPackage.TotalCount");

			List<DescribeSnapshotPackageResponse.DescribeSnapshotPackage_SnapshotPackage> describeSnapshotPackageResponse_snapshotPackages = new List<DescribeSnapshotPackageResponse.DescribeSnapshotPackage_SnapshotPackage>();
			for (int i = 0; i < _ctx.Length("DescribeSnapshotPackage.SnapshotPackages.Length"); i++) {
				DescribeSnapshotPackageResponse.DescribeSnapshotPackage_SnapshotPackage snapshotPackage = new DescribeSnapshotPackageResponse.DescribeSnapshotPackage_SnapshotPackage();
				snapshotPackage.DisplayName = _ctx.StringValue("DescribeSnapshotPackage.SnapshotPackages["+ i +"].DisplayName");
				snapshotPackage.EndTime = _ctx.StringValue("DescribeSnapshotPackage.SnapshotPackages["+ i +"].EndTime");
				snapshotPackage.StartTime = _ctx.StringValue("DescribeSnapshotPackage.SnapshotPackages["+ i +"].StartTime");
				snapshotPackage.InitCapacity = _ctx.LongValue("DescribeSnapshotPackage.SnapshotPackages["+ i +"].InitCapacity");

				describeSnapshotPackageResponse_snapshotPackages.Add(snapshotPackage);
			}
			describeSnapshotPackageResponse.SnapshotPackages = describeSnapshotPackageResponse_snapshotPackages;
        
			return describeSnapshotPackageResponse;
        }
    }
}
