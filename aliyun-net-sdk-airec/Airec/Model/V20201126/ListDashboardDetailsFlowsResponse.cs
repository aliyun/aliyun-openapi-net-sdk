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

namespace Aliyun.Acs.Airec.Model.V20201126
{
	public class ListDashboardDetailsFlowsResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private ListDashboardDetailsFlows_Result result;

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

		public string Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

		public ListDashboardDetailsFlows_Result Result
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

		public class ListDashboardDetailsFlows_Result
		{

			private string metricType;

			private List<ListDashboardDetailsFlows_MetricDataItem> metricData;

			public string MetricType
			{
				get
				{
					return metricType;
				}
				set	
				{
					metricType = value;
				}
			}

			public List<ListDashboardDetailsFlows_MetricDataItem> MetricData
			{
				get
				{
					return metricData;
				}
				set	
				{
					metricData = value;
				}
			}

			public class ListDashboardDetailsFlows_MetricDataItem
			{

				private string metricRes;

				private string sceneId;

				private string traceId;

				public string MetricRes
				{
					get
					{
						return metricRes;
					}
					set	
					{
						metricRes = value;
					}
				}

				public string SceneId
				{
					get
					{
						return sceneId;
					}
					set	
					{
						sceneId = value;
					}
				}

				public string TraceId
				{
					get
					{
						return traceId;
					}
					set	
					{
						traceId = value;
					}
				}
			}
		}
	}
}
