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
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class MetastoreListTablesResponseUnmarshaller
    {
        public static MetastoreListTablesResponse Unmarshall(UnmarshallerContext context)
        {
			MetastoreListTablesResponse metastoreListTablesResponse = new MetastoreListTablesResponse();

			metastoreListTablesResponse.HttpResponse = context.HttpResponse;
			metastoreListTablesResponse.RequestId = context.StringValue("MetastoreListTables.RequestId");
			metastoreListTablesResponse.TotalCount = context.IntegerValue("MetastoreListTables.TotalCount");
			metastoreListTablesResponse.PageNumber = context.IntegerValue("MetastoreListTables.PageNumber");
			metastoreListTablesResponse.PageSize = context.IntegerValue("MetastoreListTables.PageSize");

			List<string> metastoreListTablesResponse_tableNames = new List<string>();
			for (int i = 0; i < context.Length("MetastoreListTables.TableNames.Length"); i++) {
				metastoreListTablesResponse_tableNames.Add(context.StringValue("MetastoreListTables.TableNames["+ i +"]"));
			}
			metastoreListTablesResponse.TableNames = metastoreListTablesResponse_tableNames;

			List<MetastoreListTablesResponse.MetastoreListTables_Table> metastoreListTablesResponse_tableList = new List<MetastoreListTablesResponse.MetastoreListTables_Table>();
			for (int i = 0; i < context.Length("MetastoreListTables.TableList.Length"); i++) {
				MetastoreListTablesResponse.MetastoreListTables_Table table = new MetastoreListTablesResponse.MetastoreListTables_Table();
				table.Id = context.StringValue("MetastoreListTables.TableList["+ i +"].Id");
				table.DatabaseId = context.StringValue("MetastoreListTables.TableList["+ i +"].DatabaseId");
				table.DatabaseName = context.StringValue("MetastoreListTables.TableList["+ i +"].DatabaseName");
				table.ClusterBizId = context.StringValue("MetastoreListTables.TableList["+ i +"].ClusterBizId");
				table.ClusterName = context.StringValue("MetastoreListTables.TableList["+ i +"].ClusterName");
				table.TableName = context.StringValue("MetastoreListTables.TableList["+ i +"].TableName");
				table.TableComment = context.StringValue("MetastoreListTables.TableList["+ i +"].TableComment");
				table.TableType = context.StringValue("MetastoreListTables.TableList["+ i +"].TableType");
				table.TableParameters = context.StringValue("MetastoreListTables.TableList["+ i +"].TableParameters");
				table.Owner = context.StringValue("MetastoreListTables.TableList["+ i +"].Owner");
				table.OwnerType = context.StringValue("MetastoreListTables.TableList["+ i +"].OwnerType");
				table.IsTemporary = context.BooleanValue("MetastoreListTables.TableList["+ i +"].IsTemporary");
				table.PartitionKeys = context.StringValue("MetastoreListTables.TableList["+ i +"].PartitionKeys");
				table.SerializationLib = context.StringValue("MetastoreListTables.TableList["+ i +"].SerializationLib");
				table.SerdeParameters = context.StringValue("MetastoreListTables.TableList["+ i +"].SerdeParameters");
				table.InputFormat = context.StringValue("MetastoreListTables.TableList["+ i +"].InputFormat");
				table.OutputFormat = context.StringValue("MetastoreListTables.TableList["+ i +"].OutputFormat");
				table.Location = context.StringValue("MetastoreListTables.TableList["+ i +"].Location");
				table.IsCompressed = context.BooleanValue("MetastoreListTables.TableList["+ i +"].IsCompressed");
				table.LastAccessTime = context.LongValue("MetastoreListTables.TableList["+ i +"].LastAccessTime");
				table.CreateTime = context.LongValue("MetastoreListTables.TableList["+ i +"].CreateTime");
				table.GmtCreate = context.LongValue("MetastoreListTables.TableList["+ i +"].GmtCreate");
				table.GmtModified = context.LongValue("MetastoreListTables.TableList["+ i +"].GmtModified");

				metastoreListTablesResponse_tableList.Add(table);
			}
			metastoreListTablesResponse.TableList = metastoreListTablesResponse_tableList;
        
			return metastoreListTablesResponse;
        }
    }
}
