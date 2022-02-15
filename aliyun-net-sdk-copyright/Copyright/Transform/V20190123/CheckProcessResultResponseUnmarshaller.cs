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
using Aliyun.Acs.Copyright.Model.V20190123;

namespace Aliyun.Acs.Copyright.Transform.V20190123
{
    public class CheckProcessResultResponseUnmarshaller
    {
        public static CheckProcessResultResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CheckProcessResultResponse checkProcessResultResponse = new CheckProcessResultResponse();

			checkProcessResultResponse.HttpResponse = _ctx.HttpResponse;
			checkProcessResultResponse.Token = _ctx.StringValue("CheckProcessResult.Token");
			checkProcessResultResponse.Status = _ctx.StringValue("CheckProcessResult.Status");
			checkProcessResultResponse.Message = _ctx.StringValue("CheckProcessResult.Message");
			checkProcessResultResponse.RequestId = _ctx.StringValue("CheckProcessResult.RequestId");
			checkProcessResultResponse.Success = _ctx.BooleanValue("CheckProcessResult.Success");
        
			return checkProcessResultResponse;
        }
    }
}
