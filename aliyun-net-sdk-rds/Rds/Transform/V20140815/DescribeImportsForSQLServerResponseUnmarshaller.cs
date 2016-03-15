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
    public class DescribeImportsForSQLServerResponseUnmarshaller
    {
        public static DescribeImportsForSQLServerResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeImportsForSQLServerResponse describeImportsForSQLServerResponse = new DescribeImportsForSQLServerResponse();

			describeImportsForSQLServerResponse.HttpResponse = context.HttpResponse;
			describeImportsForSQLServerResponse.RequestId = context.StringValue("DescribeImportsForSQLServer.RequestId");
			describeImportsForSQLServerResponse.TotalRecordCounts = context.IntegerValue("DescribeImportsForSQLServer.TotalRecordCounts");
			describeImportsForSQLServerResponse.PageNumber = context.IntegerValue("DescribeImportsForSQLServer.PageNumber");
			describeImportsForSQLServerResponse.SQLItemsCounts = context.IntegerValue("DescribeImportsForSQLServer.SQLItemsCounts");

			List<DescribeImportsForSQLServerResponse.SQLServerImport> items = new List<DescribeImportsForSQLServerResponse.SQLServerImport>();
			for (int i = 0; i < context.Length("DescribeImportsForSQLServer.Items.Length"); i++) {
				DescribeImportsForSQLServerResponse.SQLServerImport sQLServerImport = new DescribeImportsForSQLServerResponse.SQLServerImport();
				sQLServerImport.ImportId = context.IntegerValue("DescribeImportsForSQLServer.Items["+ i +"].ImportId");
				sQLServerImport.FileName = context.StringValue("DescribeImportsForSQLServer.Items["+ i +"].FileName");
				sQLServerImport.DBName = context.StringValue("DescribeImportsForSQLServer.Items["+ i +"].DBName");
				sQLServerImport.ImportStatus = context.EnumValue<DescribeImportsForSQLServerResponse.SQLServerImport.ImportStatusEnum>("DescribeImportsForSQLServer.Items["+ i +"].ImportStatus");
				sQLServerImport.StartTime = context.StringValue("DescribeImportsForSQLServer.Items["+ i +"].StartTime");

				items.Add(sQLServerImport);
			}
			describeImportsForSQLServerResponse.Items = items;
        
			return describeImportsForSQLServerResponse;
        }
    }
}