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
using Aliyun.Acs.dt_oc_info.Model.V20220829;

namespace Aliyun.Acs.dt_oc_info.Transform.V20220829
{
    public class GetOcFuzzSearchResponseUnmarshaller
    {
        public static GetOcFuzzSearchResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetOcFuzzSearchResponse getOcFuzzSearchResponse = new GetOcFuzzSearchResponse();

			getOcFuzzSearchResponse.HttpResponse = _ctx.HttpResponse;
			getOcFuzzSearchResponse.Code = _ctx.StringValue("GetOcFuzzSearch.Code");
			getOcFuzzSearchResponse.Success = _ctx.BooleanValue("GetOcFuzzSearch.Success");
			getOcFuzzSearchResponse.Message = _ctx.StringValue("GetOcFuzzSearch.Message");
			getOcFuzzSearchResponse.TotalNum = _ctx.IntegerValue("GetOcFuzzSearch.TotalNum");
			getOcFuzzSearchResponse.PageIndex = _ctx.IntegerValue("GetOcFuzzSearch.PageIndex");
			getOcFuzzSearchResponse.PageNum = _ctx.IntegerValue("GetOcFuzzSearch.PageNum");
			getOcFuzzSearchResponse.RequestId = _ctx.StringValue("GetOcFuzzSearch.RequestId");

			List<GetOcFuzzSearchResponse.GetOcFuzzSearch_DataItem> getOcFuzzSearchResponse_data = new List<GetOcFuzzSearchResponse.GetOcFuzzSearch_DataItem>();
			for (int i = 0; i < _ctx.Length("GetOcFuzzSearch.Data.Length"); i++) {
				GetOcFuzzSearchResponse.GetOcFuzzSearch_DataItem dataItem = new GetOcFuzzSearchResponse.GetOcFuzzSearch_DataItem();
				dataItem.EntName = _ctx.StringValue("GetOcFuzzSearch.Data["+ i +"].EntName");

				getOcFuzzSearchResponse_data.Add(dataItem);
			}
			getOcFuzzSearchResponse.Data = getOcFuzzSearchResponse_data;
        
			return getOcFuzzSearchResponse;
        }
    }
}
