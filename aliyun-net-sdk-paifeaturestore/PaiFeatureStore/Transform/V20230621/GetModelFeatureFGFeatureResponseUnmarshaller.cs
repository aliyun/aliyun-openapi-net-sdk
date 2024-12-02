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
    public class GetModelFeatureFGFeatureResponseUnmarshaller
    {
        public static GetModelFeatureFGFeatureResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetModelFeatureFGFeatureResponse getModelFeatureFGFeatureResponse = new GetModelFeatureFGFeatureResponse();

			getModelFeatureFGFeatureResponse.HttpResponse = _ctx.HttpResponse;
			getModelFeatureFGFeatureResponse.RequestId = _ctx.StringValue("GetModelFeatureFGFeature.RequestId");

			List<string> getModelFeatureFGFeatureResponse_reserves = new List<string>();
			for (int i = 0; i < _ctx.Length("GetModelFeatureFGFeature.Reserves.Length"); i++) {
				getModelFeatureFGFeatureResponse_reserves.Add(_ctx.StringValue("GetModelFeatureFGFeature.Reserves["+ i +"]"));
			}
			getModelFeatureFGFeatureResponse.Reserves = getModelFeatureFGFeatureResponse_reserves;

			List<GetModelFeatureFGFeatureResponse.GetModelFeatureFGFeature_RawFeaturesItem> getModelFeatureFGFeatureResponse_rawFeatures = new List<GetModelFeatureFGFeatureResponse.GetModelFeatureFGFeature_RawFeaturesItem>();
			for (int i = 0; i < _ctx.Length("GetModelFeatureFGFeature.RawFeatures.Length"); i++) {
				GetModelFeatureFGFeatureResponse.GetModelFeatureFGFeature_RawFeaturesItem rawFeaturesItem = new GetModelFeatureFGFeatureResponse.GetModelFeatureFGFeature_RawFeaturesItem();
				rawFeaturesItem.InputFeatureName = _ctx.StringValue("GetModelFeatureFGFeature.RawFeatures["+ i +"].InputFeatureName");
				rawFeaturesItem.FeatureDomain = _ctx.StringValue("GetModelFeatureFGFeature.RawFeatures["+ i +"].FeatureDomain");
				rawFeaturesItem.FeatureName = _ctx.StringValue("GetModelFeatureFGFeature.RawFeatures["+ i +"].FeatureName");
				rawFeaturesItem.FeatureType = _ctx.StringValue("GetModelFeatureFGFeature.RawFeatures["+ i +"].FeatureType");
				rawFeaturesItem.ValueType = _ctx.StringValue("GetModelFeatureFGFeature.RawFeatures["+ i +"].ValueType");
				rawFeaturesItem.DefaultValue = _ctx.StringValue("GetModelFeatureFGFeature.RawFeatures["+ i +"].DefaultValue");

				getModelFeatureFGFeatureResponse_rawFeatures.Add(rawFeaturesItem);
			}
			getModelFeatureFGFeatureResponse.RawFeatures = getModelFeatureFGFeatureResponse_rawFeatures;

			List<GetModelFeatureFGFeatureResponse.GetModelFeatureFGFeature_LookupFeaturesItem> getModelFeatureFGFeatureResponse_lookupFeatures = new List<GetModelFeatureFGFeatureResponse.GetModelFeatureFGFeature_LookupFeaturesItem>();
			for (int i = 0; i < _ctx.Length("GetModelFeatureFGFeature.LookupFeatures.Length"); i++) {
				GetModelFeatureFGFeatureResponse.GetModelFeatureFGFeature_LookupFeaturesItem lookupFeaturesItem = new GetModelFeatureFGFeatureResponse.GetModelFeatureFGFeature_LookupFeaturesItem();
				lookupFeaturesItem.MapFeatureName = _ctx.StringValue("GetModelFeatureFGFeature.LookupFeatures["+ i +"].MapFeatureName");
				lookupFeaturesItem.MapFeatureDomain = _ctx.StringValue("GetModelFeatureFGFeature.LookupFeatures["+ i +"].MapFeatureDomain");
				lookupFeaturesItem.FeatureName = _ctx.StringValue("GetModelFeatureFGFeature.LookupFeatures["+ i +"].FeatureName");
				lookupFeaturesItem.ValueType = _ctx.StringValue("GetModelFeatureFGFeature.LookupFeatures["+ i +"].ValueType");
				lookupFeaturesItem.DefaultValue = _ctx.StringValue("GetModelFeatureFGFeature.LookupFeatures["+ i +"].DefaultValue");
				lookupFeaturesItem.KeyFeatureName = _ctx.StringValue("GetModelFeatureFGFeature.LookupFeatures["+ i +"].KeyFeatureName");
				lookupFeaturesItem.KeyFeatureDomain = _ctx.StringValue("GetModelFeatureFGFeature.LookupFeatures["+ i +"].KeyFeatureDomain");

				getModelFeatureFGFeatureResponse_lookupFeatures.Add(lookupFeaturesItem);
			}
			getModelFeatureFGFeatureResponse.LookupFeatures = getModelFeatureFGFeatureResponse_lookupFeatures;

			List<GetModelFeatureFGFeatureResponse.GetModelFeatureFGFeature_SequenceFeaturesItem> getModelFeatureFGFeatureResponse_sequenceFeatures = new List<GetModelFeatureFGFeatureResponse.GetModelFeatureFGFeature_SequenceFeaturesItem>();
			for (int i = 0; i < _ctx.Length("GetModelFeatureFGFeature.SequenceFeatures.Length"); i++) {
				GetModelFeatureFGFeatureResponse.GetModelFeatureFGFeature_SequenceFeaturesItem sequenceFeaturesItem = new GetModelFeatureFGFeatureResponse.GetModelFeatureFGFeature_SequenceFeaturesItem();
				sequenceFeaturesItem.FeatureName = _ctx.StringValue("GetModelFeatureFGFeature.SequenceFeatures["+ i +"].FeatureName");
				sequenceFeaturesItem.SequenceLength = _ctx.LongValue("GetModelFeatureFGFeature.SequenceFeatures["+ i +"].SequenceLength");
				sequenceFeaturesItem.SequenceDelim = _ctx.StringValue("GetModelFeatureFGFeature.SequenceFeatures["+ i +"].SequenceDelim");
				sequenceFeaturesItem.AttributeDelim = _ctx.StringValue("GetModelFeatureFGFeature.SequenceFeatures["+ i +"].AttributeDelim");

				List<GetModelFeatureFGFeatureResponse.GetModelFeatureFGFeature_SequenceFeaturesItem.GetModelFeatureFGFeature_SubFeaturesItem> sequenceFeaturesItem_subFeatures = new List<GetModelFeatureFGFeatureResponse.GetModelFeatureFGFeature_SequenceFeaturesItem.GetModelFeatureFGFeature_SubFeaturesItem>();
				for (int j = 0; j < _ctx.Length("GetModelFeatureFGFeature.SequenceFeatures["+ i +"].SubFeatures.Length"); j++) {
					GetModelFeatureFGFeatureResponse.GetModelFeatureFGFeature_SequenceFeaturesItem.GetModelFeatureFGFeature_SubFeaturesItem subFeaturesItem = new GetModelFeatureFGFeatureResponse.GetModelFeatureFGFeature_SequenceFeaturesItem.GetModelFeatureFGFeature_SubFeaturesItem();
					subFeaturesItem.InputFeatureName = _ctx.StringValue("GetModelFeatureFGFeature.SequenceFeatures["+ i +"].SubFeatures["+ j +"].InputFeatureName");
					subFeaturesItem.FeatureDomain = _ctx.StringValue("GetModelFeatureFGFeature.SequenceFeatures["+ i +"].SubFeatures["+ j +"].FeatureDomain");
					subFeaturesItem.FeatureName = _ctx.StringValue("GetModelFeatureFGFeature.SequenceFeatures["+ i +"].SubFeatures["+ j +"].FeatureName");
					subFeaturesItem.FeatureType = _ctx.StringValue("GetModelFeatureFGFeature.SequenceFeatures["+ i +"].SubFeatures["+ j +"].FeatureType");
					subFeaturesItem.ValueType = _ctx.StringValue("GetModelFeatureFGFeature.SequenceFeatures["+ i +"].SubFeatures["+ j +"].ValueType");
					subFeaturesItem.DefaultValue = _ctx.StringValue("GetModelFeatureFGFeature.SequenceFeatures["+ i +"].SubFeatures["+ j +"].DefaultValue");

					sequenceFeaturesItem_subFeatures.Add(subFeaturesItem);
				}
				sequenceFeaturesItem.SubFeatures = sequenceFeaturesItem_subFeatures;

				getModelFeatureFGFeatureResponse_sequenceFeatures.Add(sequenceFeaturesItem);
			}
			getModelFeatureFGFeatureResponse.SequenceFeatures = getModelFeatureFGFeatureResponse_sequenceFeatures;
        
			return getModelFeatureFGFeatureResponse;
        }
    }
}
