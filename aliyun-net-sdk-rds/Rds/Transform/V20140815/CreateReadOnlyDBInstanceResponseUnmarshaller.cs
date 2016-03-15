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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Rds.Model.V20140815;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class CreateReadOnlyDBInstanceResponseUnmarshaller
    {
        public static CreateReadOnlyDBInstanceResponse Unmarshall(UnmarshallerContext context)
        {
			CreateReadOnlyDBInstanceResponse createReadOnlyDBInstanceResponse = new CreateReadOnlyDBInstanceResponse();

			createReadOnlyDBInstanceResponse.HttpResponse = context.HttpResponse;
			createReadOnlyDBInstanceResponse.RequestId = context.StringValue("CreateReadOnlyDBInstance.RequestId");
			createReadOnlyDBInstanceResponse.DBInstanceId = context.StringValue("CreateReadOnlyDBInstance.DBInstanceId");
			createReadOnlyDBInstanceResponse.OrderId = context.StringValue("CreateReadOnlyDBInstance.OrderId");
			createReadOnlyDBInstanceResponse.ConnectionString = context.StringValue("CreateReadOnlyDBInstance.ConnectionString");
			createReadOnlyDBInstanceResponse.Port = context.StringValue("CreateReadOnlyDBInstance.Port");
        
			return createReadOnlyDBInstanceResponse;
        }
    }
}