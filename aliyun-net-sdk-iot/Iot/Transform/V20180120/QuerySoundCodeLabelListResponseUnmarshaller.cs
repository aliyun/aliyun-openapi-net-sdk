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
    public class QuerySoundCodeLabelListResponseUnmarshaller
    {
        public static QuerySoundCodeLabelListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QuerySoundCodeLabelListResponse querySoundCodeLabelListResponse = new QuerySoundCodeLabelListResponse();

			querySoundCodeLabelListResponse.HttpResponse = _ctx.HttpResponse;
			querySoundCodeLabelListResponse.RequestId = _ctx.StringValue("QuerySoundCodeLabelList.RequestId");
			querySoundCodeLabelListResponse.Success = _ctx.BooleanValue("QuerySoundCodeLabelList.Success");
			querySoundCodeLabelListResponse.Code = _ctx.StringValue("QuerySoundCodeLabelList.Code");
			querySoundCodeLabelListResponse.ErrorMessage = _ctx.StringValue("QuerySoundCodeLabelList.ErrorMessage");

			QuerySoundCodeLabelListResponse.QuerySoundCodeLabelList_Data data = new QuerySoundCodeLabelListResponse.QuerySoundCodeLabelList_Data();
			data.Total = _ctx.IntegerValue("QuerySoundCodeLabelList.Data.Total");
			data.PageId = _ctx.IntegerValue("QuerySoundCodeLabelList.Data.PageId");
			data.PageSize = _ctx.IntegerValue("QuerySoundCodeLabelList.Data.PageSize");

			List<QuerySoundCodeLabelListResponse.QuerySoundCodeLabelList_Data.QuerySoundCodeLabelList_Items> data_list = new List<QuerySoundCodeLabelListResponse.QuerySoundCodeLabelList_Data.QuerySoundCodeLabelList_Items>();
			for (int i = 0; i < _ctx.Length("QuerySoundCodeLabelList.Data.List.Length"); i++) {
				QuerySoundCodeLabelListResponse.QuerySoundCodeLabelList_Data.QuerySoundCodeLabelList_Items items = new QuerySoundCodeLabelListResponse.QuerySoundCodeLabelList_Data.QuerySoundCodeLabelList_Items();
				items.SoundCode = _ctx.StringValue("QuerySoundCodeLabelList.Data.List["+ i +"].SoundCode");
				items.Label = _ctx.StringValue("QuerySoundCodeLabelList.Data.List["+ i +"].Label");

				data_list.Add(items);
			}
			data.List = data_list;
			querySoundCodeLabelListResponse.Data = data;
        
			return querySoundCodeLabelListResponse;
        }
    }
}
