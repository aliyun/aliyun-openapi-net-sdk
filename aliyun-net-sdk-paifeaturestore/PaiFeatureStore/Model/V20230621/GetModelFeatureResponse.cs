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
	public class GetModelFeatureResponse : AcsResponse
	{

		private string requestId;

		private string projectId;

		private string projectName;

		private string name;

		private string owner;

		private string gmtCreateTime;

		private string gmtModifiedTime;

		private string labelTableId;

		private string labelTableName;

		private string trainingSetTable;

		private string trainingSetFGTable;

		private string exportTrainingSetTableScript;

		private long? labelPriorityLevel;

		private List<GetModelFeature_FeaturesItem> features;

		private GetModelFeature_Relations relations;

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

		public string ProjectId
		{
			get
			{
				return projectId;
			}
			set	
			{
				projectId = value;
			}
		}

		public string ProjectName
		{
			get
			{
				return projectName;
			}
			set	
			{
				projectName = value;
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
			}
		}

		public string Owner
		{
			get
			{
				return owner;
			}
			set	
			{
				owner = value;
			}
		}

		public string GmtCreateTime
		{
			get
			{
				return gmtCreateTime;
			}
			set	
			{
				gmtCreateTime = value;
			}
		}

		public string GmtModifiedTime
		{
			get
			{
				return gmtModifiedTime;
			}
			set	
			{
				gmtModifiedTime = value;
			}
		}

		public string LabelTableId
		{
			get
			{
				return labelTableId;
			}
			set	
			{
				labelTableId = value;
			}
		}

		public string LabelTableName
		{
			get
			{
				return labelTableName;
			}
			set	
			{
				labelTableName = value;
			}
		}

		public string TrainingSetTable
		{
			get
			{
				return trainingSetTable;
			}
			set	
			{
				trainingSetTable = value;
			}
		}

		public string TrainingSetFGTable
		{
			get
			{
				return trainingSetFGTable;
			}
			set	
			{
				trainingSetFGTable = value;
			}
		}

		public string ExportTrainingSetTableScript
		{
			get
			{
				return exportTrainingSetTableScript;
			}
			set	
			{
				exportTrainingSetTableScript = value;
			}
		}

		public long? LabelPriorityLevel
		{
			get
			{
				return labelPriorityLevel;
			}
			set	
			{
				labelPriorityLevel = value;
			}
		}

		public List<GetModelFeature_FeaturesItem> Features
		{
			get
			{
				return features;
			}
			set	
			{
				features = value;
			}
		}

		public GetModelFeature_Relations Relations
		{
			get
			{
				return relations;
			}
			set	
			{
				relations = value;
			}
		}

		public class GetModelFeature_FeaturesItem
		{

			private string featureViewId;

			private string featureViewName;

			private string name;

			private string type;

			private string aliasName;

			public string FeatureViewId
			{
				get
				{
					return featureViewId;
				}
				set	
				{
					featureViewId = value;
				}
			}

			public string FeatureViewName
			{
				get
				{
					return featureViewName;
				}
				set	
				{
					featureViewName = value;
				}
			}

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public string Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
				}
			}

			public string AliasName
			{
				get
				{
					return aliasName;
				}
				set	
				{
					aliasName = value;
				}
			}
		}

		public class GetModelFeature_Relations
		{

			private List<GetModelFeature_DomainsItem> domains;

			private List<GetModelFeature_LinksItem> links;

			public List<GetModelFeature_DomainsItem> Domains
			{
				get
				{
					return domains;
				}
				set	
				{
					domains = value;
				}
			}

			public List<GetModelFeature_LinksItem> Links
			{
				get
				{
					return links;
				}
				set	
				{
					links = value;
				}
			}

			public class GetModelFeature_DomainsItem
			{

				private string id;

				private string name;

				private string domainType;

				public string Id
				{
					get
					{
						return id;
					}
					set	
					{
						id = value;
					}
				}

				public string Name
				{
					get
					{
						return name;
					}
					set	
					{
						name = value;
					}
				}

				public string DomainType
				{
					get
					{
						return domainType;
					}
					set	
					{
						domainType = value;
					}
				}
			}

			public class GetModelFeature_LinksItem
			{

				private string from;

				private string to;

				private string link;

				public string From
				{
					get
					{
						return from;
					}
					set	
					{
						from = value;
					}
				}

				public string To
				{
					get
					{
						return to;
					}
					set	
					{
						to = value;
					}
				}

				public string Link
				{
					get
					{
						return link;
					}
					set	
					{
						link = value;
					}
				}
			}
		}
	}
}
