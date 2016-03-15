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
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescibeImportsFromDatabaseResponseUnmarshaller
    {
        public static DescibeImportsFromDatabaseResponse Unmarshall(UnmarshallerContext context)
        {
			DescibeImportsFromDatabaseResponse descibeImportsFromDatabaseResponse = new DescibeImportsFromDatabaseResponse();

			descibeImportsFromDatabaseResponse.HttpResponse = context.HttpResponse;
			descibeImportsFromDatabaseResponse.RequestId = context.StringValue("DescibeImportsFromDatabase.RequestId");
			descibeImportsFromDatabaseResponse.TotalRecordCount = context.IntegerValue("DescibeImportsFromDatabase.TotalRecordCount");
			descibeImportsFromDatabaseResponse.PageNumber = context.IntegerValue("DescibeImportsFromDatabase.PageNumber");
			descibeImportsFromDatabaseResponse.PageRecordCount = context.IntegerValue("DescibeImportsFromDatabase.PageRecordCount");

			List<DescibeImportsFromDatabaseResponse.ImportResultFromDB> items = new List<DescibeImportsFromDatabaseResponse.ImportResultFromDB>();
			for (int i = 0; i < context.Length("DescibeImportsFromDatabase.Items.Length"); i++) {
				DescibeImportsFromDatabaseResponse.ImportResultFromDB importResultFromDB = new DescibeImportsFromDatabaseResponse.ImportResultFromDB();
				importResultFromDB.ImportId = context.IntegerValue("DescibeImportsFromDatabase.Items["+ i +"].ImportId");
				importResultFromDB.ImportDataType = context.EnumValue<DescibeImportsFromDatabaseResponse.ImportResultFromDB.ImportDataTypeEnum>("DescibeImportsFromDatabase.Items["+ i +"].ImportDataType");
				importResultFromDB.ImportDataStatus = context.EnumValue<DescibeImportsFromDatabaseResponse.ImportResultFromDB.ImportDataStatusEnum>("DescibeImportsFromDatabase.Items["+ i +"].ImportDataStatus");
				importResultFromDB.ImportDataStatusDescription = context.StringValue("DescibeImportsFromDatabase.Items["+ i +"].ImportDataStatusDescription");
				importResultFromDB.IncrementalImportingTime = context.StringValue("DescibeImportsFromDatabase.Items["+ i +"].IncrementalImportingTime");

				items.Add(importResultFromDB);
			}
			descibeImportsFromDatabaseResponse.Items = items;
        
			return descibeImportsFromDatabaseResponse;
        }
    }
}