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
    public class GetTicketsInfoResponseUnmarshaller
    {
        public static GetTicketsInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetTicketsInfoResponse getTicketsInfoResponse = new GetTicketsInfoResponse();

			getTicketsInfoResponse.HttpResponse = _ctx.HttpResponse;
			getTicketsInfoResponse.RequestId = _ctx.StringValue("GetTicketsInfo.RequestId");
			getTicketsInfoResponse.Success = _ctx.BooleanValue("GetTicketsInfo.Success");

			List<GetTicketsInfoResponse.GetTicketsInfo_Tickets> getTicketsInfoResponse_data = new List<GetTicketsInfoResponse.GetTicketsInfo_Tickets>();
			for (int i = 0; i < _ctx.Length("GetTicketsInfo.Data.Length"); i++) {
				GetTicketsInfoResponse.GetTicketsInfo_Tickets tickets = new GetTicketsInfoResponse.GetTicketsInfo_Tickets();
				tickets.Fee = _ctx.StringValue("GetTicketsInfo.Data["+ i +"].Fee");
				tickets.InvoiceUrl = _ctx.StringValue("GetTicketsInfo.Data["+ i +"].InvoiceUrl");
				tickets.InvoiceYear = _ctx.IntegerValue("GetTicketsInfo.Data["+ i +"].InvoiceYear");
				tickets.PatentNo = _ctx.LongValue("GetTicketsInfo.Data["+ i +"].PatentNo");
				tickets.Remark = _ctx.StringValue("GetTicketsInfo.Data["+ i +"].Remark");

				getTicketsInfoResponse_data.Add(tickets);
			}
			getTicketsInfoResponse.Data = getTicketsInfoResponse_data;
        
			return getTicketsInfoResponse;
        }
    }
}
