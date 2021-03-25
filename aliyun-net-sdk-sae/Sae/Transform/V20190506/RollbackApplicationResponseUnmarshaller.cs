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
using Aliyun.Acs.sae.Model.V20190506;

namespace Aliyun.Acs.sae.Transform.V20190506
{
    public class RollbackApplicationResponseUnmarshaller
    {
        public static RollbackApplicationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RollbackApplicationResponse rollbackApplicationResponse = new RollbackApplicationResponse();

			rollbackApplicationResponse.HttpResponse = _ctx.HttpResponse;
			rollbackApplicationResponse.Message = _ctx.StringValue("RollbackApplication.Message");
			rollbackApplicationResponse.RequestId = _ctx.StringValue("RollbackApplication.RequestId");
			rollbackApplicationResponse.TraceId = _ctx.StringValue("RollbackApplication.TraceId");
			rollbackApplicationResponse.ErrorCode = _ctx.StringValue("RollbackApplication.ErrorCode");
			rollbackApplicationResponse.Code = _ctx.StringValue("RollbackApplication.Code");
			rollbackApplicationResponse.Success = _ctx.BooleanValue("RollbackApplication.Success");

			RollbackApplicationResponse.RollbackApplication_Data data = new RollbackApplicationResponse.RollbackApplication_Data();
			data.ChangeOrderId = _ctx.StringValue("RollbackApplication.Data.ChangeOrderId");
			rollbackApplicationResponse.Data = data;
        
			return rollbackApplicationResponse;
        }
    }
}
