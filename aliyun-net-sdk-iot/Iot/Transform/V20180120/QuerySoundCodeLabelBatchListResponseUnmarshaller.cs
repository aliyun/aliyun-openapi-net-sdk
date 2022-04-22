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
using Aliyun.Acs.Iot.Model.V20180120;

namespace Aliyun.Acs.Iot.Transform.V20180120
{
    public class QuerySoundCodeLabelBatchListResponseUnmarshaller
    {
        public static QuerySoundCodeLabelBatchListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QuerySoundCodeLabelBatchListResponse querySoundCodeLabelBatchListResponse = new QuerySoundCodeLabelBatchListResponse();

			querySoundCodeLabelBatchListResponse.HttpResponse = _ctx.HttpResponse;
			querySoundCodeLabelBatchListResponse.RequestId = _ctx.StringValue("QuerySoundCodeLabelBatchList.RequestId");
			querySoundCodeLabelBatchListResponse.Success = _ctx.BooleanValue("QuerySoundCodeLabelBatchList.Success");
			querySoundCodeLabelBatchListResponse.Code = _ctx.StringValue("QuerySoundCodeLabelBatchList.Code");
			querySoundCodeLabelBatchListResponse.ErrorMessage = _ctx.StringValue("QuerySoundCodeLabelBatchList.ErrorMessage");

			QuerySoundCodeLabelBatchListResponse.QuerySoundCodeLabelBatchList_Data data = new QuerySoundCodeLabelBatchListResponse.QuerySoundCodeLabelBatchList_Data();
			data.Total = _ctx.IntegerValue("QuerySoundCodeLabelBatchList.Data.Total");
			data.PageId = _ctx.IntegerValue("QuerySoundCodeLabelBatchList.Data.PageId");
			data.PageSize = _ctx.IntegerValue("QuerySoundCodeLabelBatchList.Data.PageSize");

			List<QuerySoundCodeLabelBatchListResponse.QuerySoundCodeLabelBatchList_Data.QuerySoundCodeLabelBatchList_Items> data_list = new List<QuerySoundCodeLabelBatchListResponse.QuerySoundCodeLabelBatchList_Data.QuerySoundCodeLabelBatchList_Items>();
			for (int i = 0; i < _ctx.Length("QuerySoundCodeLabelBatchList.Data.List.Length"); i++) {
				QuerySoundCodeLabelBatchListResponse.QuerySoundCodeLabelBatchList_Data.QuerySoundCodeLabelBatchList_Items items = new QuerySoundCodeLabelBatchListResponse.QuerySoundCodeLabelBatchList_Data.QuerySoundCodeLabelBatchList_Items();
				items.BatchCode = _ctx.StringValue("QuerySoundCodeLabelBatchList.Data.List["+ i +"].BatchCode");
				items.Description = _ctx.StringValue("QuerySoundCodeLabelBatchList.Data.List["+ i +"].Description");
				items.Total = _ctx.IntegerValue("QuerySoundCodeLabelBatchList.Data.List["+ i +"].Total");
				items.SuccessNum = _ctx.IntegerValue("QuerySoundCodeLabelBatchList.Data.List["+ i +"].SuccessNum");
				items.Status = _ctx.StringValue("QuerySoundCodeLabelBatchList.Data.List["+ i +"].Status");
				items.GmtCreate = _ctx.LongValue("QuerySoundCodeLabelBatchList.Data.List["+ i +"].GmtCreate");

				data_list.Add(items);
			}
			data.List = data_list;
			querySoundCodeLabelBatchListResponse.Data = data;
        
			return querySoundCodeLabelBatchListResponse;
        }
    }
}
