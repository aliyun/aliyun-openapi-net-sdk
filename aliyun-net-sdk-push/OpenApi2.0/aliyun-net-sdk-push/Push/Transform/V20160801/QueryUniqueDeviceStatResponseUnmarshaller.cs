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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Push.Model.V20160801;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Push.Transform.V20160801
{
    public class QueryUniqueDeviceStatResponseUnmarshaller
    {
        public static QueryUniqueDeviceStatResponse Unmarshall(UnmarshallerContext context)
        {
			QueryUniqueDeviceStatResponse queryUniqueDeviceStatResponse = new QueryUniqueDeviceStatResponse();

			queryUniqueDeviceStatResponse.HttpResponse = context.HttpResponse;
			queryUniqueDeviceStatResponse.RequestId = context.StringValue("QueryUniqueDeviceStat.RequestId");

			List<QueryUniqueDeviceStatResponse.AppDeviceStat> appDeviceStats = new List<QueryUniqueDeviceStatResponse.AppDeviceStat>();
			for (int i = 0; i < context.Length("QueryUniqueDeviceStat.AppDeviceStats.Length"); i++) {
				QueryUniqueDeviceStatResponse.AppDeviceStat appDeviceStat = new QueryUniqueDeviceStatResponse.AppDeviceStat();
				appDeviceStat.Time = context.StringValue("QueryUniqueDeviceStat.AppDeviceStats["+ i +"].Time");
				appDeviceStat.Count = context.LongValue("QueryUniqueDeviceStat.AppDeviceStats["+ i +"].Count");

				appDeviceStats.Add(appDeviceStat);
			}
			queryUniqueDeviceStatResponse.AppDeviceStats = appDeviceStats;
        
			return queryUniqueDeviceStatResponse;
        }
    }
}