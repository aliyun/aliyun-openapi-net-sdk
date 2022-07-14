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
using Aliyun.Acs.antiddos_public.Model.V20170518;

namespace Aliyun.Acs.antiddos_public.Transform.V20170518
{
    public class DescribeDdosEventListResponseUnmarshaller
    {
        public static DescribeDdosEventListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDdosEventListResponse describeDdosEventListResponse = new DescribeDdosEventListResponse();

			describeDdosEventListResponse.HttpResponse = _ctx.HttpResponse;
			describeDdosEventListResponse.Total = _ctx.IntegerValue("DescribeDdosEventList.Total");
			describeDdosEventListResponse.RequestId = _ctx.StringValue("DescribeDdosEventList.RequestId");

			List<DescribeDdosEventListResponse.DescribeDdosEventList_DdosEvent> describeDdosEventListResponse_ddosEventList = new List<DescribeDdosEventListResponse.DescribeDdosEventList_DdosEvent>();
			for (int i = 0; i < _ctx.Length("DescribeDdosEventList.DdosEventList.Length"); i++) {
				DescribeDdosEventListResponse.DescribeDdosEventList_DdosEvent ddosEvent = new DescribeDdosEventListResponse.DescribeDdosEventList_DdosEvent();
				ddosEvent.DdosType = _ctx.StringValue("DescribeDdosEventList.DdosEventList["+ i +"].DdosType");
				ddosEvent.EndTime = _ctx.LongValue("DescribeDdosEventList.DdosEventList["+ i +"].EndTime");
				ddosEvent.StartTime = _ctx.LongValue("DescribeDdosEventList.DdosEventList["+ i +"].StartTime");
				ddosEvent.DelayTime = _ctx.LongValue("DescribeDdosEventList.DdosEventList["+ i +"].DelayTime");
				ddosEvent.DdosStatus = _ctx.StringValue("DescribeDdosEventList.DdosEventList["+ i +"].DdosStatus");
				ddosEvent.UnBlackholeTime = _ctx.LongValue("DescribeDdosEventList.DdosEventList["+ i +"].UnBlackholeTime");

				describeDdosEventListResponse_ddosEventList.Add(ddosEvent);
			}
			describeDdosEventListResponse.DdosEventList = describeDdosEventListResponse_ddosEventList;
        
			return describeDdosEventListResponse;
        }
    }
}
