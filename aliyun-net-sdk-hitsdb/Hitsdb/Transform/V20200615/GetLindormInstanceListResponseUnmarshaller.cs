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
using Aliyun.Acs.hitsdb.Model.V20200615;

namespace Aliyun.Acs.hitsdb.Transform.V20200615
{
    public class GetLindormInstanceListResponseUnmarshaller
    {
        public static GetLindormInstanceListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetLindormInstanceListResponse getLindormInstanceListResponse = new GetLindormInstanceListResponse();

			getLindormInstanceListResponse.HttpResponse = _ctx.HttpResponse;
			getLindormInstanceListResponse.RequestId = _ctx.StringValue("GetLindormInstanceList.RequestId");
			getLindormInstanceListResponse.PageNumber = _ctx.IntegerValue("GetLindormInstanceList.PageNumber");
			getLindormInstanceListResponse.PageSize = _ctx.IntegerValue("GetLindormInstanceList.PageSize");
			getLindormInstanceListResponse.Total = _ctx.IntegerValue("GetLindormInstanceList.Total");

			List<GetLindormInstanceListResponse.GetLindormInstanceList_LindormInstanceSummary> getLindormInstanceListResponse_instanceList = new List<GetLindormInstanceListResponse.GetLindormInstanceList_LindormInstanceSummary>();
			for (int i = 0; i < _ctx.Length("GetLindormInstanceList.InstanceList.Length"); i++) {
				GetLindormInstanceListResponse.GetLindormInstanceList_LindormInstanceSummary lindormInstanceSummary = new GetLindormInstanceListResponse.GetLindormInstanceList_LindormInstanceSummary();
				lindormInstanceSummary.InstanceId = _ctx.StringValue("GetLindormInstanceList.InstanceList["+ i +"].InstanceId");
				lindormInstanceSummary.InstanceAlias = _ctx.StringValue("GetLindormInstanceList.InstanceList["+ i +"].InstanceAlias");
				lindormInstanceSummary.RegionId = _ctx.StringValue("GetLindormInstanceList.InstanceList["+ i +"].RegionId");
				lindormInstanceSummary.ZoneId = _ctx.StringValue("GetLindormInstanceList.InstanceList["+ i +"].ZoneId");
				lindormInstanceSummary.InstanceStatus = _ctx.StringValue("GetLindormInstanceList.InstanceList["+ i +"].InstanceStatus");
				lindormInstanceSummary.PayType = _ctx.StringValue("GetLindormInstanceList.InstanceList["+ i +"].PayType");
				lindormInstanceSummary.NetworkType = _ctx.StringValue("GetLindormInstanceList.InstanceList["+ i +"].NetworkType");
				lindormInstanceSummary.CreateTime = _ctx.StringValue("GetLindormInstanceList.InstanceList["+ i +"].CreateTime");
				lindormInstanceSummary.ExpireTime = _ctx.StringValue("GetLindormInstanceList.InstanceList["+ i +"].ExpireTime");
				lindormInstanceSummary.InstanceStorage = _ctx.StringValue("GetLindormInstanceList.InstanceList["+ i +"].InstanceStorage");
				lindormInstanceSummary.ServiceType = _ctx.StringValue("GetLindormInstanceList.InstanceList["+ i +"].ServiceType");
				lindormInstanceSummary.EngineType = _ctx.StringValue("GetLindormInstanceList.InstanceList["+ i +"].EngineType");
				lindormInstanceSummary.AliUid = _ctx.LongValue("GetLindormInstanceList.InstanceList["+ i +"].AliUid");
				lindormInstanceSummary.VpcId = _ctx.StringValue("GetLindormInstanceList.InstanceList["+ i +"].VpcId");
				lindormInstanceSummary.CreateMilliseconds = _ctx.LongValue("GetLindormInstanceList.InstanceList["+ i +"].CreateMilliseconds");
				lindormInstanceSummary.ExpiredMilliseconds = _ctx.LongValue("GetLindormInstanceList.InstanceList["+ i +"].ExpiredMilliseconds");

				getLindormInstanceListResponse_instanceList.Add(lindormInstanceSummary);
			}
			getLindormInstanceListResponse.InstanceList = getLindormInstanceListResponse_instanceList;
        
			return getLindormInstanceListResponse;
        }
    }
}
