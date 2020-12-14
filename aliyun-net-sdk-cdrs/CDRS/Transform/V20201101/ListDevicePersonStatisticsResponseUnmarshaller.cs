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
using Aliyun.Acs.CDRS.Model.V20201101;

namespace Aliyun.Acs.CDRS.Transform.V20201101
{
    public class ListDevicePersonStatisticsResponseUnmarshaller
    {
        public static ListDevicePersonStatisticsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDevicePersonStatisticsResponse listDevicePersonStatisticsResponse = new ListDevicePersonStatisticsResponse();

			listDevicePersonStatisticsResponse.HttpResponse = _ctx.HttpResponse;
			listDevicePersonStatisticsResponse.Code = _ctx.StringValue("ListDevicePersonStatistics.Code");
			listDevicePersonStatisticsResponse.Message = _ctx.StringValue("ListDevicePersonStatistics.Message");
			listDevicePersonStatisticsResponse.RequestId = _ctx.StringValue("ListDevicePersonStatistics.RequestId");
			listDevicePersonStatisticsResponse.TotalCount = _ctx.LongValue("ListDevicePersonStatistics.TotalCount");

			List<ListDevicePersonStatisticsResponse.ListDevicePersonStatistics_Datas> listDevicePersonStatisticsResponse_data = new List<ListDevicePersonStatisticsResponse.ListDevicePersonStatistics_Datas>();
			for (int i = 0; i < _ctx.Length("ListDevicePersonStatistics.Data.Length"); i++) {
				ListDevicePersonStatisticsResponse.ListDevicePersonStatistics_Datas datas = new ListDevicePersonStatisticsResponse.ListDevicePersonStatistics_Datas();
				datas.DataSourceId = _ctx.StringValue("ListDevicePersonStatistics.Data["+ i +"].DataSourceId");
				datas.ShotTime = _ctx.StringValue("ListDevicePersonStatistics.Data["+ i +"].ShotTime");
				datas.Number = _ctx.StringValue("ListDevicePersonStatistics.Data["+ i +"].Number");

				listDevicePersonStatisticsResponse_data.Add(datas);
			}
			listDevicePersonStatisticsResponse.Data = listDevicePersonStatisticsResponse_data;
        
			return listDevicePersonStatisticsResponse;
        }
    }
}
