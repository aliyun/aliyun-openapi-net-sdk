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
using Aliyun.Acs.Iot.Model.V20180120;

namespace Aliyun.Acs.Iot.Transform.V20180120
{
    public class ListParserDataSourceResponseUnmarshaller
    {
        public static ListParserDataSourceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListParserDataSourceResponse listParserDataSourceResponse = new ListParserDataSourceResponse();

			listParserDataSourceResponse.HttpResponse = _ctx.HttpResponse;
			listParserDataSourceResponse.RequestId = _ctx.StringValue("ListParserDataSource.RequestId");
			listParserDataSourceResponse.Success = _ctx.BooleanValue("ListParserDataSource.Success");
			listParserDataSourceResponse.Code = _ctx.StringValue("ListParserDataSource.Code");
			listParserDataSourceResponse.ErrorMessage = _ctx.StringValue("ListParserDataSource.ErrorMessage");
			listParserDataSourceResponse.Page = _ctx.IntegerValue("ListParserDataSource.Page");
			listParserDataSourceResponse.PageSize = _ctx.IntegerValue("ListParserDataSource.PageSize");
			listParserDataSourceResponse.Total = _ctx.IntegerValue("ListParserDataSource.Total");

			List<ListParserDataSourceResponse.ListParserDataSource_DataSource> listParserDataSourceResponse_data = new List<ListParserDataSourceResponse.ListParserDataSource_DataSource>();
			for (int i = 0; i < _ctx.Length("ListParserDataSource.Data.Length"); i++) {
				ListParserDataSourceResponse.ListParserDataSource_DataSource dataSource = new ListParserDataSourceResponse.ListParserDataSource_DataSource();
				dataSource.Name = _ctx.StringValue("ListParserDataSource.Data["+ i +"].Name");
				dataSource.Description = _ctx.StringValue("ListParserDataSource.Data["+ i +"].Description");
				dataSource.DataSourceId = _ctx.LongValue("ListParserDataSource.Data["+ i +"].DataSourceId");
				dataSource.UtcCreated = _ctx.StringValue("ListParserDataSource.Data["+ i +"].UtcCreated");

				listParserDataSourceResponse_data.Add(dataSource);
			}
			listParserDataSourceResponse.Data = listParserDataSourceResponse_data;
        
			return listParserDataSourceResponse;
        }
    }
}
