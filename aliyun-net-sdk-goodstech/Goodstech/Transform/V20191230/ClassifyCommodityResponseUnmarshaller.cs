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
using Aliyun.Acs.goodstech.Model.V20191230;

namespace Aliyun.Acs.goodstech.Transform.V20191230
{
    public class ClassifyCommodityResponseUnmarshaller
    {
        public static ClassifyCommodityResponse Unmarshall(UnmarshallerContext context)
        {
			ClassifyCommodityResponse classifyCommodityResponse = new ClassifyCommodityResponse();

			classifyCommodityResponse.HttpResponse = context.HttpResponse;
			classifyCommodityResponse.RequestId = context.StringValue("ClassifyCommodity.RequestId");

			ClassifyCommodityResponse.ClassifyCommodity_Data data = new ClassifyCommodityResponse.ClassifyCommodity_Data();

			List<ClassifyCommodityResponse.ClassifyCommodity_Data.ClassifyCommodity_Category> data_categories = new List<ClassifyCommodityResponse.ClassifyCommodity_Data.ClassifyCommodity_Category>();
			for (int i = 0; i < context.Length("ClassifyCommodity.Data.Categories.Length"); i++) {
				ClassifyCommodityResponse.ClassifyCommodity_Data.ClassifyCommodity_Category category = new ClassifyCommodityResponse.ClassifyCommodity_Data.ClassifyCommodity_Category();
				category.Score = context.FloatValue("ClassifyCommodity.Data.Categories["+ i +"].Score");
				category.CategoryName = context.StringValue("ClassifyCommodity.Data.Categories["+ i +"].CategoryName");
				category.CategoryId = context.StringValue("ClassifyCommodity.Data.Categories["+ i +"].CategoryId");

				data_categories.Add(category);
			}
			data.Categories = data_categories;
			classifyCommodityResponse.Data = data;
        
			return classifyCommodityResponse;
        }
    }
}
