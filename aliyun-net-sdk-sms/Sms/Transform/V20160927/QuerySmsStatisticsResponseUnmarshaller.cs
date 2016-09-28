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
using Aliyun.Acs.Sms.Model.V20160927;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Sms.Transform.V20160927
{
    public class QuerySmsStatisticsResponseUnmarshaller
    {
        public static QuerySmsStatisticsResponse Unmarshall(UnmarshallerContext context)
        {
			QuerySmsStatisticsResponse querySmsStatisticsResponse = new QuerySmsStatisticsResponse();

			querySmsStatisticsResponse.HttpResponse = context.HttpResponse;
			querySmsStatisticsResponse.RequestId = context.StringValue("QuerySmsStatistics.RequestId");
			querySmsStatisticsResponse.TotalCount = context.IntegerValue("QuerySmsStatistics.TotalCount");

			List<QuerySmsStatisticsResponse.stat> data = new List<QuerySmsStatisticsResponse.stat>();
			for (int i = 0; i < context.Length("QuerySmsStatistics.data.Length"); i++) {
				QuerySmsStatisticsResponse.stat stat = new QuerySmsStatisticsResponse.stat();
				stat.CreateTime = context.StringValue("QuerySmsStatistics.data["+ i +"].CreateTime");
				stat.RequestCount = context.StringValue("QuerySmsStatistics.data["+ i +"].requestCount");
				stat.SuccessCount = context.StringValue("QuerySmsStatistics.data["+ i +"].successCount");
				stat.FaildCount = context.StringValue("QuerySmsStatistics.data["+ i +"].faildCount");

				data.Add(stat);
			}
			querySmsStatisticsResponse.Data = data;
        
			return querySmsStatisticsResponse;
        }
    }
}