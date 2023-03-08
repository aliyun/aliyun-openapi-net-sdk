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
using Aliyun.Acs.adb.Model.V20211201;

namespace Aliyun.Acs.adb.Transform.V20211201
{
    public class GetTableResponseUnmarshaller
    {
        public static GetTableResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetTableResponse getTableResponse = new GetTableResponse();

			getTableResponse.HttpResponse = _ctx.HttpResponse;
			getTableResponse.RequestId = _ctx.StringValue("GetTable.RequestId");
			getTableResponse.Code = _ctx.LongValue("GetTable.Code");
			getTableResponse.Message = _ctx.StringValue("GetTable.Message");
			getTableResponse.Success = _ctx.BooleanValue("GetTable.Success");

			GetTableResponse.GetTable_Table table = new GetTableResponse.GetTable_Table();
			table.TblId = _ctx.LongValue("GetTable.Table.TblId");
			table.DbName = _ctx.StringValue("GetTable.Table.DbName");
			table.TableName = _ctx.StringValue("GetTable.Table.TableName");
			table.TableType = _ctx.StringValue("GetTable.Table.TableType");
			table.Parameters = _ctx.StringValue("GetTable.Table.Parameters");
			table.CreateTime = _ctx.StringValue("GetTable.Table.CreateTime");
			table.ViewOriginalText = _ctx.StringValue("GetTable.Table.ViewOriginalText");
			table.ViewExpandedText = _ctx.StringValue("GetTable.Table.ViewExpandedText");
			table.Temporary = _ctx.BooleanValue("GetTable.Table.Temporary");
			table.Comment = _ctx.StringValue("GetTable.Table.Comment");
			table.PhysicalTableName = _ctx.StringValue("GetTable.Table.PhysicalTableName");
			table.PhysicalDatabaseName = _ctx.StringValue("GetTable.Table.PhysicalDatabaseName");
			table.DistributeType = _ctx.StringValue("GetTable.Table.DistributeType");
			table.PartitionType = _ctx.StringValue("GetTable.Table.PartitionType");
			table.PartitionColumn = _ctx.StringValue("GetTable.Table.PartitionColumn");
			table.PartitionCount = _ctx.LongValue("GetTable.Table.PartitionCount");
			table.PreviousVersion = _ctx.LongValue("GetTable.Table.PreviousVersion");
			table.CurrentVersion = _ctx.LongValue("GetTable.Table.CurrentVersion");
			table.UpdateTime = _ctx.StringValue("GetTable.Table.UpdateTime");
			table.TableEngineName = _ctx.StringValue("GetTable.Table.TableEngineName");
			table.IsAllIndex = _ctx.BooleanValue("GetTable.Table.IsAllIndex");
			table.BlockSize = _ctx.LongValue("GetTable.Table.BlockSize");
			table.Compression = _ctx.StringValue("GetTable.Table.Compression");
			table.RawTableName = _ctx.StringValue("GetTable.Table.RawTableName");
			table.SubpartitionType = _ctx.StringValue("GetTable.Table.SubpartitionType");
			table.SubpartitionColumn = _ctx.StringValue("GetTable.Table.SubpartitionColumn");
			table.SubpartitionCount = _ctx.LongValue("GetTable.Table.SubpartitionCount");
			table.ArchiveType = _ctx.StringValue("GetTable.Table.ArchiveType");
			table.MaxColumnId = _ctx.LongValue("GetTable.Table.MaxColumnId");
			table.EnableDfs = _ctx.BooleanValue("GetTable.Table.EnableDfs");
			table.StoragePolicy = _ctx.StringValue("GetTable.Table.StoragePolicy");
			table.HotPartitionCount = _ctx.LongValue("GetTable.Table.HotPartitionCount");
			table.IsFulltextDict = _ctx.BooleanValue("GetTable.Table.IsFulltextDict");
			table.RtIndexAll = _ctx.BooleanValue("GetTable.Table.RtIndexAll");
			table.RtEngineType = _ctx.StringValue("GetTable.Table.RtEngineType");
			table.RtModeType = _ctx.StringValue("GetTable.Table.RtModeType");
			table.RouteType = _ctx.StringValue("GetTable.Table.RouteType");
			table.DictEncode = _ctx.BooleanValue("GetTable.Table.DictEncode");
			table.BucketCount = _ctx.LongValue("GetTable.Table.BucketCount");
			table.Bucket = _ctx.LongValue("GetTable.Table.Bucket");
			table.ViewSecurityMode = _ctx.StringValue("GetTable.Table.ViewSecurityMode");

