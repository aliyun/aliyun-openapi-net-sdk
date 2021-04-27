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
    public class DescribeBackupDirsResponseUnmarshaller
    {
        public static DescribeBackupDirsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeBackupDirsResponse describeBackupDirsResponse = new DescribeBackupDirsResponse();

			describeBackupDirsResponse.HttpResponse = _ctx.HttpResponse;
			describeBackupDirsResponse.RequestId = _ctx.StringValue("DescribeBackupDirs.RequestId");

			DescribeBackupDirsResponse.DescribeBackupDirs_PageInfo pageInfo = new DescribeBackupDirsResponse.DescribeBackupDirs_PageInfo();
			pageInfo.Count = _ctx.IntegerValue("DescribeBackupDirs.PageInfo.Count");
			pageInfo.PageSize = _ctx.IntegerValue("DescribeBackupDirs.PageInfo.PageSize");
			pageInfo.TotalCount = _ctx.IntegerValue("DescribeBackupDirs.PageInfo.TotalCount");
			pageInfo.CurrentPage = _ctx.IntegerValue("DescribeBackupDirs.PageInfo.CurrentPage");
			describeBackupDirsResponse.PageInfo = pageInfo;

			List<DescribeBackupDirsResponse.DescribeBackupDirs_SimpleBackupJob> describeBackupDirsResponse_backupDirs = new List<DescribeBackupDirsResponse.DescribeBackupDirs_SimpleBackupJob>();
			for (int i = 0; i < _ctx.Length("DescribeBackupDirs.BackupDirs.Length"); i++) {
				DescribeBackupDirsResponse.DescribeBackupDirs_SimpleBackupJob simpleBackupJob = new DescribeBackupDirsResponse.DescribeBackupDirs_SimpleBackupJob();
				simpleBackupJob.BackupJobId = _ctx.LongValue("DescribeBackupDirs.BackupDirs["+ i +"].BackupJobId");
				simpleBackupJob.Source = _ctx.StringValue("DescribeBackupDirs.BackupDirs["+ i +"].Source");

				describeBackupDirsResponse_backupDirs.Add(simpleBackupJob);
			}
			describeBackupDirsResponse.BackupDirs = describeBackupDirsResponse_backupDirs;
        
			return describeBackupDirsResponse;
        }
    }
}
