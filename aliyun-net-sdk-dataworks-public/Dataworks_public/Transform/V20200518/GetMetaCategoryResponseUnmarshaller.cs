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
        public static GetMetaCategoryResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetMetaCategoryResponse getMetaCategoryResponse = new GetMetaCategoryResponse();

			getMetaCategoryResponse.HttpResponse = _ctx.HttpResponse;
			getMetaCategoryResponse.RequestId = _ctx.StringValue("GetMetaCategory.RequestId");
			getMetaCategoryResponse.ErrorCode = _ctx.StringValue("GetMetaCategory.ErrorCode");
			getMetaCategoryResponse.ErrorMessage = _ctx.StringValue("GetMetaCategory.ErrorMessage");
			getMetaCategoryResponse.HttpStatusCode = _ctx.IntegerValue("GetMetaCategory.HttpStatusCode");
			getMetaCategoryResponse.Success = _ctx.BooleanValue("GetMetaCategory.Success");

			GetMetaCategoryResponse.GetMetaCategory_Data data = new GetMetaCategoryResponse.GetMetaCategory_Data();
			data.PageNum = _ctx.IntegerValue("GetMetaCategory.Data.PageNum");
			data.PageSize = _ctx.IntegerValue("GetMetaCategory.Data.PageSize");
			data.TotalCount = _ctx.LongValue("GetMetaCategory.Data.TotalCount");

			List<GetMetaCategoryResponse.GetMetaCategory_Data.GetMetaCategory_DataEntityListItem> data_dataEntityList = new List<GetMetaCategoryResponse.GetMetaCategory_Data.GetMetaCategory_DataEntityListItem>();
			for (int i = 0; i < _ctx.Length("GetMetaCategory.Data.DataEntityList.Length"); i++) {
				GetMetaCategoryResponse.GetMetaCategory_Data.GetMetaCategory_DataEntityListItem dataEntityListItem = new GetMetaCategoryResponse.GetMetaCategory_Data.GetMetaCategory_DataEntityListItem();
				dataEntityListItem.CategoryId = _ctx.LongValue("GetMetaCategory.Data.DataEntityList["+ i +"].CategoryId");
				dataEntityListItem.Name = _ctx.StringValue("GetMetaCategory.Data.DataEntityList["+ i +"].Name");
				dataEntityListItem.CreateTime = _ctx.LongValue("GetMetaCategory.Data.DataEntityList["+ i +"].CreateTime");
				dataEntityListItem.ModifiedTime = _ctx.LongValue("GetMetaCategory.Data.DataEntityList["+ i +"].ModifiedTime");
				dataEntityListItem.Comment = _ctx.StringValue("GetMetaCategory.Data.DataEntityList["+ i +"].Comment");
				dataEntityListItem.OwnerId = _ctx.StringValue("GetMetaCategory.Data.DataEntityList["+ i +"].OwnerId");
				dataEntityListItem.LastOperatorId = _ctx.StringValue("GetMetaCategory.Data.DataEntityList["+ i +"].LastOperatorId");
				dataEntityListItem.ParentCategoryId = _ctx.LongValue("GetMetaCategory.Data.DataEntityList["+ i +"].ParentCategoryId");
				dataEntityListItem.Depth = _ctx.IntegerValue("GetMetaCategory.Data.DataEntityList["+ i +"].Depth");

				data_dataEntityList.Add(dataEntityListItem);
			}
			data.DataEntityList = data_dataEntityList;
			getMetaCategoryResponse.Data = data;
        
			return getMetaCategoryResponse;
        }
    }
}
