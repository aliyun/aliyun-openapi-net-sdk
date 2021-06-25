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
using Aliyun.Acs.OutboundBot.Model.V20191226;

namespace Aliyun.Acs.OutboundBot.Transform.V20191226
{
    public class DeleteContactWhiteListResponseUnmarshaller
    {
        public static DeleteContactWhiteListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DeleteContactWhiteListResponse deleteContactWhiteListResponse = new DeleteContactWhiteListResponse();

			deleteContactWhiteListResponse.HttpResponse = _ctx.HttpResponse;
			deleteContactWhiteListResponse.RequestId = _ctx.StringValue("DeleteContactWhiteList.RequestId");
			deleteContactWhiteListResponse.Success = _ctx.BooleanValue("DeleteContactWhiteList.Success");
			deleteContactWhiteListResponse.Code = _ctx.StringValue("DeleteContactWhiteList.Code");
			deleteContactWhiteListResponse.Message = _ctx.StringValue("DeleteContactWhiteList.Message");
			deleteContactWhiteListResponse.HttpStatusCode = _ctx.IntegerValue("DeleteContactWhiteList.HttpStatusCode");
			deleteContactWhiteListResponse.AffectedRows = _ctx.IntegerValue("DeleteContactWhiteList.AffectedRows");
        
			return deleteContactWhiteListResponse;
        }
    }
}
