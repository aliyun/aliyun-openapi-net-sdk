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
using Aliyun.Acs.Rds.Model.V20140815;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescibeImportsFromDatabaseResponseUnmarshaller
    {
        public static DescibeImportsFromDatabaseResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescibeImportsFromDatabaseResponse descibeImportsFromDatabaseResponse = new DescibeImportsFromDatabaseResponse();

			descibeImportsFromDatabaseResponse.HttpResponse = _ctx.HttpResponse;
			descibeImportsFromDatabaseResponse.RequestId = _ctx.StringValue("DescibeImportsFromDatabase.RequestId");
			descibeImportsFromDatabaseResponse.TotalRecordCount = _ctx.IntegerValue("DescibeImportsFromDatabase.TotalRecordCount");
			descibeImportsFromDatabaseResponse.PageNumber = _ctx.IntegerValue("DescibeImportsFromDatabase.PageNumber");
			descibeImportsFromDatabaseResponse.PageRecordCount = _ctx.IntegerValue("DescibeImportsFromDatabase.PageRecordCount");

			List<DescibeImportsFromDatabaseResponse.DescibeImportsFromDatabase_ImportResultFromDB> descibeImportsFromDatabaseResponse_items = new List<DescibeImportsFromDatabaseResponse.DescibeImportsFromDatabase_ImportResultFromDB>();
			for (int i = 0; i < _ctx.Length("DescibeImportsFromDatabase.Items.Length"); i++) {
				DescibeImportsFromDatabaseResponse.DescibeImportsFromDatabase_ImportResultFromDB importResultFromDB = new DescibeImportsFromDatabaseResponse.DescibeImportsFromDatabase_ImportResultFromDB();
				importResultFromDB.ImportId = _ctx.IntegerValue("DescibeImportsFromDatabase.Items["+ i +"].ImportId");
				importResultFromDB.ImportDataType = _ctx.StringValue("DescibeImportsFromDatabase.Items["+ i +"].ImportDataType");
				importResultFromDB.ImportDataStatus = _ctx.StringValue("DescibeImportsFromDatabase.Items["+ i +"].ImportDataStatus");
				importResultFromDB.ImportDataStatusDescription = _ctx.StringValue("DescibeImportsFromDatabase.Items["+ i +"].ImportDataStatusDescription");
				importResultFromDB.IncrementalImportingTime = _ctx.StringValue("DescibeImportsFromDatabase.Items["+ i +"].IncrementalImportingTime");

				descibeImportsFromDatabaseResponse_items.Add(importResultFromDB);
			}
			descibeImportsFromDatabaseResponse.Items = descibeImportsFromDatabaseResponse_items;
        
			return descibeImportsFromDatabaseResponse;
        }
    }
}
