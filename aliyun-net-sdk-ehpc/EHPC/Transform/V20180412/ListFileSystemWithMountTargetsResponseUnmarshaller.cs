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
using Aliyun.Acs.EHPC.Model.V20180412;

namespace Aliyun.Acs.EHPC.Transform.V20180412
{
    public class ListFileSystemWithMountTargetsResponseUnmarshaller
    {
        public static ListFileSystemWithMountTargetsResponse Unmarshall(UnmarshallerContext context)
        {
			ListFileSystemWithMountTargetsResponse listFileSystemWithMountTargetsResponse = new ListFileSystemWithMountTargetsResponse();

			listFileSystemWithMountTargetsResponse.HttpResponse = context.HttpResponse;
			listFileSystemWithMountTargetsResponse.RequestId = context.StringValue("ListFileSystemWithMountTargets.RequestId");
			listFileSystemWithMountTargetsResponse.TotalCount = context.IntegerValue("ListFileSystemWithMountTargets.TotalCount");
			listFileSystemWithMountTargetsResponse.PageNumber = context.IntegerValue("ListFileSystemWithMountTargets.PageNumber");
			listFileSystemWithMountTargetsResponse.PageSize = context.IntegerValue("ListFileSystemWithMountTargets.PageSize");

			List<ListFileSystemWithMountTargetsResponse.ListFileSystemWithMountTargets_FileSystems> listFileSystemWithMountTargetsResponse_fileSystemList = new List<ListFileSystemWithMountTargetsResponse.ListFileSystemWithMountTargets_FileSystems>();
			for (int i = 0; i < context.Length("ListFileSystemWithMountTargets.FileSystemList.Length"); i++) {
				ListFileSystemWithMountTargetsResponse.ListFileSystemWithMountTargets_FileSystems fileSystems = new ListFileSystemWithMountTargetsResponse.ListFileSystemWithMountTargets_FileSystems();
				fileSystems.RegionId = context.StringValue("ListFileSystemWithMountTargets.FileSystemList["+ i +"].RegionId");
				fileSystems.FileSystemId = context.StringValue("ListFileSystemWithMountTargets.FileSystemList["+ i +"].FileSystemId");
				fileSystems.ProtocolType = context.StringValue("ListFileSystemWithMountTargets.FileSystemList["+ i +"].ProtocolType");
				fileSystems.CreateTime = context.StringValue("ListFileSystemWithMountTargets.FileSystemList["+ i +"].CreateTime");
				fileSystems.Destription = context.StringValue("ListFileSystemWithMountTargets.FileSystemList["+ i +"].Destription");
				fileSystems.StorageType = context.StringValue("ListFileSystemWithMountTargets.FileSystemList["+ i +"].StorageType");
				fileSystems.MeteredSize = context.StringValue("ListFileSystemWithMountTargets.FileSystemList["+ i +"].MeteredSize");

				List<ListFileSystemWithMountTargetsResponse.ListFileSystemWithMountTargets_FileSystems.ListFileSystemWithMountTargets_Packages> fileSystems_packageList = new List<ListFileSystemWithMountTargetsResponse.ListFileSystemWithMountTargets_FileSystems.ListFileSystemWithMountTargets_Packages>();
				for (int j = 0; j < context.Length("ListFileSystemWithMountTargets.FileSystemList["+ i +"].PackageList.Length"); j++) {
					ListFileSystemWithMountTargetsResponse.ListFileSystemWithMountTargets_FileSystems.ListFileSystemWithMountTargets_Packages packages = new ListFileSystemWithMountTargetsResponse.ListFileSystemWithMountTargets_FileSystems.ListFileSystemWithMountTargets_Packages();
					packages.PackageId = context.StringValue("ListFileSystemWithMountTargets.FileSystemList["+ i +"].PackageList["+ j +"].PackageId");

					fileSystems_packageList.Add(packages);
				}
				fileSystems.PackageList = fileSystems_packageList;

				List<ListFileSystemWithMountTargetsResponse.ListFileSystemWithMountTargets_FileSystems.ListFileSystemWithMountTargets_MountTargets> fileSystems_mountTargetList = new List<ListFileSystemWithMountTargetsResponse.ListFileSystemWithMountTargets_FileSystems.ListFileSystemWithMountTargets_MountTargets>();
				for (int j = 0; j < context.Length("ListFileSystemWithMountTargets.FileSystemList["+ i +"].MountTargetList.Length"); j++) {
					ListFileSystemWithMountTargetsResponse.ListFileSystemWithMountTargets_FileSystems.ListFileSystemWithMountTargets_MountTargets mountTargets = new ListFileSystemWithMountTargetsResponse.ListFileSystemWithMountTargets_FileSystems.ListFileSystemWithMountTargets_MountTargets();
					mountTargets.MountTargetDomain = context.StringValue("ListFileSystemWithMountTargets.FileSystemList["+ i +"].MountTargetList["+ j +"].MountTargetDomain");
					mountTargets.Status = context.StringValue("ListFileSystemWithMountTargets.FileSystemList["+ i +"].MountTargetList["+ j +"].Status");
					mountTargets.NetworkType = context.StringValue("ListFileSystemWithMountTargets.FileSystemList["+ i +"].MountTargetList["+ j +"].NetworkType");
					mountTargets.VswId = context.StringValue("ListFileSystemWithMountTargets.FileSystemList["+ i +"].MountTargetList["+ j +"].VswId");
					mountTargets.VpcId = context.StringValue("ListFileSystemWithMountTargets.FileSystemList["+ i +"].MountTargetList["+ j +"].VpcId");
					mountTargets.AccessGroup = context.StringValue("ListFileSystemWithMountTargets.FileSystemList["+ i +"].MountTargetList["+ j +"].AccessGroup");

					fileSystems_mountTargetList.Add(mountTargets);
				}
				fileSystems.MountTargetList = fileSystems_mountTargetList;

				listFileSystemWithMountTargetsResponse_fileSystemList.Add(fileSystems);
			}
			listFileSystemWithMountTargetsResponse.FileSystemList = listFileSystemWithMountTargetsResponse_fileSystemList;
        
			return listFileSystemWithMountTargetsResponse;
        }
    }
}
