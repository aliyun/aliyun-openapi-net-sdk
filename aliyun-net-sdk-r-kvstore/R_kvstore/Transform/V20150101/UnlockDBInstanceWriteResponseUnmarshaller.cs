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
using Aliyun.Acs.R_kvstore.Model.V20150101;

namespace Aliyun.Acs.R_kvstore.Transform.V20150101
{
    public class UnlockDBInstanceWriteResponseUnmarshaller
    {
        public static UnlockDBInstanceWriteResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UnlockDBInstanceWriteResponse unlockDBInstanceWriteResponse = new UnlockDBInstanceWriteResponse();

			unlockDBInstanceWriteResponse.HttpResponse = _ctx.HttpResponse;
			unlockDBInstanceWriteResponse.RequestId = _ctx.StringValue("UnlockDBInstanceWrite.RequestId");
			unlockDBInstanceWriteResponse.DBInstanceName = _ctx.StringValue("UnlockDBInstanceWrite.DBInstanceName");
			unlockDBInstanceWriteResponse.TaskId = _ctx.LongValue("UnlockDBInstanceWrite.TaskId");
        
			return unlockDBInstanceWriteResponse;
        }
    }
}
