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
    public class ListColumnWithLabelPermissionResponseUnmarshaller
    {
        public static ListColumnWithLabelPermissionResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListColumnWithLabelPermissionResponse listColumnWithLabelPermissionResponse = new ListColumnWithLabelPermissionResponse();

			listColumnWithLabelPermissionResponse.HttpResponse = _ctx.HttpResponse;
			listColumnWithLabelPermissionResponse.RequestId = _ctx.StringValue("ListColumnWithLabelPermission.RequestId");

			List<ListColumnWithLabelPermissionResponse.ListColumnWithLabelPermission_ColumnMetaItem> listColumnWithLabelPermissionResponse_columnMeta = new List<ListColumnWithLabelPermissionResponse.ListColumnWithLabelPermission_ColumnMetaItem>();
			for (int i = 0; i < _ctx.Length("ListColumnWithLabelPermission.ColumnMeta.Length"); i++) {
				ListColumnWithLabelPermissionResponse.ListColumnWithLabelPermission_ColumnMetaItem columnMetaItem = new ListColumnWithLabelPermissionResponse.ListColumnWithLabelPermission_ColumnMetaItem();
				columnMetaItem.Guid = _ctx.StringValue("ListColumnWithLabelPermission.ColumnMeta["+ i +"].Guid");
				columnMetaItem.Name = _ctx.StringValue("ListColumnWithLabelPermission.ColumnMeta["+ i +"].Name");
				columnMetaItem.Comment = _ctx.StringValue("ListColumnWithLabelPermission.ColumnMeta["+ i +"].Comment");
				columnMetaItem.SecurityLevel = _ctx.StringValue("ListColumnWithLabelPermission.ColumnMeta["+ i +"].SecurityLevel");
				columnMetaItem.Deadline = _ctx.StringValue("ListColumnWithLabelPermission.ColumnMeta["+ i +"].Deadline");
				columnMetaItem.GrantedLabel = _ctx.StringValue("ListColumnWithLabelPermission.ColumnMeta["+ i +"].GrantedLabel");

				listColumnWithLabelPermissionResponse_columnMeta.Add(columnMetaItem);
			}
			listColumnWithLabelPermissionResponse.ColumnMeta = listColumnWithLabelPermissionResponse_columnMeta;
        
			return listColumnWithLabelPermissionResponse;
        }
    }
}
