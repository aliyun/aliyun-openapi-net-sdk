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
using Aliyun.Acs.NAS.Model.V20170626;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.NAS.Transform.V20170626
{
    public class DescribeFileSystemsResponseUnmarshaller
    {
        public static DescribeFileSystemsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeFileSystemsResponse describeFileSystemsResponse = new DescribeFileSystemsResponse();

			describeFileSystemsResponse.HttpResponse = context.HttpResponse;
			describeFileSystemsResponse.RequestId = context.StringValue("DescribeFileSystems.RequestId");
			describeFileSystemsResponse.TotalCount = context.IntegerValue("DescribeFileSystems.TotalCount");
			describeFileSystemsResponse.PageSize = context.IntegerValue("DescribeFileSystems.PageSize");
			describeFileSystemsResponse.PageNumber = context.IntegerValue("DescribeFileSystems.PageNumber");

			List<DescribeFileSystemsResponse.DescribeFileSystems_FileSystem> describeFileSystemsResponse_fileSystems = new List<DescribeFileSystemsResponse.DescribeFileSystems_FileSystem>();
			for (int i = 0; i < context.Length("DescribeFileSystems.FileSystems.Length"); i++) {
				DescribeFileSystemsResponse.DescribeFileSystems_FileSystem fileSystem = new DescribeFileSystemsResponse.DescribeFileSystems_FileSystem();
				fileSystem.FileSystemId = context.StringValue("DescribeFileSystems.FileSystems["+ i +"].FileSystemId");
				fileSystem.Destription = context.StringValue("DescribeFileSystems.FileSystems["+ i +"].Destription");
				fileSystem.CreateTime = context.StringValue("DescribeFileSystems.FileSystems["+ i +"].CreateTime");
				fileSystem.RegionId = context.StringValue("DescribeFileSystems.FileSystems["+ i +"].RegionId");
				fileSystem.ProtocolType = context.StringValue("DescribeFileSystems.FileSystems["+ i +"].ProtocolType");
				fileSystem.StorageType = context.StringValue("DescribeFileSystems.FileSystems["+ i +"].StorageType");
				fileSystem.MeteredSize = context.LongValue("DescribeFileSystems.FileSystems["+ i +"].MeteredSize");

				List<DescribeFileSystemsResponse.DescribeFileSystems_FileSystem.DescribeFileSystems_MountTarget> fileSystem_mountTargets = new List<DescribeFileSystemsResponse.DescribeFileSystems_FileSystem.DescribeFileSystems_MountTarget>();
				for (int j = 0; j < context.Length("DescribeFileSystems.FileSystems["+ i +"].MountTargets.Length"); j++) {
					DescribeFileSystemsResponse.DescribeFileSystems_FileSystem.DescribeFileSystems_MountTarget mountTarget = new DescribeFileSystemsResponse.DescribeFileSystems_FileSystem.DescribeFileSystems_MountTarget();
					mountTarget.MountTargetDomain = context.StringValue("DescribeFileSystems.FileSystems["+ i +"].MountTargets["+ j +"].MountTargetDomain");

					fileSystem_mountTargets.Add(mountTarget);
				}
				fileSystem.MountTargets = fileSystem_mountTargets;

				List<DescribeFileSystemsResponse.DescribeFileSystems_FileSystem.DescribeFileSystems_Package> fileSystem_packages = new List<DescribeFileSystemsResponse.DescribeFileSystems_FileSystem.DescribeFileSystems_Package>();
				for (int j = 0; j < context.Length("DescribeFileSystems.FileSystems["+ i +"].Packages.Length"); j++) {
					DescribeFileSystemsResponse.DescribeFileSystems_FileSystem.DescribeFileSystems_Package package = new DescribeFileSystemsResponse.DescribeFileSystems_FileSystem.DescribeFileSystems_Package();
					package.PackageId = context.StringValue("DescribeFileSystems.FileSystems["+ i +"].Packages["+ j +"].PackageId");

					fileSystem_packages.Add(package);
				}
				fileSystem.Packages = fileSystem_packages;

				describeFileSystemsResponse_fileSystems.Add(fileSystem);
			}
			describeFileSystemsResponse.FileSystems = describeFileSystemsResponse_fileSystems;
        
			return describeFileSystemsResponse;
        }
    }
}