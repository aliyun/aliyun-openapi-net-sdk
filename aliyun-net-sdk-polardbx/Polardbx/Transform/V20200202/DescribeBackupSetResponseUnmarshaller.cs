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
using Aliyun.Acs.polardbx.Model.V20200202;

namespace Aliyun.Acs.polardbx.Transform.V20200202
{
    public class DescribeBackupSetResponseUnmarshaller
    {
        public static DescribeBackupSetResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeBackupSetResponse describeBackupSetResponse = new DescribeBackupSetResponse();

			describeBackupSetResponse.HttpResponse = _ctx.HttpResponse;
			describeBackupSetResponse.Message = _ctx.StringValue("DescribeBackupSet.Message");
			describeBackupSetResponse.RequestId = _ctx.StringValue("DescribeBackupSet.RequestId");
			describeBackupSetResponse.Success = _ctx.BooleanValue("DescribeBackupSet.Success");

			List<DescribeBackupSetResponse.DescribeBackupSet_BackupSet> describeBackupSetResponse_data = new List<DescribeBackupSetResponse.DescribeBackupSet_BackupSet>();
			for (int i = 0; i < _ctx.Length("DescribeBackupSet.Data.Length"); i++) {
				DescribeBackupSetResponse.DescribeBackupSet_BackupSet backupSet = new DescribeBackupSetResponse.DescribeBackupSet_BackupSet();
				backupSet.EndTime = _ctx.LongValue("DescribeBackupSet.Data["+ i +"].EndTime");
				backupSet.Status = _ctx.IntegerValue("DescribeBackupSet.Data["+ i +"].Status");
				backupSet.BackupSetSize = _ctx.LongValue("DescribeBackupSet.Data["+ i +"].BackupSetSize");
				backupSet.BackupSetId = _ctx.LongValue("DescribeBackupSet.Data["+ i +"].BackupSetId");
				backupSet.BackupType = _ctx.IntegerValue("DescribeBackupSet.Data["+ i +"].BackupType");
				backupSet.BeginTime = _ctx.LongValue("DescribeBackupSet.Data["+ i +"].BeginTime");
				backupSet.BackupModel = _ctx.IntegerValue("DescribeBackupSet.Data["+ i +"].BackupModel");

				List<DescribeBackupSetResponse.DescribeBackupSet_BackupSet.DescribeBackupSet_OSS> backupSet_oSSList = new List<DescribeBackupSetResponse.DescribeBackupSet_BackupSet.DescribeBackupSet_OSS>();
				for (int j = 0; j < _ctx.Length("DescribeBackupSet.Data["+ i +"].OSSList.Length"); j++) {
					DescribeBackupSetResponse.DescribeBackupSet_BackupSet.DescribeBackupSet_OSS oSS = new DescribeBackupSetResponse.DescribeBackupSet_BackupSet.DescribeBackupSet_OSS();
					oSS.BackupSetFile = _ctx.StringValue("DescribeBackupSet.Data["+ i +"].OSSList["+ j +"].BackupSetFile");
					oSS.LinkExpiredTime = _ctx.StringValue("DescribeBackupSet.Data["+ i +"].OSSList["+ j +"].LinkExpiredTime");
					oSS.IntranetDownloadLink = _ctx.StringValue("DescribeBackupSet.Data["+ i +"].OSSList["+ j +"].IntranetDownloadLink");
					oSS.DownloadLink = _ctx.StringValue("DescribeBackupSet.Data["+ i +"].OSSList["+ j +"].DownloadLink");

					backupSet_oSSList.Add(oSS);
				}
				backupSet.OSSList = backupSet_oSSList;

				describeBackupSetResponse_data.Add(backupSet);
			}
			describeBackupSetResponse.Data = describeBackupSetResponse_data;
        
			return describeBackupSetResponse;
        }
    }
}
