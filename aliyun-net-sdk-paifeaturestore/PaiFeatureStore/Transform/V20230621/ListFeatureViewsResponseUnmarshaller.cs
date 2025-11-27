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
    public class ListFeatureViewsResponseUnmarshaller
    {
        public static ListFeatureViewsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListFeatureViewsResponse listFeatureViewsResponse = new ListFeatureViewsResponse();

			listFeatureViewsResponse.HttpResponse = _ctx.HttpResponse;
			listFeatureViewsResponse.RequestId = _ctx.StringValue("ListFeatureViews.RequestId");
			listFeatureViewsResponse.TotalCount = _ctx.LongValue("ListFeatureViews.TotalCount");

			List<ListFeatureViewsResponse.ListFeatureViews_FeatureViewsItem> listFeatureViewsResponse_featureViews = new List<ListFeatureViewsResponse.ListFeatureViews_FeatureViewsItem>();
			for (int i = 0; i < _ctx.Length("ListFeatureViews.FeatureViews.Length"); i++) {
				ListFeatureViewsResponse.ListFeatureViews_FeatureViewsItem featureViewsItem = new ListFeatureViewsResponse.ListFeatureViews_FeatureViewsItem();
				featureViewsItem.FeatureViewId = _ctx.StringValue("ListFeatureViews.FeatureViews["+ i +"].FeatureViewId");
				featureViewsItem.ProjectId = _ctx.StringValue("ListFeatureViews.FeatureViews["+ i +"].ProjectId");
				featureViewsItem.ProjectName = _ctx.StringValue("ListFeatureViews.FeatureViews["+ i +"].ProjectName");
				featureViewsItem.FeatureEntityName = _ctx.StringValue("ListFeatureViews.FeatureViews["+ i +"].FeatureEntityName");
				featureViewsItem.Name = _ctx.StringValue("ListFeatureViews.FeatureViews["+ i +"].Name");
				featureViewsItem.Owner = _ctx.StringValue("ListFeatureViews.FeatureViews["+ i +"].Owner");
				featureViewsItem.Type = _ctx.StringValue("ListFeatureViews.FeatureViews["+ i +"].Type");
				featureViewsItem.WriteToFeatureDB = _ctx.BooleanValue("ListFeatureViews.FeatureViews["+ i +"].WriteToFeatureDB");
				featureViewsItem.GmtCreateTime = _ctx.StringValue("ListFeatureViews.FeatureViews["+ i +"].GmtCreateTime");
				featureViewsItem.GmtModifiedTime = _ctx.StringValue("ListFeatureViews.FeatureViews["+ i +"].GmtModifiedTime");
				featureViewsItem.RegisterTable = _ctx.StringValue("ListFeatureViews.FeatureViews["+ i +"].RegisterTable");
				featureViewsItem.RegisterDatasourceName = _ctx.StringValue("ListFeatureViews.FeatureViews["+ i +"].RegisterDatasourceName");
				featureViewsItem.TTL = _ctx.IntegerValue("ListFeatureViews.FeatureViews["+ i +"].TTL");
				featureViewsItem.RegisterDatasourceId = _ctx.StringValue("ListFeatureViews.FeatureViews["+ i +"].RegisterDatasourceId");

				listFeatureViewsResponse_featureViews.Add(featureViewsItem);
			}
			listFeatureViewsResponse.FeatureViews = listFeatureViewsResponse_featureViews;
        
			return listFeatureViewsResponse;
        }
    }
}
