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
    public class ModifyDBInstanceConnectionStringResponseUnmarshaller
    {
        public static ModifyDBInstanceConnectionStringResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ModifyDBInstanceConnectionStringResponse modifyDBInstanceConnectionStringResponse = new ModifyDBInstanceConnectionStringResponse();

			modifyDBInstanceConnectionStringResponse.HttpResponse = _ctx.HttpResponse;
			modifyDBInstanceConnectionStringResponse.Message = _ctx.StringValue("ModifyDBInstanceConnectionString.Message");
			modifyDBInstanceConnectionStringResponse.Code = _ctx.LongValue("ModifyDBInstanceConnectionString.Code");
			modifyDBInstanceConnectionStringResponse.RequestId = _ctx.StringValue("ModifyDBInstanceConnectionString.RequestId");

			ModifyDBInstanceConnectionStringResponse.ModifyDBInstanceConnectionString_Data data = new ModifyDBInstanceConnectionStringResponse.ModifyDBInstanceConnectionString_Data();
			data.ConnectionString = _ctx.StringValue("ModifyDBInstanceConnectionString.Data.ConnectionString");
			data.DBInstanceName = _ctx.StringValue("ModifyDBInstanceConnectionString.Data.DBInstanceName");
			data.DBInstanceNetType = _ctx.StringValue("ModifyDBInstanceConnectionString.Data.DBInstanceNetType");
			data.Port = _ctx.StringValue("ModifyDBInstanceConnectionString.Data.Port");
			modifyDBInstanceConnectionStringResponse.Data = data;
        
			return modifyDBInstanceConnectionStringResponse;
        }
    }
}
