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
        public static DescribeFileSystemsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeFileSystemsResponse describeFileSystemsResponse = new DescribeFileSystemsResponse();

			describeFileSystemsResponse.HttpResponse = _ctx.HttpResponse;
			describeFileSystemsResponse.RequestId = _ctx.StringValue("DescribeFileSystems.RequestId");
			describeFileSystemsResponse.TotalCount = _ctx.IntegerValue("DescribeFileSystems.TotalCount");
			describeFileSystemsResponse.PageSize = _ctx.IntegerValue("DescribeFileSystems.PageSize");
			describeFileSystemsResponse.PageNumber = _ctx.IntegerValue("DescribeFileSystems.PageNumber");

			List<DescribeFileSystemsResponse.DescribeFileSystems_FileSystem> describeFileSystemsResponse_fileSystems = new List<DescribeFileSystemsResponse.DescribeFileSystems_FileSystem>();
			for (int i = 0; i < _ctx.Length("DescribeFileSystems.FileSystems.Length"); i++) {
				DescribeFileSystemsResponse.DescribeFileSystems_FileSystem fileSystem = new DescribeFileSystemsResponse.DescribeFileSystems_FileSystem();
				fileSystem.FileSystemId = _ctx.StringValue("DescribeFileSystems.FileSystems["+ i +"].FileSystemId");
				fileSystem.Description = _ctx.StringValue("DescribeFileSystems.FileSystems["+ i +"].Description");
				fileSystem.CreateTime = _ctx.StringValue("DescribeFileSystems.FileSystems["+ i +"].CreateTime");
				fileSystem.ExpiredTime = _ctx.StringValue("DescribeFileSystems.FileSystems["+ i +"].ExpiredTime");
				fileSystem.RegionId = _ctx.StringValue("DescribeFileSystems.FileSystems["+ i +"].RegionId");
				fileSystem.ZoneId = _ctx.StringValue("DescribeFileSystems.FileSystems["+ i +"].ZoneId");
				fileSystem.ProtocolType = _ctx.StringValue("DescribeFileSystems.FileSystems["+ i +"].ProtocolType");
				fileSystem.StorageType = _ctx.StringValue("DescribeFileSystems.FileSystems["+ i +"].StorageType");
				fileSystem.FileSystemType = _ctx.StringValue("DescribeFileSystems.FileSystems["+ i +"].FileSystemType");
				fileSystem.EncryptType = _ctx.IntegerValue("DescribeFileSystems.FileSystems["+ i +"].EncryptType");
				fileSystem.MeteredSize = _ctx.LongValue("DescribeFileSystems.FileSystems["+ i +"].MeteredSize");
				fileSystem.MeteredIASize = _ctx.LongValue("DescribeFileSystems.FileSystems["+ i +"].MeteredIASize");
				fileSystem.Bandwidth = _ctx.LongValue("DescribeFileSystems.FileSystems["+ i +"].Bandwidth");
				fileSystem.Capacity = _ctx.LongValue("DescribeFileSystems.FileSystems["+ i +"].Capacity");
				fileSystem.AutoSnapshotPolicyId = _ctx.StringValue("DescribeFileSystems.FileSystems["+ i +"].AutoSnapshotPolicyId");
				fileSystem.Status = _ctx.StringValue("DescribeFileSystems.FileSystems["+ i +"].Status");
				fileSystem.ChargeType = _ctx.StringValue("DescribeFileSystems.FileSystems["+ i +"].ChargeType");
				fileSystem.MountTargetCountLimit = _ctx.LongValue("DescribeFileSystems.FileSystems["+ i +"].MountTargetCountLimit");
				fileSystem.NasNamespaceId = _ctx.StringValue("DescribeFileSystems.FileSystems["+ i +"].NasNamespaceId");
				fileSystem.KMSKeyId = _ctx.StringValue("DescribeFileSystems.FileSystems["+ i +"].KMSKeyId");
				fileSystem.Version = _ctx.StringValue("DescribeFileSystems.FileSystems["+ i +"].Version");

				List<string> fileSystem_supportedFeatures = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeFileSystems.FileSystems["+ i +"].SupportedFeatures.Length"); j++) {
					fileSystem_supportedFeatures.Add(_ctx.StringValue("DescribeFileSystems.FileSystems["+ i +"].SupportedFeatures["+ j +"]"));
				}
				fileSystem.SupportedFeatures = fileSystem_supportedFeatures;

				DescribeFileSystemsResponse.DescribeFileSystems_FileSystem.DescribeFileSystems_Ldap ldap = new DescribeFileSystemsResponse.DescribeFileSystems_FileSystem.DescribeFileSystems_Ldap();
				ldap.BindDN = _ctx.StringValue("DescribeFileSystems.FileSystems["+ i +"].Ldap.BindDN");
				ldap.URI = _ctx.StringValue("DescribeFileSystems.FileSystems["+ i +"].Ldap.URI");
				ldap.SearchBase = _ctx.StringValue("DescribeFileSystems.FileSystems["+ i +"].Ldap.SearchBase");
				fileSystem.Ldap = ldap;

				List<DescribeFileSystemsResponse.DescribeFileSystems_FileSystem.DescribeFileSystems_MountTarget> fileSystem_mountTargets = new List<DescribeFileSystemsResponse.DescribeFileSystems_FileSystem.DescribeFileSystems_MountTarget>();
				for (int j = 0; j < _ctx.Length("DescribeFileSystems.FileSystems["+ i +"].MountTargets.Length"); j++) {
					DescribeFileSystemsResponse.DescribeFileSystems_FileSystem.DescribeFileSystems_MountTarget mountTarget = new DescribeFileSystemsResponse.DescribeFileSystems_FileSystem.DescribeFileSystems_MountTarget();
					mountTarget.MountTargetDomain = _ctx.StringValue("DescribeFileSystems.FileSystems["+ i +"].MountTargets["+ j +"].MountTargetDomain");
					mountTarget.NetworkType = _ctx.StringValue("DescribeFileSystems.FileSystems["+ i +"].MountTargets["+ j +"].NetworkType");
					mountTarget.VpcId = _ctx.StringValue("DescribeFileSystems.FileSystems["+ i +"].MountTargets["+ j +"].VpcId");
					mountTarget.VswId = _ctx.StringValue("DescribeFileSystems.FileSystems["+ i +"].MountTargets["+ j +"].VswId");
					mountTarget.AccessGroupName = _ctx.StringValue("DescribeFileSystems.FileSystems["+ i +"].MountTargets["+ j +"].AccessGroupName");
					mountTarget.Status = _ctx.StringValue("DescribeFileSystems.FileSystems["+ i +"].MountTargets["+ j +"].Status");
					mountTarget.DualStackMountTargetDomain = _ctx.StringValue("DescribeFileSystems.FileSystems["+ i +"].MountTargets["+ j +"].DualStackMountTargetDomain");

					List<DescribeFileSystemsResponse.DescribeFileSystems_FileSystem.DescribeFileSystems_MountTarget.DescribeFileSystems_ClientMasterNode> mountTarget_clientMasterNodes = new List<DescribeFileSystemsResponse.DescribeFileSystems_FileSystem.DescribeFileSystems_MountTarget.DescribeFileSystems_ClientMasterNode>();
					for (int k = 0; k < _ctx.Length("DescribeFileSystems.FileSystems["+ i +"].MountTargets["+ j +"].ClientMasterNodes.Length"); k++) {
						DescribeFileSystemsResponse.DescribeFileSystems_FileSystem.DescribeFileSystems_MountTarget.DescribeFileSystems_ClientMasterNode clientMasterNode = new DescribeFileSystemsResponse.DescribeFileSystems_FileSystem.DescribeFileSystems_MountTarget.DescribeFileSystems_ClientMasterNode();
						clientMasterNode.EcsId = _ctx.StringValue("DescribeFileSystems.FileSystems["+ i +"].MountTargets["+ j +"].ClientMasterNodes["+ k +"].EcsId");
						clientMasterNode.EcsIp = _ctx.StringValue("DescribeFileSystems.FileSystems["+ i +"].MountTargets["+ j +"].ClientMasterNodes["+ k +"].EcsIp");
						clientMasterNode.DefaultPasswd = _ctx.StringValue("DescribeFileSystems.FileSystems["+ i +"].MountTargets["+ j +"].ClientMasterNodes["+ k +"].DefaultPasswd");

						mountTarget_clientMasterNodes.Add(clientMasterNode);
					}
					mountTarget.ClientMasterNodes = mountTarget_clientMasterNodes;

					List<DescribeFileSystemsResponse.DescribeFileSystems_FileSystem.DescribeFileSystems_MountTarget.DescribeFileSystems_Tag> mountTarget_tags1 = new List<DescribeFileSystemsResponse.DescribeFileSystems_FileSystem.DescribeFileSystems_MountTarget.DescribeFileSystems_Tag>();
					for (int k = 0; k < _ctx.Length("DescribeFileSystems.FileSystems["+ i +"].MountTargets["+ j +"].Tags.Length"); k++) {
						DescribeFileSystemsResponse.DescribeFileSystems_FileSystem.DescribeFileSystems_MountTarget.DescribeFileSystems_Tag tag = new DescribeFileSystemsResponse.DescribeFileSystems_FileSystem.DescribeFileSystems_MountTarget.DescribeFileSystems_Tag();
						tag.Key = _ctx.StringValue("DescribeFileSystems.FileSystems["+ i +"].MountTargets["+ j +"].Tags["+ k +"].Key");
						tag._Value = _ctx.StringValue("DescribeFileSystems.FileSystems["+ i +"].MountTargets["+ j +"].Tags["+ k +"].Value");

						mountTarget_tags1.Add(tag);
					}
					mountTarget.Tags1 = mountTarget_tags1;

					fileSystem_mountTargets.Add(mountTarget);
				}
				fileSystem.MountTargets = fileSystem_mountTargets;

				List<DescribeFileSystemsResponse.DescribeFileSystems_FileSystem.DescribeFileSystems_Package> fileSystem_packages = new List<DescribeFileSystemsResponse.DescribeFileSystems_FileSystem.DescribeFileSystems_Package>();
				for (int j = 0; j < _ctx.Length("DescribeFileSystems.FileSystems["+ i +"].Packages.Length"); j++) {
					DescribeFileSystemsResponse.DescribeFileSystems_FileSystem.DescribeFileSystems_Package package = new DescribeFileSystemsResponse.DescribeFileSystems_FileSystem.DescribeFileSystems_Package();
					package.PackageId = _ctx.StringValue("DescribeFileSystems.FileSystems["+ i +"].Packages["+ j +"].PackageId");
					package.PackageType = _ctx.StringValue("DescribeFileSystems.FileSystems["+ i +"].Packages["+ j +"].PackageType");
					package.Size = _ctx.LongValue("DescribeFileSystems.FileSystems["+ i +"].Packages["+ j +"].Size");
					package.StartTime = _ctx.StringValue("DescribeFileSystems.FileSystems["+ i +"].Packages["+ j +"].StartTime");
					package.ExpiredTime = _ctx.StringValue("DescribeFileSystems.FileSystems["+ i +"].Packages["+ j +"].ExpiredTime");

					fileSystem_packages.Add(package);
				}
				fileSystem.Packages = fileSystem_packages;

				List<DescribeFileSystemsResponse.DescribeFileSystems_FileSystem.DescribeFileSystems_Tag2> fileSystem_tags = new List<DescribeFileSystemsResponse.DescribeFileSystems_FileSystem.DescribeFileSystems_Tag2>();
				for (int j = 0; j < _ctx.Length("DescribeFileSystems.FileSystems["+ i +"].Tags.Length"); j++) {
					DescribeFileSystemsResponse.DescribeFileSystems_FileSystem.DescribeFileSystems_Tag2 tag2 = new DescribeFileSystemsResponse.DescribeFileSystems_FileSystem.DescribeFileSystems_Tag2();
					tag2.Key = _ctx.StringValue("DescribeFileSystems.FileSystems["+ i +"].Tags["+ j +"].Key");
					tag2._Value = _ctx.StringValue("DescribeFileSystems.FileSystems["+ i +"].Tags["+ j +"].Value");

					fileSystem_tags.Add(tag2);
				}
				fileSystem.Tags = fileSystem_tags;

				describeFileSystemsResponse_fileSystems.Add(fileSystem);
			}
			describeFileSystemsResponse.FileSystems = describeFileSystemsResponse_fileSystems;
        
			return describeFileSystemsResponse;
        }
    }
}