			GetTableResponse.GetTable_Table.GetTable_Sd sd = new GetTableResponse.GetTable_Table.GetTable_Sd();
			sd.SdId = _ctx.LongValue("GetTable.Table.Sd.SdId");
			sd.Location = _ctx.StringValue("GetTable.Table.Sd.Location");
			sd.InputFormat = _ctx.StringValue("GetTable.Table.Sd.InputFormat");
			sd.OutputFormat = _ctx.StringValue("GetTable.Table.Sd.OutputFormat");
			sd.Compressed = _ctx.BooleanValue("GetTable.Table.Sd.Compressed");
			sd.NumBuckets = _ctx.LongValue("GetTable.Table.Sd.NumBuckets");
			sd.Parameters = _ctx.StringValue("GetTable.Table.Sd.Parameters");
			sd.StoredAsSubDirectories = _ctx.BooleanValue("GetTable.Table.Sd.StoredAsSubDirectories");

			GetTableResponse.GetTable_Table.GetTable_Sd.GetTable_SerDeInfo serDeInfo = new GetTableResponse.GetTable_Table.GetTable_Sd.GetTable_SerDeInfo();
			serDeInfo.SerDeId = _ctx.LongValue("GetTable.Table.Sd.SerDeInfo.SerDeId");
			serDeInfo.Name = _ctx.StringValue("GetTable.Table.Sd.SerDeInfo.Name");
			serDeInfo.Parameters = _ctx.StringValue("GetTable.Table.Sd.SerDeInfo.Parameters");
			serDeInfo.SerializationLib = _ctx.StringValue("GetTable.Table.Sd.SerDeInfo.SerializationLib");
			sd.SerDeInfo = serDeInfo;
			table.Sd = sd;

			GetTableResponse.GetTable_Table.GetTable_RouteEffectiveColumn routeEffectiveColumn = new GetTableResponse.GetTable_Table.GetTable_RouteEffectiveColumn();
			routeEffectiveColumn.Name = _ctx.StringValue("GetTable.Table.RouteEffectiveColumn.Name");
			routeEffectiveColumn.Type = _ctx.StringValue("GetTable.Table.RouteEffectiveColumn.Type");
			routeEffectiveColumn.Comment = _ctx.StringValue("GetTable.Table.RouteEffectiveColumn.Comment");
			routeEffectiveColumn.DatabaseName = _ctx.StringValue("GetTable.Table.RouteEffectiveColumn.DatabaseName");
			routeEffectiveColumn.TableName = _ctx.StringValue("GetTable.Table.RouteEffectiveColumn.TableName");
			routeEffectiveColumn.MappedName = _ctx.StringValue("GetTable.Table.RouteEffectiveColumn.MappedName");
			routeEffectiveColumn.DataType = _ctx.StringValue("GetTable.Table.RouteEffectiveColumn.DataType");
			routeEffectiveColumn.CreateTime = _ctx.StringValue("GetTable.Table.RouteEffectiveColumn.CreateTime");
			routeEffectiveColumn.UpdateTime = _ctx.StringValue("GetTable.Table.RouteEffectiveColumn.UpdateTime");
			routeEffectiveColumn.PkPosition = _ctx.LongValue("GetTable.Table.RouteEffectiveColumn.PkPosition");
			routeEffectiveColumn.IsPartitionKey = _ctx.BooleanValue("GetTable.Table.RouteEffectiveColumn.IsPartitionKey");
			routeEffectiveColumn.OrdinalPosition = _ctx.LongValue("GetTable.Table.RouteEffectiveColumn.OrdinalPosition");
			routeEffectiveColumn.ColumnRawName = _ctx.StringValue("GetTable.Table.RouteEffectiveColumn.ColumnRawName");
			routeEffectiveColumn.PhysicalColumnName = _ctx.StringValue("GetTable.Table.RouteEffectiveColumn.PhysicalColumnName");
			routeEffectiveColumn.Nullable = _ctx.BooleanValue("GetTable.Table.RouteEffectiveColumn.Nullable");
			routeEffectiveColumn.AutoIncrement = _ctx.BooleanValue("GetTable.Table.RouteEffectiveColumn.AutoIncrement");
			routeEffectiveColumn.Precision = _ctx.LongValue("GetTable.Table.RouteEffectiveColumn.Precision");
			routeEffectiveColumn.Scale = _ctx.LongValue("GetTable.Table.RouteEffectiveColumn.Scale");
			routeEffectiveColumn.Primarykey = _ctx.BooleanValue("GetTable.Table.RouteEffectiveColumn.Primarykey");
			routeEffectiveColumn.DefaultValue = _ctx.StringValue("GetTable.Table.RouteEffectiveColumn.DefaultValue");
			routeEffectiveColumn.Tokenizer = _ctx.StringValue("GetTable.Table.RouteEffectiveColumn.Tokenizer");
			routeEffectiveColumn.Encode = _ctx.StringValue("GetTable.Table.RouteEffectiveColumn.Encode");
			routeEffectiveColumn.Compression = _ctx.StringValue("GetTable.Table.RouteEffectiveColumn.Compression");
			routeEffectiveColumn.Delimiter = _ctx.StringValue("GetTable.Table.RouteEffectiveColumn.Delimiter");
			routeEffectiveColumn.ValueType = _ctx.StringValue("GetTable.Table.RouteEffectiveColumn.ValueType");
			routeEffectiveColumn.CompressFloatUseShort = _ctx.BooleanValue("GetTable.Table.RouteEffectiveColumn.CompressFloatUseShort");
			routeEffectiveColumn.OnUpdate = _ctx.StringValue("GetTable.Table.RouteEffectiveColumn.OnUpdate");
			table.RouteEffectiveColumn = routeEffectiveColumn;

