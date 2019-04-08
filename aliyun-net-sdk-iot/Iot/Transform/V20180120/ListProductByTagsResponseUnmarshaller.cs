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
using Aliyun.Acs.Iot.Model.V20180120;

namespace Aliyun.Acs.Iot.Transform.V20180120
{
    public class ListProductByTagsResponseUnmarshaller
    {
        public static ListProductByTagsResponse Unmarshall(UnmarshallerContext context)
        {
			ListProductByTagsResponse listProductByTagsResponse = new ListProductByTagsResponse();

			listProductByTagsResponse.HttpResponse = context.HttpResponse;
			listProductByTagsResponse.RequestId = context.StringValue("ListProductByTags.RequestId");
			listProductByTagsResponse.Success = context.BooleanValue("ListProductByTags.Success");
			listProductByTagsResponse.ErrorMessage = context.StringValue("ListProductByTags.ErrorMessage");
			listProductByTagsResponse.Code = context.StringValue("ListProductByTags.Code");

			List<ListProductByTagsResponse.ListProductByTags_ProductInfo> listProductByTagsResponse_productInfos = new List<ListProductByTagsResponse.ListProductByTags_ProductInfo>();
			for (int i = 0; i < context.Length("ListProductByTags.ProductInfos.Length"); i++) {
				ListProductByTagsResponse.ListProductByTags_ProductInfo productInfo = new ListProductByTagsResponse.ListProductByTags_ProductInfo();
				productInfo.ProductName = context.StringValue("ListProductByTags.ProductInfos["+ i +"].ProductName");
				productInfo.ProductKey = context.StringValue("ListProductByTags.ProductInfos["+ i +"].ProductKey");
				productInfo.CreateTime = context.LongValue("ListProductByTags.ProductInfos["+ i +"].CreateTime");
				productInfo.Description = context.StringValue("ListProductByTags.ProductInfos["+ i +"].Description");
				productInfo.NodeType = context.IntegerValue("ListProductByTags.ProductInfos["+ i +"].NodeType");

				listProductByTagsResponse_productInfos.Add(productInfo);
			}
			listProductByTagsResponse.ProductInfos = listProductByTagsResponse_productInfos;
        
			return listProductByTagsResponse;
        }
    }
}
