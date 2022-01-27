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
    public class ListStructureStatisticsResponseUnmarshaller
    {
        public static ListStructureStatisticsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListStructureStatisticsResponse listStructureStatisticsResponse = new ListStructureStatisticsResponse();

			listStructureStatisticsResponse.HttpResponse = _ctx.HttpResponse;
			listStructureStatisticsResponse.Code = _ctx.StringValue("ListStructureStatistics.Code");
			listStructureStatisticsResponse.Message = _ctx.StringValue("ListStructureStatistics.Message");
			listStructureStatisticsResponse.RequestId = _ctx.StringValue("ListStructureStatistics.RequestId");
			listStructureStatisticsResponse.PageNumber = _ctx.LongValue("ListStructureStatistics.PageNumber");
			listStructureStatisticsResponse.PageSize = _ctx.LongValue("ListStructureStatistics.PageSize");
			listStructureStatisticsResponse.TotalCount = _ctx.LongValue("ListStructureStatistics.TotalCount");

			List<ListStructureStatisticsResponse.ListStructureStatistics_Datas> listStructureStatisticsResponse_data = new List<ListStructureStatisticsResponse.ListStructureStatistics_Datas>();
			for (int i = 0; i < _ctx.Length("ListStructureStatistics.Data.Length"); i++) {
				ListStructureStatisticsResponse.ListStructureStatistics_Datas datas = new ListStructureStatisticsResponse.ListStructureStatistics_Datas();
				datas.Number = _ctx.StringValue("ListStructureStatistics.Data["+ i +"].Number");
				datas.CorpId = _ctx.StringValue("ListStructureStatistics.Data["+ i +"].CorpId");

				listStructureStatisticsResponse_data.Add(datas);
			}
			listStructureStatisticsResponse.Data = listStructureStatisticsResponse_data;
        
			return listStructureStatisticsResponse;
        }
    }
}
