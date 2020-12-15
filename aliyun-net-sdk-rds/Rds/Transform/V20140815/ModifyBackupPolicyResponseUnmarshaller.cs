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
using Aliyun.Acs.Rds.Model.V20140815;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class ModifyBackupPolicyResponseUnmarshaller
    {
        public static ModifyBackupPolicyResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ModifyBackupPolicyResponse modifyBackupPolicyResponse = new ModifyBackupPolicyResponse();

			modifyBackupPolicyResponse.HttpResponse = _ctx.HttpResponse;
			modifyBackupPolicyResponse.RequestId = _ctx.StringValue("ModifyBackupPolicy.RequestId");
			modifyBackupPolicyResponse.DBInstanceID = _ctx.StringValue("ModifyBackupPolicy.DBInstanceID");
			modifyBackupPolicyResponse.EnableBackupLog = _ctx.StringValue("ModifyBackupPolicy.EnableBackupLog");
			modifyBackupPolicyResponse.LocalLogRetentionHours = _ctx.IntegerValue("ModifyBackupPolicy.LocalLogRetentionHours");
			modifyBackupPolicyResponse.LocalLogRetentionSpace = _ctx.StringValue("ModifyBackupPolicy.LocalLogRetentionSpace");
			modifyBackupPolicyResponse.HighSpaceUsageProtection = _ctx.StringValue("ModifyBackupPolicy.HighSpaceUsageProtection");
			modifyBackupPolicyResponse.CompressType = _ctx.StringValue("ModifyBackupPolicy.CompressType");
			modifyBackupPolicyResponse.LogBackupLocalRetentionNumber = _ctx.IntegerValue("ModifyBackupPolicy.LogBackupLocalRetentionNumber");
        
			return modifyBackupPolicyResponse;
        }
    }
}
