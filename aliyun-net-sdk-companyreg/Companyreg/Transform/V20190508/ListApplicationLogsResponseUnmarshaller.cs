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
using Aliyun.Acs.companyreg.Model.V20190508;

namespace Aliyun.Acs.companyreg.Transform.V20190508
{
    public class ListApplicationLogsResponseUnmarshaller
    {
        public static ListApplicationLogsResponse Unmarshall(UnmarshallerContext context)
        {
			ListApplicationLogsResponse listApplicationLogsResponse = new ListApplicationLogsResponse();

			listApplicationLogsResponse.HttpResponse = context.HttpResponse;
			listApplicationLogsResponse.RequestId = context.StringValue("ListApplicationLogs.RequestId");

			List<ListApplicationLogsResponse.ListApplicationLogs_DataItem> listApplicationLogsResponse_data = new List<ListApplicationLogsResponse.ListApplicationLogs_DataItem>();
			for (int i = 0; i < context.Length("ListApplicationLogs.Data.Length"); i++) {
				ListApplicationLogsResponse.ListApplicationLogs_DataItem dataItem = new ListApplicationLogsResponse.ListApplicationLogs_DataItem();
				dataItem.BizId = context.StringValue("ListApplicationLogs.Data["+ i +"].BizId");
				dataItem.Note = context.StringValue("ListApplicationLogs.Data["+ i +"].Note");
				dataItem.OperateType = context.IntegerValue("ListApplicationLogs.Data["+ i +"].OperateType");
				dataItem.OperateTime = context.LongValue("ListApplicationLogs.Data["+ i +"].OperateTime");
				dataItem.BizStatus = context.IntegerValue("ListApplicationLogs.Data["+ i +"].BizStatus");
				dataItem.ExtendContent = context.StringValue("ListApplicationLogs.Data["+ i +"].ExtendContent");

				listApplicationLogsResponse_data.Add(dataItem);
			}
			listApplicationLogsResponse.Data = listApplicationLogsResponse_data;
        
			return listApplicationLogsResponse;
        }
    }
}
