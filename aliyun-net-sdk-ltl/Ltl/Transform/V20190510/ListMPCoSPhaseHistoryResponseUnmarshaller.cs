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
using Aliyun.Acs.ltl.Model.V20190510;

namespace Aliyun.Acs.ltl.Transform.V20190510
{
    public class ListMPCoSPhaseHistoryResponseUnmarshaller
    {
        public static ListMPCoSPhaseHistoryResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListMPCoSPhaseHistoryResponse listMPCoSPhaseHistoryResponse = new ListMPCoSPhaseHistoryResponse();

			listMPCoSPhaseHistoryResponse.HttpResponse = _ctx.HttpResponse;
			listMPCoSPhaseHistoryResponse.Code = _ctx.IntegerValue("ListMPCoSPhaseHistory.Code");
			listMPCoSPhaseHistoryResponse.Message = _ctx.StringValue("ListMPCoSPhaseHistory.Message");
			listMPCoSPhaseHistoryResponse.RequestId = _ctx.StringValue("ListMPCoSPhaseHistory.RequestId");
			listMPCoSPhaseHistoryResponse.Success = _ctx.BooleanValue("ListMPCoSPhaseHistory.Success");

			ListMPCoSPhaseHistoryResponse.ListMPCoSPhaseHistory_Data data = new ListMPCoSPhaseHistoryResponse.ListMPCoSPhaseHistory_Data();
			data.Num = _ctx.IntegerValue("ListMPCoSPhaseHistory.Data.Num");
			data.Total = _ctx.IntegerValue("ListMPCoSPhaseHistory.Data.Total");
			data.Size = _ctx.IntegerValue("ListMPCoSPhaseHistory.Data.Size");

			List<ListMPCoSPhaseHistoryResponse.ListMPCoSPhaseHistory_Data.ListMPCoSPhaseHistory_HistoryDataInfo> data_pageData = new List<ListMPCoSPhaseHistoryResponse.ListMPCoSPhaseHistory_Data.ListMPCoSPhaseHistory_HistoryDataInfo>();
			for (int i = 0; i < _ctx.Length("ListMPCoSPhaseHistory.Data.PageData.Length"); i++) {
				ListMPCoSPhaseHistoryResponse.ListMPCoSPhaseHistory_Data.ListMPCoSPhaseHistory_HistoryDataInfo historyDataInfo = new ListMPCoSPhaseHistoryResponse.ListMPCoSPhaseHistory_Data.ListMPCoSPhaseHistory_HistoryDataInfo();
				historyDataInfo.ProductKey = _ctx.StringValue("ListMPCoSPhaseHistory.Data.PageData["+ i +"].ProductKey");
				historyDataInfo.PreviousHash = _ctx.StringValue("ListMPCoSPhaseHistory.Data.PageData["+ i +"].PreviousHash");
				historyDataInfo.DataHash = _ctx.StringValue("ListMPCoSPhaseHistory.Data.PageData["+ i +"].DataHash");
				historyDataInfo.DataSeq = _ctx.StringValue("ListMPCoSPhaseHistory.Data.PageData["+ i +"].DataSeq");
				historyDataInfo.DataValue = _ctx.StringValue("ListMPCoSPhaseHistory.Data.PageData["+ i +"].DataValue");
				historyDataInfo.Timestamp = _ctx.LongValue("ListMPCoSPhaseHistory.Data.PageData["+ i +"].Timestamp");
				historyDataInfo.TransactionHash = _ctx.StringValue("ListMPCoSPhaseHistory.Data.PageData["+ i +"].TransactionHash");
				historyDataInfo.BlockHash = _ctx.StringValue("ListMPCoSPhaseHistory.Data.PageData["+ i +"].BlockHash");
				historyDataInfo.BlockNumber = _ctx.LongValue("ListMPCoSPhaseHistory.Data.PageData["+ i +"].BlockNumber");
				historyDataInfo.IotId = _ctx.StringValue("ListMPCoSPhaseHistory.Data.PageData["+ i +"].IotId");

				data_pageData.Add(historyDataInfo);
			}
			data.PageData = data_pageData;
			listMPCoSPhaseHistoryResponse.Data = data;
        
			return listMPCoSPhaseHistoryResponse;
        }
    }
}
