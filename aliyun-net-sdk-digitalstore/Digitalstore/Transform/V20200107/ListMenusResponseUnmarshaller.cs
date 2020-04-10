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
using Aliyun.Acs.digitalstore.Model.V20200107;

namespace Aliyun.Acs.digitalstore.Transform.V20200107
{
    public class ListMenusResponseUnmarshaller
    {
        public static ListMenusResponse Unmarshall(UnmarshallerContext context)
        {
			ListMenusResponse listMenusResponse = new ListMenusResponse();

			listMenusResponse.HttpResponse = context.HttpResponse;
			listMenusResponse.RequestId = context.StringValue("ListMenus.RequestId");
			listMenusResponse.Success = context.BooleanValue("ListMenus.Success");

			List<ListMenusResponse.ListMenus_DataItem> listMenusResponse_data = new List<ListMenusResponse.ListMenus_DataItem>();
			for (int i = 0; i < context.Length("ListMenus.Data.Length"); i++) {
				ListMenusResponse.ListMenus_DataItem dataItem = new ListMenusResponse.ListMenus_DataItem();
				dataItem.Id = context.LongValue("ListMenus.Data["+ i +"].Id");
				dataItem.Name = context.StringValue("ListMenus.Data["+ i +"].Name");
				dataItem.ParentId = context.LongValue("ListMenus.Data["+ i +"].ParentId");
				dataItem.Sequence = context.IntegerValue("ListMenus.Data["+ i +"].Sequence");

				List<ListMenusResponse.ListMenus_DataItem.ListMenus_AclItem> dataItem_acl = new List<ListMenusResponse.ListMenus_DataItem.ListMenus_AclItem>();
				for (int j = 0; j < context.Length("ListMenus.Data["+ i +"].Acl.Length"); j++) {
					ListMenusResponse.ListMenus_DataItem.ListMenus_AclItem aclItem = new ListMenusResponse.ListMenus_DataItem.ListMenus_AclItem();
					aclItem.Id = context.LongValue("ListMenus.Data["+ i +"].Acl["+ j +"].Id");
					aclItem.Name = context.StringValue("ListMenus.Data["+ i +"].Acl["+ j +"].Name");
					aclItem.Code = context.StringValue("ListMenus.Data["+ i +"].Acl["+ j +"].Code");
					aclItem.Type = context.IntegerValue("ListMenus.Data["+ i +"].Acl["+ j +"].Type");
					aclItem.Status = context.IntegerValue("ListMenus.Data["+ i +"].Acl["+ j +"].Status");

					dataItem_acl.Add(aclItem);
				}
				dataItem.Acl = dataItem_acl;

				List<ListMenusResponse.ListMenus_DataItem.ListMenus_ChildModuleItem> dataItem_childModule = new List<ListMenusResponse.ListMenus_DataItem.ListMenus_ChildModuleItem>();
				for (int j = 0; j < context.Length("ListMenus.Data["+ i +"].ChildModule.Length"); j++) {
					ListMenusResponse.ListMenus_DataItem.ListMenus_ChildModuleItem childModuleItem = new ListMenusResponse.ListMenus_DataItem.ListMenus_ChildModuleItem();
					childModuleItem.Id = context.LongValue("ListMenus.Data["+ i +"].ChildModule["+ j +"].Id");
					childModuleItem.Name = context.StringValue("ListMenus.Data["+ i +"].ChildModule["+ j +"].Name");
					childModuleItem.ParentId = context.LongValue("ListMenus.Data["+ i +"].ChildModule["+ j +"].ParentId");
					childModuleItem.Sequence = context.IntegerValue("ListMenus.Data["+ i +"].ChildModule["+ j +"].Sequence");

					List<ListMenusResponse.ListMenus_DataItem.ListMenus_ChildModuleItem.ListMenus_AclItem2> childModuleItem_acl1 = new List<ListMenusResponse.ListMenus_DataItem.ListMenus_ChildModuleItem.ListMenus_AclItem2>();
					for (int k = 0; k < context.Length("ListMenus.Data["+ i +"].ChildModule["+ j +"].Acl.Length"); k++) {
						ListMenusResponse.ListMenus_DataItem.ListMenus_ChildModuleItem.ListMenus_AclItem2 aclItem2 = new ListMenusResponse.ListMenus_DataItem.ListMenus_ChildModuleItem.ListMenus_AclItem2();
						aclItem2.Id = context.LongValue("ListMenus.Data["+ i +"].ChildModule["+ j +"].Acl["+ k +"].Id");
						aclItem2.Name = context.StringValue("ListMenus.Data["+ i +"].ChildModule["+ j +"].Acl["+ k +"].Name");
						aclItem2.Code = context.StringValue("ListMenus.Data["+ i +"].ChildModule["+ j +"].Acl["+ k +"].Code");
						aclItem2.Type = context.IntegerValue("ListMenus.Data["+ i +"].ChildModule["+ j +"].Acl["+ k +"].Type");
						aclItem2.Status = context.IntegerValue("ListMenus.Data["+ i +"].ChildModule["+ j +"].Acl["+ k +"].Status");

						childModuleItem_acl1.Add(aclItem2);
					}
					childModuleItem.Acl1 = childModuleItem_acl1;

					dataItem_childModule.Add(childModuleItem);
				}
				dataItem.ChildModule = dataItem_childModule;

				listMenusResponse_data.Add(dataItem);
			}
			listMenusResponse.Data = listMenusResponse_data;
        
			return listMenusResponse;
        }
    }
}
