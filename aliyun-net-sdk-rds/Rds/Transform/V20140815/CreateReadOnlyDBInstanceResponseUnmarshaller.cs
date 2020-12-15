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
    public class CreateReadOnlyDBInstanceResponseUnmarshaller
    {
        public static CreateReadOnlyDBInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateReadOnlyDBInstanceResponse createReadOnlyDBInstanceResponse = new CreateReadOnlyDBInstanceResponse();

			createReadOnlyDBInstanceResponse.HttpResponse = _ctx.HttpResponse;
			createReadOnlyDBInstanceResponse.RequestId = _ctx.StringValue("CreateReadOnlyDBInstance.RequestId");
			createReadOnlyDBInstanceResponse.DBInstanceId = _ctx.StringValue("CreateReadOnlyDBInstance.DBInstanceId");
			createReadOnlyDBInstanceResponse.OrderId = _ctx.StringValue("CreateReadOnlyDBInstance.OrderId");
			createReadOnlyDBInstanceResponse.ConnectionString = _ctx.StringValue("CreateReadOnlyDBInstance.ConnectionString");
			createReadOnlyDBInstanceResponse.Port = _ctx.StringValue("CreateReadOnlyDBInstance.Port");
        
			return createReadOnlyDBInstanceResponse;
        }
    }
}
