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
    public class ListProjectFeaturesResponseUnmarshaller
    {
        public static ListProjectFeaturesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListProjectFeaturesResponse listProjectFeaturesResponse = new ListProjectFeaturesResponse();

			listProjectFeaturesResponse.HttpResponse = _ctx.HttpResponse;
			listProjectFeaturesResponse.TotalCount = _ctx.IntegerValue("ListProjectFeatures.TotalCount");
			listProjectFeaturesResponse.RequestId = _ctx.StringValue("ListProjectFeatures.requestId");

			List<ListProjectFeaturesResponse.ListProjectFeatures_FeaturesItem> listProjectFeaturesResponse_features = new List<ListProjectFeaturesResponse.ListProjectFeatures_FeaturesItem>();
			for (int i = 0; i < _ctx.Length("ListProjectFeatures.Features.Length"); i++) {
				ListProjectFeaturesResponse.ListProjectFeatures_FeaturesItem featuresItem = new ListProjectFeaturesResponse.ListProjectFeatures_FeaturesItem();
				featuresItem.Name = _ctx.StringValue("ListProjectFeatures.Features["+ i +"].Name");
				featuresItem.Type = _ctx.StringValue("ListProjectFeatures.Features["+ i +"].Type");
				featuresItem.FeatureViewId = _ctx.StringValue("ListProjectFeatures.Features["+ i +"].FeatureViewId");
				featuresItem.FeatureViewName = _ctx.StringValue("ListProjectFeatures.Features["+ i +"].FeatureViewName");
				featuresItem.Owner = _ctx.StringValue("ListProjectFeatures.Features["+ i +"].Owner");
				featuresItem.ModelFeatureCount = _ctx.IntegerValue("ListProjectFeatures.Features["+ i +"].ModelFeatureCount");
				featuresItem.AliasNames = _ctx.StringValue("ListProjectFeatures.Features["+ i +"].AliasNames");
				featuresItem.GmtCreateTime = _ctx.StringValue("ListProjectFeatures.Features["+ i +"].GmtCreateTime");

				listProjectFeaturesResponse_features.Add(featuresItem);
			}
			listProjectFeaturesResponse.Features = listProjectFeaturesResponse_features;
        
			return listProjectFeaturesResponse;
        }
    }
}
