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
using Aliyun.Acs.dataworks_public.Model.V20200518;

namespace Aliyun.Acs.dataworks_public.Transform.V20200518
{
    public class GetInstanceCountTrendResponseUnmarshaller
    {
        public static GetInstanceCountTrendResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetInstanceCountTrendResponse getInstanceCountTrendResponse = new GetInstanceCountTrendResponse();

			getInstanceCountTrendResponse.HttpResponse = _ctx.HttpResponse;
			getInstanceCountTrendResponse.RequestId = _ctx.StringValue("GetInstanceCountTrend.RequestId");

			List<GetInstanceCountTrendResponse.GetInstanceCountTrend_IntanceCounts> getInstanceCountTrendResponse_instanceCounts = new List<GetInstanceCountTrendResponse.GetInstanceCountTrend_IntanceCounts>();
			for (int i = 0; i < _ctx.Length("GetInstanceCountTrend.InstanceCounts.Length"); i++) {
				GetInstanceCountTrendResponse.GetInstanceCountTrend_IntanceCounts intanceCounts = new GetInstanceCountTrendResponse.GetInstanceCountTrend_IntanceCounts();
				intanceCounts.Date = _ctx.LongValue("GetInstanceCountTrend.InstanceCounts["+ i +"].Date");
				intanceCounts.Count = _ctx.IntegerValue("GetInstanceCountTrend.InstanceCounts["+ i +"].Count");

				getInstanceCountTrendResponse_instanceCounts.Add(intanceCounts);
			}
			getInstanceCountTrendResponse.InstanceCounts = getInstanceCountTrendResponse_instanceCounts;
        
			return getInstanceCountTrendResponse;
        }
    }
}
