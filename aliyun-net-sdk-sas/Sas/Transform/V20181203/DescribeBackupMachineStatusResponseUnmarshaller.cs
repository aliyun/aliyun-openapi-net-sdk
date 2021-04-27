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
    public class DescribeBackupMachineStatusResponseUnmarshaller
    {
        public static DescribeBackupMachineStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeBackupMachineStatusResponse describeBackupMachineStatusResponse = new DescribeBackupMachineStatusResponse();

			describeBackupMachineStatusResponse.HttpResponse = _ctx.HttpResponse;
			describeBackupMachineStatusResponse.RequestId = _ctx.StringValue("DescribeBackupMachineStatus.RequestId");

			DescribeBackupMachineStatusResponse.DescribeBackupMachineStatus_BackupMachineStatus backupMachineStatus = new DescribeBackupMachineStatusResponse.DescribeBackupMachineStatus_BackupMachineStatus();
			backupMachineStatus.Uuid = _ctx.StringValue("DescribeBackupMachineStatus.BackupMachineStatus.Uuid");
			backupMachineStatus.ClientStatus = _ctx.StringValue("DescribeBackupMachineStatus.BackupMachineStatus.ClientStatus");
			backupMachineStatus.SavedBackupCount = _ctx.IntegerValue("DescribeBackupMachineStatus.BackupMachineStatus.SavedBackupCount");
			backupMachineStatus.ErrorCode = _ctx.StringValue("DescribeBackupMachineStatus.BackupMachineStatus.ErrorCode");
			backupMachineStatus.ClientId = _ctx.StringValue("DescribeBackupMachineStatus.BackupMachineStatus.ClientId");
			backupMachineStatus.ClientVersion = _ctx.StringValue("DescribeBackupMachineStatus.BackupMachineStatus.ClientVersion");
			backupMachineStatus.VaultId = _ctx.StringValue("DescribeBackupMachineStatus.BackupMachineStatus.VaultId");
			backupMachineStatus.Status = _ctx.StringValue("DescribeBackupMachineStatus.BackupMachineStatus.Status");
			backupMachineStatus.RegionId = _ctx.StringValue("DescribeBackupMachineStatus.BackupMachineStatus.RegionId");
			backupMachineStatus.InstanceId = _ctx.StringValue("DescribeBackupMachineStatus.BackupMachineStatus.InstanceId");
			backupMachineStatus.RequestId = _ctx.StringValue("DescribeBackupMachineStatus.BackupMachineStatus.RequestId");
			backupMachineStatus.Jobs = _ctx.StringValue("DescribeBackupMachineStatus.BackupMachineStatus.Jobs");

			List<DescribeBackupMachineStatusResponse.DescribeBackupMachineStatus_BackupMachineStatus.DescribeBackupMachineStatus_BackupErrorMsg> backupMachineStatus_errorList = new List<DescribeBackupMachineStatusResponse.DescribeBackupMachineStatus_BackupMachineStatus.DescribeBackupMachineStatus_BackupErrorMsg>();
			for (int i = 0; i < _ctx.Length("DescribeBackupMachineStatus.BackupMachineStatus.ErrorList.Length"); i++) {
				DescribeBackupMachineStatusResponse.DescribeBackupMachineStatus_BackupMachineStatus.DescribeBackupMachineStatus_BackupErrorMsg backupErrorMsg = new DescribeBackupMachineStatusResponse.DescribeBackupMachineStatus_BackupMachineStatus.DescribeBackupMachineStatus_BackupErrorMsg();
				backupErrorMsg.Key = _ctx.StringValue("DescribeBackupMachineStatus.BackupMachineStatus.ErrorList["+ i +"].Key");
				backupErrorMsg.Path = _ctx.StringValue("DescribeBackupMachineStatus.BackupMachineStatus.ErrorList["+ i +"].Path");
				backupErrorMsg.ErrorStatus = _ctx.StringValue("DescribeBackupMachineStatus.BackupMachineStatus.ErrorList["+ i +"].ErrorStatus");
				backupErrorMsg.ErrorCode = _ctx.StringValue("DescribeBackupMachineStatus.BackupMachineStatus.ErrorList["+ i +"].ErrorCode");
				backupErrorMsg.ErrorType = _ctx.StringValue("DescribeBackupMachineStatus.BackupMachineStatus.ErrorList["+ i +"].ErrorType");
				backupErrorMsg.ErrorMsg = _ctx.StringValue("DescribeBackupMachineStatus.BackupMachineStatus.ErrorList["+ i +"].ErrorMsg");
				backupErrorMsg.ErrorTime = _ctx.LongValue("DescribeBackupMachineStatus.BackupMachineStatus.ErrorList["+ i +"].ErrorTime");
				backupErrorMsg.ErrorFile = _ctx.StringValue("DescribeBackupMachineStatus.BackupMachineStatus.ErrorList["+ i +"].ErrorFile");
				backupErrorMsg.ErrorFileUrl = _ctx.StringValue("DescribeBackupMachineStatus.BackupMachineStatus.ErrorList["+ i +"].ErrorFileUrl");
				backupErrorMsg.RequestId = _ctx.StringValue("DescribeBackupMachineStatus.BackupMachineStatus.ErrorList["+ i +"].RequestId");

				backupMachineStatus_errorList.Add(backupErrorMsg);
			}
			backupMachineStatus.ErrorList = backupMachineStatus_errorList;
			describeBackupMachineStatusResponse.BackupMachineStatus = backupMachineStatus;
        
			return describeBackupMachineStatusResponse;
        }
    }
}
