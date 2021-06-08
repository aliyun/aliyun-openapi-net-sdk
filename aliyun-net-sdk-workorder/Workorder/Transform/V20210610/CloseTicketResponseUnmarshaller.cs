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
    public class CloseTicketResponseUnmarshaller
    {
        public static CloseTicketResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CloseTicketResponse closeTicketResponse = new CloseTicketResponse();

			closeTicketResponse.HttpResponse = _ctx.HttpResponse;
			closeTicketResponse.Code = _ctx.IntegerValue("CloseTicket.Code");
			closeTicketResponse.RequestId = _ctx.StringValue("CloseTicket.RequestId");
			closeTicketResponse.Message = _ctx.StringValue("CloseTicket.Message");
			closeTicketResponse.Success = _ctx.BooleanValue("CloseTicket.Success");
        
			return closeTicketResponse;
        }
    }
}
