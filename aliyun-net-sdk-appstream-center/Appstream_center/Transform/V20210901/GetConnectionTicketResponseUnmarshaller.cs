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
using Aliyun.Acs.appstream_center.Model.V20210901;

namespace Aliyun.Acs.appstream_center.Transform.V20210901
{
    public class GetConnectionTicketResponseUnmarshaller
    {
        public static GetConnectionTicketResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetConnectionTicketResponse getConnectionTicketResponse = new GetConnectionTicketResponse();

			getConnectionTicketResponse.HttpResponse = _ctx.HttpResponse;
			getConnectionTicketResponse.RequestId = _ctx.StringValue("GetConnectionTicket.RequestId");
			getConnectionTicketResponse.TaskStatus = _ctx.StringValue("GetConnectionTicket.TaskStatus");
			getConnectionTicketResponse.TaskId = _ctx.StringValue("GetConnectionTicket.TaskId");
			getConnectionTicketResponse.BizRegionId = _ctx.StringValue("GetConnectionTicket.BizRegionId");
			getConnectionTicketResponse.Ticket = _ctx.StringValue("GetConnectionTicket.Ticket");
			getConnectionTicketResponse.AppInstanceGroupId = _ctx.StringValue("GetConnectionTicket.AppInstanceGroupId");
			getConnectionTicketResponse.AppInstanceId = _ctx.StringValue("GetConnectionTicket.AppInstanceId");
			getConnectionTicketResponse.OsType = _ctx.StringValue("GetConnectionTicket.OsType");
        
			return getConnectionTicketResponse;
        }
    }
}
