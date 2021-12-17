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
using Aliyun.Acs.NAS.Model.V20170626;

namespace Aliyun.Acs.NAS.Transform.V20170626
{
    public class DescribeStoragePackagesResponseUnmarshaller
    {
        public static DescribeStoragePackagesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeStoragePackagesResponse describeStoragePackagesResponse = new DescribeStoragePackagesResponse();

			describeStoragePackagesResponse.HttpResponse = _ctx.HttpResponse;
			describeStoragePackagesResponse.RequestId = _ctx.StringValue("DescribeStoragePackages.RequestId");
			describeStoragePackagesResponse.TotalCount = _ctx.IntegerValue("DescribeStoragePackages.TotalCount");
			describeStoragePackagesResponse.PageSize = _ctx.IntegerValue("DescribeStoragePackages.PageSize");
			describeStoragePackagesResponse.PageNumber = _ctx.IntegerValue("DescribeStoragePackages.PageNumber");

			List<DescribeStoragePackagesResponse.DescribeStoragePackages_Package> describeStoragePackagesResponse_packages = new List<DescribeStoragePackagesResponse.DescribeStoragePackages_Package>();
			for (int i = 0; i < _ctx.Length("DescribeStoragePackages.Packages.Length"); i++) {
				DescribeStoragePackagesResponse.DescribeStoragePackages_Package package = new DescribeStoragePackagesResponse.DescribeStoragePackages_Package();
				package.StartTime = _ctx.StringValue("DescribeStoragePackages.Packages["+ i +"].StartTime");
				package.StorageType = _ctx.StringValue("DescribeStoragePackages.Packages["+ i +"].StorageType");
				package.Status = _ctx.StringValue("DescribeStoragePackages.Packages["+ i +"].Status");
				package.FileSystemId = _ctx.StringValue("DescribeStoragePackages.Packages["+ i +"].FileSystemId");
				package.PackageId = _ctx.StringValue("DescribeStoragePackages.Packages["+ i +"].PackageId");
				package.ExpiredTime = _ctx.StringValue("DescribeStoragePackages.Packages["+ i +"].ExpiredTime");
				package.Size = _ctx.LongValue("DescribeStoragePackages.Packages["+ i +"].Size");

				describeStoragePackagesResponse_packages.Add(package);
			}
			describeStoragePackagesResponse.Packages = describeStoragePackagesResponse_packages;
        
			return describeStoragePackagesResponse;
        }
    }
}
