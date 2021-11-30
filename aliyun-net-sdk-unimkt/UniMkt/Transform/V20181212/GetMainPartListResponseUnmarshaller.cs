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
using Aliyun.Acs.UniMkt.Model.V20181212;

namespace Aliyun.Acs.UniMkt.Transform.V20181212
{
    public class GetMainPartListResponseUnmarshaller
    {
        public static GetMainPartListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetMainPartListResponse getMainPartListResponse = new GetMainPartListResponse();

			getMainPartListResponse.HttpResponse = _ctx.HttpResponse;
			getMainPartListResponse.Code = _ctx.LongValue("GetMainPartList.Code");
			getMainPartListResponse.Success = _ctx.BooleanValue("GetMainPartList.Success");
			getMainPartListResponse.RequestId = _ctx.StringValue("GetMainPartList.RequestId");

			GetMainPartListResponse.GetMainPartList_Data data = new GetMainPartListResponse.GetMainPartList_Data();
			data.Count = _ctx.LongValue("GetMainPartList.Data.Count");

			List<GetMainPartListResponse.GetMainPartList_Data.GetMainPartList_MainPartBizs> data_list = new List<GetMainPartListResponse.GetMainPartList_Data.GetMainPartList_MainPartBizs>();
			for (int i = 0; i < _ctx.Length("GetMainPartList.Data.List.Length"); i++) {
				GetMainPartListResponse.GetMainPartList_Data.GetMainPartList_MainPartBizs mainPartBizs = new GetMainPartListResponse.GetMainPartList_Data.GetMainPartList_MainPartBizs();
				mainPartBizs.AccountNo = _ctx.StringValue("GetMainPartList.Data.List["+ i +"].AccountNo");
				mainPartBizs.AccountType = _ctx.StringValue("GetMainPartList.Data.List["+ i +"].AccountType");
				mainPartBizs.BrandUserId = _ctx.LongValue("GetMainPartList.Data.List["+ i +"].BrandUserId");
				mainPartBizs.BrandUserNick = _ctx.StringValue("GetMainPartList.Data.List["+ i +"].BrandUserNick");
				mainPartBizs.MainId = _ctx.LongValue("GetMainPartList.Data.List["+ i +"].MainId");
				mainPartBizs.MainName = _ctx.StringValue("GetMainPartList.Data.List["+ i +"].MainName");
				mainPartBizs.ProxyUserId = _ctx.LongValue("GetMainPartList.Data.List["+ i +"].ProxyUserId");

				data_list.Add(mainPartBizs);
			}
			data.List = data_list;
			getMainPartListResponse.Data = data;
        
			return getMainPartListResponse;
        }
    }
}
