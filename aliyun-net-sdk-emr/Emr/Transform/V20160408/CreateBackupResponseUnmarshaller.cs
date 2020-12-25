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
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class CreateBackupResponseUnmarshaller
    {
        public static CreateBackupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateBackupResponse createBackupResponse = new CreateBackupResponse();

			createBackupResponse.HttpResponse = _ctx.HttpResponse;
			createBackupResponse.RequestId = _ctx.StringValue("CreateBackup.RequestId");
			createBackupResponse.BizId = _ctx.StringValue("CreateBackup.BizId");
			createBackupResponse.DataSourceId = _ctx.LongValue("CreateBackup.DataSourceId");
			createBackupResponse.TaskType = _ctx.StringValue("CreateBackup.TaskType");
			createBackupResponse.TaskStatus = _ctx.StringValue("CreateBackup.TaskStatus");
			createBackupResponse.StartTime = _ctx.LongValue("CreateBackup.StartTime");
			createBackupResponse.EndTime = _ctx.LongValue("CreateBackup.EndTime");
			createBackupResponse.TaskDetail = _ctx.StringValue("CreateBackup.TaskDetail");
			createBackupResponse.TaskResultDetail = _ctx.StringValue("CreateBackup.TaskResultDetail");
			createBackupResponse.TaskProcess = _ctx.IntegerValue("CreateBackup.TaskProcess");
			createBackupResponse.TriggerUser = _ctx.StringValue("CreateBackup.TriggerUser");
			createBackupResponse.TriggerType = _ctx.StringValue("CreateBackup.TriggerType");
			createBackupResponse.GmtCreate = _ctx.LongValue("CreateBackup.GmtCreate");
			createBackupResponse.GmtModified = _ctx.LongValue("CreateBackup.GmtModified");
			createBackupResponse.ClusterBizId = _ctx.StringValue("CreateBackup.ClusterBizId");
			createBackupResponse.HostName = _ctx.StringValue("CreateBackup.HostName");
			createBackupResponse.EcmTaskId = _ctx.LongValue("CreateBackup.EcmTaskId");
        
			return createBackupResponse;
        }
    }
}
