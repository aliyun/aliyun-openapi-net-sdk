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
    public class CreateProductTagsResponseUnmarshaller
    {
        public static CreateProductTagsResponse Unmarshall(UnmarshallerContext context)
        {
			CreateProductTagsResponse createProductTagsResponse = new CreateProductTagsResponse();

			createProductTagsResponse.HttpResponse = context.HttpResponse;
			createProductTagsResponse.RequestId = context.StringValue("CreateProductTags.RequestId");
			createProductTagsResponse.Success = context.BooleanValue("CreateProductTags.Success");
			createProductTagsResponse.ErrorMessage = context.StringValue("CreateProductTags.ErrorMessage");
			createProductTagsResponse.Code = context.StringValue("CreateProductTags.Code");

			List<CreateProductTagsResponse.CreateProductTags_ProductTag> createProductTagsResponse_invalidProductTags = new List<CreateProductTagsResponse.CreateProductTags_ProductTag>();
			for (int i = 0; i < context.Length("CreateProductTags.InvalidProductTags.Length"); i++) {
				CreateProductTagsResponse.CreateProductTags_ProductTag productTag = new CreateProductTagsResponse.CreateProductTags_ProductTag();
				productTag.TagKey = context.StringValue("CreateProductTags.InvalidProductTags["+ i +"].TagKey");
				productTag.TagValue = context.StringValue("CreateProductTags.InvalidProductTags["+ i +"].TagValue");

				createProductTagsResponse_invalidProductTags.Add(productTag);
			}
			createProductTagsResponse.InvalidProductTags = createProductTagsResponse_invalidProductTags;
        
			return createProductTagsResponse;
        }
    }
}
