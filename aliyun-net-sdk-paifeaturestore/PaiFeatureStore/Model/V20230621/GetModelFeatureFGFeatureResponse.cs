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
using System.Collections.Generic;
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.PaiFeatureStore.Model.V20230621
{
	public class GetModelFeatureFGFeatureResponse : AcsResponse
	{

		private string requestId;

		private List<GetModelFeatureFGFeature_RawFeaturesItem> rawFeatures;

		private List<GetModelFeatureFGFeature_LookupFeaturesItem> lookupFeatures;

		private List<GetModelFeatureFGFeature_SequenceFeaturesItem> sequenceFeatures;

		private List<string> reserves;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public List<GetModelFeatureFGFeature_RawFeaturesItem> RawFeatures
		{
			get
			{
				return rawFeatures;
			}
			set	
			{
				rawFeatures = value;
			}
		}

		public List<GetModelFeatureFGFeature_LookupFeaturesItem> LookupFeatures
		{
			get
			{
				return lookupFeatures;
			}
			set	
			{
				lookupFeatures = value;
			}
		}

		public List<GetModelFeatureFGFeature_SequenceFeaturesItem> SequenceFeatures
		{
			get
			{
				return sequenceFeatures;
			}
			set	
			{
				sequenceFeatures = value;
			}
		}

		public List<string> Reserves
		{
			get
			{
				return reserves;
			}
			set	
			{
				reserves = value;
			}
		}

		public class GetModelFeatureFGFeature_RawFeaturesItem
		{

			private string inputFeatureName;

			private string featureDomain;

			private string featureName;

			private string featureType;

			private string valueType;

			private string defaultValue;

			public string InputFeatureName
			{
				get
				{
					return inputFeatureName;
				}
				set	
				{
					inputFeatureName = value;
				}
			}

			public string FeatureDomain
			{
				get
				{
					return featureDomain;
				}
				set	
				{
					featureDomain = value;
				}
			}

			public string FeatureName
			{
				get
				{
					return featureName;
				}
				set	
				{
					featureName = value;
				}
			}

			public string FeatureType
			{
				get
				{
					return featureType;
				}
				set	
				{
					featureType = value;
				}
			}

			public string ValueType
			{
				get
				{
					return valueType;
				}
				set	
				{
					valueType = value;
				}
			}

			public string DefaultValue
			{
				get
				{
					return defaultValue;
				}
				set	
				{
					defaultValue = value;
				}
			}
		}

		public class GetModelFeatureFGFeature_LookupFeaturesItem
		{

			private string mapFeatureName;

			private string mapFeatureDomain;

			private string featureName;

			private string valueType;

			private string defaultValue;

			private string keyFeatureName;

			private string keyFeatureDomain;

			public string MapFeatureName
			{
				get
				{
					return mapFeatureName;
				}
				set	
				{
					mapFeatureName = value;
				}
			}

			public string MapFeatureDomain
			{
				get
				{
					return mapFeatureDomain;
				}
				set	
				{
					mapFeatureDomain = value;
				}
			}

			public string FeatureName
			{
				get
				{
					return featureName;
				}
				set	
				{
					featureName = value;
				}
			}

			public string ValueType
			{
				get
				{
					return valueType;
				}
				set	
				{
					valueType = value;
				}
			}

			public string DefaultValue
			{
				get
				{
					return defaultValue;
				}
				set	
				{
					defaultValue = value;
				}
			}

			public string KeyFeatureName
			{
				get
				{
					return keyFeatureName;
				}
				set	
				{
					keyFeatureName = value;
				}
			}

			public string KeyFeatureDomain
			{
				get
				{
					return keyFeatureDomain;
				}
				set	
				{
					keyFeatureDomain = value;
				}
			}
		}

		public class GetModelFeatureFGFeature_SequenceFeaturesItem
		{

			private string featureName;

			private long? sequenceLength;

			private string sequenceDelim;

			private string attributeDelim;

			private List<GetModelFeatureFGFeature_SubFeaturesItem> subFeatures;

			public string FeatureName
			{
				get
				{
					return featureName;
				}
				set	
				{
					featureName = value;
				}
			}

			public long? SequenceLength
			{
				get
				{
					return sequenceLength;
				}
				set	
				{
					sequenceLength = value;
				}
			}

			public string SequenceDelim
			{
				get
				{
					return sequenceDelim;
				}
				set	
				{
					sequenceDelim = value;
				}
			}

			public string AttributeDelim
			{
				get
				{
					return attributeDelim;
				}
				set	
				{
					attributeDelim = value;
				}
			}

			public List<GetModelFeatureFGFeature_SubFeaturesItem> SubFeatures
			{
				get
				{
					return subFeatures;
				}
				set	
				{
					subFeatures = value;
				}
			}

			public class GetModelFeatureFGFeature_SubFeaturesItem
			{

				private string inputFeatureName;

				private string featureDomain;

				private string featureName;

				private string featureType;

				private string valueType;

				private string defaultValue;

				public string InputFeatureName
				{
					get
					{
						return inputFeatureName;
					}
					set	
					{
						inputFeatureName = value;
					}
				}

				public string FeatureDomain
				{
					get
					{
						return featureDomain;
					}
					set	
					{
						featureDomain = value;
					}
				}

				public string FeatureName
				{
					get
					{
						return featureName;
					}
					set	
					{
						featureName = value;
					}
				}

				public string FeatureType
				{
					get
					{
						return featureType;
					}
					set	
					{
						featureType = value;
					}
				}

				public string ValueType
				{
					get
					{
						return valueType;
					}
					set	
					{
						valueType = value;
					}
				}

				public string DefaultValue
				{
					get
					{
						return defaultValue;
					}
					set	
					{
						defaultValue = value;
					}
				}
			}
		}
	}
}
