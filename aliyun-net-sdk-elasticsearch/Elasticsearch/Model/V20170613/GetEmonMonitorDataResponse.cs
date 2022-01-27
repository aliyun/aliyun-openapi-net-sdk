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
	public class GetEmonMonitorDataResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private bool? success;

		private List<GetEmonMonitorData_ResultItem> result;

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

		public List<GetEmonMonitorData_ResultItem> Result
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

		public class GetEmonMonitorData_ResultItem
		{

			private string dps;

			private float? integrity;

			private long? messageWatermark;

			private string metric;

			private float? summary;

			private string tags;

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

			public float? Integrity
			{
				get
				{
					return integrity;
				}
				set	
				{
					integrity = value;
				}
			}

			public long? MessageWatermark
			{
				get
				{
					return messageWatermark;
				}
				set	
				{
					messageWatermark = value;
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
