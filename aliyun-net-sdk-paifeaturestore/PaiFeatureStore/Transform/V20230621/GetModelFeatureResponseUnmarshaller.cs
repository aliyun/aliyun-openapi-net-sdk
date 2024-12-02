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
    public class GetModelFeatureResponseUnmarshaller
    {
        public static GetModelFeatureResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetModelFeatureResponse getModelFeatureResponse = new GetModelFeatureResponse();

			getModelFeatureResponse.HttpResponse = _ctx.HttpResponse;
			getModelFeatureResponse.RequestId = _ctx.StringValue("GetModelFeature.RequestId");
			getModelFeatureResponse.ProjectId = _ctx.StringValue("GetModelFeature.ProjectId");
			getModelFeatureResponse.ProjectName = _ctx.StringValue("GetModelFeature.ProjectName");
			getModelFeatureResponse.Name = _ctx.StringValue("GetModelFeature.Name");
			getModelFeatureResponse.Owner = _ctx.StringValue("GetModelFeature.Owner");
			getModelFeatureResponse.GmtCreateTime = _ctx.StringValue("GetModelFeature.GmtCreateTime");
			getModelFeatureResponse.GmtModifiedTime = _ctx.StringValue("GetModelFeature.GmtModifiedTime");
			getModelFeatureResponse.LabelTableId = _ctx.StringValue("GetModelFeature.LabelTableId");
			getModelFeatureResponse.LabelTableName = _ctx.StringValue("GetModelFeature.LabelTableName");
			getModelFeatureResponse.TrainingSetTable = _ctx.StringValue("GetModelFeature.TrainingSetTable");
			getModelFeatureResponse.TrainingSetFGTable = _ctx.StringValue("GetModelFeature.TrainingSetFGTable");
			getModelFeatureResponse.ExportTrainingSetTableScript = _ctx.StringValue("GetModelFeature.ExportTrainingSetTableScript");
			getModelFeatureResponse.LabelPriorityLevel = _ctx.LongValue("GetModelFeature.LabelPriorityLevel");

			GetModelFeatureResponse.GetModelFeature_Relations relations = new GetModelFeatureResponse.GetModelFeature_Relations();

			List<GetModelFeatureResponse.GetModelFeature_Relations.GetModelFeature_DomainsItem> relations_domains = new List<GetModelFeatureResponse.GetModelFeature_Relations.GetModelFeature_DomainsItem>();
			for (int i = 0; i < _ctx.Length("GetModelFeature.Relations.Domains.Length"); i++) {
				GetModelFeatureResponse.GetModelFeature_Relations.GetModelFeature_DomainsItem domainsItem = new GetModelFeatureResponse.GetModelFeature_Relations.GetModelFeature_DomainsItem();
				domainsItem.Id = _ctx.StringValue("GetModelFeature.Relations.Domains["+ i +"].Id");
				domainsItem.Name = _ctx.StringValue("GetModelFeature.Relations.Domains["+ i +"].Name");
				domainsItem.DomainType = _ctx.StringValue("GetModelFeature.Relations.Domains["+ i +"].DomainType");

				relations_domains.Add(domainsItem);
			}
			relations.Domains = relations_domains;

			List<GetModelFeatureResponse.GetModelFeature_Relations.GetModelFeature_LinksItem> relations_links = new List<GetModelFeatureResponse.GetModelFeature_Relations.GetModelFeature_LinksItem>();
			for (int i = 0; i < _ctx.Length("GetModelFeature.Relations.Links.Length"); i++) {
				GetModelFeatureResponse.GetModelFeature_Relations.GetModelFeature_LinksItem linksItem = new GetModelFeatureResponse.GetModelFeature_Relations.GetModelFeature_LinksItem();
				linksItem.From = _ctx.StringValue("GetModelFeature.Relations.Links["+ i +"].From");
				linksItem.To = _ctx.StringValue("GetModelFeature.Relations.Links["+ i +"].To");
				linksItem.Link = _ctx.StringValue("GetModelFeature.Relations.Links["+ i +"].Link");

				relations_links.Add(linksItem);
			}
			relations.Links = relations_links;
			getModelFeatureResponse.Relations = relations;

			List<GetModelFeatureResponse.GetModelFeature_FeaturesItem> getModelFeatureResponse_features = new List<GetModelFeatureResponse.GetModelFeature_FeaturesItem>();
			for (int i = 0; i < _ctx.Length("GetModelFeature.Features.Length"); i++) {
				GetModelFeatureResponse.GetModelFeature_FeaturesItem featuresItem = new GetModelFeatureResponse.GetModelFeature_FeaturesItem();
				featuresItem.FeatureViewId = _ctx.StringValue("GetModelFeature.Features["+ i +"].FeatureViewId");
				featuresItem.FeatureViewName = _ctx.StringValue("GetModelFeature.Features["+ i +"].FeatureViewName");
				featuresItem.Name = _ctx.StringValue("GetModelFeature.Features["+ i +"].Name");
				featuresItem.Type = _ctx.StringValue("GetModelFeature.Features["+ i +"].Type");
				featuresItem.AliasName = _ctx.StringValue("GetModelFeature.Features["+ i +"].AliasName");

				getModelFeatureResponse_features.Add(featuresItem);
			}
			getModelFeatureResponse.Features = getModelFeatureResponse_features;
        
			return getModelFeatureResponse;
        }
    }
}
