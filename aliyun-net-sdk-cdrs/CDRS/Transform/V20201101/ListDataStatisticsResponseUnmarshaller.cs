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
    public class ListDataStatisticsResponseUnmarshaller
    {
        public static ListDataStatisticsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDataStatisticsResponse listDataStatisticsResponse = new ListDataStatisticsResponse();

			listDataStatisticsResponse.HttpResponse = _ctx.HttpResponse;
			listDataStatisticsResponse.Code = _ctx.StringValue("ListDataStatistics.Code");
			listDataStatisticsResponse.Message = _ctx.StringValue("ListDataStatistics.Message");
			listDataStatisticsResponse.RequestId = _ctx.StringValue("ListDataStatistics.RequestId");
			listDataStatisticsResponse.PageNumber = _ctx.LongValue("ListDataStatistics.PageNumber");
			listDataStatisticsResponse.PageSize = _ctx.LongValue("ListDataStatistics.PageSize");
			listDataStatisticsResponse.TotalCount = _ctx.LongValue("ListDataStatistics.TotalCount");

			List<ListDataStatisticsResponse.ListDataStatistics_Datas> listDataStatisticsResponse_data = new List<ListDataStatisticsResponse.ListDataStatistics_Datas>();
			for (int i = 0; i < _ctx.Length("ListDataStatistics.Data.Length"); i++) {
				ListDataStatisticsResponse.ListDataStatistics_Datas datas = new ListDataStatisticsResponse.ListDataStatistics_Datas();
				datas.CorpId = _ctx.StringValue("ListDataStatistics.Data["+ i +"].CorpId");
				datas.Number = _ctx.StringValue("ListDataStatistics.Data["+ i +"].Number");

				listDataStatisticsResponse_data.Add(datas);
			}
			listDataStatisticsResponse.Data = listDataStatisticsResponse_data;
        
			return listDataStatisticsResponse;
        }
    }
}
