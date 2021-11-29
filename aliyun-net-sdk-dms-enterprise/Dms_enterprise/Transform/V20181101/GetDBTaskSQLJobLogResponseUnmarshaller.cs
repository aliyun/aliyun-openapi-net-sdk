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
using Aliyun.Acs.dms_enterprise.Model.V20181101;

namespace Aliyun.Acs.dms_enterprise.Transform.V20181101
{
    public class GetDBTaskSQLJobLogResponseUnmarshaller
    {
        public static GetDBTaskSQLJobLogResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetDBTaskSQLJobLogResponse getDBTaskSQLJobLogResponse = new GetDBTaskSQLJobLogResponse();

			getDBTaskSQLJobLogResponse.HttpResponse = _ctx.HttpResponse;
			getDBTaskSQLJobLogResponse.RequestId = _ctx.StringValue("GetDBTaskSQLJobLog.RequestId");
			getDBTaskSQLJobLogResponse.Success = _ctx.BooleanValue("GetDBTaskSQLJobLog.Success");
			getDBTaskSQLJobLogResponse.ErrorMessage = _ctx.StringValue("GetDBTaskSQLJobLog.ErrorMessage");
			getDBTaskSQLJobLogResponse.ErrorCode = _ctx.StringValue("GetDBTaskSQLJobLog.ErrorCode");
			getDBTaskSQLJobLogResponse.Log = _ctx.StringValue("GetDBTaskSQLJobLog.Log");
        
			return getDBTaskSQLJobLogResponse;
        }
    }
}
