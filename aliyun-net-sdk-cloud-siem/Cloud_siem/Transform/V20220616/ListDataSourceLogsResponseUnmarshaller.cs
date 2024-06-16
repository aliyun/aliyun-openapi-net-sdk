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
    public class ListDataSourceLogsResponseUnmarshaller
    {
        public static ListDataSourceLogsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDataSourceLogsResponse listDataSourceLogsResponse = new ListDataSourceLogsResponse();

			listDataSourceLogsResponse.HttpResponse = _ctx.HttpResponse;
			listDataSourceLogsResponse.RequestId = _ctx.StringValue("ListDataSourceLogs.RequestId");

			ListDataSourceLogsResponse.ListDataSourceLogs_Data data = new ListDataSourceLogsResponse.ListDataSourceLogs_Data();
			data.SubUserId = _ctx.LongValue("ListDataSourceLogs.Data.SubUserId");
			data.DataSourceInstanceId = _ctx.StringValue("ListDataSourceLogs.Data.DataSourceInstanceId");
			data.DataSourceInstanceName = _ctx.StringValue("ListDataSourceLogs.Data.DataSourceInstanceName");
			data.DataSourceInstanceRemark = _ctx.StringValue("ListDataSourceLogs.Data.DataSourceInstanceRemark");
			data.AccountId = _ctx.StringValue("ListDataSourceLogs.Data.AccountId");
			data.CloudCode = _ctx.StringValue("ListDataSourceLogs.Data.CloudCode");

			List<ListDataSourceLogsResponse.ListDataSourceLogs_Data.ListDataSourceLogs_DataSourceInstanceLog> data_dataSourceInstanceLogs = new List<ListDataSourceLogsResponse.ListDataSourceLogs_Data.ListDataSourceLogs_DataSourceInstanceLog>();
			for (int i = 0; i < _ctx.Length("ListDataSourceLogs.Data.DataSourceInstanceLogs.Length"); i++) {
				ListDataSourceLogsResponse.ListDataSourceLogs_Data.ListDataSourceLogs_DataSourceInstanceLog dataSourceInstanceLog = new ListDataSourceLogsResponse.ListDataSourceLogs_Data.ListDataSourceLogs_DataSourceInstanceLog();
				dataSourceInstanceLog.LogInstanceId = _ctx.StringValue("ListDataSourceLogs.Data.DataSourceInstanceLogs["+ i +"].LogInstanceId");
				dataSourceInstanceLog.LogCode = _ctx.StringValue("ListDataSourceLogs.Data.DataSourceInstanceLogs["+ i +"].LogCode");
				dataSourceInstanceLog.LogMdsCode = _ctx.StringValue("ListDataSourceLogs.Data.DataSourceInstanceLogs["+ i +"].LogMdsCode");
				dataSourceInstanceLog.TaskStatus = _ctx.IntegerValue("ListDataSourceLogs.Data.DataSourceInstanceLogs["+ i +"].TaskStatus");

				List<ListDataSourceLogsResponse.ListDataSourceLogs_Data.ListDataSourceLogs_DataSourceInstanceLog.ListDataSourceLogs_LogParam> dataSourceInstanceLog_logParams = new List<ListDataSourceLogsResponse.ListDataSourceLogs_Data.ListDataSourceLogs_DataSourceInstanceLog.ListDataSourceLogs_LogParam>();
				for (int j = 0; j < _ctx.Length("ListDataSourceLogs.Data.DataSourceInstanceLogs["+ i +"].LogParams.Length"); j++) {
					ListDataSourceLogsResponse.ListDataSourceLogs_Data.ListDataSourceLogs_DataSourceInstanceLog.ListDataSourceLogs_LogParam logParam = new ListDataSourceLogsResponse.ListDataSourceLogs_Data.ListDataSourceLogs_DataSourceInstanceLog.ListDataSourceLogs_LogParam();
					logParam.ParaCode = _ctx.StringValue("ListDataSourceLogs.Data.DataSourceInstanceLogs["+ i +"].LogParams["+ j +"].ParaCode");
					logParam.ParaValue = _ctx.StringValue("ListDataSourceLogs.Data.DataSourceInstanceLogs["+ i +"].LogParams["+ j +"].ParaValue");

					dataSourceInstanceLog_logParams.Add(logParam);
				}
				dataSourceInstanceLog.LogParams = dataSourceInstanceLog_logParams;

				data_dataSourceInstanceLogs.Add(dataSourceInstanceLog);
			}
			data.DataSourceInstanceLogs = data_dataSourceInstanceLogs;
			listDataSourceLogsResponse.Data = data;
        
			return listDataSourceLogsResponse;
        }
    }
}
