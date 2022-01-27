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
    public class ListSensitiveColumnsResponseUnmarshaller
    {
        public static ListSensitiveColumnsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListSensitiveColumnsResponse listSensitiveColumnsResponse = new ListSensitiveColumnsResponse();

			listSensitiveColumnsResponse.HttpResponse = _ctx.HttpResponse;
			listSensitiveColumnsResponse.TotalCount = _ctx.LongValue("ListSensitiveColumns.TotalCount");
			listSensitiveColumnsResponse.RequestId = _ctx.StringValue("ListSensitiveColumns.RequestId");
			listSensitiveColumnsResponse.ErrorCode = _ctx.StringValue("ListSensitiveColumns.ErrorCode");
			listSensitiveColumnsResponse.ErrorMessage = _ctx.StringValue("ListSensitiveColumns.ErrorMessage");
			listSensitiveColumnsResponse.Success = _ctx.BooleanValue("ListSensitiveColumns.Success");

			List<ListSensitiveColumnsResponse.ListSensitiveColumns_SensitiveColumn> listSensitiveColumnsResponse_sensitiveColumnList = new List<ListSensitiveColumnsResponse.ListSensitiveColumns_SensitiveColumn>();
			for (int i = 0; i < _ctx.Length("ListSensitiveColumns.SensitiveColumnList.Length"); i++) {
				ListSensitiveColumnsResponse.ListSensitiveColumns_SensitiveColumn sensitiveColumn = new ListSensitiveColumnsResponse.ListSensitiveColumns_SensitiveColumn();
				sensitiveColumn.ColumnName = _ctx.StringValue("ListSensitiveColumns.SensitiveColumnList["+ i +"].ColumnName");
				sensitiveColumn.TableName = _ctx.StringValue("ListSensitiveColumns.SensitiveColumnList["+ i +"].TableName");
				sensitiveColumn.SecurityLevel = _ctx.StringValue("ListSensitiveColumns.SensitiveColumnList["+ i +"].SecurityLevel");
				sensitiveColumn.ColumnCount = _ctx.LongValue("ListSensitiveColumns.SensitiveColumnList["+ i +"].ColumnCount");
				sensitiveColumn.SchemaName = _ctx.StringValue("ListSensitiveColumns.SensitiveColumnList["+ i +"].SchemaName");
				sensitiveColumn.FunctionType = _ctx.StringValue("ListSensitiveColumns.SensitiveColumnList["+ i +"].FunctionType");

				listSensitiveColumnsResponse_sensitiveColumnList.Add(sensitiveColumn);
			}
			listSensitiveColumnsResponse.SensitiveColumnList = listSensitiveColumnsResponse_sensitiveColumnList;
        
			return listSensitiveColumnsResponse;
        }
    }
}