			List<GetTableResponse.GetTable_Table.GetTable_PartitionKeysItem> table_partitionKeys = new List<GetTableResponse.GetTable_Table.GetTable_PartitionKeysItem>();
			for (int i = 0; i < _ctx.Length("GetTable.Table.PartitionKeys.Length"); i++) {
				GetTableResponse.GetTable_Table.GetTable_PartitionKeysItem partitionKeysItem = new GetTableResponse.GetTable_Table.GetTable_PartitionKeysItem();
				partitionKeysItem.Name = _ctx.StringValue("GetTable.Table.PartitionKeys["+ i +"].Name");
				partitionKeysItem.Type = _ctx.StringValue("GetTable.Table.PartitionKeys["+ i +"].Type");
				partitionKeysItem.Comment = _ctx.StringValue("GetTable.Table.PartitionKeys["+ i +"].Comment");
				partitionKeysItem.DatabaseName = _ctx.StringValue("GetTable.Table.PartitionKeys["+ i +"].DatabaseName");
				partitionKeysItem.TableName = _ctx.StringValue("GetTable.Table.PartitionKeys["+ i +"].TableName");
				partitionKeysItem.MappedName = _ctx.StringValue("GetTable.Table.PartitionKeys["+ i +"].MappedName");
				partitionKeysItem.DataType = _ctx.StringValue("GetTable.Table.PartitionKeys["+ i +"].DataType");
				partitionKeysItem.CreateTime = _ctx.StringValue("GetTable.Table.PartitionKeys["+ i +"].CreateTime");
				partitionKeysItem.UpdateTime = _ctx.StringValue("GetTable.Table.PartitionKeys["+ i +"].UpdateTime");
				partitionKeysItem.PkPosition = _ctx.LongValue("GetTable.Table.PartitionKeys["+ i +"].PkPosition");
				partitionKeysItem.IsPartitionKey = _ctx.BooleanValue("GetTable.Table.PartitionKeys["+ i +"].IsPartitionKey");
				partitionKeysItem.OrdinalPosition = _ctx.LongValue("GetTable.Table.PartitionKeys["+ i +"].OrdinalPosition");
				partitionKeysItem.ColumnRawName = _ctx.StringValue("GetTable.Table.PartitionKeys["+ i +"].ColumnRawName");
				partitionKeysItem.PhysicalColumnName = _ctx.StringValue("GetTable.Table.PartitionKeys["+ i +"].PhysicalColumnName");
				partitionKeysItem.Nullable = _ctx.BooleanValue("GetTable.Table.PartitionKeys["+ i +"].Nullable");
				partitionKeysItem.AutoIncrement = _ctx.BooleanValue("GetTable.Table.PartitionKeys["+ i +"].AutoIncrement");
				partitionKeysItem.Precision = _ctx.LongValue("GetTable.Table.PartitionKeys["+ i +"].Precision");
				partitionKeysItem.Scale = _ctx.LongValue("GetTable.Table.PartitionKeys["+ i +"].Scale");
				partitionKeysItem.Primarykey = _ctx.BooleanValue("GetTable.Table.PartitionKeys["+ i +"].Primarykey");
				partitionKeysItem.DefaultValue = _ctx.StringValue("GetTable.Table.PartitionKeys["+ i +"].DefaultValue");
				partitionKeysItem.Tokenizer = _ctx.StringValue("GetTable.Table.PartitionKeys["+ i +"].Tokenizer");
				partitionKeysItem.Encode = _ctx.StringValue("GetTable.Table.PartitionKeys["+ i +"].Encode");
				partitionKeysItem.Compression = _ctx.StringValue("GetTable.Table.PartitionKeys["+ i +"].Compression");
				partitionKeysItem.Delimiter = _ctx.StringValue("GetTable.Table.PartitionKeys["+ i +"].Delimiter");
				partitionKeysItem.ValueType = _ctx.StringValue("GetTable.Table.PartitionKeys["+ i +"].ValueType");
				partitionKeysItem.CompressFloatUseShort = _ctx.BooleanValue("GetTable.Table.PartitionKeys["+ i +"].CompressFloatUseShort");
				partitionKeysItem.OnUpdate = _ctx.StringValue("GetTable.Table.PartitionKeys["+ i +"].OnUpdate");

				table_partitionKeys.Add(partitionKeysItem);
			}
			table.PartitionKeys = table_partitionKeys;

