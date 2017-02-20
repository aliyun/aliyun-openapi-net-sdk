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
    public class DescribeImportsForSQLServerResponseUnmarshaller
    {
        public static DescribeImportsForSQLServerResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeImportsForSQLServerResponse describeImportsForSQLServerResponse = new DescribeImportsForSQLServerResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeImportsForSQLServer.RequestId"),
                TotalRecordCounts = context.IntegerValue("DescribeImportsForSQLServer.TotalRecordCounts"),
                PageNumber = context.IntegerValue("DescribeImportsForSQLServer.PageNumber"),
                SQLItemsCounts = context.IntegerValue("DescribeImportsForSQLServer.SQLItemsCounts")
            };
            List<DescribeImportsForSQLServerResponse.SQLServerImport> items = new List<DescribeImportsForSQLServerResponse.SQLServerImport>();
			for (int i = 0; i < context.Length("DescribeImportsForSQLServer.Items.Length"); i++) {
                DescribeImportsForSQLServerResponse.SQLServerImport sQlServerImport = new DescribeImportsForSQLServerResponse.SQLServerImport()
                {
                    ImportId = context.IntegerValue($"DescribeImportsForSQLServer.Items[{i}].ImportId"),
                    FileName = context.StringValue($"DescribeImportsForSQLServer.Items[{i}].FileName"),
                    DBName = context.StringValue($"DescribeImportsForSQLServer.Items[{i}].DBName"),
                    ImportStatus = context.EnumValue<DescribeImportsForSQLServerResponse.SQLServerImport.ImportStatusEnum>($"DescribeImportsForSQLServer.Items[{i}].ImportStatus"),
                    StartTime = context.StringValue($"DescribeImportsForSQLServer.Items[{i}].StartTime")
                };
                items.Add(sQlServerImport);
			}
			describeImportsForSQLServerResponse.Items = items;
        
			return describeImportsForSQLServerResponse;
        }
    }
}