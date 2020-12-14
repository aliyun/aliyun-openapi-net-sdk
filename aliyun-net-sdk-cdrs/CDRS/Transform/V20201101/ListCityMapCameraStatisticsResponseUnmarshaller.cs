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
    public class ListCityMapCameraStatisticsResponseUnmarshaller
    {
        public static ListCityMapCameraStatisticsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListCityMapCameraStatisticsResponse listCityMapCameraStatisticsResponse = new ListCityMapCameraStatisticsResponse();

			listCityMapCameraStatisticsResponse.HttpResponse = _ctx.HttpResponse;
			listCityMapCameraStatisticsResponse.Code = _ctx.StringValue("ListCityMapCameraStatistics.Code");
			listCityMapCameraStatisticsResponse.Message = _ctx.StringValue("ListCityMapCameraStatistics.Message");
			listCityMapCameraStatisticsResponse.RequestId = _ctx.StringValue("ListCityMapCameraStatistics.RequestId");
			listCityMapCameraStatisticsResponse.PageNumber = _ctx.LongValue("ListCityMapCameraStatistics.PageNumber");
			listCityMapCameraStatisticsResponse.PageSize = _ctx.LongValue("ListCityMapCameraStatistics.PageSize");
			listCityMapCameraStatisticsResponse.TotalCount = _ctx.LongValue("ListCityMapCameraStatistics.TotalCount");

			List<ListCityMapCameraStatisticsResponse.ListCityMapCameraStatistics_Datas> listCityMapCameraStatisticsResponse_data = new List<ListCityMapCameraStatisticsResponse.ListCityMapCameraStatistics_Datas>();
			for (int i = 0; i < _ctx.Length("ListCityMapCameraStatistics.Data.Length"); i++) {
				ListCityMapCameraStatisticsResponse.ListCityMapCameraStatistics_Datas datas = new ListCityMapCameraStatisticsResponse.ListCityMapCameraStatistics_Datas();
				datas.DataSourceId = _ctx.StringValue("ListCityMapCameraStatistics.Data["+ i +"].DataSourceId");
				datas.Latitude = _ctx.StringValue("ListCityMapCameraStatistics.Data["+ i +"].Latitude");
				datas.Longitude = _ctx.StringValue("ListCityMapCameraStatistics.Data["+ i +"].Longitude");
				datas.DataSourceName = _ctx.StringValue("ListCityMapCameraStatistics.Data["+ i +"].DataSourceName");
				datas.CorpId = _ctx.StringValue("ListCityMapCameraStatistics.Data["+ i +"].CorpId");
				datas.AdultValue = _ctx.StringValue("ListCityMapCameraStatistics.Data["+ i +"].AdultValue");
				datas.WomanValue = _ctx.StringValue("ListCityMapCameraStatistics.Data["+ i +"].WomanValue");
				datas.MotorValue = _ctx.StringValue("ListCityMapCameraStatistics.Data["+ i +"].MotorValue");
				datas.ManValue = _ctx.StringValue("ListCityMapCameraStatistics.Data["+ i +"].ManValue");
				datas.OldValue = _ctx.StringValue("ListCityMapCameraStatistics.Data["+ i +"].OldValue");
				datas.ChildValue = _ctx.StringValue("ListCityMapCameraStatistics.Data["+ i +"].ChildValue");
				datas.StatisticTime = _ctx.StringValue("ListCityMapCameraStatistics.Data["+ i +"].StatisticTime");

				listCityMapCameraStatisticsResponse_data.Add(datas);
			}
			listCityMapCameraStatisticsResponse.Data = listCityMapCameraStatisticsResponse_data;
        
			return listCityMapCameraStatisticsResponse;
        }
    }
}
