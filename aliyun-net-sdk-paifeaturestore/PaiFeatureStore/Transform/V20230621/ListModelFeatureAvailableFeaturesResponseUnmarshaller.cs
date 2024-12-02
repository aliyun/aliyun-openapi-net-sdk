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
    public class ListModelFeatureAvailableFeaturesResponseUnmarshaller
    {
        public static ListModelFeatureAvailableFeaturesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListModelFeatureAvailableFeaturesResponse listModelFeatureAvailableFeaturesResponse = new ListModelFeatureAvailableFeaturesResponse();

			listModelFeatureAvailableFeaturesResponse.HttpResponse = _ctx.HttpResponse;
			listModelFeatureAvailableFeaturesResponse.RequestId = _ctx.StringValue("ListModelFeatureAvailableFeatures.requestId");
			listModelFeatureAvailableFeaturesResponse.TotalCount = _ctx.LongValue("ListModelFeatureAvailableFeatures.TotalCount");

			List<ListModelFeatureAvailableFeaturesResponse.ListModelFeatureAvailableFeatures_AvailableFeatures> listModelFeatureAvailableFeaturesResponse_avaliableFeatures = new List<ListModelFeatureAvailableFeaturesResponse.ListModelFeatureAvailableFeatures_AvailableFeatures>();
			for (int i = 0; i < _ctx.Length("ListModelFeatureAvailableFeatures.AvaliableFeatures.Length"); i++) {
				ListModelFeatureAvailableFeaturesResponse.ListModelFeatureAvailableFeatures_AvailableFeatures availableFeatures = new ListModelFeatureAvailableFeaturesResponse.ListModelFeatureAvailableFeatures_AvailableFeatures();
				availableFeatures.Name = _ctx.StringValue("ListModelFeatureAvailableFeatures.AvaliableFeatures["+ i +"].Name");
				availableFeatures.Type = _ctx.StringValue("ListModelFeatureAvailableFeatures.AvaliableFeatures["+ i +"].Type");
				availableFeatures.SourceType = _ctx.StringValue("ListModelFeatureAvailableFeatures.AvaliableFeatures["+ i +"].SourceType");
				availableFeatures.SourceName = _ctx.StringValue("ListModelFeatureAvailableFeatures.AvaliableFeatures["+ i +"].SourceName");

				listModelFeatureAvailableFeaturesResponse_avaliableFeatures.Add(availableFeatures);
			}
			listModelFeatureAvailableFeaturesResponse.AvaliableFeatures = listModelFeatureAvailableFeaturesResponse_avaliableFeatures;
        
			return listModelFeatureAvailableFeaturesResponse;
        }
    }
}
