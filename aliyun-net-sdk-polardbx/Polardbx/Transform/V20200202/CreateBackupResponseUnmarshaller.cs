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
    public class CreateBackupResponseUnmarshaller
    {
        public static CreateBackupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateBackupResponse createBackupResponse = new CreateBackupResponse();

			createBackupResponse.HttpResponse = _ctx.HttpResponse;
			createBackupResponse.Message = _ctx.StringValue("CreateBackup.Message");
			createBackupResponse.RequestId = _ctx.StringValue("CreateBackup.RequestId");
			createBackupResponse.Success = _ctx.BooleanValue("CreateBackup.Success");

			List<CreateBackupResponse.CreateBackup_Account> createBackupResponse_data = new List<CreateBackupResponse.CreateBackup_Account>();
			for (int i = 0; i < _ctx.Length("CreateBackup.Data.Length"); i++) {
				CreateBackupResponse.CreateBackup_Account account = new CreateBackupResponse.CreateBackup_Account();
				account.BackupSetId = _ctx.LongValue("CreateBackup.Data["+ i +"].BackupSetId");

				createBackupResponse_data.Add(account);
			}
			createBackupResponse.Data = createBackupResponse_data;
        
			return createBackupResponse;
        }
    }
}
