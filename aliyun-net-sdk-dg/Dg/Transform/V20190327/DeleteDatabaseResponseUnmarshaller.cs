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
using Aliyun.Acs.dg.Model.V20190327;

namespace Aliyun.Acs.dg.Transform.V20190327
{
    public class DeleteDatabaseResponseUnmarshaller
    {
        public static DeleteDatabaseResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DeleteDatabaseResponse deleteDatabaseResponse = new DeleteDatabaseResponse();

			deleteDatabaseResponse.HttpResponse = _ctx.HttpResponse;
			deleteDatabaseResponse.RequestId = _ctx.StringValue("DeleteDatabase.RequestId");
			deleteDatabaseResponse.Success = _ctx.BooleanValue("DeleteDatabase.Success");
			deleteDatabaseResponse.Code = _ctx.StringValue("DeleteDatabase.Code");
			deleteDatabaseResponse.ErrorMsg = _ctx.StringValue("DeleteDatabase.ErrorMsg");
			deleteDatabaseResponse.Data = _ctx.StringValue("DeleteDatabase.Data");
        
			return deleteDatabaseResponse;
        }
    }
}
