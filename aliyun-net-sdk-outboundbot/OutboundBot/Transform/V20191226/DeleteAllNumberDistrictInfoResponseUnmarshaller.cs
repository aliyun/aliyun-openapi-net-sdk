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
    public class DeleteAllNumberDistrictInfoResponseUnmarshaller
    {
        public static DeleteAllNumberDistrictInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DeleteAllNumberDistrictInfoResponse deleteAllNumberDistrictInfoResponse = new DeleteAllNumberDistrictInfoResponse();

			deleteAllNumberDistrictInfoResponse.HttpResponse = _ctx.HttpResponse;
			deleteAllNumberDistrictInfoResponse.HttpStatusCode = _ctx.IntegerValue("DeleteAllNumberDistrictInfo.HttpStatusCode");
			deleteAllNumberDistrictInfoResponse.Code = _ctx.StringValue("DeleteAllNumberDistrictInfo.Code");
			deleteAllNumberDistrictInfoResponse.Message = _ctx.StringValue("DeleteAllNumberDistrictInfo.Message");
			deleteAllNumberDistrictInfoResponse.RequestId = _ctx.StringValue("DeleteAllNumberDistrictInfo.RequestId");
			deleteAllNumberDistrictInfoResponse.Success = _ctx.BooleanValue("DeleteAllNumberDistrictInfo.Success");
        
			return deleteAllNumberDistrictInfoResponse;
        }
    }
}
