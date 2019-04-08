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
    public class UpdateProductTagsResponseUnmarshaller
    {
        public static UpdateProductTagsResponse Unmarshall(UnmarshallerContext context)
        {
			UpdateProductTagsResponse updateProductTagsResponse = new UpdateProductTagsResponse();

			updateProductTagsResponse.HttpResponse = context.HttpResponse;
			updateProductTagsResponse.RequestId = context.StringValue("UpdateProductTags.RequestId");
			updateProductTagsResponse.Success = context.BooleanValue("UpdateProductTags.Success");
			updateProductTagsResponse.ErrorMessage = context.StringValue("UpdateProductTags.ErrorMessage");
			updateProductTagsResponse.Code = context.StringValue("UpdateProductTags.Code");

			List<UpdateProductTagsResponse.UpdateProductTags_ProductTag> updateProductTagsResponse_invalidProductTags = new List<UpdateProductTagsResponse.UpdateProductTags_ProductTag>();
			for (int i = 0; i < context.Length("UpdateProductTags.InvalidProductTags.Length"); i++) {
				UpdateProductTagsResponse.UpdateProductTags_ProductTag productTag = new UpdateProductTagsResponse.UpdateProductTags_ProductTag();
				productTag.TagKey = context.StringValue("UpdateProductTags.InvalidProductTags["+ i +"].TagKey");
				productTag.TagValue = context.StringValue("UpdateProductTags.InvalidProductTags["+ i +"].TagValue");

				updateProductTagsResponse_invalidProductTags.Add(productTag);
			}
			updateProductTagsResponse.InvalidProductTags = updateProductTagsResponse_invalidProductTags;
        
			return updateProductTagsResponse;
        }
    }
}
