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

namespace Aliyun.Acs.ROS.Model.V20190910
{
	public class ListStackResourceDriftsResponse : AcsResponse
	{

		private string requestId;

		private string nextToken;

		private List<ListStackResourceDrifts_ResourceDrift> resourceDrifts;

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

		public string NextToken
		{
			get
			{
				return nextToken;
			}
			set	
			{
				nextToken = value;
			}
		}

		public List<ListStackResourceDrifts_ResourceDrift> ResourceDrifts
		{
			get
			{
				return resourceDrifts;
			}
			set	
			{
				resourceDrifts = value;
			}
		}

		public class ListStackResourceDrifts_ResourceDrift
		{

			private string driftDetectionTime;

			private string resourceDriftStatus;

			private string stackId;

			private string resourceType;

			private string physicalResourceId;

			private string logicalResourceId;

			private string actualProperties;

			private string expectedProperties;

			private List<ListStackResourceDrifts_PropertyDifference> propertyDifferences;

			public string DriftDetectionTime
			{
				get
				{
					return driftDetectionTime;
				}
				set	
				{
					driftDetectionTime = value;
				}
			}

			public string ResourceDriftStatus
			{
				get
				{
					return resourceDriftStatus;
				}
				set	
				{
					resourceDriftStatus = value;
				}
			}

			public string StackId
			{
				get
				{
					return stackId;
				}
				set	
				{
					stackId = value;
				}
			}

			public string ResourceType
			{
				get
				{
					return resourceType;
				}
				set	
				{
					resourceType = value;
				}
			}

			public string PhysicalResourceId
			{
				get
				{
					return physicalResourceId;
				}
				set	
				{
					physicalResourceId = value;
				}
			}

			public string LogicalResourceId
			{
				get
				{
					return logicalResourceId;
				}
				set	
				{
					logicalResourceId = value;
				}
			}

			public string ActualProperties
			{
				get
				{
					return actualProperties;
				}
				set	
				{
					actualProperties = value;
				}
			}

			public string ExpectedProperties
			{
				get
				{
					return expectedProperties;
				}
				set	
				{
					expectedProperties = value;
				}
			}

			public List<ListStackResourceDrifts_PropertyDifference> PropertyDifferences
			{
				get
				{
					return propertyDifferences;
				}
				set	
				{
					propertyDifferences = value;
				}
			}

			public class ListStackResourceDrifts_PropertyDifference
			{

				private string propertyPath;

				private string actualValue;

				private string expectedValue;

				private string differenceType;

				public string PropertyPath
				{
					get
					{
						return propertyPath;
					}
					set	
					{
						propertyPath = value;
					}
				}

				public string ActualValue
				{
					get
					{
						return actualValue;
					}
					set	
					{
						actualValue = value;
					}
				}

				public string ExpectedValue
				{
					get
					{
						return expectedValue;
					}
					set	
					{
						expectedValue = value;
					}
				}

				public string DifferenceType
				{
					get
					{
						return differenceType;
					}
					set	
					{
						differenceType = value;
					}
				}
			}
		}
	}
}
