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

namespace Aliyun.Acs.cloud_siem.Model.V20220616
{
	public class GetHistogramsResponse : AcsResponse
	{

		private bool? success;

		private int? code;

		private string message;

		private string errCode;

		private string requestId;

		private string dyCode;

		private string dyMessage;

		private GetHistograms_Data data;

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

		public string ErrCode
		{
			get
			{
				return errCode;
			}
			set	
			{
				errCode = value;
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

		public string DyCode
		{
			get
			{
				return dyCode;
			}
			set	
			{
				dyCode = value;
			}
		}

		public string DyMessage
		{
			get
			{
				return dyMessage;
			}
			set	
			{
				dyMessage = value;
			}
		}

		public GetHistograms_Data Data
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

		public class GetHistograms_Data
		{

			private string server;

			private long? totalCount;

			private List<GetHistograms_Histogram> histograms;

			public string Server
			{
				get
				{
					return server;
				}
				set	
				{
					server = value;
				}
			}

			public long? TotalCount
			{
				get
				{
					return totalCount;
				}
				set	
				{
					totalCount = value;
				}
			}

			public List<GetHistograms_Histogram> Histograms
			{
				get
				{
					return histograms;
				}
				set	
				{
					histograms = value;
				}
			}

			public class GetHistograms_Histogram
			{

				private int? from;

				private int? to;

				private long? count;

				private bool? completedOrNot;

				public int? From
				{
					get
					{
						return from;
					}
					set	
					{
						from = value;
					}
				}

				public int? To
				{
					get
					{
						return to;
					}
					set	
					{
						to = value;
					}
				}

				public long? Count
				{
					get
					{
						return count;
					}
					set	
					{
						count = value;
					}
				}

				public bool? CompletedOrNot
				{
					get
					{
						return completedOrNot;
					}
					set	
					{
						completedOrNot = value;
					}
				}
			}
		}
	}
}
