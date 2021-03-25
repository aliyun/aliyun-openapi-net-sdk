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
using Aliyun.Acs.BssOpenApi.Model.V20171214;

namespace Aliyun.Acs.BssOpenApi.Transform.V20171214
{
    public class QueryInstanceByTagResponseUnmarshaller
    {
        public static QueryInstanceByTagResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryInstanceByTagResponse queryInstanceByTagResponse = new QueryInstanceByTagResponse();

			queryInstanceByTagResponse.HttpResponse = _ctx.HttpResponse;
			queryInstanceByTagResponse.Code = _ctx.StringValue("QueryInstanceByTag.Code");
			queryInstanceByTagResponse.RequestId = _ctx.StringValue("QueryInstanceByTag.RequestId");
			queryInstanceByTagResponse.Success = _ctx.BooleanValue("QueryInstanceByTag.Success");
			queryInstanceByTagResponse.Message = _ctx.StringValue("QueryInstanceByTag.Message");
			queryInstanceByTagResponse.NextToken = _ctx.StringValue("QueryInstanceByTag.NextToken");

			List<QueryInstanceByTagResponse.QueryInstanceByTag_TagResourceItem> queryInstanceByTagResponse_tagResource = new List<QueryInstanceByTagResponse.QueryInstanceByTag_TagResourceItem>();
			for (int i = 0; i < _ctx.Length("QueryInstanceByTag.TagResource.Length"); i++) {
				QueryInstanceByTagResponse.QueryInstanceByTag_TagResourceItem tagResourceItem = new QueryInstanceByTagResponse.QueryInstanceByTag_TagResourceItem();
				tagResourceItem.ResourceId = _ctx.StringValue("QueryInstanceByTag.TagResource["+ i +"].ResourceId");
				tagResourceItem.ResourceType = _ctx.StringValue("QueryInstanceByTag.TagResource["+ i +"].ResourceType");

				List<QueryInstanceByTagResponse.QueryInstanceByTag_TagResourceItem.QueryInstanceByTag_TagKeyValue> tagResourceItem_tag = new List<QueryInstanceByTagResponse.QueryInstanceByTag_TagResourceItem.QueryInstanceByTag_TagKeyValue>();
				for (int j = 0; j < _ctx.Length("QueryInstanceByTag.TagResource["+ i +"].Tag.Length"); j++) {
					QueryInstanceByTagResponse.QueryInstanceByTag_TagResourceItem.QueryInstanceByTag_TagKeyValue tagKeyValue = new QueryInstanceByTagResponse.QueryInstanceByTag_TagResourceItem.QueryInstanceByTag_TagKeyValue();
					tagKeyValue.Key = _ctx.StringValue("QueryInstanceByTag.TagResource["+ i +"].Tag["+ j +"].Key");
					tagKeyValue._Value = _ctx.StringValue("QueryInstanceByTag.TagResource["+ i +"].Tag["+ j +"].Value");

					tagResourceItem_tag.Add(tagKeyValue);
				}
				tagResourceItem.Tag = tagResourceItem_tag;

				queryInstanceByTagResponse_tagResource.Add(tagResourceItem);
			}
			queryInstanceByTagResponse.TagResource = queryInstanceByTagResponse_tagResource;
        
			return queryInstanceByTagResponse;
        }
    }
}
