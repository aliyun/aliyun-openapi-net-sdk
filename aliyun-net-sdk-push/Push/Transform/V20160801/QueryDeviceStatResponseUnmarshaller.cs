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
using Aliyun.Acs.Push.Model.V20160801;

namespace Aliyun.Acs.Push.Transform.V20160801
{
    public class QueryDeviceStatResponseUnmarshaller
    {
        public static QueryDeviceStatResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryDeviceStatResponse queryDeviceStatResponse = new QueryDeviceStatResponse();

			queryDeviceStatResponse.HttpResponse = _ctx.HttpResponse;
			queryDeviceStatResponse.RequestId = _ctx.StringValue("QueryDeviceStat.RequestId");

			List<QueryDeviceStatResponse.QueryDeviceStat_AppDeviceStat> queryDeviceStatResponse_appDeviceStats = new List<QueryDeviceStatResponse.QueryDeviceStat_AppDeviceStat>();
			for (int i = 0; i < _ctx.Length("QueryDeviceStat.AppDeviceStats.Length"); i++) {
				QueryDeviceStatResponse.QueryDeviceStat_AppDeviceStat appDeviceStat = new QueryDeviceStatResponse.QueryDeviceStat_AppDeviceStat();
				appDeviceStat.Count = _ctx.LongValue("QueryDeviceStat.AppDeviceStats["+ i +"].Count");
				appDeviceStat.DeviceType = _ctx.StringValue("QueryDeviceStat.AppDeviceStats["+ i +"].DeviceType");
				appDeviceStat.Time = _ctx.StringValue("QueryDeviceStat.AppDeviceStats["+ i +"].Time");

				queryDeviceStatResponse_appDeviceStats.Add(appDeviceStat);
			}
			queryDeviceStatResponse.AppDeviceStats = queryDeviceStatResponse_appDeviceStats;
        
			return queryDeviceStatResponse;
        }
    }
}
