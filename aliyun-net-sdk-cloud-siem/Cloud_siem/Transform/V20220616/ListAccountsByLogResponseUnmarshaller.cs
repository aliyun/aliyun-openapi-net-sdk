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
    public class ListAccountsByLogResponseUnmarshaller
    {
        public static ListAccountsByLogResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListAccountsByLogResponse listAccountsByLogResponse = new ListAccountsByLogResponse();

			listAccountsByLogResponse.HttpResponse = _ctx.HttpResponse;
			listAccountsByLogResponse.RequestId = _ctx.StringValue("ListAccountsByLog.RequestId");

			List<ListAccountsByLogResponse.ListAccountsByLog_DataItem> listAccountsByLogResponse_data = new List<ListAccountsByLogResponse.ListAccountsByLog_DataItem>();
			for (int i = 0; i < _ctx.Length("ListAccountsByLog.Data.Length"); i++) {
				ListAccountsByLogResponse.ListAccountsByLog_DataItem dataItem = new ListAccountsByLogResponse.ListAccountsByLog_DataItem();
				dataItem.SubUserId = _ctx.LongValue("ListAccountsByLog.Data["+ i +"].SubUserId");
				dataItem.MainUserId = _ctx.LongValue("ListAccountsByLog.Data["+ i +"].MainUserId");
				dataItem.AccountId = _ctx.StringValue("ListAccountsByLog.Data["+ i +"].AccountId");
				dataItem.AccountName = _ctx.StringValue("ListAccountsByLog.Data["+ i +"].AccountName");
				dataItem.Imported = _ctx.IntegerValue("ListAccountsByLog.Data["+ i +"].Imported");
				dataItem.LogCode = _ctx.StringValue("ListAccountsByLog.Data["+ i +"].LogCode");
				dataItem.ProdCode = _ctx.StringValue("ListAccountsByLog.Data["+ i +"].ProdCode");

				listAccountsByLogResponse_data.Add(dataItem);
			}
			listAccountsByLogResponse.Data = listAccountsByLogResponse_data;
        
			return listAccountsByLogResponse;
        }
    }
}
