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
using Aliyun.Acs.PaiFeatureStore.Model.V20230621;

namespace Aliyun.Acs.PaiFeatureStore.Transform.V20230621
{
    public class ListProjectFeatureViewsResponseUnmarshaller
    {
        public static ListProjectFeatureViewsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListProjectFeatureViewsResponse listProjectFeatureViewsResponse = new ListProjectFeatureViewsResponse();

			listProjectFeatureViewsResponse.HttpResponse = _ctx.HttpResponse;
			listProjectFeatureViewsResponse.RequestId = _ctx.StringValue("ListProjectFeatureViews.RequestId");
			listProjectFeatureViewsResponse.TotalCount = _ctx.LongValue("ListProjectFeatureViews.TotalCount");

			List<ListProjectFeatureViewsResponse.ListProjectFeatureViews_FeatureViewsItem> listProjectFeatureViewsResponse_featureViews = new List<ListProjectFeatureViewsResponse.ListProjectFeatureViews_FeatureViewsItem>();
			for (int i = 0; i < _ctx.Length("ListProjectFeatureViews.FeatureViews.Length"); i++) {
				ListProjectFeatureViewsResponse.ListProjectFeatureViews_FeatureViewsItem featureViewsItem = new ListProjectFeatureViewsResponse.ListProjectFeatureViews_FeatureViewsItem();
				featureViewsItem.Name = _ctx.StringValue("ListProjectFeatureViews.FeatureViews["+ i +"].Name");
				featureViewsItem.FeatureViewId = _ctx.StringValue("ListProjectFeatureViews.FeatureViews["+ i +"].FeatureViewId");
				featureViewsItem.Type = _ctx.StringValue("ListProjectFeatureViews.FeatureViews["+ i +"].Type");

				List<ListProjectFeatureViewsResponse.ListProjectFeatureViews_FeatureViewsItem.ListProjectFeatureViews_FeaturesItem> featureViewsItem_features = new List<ListProjectFeatureViewsResponse.ListProjectFeatureViews_FeatureViewsItem.ListProjectFeatureViews_FeaturesItem>();
				for (int j = 0; j < _ctx.Length("ListProjectFeatureViews.FeatureViews["+ i +"].Features.Length"); j++) {
					ListProjectFeatureViewsResponse.ListProjectFeatureViews_FeatureViewsItem.ListProjectFeatureViews_FeaturesItem featuresItem = new ListProjectFeatureViewsResponse.ListProjectFeatureViews_FeatureViewsItem.ListProjectFeatureViews_FeaturesItem();
					featuresItem.Name = _ctx.StringValue("ListProjectFeatureViews.FeatureViews["+ i +"].Features["+ j +"].Name");
					featuresItem.Type = _ctx.StringValue("ListProjectFeatureViews.FeatureViews["+ i +"].Features["+ j +"].Type");

					List<string> featuresItem_attributes = new List<string>();
					for (int k = 0; k < _ctx.Length("ListProjectFeatureViews.FeatureViews["+ i +"].Features["+ j +"].Attributes.Length"); k++) {
						featuresItem_attributes.Add(_ctx.StringValue("ListProjectFeatureViews.FeatureViews["+ i +"].Features["+ j +"].Attributes["+ k +"]"));
					}
					featuresItem.Attributes = featuresItem_attributes;

					featureViewsItem_features.Add(featuresItem);
				}
				featureViewsItem.Features = featureViewsItem_features;

				listProjectFeatureViewsResponse_featureViews.Add(featureViewsItem);
			}
			listProjectFeatureViewsResponse.FeatureViews = listProjectFeatureViewsResponse_featureViews;
        
			return listProjectFeatureViewsResponse;
        }
    }
}
