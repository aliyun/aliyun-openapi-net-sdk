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
using Aliyun.Acs.Vpc.Model.V20160428;

namespace Aliyun.Acs.Vpc.Transform.V20160428
{
    public class ListPhysicalConnectionFeaturesResponseUnmarshaller
    {
        public static ListPhysicalConnectionFeaturesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListPhysicalConnectionFeaturesResponse listPhysicalConnectionFeaturesResponse = new ListPhysicalConnectionFeaturesResponse();

			listPhysicalConnectionFeaturesResponse.HttpResponse = _ctx.HttpResponse;
			listPhysicalConnectionFeaturesResponse.RequestId = _ctx.StringValue("ListPhysicalConnectionFeatures.RequestId");

			List<ListPhysicalConnectionFeaturesResponse.ListPhysicalConnectionFeatures_PhysicalConnectionFeature> listPhysicalConnectionFeaturesResponse_physicalConnectionFeatures = new List<ListPhysicalConnectionFeaturesResponse.ListPhysicalConnectionFeatures_PhysicalConnectionFeature>();
			for (int i = 0; i < _ctx.Length("ListPhysicalConnectionFeatures.PhysicalConnectionFeatures.Length"); i++) {
				ListPhysicalConnectionFeaturesResponse.ListPhysicalConnectionFeatures_PhysicalConnectionFeature physicalConnectionFeature = new ListPhysicalConnectionFeaturesResponse.ListPhysicalConnectionFeatures_PhysicalConnectionFeature();
				physicalConnectionFeature.FeatureKey = _ctx.StringValue("ListPhysicalConnectionFeatures.PhysicalConnectionFeatures["+ i +"].FeatureKey");
				physicalConnectionFeature.FeatureValue = _ctx.StringValue("ListPhysicalConnectionFeatures.PhysicalConnectionFeatures["+ i +"].FeatureValue");

				listPhysicalConnectionFeaturesResponse_physicalConnectionFeatures.Add(physicalConnectionFeature);
			}
			listPhysicalConnectionFeaturesResponse.PhysicalConnectionFeatures = listPhysicalConnectionFeaturesResponse_physicalConnectionFeatures;
        
			return listPhysicalConnectionFeaturesResponse;
        }
    }
}
