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
using Aliyun.Acs.Linkvisual.Model.V20180120;

namespace Aliyun.Acs.Linkvisual.Transform.V20180120
{
    public class QueryPictureFilesResponseUnmarshaller
    {
        public static QueryPictureFilesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryPictureFilesResponse queryPictureFilesResponse = new QueryPictureFilesResponse();

			queryPictureFilesResponse.HttpResponse = _ctx.HttpResponse;
			queryPictureFilesResponse.Code = _ctx.StringValue("QueryPictureFiles.Code");
			queryPictureFilesResponse.RequestId = _ctx.StringValue("QueryPictureFiles.RequestId");
			queryPictureFilesResponse.ErrorMessage = _ctx.StringValue("QueryPictureFiles.ErrorMessage");
			queryPictureFilesResponse.Success = _ctx.BooleanValue("QueryPictureFiles.Success");

			QueryPictureFilesResponse.QueryPictureFiles_Data data = new QueryPictureFilesResponse.QueryPictureFiles_Data();
			data.Page = _ctx.IntegerValue("QueryPictureFiles.Data.Page");
			data.PageSize = _ctx.IntegerValue("QueryPictureFiles.Data.PageSize");

			List<QueryPictureFilesResponse.QueryPictureFiles_Data.QueryPictureFiles_ListItem> data_list = new List<QueryPictureFilesResponse.QueryPictureFiles_Data.QueryPictureFiles_ListItem>();
			for (int i = 0; i < _ctx.Length("QueryPictureFiles.Data.List.Length"); i++) {
				QueryPictureFilesResponse.QueryPictureFiles_Data.QueryPictureFiles_ListItem listItem = new QueryPictureFilesResponse.QueryPictureFiles_Data.QueryPictureFiles_ListItem();
				listItem.PicId = _ctx.StringValue("QueryPictureFiles.Data.List["+ i +"].PicId");
				listItem.PicUrl = _ctx.StringValue("QueryPictureFiles.Data.List["+ i +"].PicUrl");
				listItem.PicCreateTime = _ctx.LongValue("QueryPictureFiles.Data.List["+ i +"].PicCreateTime");
				listItem.ThumbUrl = _ctx.StringValue("QueryPictureFiles.Data.List["+ i +"].ThumbUrl");
				listItem.IotId = _ctx.StringValue("QueryPictureFiles.Data.List["+ i +"].IotId");

				data_list.Add(listItem);
			}
			data.List = data_list;
			queryPictureFilesResponse.Data = data;
        
			return queryPictureFilesResponse;
        }
    }
}
