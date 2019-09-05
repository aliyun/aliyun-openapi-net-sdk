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

namespace Aliyun.Acs.foas.Model.V20181111
{
	public class GetClusterMetricsResponse : AcsResponse
	{

		private string requestId;

		private List<GetClusterMetrics_Metric> metrics;

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

		public List<GetClusterMetrics_Metric> Metrics
		{
			get
			{
				return metrics;
			}
			set	
			{
				metrics = value;
			}
		}

		public class GetClusterMetrics_Metric
		{

			private string metricName;

			private string dps;

			private float? summary;

			private string tags;

			public string MetricName
			{
				get
				{
					return metricName;
				}
				set	
				{
					metricName = value;
				}
			}

			public string Dps
			{
				get
				{
					return dps;
				}
				set	
				{
					dps = value;
				}
			}

			public float? Summary
			{
				get
				{
					return summary;
				}
				set	
				{
					summary = value;
				}
			}

			public string Tags
			{
				get
				{
					return tags;
				}
				set	
				{
					tags = value;
				}
			}
		}
	}
}
