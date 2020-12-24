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
    public class RenewBackupPlanResponseUnmarshaller
    {
        public static RenewBackupPlanResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RenewBackupPlanResponse renewBackupPlanResponse = new RenewBackupPlanResponse();

			renewBackupPlanResponse.HttpResponse = _ctx.HttpResponse;
			renewBackupPlanResponse.Success = _ctx.BooleanValue("RenewBackupPlan.Success");
			renewBackupPlanResponse.ErrCode = _ctx.StringValue("RenewBackupPlan.ErrCode");
			renewBackupPlanResponse.ErrMessage = _ctx.StringValue("RenewBackupPlan.ErrMessage");
			renewBackupPlanResponse.HttpStatusCode = _ctx.IntegerValue("RenewBackupPlan.HttpStatusCode");
			renewBackupPlanResponse.RequestId = _ctx.StringValue("RenewBackupPlan.RequestId");
			renewBackupPlanResponse.BackupPlanId = _ctx.StringValue("RenewBackupPlan.BackupPlanId");
			renewBackupPlanResponse.OrderId = _ctx.StringValue("RenewBackupPlan.OrderId");
        
			return renewBackupPlanResponse;
        }
    }
}
