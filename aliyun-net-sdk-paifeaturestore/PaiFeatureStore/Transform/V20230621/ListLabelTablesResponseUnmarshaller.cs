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
    public class ListLabelTablesResponseUnmarshaller
    {
        public static ListLabelTablesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListLabelTablesResponse listLabelTablesResponse = new ListLabelTablesResponse();

			listLabelTablesResponse.HttpResponse = _ctx.HttpResponse;
			listLabelTablesResponse.RequestId = _ctx.StringValue("ListLabelTables.RequestId");
			listLabelTablesResponse.TotalCount = _ctx.LongValue("ListLabelTables.TotalCount");

			List<ListLabelTablesResponse.ListLabelTables_LabelTable> listLabelTablesResponse_labelTables = new List<ListLabelTablesResponse.ListLabelTables_LabelTable>();
			for (int i = 0; i < _ctx.Length("ListLabelTables.LabelTables.Length"); i++) {
				ListLabelTablesResponse.ListLabelTables_LabelTable labelTable = new ListLabelTablesResponse.ListLabelTables_LabelTable();
				labelTable.LabelTableId = _ctx.StringValue("ListLabelTables.LabelTables["+ i +"].LabelTableId");
				labelTable.ProjectId = _ctx.StringValue("ListLabelTables.LabelTables["+ i +"].ProjectId");
				labelTable.ProjectName = _ctx.StringValue("ListLabelTables.LabelTables["+ i +"].ProjectName");
				labelTable.DatasourceId = _ctx.StringValue("ListLabelTables.LabelTables["+ i +"].DatasourceId");
				labelTable.Name = _ctx.StringValue("ListLabelTables.LabelTables["+ i +"].Name");
				labelTable.DatasourceName = _ctx.StringValue("ListLabelTables.LabelTables["+ i +"].DatasourceName");
				labelTable.Owner = _ctx.StringValue("ListLabelTables.LabelTables["+ i +"].Owner");
				labelTable.GmtCreateTime = _ctx.StringValue("ListLabelTables.LabelTables["+ i +"].GmtCreateTime");
				labelTable.GmtModifiedTime = _ctx.StringValue("ListLabelTables.LabelTables["+ i +"].GmtModifiedTime");

				listLabelTablesResponse_labelTables.Add(labelTable);
			}
			listLabelTablesResponse.LabelTables = listLabelTablesResponse_labelTables;
        
			return listLabelTablesResponse;
        }
    }
}
