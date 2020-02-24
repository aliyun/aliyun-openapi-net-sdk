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
using Aliyun.Acs.VoiceNavigator.Model.V20180612;

namespace Aliyun.Acs.VoiceNavigator.Transform.V20180612
{
    public class DescribeCategoryTreeResponseUnmarshaller
    {
        public static DescribeCategoryTreeResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeCategoryTreeResponse describeCategoryTreeResponse = new DescribeCategoryTreeResponse();

			describeCategoryTreeResponse.HttpResponse = context.HttpResponse;
			describeCategoryTreeResponse.RequestId = context.StringValue("DescribeCategoryTree.RequestId");

			List<DescribeCategoryTreeResponse.DescribeCategoryTree_Level> describeCategoryTreeResponse_levels = new List<DescribeCategoryTreeResponse.DescribeCategoryTree_Level>();
			for (int i = 0; i < context.Length("DescribeCategoryTree.Levels.Length"); i++) {
				DescribeCategoryTreeResponse.DescribeCategoryTree_Level level = new DescribeCategoryTreeResponse.DescribeCategoryTree_Level();

				List<DescribeCategoryTreeResponse.DescribeCategoryTree_Level.DescribeCategoryTree_Category> level_categories = new List<DescribeCategoryTreeResponse.DescribeCategoryTree_Level.DescribeCategoryTree_Category>();
				for (int j = 0; j < context.Length("DescribeCategoryTree.Levels["+ i +"].Categories.Length"); j++) {
					DescribeCategoryTreeResponse.DescribeCategoryTree_Level.DescribeCategoryTree_Category category = new DescribeCategoryTreeResponse.DescribeCategoryTree_Level.DescribeCategoryTree_Category();
					category.InstanceId = context.StringValue("DescribeCategoryTree.Levels["+ i +"].Categories["+ j +"].InstanceId");
					category.Name = context.StringValue("DescribeCategoryTree.Levels["+ i +"].Categories["+ j +"].Name");
					category.CategoryId = context.StringValue("DescribeCategoryTree.Levels["+ i +"].Categories["+ j +"].CategoryId");
					category.Level = context.LongValue("DescribeCategoryTree.Levels["+ i +"].Categories["+ j +"].Level");
					category.PreviousSiblingId = context.StringValue("DescribeCategoryTree.Levels["+ i +"].Categories["+ j +"].PreviousSiblingId");
					category.NextSiblingId = context.StringValue("DescribeCategoryTree.Levels["+ i +"].Categories["+ j +"].NextSiblingId");
					category.ParentId = context.StringValue("DescribeCategoryTree.Levels["+ i +"].Categories["+ j +"].ParentId");

					level_categories.Add(category);
				}
				level.Categories = level_categories;

				describeCategoryTreeResponse_levels.Add(level);
			}
			describeCategoryTreeResponse.Levels = describeCategoryTreeResponse_levels;
        
			return describeCategoryTreeResponse;
        }
    }
}
