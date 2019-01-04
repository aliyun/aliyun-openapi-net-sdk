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
    public class CPFSCreateFileSystemResponseUnmarshaller
    {
        public static CPFSCreateFileSystemResponse Unmarshall(UnmarshallerContext context)
        {
			CPFSCreateFileSystemResponse cPFSCreateFileSystemResponse = new CPFSCreateFileSystemResponse();

			cPFSCreateFileSystemResponse.HttpResponse = context.HttpResponse;
			cPFSCreateFileSystemResponse.RequestId = context.StringValue("CPFSCreateFileSystem.RequestId");

			CPFSCreateFileSystemResponse.CPFSCreateFileSystem_FileSystem fileSystem = new CPFSCreateFileSystemResponse.CPFSCreateFileSystem_FileSystem();
			fileSystem.FsId = context.StringValue("CPFSCreateFileSystem.FileSystem.FsId");
			fileSystem.FsDesc = context.StringValue("CPFSCreateFileSystem.FileSystem.FsDesc");
			fileSystem.FsSpec = context.StringValue("CPFSCreateFileSystem.FileSystem.FsSpec");
			fileSystem.Bandwidth = context.LongValue("CPFSCreateFileSystem.FileSystem.Bandwidth");
			fileSystem.Capacity = context.LongValue("CPFSCreateFileSystem.FileSystem.Capacity");
			fileSystem.MeteredSize = context.LongValue("CPFSCreateFileSystem.FileSystem.MeteredSize");
			fileSystem.CreateTime = context.StringValue("CPFSCreateFileSystem.FileSystem.CreateTime");
			fileSystem.NetworkType = context.StringValue("CPFSCreateFileSystem.FileSystem.NetworkType");
			fileSystem.MountTargets = context.StringValue("CPFSCreateFileSystem.FileSystem.MountTargets");
			fileSystem.RegionId = context.StringValue("CPFSCreateFileSystem.FileSystem.RegionId");
			fileSystem.ZoneId = context.StringValue("CPFSCreateFileSystem.FileSystem.ZoneId");
			fileSystem.VpcId = context.StringValue("CPFSCreateFileSystem.FileSystem.VpcId");
			fileSystem.VSwitchId = context.StringValue("CPFSCreateFileSystem.FileSystem.VSwitchId");
			cPFSCreateFileSystemResponse.FileSystem = fileSystem;
        
			return cPFSCreateFileSystemResponse;
        }
    }
}