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

namespace Aliyun.Acs.Ess.Model.V20140828
{
	public class DescribeLimitationResponse : AcsResponse
	{

		private int? maxNumberOfScalingGroups;

		private int? maxNumberOfScalingConfigurations;

		private int? maxNumberOfScalingRules;

		private int? maxNumberOfScheduledTasks;

		private int? maxNumberOfScalingInstances;

		private int? maxNumberOfDBInstances;

		private int? maxNumberOfLoadBalancers;

		private int? maxNumberOfMinSize;

		private int? maxNumberOfMaxSize;

		private int? maxNumberOfVServerGroups;

		private int? maxNumberOfLifecycleHooks;

		private int? maxNumberOfNotificationConfigurations;

		public int? MaxNumberOfScalingGroups
		{
			get
			{
				return maxNumberOfScalingGroups;
			}
			set	
			{
				maxNumberOfScalingGroups = value;
			}
		}

		public int? MaxNumberOfScalingConfigurations
		{
			get
			{
				return maxNumberOfScalingConfigurations;
			}
			set	
			{
				maxNumberOfScalingConfigurations = value;
			}
		}

		public int? MaxNumberOfScalingRules
		{
			get
			{
				return maxNumberOfScalingRules;
			}
			set	
			{
				maxNumberOfScalingRules = value;
			}
		}

		public int? MaxNumberOfScheduledTasks
		{
			get
			{
				return maxNumberOfScheduledTasks;
			}
			set	
			{
				maxNumberOfScheduledTasks = value;
			}
		}

		public int? MaxNumberOfScalingInstances
		{
			get
			{
				return maxNumberOfScalingInstances;
			}
			set	
			{
				maxNumberOfScalingInstances = value;
			}
		}

		public int? MaxNumberOfDBInstances
		{
			get
			{
				return maxNumberOfDBInstances;
			}
			set	
			{
				maxNumberOfDBInstances = value;
			}
		}

		public int? MaxNumberOfLoadBalancers
		{
			get
			{
				return maxNumberOfLoadBalancers;
			}
			set	
			{
				maxNumberOfLoadBalancers = value;
			}
		}

		public int? MaxNumberOfMinSize
		{
			get
			{
				return maxNumberOfMinSize;
			}
			set	
			{
				maxNumberOfMinSize = value;
			}
		}

		public int? MaxNumberOfMaxSize
		{
			get
			{
				return maxNumberOfMaxSize;
			}
			set	
			{
				maxNumberOfMaxSize = value;
			}
		}

		public int? MaxNumberOfVServerGroups
		{
			get
			{
				return maxNumberOfVServerGroups;
			}
			set	
			{
				maxNumberOfVServerGroups = value;
			}
		}

		public int? MaxNumberOfLifecycleHooks
		{
			get
			{
				return maxNumberOfLifecycleHooks;
			}
			set	
			{
				maxNumberOfLifecycleHooks = value;
			}
		}

		public int? MaxNumberOfNotificationConfigurations
		{
			get
			{
				return maxNumberOfNotificationConfigurations;
			}
			set	
			{
				maxNumberOfNotificationConfigurations = value;
			}
		}
	}
}
