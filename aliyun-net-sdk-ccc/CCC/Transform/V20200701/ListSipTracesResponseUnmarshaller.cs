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
using Aliyun.Acs.CCC.Model.V20200701;

namespace Aliyun.Acs.CCC.Transform.V20200701
{
    public class ListSipTracesResponseUnmarshaller
    {
        public static ListSipTracesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListSipTracesResponse listSipTracesResponse = new ListSipTracesResponse();

			listSipTracesResponse.HttpResponse = _ctx.HttpResponse;
			listSipTracesResponse.Code = _ctx.StringValue("ListSipTraces.Code");
			listSipTracesResponse.HttpStatusCode = _ctx.IntegerValue("ListSipTraces.HttpStatusCode");
			listSipTracesResponse.Message = _ctx.StringValue("ListSipTraces.Message");
			listSipTracesResponse.RequestId = _ctx.StringValue("ListSipTraces.RequestId");

			List<ListSipTracesResponse.ListSipTraces_CallTraces> listSipTracesResponse_data = new List<ListSipTracesResponse.ListSipTraces_CallTraces>();
			for (int i = 0; i < _ctx.Length("ListSipTraces.Data.Length"); i++) {
				ListSipTracesResponse.ListSipTraces_CallTraces callTraces = new ListSipTracesResponse.ListSipTraces_CallTraces();
				callTraces.CallId = _ctx.StringValue("ListSipTraces.Data["+ i +"].CallId");
				callTraces.ContactId = _ctx.StringValue("ListSipTraces.Data["+ i +"].ContactId");
				callTraces.FirstLine = _ctx.StringValue("ListSipTraces.Data["+ i +"].FirstLine");
				callTraces.DestinationNodeIp = _ctx.StringValue("ListSipTraces.Data["+ i +"].DestinationNodeIp");
				callTraces.SourceNodeIp = _ctx.StringValue("ListSipTraces.Data["+ i +"].SourceNodeIp");
				callTraces.Payload = _ctx.StringValue("ListSipTraces.Data["+ i +"].Payload");
				callTraces.Timestamp = _ctx.LongValue("ListSipTraces.Data["+ i +"].Timestamp");

				listSipTracesResponse_data.Add(callTraces);
			}
			listSipTracesResponse.Data = listSipTracesResponse_data;
        
			return listSipTracesResponse;
        }
    }
}
