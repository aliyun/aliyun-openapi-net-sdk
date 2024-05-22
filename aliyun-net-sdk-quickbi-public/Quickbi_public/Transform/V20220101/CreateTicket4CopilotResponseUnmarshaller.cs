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
using Aliyun.Acs.quickbi_public.Model.V20220101;

namespace Aliyun.Acs.quickbi_public.Transform.V20220101
{
    public class CreateTicket4CopilotResponseUnmarshaller
    {
        public static CreateTicket4CopilotResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateTicket4CopilotResponse createTicket4CopilotResponse = new CreateTicket4CopilotResponse();

			createTicket4CopilotResponse.HttpResponse = _ctx.HttpResponse;
			createTicket4CopilotResponse.RequestId = _ctx.StringValue("CreateTicket4Copilot.RequestId");
			createTicket4CopilotResponse.Result = _ctx.StringValue("CreateTicket4Copilot.Result");
			createTicket4CopilotResponse.Success = _ctx.BooleanValue("CreateTicket4Copilot.Success");
        
			return createTicket4CopilotResponse;
        }
    }
}
