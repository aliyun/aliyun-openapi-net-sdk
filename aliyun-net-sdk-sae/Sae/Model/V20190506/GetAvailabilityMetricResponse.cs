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

namespace Aliyun.Acs.sae.Model.V20190506
{
	public class GetAvailabilityMetricResponse : AcsResponse
	{

		private string message;

		private string requestId;

		private string code;

		private bool? success;

		private List<GetAvailabilityMetric_AvailabilityMetricDto> data;

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

		public List<GetAvailabilityMetric_AvailabilityMetricDto> Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class GetAvailabilityMetric_AvailabilityMetricDto
		{

			private string appId;

			private string name;

			private string regionId;

			private long? runnings;

			private long? instances;

			private long? errorInstances;

			private long? enableAutoscale;

			public string AppId
			{
				get
				{
					return appId;
				}
				set	
				{
					appId = value;
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

			public string RegionId
			{
				get
				{
					return regionId;
				}
				set	
				{
					regionId = value;
				}
			}

			public long? Runnings
			{
				get
				{
					return runnings;
				}
				set	
				{
					runnings = value;
				}
			}

			public long? Instances
			{
				get
				{
					return instances;
				}
				set	
				{
					instances = value;
				}
			}

			public long? ErrorInstances
			{
				get
				{
					return errorInstances;
				}
				set	
				{
					errorInstances = value;
				}
			}

			public long? EnableAutoscale
			{
				get
				{
					return enableAutoscale;
				}
				set	
				{
					enableAutoscale = value;
				}
			}
		}
	}
}
