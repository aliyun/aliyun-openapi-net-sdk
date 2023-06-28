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
    public class GetOcIcClearAccountResponseUnmarshaller
    {
        public static GetOcIcClearAccountResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetOcIcClearAccountResponse getOcIcClearAccountResponse = new GetOcIcClearAccountResponse();

			getOcIcClearAccountResponse.HttpResponse = _ctx.HttpResponse;
			getOcIcClearAccountResponse.Code = _ctx.StringValue("GetOcIcClearAccount.Code");
			getOcIcClearAccountResponse.Success = _ctx.BooleanValue("GetOcIcClearAccount.Success");
			getOcIcClearAccountResponse.Message = _ctx.StringValue("GetOcIcClearAccount.Message");
			getOcIcClearAccountResponse.TotalNum = _ctx.IntegerValue("GetOcIcClearAccount.TotalNum");
			getOcIcClearAccountResponse.PageIndex = _ctx.IntegerValue("GetOcIcClearAccount.PageIndex");
			getOcIcClearAccountResponse.PageNum = _ctx.IntegerValue("GetOcIcClearAccount.PageNum");
			getOcIcClearAccountResponse.RequestId = _ctx.StringValue("GetOcIcClearAccount.RequestId");

			List<GetOcIcClearAccountResponse.GetOcIcClearAccount_DataItem> getOcIcClearAccountResponse_data = new List<GetOcIcClearAccountResponse.GetOcIcClearAccount_DataItem>();
			for (int i = 0; i < _ctx.Length("GetOcIcClearAccount.Data.Length"); i++) {
				GetOcIcClearAccountResponse.GetOcIcClearAccount_DataItem dataItem = new GetOcIcClearAccountResponse.GetOcIcClearAccount_DataItem();
				dataItem.Leader = _ctx.StringValue("GetOcIcClearAccount.Data["+ i +"].Leader");
				dataItem.Member = _ctx.StringValue("GetOcIcClearAccount.Data["+ i +"].Member");

				getOcIcClearAccountResponse_data.Add(dataItem);
			}
			getOcIcClearAccountResponse.Data = getOcIcClearAccountResponse_data;
        
			return getOcIcClearAccountResponse;
        }
    }
}
