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
    public class ListFeatureViewRelationshipsResponseUnmarshaller
    {
        public static ListFeatureViewRelationshipsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListFeatureViewRelationshipsResponse listFeatureViewRelationshipsResponse = new ListFeatureViewRelationshipsResponse();

			listFeatureViewRelationshipsResponse.HttpResponse = _ctx.HttpResponse;
			listFeatureViewRelationshipsResponse.RequestId = _ctx.StringValue("ListFeatureViewRelationships.RequestId");

			List<ListFeatureViewRelationshipsResponse.ListFeatureViewRelationships_RelationshipsItem> listFeatureViewRelationshipsResponse_relationships = new List<ListFeatureViewRelationshipsResponse.ListFeatureViewRelationships_RelationshipsItem>();
			for (int i = 0; i < _ctx.Length("ListFeatureViewRelationships.Relationships.Length"); i++) {
				ListFeatureViewRelationshipsResponse.ListFeatureViewRelationships_RelationshipsItem relationshipsItem = new ListFeatureViewRelationshipsResponse.ListFeatureViewRelationships_RelationshipsItem();
				relationshipsItem.FeatureViewName = _ctx.StringValue("ListFeatureViewRelationships.Relationships["+ i +"].FeatureViewName");
				relationshipsItem.ProjectName = _ctx.StringValue("ListFeatureViewRelationships.Relationships["+ i +"].ProjectName");

				List<ListFeatureViewRelationshipsResponse.ListFeatureViewRelationships_RelationshipsItem.ListFeatureViewRelationships_ModelsItem> relationshipsItem_models = new List<ListFeatureViewRelationshipsResponse.ListFeatureViewRelationships_RelationshipsItem.ListFeatureViewRelationships_ModelsItem>();
				for (int j = 0; j < _ctx.Length("ListFeatureViewRelationships.Relationships["+ i +"].Models.Length"); j++) {
					ListFeatureViewRelationshipsResponse.ListFeatureViewRelationships_RelationshipsItem.ListFeatureViewRelationships_ModelsItem modelsItem = new ListFeatureViewRelationshipsResponse.ListFeatureViewRelationships_RelationshipsItem.ListFeatureViewRelationships_ModelsItem();
					modelsItem.ModelId = _ctx.StringValue("ListFeatureViewRelationships.Relationships["+ i +"].Models["+ j +"].ModelId");
					modelsItem.ModelName = _ctx.StringValue("ListFeatureViewRelationships.Relationships["+ i +"].Models["+ j +"].ModelName");

					relationshipsItem_models.Add(modelsItem);
				}
				relationshipsItem.Models = relationshipsItem_models;

				listFeatureViewRelationshipsResponse_relationships.Add(relationshipsItem);
			}
			listFeatureViewRelationshipsResponse.Relationships = listFeatureViewRelationshipsResponse_relationships;
        
			return listFeatureViewRelationshipsResponse;
        }
    }
}