			List<GetTableResponse.GetTable_Table.GetTable_ColsItem> table_cols = new List<GetTableResponse.GetTable_Table.GetTable_ColsItem>();
			for (int i = 0; i < _ctx.Length("GetTable.Table.Cols.Length"); i++) {
				GetTableResponse.GetTable_Table.GetTable_ColsItem colsItem = new GetTableResponse.GetTable_Table.GetTable_ColsItem();
				colsItem.Name = _ctx.StringValue("GetTable.Table.Cols["+ i +"].Name");
				colsItem.Type = _ctx.StringValue("GetTable.Table.Cols["+ i +"].Type");
				colsItem.Comment = _ctx.StringValue("GetTable.Table.Cols["+ i +"].Comment");
				colsItem.DatabaseName = _ctx.StringValue("GetTable.Table.Cols["+ i +"].DatabaseName");
				colsItem.TableName = _ctx.StringValue("GetTable.Table.Cols["+ i +"].TableName");
				colsItem.MappedName = _ctx.StringValue("GetTable.Table.Cols["+ i +"].MappedName");
				colsItem.DataType = _ctx.StringValue("GetTable.Table.Cols["+ i +"].DataType");
				colsItem.CreateTime = _ctx.StringValue("GetTable.Table.Cols["+ i +"].CreateTime");
				colsItem.UpdateTime = _ctx.StringValue("GetTable.Table.Cols["+ i +"].UpdateTime");
				colsItem.PkPosition = _ctx.LongValue("GetTable.Table.Cols["+ i +"].PkPosition");
				colsItem.IsPartitionKey = _ctx.BooleanValue("GetTable.Table.Cols["+ i +"].IsPartitionKey");
				colsItem.OrdinalPosition = _ctx.LongValue("GetTable.Table.Cols["+ i +"].OrdinalPosition");
				colsItem.ColumnRawName = _ctx.StringValue("GetTable.Table.Cols["+ i +"].ColumnRawName");
				colsItem.PhysicalColumnName = _ctx.StringValue("GetTable.Table.Cols["+ i +"].PhysicalColumnName");
				colsItem.Nullable = _ctx.BooleanValue("GetTable.Table.Cols["+ i +"].Nullable");
				colsItem.AutoIncrement = _ctx.BooleanValue("GetTable.Table.Cols["+ i +"].AutoIncrement");
				colsItem.Precision = _ctx.LongValue("GetTable.Table.Cols["+ i +"].Precision");
				colsItem.Scale = _ctx.LongValue("GetTable.Table.Cols["+ i +"].Scale");
				colsItem.Primarykey = _ctx.BooleanValue("GetTable.Table.Cols["+ i +"].Primarykey");
				colsItem.DefaultValue = _ctx.StringValue("GetTable.Table.Cols["+ i +"].DefaultValue");
				colsItem.Tokenizer = _ctx.StringValue("GetTable.Table.Cols["+ i +"].Tokenizer");
				colsItem.Encode = _ctx.StringValue("GetTable.Table.Cols["+ i +"].Encode");
				colsItem.Compression = _ctx.StringValue("GetTable.Table.Cols["+ i +"].Compression");
				colsItem.Delimiter = _ctx.StringValue("GetTable.Table.Cols["+ i +"].Delimiter");
				colsItem.ValueType = _ctx.StringValue("GetTable.Table.Cols["+ i +"].ValueType");
				colsItem.CompressFloatUseShort = _ctx.BooleanValue("GetTable.Table.Cols["+ i +"].CompressFloatUseShort");
				colsItem.OnUpdate = _ctx.StringValue("GetTable.Table.Cols["+ i +"].OnUpdate");

				table_cols.Add(colsItem);
			}
			table.Cols = table_cols;

