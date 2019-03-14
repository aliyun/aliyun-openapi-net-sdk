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
    public class MetastoreDescribeTableResponseUnmarshaller
    {
        public static MetastoreDescribeTableResponse Unmarshall(UnmarshallerContext context)
        {
			MetastoreDescribeTableResponse metastoreDescribeTableResponse = new MetastoreDescribeTableResponse();

			metastoreDescribeTableResponse.HttpResponse = context.HttpResponse;
			metastoreDescribeTableResponse.RequestId = context.StringValue("MetastoreDescribeTable.RequestId");
			metastoreDescribeTableResponse.Id = context.StringValue("MetastoreDescribeTable.Id");
			metastoreDescribeTableResponse.DatabaseId = context.StringValue("MetastoreDescribeTable.DatabaseId");
			metastoreDescribeTableResponse.ClusterBizId = context.StringValue("MetastoreDescribeTable.ClusterBizId");
			metastoreDescribeTableResponse.ClusterName = context.StringValue("MetastoreDescribeTable.ClusterName");
			metastoreDescribeTableResponse.CreateTime = context.IntegerValue("MetastoreDescribeTable.CreateTime");
			metastoreDescribeTableResponse.LastAccessTime = context.IntegerValue("MetastoreDescribeTable.LastAccessTime");
			metastoreDescribeTableResponse.LocationUri = context.StringValue("MetastoreDescribeTable.LocationUri");
			metastoreDescribeTableResponse.InputFormat = context.StringValue("MetastoreDescribeTable.InputFormat");
			metastoreDescribeTableResponse.OutputFormat = context.StringValue("MetastoreDescribeTable.OutputFormat");
			metastoreDescribeTableResponse.Compressed = context.BooleanValue("MetastoreDescribeTable.Compressed");
			metastoreDescribeTableResponse.SerializationLib = context.StringValue("MetastoreDescribeTable.SerializationLib");
			metastoreDescribeTableResponse.TableName = context.StringValue("MetastoreDescribeTable.TableName");
			metastoreDescribeTableResponse.DbName = context.StringValue("MetastoreDescribeTable.DbName");
			metastoreDescribeTableResponse.Owner = context.StringValue("MetastoreDescribeTable.Owner");
			metastoreDescribeTableResponse.TableComment = context.StringValue("MetastoreDescribeTable.TableComment");
			metastoreDescribeTableResponse.TableType = context.StringValue("MetastoreDescribeTable.TableType");
			metastoreDescribeTableResponse.Creator = context.StringValue("MetastoreDescribeTable.Creator");
			metastoreDescribeTableResponse.FieldDelimiter = context.StringValue("MetastoreDescribeTable.FieldDelimiter");

			List<MetastoreDescribeTableResponse.MetastoreDescribeTable_Column> metastoreDescribeTableResponse_columns = new List<MetastoreDescribeTableResponse.MetastoreDescribeTable_Column>();
			for (int i = 0; i < context.Length("MetastoreDescribeTable.Columns.Length"); i++) {
				MetastoreDescribeTableResponse.MetastoreDescribeTable_Column column = new MetastoreDescribeTableResponse.MetastoreDescribeTable_Column();
				column.Name = context.StringValue("MetastoreDescribeTable.Columns["+ i +"].Name");
				column.Type = context.StringValue("MetastoreDescribeTable.Columns["+ i +"].Type");
				column.Comment = context.StringValue("MetastoreDescribeTable.Columns["+ i +"].Comment");

				metastoreDescribeTableResponse_columns.Add(column);
			}
			metastoreDescribeTableResponse.Columns = metastoreDescribeTableResponse_columns;

			List<MetastoreDescribeTableResponse.MetastoreDescribeTable_PartitionColumn> metastoreDescribeTableResponse_partitionColumns = new List<MetastoreDescribeTableResponse.MetastoreDescribeTable_PartitionColumn>();
			for (int i = 0; i < context.Length("MetastoreDescribeTable.PartitionColumns.Length"); i++) {
				MetastoreDescribeTableResponse.MetastoreDescribeTable_PartitionColumn partitionColumn = new MetastoreDescribeTableResponse.MetastoreDescribeTable_PartitionColumn();
				partitionColumn.Name = context.StringValue("MetastoreDescribeTable.PartitionColumns["+ i +"].Name");
				partitionColumn.Type = context.StringValue("MetastoreDescribeTable.PartitionColumns["+ i +"].Type");
				partitionColumn.Comment = context.StringValue("MetastoreDescribeTable.PartitionColumns["+ i +"].Comment");

				metastoreDescribeTableResponse_partitionColumns.Add(partitionColumn);
			}
			metastoreDescribeTableResponse.PartitionColumns = metastoreDescribeTableResponse_partitionColumns;

			List<MetastoreDescribeTableResponse.MetastoreDescribeTable_SerdeParameter> metastoreDescribeTableResponse_serdeParameters = new List<MetastoreDescribeTableResponse.MetastoreDescribeTable_SerdeParameter>();
			for (int i = 0; i < context.Length("MetastoreDescribeTable.SerdeParameters.Length"); i++) {
				MetastoreDescribeTableResponse.MetastoreDescribeTable_SerdeParameter serdeParameter = new MetastoreDescribeTableResponse.MetastoreDescribeTable_SerdeParameter();
				serdeParameter.Key = context.StringValue("MetastoreDescribeTable.SerdeParameters["+ i +"].Key");
				serdeParameter._Value = context.StringValue("MetastoreDescribeTable.SerdeParameters["+ i +"].Value");

				metastoreDescribeTableResponse_serdeParameters.Add(serdeParameter);
			}
			metastoreDescribeTableResponse.SerdeParameters = metastoreDescribeTableResponse_serdeParameters;

			List<MetastoreDescribeTableResponse.MetastoreDescribeTable_StorageDescParameter> metastoreDescribeTableResponse_storageDescParameters = new List<MetastoreDescribeTableResponse.MetastoreDescribeTable_StorageDescParameter>();
			for (int i = 0; i < context.Length("MetastoreDescribeTable.StorageDescParameters.Length"); i++) {
				MetastoreDescribeTableResponse.MetastoreDescribeTable_StorageDescParameter storageDescParameter = new MetastoreDescribeTableResponse.MetastoreDescribeTable_StorageDescParameter();
				storageDescParameter.Key = context.StringValue("MetastoreDescribeTable.StorageDescParameters["+ i +"].Key");
				storageDescParameter._Value = context.StringValue("MetastoreDescribeTable.StorageDescParameters["+ i +"].Value");

				metastoreDescribeTableResponse_storageDescParameters.Add(storageDescParameter);
			}
			metastoreDescribeTableResponse.StorageDescParameters = metastoreDescribeTableResponse_storageDescParameters;

			List<MetastoreDescribeTableResponse.MetastoreDescribeTable_TableParameter> metastoreDescribeTableResponse_tableParameters = new List<MetastoreDescribeTableResponse.MetastoreDescribeTable_TableParameter>();
			for (int i = 0; i < context.Length("MetastoreDescribeTable.TableParameters.Length"); i++) {
				MetastoreDescribeTableResponse.MetastoreDescribeTable_TableParameter tableParameter = new MetastoreDescribeTableResponse.MetastoreDescribeTable_TableParameter();
				tableParameter.Key = context.StringValue("MetastoreDescribeTable.TableParameters["+ i +"].Key");
				tableParameter._Value = context.StringValue("MetastoreDescribeTable.TableParameters["+ i +"].Value");

				metastoreDescribeTableResponse_tableParameters.Add(tableParameter);
			}
			metastoreDescribeTableResponse.TableParameters = metastoreDescribeTableResponse_tableParameters;
        
			return metastoreDescribeTableResponse;
        }
    }
}
