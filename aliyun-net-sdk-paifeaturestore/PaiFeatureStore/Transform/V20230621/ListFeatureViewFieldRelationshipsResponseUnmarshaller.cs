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
    public class ListFeatureViewFieldRelationshipsResponseUnmarshaller
    {
        public static ListFeatureViewFieldRelationshipsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListFeatureViewFieldRelationshipsResponse listFeatureViewFieldRelationshipsResponse = new ListFeatureViewFieldRelationshipsResponse();

			listFeatureViewFieldRelationshipsResponse.HttpResponse = _ctx.HttpResponse;
			listFeatureViewFieldRelationshipsResponse.RequestId = _ctx.StringValue("ListFeatureViewFieldRelationships.RequestId");

			List<ListFeatureViewFieldRelationshipsResponse.ListFeatureViewFieldRelationships_RelationshipsItem> listFeatureViewFieldRelationshipsResponse_relationships = new List<ListFeatureViewFieldRelationshipsResponse.ListFeatureViewFieldRelationships_RelationshipsItem>();
			for (int i = 0; i < _ctx.Length("ListFeatureViewFieldRelationships.Relationships.Length"); i++) {
				ListFeatureViewFieldRelationshipsResponse.ListFeatureViewFieldRelationships_RelationshipsItem relationshipsItem = new ListFeatureViewFieldRelationshipsResponse.ListFeatureViewFieldRelationships_RelationshipsItem();
				relationshipsItem.FeatureName = _ctx.StringValue("ListFeatureViewFieldRelationships.Relationships["+ i +"].FeatureName");
				relationshipsItem.OnlineTableName = _ctx.StringValue("ListFeatureViewFieldRelationships.Relationships["+ i +"].OnlineTableName");
				relationshipsItem.OfflineTableName = _ctx.StringValue("ListFeatureViewFieldRelationships.Relationships["+ i +"].OfflineTableName");

				List<ListFeatureViewFieldRelationshipsResponse.ListFeatureViewFieldRelationships_RelationshipsItem.ListFeatureViewFieldRelationships_ModelsItem> relationshipsItem_models = new List<ListFeatureViewFieldRelationshipsResponse.ListFeatureViewFieldRelationships_RelationshipsItem.ListFeatureViewFieldRelationships_ModelsItem>();
				for (int j = 0; j < _ctx.Length("ListFeatureViewFieldRelationships.Relationships["+ i +"].Models.Length"); j++) {
					ListFeatureViewFieldRelationshipsResponse.ListFeatureViewFieldRelationships_RelationshipsItem.ListFeatureViewFieldRelationships_ModelsItem modelsItem = new ListFeatureViewFieldRelationshipsResponse.ListFeatureViewFieldRelationships_RelationshipsItem.ListFeatureViewFieldRelationships_ModelsItem();
					modelsItem.ModelId = _ctx.StringValue("ListFeatureViewFieldRelationships.Relationships["+ i +"].Models["+ j +"].ModelId");
					modelsItem.ModelName = _ctx.StringValue("ListFeatureViewFieldRelationships.Relationships["+ i +"].Models["+ j +"].ModelName");
					modelsItem.FeatureAliasName = _ctx.StringValue("ListFeatureViewFieldRelationships.Relationships["+ i +"].Models["+ j +"].FeatureAliasName");

					relationshipsItem_models.Add(modelsItem);
				}
				relationshipsItem.Models = relationshipsItem_models;

				listFeatureViewFieldRelationshipsResponse_relationships.Add(relationshipsItem);
			}
			listFeatureViewFieldRelationshipsResponse.Relationships = listFeatureViewFieldRelationshipsResponse_relationships;
        
			return listFeatureViewFieldRelationshipsResponse;
        }
    }
}
