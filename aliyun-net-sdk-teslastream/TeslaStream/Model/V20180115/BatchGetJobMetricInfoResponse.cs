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

namespace Aliyun.Acs.TeslaStream.Model.V20180115
{
	public class BatchGetJobMetricInfoResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private List<BatchGetJobMetricInfo_Job> data;

		public int? Code
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

		public List<BatchGetJobMetricInfo_Job> Data
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

		public class BatchGetJobMetricInfo_Job
		{

			private int? delay;

			private int? tpsOut;

			private int? memRequest;

			private string jobUniqKey;

			private float? memUsed;

			private float? cpuUsed;

			private int? cpuRequest;

			private string nickname;

			private int? tpsIn;

			private string priority;

			public int? Delay
			{
				get
				{
					return delay;
				}
				set	
				{
					delay = value;
				}
			}

			public int? TpsOut
			{
				get
				{
					return tpsOut;
				}
				set	
				{
					tpsOut = value;
				}
			}

			public int? MemRequest
			{
				get
				{
					return memRequest;
				}
				set	
				{
					memRequest = value;
				}
			}

			public string JobUniqKey
			{
				get
				{
					return jobUniqKey;
				}
				set	
				{
					jobUniqKey = value;
				}
			}

			public float? MemUsed
			{
				get
				{
					return memUsed;
				}
				set	
				{
					memUsed = value;
				}
			}

			public float? CpuUsed
			{
				get
				{
					return cpuUsed;
				}
				set	
				{
					cpuUsed = value;
				}
			}

			public int? CpuRequest
			{
				get
				{
					return cpuRequest;
				}
				set	
				{
					cpuRequest = value;
				}
			}

			public string Nickname
			{
				get
				{
					return nickname;
				}
				set	
				{
					nickname = value;
				}
			}

			public int? TpsIn
			{
				get
				{
					return tpsIn;
				}
				set	
				{
					tpsIn = value;
				}
			}

			public string Priority
			{
				get
				{
					return priority;
				}
				set	
				{
					priority = value;
				}
			}
		}
	}
}