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
    public class ListSizeGroupsResponseUnmarshaller
    {
        public static ListSizeGroupsResponse Unmarshall(UnmarshallerContext context)
        {
			ListSizeGroupsResponse listSizeGroupsResponse = new ListSizeGroupsResponse();

			listSizeGroupsResponse.HttpResponse = context.HttpResponse;
			listSizeGroupsResponse.PageSize = context.IntegerValue("ListSizeGroups.PageSize");
			listSizeGroupsResponse.PageNumber = context.IntegerValue("ListSizeGroups.PageNumber");
			listSizeGroupsResponse.RequestId = context.StringValue("ListSizeGroups.RequestId");
			listSizeGroupsResponse.Success = context.BooleanValue("ListSizeGroups.Success");
			listSizeGroupsResponse.TotalCount = context.IntegerValue("ListSizeGroups.TotalCount");

			List<ListSizeGroupsResponse.ListSizeGroups_SizeGroupModel> listSizeGroupsResponse_sizeGroups = new List<ListSizeGroupsResponse.ListSizeGroups_SizeGroupModel>();
			for (int i = 0; i < context.Length("ListSizeGroups.SizeGroups.Length"); i++) {
				ListSizeGroupsResponse.ListSizeGroups_SizeGroupModel sizeGroupModel = new ListSizeGroupsResponse.ListSizeGroups_SizeGroupModel();
				sizeGroupModel.CreateDate = context.StringValue("ListSizeGroups.SizeGroups["+ i +"].CreateDate");
				sizeGroupModel.Description = context.StringValue("ListSizeGroups.SizeGroups["+ i +"].Description");
				sizeGroupModel.Name = context.StringValue("ListSizeGroups.SizeGroups["+ i +"].Name");
				sizeGroupModel.Disable = context.IntegerValue("ListSizeGroups.SizeGroups["+ i +"].Disable");
				sizeGroupModel.Code = context.StringValue("ListSizeGroups.SizeGroups["+ i +"].Code");
				sizeGroupModel.UpdateDate = context.StringValue("ListSizeGroups.SizeGroups["+ i +"].UpdateDate");
				sizeGroupModel.SizeGroupId = context.StringValue("ListSizeGroups.SizeGroups["+ i +"].SizeGroupId");

				List<ListSizeGroupsResponse.ListSizeGroups_SizeGroupModel.ListSizeGroups_SizeModel> sizeGroupModel_sizes = new List<ListSizeGroupsResponse.ListSizeGroups_SizeGroupModel.ListSizeGroups_SizeModel>();
				for (int j = 0; j < context.Length("ListSizeGroups.SizeGroups["+ i +"].Sizes.Length"); j++) {
					ListSizeGroupsResponse.ListSizeGroups_SizeGroupModel.ListSizeGroups_SizeModel sizeModel = new ListSizeGroupsResponse.ListSizeGroups_SizeGroupModel.ListSizeGroups_SizeModel();
					sizeModel.Description = context.StringValue("ListSizeGroups.SizeGroups["+ i +"].Sizes["+ j +"].Description");
					sizeModel.SizeName = context.StringValue("ListSizeGroups.SizeGroups["+ i +"].Sizes["+ j +"].SizeName");
					sizeModel.SizeGroupCode = context.StringValue("ListSizeGroups.SizeGroups["+ i +"].Sizes["+ j +"].SizeGroupCode");
					sizeModel.CreateDate = context.StringValue("ListSizeGroups.SizeGroups["+ i +"].Sizes["+ j +"].CreateDate");
					sizeModel.SizeGroupId = context.StringValue("ListSizeGroups.SizeGroups["+ i +"].Sizes["+ j +"].SizeGroupId");
					sizeModel.SizeCode = context.StringValue("ListSizeGroups.SizeGroups["+ i +"].Sizes["+ j +"].SizeCode");
					sizeModel.SizeGroupName = context.StringValue("ListSizeGroups.SizeGroups["+ i +"].Sizes["+ j +"].SizeGroupName");
					sizeModel.UpdateDate = context.StringValue("ListSizeGroups.SizeGroups["+ i +"].Sizes["+ j +"].UpdateDate");
					sizeModel.Disable = context.IntegerValue("ListSizeGroups.SizeGroups["+ i +"].Sizes["+ j +"].Disable");
					sizeModel.SizeId = context.StringValue("ListSizeGroups.SizeGroups["+ i +"].Sizes["+ j +"].SizeId");

					sizeGroupModel_sizes.Add(sizeModel);
				}
				sizeGroupModel.Sizes = sizeGroupModel_sizes;

				listSizeGroupsResponse_sizeGroups.Add(sizeGroupModel);
			}
			listSizeGroupsResponse.SizeGroups = listSizeGroupsResponse_sizeGroups;
        
			return listSizeGroupsResponse;
        }
    }
}
