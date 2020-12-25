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
    public class ListDataSourceResponseUnmarshaller
    {
        public static ListDataSourceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDataSourceResponse listDataSourceResponse = new ListDataSourceResponse();

			listDataSourceResponse.HttpResponse = _ctx.HttpResponse;
			listDataSourceResponse.RequestId = _ctx.StringValue("ListDataSource.RequestId");
			listDataSourceResponse.Total = _ctx.IntegerValue("ListDataSource.Total");
			listDataSourceResponse.PageSize = _ctx.IntegerValue("ListDataSource.PageSize");
			listDataSourceResponse.PageNumber = _ctx.IntegerValue("ListDataSource.PageNumber");

			List<ListDataSourceResponse.ListDataSource_DataSource> listDataSourceResponse_dataSourceList = new List<ListDataSourceResponse.ListDataSource_DataSource>();
			for (int i = 0; i < _ctx.Length("ListDataSource.DataSourceList.Length"); i++) {
				ListDataSourceResponse.ListDataSource_DataSource dataSource = new ListDataSourceResponse.ListDataSource_DataSource();
				dataSource.Id = _ctx.StringValue("ListDataSource.DataSourceList["+ i +"].Id");
				dataSource.Name = _ctx.StringValue("ListDataSource.DataSourceList["+ i +"].Name");
				dataSource.Description = _ctx.StringValue("ListDataSource.DataSourceList["+ i +"].Description");
				dataSource.Status = _ctx.StringValue("ListDataSource.DataSourceList["+ i +"].Status");
				dataSource.SourceType = _ctx.StringValue("ListDataSource.DataSourceList["+ i +"].SourceType");
				dataSource.CreateFrom = _ctx.StringValue("ListDataSource.DataSourceList["+ i +"].CreateFrom");
				dataSource.Conf = _ctx.StringValue("ListDataSource.DataSourceList["+ i +"].Conf");
				dataSource.ClusterId = _ctx.StringValue("ListDataSource.DataSourceList["+ i +"].ClusterId");
				dataSource.Creator = _ctx.StringValue("ListDataSource.DataSourceList["+ i +"].Creator");
				dataSource.Modifier = _ctx.StringValue("ListDataSource.DataSourceList["+ i +"].Modifier");
				dataSource.GmtCreate = _ctx.LongValue("ListDataSource.DataSourceList["+ i +"].GmtCreate");
				dataSource.GmtModified = _ctx.LongValue("ListDataSource.DataSourceList["+ i +"].GmtModified");

				listDataSourceResponse_dataSourceList.Add(dataSource);
			}
			listDataSourceResponse.DataSourceList = listDataSourceResponse_dataSourceList;
        
			return listDataSourceResponse;
        }
    }
}
