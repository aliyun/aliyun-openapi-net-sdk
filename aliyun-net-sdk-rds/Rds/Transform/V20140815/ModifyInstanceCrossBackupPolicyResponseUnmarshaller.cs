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
    public class ModifyInstanceCrossBackupPolicyResponseUnmarshaller
    {
        public static ModifyInstanceCrossBackupPolicyResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ModifyInstanceCrossBackupPolicyResponse modifyInstanceCrossBackupPolicyResponse = new ModifyInstanceCrossBackupPolicyResponse();

			modifyInstanceCrossBackupPolicyResponse.HttpResponse = _ctx.HttpResponse;
			modifyInstanceCrossBackupPolicyResponse.RequestId = _ctx.StringValue("ModifyInstanceCrossBackupPolicy.RequestId");
			modifyInstanceCrossBackupPolicyResponse.DBInstanceId = _ctx.StringValue("ModifyInstanceCrossBackupPolicy.DBInstanceId");
			modifyInstanceCrossBackupPolicyResponse.RegionId = _ctx.StringValue("ModifyInstanceCrossBackupPolicy.RegionId");
			modifyInstanceCrossBackupPolicyResponse.CrossBackupRegion = _ctx.StringValue("ModifyInstanceCrossBackupPolicy.CrossBackupRegion");
			modifyInstanceCrossBackupPolicyResponse.CrossBackupType = _ctx.StringValue("ModifyInstanceCrossBackupPolicy.CrossBackupType");
			modifyInstanceCrossBackupPolicyResponse.BackupEnabled = _ctx.StringValue("ModifyInstanceCrossBackupPolicy.BackupEnabled");
			modifyInstanceCrossBackupPolicyResponse.LogBackupEnabled = _ctx.StringValue("ModifyInstanceCrossBackupPolicy.LogBackupEnabled");
			modifyInstanceCrossBackupPolicyResponse.StorageOwner = _ctx.StringValue("ModifyInstanceCrossBackupPolicy.StorageOwner");
			modifyInstanceCrossBackupPolicyResponse.StorageType = _ctx.StringValue("ModifyInstanceCrossBackupPolicy.StorageType");
			modifyInstanceCrossBackupPolicyResponse.Endpoint = _ctx.StringValue("ModifyInstanceCrossBackupPolicy.Endpoint");
			modifyInstanceCrossBackupPolicyResponse.RetentType = _ctx.IntegerValue("ModifyInstanceCrossBackupPolicy.RetentType");
			modifyInstanceCrossBackupPolicyResponse.Retention = _ctx.IntegerValue("ModifyInstanceCrossBackupPolicy.Retention");
        
			return modifyInstanceCrossBackupPolicyResponse;
        }
    }
}
