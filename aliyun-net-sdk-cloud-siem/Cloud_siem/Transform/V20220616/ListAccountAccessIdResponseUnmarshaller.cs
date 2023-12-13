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
using Aliyun.Acs.cloud_siem.Model.V20220616;

namespace Aliyun.Acs.cloud_siem.Transform.V20220616
{
    public class ListAccountAccessIdResponseUnmarshaller
    {
        public static ListAccountAccessIdResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListAccountAccessIdResponse listAccountAccessIdResponse = new ListAccountAccessIdResponse();

			listAccountAccessIdResponse.HttpResponse = _ctx.HttpResponse;
			listAccountAccessIdResponse.Success = _ctx.BooleanValue("ListAccountAccessId.Success");
			listAccountAccessIdResponse.Code = _ctx.IntegerValue("ListAccountAccessId.Code");
			listAccountAccessIdResponse.Message = _ctx.StringValue("ListAccountAccessId.Message");
			listAccountAccessIdResponse.RequestId = _ctx.StringValue("ListAccountAccessId.RequestId");

			List<ListAccountAccessIdResponse.ListAccountAccessId_DataItem> listAccountAccessIdResponse_data = new List<ListAccountAccessIdResponse.ListAccountAccessId_DataItem>();
			for (int i = 0; i < _ctx.Length("ListAccountAccessId.Data.Length"); i++) {
				ListAccountAccessIdResponse.ListAccountAccessId_DataItem dataItem = new ListAccountAccessIdResponse.ListAccountAccessId_DataItem();
				dataItem.SubUserId = _ctx.LongValue("ListAccountAccessId.Data["+ i +"].SubUserId");
				dataItem.AccessIdMd5 = _ctx.StringValue("ListAccountAccessId.Data["+ i +"].AccessIdMd5");
				dataItem.AccountStr = _ctx.StringValue("ListAccountAccessId.Data["+ i +"].AccountStr");
				dataItem.Bound = _ctx.IntegerValue("ListAccountAccessId.Data["+ i +"].Bound");
				dataItem.AccessId = _ctx.StringValue("ListAccountAccessId.Data["+ i +"].AccessId");
				dataItem.AccountId = _ctx.StringValue("ListAccountAccessId.Data["+ i +"].AccountId");
				dataItem.CloudCode = _ctx.StringValue("ListAccountAccessId.Data["+ i +"].CloudCode");

				listAccountAccessIdResponse_data.Add(dataItem);
			}
			listAccountAccessIdResponse.Data = listAccountAccessIdResponse_data;
        
			return listAccountAccessIdResponse;
        }
    }
}
