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

namespace Aliyun.Acs.Cms.Model.V20180308
{
	public class QueryMetricMetaResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string errorCode;

		private string errorMessage;

		private List<QueryMetricMeta_Resource> resources;

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

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public string ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
			}
		}

		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
			}
		}

		public List<QueryMetricMeta_Resource> Resources
		{
			get
			{
				return resources;
			}
			set	
			{
				resources = value;
			}
		}

		public class QueryMetricMeta_Resource
		{

			private string project;

			private string metric;

			private string statistics;

			private string unit;

			private string description;

			private string dimensions;

			private string periods;

			private string labels;

			public string Project
			{
				get
				{
					return project;
				}
				set	
				{
					project = value;
				}
			}

			public string Metric
			{
				get
				{
					return metric;
				}
				set	
				{
					metric = value;
				}
			}

			public string Statistics
			{
				get
				{
					return statistics;
				}
				set	
				{
					statistics = value;
				}
			}

			public string Unit
			{
				get
				{
					return unit;
				}
				set	
				{
					unit = value;
				}
			}

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}

			public string Dimensions
			{
				get
				{
					return dimensions;
				}
				set	
				{
					dimensions = value;
				}
			}

			public string Periods
			{
				get
				{
					return periods;
				}
				set	
				{
					periods = value;
				}
			}

			public string Labels
			{
				get
				{
					return labels;
				}
				set	
				{
					labels = value;
				}
			}
		}
	}
}
