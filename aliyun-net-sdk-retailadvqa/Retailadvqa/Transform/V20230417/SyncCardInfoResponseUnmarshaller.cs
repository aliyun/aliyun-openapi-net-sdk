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
using Aliyun.Acs.retailadvqa.Model.V20230417;

namespace Aliyun.Acs.retailadvqa.Transform.V20230417
{
    public class SyncCardInfoResponseUnmarshaller
    {
        public static SyncCardInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SyncCardInfoResponse syncCardInfoResponse = new SyncCardInfoResponse();

			syncCardInfoResponse.HttpResponse = _ctx.HttpResponse;
			syncCardInfoResponse.RequestId = _ctx.StringValue("SyncCardInfo.RequestId");
			syncCardInfoResponse.Success = _ctx.StringValue("SyncCardInfo.Success");
			syncCardInfoResponse.HttpStatusCode = _ctx.StringValue("SyncCardInfo.HttpStatusCode");
			syncCardInfoResponse.ErrorCode = _ctx.StringValue("SyncCardInfo.ErrorCode");
			syncCardInfoResponse.ErrorMessage = _ctx.StringValue("SyncCardInfo.ErrorMessage");
        
			return syncCardInfoResponse;
        }
    }
}
