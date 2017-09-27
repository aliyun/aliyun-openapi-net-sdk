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
    public class DescribeFilesForSQLServerResponseUnmarshaller
    {
        public static DescribeFilesForSQLServerResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeFilesForSQLServerResponse describeFilesForSQLServerResponse = new DescribeFilesForSQLServerResponse();

			describeFilesForSQLServerResponse.HttpResponse = context.HttpResponse;
			describeFilesForSQLServerResponse.RequestId = context.StringValue("DescribeFilesForSQLServer.RequestId");
			describeFilesForSQLServerResponse.DBInstanceId = context.StringValue("DescribeFilesForSQLServer.DBInstanceId");
			describeFilesForSQLServerResponse.TotalRecordCount = context.IntegerValue("DescribeFilesForSQLServer.TotalRecordCount");
			describeFilesForSQLServerResponse.PageNumber = context.IntegerValue("DescribeFilesForSQLServer.PageNumber");
			describeFilesForSQLServerResponse.PageRecordCount = context.IntegerValue("DescribeFilesForSQLServer.PageRecordCount");

			List<DescribeFilesForSQLServerResponse.DescribeFilesForSQLServer_SQLServerUploadFile> describeFilesForSQLServerResponse_items = new List<DescribeFilesForSQLServerResponse.DescribeFilesForSQLServer_SQLServerUploadFile>();
			for (int i = 0; i < context.Length("DescribeFilesForSQLServer.Items.Length"); i++) {
				DescribeFilesForSQLServerResponse.DescribeFilesForSQLServer_SQLServerUploadFile sQLServerUploadFile = new DescribeFilesForSQLServerResponse.DescribeFilesForSQLServer_SQLServerUploadFile();
				sQLServerUploadFile.DBName = context.StringValue("DescribeFilesForSQLServer.Items["+ i +"].DBName");
				sQLServerUploadFile.FileName = context.StringValue("DescribeFilesForSQLServer.Items["+ i +"].FileName");
				sQLServerUploadFile.FileSize = context.LongValue("DescribeFilesForSQLServer.Items["+ i +"].FileSize");
				sQLServerUploadFile.InternetFtpServer = context.StringValue("DescribeFilesForSQLServer.Items["+ i +"].InternetFtpServer");
				sQLServerUploadFile.InternetPort = context.IntegerValue("DescribeFilesForSQLServer.Items["+ i +"].InternetPort");
				sQLServerUploadFile.IntranetFtpserver = context.StringValue("DescribeFilesForSQLServer.Items["+ i +"].IntranetFtpserver");
				sQLServerUploadFile.Intranetport = context.IntegerValue("DescribeFilesForSQLServer.Items["+ i +"].Intranetport");
				sQLServerUploadFile.UserName = context.StringValue("DescribeFilesForSQLServer.Items["+ i +"].UserName");
				sQLServerUploadFile.Password = context.StringValue("DescribeFilesForSQLServer.Items["+ i +"].Password");
				sQLServerUploadFile.FileStatus = context.StringValue("DescribeFilesForSQLServer.Items["+ i +"].FileStatus");
				sQLServerUploadFile.Description = context.StringValue("DescribeFilesForSQLServer.Items["+ i +"].Description");
				sQLServerUploadFile.CreationTime = context.StringValue("DescribeFilesForSQLServer.Items["+ i +"].CreationTime");

				describeFilesForSQLServerResponse_items.Add(sQLServerUploadFile);
			}
			describeFilesForSQLServerResponse.Items = describeFilesForSQLServerResponse_items;
        
			return describeFilesForSQLServerResponse;
        }
    }
}