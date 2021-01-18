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
    public class RetryDatabaseResponseUnmarshaller
    {
        public static RetryDatabaseResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RetryDatabaseResponse retryDatabaseResponse = new RetryDatabaseResponse();

			retryDatabaseResponse.HttpResponse = _ctx.HttpResponse;
			retryDatabaseResponse.RequestId = _ctx.StringValue("RetryDatabase.RequestId");
			retryDatabaseResponse.Success = _ctx.BooleanValue("RetryDatabase.Success");
			retryDatabaseResponse.Code = _ctx.StringValue("RetryDatabase.Code");
			retryDatabaseResponse.ErrorMsg = _ctx.StringValue("RetryDatabase.ErrorMsg");
			retryDatabaseResponse.Data = _ctx.StringValue("RetryDatabase.Data");
        
			return retryDatabaseResponse;
        }
    }
}
