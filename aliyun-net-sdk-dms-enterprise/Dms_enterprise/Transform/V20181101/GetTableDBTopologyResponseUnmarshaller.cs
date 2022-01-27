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
using Aliyun.Acs.dms_enterprise.Model.V20181101;

namespace Aliyun.Acs.dms_enterprise.Transform.V20181101
{
    public class GetTableDBTopologyResponseUnmarshaller
    {
        public static GetTableDBTopologyResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetTableDBTopologyResponse getTableDBTopologyResponse = new GetTableDBTopologyResponse();

			getTableDBTopologyResponse.HttpResponse = _ctx.HttpResponse;
			getTableDBTopologyResponse.RequestId = _ctx.StringValue("GetTableDBTopology.RequestId");
			getTableDBTopologyResponse.ErrorCode = _ctx.StringValue("GetTableDBTopology.ErrorCode");
			getTableDBTopologyResponse.ErrorMessage = _ctx.StringValue("GetTableDBTopology.ErrorMessage");
			getTableDBTopologyResponse.Success = _ctx.BooleanValue("GetTableDBTopology.Success");

			GetTableDBTopologyResponse.GetTableDBTopology_DBTopology dBTopology = new GetTableDBTopologyResponse.GetTableDBTopology_DBTopology();
			dBTopology.TableName = _ctx.StringValue("GetTableDBTopology.DBTopology.TableName");
			dBTopology.TableGuid = _ctx.StringValue("GetTableDBTopology.DBTopology.TableGuid");

			List<GetTableDBTopologyResponse.GetTableDBTopology_DBTopology.GetTableDBTopology_DataSource> dBTopology_dataSourceList = new List<GetTableDBTopologyResponse.GetTableDBTopology_DBTopology.GetTableDBTopology_DataSource>();
			for (int i = 0; i < _ctx.Length("GetTableDBTopology.DBTopology.DataSourceList.Length"); i++) {
				GetTableDBTopologyResponse.GetTableDBTopology_DBTopology.GetTableDBTopology_DataSource dataSource = new GetTableDBTopologyResponse.GetTableDBTopology_DBTopology.GetTableDBTopology_DataSource();
				dataSource.Sid = _ctx.StringValue("GetTableDBTopology.DBTopology.DataSourceList["+ i +"].Sid");
				dataSource.Host = _ctx.StringValue("GetTableDBTopology.DBTopology.DataSourceList["+ i +"].Host");
				dataSource.DbType = _ctx.StringValue("GetTableDBTopology.DBTopology.DataSourceList["+ i +"].DbType");
				dataSource.Port = _ctx.IntegerValue("GetTableDBTopology.DBTopology.DataSourceList["+ i +"].Port");

				List<GetTableDBTopologyResponse.GetTableDBTopology_DBTopology.GetTableDBTopology_DataSource.GetTableDBTopology_Database> dataSource_databaseList = new List<GetTableDBTopologyResponse.GetTableDBTopology_DBTopology.GetTableDBTopology_DataSource.GetTableDBTopology_Database>();
				for (int j = 0; j < _ctx.Length("GetTableDBTopology.DBTopology.DataSourceList["+ i +"].DatabaseList.Length"); j++) {
					GetTableDBTopologyResponse.GetTableDBTopology_DBTopology.GetTableDBTopology_DataSource.GetTableDBTopology_Database database = new GetTableDBTopologyResponse.GetTableDBTopology_DBTopology.GetTableDBTopology_DataSource.GetTableDBTopology_Database();
					database.DbId = _ctx.StringValue("GetTableDBTopology.DBTopology.DataSourceList["+ i +"].DatabaseList["+ j +"].DbId");
					database.DbName = _ctx.StringValue("GetTableDBTopology.DBTopology.DataSourceList["+ i +"].DatabaseList["+ j +"].DbName");
					database.DbType = _ctx.StringValue("GetTableDBTopology.DBTopology.DataSourceList["+ i +"].DatabaseList["+ j +"].DbType");
					database.EnvType = _ctx.StringValue("GetTableDBTopology.DBTopology.DataSourceList["+ i +"].DatabaseList["+ j +"].EnvType");

					List<GetTableDBTopologyResponse.GetTableDBTopology_DBTopology.GetTableDBTopology_DataSource.GetTableDBTopology_Database.GetTableDBTopology_Table> database_tableList = new List<GetTableDBTopologyResponse.GetTableDBTopology_DBTopology.GetTableDBTopology_DataSource.GetTableDBTopology_Database.GetTableDBTopology_Table>();
					for (int k = 0; k < _ctx.Length("GetTableDBTopology.DBTopology.DataSourceList["+ i +"].DatabaseList["+ j +"].TableList.Length"); k++) {
						GetTableDBTopologyResponse.GetTableDBTopology_DBTopology.GetTableDBTopology_DataSource.GetTableDBTopology_Database.GetTableDBTopology_Table table = new GetTableDBTopologyResponse.GetTableDBTopology_DBTopology.GetTableDBTopology_DataSource.GetTableDBTopology_Database.GetTableDBTopology_Table();
						table.TableName = _ctx.StringValue("GetTableDBTopology.DBTopology.DataSourceList["+ i +"].DatabaseList["+ j +"].TableList["+ k +"].TableName");
						table.TableType = _ctx.StringValue("GetTableDBTopology.DBTopology.DataSourceList["+ i +"].DatabaseList["+ j +"].TableList["+ k +"].TableType");
						table.TableId = _ctx.StringValue("GetTableDBTopology.DBTopology.DataSourceList["+ i +"].DatabaseList["+ j +"].TableList["+ k +"].TableId");

						database_tableList.Add(table);
					}
					database.TableList = database_tableList;

					dataSource_databaseList.Add(database);
				}
				dataSource.DatabaseList = dataSource_databaseList;

				dBTopology_dataSourceList.Add(dataSource);
			}
			dBTopology.DataSourceList = dBTopology_dataSourceList;
			getTableDBTopologyResponse.DBTopology = dBTopology;
        
			return getTableDBTopologyResponse;
        }
    }
}
