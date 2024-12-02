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
    public class ListModelFeaturesResponseUnmarshaller
    {
        public static ListModelFeaturesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListModelFeaturesResponse listModelFeaturesResponse = new ListModelFeaturesResponse();

			listModelFeaturesResponse.HttpResponse = _ctx.HttpResponse;
			listModelFeaturesResponse.RequestId = _ctx.StringValue("ListModelFeatures.RequestId");
			listModelFeaturesResponse.TotalCount = _ctx.LongValue("ListModelFeatures.TotalCount");

			List<ListModelFeaturesResponse.ListModelFeatures_ModelFeaturesItem> listModelFeaturesResponse_modelFeatures = new List<ListModelFeaturesResponse.ListModelFeatures_ModelFeaturesItem>();
			for (int i = 0; i < _ctx.Length("ListModelFeatures.ModelFeatures.Length"); i++) {
				ListModelFeaturesResponse.ListModelFeatures_ModelFeaturesItem modelFeaturesItem = new ListModelFeaturesResponse.ListModelFeatures_ModelFeaturesItem();
				modelFeaturesItem.ModelFeatureId = _ctx.StringValue("ListModelFeatures.ModelFeatures["+ i +"].ModelFeatureId");
				modelFeaturesItem.ProjectId = _ctx.StringValue("ListModelFeatures.ModelFeatures["+ i +"].ProjectId");
				modelFeaturesItem.ProjectName = _ctx.StringValue("ListModelFeatures.ModelFeatures["+ i +"].ProjectName");
				modelFeaturesItem.Name = _ctx.StringValue("ListModelFeatures.ModelFeatures["+ i +"].Name");
				modelFeaturesItem.Owner = _ctx.StringValue("ListModelFeatures.ModelFeatures["+ i +"].Owner");
				modelFeaturesItem.GmtCreateTime = _ctx.StringValue("ListModelFeatures.ModelFeatures["+ i +"].GmtCreateTime");
				modelFeaturesItem.GmtModifiedTime = _ctx.StringValue("ListModelFeatures.ModelFeatures["+ i +"].GmtModifiedTime");
				modelFeaturesItem.LabelTableName = _ctx.StringValue("ListModelFeatures.ModelFeatures["+ i +"].LabelTableName");

				listModelFeaturesResponse_modelFeatures.Add(modelFeaturesItem);
			}
			listModelFeaturesResponse.ModelFeatures = listModelFeaturesResponse_modelFeatures;
        
			return listModelFeaturesResponse;
        }
    }
}
