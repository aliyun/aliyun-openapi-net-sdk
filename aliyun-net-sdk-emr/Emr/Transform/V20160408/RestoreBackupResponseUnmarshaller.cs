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
    public class RestoreBackupResponseUnmarshaller
    {
        public static RestoreBackupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RestoreBackupResponse restoreBackupResponse = new RestoreBackupResponse();

			restoreBackupResponse.HttpResponse = _ctx.HttpResponse;
			restoreBackupResponse.RequestId = _ctx.StringValue("RestoreBackup.RequestId");
			restoreBackupResponse.BizId = _ctx.StringValue("RestoreBackup.BizId");
			restoreBackupResponse.DataSourceId = _ctx.LongValue("RestoreBackup.DataSourceId");
			restoreBackupResponse.TaskType = _ctx.StringValue("RestoreBackup.TaskType");
			restoreBackupResponse.TaskStatus = _ctx.StringValue("RestoreBackup.TaskStatus");
			restoreBackupResponse.StartTime = _ctx.LongValue("RestoreBackup.StartTime");
			restoreBackupResponse.EndTime = _ctx.LongValue("RestoreBackup.EndTime");
			restoreBackupResponse.TaskDetail = _ctx.StringValue("RestoreBackup.TaskDetail");
			restoreBackupResponse.TaskResultDetail = _ctx.StringValue("RestoreBackup.TaskResultDetail");
			restoreBackupResponse.TaskProcess = _ctx.IntegerValue("RestoreBackup.TaskProcess");
			restoreBackupResponse.TriggerUser = _ctx.StringValue("RestoreBackup.TriggerUser");
			restoreBackupResponse.TriggerType = _ctx.StringValue("RestoreBackup.TriggerType");
			restoreBackupResponse.GmtCreate = _ctx.LongValue("RestoreBackup.GmtCreate");
			restoreBackupResponse.GmtModified = _ctx.LongValue("RestoreBackup.GmtModified");
			restoreBackupResponse.ClusterBizId = _ctx.StringValue("RestoreBackup.ClusterBizId");
			restoreBackupResponse.HostName = _ctx.StringValue("RestoreBackup.HostName");
			restoreBackupResponse.EcmTaskId = _ctx.LongValue("RestoreBackup.EcmTaskId");
        
			return restoreBackupResponse;
        }
    }
}
