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
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeSqlLogDetailArchiveStatusResponseUnmarshaller
    {
        public static DescribeSqlLogDetailArchiveStatusResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSqlLogDetailArchiveStatusResponse describeSqlLogDetailArchiveStatusResponse = new DescribeSqlLogDetailArchiveStatusResponse();

			describeSqlLogDetailArchiveStatusResponse.HttpResponse = context.HttpResponse;
			describeSqlLogDetailArchiveStatusResponse.RequestId = context.StringValue("DescribeSqlLogDetailArchiveStatus.RequestId");
			describeSqlLogDetailArchiveStatusResponse.DBInstanceID = context.IntegerValue("DescribeSqlLogDetailArchiveStatus.DBInstanceID");
			describeSqlLogDetailArchiveStatusResponse.DBInstanceName = context.StringValue("DescribeSqlLogDetailArchiveStatus.DBInstanceName");
			describeSqlLogDetailArchiveStatusResponse.ItemsNumbers = context.IntegerValue("DescribeSqlLogDetailArchiveStatus.ItemsNumbers");

			List<DescribeSqlLogDetailArchiveStatusResponse.DescribeSqlLogDetailArchiveStatus_ArchiveSQLLog> describeSqlLogDetailArchiveStatusResponse_items = new List<DescribeSqlLogDetailArchiveStatusResponse.DescribeSqlLogDetailArchiveStatus_ArchiveSQLLog>();
			for (int i = 0; i < context.Length("DescribeSqlLogDetailArchiveStatus.Items.Length"); i++) {
				DescribeSqlLogDetailArchiveStatusResponse.DescribeSqlLogDetailArchiveStatus_ArchiveSQLLog archiveSQLLog = new DescribeSqlLogDetailArchiveStatusResponse.DescribeSqlLogDetailArchiveStatus_ArchiveSQLLog();
				archiveSQLLog.JobName = context.StringValue("DescribeSqlLogDetailArchiveStatus.Items["+ i +"].JobName");
				archiveSQLLog.CreateTime = context.StringValue("DescribeSqlLogDetailArchiveStatus.Items["+ i +"].CreateTime");
				archiveSQLLog.UpdateTime = context.StringValue("DescribeSqlLogDetailArchiveStatus.Items["+ i +"].UpdateTime");
				archiveSQLLog.ProcessRows = context.LongValue("DescribeSqlLogDetailArchiveStatus.Items["+ i +"].ProcessRows");
				archiveSQLLog.TotalRows = context.LongValue("DescribeSqlLogDetailArchiveStatus.Items["+ i +"].TotalRows");
				archiveSQLLog.FailMsg = context.StringValue("DescribeSqlLogDetailArchiveStatus.Items["+ i +"].FailMsg");
				archiveSQLLog.JobStatus = context.StringValue("DescribeSqlLogDetailArchiveStatus.Items["+ i +"].JobStatus");
				archiveSQLLog.DownloadLink = context.StringValue("DescribeSqlLogDetailArchiveStatus.Items["+ i +"].DownloadLink");
				archiveSQLLog.LinkExpiredTime = context.StringValue("DescribeSqlLogDetailArchiveStatus.Items["+ i +"].LinkExpiredTime");

				describeSqlLogDetailArchiveStatusResponse_items.Add(archiveSQLLog);
			}
			describeSqlLogDetailArchiveStatusResponse.Items = describeSqlLogDetailArchiveStatusResponse_items;
        
			return describeSqlLogDetailArchiveStatusResponse;
        }
    }
}