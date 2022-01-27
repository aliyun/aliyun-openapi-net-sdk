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
    public class AddDatabaseResponseUnmarshaller
    {
        public static AddDatabaseResponse Unmarshall(UnmarshallerContext _ctx)
        {
			AddDatabaseResponse addDatabaseResponse = new AddDatabaseResponse();

			addDatabaseResponse.HttpResponse = _ctx.HttpResponse;
			addDatabaseResponse.RequestId = _ctx.StringValue("AddDatabase.RequestId");
			addDatabaseResponse.Success = _ctx.BooleanValue("AddDatabase.Success");
			addDatabaseResponse.Code = _ctx.StringValue("AddDatabase.Code");
			addDatabaseResponse.ErrorMsg = _ctx.StringValue("AddDatabase.ErrorMsg");
			addDatabaseResponse.Data = _ctx.StringValue("AddDatabase.Data");
        
			return addDatabaseResponse;
        }
    }
}
