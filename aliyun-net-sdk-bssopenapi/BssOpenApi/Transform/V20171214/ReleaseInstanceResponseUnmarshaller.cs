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
using Aliyun.Acs.BssOpenApi.Model.V20171214;

namespace Aliyun.Acs.BssOpenApi.Transform.V20171214
{
    public class ReleaseInstanceResponseUnmarshaller
    {
        public static ReleaseInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ReleaseInstanceResponse releaseInstanceResponse = new ReleaseInstanceResponse();

			releaseInstanceResponse.HttpResponse = _ctx.HttpResponse;
			releaseInstanceResponse.Message = _ctx.StringValue("ReleaseInstance.Message");
			releaseInstanceResponse.RequestId = _ctx.StringValue("ReleaseInstance.RequestId");
			releaseInstanceResponse.Code = _ctx.StringValue("ReleaseInstance.Code");
			releaseInstanceResponse.Success = _ctx.BooleanValue("ReleaseInstance.Success");

			ReleaseInstanceResponse.ReleaseInstance_Data data = new ReleaseInstanceResponse.ReleaseInstance_Data();
			data.ReleaseResult = _ctx.BooleanValue("ReleaseInstance.Data.ReleaseResult");
			data.HostId = _ctx.StringValue("ReleaseInstance.Data.HostId");
			releaseInstanceResponse.Data = data;
        
			return releaseInstanceResponse;
        }
    }
}
