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
				fileSystem.Description = context.StringValue("DescribeFileSystems.FileSystems["+ i +"].Description");
				fileSystem.CreateTime = context.StringValue("DescribeFileSystems.FileSystems["+ i +"].CreateTime");
				fileSystem.ExpiredTime = context.StringValue("DescribeFileSystems.FileSystems["+ i +"].ExpiredTime");
				fileSystem.RegionId = context.StringValue("DescribeFileSystems.FileSystems["+ i +"].RegionId");
				fileSystem.ZoneId = context.StringValue("DescribeFileSystems.FileSystems["+ i +"].ZoneId");
				fileSystem.ProtocolType = context.StringValue("DescribeFileSystems.FileSystems["+ i +"].ProtocolType");
				fileSystem.StorageType = context.StringValue("DescribeFileSystems.FileSystems["+ i +"].StorageType");
				fileSystem.FileSystemType = context.StringValue("DescribeFileSystems.FileSystems["+ i +"].FileSystemType");
				fileSystem.EncryptType = context.IntegerValue("DescribeFileSystems.FileSystems["+ i +"].EncryptType");
				fileSystem.MeteredSize = context.LongValue("DescribeFileSystems.FileSystems["+ i +"].MeteredSize");
				fileSystem.Bandwidth = context.LongValue("DescribeFileSystems.FileSystems["+ i +"].Bandwidth");
				fileSystem.Capacity = context.LongValue("DescribeFileSystems.FileSystems["+ i +"].Capacity");
				fileSystem.AutoSnapshotPolicyId = context.StringValue("DescribeFileSystems.FileSystems["+ i +"].AutoSnapshotPolicyId");
				fileSystem.Status = context.StringValue("DescribeFileSystems.FileSystems["+ i +"].Status");
				fileSystem.ChargeType = context.StringValue("DescribeFileSystems.FileSystems["+ i +"].ChargeType");
				fileSystem.MountTargetCountLimit = context.LongValue("DescribeFileSystems.FileSystems["+ i +"].MountTargetCountLimit");

				DescribeFileSystemsResponse.DescribeFileSystems_FileSystem.DescribeFileSystems_Ldap ldap = new DescribeFileSystemsResponse.DescribeFileSystems_FileSystem.DescribeFileSystems_Ldap();
				ldap.BindDN = context.StringValue("DescribeFileSystems.FileSystems["+ i +"].Ldap.BindDN");
				ldap.URI = context.StringValue("DescribeFileSystems.FileSystems["+ i +"].Ldap.URI");
				ldap.SearchBase = context.StringValue("DescribeFileSystems.FileSystems["+ i +"].Ldap.SearchBase");
				fileSystem.Ldap = ldap;

				List<DescribeFileSystemsResponse.DescribeFileSystems_FileSystem.DescribeFileSystems_MountTarget> fileSystem_mountTargets = new List<DescribeFileSystemsResponse.DescribeFileSystems_FileSystem.DescribeFileSystems_MountTarget>();
				for (int j = 0; j < context.Length("DescribeFileSystems.FileSystems["+ i +"].MountTargets.Length"); j++) {
					DescribeFileSystemsResponse.DescribeFileSystems_FileSystem.DescribeFileSystems_MountTarget mountTarget = new DescribeFileSystemsResponse.DescribeFileSystems_FileSystem.DescribeFileSystems_MountTarget();
					mountTarget.MountTargetDomain = context.StringValue("DescribeFileSystems.FileSystems["+ i +"].MountTargets["+ j +"].MountTargetDomain");
					mountTarget.NetworkType = context.StringValue("DescribeFileSystems.FileSystems["+ i +"].MountTargets["+ j +"].NetworkType");
					mountTarget.VpcId = context.StringValue("DescribeFileSystems.FileSystems["+ i +"].MountTargets["+ j +"].VpcId");
					mountTarget.VswId = context.StringValue("DescribeFileSystems.FileSystems["+ i +"].MountTargets["+ j +"].VswId");
					mountTarget.AccessGroupName = context.StringValue("DescribeFileSystems.FileSystems["+ i +"].MountTargets["+ j +"].AccessGroupName");
					mountTarget.Status = context.StringValue("DescribeFileSystems.FileSystems["+ i +"].MountTargets["+ j +"].Status");

					List<DescribeFileSystemsResponse.DescribeFileSystems_FileSystem.DescribeFileSystems_MountTarget.DescribeFileSystems_Tag> mountTarget_tags = new List<DescribeFileSystemsResponse.DescribeFileSystems_FileSystem.DescribeFileSystems_MountTarget.DescribeFileSystems_Tag>();
					for (int k = 0; k < context.Length("DescribeFileSystems.FileSystems["+ i +"].MountTargets["+ j +"].Tags.Length"); k++) {
						DescribeFileSystemsResponse.DescribeFileSystems_FileSystem.DescribeFileSystems_MountTarget.DescribeFileSystems_Tag tag = new DescribeFileSystemsResponse.DescribeFileSystems_FileSystem.DescribeFileSystems_MountTarget.DescribeFileSystems_Tag();
						tag.Key = context.StringValue("DescribeFileSystems.FileSystems["+ i +"].MountTargets["+ j +"].Tags["+ k +"].Key");
						tag._Value = context.StringValue("DescribeFileSystems.FileSystems["+ i +"].MountTargets["+ j +"].Tags["+ k +"].Value");

						mountTarget_tags.Add(tag);
					}
					mountTarget.Tags = mountTarget_tags;

					fileSystem_mountTargets.Add(mountTarget);
				}
				fileSystem.MountTargets = fileSystem_mountTargets;

				List<DescribeFileSystemsResponse.DescribeFileSystems_FileSystem.DescribeFileSystems_Package> fileSystem_packages = new List<DescribeFileSystemsResponse.DescribeFileSystems_FileSystem.DescribeFileSystems_Package>();
				for (int j = 0; j < context.Length("DescribeFileSystems.FileSystems["+ i +"].Packages.Length"); j++) {
					DescribeFileSystemsResponse.DescribeFileSystems_FileSystem.DescribeFileSystems_Package package = new DescribeFileSystemsResponse.DescribeFileSystems_FileSystem.DescribeFileSystems_Package();
					package.PackageId = context.StringValue("DescribeFileSystems.FileSystems["+ i +"].Packages["+ j +"].PackageId");
					package.PackageType = context.StringValue("DescribeFileSystems.FileSystems["+ i +"].Packages["+ j +"].PackageType");
					package.Size = context.LongValue("DescribeFileSystems.FileSystems["+ i +"].Packages["+ j +"].Size");
					package.StartTime = context.StringValue("DescribeFileSystems.FileSystems["+ i +"].Packages["+ j +"].StartTime");
					package.ExpiredTime = context.StringValue("DescribeFileSystems.FileSystems["+ i +"].Packages["+ j +"].ExpiredTime");

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
