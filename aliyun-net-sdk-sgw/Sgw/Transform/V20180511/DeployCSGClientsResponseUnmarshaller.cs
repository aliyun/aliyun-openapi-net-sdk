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
    public class DeployCSGClientsResponseUnmarshaller
    {
        public static DeployCSGClientsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DeployCSGClientsResponse deployCSGClientsResponse = new DeployCSGClientsResponse();

			deployCSGClientsResponse.HttpResponse = _ctx.HttpResponse;
			deployCSGClientsResponse.Code = _ctx.StringValue("DeployCSGClients.Code");
			deployCSGClientsResponse.Message = _ctx.StringValue("DeployCSGClients.Message");
			deployCSGClientsResponse.RequestId = _ctx.StringValue("DeployCSGClients.RequestId");
			deployCSGClientsResponse.TaskId = _ctx.StringValue("DeployCSGClients.TaskId");
			deployCSGClientsResponse.Success = _ctx.BooleanValue("DeployCSGClients.Success");
        
			return deployCSGClientsResponse;
        }
    }
}
