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
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class ListUserStatisticsResponseUnmarshaller
    {
        public static ListUserStatisticsResponse Unmarshall(UnmarshallerContext context)
        {
			ListUserStatisticsResponse listUserStatisticsResponse = new ListUserStatisticsResponse();

			listUserStatisticsResponse.HttpResponse = context.HttpResponse;
			listUserStatisticsResponse.Total = context.LongValue("ListUserStatistics.Total");

			List<ListUserStatisticsResponse.ListUserStatistics_UserStatistics> listUserStatisticsResponse_userStatisticsList = new List<ListUserStatisticsResponse.ListUserStatistics_UserStatistics>();
			for (int i = 0; i < context.Length("ListUserStatistics.UserStatisticsList.Length"); i++) {
				ListUserStatisticsResponse.ListUserStatistics_UserStatistics userStatistics = new ListUserStatisticsResponse.ListUserStatistics_UserStatistics();
				userStatistics.Id = context.LongValue("ListUserStatistics.UserStatisticsList["+ i +"].Id");
				userStatistics.UserId = context.StringValue("ListUserStatistics.UserStatisticsList["+ i +"].UserId");
				userStatistics.JobNum = context.IntegerValue("ListUserStatistics.UserStatisticsList["+ i +"].JobNum");
				userStatistics.ExecutePlanNum = context.IntegerValue("ListUserStatistics.UserStatisticsList["+ i +"].ExecutePlanNum");
				userStatistics.InteractionJobNum = context.IntegerValue("ListUserStatistics.UserStatisticsList["+ i +"].InteractionJobNum");
				userStatistics.JobMigratedNum = context.IntegerValue("ListUserStatistics.UserStatisticsList["+ i +"].JobMigratedNum");
				userStatistics.ExecutePlanMigratedNum = context.IntegerValue("ListUserStatistics.UserStatisticsList["+ i +"].ExecutePlanMigratedNum");
				userStatistics.InteractionJobMigratedNum = context.IntegerValue("ListUserStatistics.UserStatisticsList["+ i +"].InteractionJobMigratedNum");

				listUserStatisticsResponse_userStatisticsList.Add(userStatistics);
			}
			listUserStatisticsResponse.UserStatisticsList = listUserStatisticsResponse_userStatisticsList;
        
			return listUserStatisticsResponse;
        }
    }
}
