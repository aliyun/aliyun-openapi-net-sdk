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
    public class ModifyBackupSetDownloadRulesResponseUnmarshaller
    {
        public static ModifyBackupSetDownloadRulesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ModifyBackupSetDownloadRulesResponse modifyBackupSetDownloadRulesResponse = new ModifyBackupSetDownloadRulesResponse();

			modifyBackupSetDownloadRulesResponse.HttpResponse = _ctx.HttpResponse;
			modifyBackupSetDownloadRulesResponse.Success = _ctx.BooleanValue("ModifyBackupSetDownloadRules.Success");
			modifyBackupSetDownloadRulesResponse.ErrCode = _ctx.StringValue("ModifyBackupSetDownloadRules.ErrCode");
			modifyBackupSetDownloadRulesResponse.ErrMessage = _ctx.StringValue("ModifyBackupSetDownloadRules.ErrMessage");
			modifyBackupSetDownloadRulesResponse.HttpStatusCode = _ctx.IntegerValue("ModifyBackupSetDownloadRules.HttpStatusCode");
			modifyBackupSetDownloadRulesResponse.RequestId = _ctx.StringValue("ModifyBackupSetDownloadRules.RequestId");
			modifyBackupSetDownloadRulesResponse.BackupPlanId = _ctx.StringValue("ModifyBackupSetDownloadRules.BackupPlanId");
        
			return modifyBackupSetDownloadRulesResponse;
        }
    }
}
