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
using Aliyun.Acs.Sas.Model.V20181203;

namespace Aliyun.Acs.Sas.Transform.V20181203
{
    public class DescribeBackupFilesResponseUnmarshaller
    {
        public static DescribeBackupFilesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeBackupFilesResponse describeBackupFilesResponse = new DescribeBackupFilesResponse();

			describeBackupFilesResponse.HttpResponse = _ctx.HttpResponse;
			describeBackupFilesResponse.RequestId = _ctx.StringValue("DescribeBackupFiles.RequestId");

			DescribeBackupFilesResponse.DescribeBackupFiles_PageInfo pageInfo = new DescribeBackupFilesResponse.DescribeBackupFiles_PageInfo();
			pageInfo.Count = _ctx.IntegerValue("DescribeBackupFiles.PageInfo.Count");
			pageInfo.PageSize = _ctx.IntegerValue("DescribeBackupFiles.PageInfo.PageSize");
			pageInfo.TotalCount = _ctx.IntegerValue("DescribeBackupFiles.PageInfo.TotalCount");
			pageInfo.CurrentPage = _ctx.IntegerValue("DescribeBackupFiles.PageInfo.CurrentPage");
			describeBackupFilesResponse.PageInfo = pageInfo;

			List<DescribeBackupFilesResponse.DescribeBackupFiles_BrowseFile> describeBackupFilesResponse_backupFiles = new List<DescribeBackupFilesResponse.DescribeBackupFiles_BrowseFile>();
			for (int i = 0; i < _ctx.Length("DescribeBackupFiles.BackupFiles.Length"); i++) {
				DescribeBackupFilesResponse.DescribeBackupFiles_BrowseFile browseFile = new DescribeBackupFilesResponse.DescribeBackupFiles_BrowseFile();
				browseFile.Name = _ctx.StringValue("DescribeBackupFiles.BackupFiles["+ i +"].Name");
				browseFile.Type = _ctx.StringValue("DescribeBackupFiles.BackupFiles["+ i +"].Type");
				browseFile.Subtree = _ctx.StringValue("DescribeBackupFiles.BackupFiles["+ i +"].Subtree");
				browseFile.Size = _ctx.LongValue("DescribeBackupFiles.BackupFiles["+ i +"].Size");

				describeBackupFilesResponse_backupFiles.Add(browseFile);
			}
			describeBackupFilesResponse.BackupFiles = describeBackupFilesResponse_backupFiles;
        
			return describeBackupFilesResponse;
        }
    }
}
