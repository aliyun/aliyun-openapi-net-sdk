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
    public class GetMetaCategoryResponseUnmarshaller
    {
        public static GetMetaCategoryResponse Unmarshall(UnmarshallerContext context)
        {
			GetMetaCategoryResponse getMetaCategoryResponse = new GetMetaCategoryResponse();

			getMetaCategoryResponse.HttpResponse = context.HttpResponse;
			getMetaCategoryResponse.RequestId = context.StringValue("GetMetaCategory.RequestId");
			getMetaCategoryResponse.ErrorCode = context.StringValue("GetMetaCategory.ErrorCode");
			getMetaCategoryResponse.ErrorMessage = context.StringValue("GetMetaCategory.ErrorMessage");
			getMetaCategoryResponse.HttpStatusCode = context.IntegerValue("GetMetaCategory.HttpStatusCode");
			getMetaCategoryResponse.Success = context.BooleanValue("GetMetaCategory.Success");

			GetMetaCategoryResponse.GetMetaCategory_Data data = new GetMetaCategoryResponse.GetMetaCategory_Data();
			data.PageNum = context.IntegerValue("GetMetaCategory.Data.PageNum");
			data.PageSize = context.IntegerValue("GetMetaCategory.Data.PageSize");
			data.TotalCount = context.LongValue("GetMetaCategory.Data.TotalCount");

			List<GetMetaCategoryResponse.GetMetaCategory_Data.GetMetaCategory_DataEntityListItem> data_dataEntityList = new List<GetMetaCategoryResponse.GetMetaCategory_Data.GetMetaCategory_DataEntityListItem>();
			for (int i = 0; i < context.Length("GetMetaCategory.Data.DataEntityList.Length"); i++) {
				GetMetaCategoryResponse.GetMetaCategory_Data.GetMetaCategory_DataEntityListItem dataEntityListItem = new GetMetaCategoryResponse.GetMetaCategory_Data.GetMetaCategory_DataEntityListItem();
				dataEntityListItem.CategoryId = context.LongValue("GetMetaCategory.Data.DataEntityList["+ i +"].CategoryId");
				dataEntityListItem.Name = context.StringValue("GetMetaCategory.Data.DataEntityList["+ i +"].Name");
				dataEntityListItem.CreateTime = context.LongValue("GetMetaCategory.Data.DataEntityList["+ i +"].CreateTime");
				dataEntityListItem.ModifiedTime = context.LongValue("GetMetaCategory.Data.DataEntityList["+ i +"].ModifiedTime");
				dataEntityListItem.Comment = context.StringValue("GetMetaCategory.Data.DataEntityList["+ i +"].Comment");
				dataEntityListItem.OwnerId = context.StringValue("GetMetaCategory.Data.DataEntityList["+ i +"].OwnerId");
				dataEntityListItem.LastOperatorId = context.StringValue("GetMetaCategory.Data.DataEntityList["+ i +"].LastOperatorId");
				dataEntityListItem.ParentCategoryId = context.LongValue("GetMetaCategory.Data.DataEntityList["+ i +"].ParentCategoryId");
				dataEntityListItem.Depth = context.IntegerValue("GetMetaCategory.Data.DataEntityList["+ i +"].Depth");

				data_dataEntityList.Add(dataEntityListItem);
			}
			data.DataEntityList = data_dataEntityList;
			getMetaCategoryResponse.Data = data;
        
			return getMetaCategoryResponse;
        }
    }
}
