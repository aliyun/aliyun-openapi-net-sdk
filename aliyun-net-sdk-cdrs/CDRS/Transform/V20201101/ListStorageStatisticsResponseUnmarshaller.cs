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
    public class ListStorageStatisticsResponseUnmarshaller
    {
        public static ListStorageStatisticsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListStorageStatisticsResponse listStorageStatisticsResponse = new ListStorageStatisticsResponse();

			listStorageStatisticsResponse.HttpResponse = _ctx.HttpResponse;
			listStorageStatisticsResponse.Code = _ctx.StringValue("ListStorageStatistics.Code");
			listStorageStatisticsResponse.Message = _ctx.StringValue("ListStorageStatistics.Message");
			listStorageStatisticsResponse.RequestId = _ctx.StringValue("ListStorageStatistics.RequestId");
			listStorageStatisticsResponse.TotalCount = _ctx.LongValue("ListStorageStatistics.TotalCount");

			List<ListStorageStatisticsResponse.ListStorageStatistics_Datas> listStorageStatisticsResponse_data = new List<ListStorageStatisticsResponse.ListStorageStatistics_Datas>();
			for (int i = 0; i < _ctx.Length("ListStorageStatistics.Data.Length"); i++) {
				ListStorageStatisticsResponse.ListStorageStatistics_Datas datas = new ListStorageStatisticsResponse.ListStorageStatistics_Datas();
				datas.CorpId = _ctx.StringValue("ListStorageStatistics.Data["+ i +"].CorpId");
				datas.Number = _ctx.StringValue("ListStorageStatistics.Data["+ i +"].Number");
				datas.TotalStore = _ctx.StringValue("ListStorageStatistics.Data["+ i +"].TotalStore");
				datas.UnusedStore = _ctx.StringValue("ListStorageStatistics.Data["+ i +"].UnusedStore");
				datas.UsedStore = _ctx.StringValue("ListStorageStatistics.Data["+ i +"].UsedStore");

				listStorageStatisticsResponse_data.Add(datas);
			}
			listStorageStatisticsResponse.Data = listStorageStatisticsResponse_data;
        
			return listStorageStatisticsResponse;
        }
    }
}
