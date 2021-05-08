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
using Aliyun.Acs.UniMkt.Model.V20181207;

namespace Aliyun.Acs.UniMkt.Transform.V20181207
{
    public class GetConsoleInfoResponseUnmarshaller
    {
        public static GetConsoleInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetConsoleInfoResponse getConsoleInfoResponse = new GetConsoleInfoResponse();

			getConsoleInfoResponse.HttpResponse = _ctx.HttpResponse;
			getConsoleInfoResponse.RequestId = _ctx.StringValue("GetConsoleInfo.RequestId");
			getConsoleInfoResponse.Status = _ctx.IntegerValue("GetConsoleInfo.Status");
			getConsoleInfoResponse.Message = _ctx.StringValue("GetConsoleInfo.Message");
			getConsoleInfoResponse.Data = _ctx.StringValue("GetConsoleInfo.Data");
        
			return getConsoleInfoResponse;
        }
    }
}
