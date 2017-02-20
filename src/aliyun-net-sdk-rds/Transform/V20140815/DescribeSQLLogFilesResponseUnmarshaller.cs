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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Rds.Model.V20140815;
using System.Collections.Generic;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeSQLLogFilesResponseUnmarshaller
    {
        public static DescribeSQLLogFilesResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeSQLLogFilesResponse describeSQLLogFilesResponse = new DescribeSQLLogFilesResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeSQLLogFiles.RequestId"),
                TotalRecordCount = context.IntegerValue("DescribeSQLLogFiles.TotalRecordCount"),
                PageNumber = context.IntegerValue("DescribeSQLLogFiles.PageNumber"),
                PageRecordCount = context.IntegerValue("DescribeSQLLogFiles.PageRecordCount")
            };
            List<DescribeSQLLogFilesResponse.LogFile> items = new List<DescribeSQLLogFilesResponse.LogFile>();
			for (int i = 0; i < context.Length("DescribeSQLLogFiles.Items.Length"); i++) {
                DescribeSQLLogFilesResponse.LogFile logFile = new DescribeSQLLogFilesResponse.LogFile()
                {
                    FileID = context.StringValue($"DescribeSQLLogFiles.Items[{i}].FileID"),
                    LogStatus = context.EnumValue<DescribeSQLLogFilesResponse.LogFile.LogStatusEnum>($"DescribeSQLLogFiles.Items[{i}].LogStatus"),
                    LogDownloadURL = context.StringValue($"DescribeSQLLogFiles.Items[{i}].LogDownloadURL"),
                    LogSize = context.StringValue($"DescribeSQLLogFiles.Items[{i}].LogSize"),
                    LogStartTime = context.StringValue($"DescribeSQLLogFiles.Items[{i}].LogStartTime"),
                    LogEndTime = context.StringValue($"DescribeSQLLogFiles.Items[{i}].LogEndTime")
                };
                items.Add(logFile);
			}
			describeSQLLogFilesResponse.Items = items;
        
			return describeSQLLogFilesResponse;
        }
    }
}