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
    public class CreateDBInstanceEndpointResponseUnmarshaller
    {
        public static CreateDBInstanceEndpointResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateDBInstanceEndpointResponse createDBInstanceEndpointResponse = new CreateDBInstanceEndpointResponse();

			createDBInstanceEndpointResponse.HttpResponse = _ctx.HttpResponse;
			createDBInstanceEndpointResponse.RequestId = _ctx.StringValue("CreateDBInstanceEndpoint.RequestId");

			CreateDBInstanceEndpointResponse.CreateDBInstanceEndpoint_Data data = new CreateDBInstanceEndpointResponse.CreateDBInstanceEndpoint_Data();
			data.DBInstanceName = _ctx.StringValue("CreateDBInstanceEndpoint.Data.DBInstanceName");
			data.DBInstanceEndpointId = _ctx.StringValue("CreateDBInstanceEndpoint.Data.DBInstanceEndpointId");
			data.ConnectionString = _ctx.StringValue("CreateDBInstanceEndpoint.Data.ConnectionString");
			createDBInstanceEndpointResponse.Data = data;
        
			return createDBInstanceEndpointResponse;
        }
    }
}
