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
    public class DeleteTicketResponseUnmarshaller
    {
        public static DeleteTicketResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DeleteTicketResponse deleteTicketResponse = new DeleteTicketResponse();

			deleteTicketResponse.HttpResponse = _ctx.HttpResponse;
			deleteTicketResponse.RequestId = _ctx.StringValue("DeleteTicket.RequestId");
			deleteTicketResponse.Result = _ctx.BooleanValue("DeleteTicket.Result");
			deleteTicketResponse.Success = _ctx.BooleanValue("DeleteTicket.Success");
        
			return deleteTicketResponse;
        }
    }
}
