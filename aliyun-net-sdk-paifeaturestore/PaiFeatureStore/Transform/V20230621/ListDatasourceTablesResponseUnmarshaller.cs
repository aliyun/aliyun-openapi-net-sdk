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
using Aliyun.Acs.PaiFeatureStore.Model.V20230621;

namespace Aliyun.Acs.PaiFeatureStore.Transform.V20230621
{
    public class ListDatasourceTablesResponseUnmarshaller
    {
        public static ListDatasourceTablesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDatasourceTablesResponse listDatasourceTablesResponse = new ListDatasourceTablesResponse();

			listDatasourceTablesResponse.HttpResponse = _ctx.HttpResponse;
			listDatasourceTablesResponse.RequestId = _ctx.StringValue("ListDatasourceTables.RequestId");
			listDatasourceTablesResponse.TotalCount = _ctx.LongValue("ListDatasourceTables.TotalCount");

			List<string> listDatasourceTablesResponse_tables = new List<string>();
			for (int i = 0; i < _ctx.Length("ListDatasourceTables.Tables.Length"); i++) {
				listDatasourceTablesResponse_tables.Add(_ctx.StringValue("ListDatasourceTables.Tables["+ i +"]"));
			}
			listDatasourceTablesResponse.Tables = listDatasourceTablesResponse_tables;
        
			return listDatasourceTablesResponse;
        }
    }
}
