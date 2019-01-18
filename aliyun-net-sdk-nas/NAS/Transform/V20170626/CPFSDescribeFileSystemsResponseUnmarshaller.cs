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
    public class CPFSDescribeFileSystemsResponseUnmarshaller
    {
        public static CPFSDescribeFileSystemsResponse Unmarshall(UnmarshallerContext context)
        {
			CPFSDescribeFileSystemsResponse cPFSDescribeFileSystemsResponse = new CPFSDescribeFileSystemsResponse();

			cPFSDescribeFileSystemsResponse.HttpResponse = context.HttpResponse;
			cPFSDescribeFileSystemsResponse.RequestId = context.StringValue("CPFSDescribeFileSystems.RequestId");
			cPFSDescribeFileSystemsResponse.TotalCount = context.IntegerValue("CPFSDescribeFileSystems.TotalCount");
			cPFSDescribeFileSystemsResponse.PageSize = context.IntegerValue("CPFSDescribeFileSystems.PageSize");
			cPFSDescribeFileSystemsResponse.PageNumber = context.IntegerValue("CPFSDescribeFileSystems.PageNumber");

			List<CPFSDescribeFileSystemsResponse.CPFSDescribeFileSystems_FileSystem> cPFSDescribeFileSystemsResponse_fileSystems = new List<CPFSDescribeFileSystemsResponse.CPFSDescribeFileSystems_FileSystem>();
			for (int i = 0; i < context.Length("CPFSDescribeFileSystems.FileSystems.Length"); i++) {
				CPFSDescribeFileSystemsResponse.CPFSDescribeFileSystems_FileSystem fileSystem = new CPFSDescribeFileSystemsResponse.CPFSDescribeFileSystems_FileSystem();
				fileSystem.FsId = context.StringValue("CPFSDescribeFileSystems.FileSystems["+ i +"].FsId");
				fileSystem.FsDesc = context.StringValue("CPFSDescribeFileSystems.FileSystems["+ i +"].FsDesc");
				fileSystem.FsSpec = context.StringValue("CPFSDescribeFileSystems.FileSystems["+ i +"].FsSpec");
				fileSystem.Bandwidth = context.LongValue("CPFSDescribeFileSystems.FileSystems["+ i +"].Bandwidth");
				fileSystem.Capacity = context.LongValue("CPFSDescribeFileSystems.FileSystems["+ i +"].Capacity");
				fileSystem.MeteredSize = context.LongValue("CPFSDescribeFileSystems.FileSystems["+ i +"].MeteredSize");
				fileSystem.CreateTime = context.StringValue("CPFSDescribeFileSystems.FileSystems["+ i +"].CreateTime");
				fileSystem.NetworkType = context.StringValue("CPFSDescribeFileSystems.FileSystems["+ i +"].NetworkType");
				fileSystem.MountTargets = context.StringValue("CPFSDescribeFileSystems.FileSystems["+ i +"].MountTargets");
				fileSystem.RegionId = context.StringValue("CPFSDescribeFileSystems.FileSystems["+ i +"].RegionId");
				fileSystem.ZoneId = context.StringValue("CPFSDescribeFileSystems.FileSystems["+ i +"].ZoneId");
				fileSystem.VpcId = context.StringValue("CPFSDescribeFileSystems.FileSystems["+ i +"].VpcId");
				fileSystem.VSwitchId = context.StringValue("CPFSDescribeFileSystems.FileSystems["+ i +"].VSwitchId");
				fileSystem.Status = context.StringValue("CPFSDescribeFileSystems.FileSystems["+ i +"].Status");

				cPFSDescribeFileSystemsResponse_fileSystems.Add(fileSystem);
			}
			cPFSDescribeFileSystemsResponse.FileSystems = cPFSDescribeFileSystemsResponse_fileSystems;
        
			return cPFSDescribeFileSystemsResponse;
        }
    }
}