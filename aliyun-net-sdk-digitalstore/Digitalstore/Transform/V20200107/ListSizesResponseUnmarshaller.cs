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
    public class ListSizesResponseUnmarshaller
    {
        public static ListSizesResponse Unmarshall(UnmarshallerContext context)
        {
			ListSizesResponse listSizesResponse = new ListSizesResponse();

			listSizesResponse.HttpResponse = context.HttpResponse;
			listSizesResponse.PageSize = context.IntegerValue("ListSizes.PageSize");
			listSizesResponse.PageNumber = context.IntegerValue("ListSizes.PageNumber");
			listSizesResponse.RequestId = context.StringValue("ListSizes.RequestId");
			listSizesResponse.Success = context.BooleanValue("ListSizes.Success");
			listSizesResponse.TotalCount = context.IntegerValue("ListSizes.TotalCount");

			List<ListSizesResponse.ListSizes_SizeModel> listSizesResponse_sizes = new List<ListSizesResponse.ListSizes_SizeModel>();
			for (int i = 0; i < context.Length("ListSizes.Sizes.Length"); i++) {
				ListSizesResponse.ListSizes_SizeModel sizeModel = new ListSizesResponse.ListSizes_SizeModel();
				sizeModel.Description = context.StringValue("ListSizes.Sizes["+ i +"].Description");
				sizeModel.Name = context.StringValue("ListSizes.Sizes["+ i +"].Name");
				sizeModel.SizeGroupCode = context.StringValue("ListSizes.Sizes["+ i +"].SizeGroupCode");
				sizeModel.CreateDate = context.StringValue("ListSizes.Sizes["+ i +"].CreateDate");
				sizeModel.SizeGroupId = context.StringValue("ListSizes.Sizes["+ i +"].SizeGroupId");
				sizeModel.Code = context.StringValue("ListSizes.Sizes["+ i +"].Code");
				sizeModel.SizeGroupName = context.StringValue("ListSizes.Sizes["+ i +"].SizeGroupName");
				sizeModel.UpdateDate = context.StringValue("ListSizes.Sizes["+ i +"].UpdateDate");
				sizeModel.Disable = context.IntegerValue("ListSizes.Sizes["+ i +"].Disable");
				sizeModel.SizeId = context.StringValue("ListSizes.Sizes["+ i +"].SizeId");

				listSizesResponse_sizes.Add(sizeModel);
			}
			listSizesResponse.Sizes = listSizesResponse_sizes;
        
			return listSizesResponse;
        }
    }
}