			List<GetTableResponse.GetTable_Table.GetTable_DistributeColumnsItem> table_distributeColumns = new List<GetTableResponse.GetTable_Table.GetTable_DistributeColumnsItem>();
			for (int i = 0; i < _ctx.Length("GetTable.Table.DistributeColumns.Length"); i++) {
				GetTableResponse.GetTable_Table.GetTable_DistributeColumnsItem distributeColumnsItem = new GetTableResponse.GetTable_Table.GetTable_DistributeColumnsItem();
				distributeColumnsItem.Name = _ctx.StringValue("GetTable.Table.DistributeColumns["+ i +"].Name");
				distributeColumnsItem.Type = _ctx.StringValue("GetTable.Table.DistributeColumns["+ i +"].Type");
				distributeColumnsItem.Comment = _ctx.StringValue("GetTable.Table.DistributeColumns["+ i +"].Comment");
				distributeColumnsItem.DatabaseName = _ctx.StringValue("GetTable.Table.DistributeColumns["+ i +"].DatabaseName");
				distributeColumnsItem.TableName = _ctx.StringValue("GetTable.Table.DistributeColumns["+ i +"].TableName");
				distributeColumnsItem.MappedName = _ctx.StringValue("GetTable.Table.DistributeColumns["+ i +"].MappedName");
				distributeColumnsItem.DataType = _ctx.StringValue("GetTable.Table.DistributeColumns["+ i +"].DataType");
				distributeColumnsItem.CreateTime = _ctx.StringValue("GetTable.Table.DistributeColumns["+ i +"].CreateTime");
				distributeColumnsItem.UpdateTime = _ctx.StringValue("GetTable.Table.DistributeColumns["+ i +"].UpdateTime");
				distributeColumnsItem.PkPosition = _ctx.LongValue("GetTable.Table.DistributeColumns["+ i +"].PkPosition");
				distributeColumnsItem.IsPartitionKey = _ctx.BooleanValue("GetTable.Table.DistributeColumns["+ i +"].IsPartitionKey");
				distributeColumnsItem.OrdinalPosition = _ctx.LongValue("GetTable.Table.DistributeColumns["+ i +"].OrdinalPosition");
				distributeColumnsItem.ColumnRawName = _ctx.StringValue("GetTable.Table.DistributeColumns["+ i +"].ColumnRawName");
				distributeColumnsItem.PhysicalColumnName = _ctx.StringValue("GetTable.Table.DistributeColumns["+ i +"].PhysicalColumnName");
				distributeColumnsItem.Nullable = _ctx.BooleanValue("GetTable.Table.DistributeColumns["+ i +"].Nullable");
				distributeColumnsItem.AutoIncrement = _ctx.BooleanValue("GetTable.Table.DistributeColumns["+ i +"].AutoIncrement");
				distributeColumnsItem.Precision = _ctx.LongValue("GetTable.Table.DistributeColumns["+ i +"].Precision");
				distributeColumnsItem.Scale = _ctx.LongValue("GetTable.Table.DistributeColumns["+ i +"].Scale");
				distributeColumnsItem.Primarykey = _ctx.BooleanValue("GetTable.Table.DistributeColumns["+ i +"].Primarykey");
				distributeColumnsItem.DefaultValue = _ctx.StringValue("GetTable.Table.DistributeColumns["+ i +"].DefaultValue");
				distributeColumnsItem.Tokenizer = _ctx.StringValue("GetTable.Table.DistributeColumns["+ i +"].Tokenizer");
				distributeColumnsItem.Encode = _ctx.StringValue("GetTable.Table.DistributeColumns["+ i +"].Encode");
				distributeColumnsItem.Compression = _ctx.StringValue("GetTable.Table.DistributeColumns["+ i +"].Compression");
				distributeColumnsItem.Delimiter = _ctx.StringValue("GetTable.Table.DistributeColumns["+ i +"].Delimiter");
				distributeColumnsItem.ValueType = _ctx.StringValue("GetTable.Table.DistributeColumns["+ i +"].ValueType");
				distributeColumnsItem.CompressFloatUseShort = _ctx.BooleanValue("GetTable.Table.DistributeColumns["+ i +"].CompressFloatUseShort");
				distributeColumnsItem.OnUpdate = _ctx.StringValue("GetTable.Table.DistributeColumns["+ i +"].OnUpdate");

				table_distributeColumns.Add(distributeColumnsItem);
			}
			table.DistributeColumns = table_distributeColumns;

