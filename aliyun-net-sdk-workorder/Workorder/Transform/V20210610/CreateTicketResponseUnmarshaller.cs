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
using Aliyun.Acs.Workorder.Model.V20210610;

namespace Aliyun.Acs.Workorder.Transform.V20210610
{
    public class CreateTicketResponseUnmarshaller
    {
        public static CreateTicketResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateTicketResponse createTicketResponse = new CreateTicketResponse();

			createTicketResponse.HttpResponse = _ctx.HttpResponse;
			createTicketResponse.Code = _ctx.IntegerValue("CreateTicket.Code");
			createTicketResponse.RequestId = _ctx.StringValue("CreateTicket.RequestId");
			createTicketResponse.Message = _ctx.StringValue("CreateTicket.Message");
			createTicketResponse.Data = _ctx.StringValue("CreateTicket.Data");
			createTicketResponse.Success = _ctx.BooleanValue("CreateTicket.Success");
        
			return createTicketResponse;
        }
    }
}
