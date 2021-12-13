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
using Aliyun.Acs.gpdb.Model.V20160503;

namespace Aliyun.Acs.gpdb.Transform.V20160503
{
    public class CreateECSDBInstanceResponseUnmarshaller
    {
        public static CreateECSDBInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateECSDBInstanceResponse createECSDBInstanceResponse = new CreateECSDBInstanceResponse();

			createECSDBInstanceResponse.HttpResponse = _ctx.HttpResponse;
			createECSDBInstanceResponse.RequestId = _ctx.StringValue("CreateECSDBInstance.RequestId");
			createECSDBInstanceResponse.DBInstanceId = _ctx.StringValue("CreateECSDBInstance.DBInstanceId");
			createECSDBInstanceResponse.Port = _ctx.StringValue("CreateECSDBInstance.Port");
			createECSDBInstanceResponse.ConnectionString = _ctx.StringValue("CreateECSDBInstance.ConnectionString");
			createECSDBInstanceResponse.OrderId = _ctx.StringValue("CreateECSDBInstance.OrderId");
        
			return createECSDBInstanceResponse;
        }
    }
}
