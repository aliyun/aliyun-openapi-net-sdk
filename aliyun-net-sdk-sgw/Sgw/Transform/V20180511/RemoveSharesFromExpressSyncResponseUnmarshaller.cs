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
using Aliyun.Acs.sgw.Model.V20180511;

namespace Aliyun.Acs.sgw.Transform.V20180511
{
    public class RemoveSharesFromExpressSyncResponseUnmarshaller
    {
        public static RemoveSharesFromExpressSyncResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RemoveSharesFromExpressSyncResponse removeSharesFromExpressSyncResponse = new RemoveSharesFromExpressSyncResponse();

			removeSharesFromExpressSyncResponse.HttpResponse = _ctx.HttpResponse;
			removeSharesFromExpressSyncResponse.RequestId = _ctx.StringValue("RemoveSharesFromExpressSync.RequestId");
			removeSharesFromExpressSyncResponse.Success = _ctx.BooleanValue("RemoveSharesFromExpressSync.Success");
			removeSharesFromExpressSyncResponse.Code = _ctx.StringValue("RemoveSharesFromExpressSync.Code");
			removeSharesFromExpressSyncResponse.Message = _ctx.StringValue("RemoveSharesFromExpressSync.Message");
			removeSharesFromExpressSyncResponse.TaskId = _ctx.StringValue("RemoveSharesFromExpressSync.TaskId");
        
			return removeSharesFromExpressSyncResponse;
        }
    }
}
