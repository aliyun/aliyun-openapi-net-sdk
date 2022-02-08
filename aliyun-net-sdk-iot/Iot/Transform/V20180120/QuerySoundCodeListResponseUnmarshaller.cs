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
    public class QuerySoundCodeListResponseUnmarshaller
    {
        public static QuerySoundCodeListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QuerySoundCodeListResponse querySoundCodeListResponse = new QuerySoundCodeListResponse();

			querySoundCodeListResponse.HttpResponse = _ctx.HttpResponse;
			querySoundCodeListResponse.RequestId = _ctx.StringValue("QuerySoundCodeList.RequestId");
			querySoundCodeListResponse.Success = _ctx.BooleanValue("QuerySoundCodeList.Success");
			querySoundCodeListResponse.Code = _ctx.StringValue("QuerySoundCodeList.Code");
			querySoundCodeListResponse.ErrorMessage = _ctx.StringValue("QuerySoundCodeList.ErrorMessage");

			QuerySoundCodeListResponse.QuerySoundCodeList_Data data = new QuerySoundCodeListResponse.QuerySoundCodeList_Data();
			data.Total = _ctx.IntegerValue("QuerySoundCodeList.Data.Total");
			data.PageId = _ctx.IntegerValue("QuerySoundCodeList.Data.PageId");
			data.PageSize = _ctx.IntegerValue("QuerySoundCodeList.Data.PageSize");

			List<QuerySoundCodeListResponse.QuerySoundCodeList_Data.QuerySoundCodeList_Items> data_list = new List<QuerySoundCodeListResponse.QuerySoundCodeList_Data.QuerySoundCodeList_Items>();
			for (int i = 0; i < _ctx.Length("QuerySoundCodeList.Data.List.Length"); i++) {
				QuerySoundCodeListResponse.QuerySoundCodeList_Data.QuerySoundCodeList_Items items = new QuerySoundCodeListResponse.QuerySoundCodeList_Data.QuerySoundCodeList_Items();
				items.SoundCode = _ctx.StringValue("QuerySoundCodeList.Data.List["+ i +"].SoundCode");
				items.SoundCodeContent = _ctx.StringValue("QuerySoundCodeList.Data.List["+ i +"].SoundCodeContent");
				items.Duration = _ctx.IntegerValue("QuerySoundCodeList.Data.List["+ i +"].Duration");
				items.GmtCreate = _ctx.LongValue("QuerySoundCodeList.Data.List["+ i +"].GmtCreate");

				data_list.Add(items);
			}
			data.List = data_list;
			querySoundCodeListResponse.Data = data;
        
			return querySoundCodeListResponse;
        }
    }
}
