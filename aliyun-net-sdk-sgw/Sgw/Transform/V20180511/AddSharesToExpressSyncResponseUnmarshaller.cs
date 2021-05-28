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
    public class AddSharesToExpressSyncResponseUnmarshaller
    {
        public static AddSharesToExpressSyncResponse Unmarshall(UnmarshallerContext _ctx)
        {
			AddSharesToExpressSyncResponse addSharesToExpressSyncResponse = new AddSharesToExpressSyncResponse();

			addSharesToExpressSyncResponse.HttpResponse = _ctx.HttpResponse;
			addSharesToExpressSyncResponse.RequestId = _ctx.StringValue("AddSharesToExpressSync.RequestId");
			addSharesToExpressSyncResponse.Success = _ctx.BooleanValue("AddSharesToExpressSync.Success");
			addSharesToExpressSyncResponse.Code = _ctx.StringValue("AddSharesToExpressSync.Code");
			addSharesToExpressSyncResponse.Message = _ctx.StringValue("AddSharesToExpressSync.Message");
			addSharesToExpressSyncResponse.TaskId = _ctx.StringValue("AddSharesToExpressSync.TaskId");
			addSharesToExpressSyncResponse.MnsTopic = _ctx.StringValue("AddSharesToExpressSync.MnsTopic");
			addSharesToExpressSyncResponse.MnsQueues = _ctx.StringValue("AddSharesToExpressSync.MnsQueues");
			addSharesToExpressSyncResponse.MnsFullSyncDelay = _ctx.LongValue("AddSharesToExpressSync.MnsFullSyncDelay");
			addSharesToExpressSyncResponse.MnsPublicEndpoint = _ctx.StringValue("AddSharesToExpressSync.MnsPublicEndpoint");
			addSharesToExpressSyncResponse.MnsInnerEndpoint = _ctx.StringValue("AddSharesToExpressSync.MnsInnerEndpoint");
        
			return addSharesToExpressSyncResponse;
        }
    }
}
