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
    public class GetParserDataSourceResponseUnmarshaller
    {
        public static GetParserDataSourceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetParserDataSourceResponse getParserDataSourceResponse = new GetParserDataSourceResponse();

			getParserDataSourceResponse.HttpResponse = _ctx.HttpResponse;
			getParserDataSourceResponse.RequestId = _ctx.StringValue("GetParserDataSource.RequestId");
			getParserDataSourceResponse.Success = _ctx.BooleanValue("GetParserDataSource.Success");
			getParserDataSourceResponse.Code = _ctx.StringValue("GetParserDataSource.Code");
			getParserDataSourceResponse.ErrorMessage = _ctx.StringValue("GetParserDataSource.ErrorMessage");

			GetParserDataSourceResponse.GetParserDataSource_DataSource dataSource = new GetParserDataSourceResponse.GetParserDataSource_DataSource();
			dataSource.Name = _ctx.StringValue("GetParserDataSource.DataSource.Name");
			dataSource.Description = _ctx.StringValue("GetParserDataSource.DataSource.Description");
			dataSource.DataSourceId = _ctx.LongValue("GetParserDataSource.DataSource.DataSourceId");
			dataSource.UtcCreated = _ctx.StringValue("GetParserDataSource.DataSource.UtcCreated");
			dataSource.CreateUserId = _ctx.LongValue("GetParserDataSource.DataSource.CreateUserId");
			getParserDataSourceResponse.DataSource = dataSource;
        
			return getParserDataSourceResponse;
        }
    }
}
