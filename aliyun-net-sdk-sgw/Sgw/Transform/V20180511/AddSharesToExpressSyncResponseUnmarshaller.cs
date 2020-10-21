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
        public static AddSharesToExpressSyncResponse Unmarshall(UnmarshallerContext context)
        {
			AddSharesToExpressSyncResponse addSharesToExpressSyncResponse = new AddSharesToExpressSyncResponse();

			addSharesToExpressSyncResponse.HttpResponse = context.HttpResponse;
			addSharesToExpressSyncResponse.RequestId = context.StringValue("AddSharesToExpressSync.RequestId");
			addSharesToExpressSyncResponse.Success = context.BooleanValue("AddSharesToExpressSync.Success");
			addSharesToExpressSyncResponse.Code = context.StringValue("AddSharesToExpressSync.Code");
			addSharesToExpressSyncResponse.Message = context.StringValue("AddSharesToExpressSync.Message");
			addSharesToExpressSyncResponse.TaskId = context.StringValue("AddSharesToExpressSync.TaskId");
			addSharesToExpressSyncResponse.MnsTopic = context.StringValue("AddSharesToExpressSync.MnsTopic");
			addSharesToExpressSyncResponse.MnsQueues = context.StringValue("AddSharesToExpressSync.MnsQueues");
			addSharesToExpressSyncResponse.MnsFullSyncDelay = context.LongValue("AddSharesToExpressSync.MnsFullSyncDelay");
			addSharesToExpressSyncResponse.MnsPublicEndpoint = context.StringValue("AddSharesToExpressSync.MnsPublicEndpoint");
			addSharesToExpressSyncResponse.MnsInnerEndpoint = context.StringValue("AddSharesToExpressSync.MnsInnerEndpoint");
        
			return addSharesToExpressSyncResponse;
        }
    }
}
