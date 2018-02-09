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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.EHPC.Model.V20170714
{
	public class GetAutoScaleConfigResponse : AcsResponse
	{

		private string requestId;

		private string uid;

		private string clusterId;

		private string clusterType;

		private bool? enableAutoGrow;

		private bool? enableAutoShrink;

		private int? growIntervalInMinutes;

		private int? shrinkIntervalInMinutes;

		private int? shrinkIdleTimes;

		private int? growTimeoutInMinutes;

		private int? extraNodesGrowRatio;

		private int? growRatio;

		private int? maxNodesInCluster;

		private string excludeNodes;

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

		public string Uid
		{
			get
			{
				return uid;
			}
			set	
			{
				uid = value;
			}
		}

		public string ClusterId
		{
			get
			{
				return clusterId;
			}
			set	
			{
				clusterId = value;
			}
		}

		public string ClusterType
		{
			get
			{
				return clusterType;
			}
			set	
			{
				clusterType = value;
			}
		}

		public bool? EnableAutoGrow
		{
			get
			{
				return enableAutoGrow;
			}
			set	
			{
				enableAutoGrow = value;
			}
		}

		public bool? EnableAutoShrink
		{
			get
			{
				return enableAutoShrink;
			}
			set	
			{
				enableAutoShrink = value;
			}
		}

		public int? GrowIntervalInMinutes
		{
			get
			{
				return growIntervalInMinutes;
			}
			set	
			{
				growIntervalInMinutes = value;
			}
		}

		public int? ShrinkIntervalInMinutes
		{
			get
			{
				return shrinkIntervalInMinutes;
			}
			set	
			{
				shrinkIntervalInMinutes = value;
			}
		}

		public int? ShrinkIdleTimes
		{
			get
			{
				return shrinkIdleTimes;
			}
			set	
			{
				shrinkIdleTimes = value;
			}
		}

		public int? GrowTimeoutInMinutes
		{
			get
			{
				return growTimeoutInMinutes;
			}
			set	
			{
				growTimeoutInMinutes = value;
			}
		}

		public int? ExtraNodesGrowRatio
		{
			get
			{
				return extraNodesGrowRatio;
			}
			set	
			{
				extraNodesGrowRatio = value;
			}
		}

		public int? GrowRatio
		{
			get
			{
				return growRatio;
			}
			set	
			{
				growRatio = value;
			}
		}

		public int? MaxNodesInCluster
		{
			get
			{
				return maxNodesInCluster;
			}
			set	
			{
				maxNodesInCluster = value;
			}
		}

		public string ExcludeNodes
		{
			get
			{
				return excludeNodes;
			}
			set	
			{
				excludeNodes = value;
			}
		}
	}
}