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
    public class RestartFileSharesResponseUnmarshaller
    {
        public static RestartFileSharesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RestartFileSharesResponse restartFileSharesResponse = new RestartFileSharesResponse();

			restartFileSharesResponse.HttpResponse = _ctx.HttpResponse;
			restartFileSharesResponse.RequestId = _ctx.StringValue("RestartFileShares.RequestId");
			restartFileSharesResponse.Success = _ctx.BooleanValue("RestartFileShares.Success");
			restartFileSharesResponse.Code = _ctx.StringValue("RestartFileShares.Code");
			restartFileSharesResponse.Message = _ctx.StringValue("RestartFileShares.Message");
			restartFileSharesResponse.TaskId = _ctx.StringValue("RestartFileShares.TaskId");
        
			return restartFileSharesResponse;
        }
    }
}
