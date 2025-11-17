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
    public class ListFeatureEntitiesResponseUnmarshaller
    {
        public static ListFeatureEntitiesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListFeatureEntitiesResponse listFeatureEntitiesResponse = new ListFeatureEntitiesResponse();

			listFeatureEntitiesResponse.HttpResponse = _ctx.HttpResponse;
			listFeatureEntitiesResponse.RequestId = _ctx.StringValue("ListFeatureEntities.RequestId");
			listFeatureEntitiesResponse.TotalCount = _ctx.IntegerValue("ListFeatureEntities.TotalCount");

			List<ListFeatureEntitiesResponse.ListFeatureEntities_FeatureEntitiesItem> listFeatureEntitiesResponse_featureEntities = new List<ListFeatureEntitiesResponse.ListFeatureEntities_FeatureEntitiesItem>();
			for (int i = 0; i < _ctx.Length("ListFeatureEntities.FeatureEntities.Length"); i++) {
				ListFeatureEntitiesResponse.ListFeatureEntities_FeatureEntitiesItem featureEntitiesItem = new ListFeatureEntitiesResponse.ListFeatureEntities_FeatureEntitiesItem();
				featureEntitiesItem.FeatureEntityId = _ctx.StringValue("ListFeatureEntities.FeatureEntities["+ i +"].FeatureEntityId");
				featureEntitiesItem.GmtCreateTime = _ctx.StringValue("ListFeatureEntities.FeatureEntities["+ i +"].GmtCreateTime");
				featureEntitiesItem.JoinId = _ctx.StringValue("ListFeatureEntities.FeatureEntities["+ i +"].JoinId");
				featureEntitiesItem.Name = _ctx.StringValue("ListFeatureEntities.FeatureEntities["+ i +"].Name");
				featureEntitiesItem.Owner = _ctx.StringValue("ListFeatureEntities.FeatureEntities["+ i +"].Owner");
				featureEntitiesItem.ProjectId = _ctx.StringValue("ListFeatureEntities.FeatureEntities["+ i +"].ProjectId");
				featureEntitiesItem.ProjectName = _ctx.StringValue("ListFeatureEntities.FeatureEntities["+ i +"].ProjectName");
				featureEntitiesItem.ParentFeatureEntityId = _ctx.StringValue("ListFeatureEntities.FeatureEntities["+ i +"].ParentFeatureEntityId");
				featureEntitiesItem.ParentFeatureEntityName = _ctx.StringValue("ListFeatureEntities.FeatureEntities["+ i +"].ParentFeatureEntityName");
				featureEntitiesItem.ParentJoinId = _ctx.StringValue("ListFeatureEntities.FeatureEntities["+ i +"].ParentJoinId");

				listFeatureEntitiesResponse_featureEntities.Add(featureEntitiesItem);
			}
			listFeatureEntitiesResponse.FeatureEntities = listFeatureEntitiesResponse_featureEntities;
        
			return listFeatureEntitiesResponse;
        }
    }
}
