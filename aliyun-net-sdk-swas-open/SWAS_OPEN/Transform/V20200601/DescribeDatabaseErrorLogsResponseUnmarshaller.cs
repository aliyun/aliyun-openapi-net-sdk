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
using Aliyun.Acs.SWAS_OPEN.Model.V20200601;

namespace Aliyun.Acs.SWAS_OPEN.Transform.V20200601
{
    public class DescribeDatabaseErrorLogsResponseUnmarshaller
    {
        public static DescribeDatabaseErrorLogsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDatabaseErrorLogsResponse describeDatabaseErrorLogsResponse = new DescribeDatabaseErrorLogsResponse();

			describeDatabaseErrorLogsResponse.HttpResponse = _ctx.HttpResponse;
			describeDatabaseErrorLogsResponse.RequestId = _ctx.StringValue("DescribeDatabaseErrorLogs.RequestId");
			describeDatabaseErrorLogsResponse.PageNumber = _ctx.IntegerValue("DescribeDatabaseErrorLogs.PageNumber");
			describeDatabaseErrorLogsResponse.PageSize = _ctx.IntegerValue("DescribeDatabaseErrorLogs.PageSize");
			describeDatabaseErrorLogsResponse.TotalCount = _ctx.IntegerValue("DescribeDatabaseErrorLogs.TotalCount");

			List<DescribeDatabaseErrorLogsResponse.DescribeDatabaseErrorLogs_ErrorLog> describeDatabaseErrorLogsResponse_errorLogs = new List<DescribeDatabaseErrorLogsResponse.DescribeDatabaseErrorLogs_ErrorLog>();
			for (int i = 0; i < _ctx.Length("DescribeDatabaseErrorLogs.ErrorLogs.Length"); i++) {
				DescribeDatabaseErrorLogsResponse.DescribeDatabaseErrorLogs_ErrorLog errorLog = new DescribeDatabaseErrorLogsResponse.DescribeDatabaseErrorLogs_ErrorLog();
				errorLog.ErrorInfo = _ctx.StringValue("DescribeDatabaseErrorLogs.ErrorLogs["+ i +"].ErrorInfo");
				errorLog.CreateTime = _ctx.StringValue("DescribeDatabaseErrorLogs.ErrorLogs["+ i +"].CreateTime");

				describeDatabaseErrorLogsResponse_errorLogs.Add(errorLog);
			}
			describeDatabaseErrorLogsResponse.ErrorLogs = describeDatabaseErrorLogsResponse_errorLogs;
        
			return describeDatabaseErrorLogsResponse;
        }
    }
}
