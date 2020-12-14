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
    public class ListCityMapRangeStatisticResponseUnmarshaller
    {
        public static ListCityMapRangeStatisticResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListCityMapRangeStatisticResponse listCityMapRangeStatisticResponse = new ListCityMapRangeStatisticResponse();

			listCityMapRangeStatisticResponse.HttpResponse = _ctx.HttpResponse;
			listCityMapRangeStatisticResponse.Code = _ctx.StringValue("ListCityMapRangeStatistic.Code");
			listCityMapRangeStatisticResponse.Message = _ctx.StringValue("ListCityMapRangeStatistic.Message");
			listCityMapRangeStatisticResponse.RequestId = _ctx.StringValue("ListCityMapRangeStatistic.RequestId");
			listCityMapRangeStatisticResponse.PageNumber = _ctx.LongValue("ListCityMapRangeStatistic.PageNumber");
			listCityMapRangeStatisticResponse.PageSize = _ctx.LongValue("ListCityMapRangeStatistic.PageSize");
			listCityMapRangeStatisticResponse.TotalCount = _ctx.LongValue("ListCityMapRangeStatistic.TotalCount");

			List<ListCityMapRangeStatisticResponse.ListCityMapRangeStatistic_Datas> listCityMapRangeStatisticResponse_data = new List<ListCityMapRangeStatisticResponse.ListCityMapRangeStatistic_Datas>();
			for (int i = 0; i < _ctx.Length("ListCityMapRangeStatistic.Data.Length"); i++) {
				ListCityMapRangeStatisticResponse.ListCityMapRangeStatistic_Datas datas = new ListCityMapRangeStatisticResponse.ListCityMapRangeStatistic_Datas();
				datas.DataSourceId = _ctx.StringValue("ListCityMapRangeStatistic.Data["+ i +"].DataSourceId");
				datas.Latitude = _ctx.StringValue("ListCityMapRangeStatistic.Data["+ i +"].Latitude");
				datas.Longitude = _ctx.StringValue("ListCityMapRangeStatistic.Data["+ i +"].Longitude");
				datas.DataSourceName = _ctx.StringValue("ListCityMapRangeStatistic.Data["+ i +"].DataSourceName");
				datas.CorpId = _ctx.StringValue("ListCityMapRangeStatistic.Data["+ i +"].CorpId");
				datas.AdultValue = _ctx.StringValue("ListCityMapRangeStatistic.Data["+ i +"].AdultValue");
				datas.WomanValue = _ctx.StringValue("ListCityMapRangeStatistic.Data["+ i +"].WomanValue");
				datas.MotorValue = _ctx.StringValue("ListCityMapRangeStatistic.Data["+ i +"].MotorValue");
				datas.ManValue = _ctx.StringValue("ListCityMapRangeStatistic.Data["+ i +"].ManValue");
				datas.OldValue = _ctx.StringValue("ListCityMapRangeStatistic.Data["+ i +"].OldValue");
				datas.ChildValue = _ctx.StringValue("ListCityMapRangeStatistic.Data["+ i +"].ChildValue");

				listCityMapRangeStatisticResponse_data.Add(datas);
			}
			listCityMapRangeStatisticResponse.Data = listCityMapRangeStatisticResponse_data;
        
			return listCityMapRangeStatisticResponse;
        }
    }
}
