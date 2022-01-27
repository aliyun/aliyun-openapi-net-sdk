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
using Aliyun.Acs.Dbs.Model.V20190306;

namespace Aliyun.Acs.Dbs.Transform.V20190306
{
    public class DisableBackupLogResponseUnmarshaller
    {
        public static DisableBackupLogResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DisableBackupLogResponse disableBackupLogResponse = new DisableBackupLogResponse();

			disableBackupLogResponse.HttpResponse = _ctx.HttpResponse;
			disableBackupLogResponse.Success = _ctx.BooleanValue("DisableBackupLog.Success");
			disableBackupLogResponse.ErrCode = _ctx.StringValue("DisableBackupLog.ErrCode");
			disableBackupLogResponse.ErrMessage = _ctx.StringValue("DisableBackupLog.ErrMessage");
			disableBackupLogResponse.HttpStatusCode = _ctx.IntegerValue("DisableBackupLog.HttpStatusCode");
			disableBackupLogResponse.RequestId = _ctx.StringValue("DisableBackupLog.RequestId");
			disableBackupLogResponse.BackupPlanId = _ctx.StringValue("DisableBackupLog.BackupPlanId");
			disableBackupLogResponse.NeedPrecheck = _ctx.BooleanValue("DisableBackupLog.NeedPrecheck");
        
			return disableBackupLogResponse;
        }
    }
}
