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
    public class DescribeFilesForSQLServerResponseUnmarshaller
    {
        public static DescribeFilesForSQLServerResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeFilesForSQLServerResponse describeFilesForSQLServerResponse = new DescribeFilesForSQLServerResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeFilesForSQLServer.RequestId"),
                DBInstanceId = context.StringValue("DescribeFilesForSQLServer.DBInstanceId"),
                TotalRecordCount = context.IntegerValue("DescribeFilesForSQLServer.TotalRecordCount"),
                PageNumber = context.IntegerValue("DescribeFilesForSQLServer.PageNumber"),
                PageRecordCount = context.IntegerValue("DescribeFilesForSQLServer.PageRecordCount")
            };
            List<DescribeFilesForSQLServerResponse.SQLServerUploadFile> items = new List<DescribeFilesForSQLServerResponse.SQLServerUploadFile>();
			for (int i = 0; i < context.Length("DescribeFilesForSQLServer.Items.Length"); i++) {
                DescribeFilesForSQLServerResponse.SQLServerUploadFile sQlServerUploadFile = new DescribeFilesForSQLServerResponse.SQLServerUploadFile()
                {
                    DBName = context.StringValue($"DescribeFilesForSQLServer.Items[{i}].DBName"),
                    FileName = context.StringValue($"DescribeFilesForSQLServer.Items[{i}].FileName"),
                    FileSize = context.LongValue($"DescribeFilesForSQLServer.Items[{i}].FileSize"),
                    InternetFtpServer = context.StringValue($"DescribeFilesForSQLServer.Items[{i}].InternetFtpServer"),
                    InternetPort = context.IntegerValue($"DescribeFilesForSQLServer.Items[{i}].InternetPort"),
                    IntranetFtpserver = context.StringValue($"DescribeFilesForSQLServer.Items[{i}].IntranetFtpserver"),
                    Intranetport = context.IntegerValue($"DescribeFilesForSQLServer.Items[{i}].Intranetport"),
                    UserName = context.StringValue($"DescribeFilesForSQLServer.Items[{i}].UserName"),
                    Password = context.StringValue($"DescribeFilesForSQLServer.Items[{i}].Password"),
                    FileStatus = context.EnumValue<DescribeFilesForSQLServerResponse.SQLServerUploadFile.FileStatusEnum>($"DescribeFilesForSQLServer.Items[{i}].FileStatus"),
                    Description = context.StringValue($"DescribeFilesForSQLServer.Items[{i}].Description"),
                    CreationTime = context.StringValue($"DescribeFilesForSQLServer.Items[{i}].CreationTime")
                };
                items.Add(sQlServerUploadFile);
			}
			describeFilesForSQLServerResponse.Items = items;
        
			return describeFilesForSQLServerResponse;
        }
    }
}