			List<GetTableResponse.GetTable_Table.GetTable_RouteColumnsItem> table_routeColumns = new List<GetTableResponse.GetTable_Table.GetTable_RouteColumnsItem>();
			for (int i = 0; i < _ctx.Length("GetTable.Table.RouteColumns.Length"); i++) {
				GetTableResponse.GetTable_Table.GetTable_RouteColumnsItem routeColumnsItem = new GetTableResponse.GetTable_Table.GetTable_RouteColumnsItem();
				routeColumnsItem.Name = _ctx.StringValue("GetTable.Table.RouteColumns["+ i +"].Name");
				routeColumnsItem.Type = _ctx.StringValue("GetTable.Table.RouteColumns["+ i +"].Type");
				routeColumnsItem.Comment = _ctx.StringValue("GetTable.Table.RouteColumns["+ i +"].Comment");
				routeColumnsItem.DatabaseName = _ctx.StringValue("GetTable.Table.RouteColumns["+ i +"].DatabaseName");
				routeColumnsItem.TableName = _ctx.StringValue("GetTable.Table.RouteColumns["+ i +"].TableName");
				routeColumnsItem.MappedName = _ctx.StringValue("GetTable.Table.RouteColumns["+ i +"].MappedName");
				routeColumnsItem.DataType = _ctx.StringValue("GetTable.Table.RouteColumns["+ i +"].DataType");
				routeColumnsItem.CreateTime = _ctx.StringValue("GetTable.Table.RouteColumns["+ i +"].CreateTime");
				routeColumnsItem.UpdateTime = _ctx.StringValue("GetTable.Table.RouteColumns["+ i +"].UpdateTime");
				routeColumnsItem.PkPosition = _ctx.LongValue("GetTable.Table.RouteColumns["+ i +"].PkPosition");
				routeColumnsItem.IsPartitionKey = _ctx.BooleanValue("GetTable.Table.RouteColumns["+ i +"].IsPartitionKey");
				routeColumnsItem.OrdinalPosition = _ctx.LongValue("GetTable.Table.RouteColumns["+ i +"].OrdinalPosition");
				routeColumnsItem.ColumnRawName = _ctx.StringValue("GetTable.Table.RouteColumns["+ i +"].ColumnRawName");
				routeColumnsItem.PhysicalColumnName = _ctx.StringValue("GetTable.Table.RouteColumns["+ i +"].PhysicalColumnName");
				routeColumnsItem.Nullable = _ctx.BooleanValue("GetTable.Table.RouteColumns["+ i +"].Nullable");
				routeColumnsItem.AutoIncrement = _ctx.BooleanValue("GetTable.Table.RouteColumns["+ i +"].AutoIncrement");
				routeColumnsItem.Precision = _ctx.LongValue("GetTable.Table.RouteColumns["+ i +"].Precision");
				routeColumnsItem.Scale = _ctx.LongValue("GetTable.Table.RouteColumns["+ i +"].Scale");
				routeColumnsItem.Primarykey = _ctx.BooleanValue("GetTable.Table.RouteColumns["+ i +"].Primarykey");
				routeColumnsItem.DefaultValue = _ctx.StringValue("GetTable.Table.RouteColumns["+ i +"].DefaultValue");
				routeColumnsItem.Tokenizer = _ctx.StringValue("GetTable.Table.RouteColumns["+ i +"].Tokenizer");
				routeColumnsItem.Encode = _ctx.StringValue("GetTable.Table.RouteColumns["+ i +"].Encode");
				routeColumnsItem.Compression = _ctx.StringValue("GetTable.Table.RouteColumns["+ i +"].Compression");
				routeColumnsItem.Delimiter = _ctx.StringValue("GetTable.Table.RouteColumns["+ i +"].Delimiter");
				routeColumnsItem.ValueType = _ctx.StringValue("GetTable.Table.RouteColumns["+ i +"].ValueType");
				routeColumnsItem.CompressFloatUseShort = _ctx.BooleanValue("GetTable.Table.RouteColumns["+ i +"].CompressFloatUseShort");
				routeColumnsItem.OnUpdate = _ctx.StringValue("GetTable.Table.RouteColumns["+ i +"].OnUpdate");

				table_routeColumns.Add(routeColumnsItem);
			}
			table.RouteColumns = table_routeColumns;

