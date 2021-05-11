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
using Aliyun.Acs.dataworks_public.Model.V20200518;

namespace Aliyun.Acs.dataworks_public.Transform.V20200518
{
    public class ListTableWithPermissionResponseUnmarshaller
    {
        public static ListTableWithPermissionResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListTableWithPermissionResponse listTableWithPermissionResponse = new ListTableWithPermissionResponse();

			listTableWithPermissionResponse.HttpResponse = _ctx.HttpResponse;
			listTableWithPermissionResponse.RequestId = _ctx.StringValue("ListTableWithPermission.RequestId");

			ListTableWithPermissionResponse.ListTableWithPermission_Tables tables = new ListTableWithPermissionResponse.ListTableWithPermission_Tables();
			tables.PageNumber = _ctx.IntegerValue("ListTableWithPermission.Tables.PageNumber");
			tables.PageSize = _ctx.IntegerValue("ListTableWithPermission.Tables.PageSize");
			tables.TotalCount = _ctx.IntegerValue("ListTableWithPermission.Tables.TotalCount");

			List<ListTableWithPermissionResponse.ListTableWithPermission_Tables.ListTableWithPermission_TableListItem> tables_tableList = new List<ListTableWithPermissionResponse.ListTableWithPermission_Tables.ListTableWithPermission_TableListItem>();
			for (int i = 0; i < _ctx.Length("ListTableWithPermission.Tables.TableList.Length"); i++) {
				ListTableWithPermissionResponse.ListTableWithPermission_Tables.ListTableWithPermission_TableListItem tableListItem = new ListTableWithPermissionResponse.ListTableWithPermission_Tables.ListTableWithPermission_TableListItem();
				tableListItem.ProjectGuid = _ctx.StringValue("ListTableWithPermission.Tables.TableList["+ i +"].ProjectGuid");
				tableListItem.Guid = _ctx.StringValue("ListTableWithPermission.Tables.TableList["+ i +"].Guid");
				tableListItem.Name = _ctx.StringValue("ListTableWithPermission.Tables.TableList["+ i +"].Name");
				tableListItem.NameCn = _ctx.StringValue("ListTableWithPermission.Tables.TableList["+ i +"].NameCn");
				tableListItem.Comment = _ctx.StringValue("ListTableWithPermission.Tables.TableList["+ i +"].Comment");
				tableListItem.Owner = _ctx.StringValue("ListTableWithPermission.Tables.TableList["+ i +"].Owner");

				List<string> tableListItem_action = new List<string>();
				for (int j = 0; j < _ctx.Length("ListTableWithPermission.Tables.TableList["+ i +"].Action.Length"); j++) {
					tableListItem_action.Add(_ctx.StringValue("ListTableWithPermission.Tables.TableList["+ i +"].Action["+ j +"]"));
				}
				tableListItem.Action = tableListItem_action;

				tables_tableList.Add(tableListItem);
			}
			tables.TableList = tables_tableList;
			listTableWithPermissionResponse.Tables = tables;
        
			return listTableWithPermissionResponse;
        }
    }
}
