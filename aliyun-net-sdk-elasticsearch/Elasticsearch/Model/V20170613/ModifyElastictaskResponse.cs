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

using Aliyun.Acs.Core;

namespace Aliyun.Acs.elasticsearch.Model.V20170613
{
	public class ModifyElastictaskResponse : AcsResponse
	{

		private string requestId;

		private ModifyElastictask_Result result;

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

		public ModifyElastictask_Result Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class ModifyElastictask_Result
		{

			private ModifyElastictask_ElasticExpansionTask elasticExpansionTask;

			private ModifyElastictask_ElasticShrinkTask elasticShrinkTask;

			public ModifyElastictask_ElasticExpansionTask ElasticExpansionTask
			{
				get
				{
					return elasticExpansionTask;
				}
				set	
				{
					elasticExpansionTask = value;
				}
			}

			public ModifyElastictask_ElasticShrinkTask ElasticShrinkTask
			{
				get
				{
					return elasticShrinkTask;
				}
				set	
				{
					elasticShrinkTask = value;
				}
			}

			public class ModifyElastictask_ElasticExpansionTask
			{

				private string triggerType;

				private string cronExpression;

				private int? elasticNodeCount;

				private int? replicaCount;

				private List<string> targetIndices;

				public string TriggerType
				{
					get
					{
						return triggerType;
					}
					set	
					{
						triggerType = value;
					}
				}

				public string CronExpression
				{
					get
					{
						return cronExpression;
					}
					set	
					{
						cronExpression = value;
					}
				}

				public int? ElasticNodeCount
				{
					get
					{
						return elasticNodeCount;
					}
					set	
					{
						elasticNodeCount = value;
					}
				}

				public int? ReplicaCount
				{
					get
					{
						return replicaCount;
					}
					set	
					{
						replicaCount = value;
					}
				}

				public List<string> TargetIndices
				{
					get
					{
						return targetIndices;
					}
					set	
					{
						targetIndices = value;
					}
				}
			}

			public class ModifyElastictask_ElasticShrinkTask
			{

				private string triggerType;

				private string cronExpression;

				private int? elasticNodeCount;

				private int? replicaCount;

				private List<string> targetIndices1;

				public string TriggerType
				{
					get
					{
						return triggerType;
					}
					set	
					{
						triggerType = value;
					}
				}

				public string CronExpression
				{
					get
					{
						return cronExpression;
					}
					set	
					{
						cronExpression = value;
					}
				}

				public int? ElasticNodeCount
				{
					get
					{
						return elasticNodeCount;
					}
					set	
					{
						elasticNodeCount = value;
					}
				}

				public int? ReplicaCount
				{
					get
					{
						return replicaCount;
					}
					set	
					{
						replicaCount = value;
					}
				}

				public List<string> TargetIndices1
				{
					get
					{
						return targetIndices1;
					}
					set	
					{
						targetIndices1 = value;
					}
				}
			}
		}
	}
}