			List<GetTableResponse.GetTable_Table.GetTable_IndexesItem> table_indexes = new List<GetTableResponse.GetTable_Table.GetTable_IndexesItem>();
			for (int i = 0; i < _ctx.Length("GetTable.Table.Indexes.Length"); i++) {
				GetTableResponse.GetTable_Table.GetTable_IndexesItem indexesItem = new GetTableResponse.GetTable_Table.GetTable_IndexesItem();
				indexesItem.DatabaseName = _ctx.StringValue("GetTable.Table.Indexes["+ i +"].DatabaseName");
				indexesItem.PhysicalTableName = _ctx.StringValue("GetTable.Table.Indexes["+ i +"].PhysicalTableName");
				indexesItem.IndexName = _ctx.StringValue("GetTable.Table.Indexes["+ i +"].IndexName");
				indexesItem.IndexType = _ctx.StringValue("GetTable.Table.Indexes["+ i +"].IndexType");
				indexesItem.Options = _ctx.StringValue("GetTable.Table.Indexes["+ i +"].Options");
				indexesItem.CreateTime = _ctx.StringValue("GetTable.Table.Indexes["+ i +"].CreateTime");
				indexesItem.UpdateTime = _ctx.StringValue("GetTable.Table.Indexes["+ i +"].UpdateTime");

				List<string> indexesItem_columnOrds = new List<string>();
				for (int j = 0; j < _ctx.Length("GetTable.Table.Indexes["+ i +"].ColumnOrds.Length"); j++) {
					indexesItem_columnOrds.Add(_ctx.StringValue("GetTable.Table.Indexes["+ i +"].ColumnOrds["+ j +"]"));
				}
				indexesItem.ColumnOrds = indexesItem_columnOrds;

				List<GetTableResponse.GetTable_Table.GetTable_IndexesItem.GetTable_IndexColumnsItem> indexesItem_indexColumns = new List<GetTableResponse.GetTable_Table.GetTable_IndexesItem.GetTable_IndexColumnsItem>();
				for (int j = 0; j < _ctx.Length("GetTable.Table.Indexes["+ i +"].IndexColumns.Length"); j++) {
					GetTableResponse.GetTable_Table.GetTable_IndexesItem.GetTable_IndexColumnsItem indexColumnsItem = new GetTableResponse.GetTable_Table.GetTable_IndexesItem.GetTable_IndexColumnsItem();
					indexColumnsItem.Name = _ctx.StringValue("GetTable.Table.Indexes["+ i +"].IndexColumns["+ j +"].Name");
					indexColumnsItem.Type = _ctx.StringValue("GetTable.Table.Indexes["+ i +"].IndexColumns["+ j +"].Type");
					indexColumnsItem.Comment = _ctx.StringValue("GetTable.Table.Indexes["+ i +"].IndexColumns["+ j +"].Comment");
					indexColumnsItem.DatabaseName = _ctx.StringValue("GetTable.Table.Indexes["+ i +"].IndexColumns["+ j +"].DatabaseName");
					indexColumnsItem.TableName = _ctx.StringValue("GetTable.Table.Indexes["+ i +"].IndexColumns["+ j +"].TableName");
					indexColumnsItem.MappedName = _ctx.StringValue("GetTable.Table.Indexes["+ i +"].IndexColumns["+ j +"].MappedName");
					indexColumnsItem.DataType = _ctx.StringValue("GetTable.Table.Indexes["+ i +"].IndexColumns["+ j +"].DataType");
					indexColumnsItem.CreateTime = _ctx.StringValue("GetTable.Table.Indexes["+ i +"].IndexColumns["+ j +"].CreateTime");
					indexColumnsItem.UpdateTime = _ctx.StringValue("GetTable.Table.Indexes["+ i +"].IndexColumns["+ j +"].UpdateTime");
					indexColumnsItem.PkPosition = _ctx.LongValue("GetTable.Table.Indexes["+ i +"].IndexColumns["+ j +"].PkPosition");
					indexColumnsItem.IsPartitionKey = _ctx.BooleanValue("GetTable.Table.Indexes["+ i +"].IndexColumns["+ j +"].IsPartitionKey");
					indexColumnsItem.OrdinalPosition = _ctx.LongValue("GetTable.Table.Indexes["+ i +"].IndexColumns["+ j +"].OrdinalPosition");
					indexColumnsItem.ColumnRawName = _ctx.StringValue("GetTable.Table.Indexes["+ i +"].IndexColumns["+ j +"].ColumnRawName");
					indexColumnsItem.PhysicalColumnName = _ctx.StringValue("GetTable.Table.Indexes["+ i +"].IndexColumns["+ j +"].PhysicalColumnName");
					indexColumnsItem.Nullable = _ctx.BooleanValue("GetTable.Table.Indexes["+ i +"].IndexColumns["+ j +"].Nullable");
					indexColumnsItem.AutoIncrement = _ctx.BooleanValue("GetTable.Table.Indexes["+ i +"].IndexColumns["+ j +"].AutoIncrement");
					indexColumnsItem.Precision = _ctx.LongValue("GetTable.Table.Indexes["+ i +"].IndexColumns["+ j +"].Precision");
					indexColumnsItem.Scale = _ctx.LongValue("GetTable.Table.Indexes["+ i +"].IndexColumns["+ j +"].Scale");
					indexColumnsItem.Primarykey = _ctx.BooleanValue("GetTable.Table.Indexes["+ i +"].IndexColumns["+ j +"].Primarykey");
					indexColumnsItem.DefaultValue = _ctx.StringValue("GetTable.Table.Indexes["+ i +"].IndexColumns["+ j +"].DefaultValue");
					indexColumnsItem.Tokenizer = _ctx.StringValue("GetTable.Table.Indexes["+ i +"].IndexColumns["+ j +"].Tokenizer");
					indexColumnsItem.Encode = _ctx.StringValue("GetTable.Table.Indexes["+ i +"].IndexColumns["+ j +"].Encode");
					indexColumnsItem.Compression = _ctx.StringValue("GetTable.Table.Indexes["+ i +"].IndexColumns["+ j +"].Compression");
					indexColumnsItem.Delimiter = _ctx.StringValue("GetTable.Table.Indexes["+ i +"].IndexColumns["+ j +"].Delimiter");
					indexColumnsItem.ValueType = _ctx.StringValue("GetTable.Table.Indexes["+ i +"].IndexColumns["+ j +"].ValueType");
					indexColumnsItem.CompressFloatUseShort = _ctx.BooleanValue("GetTable.Table.Indexes["+ i +"].IndexColumns["+ j +"].CompressFloatUseShort");
					indexColumnsItem.OnUpdate = _ctx.StringValue("GetTable.Table.Indexes["+ i +"].IndexColumns["+ j +"].OnUpdate");

					indexesItem_indexColumns.Add(indexColumnsItem);
				}
				indexesItem.IndexColumns = indexesItem_indexColumns;

				table_indexes.Add(indexesItem);
			}
			table.Indexes = table_indexes;
			getTableResponse.Table = table;
        
			return getTableResponse;
        }
    }
}
