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
    public class ListUserProdLogsResponseUnmarshaller
    {
        public static ListUserProdLogsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListUserProdLogsResponse listUserProdLogsResponse = new ListUserProdLogsResponse();

			listUserProdLogsResponse.HttpResponse = _ctx.HttpResponse;
			listUserProdLogsResponse.RequestId = _ctx.StringValue("ListUserProdLogs.RequestId");

			List<ListUserProdLogsResponse.ListUserProdLogs_DataItem> listUserProdLogsResponse_data = new List<ListUserProdLogsResponse.ListUserProdLogs_DataItem>();
			for (int i = 0; i < _ctx.Length("ListUserProdLogs.Data.Length"); i++) {
				ListUserProdLogsResponse.ListUserProdLogs_DataItem dataItem = new ListUserProdLogsResponse.ListUserProdLogs_DataItem();
				dataItem.SourceLogCode = _ctx.StringValue("ListUserProdLogs.Data["+ i +"].SourceLogCode");
				dataItem.SourceLogInfo = _ctx.StringValue("ListUserProdLogs.Data["+ i +"].SourceLogInfo");
				dataItem.DisplayLine = _ctx.StringValue("ListUserProdLogs.Data["+ i +"].DisplayLine");
				dataItem.SourceProdCode = _ctx.StringValue("ListUserProdLogs.Data["+ i +"].SourceProdCode");
				dataItem.IsDeleted = _ctx.IntegerValue("ListUserProdLogs.Data["+ i +"].IsDeleted");
				dataItem.Imported = _ctx.BooleanValue("ListUserProdLogs.Data["+ i +"].Imported");
				dataItem.Displayed = _ctx.BooleanValue("ListUserProdLogs.Data["+ i +"].Displayed");
				dataItem.MainUserId = _ctx.LongValue("ListUserProdLogs.Data["+ i +"].MainUserId");
				dataItem.SubUserId = _ctx.LongValue("ListUserProdLogs.Data["+ i +"].SubUserId");
				dataItem.SubUserName = _ctx.StringValue("ListUserProdLogs.Data["+ i +"].SubUserName");

				listUserProdLogsResponse_data.Add(dataItem);
			}
			listUserProdLogsResponse.Data = listUserProdLogsResponse_data;
        
			return listUserProdLogsResponse;
        }
    }
}
