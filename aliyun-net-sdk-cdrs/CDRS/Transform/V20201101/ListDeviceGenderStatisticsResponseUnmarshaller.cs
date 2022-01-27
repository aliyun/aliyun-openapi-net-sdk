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
    public class ListDeviceGenderStatisticsResponseUnmarshaller
    {
        public static ListDeviceGenderStatisticsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDeviceGenderStatisticsResponse listDeviceGenderStatisticsResponse = new ListDeviceGenderStatisticsResponse();

			listDeviceGenderStatisticsResponse.HttpResponse = _ctx.HttpResponse;
			listDeviceGenderStatisticsResponse.Code = _ctx.StringValue("ListDeviceGenderStatistics.Code");
			listDeviceGenderStatisticsResponse.Message = _ctx.StringValue("ListDeviceGenderStatistics.Message");
			listDeviceGenderStatisticsResponse.RequestId = _ctx.StringValue("ListDeviceGenderStatistics.RequestId");
			listDeviceGenderStatisticsResponse.TotalCount = _ctx.LongValue("ListDeviceGenderStatistics.TotalCount");

			List<ListDeviceGenderStatisticsResponse.ListDeviceGenderStatistics_Datas> listDeviceGenderStatisticsResponse_data = new List<ListDeviceGenderStatisticsResponse.ListDeviceGenderStatistics_Datas>();
			for (int i = 0; i < _ctx.Length("ListDeviceGenderStatistics.Data.Length"); i++) {
				ListDeviceGenderStatisticsResponse.ListDeviceGenderStatistics_Datas datas = new ListDeviceGenderStatisticsResponse.ListDeviceGenderStatistics_Datas();
				datas.DataSourceId = _ctx.StringValue("ListDeviceGenderStatistics.Data["+ i +"].DataSourceId");
				datas.Gender = _ctx.StringValue("ListDeviceGenderStatistics.Data["+ i +"].Gender");
				datas.Number = _ctx.StringValue("ListDeviceGenderStatistics.Data["+ i +"].Number");

				listDeviceGenderStatisticsResponse_data.Add(datas);
			}
			listDeviceGenderStatisticsResponse.Data = listDeviceGenderStatisticsResponse_data;
        
			return listDeviceGenderStatisticsResponse;
        }
    }
}
