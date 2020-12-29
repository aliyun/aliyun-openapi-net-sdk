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
        public static ListFileSystemWithMountTargetsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListFileSystemWithMountTargetsResponse listFileSystemWithMountTargetsResponse = new ListFileSystemWithMountTargetsResponse();

			listFileSystemWithMountTargetsResponse.HttpResponse = _ctx.HttpResponse;
			listFileSystemWithMountTargetsResponse.RequestId = _ctx.StringValue("ListFileSystemWithMountTargets.RequestId");
			listFileSystemWithMountTargetsResponse.TotalCount = _ctx.IntegerValue("ListFileSystemWithMountTargets.TotalCount");
			listFileSystemWithMountTargetsResponse.PageNumber = _ctx.IntegerValue("ListFileSystemWithMountTargets.PageNumber");
			listFileSystemWithMountTargetsResponse.PageSize = _ctx.IntegerValue("ListFileSystemWithMountTargets.PageSize");

			List<ListFileSystemWithMountTargetsResponse.ListFileSystemWithMountTargets_FileSystems> listFileSystemWithMountTargetsResponse_fileSystemList = new List<ListFileSystemWithMountTargetsResponse.ListFileSystemWithMountTargets_FileSystems>();
			for (int i = 0; i < _ctx.Length("ListFileSystemWithMountTargets.FileSystemList.Length"); i++) {
				ListFileSystemWithMountTargetsResponse.ListFileSystemWithMountTargets_FileSystems fileSystems = new ListFileSystemWithMountTargetsResponse.ListFileSystemWithMountTargets_FileSystems();
				fileSystems.RegionId = _ctx.StringValue("ListFileSystemWithMountTargets.FileSystemList["+ i +"].RegionId");
				fileSystems.FileSystemId = _ctx.StringValue("ListFileSystemWithMountTargets.FileSystemList["+ i +"].FileSystemId");
				fileSystems.FileSystemType = _ctx.StringValue("ListFileSystemWithMountTargets.FileSystemList["+ i +"].FileSystemType");
				fileSystems.ProtocolType = _ctx.StringValue("ListFileSystemWithMountTargets.FileSystemList["+ i +"].ProtocolType");
				fileSystems.CreateTime = _ctx.StringValue("ListFileSystemWithMountTargets.FileSystemList["+ i +"].CreateTime");
				fileSystems.Destription = _ctx.StringValue("ListFileSystemWithMountTargets.FileSystemList["+ i +"].Destription");
				fileSystems.StorageType = _ctx.StringValue("ListFileSystemWithMountTargets.FileSystemList["+ i +"].StorageType");
				fileSystems.MeteredSize = _ctx.IntegerValue("ListFileSystemWithMountTargets.FileSystemList["+ i +"].MeteredSize");
				fileSystems.Capacity = _ctx.IntegerValue("ListFileSystemWithMountTargets.FileSystemList["+ i +"].Capacity");
				fileSystems.EncryptType = _ctx.IntegerValue("ListFileSystemWithMountTargets.FileSystemList["+ i +"].EncryptType");
				fileSystems.BandWidth = _ctx.IntegerValue("ListFileSystemWithMountTargets.FileSystemList["+ i +"].BandWidth");
				fileSystems.Status = _ctx.StringValue("ListFileSystemWithMountTargets.FileSystemList["+ i +"].Status");

				List<ListFileSystemWithMountTargetsResponse.ListFileSystemWithMountTargets_FileSystems.ListFileSystemWithMountTargets_Packages> fileSystems_packageList = new List<ListFileSystemWithMountTargetsResponse.ListFileSystemWithMountTargets_FileSystems.ListFileSystemWithMountTargets_Packages>();
				for (int j = 0; j < _ctx.Length("ListFileSystemWithMountTargets.FileSystemList["+ i +"].PackageList.Length"); j++) {
					ListFileSystemWithMountTargetsResponse.ListFileSystemWithMountTargets_FileSystems.ListFileSystemWithMountTargets_Packages packages = new ListFileSystemWithMountTargetsResponse.ListFileSystemWithMountTargets_FileSystems.ListFileSystemWithMountTargets_Packages();
					packages.PackageId = _ctx.StringValue("ListFileSystemWithMountTargets.FileSystemList["+ i +"].PackageList["+ j +"].PackageId");

					fileSystems_packageList.Add(packages);
				}
				fileSystems.PackageList = fileSystems_packageList;

				List<ListFileSystemWithMountTargetsResponse.ListFileSystemWithMountTargets_FileSystems.ListFileSystemWithMountTargets_MountTargets> fileSystems_mountTargetList = new List<ListFileSystemWithMountTargetsResponse.ListFileSystemWithMountTargets_FileSystems.ListFileSystemWithMountTargets_MountTargets>();
				for (int j = 0; j < _ctx.Length("ListFileSystemWithMountTargets.FileSystemList["+ i +"].MountTargetList.Length"); j++) {
					ListFileSystemWithMountTargetsResponse.ListFileSystemWithMountTargets_FileSystems.ListFileSystemWithMountTargets_MountTargets mountTargets = new ListFileSystemWithMountTargetsResponse.ListFileSystemWithMountTargets_FileSystems.ListFileSystemWithMountTargets_MountTargets();
					mountTargets.MountTargetDomain = _ctx.StringValue("ListFileSystemWithMountTargets.FileSystemList["+ i +"].MountTargetList["+ j +"].MountTargetDomain");
					mountTargets.Status = _ctx.StringValue("ListFileSystemWithMountTargets.FileSystemList["+ i +"].MountTargetList["+ j +"].Status");
					mountTargets.NetworkType = _ctx.StringValue("ListFileSystemWithMountTargets.FileSystemList["+ i +"].MountTargetList["+ j +"].NetworkType");
					mountTargets.VswId = _ctx.StringValue("ListFileSystemWithMountTargets.FileSystemList["+ i +"].MountTargetList["+ j +"].VswId");
					mountTargets.VpcId = _ctx.StringValue("ListFileSystemWithMountTargets.FileSystemList["+ i +"].MountTargetList["+ j +"].VpcId");
					mountTargets.AccessGroup = _ctx.StringValue("ListFileSystemWithMountTargets.FileSystemList["+ i +"].MountTargetList["+ j +"].AccessGroup");

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
