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
    public class UpgradeDBInstanceMajorVersionResponseUnmarshaller
    {
        public static UpgradeDBInstanceMajorVersionResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpgradeDBInstanceMajorVersionResponse upgradeDBInstanceMajorVersionResponse = new UpgradeDBInstanceMajorVersionResponse();

			upgradeDBInstanceMajorVersionResponse.HttpResponse = _ctx.HttpResponse;
			upgradeDBInstanceMajorVersionResponse.DBInstanceId = _ctx.StringValue("UpgradeDBInstanceMajorVersion.DBInstanceId");
			upgradeDBInstanceMajorVersionResponse.RequestId = _ctx.StringValue("UpgradeDBInstanceMajorVersion.RequestId");
			upgradeDBInstanceMajorVersionResponse.Port = _ctx.StringValue("UpgradeDBInstanceMajorVersion.Port");
			upgradeDBInstanceMajorVersionResponse.ConnectionString = _ctx.StringValue("UpgradeDBInstanceMajorVersion.ConnectionString");
			upgradeDBInstanceMajorVersionResponse.OrderId = _ctx.StringValue("UpgradeDBInstanceMajorVersion.OrderId");
			upgradeDBInstanceMajorVersionResponse.TaskId = _ctx.LongValue("UpgradeDBInstanceMajorVersion.TaskId");
        
			return upgradeDBInstanceMajorVersionResponse;
        }
    }
}
