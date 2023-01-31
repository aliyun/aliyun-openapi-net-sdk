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
using Aliyun.Acs.Vpc.Model.V20160428;

namespace Aliyun.Acs.Vpc.Transform.V20160428
{
    public class CreateRouteEntriesResponseUnmarshaller
    {
        public static CreateRouteEntriesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateRouteEntriesResponse createRouteEntriesResponse = new CreateRouteEntriesResponse();

			createRouteEntriesResponse.HttpResponse = _ctx.HttpResponse;
			createRouteEntriesResponse.SuccessCount = _ctx.IntegerValue("CreateRouteEntries.SuccessCount");
			createRouteEntriesResponse.FailedCount = _ctx.IntegerValue("CreateRouteEntries.FailedCount");
			createRouteEntriesResponse.RequestId = _ctx.StringValue("CreateRouteEntries.RequestId");

			List<string> createRouteEntriesResponse_routeEntryIds = new List<string>();
			for (int i = 0; i < _ctx.Length("CreateRouteEntries.RouteEntryIds.Length"); i++) {
				createRouteEntriesResponse_routeEntryIds.Add(_ctx.StringValue("CreateRouteEntries.RouteEntryIds["+ i +"]"));
			}
			createRouteEntriesResponse.RouteEntryIds = createRouteEntriesResponse_routeEntryIds;

			List<CreateRouteEntriesResponse.CreateRouteEntries_FailedRouteEntriesItem> createRouteEntriesResponse_failedRouteEntries = new List<CreateRouteEntriesResponse.CreateRouteEntries_FailedRouteEntriesItem>();
			for (int i = 0; i < _ctx.Length("CreateRouteEntries.FailedRouteEntries.Length"); i++) {
				CreateRouteEntriesResponse.CreateRouteEntries_FailedRouteEntriesItem failedRouteEntriesItem = new CreateRouteEntriesResponse.CreateRouteEntries_FailedRouteEntriesItem();
				failedRouteEntriesItem.DstCidrBlock = _ctx.StringValue("CreateRouteEntries.FailedRouteEntries["+ i +"].DstCidrBlock");
				failedRouteEntriesItem.NextHop = _ctx.StringValue("CreateRouteEntries.FailedRouteEntries["+ i +"].NextHop");
				failedRouteEntriesItem.FailedCode = _ctx.StringValue("CreateRouteEntries.FailedRouteEntries["+ i +"].FailedCode");
				failedRouteEntriesItem.FailedMessage = _ctx.StringValue("CreateRouteEntries.FailedRouteEntries["+ i +"].FailedMessage");

				createRouteEntriesResponse_failedRouteEntries.Add(failedRouteEntriesItem);
			}
			createRouteEntriesResponse.FailedRouteEntries = createRouteEntriesResponse_failedRouteEntries;
        
			return createRouteEntriesResponse;
        }
    }
}
