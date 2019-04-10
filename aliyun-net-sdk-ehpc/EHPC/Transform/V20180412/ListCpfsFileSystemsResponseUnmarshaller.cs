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
    public class ListCpfsFileSystemsResponseUnmarshaller
    {
        public static ListCpfsFileSystemsResponse Unmarshall(UnmarshallerContext context)
        {
			ListCpfsFileSystemsResponse listCpfsFileSystemsResponse = new ListCpfsFileSystemsResponse();

			listCpfsFileSystemsResponse.HttpResponse = context.HttpResponse;
			listCpfsFileSystemsResponse.RequestId = context.StringValue("ListCpfsFileSystems.RequestId");
			listCpfsFileSystemsResponse.TotalCount = context.IntegerValue("ListCpfsFileSystems.TotalCount");
			listCpfsFileSystemsResponse.PageNumber = context.IntegerValue("ListCpfsFileSystems.PageNumber");
			listCpfsFileSystemsResponse.PageSize = context.IntegerValue("ListCpfsFileSystems.PageSize");

			List<ListCpfsFileSystemsResponse.ListCpfsFileSystems_FileSystems> listCpfsFileSystemsResponse_fileSystemList = new List<ListCpfsFileSystemsResponse.ListCpfsFileSystems_FileSystems>();
			for (int i = 0; i < context.Length("ListCpfsFileSystems.FileSystemList.Length"); i++) {
				ListCpfsFileSystemsResponse.ListCpfsFileSystems_FileSystems fileSystems = new ListCpfsFileSystemsResponse.ListCpfsFileSystems_FileSystems();
				fileSystems.RegionId = context.StringValue("ListCpfsFileSystems.FileSystemList["+ i +"].RegionId");
				fileSystems.ZoneId = context.StringValue("ListCpfsFileSystems.FileSystemList["+ i +"].ZoneId");
				fileSystems.FileSystemId = context.StringValue("ListCpfsFileSystems.FileSystemList["+ i +"].FileSystemId");
				fileSystems.CreateTime = context.StringValue("ListCpfsFileSystems.FileSystemList["+ i +"].CreateTime");
				fileSystems.Destription = context.StringValue("ListCpfsFileSystems.FileSystemList["+ i +"].Destription");
				fileSystems.ProtocolType = context.StringValue("ListCpfsFileSystems.FileSystemList["+ i +"].ProtocolType");
				fileSystems.Capacity = context.StringValue("ListCpfsFileSystems.FileSystemList["+ i +"].Capacity");

				List<ListCpfsFileSystemsResponse.ListCpfsFileSystems_FileSystems.ListCpfsFileSystems_MountTargets> fileSystems_mountTargetList = new List<ListCpfsFileSystemsResponse.ListCpfsFileSystems_FileSystems.ListCpfsFileSystems_MountTargets>();
				for (int j = 0; j < context.Length("ListCpfsFileSystems.FileSystemList["+ i +"].MountTargetList.Length"); j++) {
					ListCpfsFileSystemsResponse.ListCpfsFileSystems_FileSystems.ListCpfsFileSystems_MountTargets mountTargets = new ListCpfsFileSystemsResponse.ListCpfsFileSystems_FileSystems.ListCpfsFileSystems_MountTargets();
					mountTargets.MountTargetDomain = context.StringValue("ListCpfsFileSystems.FileSystemList["+ i +"].MountTargetList["+ j +"].MountTargetDomain");
					mountTargets.Status = context.StringValue("ListCpfsFileSystems.FileSystemList["+ i +"].MountTargetList["+ j +"].Status");
					mountTargets.NetworkType = context.StringValue("ListCpfsFileSystems.FileSystemList["+ i +"].MountTargetList["+ j +"].NetworkType");
					mountTargets.VswId = context.StringValue("ListCpfsFileSystems.FileSystemList["+ i +"].MountTargetList["+ j +"].VswId");
					mountTargets.VpcId = context.StringValue("ListCpfsFileSystems.FileSystemList["+ i +"].MountTargetList["+ j +"].VpcId");

					fileSystems_mountTargetList.Add(mountTargets);
				}
				fileSystems.MountTargetList = fileSystems_mountTargetList;

				listCpfsFileSystemsResponse_fileSystemList.Add(fileSystems);
			}
			listCpfsFileSystemsResponse.FileSystemList = listCpfsFileSystemsResponse_fileSystemList;
        
			return listCpfsFileSystemsResponse;
        }
    }
}
